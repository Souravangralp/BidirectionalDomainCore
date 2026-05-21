using System.Runtime.CompilerServices;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Helpers;

[ExcludeFromCodeCoverage]
public static class HierarchyQueries
{
    public static FormattableString BuildOrganizationHierarchyIsActiveQuery(int organizationID)
    {
        return $@"
                  WITH RecursiveOrg AS (    
                    SELECT 
                        Id, 
                        ParentOrganizationID,
                        Name, 
                        IsActive,
                        CAST('Current' AS NVARCHAR(20)) AS RelationType
                    FROM Organizations
                    WHERE Id = {organizationID}

                    UNION ALL
	                
                    SELECT 
                        o.Id, 
                        o.ParentOrganizationID,
                        o.Name,            
                        o.IsActive,
                        CAST('Parent' AS NVARCHAR(20)) AS RelationType
                    FROM Organizations o
                    INNER JOIN RecursiveOrg h ON h.ParentOrganizationID = o.Id
                    )
                    SELECT 
                        'Organization' AS EntityType,
                        Id,
                        Name,
                        IsActive,
                        RelationType AS ParentOrCurrent
                    FROM RecursiveOrg
                    WHERE IsActive = 0;";
    }

    public static FormattableString BuildBusinessUnitHierarchyIsActiveQuery(int businessUnitID)
    {
        return $@"WITH RecursiveBU AS (
                 -- Anchor member
                 SELECT 
                     Id, 
                     ParentBusinessUnitID, 
                     BusinessUnit_OrganizationID, 
                     Name, 
                     IsActive,
                     CAST('Current' AS NVARCHAR(20)) AS RelationType
                 FROM BusinessUnits 
                 WHERE Id = {businessUnitID}  -- target BusinessUnit

                 UNION ALL

                 -- Recursive member
                 SELECT 
                     bu.Id, 
                     bu.ParentBusinessUnitID, 
                     bu.BusinessUnit_OrganizationID, 
                     bu.Name, 
                     bu.IsActive,
                     CAST('Parent' AS NVARCHAR(20)) AS RelationType
                 FROM BusinessUnits bu
                 INNER JOIN RecursiveBU rbu ON rbu.ParentBusinessUnitID = bu.Id
                ),
                RecursiveOrg AS (
                    -- Anchor member
                    SELECT 
                        Id, 
                        ParentOrganizationID, 
                        Name, 
                        IsActive,
                        CAST('Current' AS NVARCHAR(20)) AS RelationType
                    FROM Organizations 
                    WHERE Id = (SELECT TOP 1 BusinessUnit_OrganizationID FROM RecursiveBU)
                
                    UNION ALL
                
                    -- Recursive member
                    SELECT 
                        o.Id, 
                        o.ParentOrganizationID, 
                        o.Name, 
                        o.IsActive,
                        CAST('Parent' AS NVARCHAR(20)) AS RelationType
                    FROM Organizations o
                    INNER JOIN RecursiveOrg ro ON ro.ParentOrganizationID = o.Id
                )
                SELECT 
                    'BusinessUnit' AS EntityType,
                    Id,
                    Name,
                    IsActive,
                    RelationType AS ParentOrCurrent
                FROM RecursiveBU
                WHERE IsActive = 0
                
                UNION ALL
                
                SELECT 
                    'Organization' AS EntityType,
                    Id,
                    Name,
                    IsActive,
                    RelationType AS ParentOrCurrent
                FROM RecursiveOrg
                WHERE IsActive = 0;";
    }

    public static FormattableString BuildUserForUserHerarchyQuery(int? userID, int? onboardingStageID)
    {
        string sql = $@"
                SELECT DISTINCT
                    u.ID AS UserID,
                    u.FirstName,
                    u.LastName,
                    e.Email AS EmailAddress,
                    ug.GroupName AS UserGroupName,
                    nt.TwilioTemplateID
                FROM Users u
                INNER JOIN OrganizationBusinessUnitGroupUserMapper obugum
                    ON obugum.UserID = u.ID
                INNER JOIN OrganizationBusinessUnitGroupMapper ogm
                    ON ogm.ID = obugum.OrganizationGroupMapperID
                INNER JOIN UserGroups ug
                    ON ug.ID = ogm.OrganizationBusinessUnitGroupMapper_UserGroupID
                LEFT JOIN EmailDetails e
                    ON e.EmailDetail_UserID = u.ID
                   AND e.ISPrimary = 1
                CROSS APPLY (
                    SELECT et.TwilioTemplateID
                    FROM OnboardingNotificationSettings ons
                    INNER JOIN EmailTemplates et
                        ON et.ID = ons.OnboardingNotificationSetting_EmailTemplateID
                    WHERE ons.OnboardingNotificationSetting_OnboardingStageID = {onboardingStageID}
                        AND ons.ISReversionNotification = 0
                ) nt
                WHERE u.ID = {userID}
            ";

        return FormattableStringFactory.Create(sql, Array.Empty<object>());
    }

    public static FormattableString BuildRecipientForUserHerarchyQuery(int? organizationID, int? businessUnitID, int? onboardingStageID)
    {
        string sql = $@"
                WITH NotificationGroups AS (
                    SELECT
                        Trim(value) AS GroupName,
                        ons.OnboardingNotificationSetting_RecipientEmailTemplateID AS EmailTemplateID
                    FROM OnboardingNotificationSettings ons
                        CROSS APPLY STRING_SPLIT(ons.RecipientGroups, ',')
                    WHERE ons.OnboardingNotificationSetting_OnboardingStageID = {onboardingStageID}
                        AND ons.ISReversionNotification	= 0
                        AND TRIM(value) <> ''
                )
                SELECT DISTINCT
                    u.ID AS UserID,
                    u.FirstName,
                    u.LastName,
                    e.Email AS EmailAddress,
                    ng.GroupName AS UserGroupName,
                    et.TwilioTemplateID
                FROM NotificationGroups ng
                INNER JOIN EmailTemplates et
                    ON et.ID = ng.EmailTemplateID
                INNER JOIN UserGroups ug
                    ON ug.GroupName = ng.GroupName
                INNER JOIN OrganizationBusinessUnitGroupMapper ogm
                    ON ogm.OrganizationBusinessUnitGroupMapper_UserGroupID = ug.ID
                INNER JOIN OrganizationBusinessUnitGroupUserMapper obugum
                    ON obugum.OrganizationGroupMapperID = ogm.ID
                INNER JOIN Users u
                    ON u.ID = obugum.UserID
                LEFT JOIN EmailDetails e
                    ON e.EmailDetail_UserID = u.ID
                    AND e.ISPrimary = 1
                WHERE 1 = 1
            ";

        if (businessUnitID.HasValue)
        {
            sql += $@"
                AND ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID = {businessUnitID}
            ";
        }
        else if (organizationID.HasValue)
        {
            sql += $@"
                AND ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = {organizationID}
            ";
        }
        else
        {
            sql += " AND 1 = 0 ";
        }

        return FormattableStringFactory.Create(sql, Array.Empty<object>());
    }

    public static FormattableString BuildRecipientForEntityHerarchyQuery(
        int? organizationID,
        int? businessUnitID,
        int? onboardingStageID)
    {
        string sql = $@"
                WITH NotificationGroups AS (
	                SELECT
		                Trim(value) AS GroupName,
                        ons.OnboardingNotificationSetting_RecipientEmailTemplateID AS EmailTemplateID
	                FROM OnboardingNotificationSettings ons
		                CROSS APPLY STRING_SPLIT(ons.RecipientGroups, ',')
	                WHERE ons.OnboardingNotificationSetting_OnboardingStageID = {onboardingStageID}
		                AND ons.ISReversionNotification	= 0
		                AND TRIM(value) <> ''
                )
                SELECT DISTINCT
                    u.ID AS UserID,
                    u.FirstName,
                    u.LastName,
                    e.Email AS EmailAddress,
                    ng.GroupName AS UserGroupName,
	                et.TwilioTemplateID
                FROM NotificationGroups ng
                INNER JOIN EmailTemplates et
	                ON et.ID = ng.EmailTemplateID
                INNER JOIN UserGroups ug
                    ON ug.GroupName = ng.GroupName
                INNER JOIN OrganizationBusinessUnitGroupMapper ogm
                    ON ogm.OrganizationBusinessUnitGroupMapper_UserGroupID = ug.ID
                INNER JOIN OrganizationBusinessUnitGroupUserMapper obugum
                    ON obugum.OrganizationGroupMapperID = ogm.ID
                INNER JOIN Users u
                    ON u.ID = obugum.UserID
                LEFT JOIN EmailDetails e
                    ON e.EmailDetail_UserID = u.ID
                    AND e.ISPrimary = 1
                WHERE 1 = 1
            ";

        if (businessUnitID.HasValue)
        {
            string buOrgLookup = $"(SELECT TOP 1 BusinessUnit_OrganizationID FROM BusinessUnits WHERE Id = {businessUnitID.Value})";
            string buParentLookup = $"(SELECT TOP 1 ParentBusinessUnitID FROM BusinessUnits WHERE Id = {businessUnitID.Value})";

            sql += $@"
                  AND (
                        ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID = {buParentLookup}
                        OR ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = {buOrgLookup}
                      );";

            return FormattableStringFactory.Create(sql, Array.Empty<object>());
        }

        if (organizationID.HasValue)
        {
            string orgParentLookup = $"(SELECT TOP 1 ParentOrganizationID FROM Organizations WHERE Id = {organizationID.Value})";

            sql += $@"
                  AND ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = {orgParentLookup};";

            return FormattableStringFactory.Create(sql, Array.Empty<object>());
        }

        sql += " AND 1 = 0;";

        return FormattableStringFactory.Create(sql, Array.Empty<object>());
    }

    public static FormattableString BuildUserForEntityHerarchyQuery(
        int? organizationID,
        int? businessUnitID,
        int? onboardingStageID,
        List<string> groups)
    {
        string sql = $@"
                SELECT DISTINCT
                    u.ID AS UserID,
                    u.FirstName,
                    u.LastName,
                    e.Email AS EmailAddress,
                    ug.GroupName AS UserGroupName,
                    nt.TwilioTemplateID
                FROM Organizations o
                INNER JOIN OrganizationBusinessUnitGroupMapper ogm
                    ON ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = o.ID
                INNER JOIN OrganizationBusinessUnitGroupUserMapper obugum
                    ON obugum.OrganizationGroupMapperID = ogm.ID
                INNER JOIN Users u
                    ON u.ID = obugum.UserID
                LEFT JOIN EmailDetails e
                    ON e.EmailDetail_UserID = u.ID
                   AND e.ISPrimary = 1
                INNER JOIN UserGroups ug
                    ON ug.ID = ogm.OrganizationBusinessUnitGroupMapper_UserGroupID
                CROSS APPLY (
                    SELECT et.TwilioTemplateID
                    FROM OnboardingNotificationSettings ons
                    INNER JOIN EmailTemplates et
                        ON et.ID = ons.OnboardingNotificationSetting_EmailTemplateID
                    WHERE ons.OnboardingNotificationSetting_OnboardingStageID = {onboardingStageID}
                        AND ons.ISReversionNotification = 0
                ) nt
                WHERE 1 = 1
            ";

        if (groups != null && groups.Count > 0)
        {
            string csv = string.Join(",", groups);
            sql += $@"
                AND ug.GroupName IN (
                    SELECT LTRIM(RTRIM(value))
                    FROM STRING_SPLIT('{csv}', ',')
                )
            ";
        }

        if (businessUnitID.HasValue)
        {
            sql += $@"
                AND ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID = {businessUnitID}
            ";
        }
        else if (organizationID.HasValue)
        {
            sql += $@"
                AND ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = {organizationID}
            ";
        }
        else
        {
            sql += " AND 1 = 0 ";
        }

        return FormattableStringFactory.Create(sql, Array.Empty<object>());
    }

    public static FormattableString BuildUserForUserRevertStatusHerarchyQuery(int? userID, int? onboardingStageID)
    {
        string sql = $@"
                SELECT DISTINCT
                    u.ID AS UserID,
                    u.FirstName,
                    u.LastName,
                    e.Email AS EmailAddress,
                    ug.GroupName AS UserGroupName,
                    nt.TwilioTemplateID
                FROM Users u
                INNER JOIN OrganizationBusinessUnitGroupUserMapper obugum
                    ON obugum.UserID = u.ID
                INNER JOIN OrganizationBusinessUnitGroupMapper ogm
                    ON ogm.ID = obugum.OrganizationGroupMapperID
                INNER JOIN UserGroups ug
                    ON ug.ID = ogm.OrganizationBusinessUnitGroupMapper_UserGroupID
                LEFT JOIN EmailDetails e
                    ON e.EmailDetail_UserID = u.ID
                   AND e.ISPrimary = 1
                CROSS APPLY (
                    SELECT et.TwilioTemplateID
                    FROM OnboardingNotificationSettings ons
                    INNER JOIN EmailTemplates et
                        ON et.ID = ons.OnboardingNotificationSetting_EmailTemplateID
                    WHERE ons.OnboardingNotificationSetting_OnboardingStageID = {onboardingStageID}
                        AND ons.ISReversionNotification = 1
                ) nt
                WHERE u.ID = {userID}
            ";

        return FormattableStringFactory.Create(sql, Array.Empty<object>());
    }

    public static FormattableString BuildUserForEntityRevertStatusHerarchyQuery(int? organizationID, int? businessUnitID, int? onboardingStageID, List<string> groups)
    {
        string sql = $@"
                SELECT DISTINCT
                    u.ID AS UserID,
                    u.FirstName,
                    u.LastName,
                    e.Email AS EmailAddress,
                    ug.GroupName AS UserGroupName,
                    nt.TwilioTemplateID
                FROM Organizations o
                INNER JOIN OrganizationBusinessUnitGroupMapper ogm
                    ON ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = o.ID
                INNER JOIN OrganizationBusinessUnitGroupUserMapper obugum
                    ON obugum.OrganizationGroupMapperID = ogm.ID
                INNER JOIN Users u
                    ON u.ID = obugum.UserID
                LEFT JOIN EmailDetails e
                    ON e.EmailDetail_UserID = u.ID
                   AND e.ISPrimary = 1
                INNER JOIN UserGroups ug
                    ON ug.ID = ogm.OrganizationBusinessUnitGroupMapper_UserGroupID
                CROSS APPLY (
                    SELECT et.TwilioTemplateID
                    FROM OnboardingNotificationSettings ons
                    INNER JOIN EmailTemplates et
                        ON et.ID = ons.OnboardingNotificationSetting_EmailTemplateID
                    WHERE ons.OnboardingNotificationSetting_OnboardingStageID = {onboardingStageID}
                        AND ons.ISReversionNotification = 1
                ) nt
                WHERE 1 = 1
            ";

        if (groups != null && groups.Count > 0)
        {
            string csv = string.Join(",", groups);
            sql += $@"
                AND ug.GroupName IN (
                    SELECT LTRIM(RTRIM(value))
                    FROM STRING_SPLIT('{csv}', ',')
                )
            ";
        }

        if (businessUnitID.HasValue)
        {
            sql += $@"
                AND ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID = {businessUnitID}
            ";
        }
        else if (organizationID.HasValue)
        {
            sql += $@"
                AND ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = {organizationID}
            ";
        }
        else
        {
            sql += " AND 1 = 0 ";
        }

        return FormattableStringFactory.Create(sql, Array.Empty<object>());
    }

    /// <summary>
    /// Constructs a hierarchical SQL query that retrieves all business units and organizations associated with a user, including their group and user details.
    /// </summary>
    /// <param name="userID">The unique identifier of the user for whom to build the business unit and organization hierarchy query.</param>
    /// <returns>
    /// A <see cref="FormattableString"/> containing the SQL query for retrieving the user's business unit and organization hierarchy, including user and group information.
    /// </returns>
    public static FormattableString BuildUserBasedBusinessUnitHierarchyQuery(int userID)
    {
        return $@"WITH UserBU AS (
            SELECT 
                bu.Id AS BusinessUnitID,
                bu.ParentBusinessUnitID,
                bu.BusinessUnit_OrganizationID,
                bu.Name AS BusinessUnitName,
				ed.Email
                --bu.IsActive
            FROM Users u
            INNER JOIN EmailDetails ed ON ed.EmailDetail_UserID = u.Id
			INNER JOIN OrganizationBusinessUnitGroupUserMappers ubgm ON ubgm.UserID = u.Id
            INNER JOIN OrganizationBusinessUnitGroupMappers ogm ON ogm.Id = ubgm.OrganizationGroupMapperID
            INNER JOIN BusinessUnits bu ON bu.Id = ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID
            WHERE u.Id = {userID}
        ),
        RecursiveBU AS (
            SELECT 
                bu.Id,
                bu.ParentBusinessUnitID,
                bu.BusinessUnit_OrganizationID,
                bu.Name,
				u.Email,
                --bu.IsActive,
                CAST('Current' AS NVARCHAR(20)) AS RelationType,
				bu.BusinessType AS Type
            FROM BusinessUnits bu
            INNER JOIN UserBU u ON u.BusinessUnitID = bu.Id

            UNION ALL

            SELECT 
                parent.Id,
                parent.ParentBusinessUnitID,
                parent.BusinessUnit_OrganizationID,
                parent.Name,
				child.Email,
                --parent.IsActive,
                CAST('Parent' AS NVARCHAR(20)) AS RelationType,
				parent.BusinessType AS Type
            FROM BusinessUnits parent
            INNER JOIN RecursiveBU child ON child.ParentBusinessUnitID = parent.Id
        ),
        RecursiveOrg AS (
            SELECT 
                o.Id,
                o.ParentOrganizationID,
                o.Name,
                --o.IsActive,
                CAST('Current' AS NVARCHAR(20)) AS RelationType,
				o.OrganizationType AS Type
            FROM Organizations o
            WHERE o.Id IN (SELECT BusinessUnit_OrganizationID FROM RecursiveBU)

            UNION ALL

            SELECT 
                parent.Id,
                parent.ParentOrganizationID,
                parent.Name,
                --parent.IsActive,
                CAST('Parent' AS NVARCHAR(20)) AS RelationType,
				parent.OrganizationType AS Type
            FROM Organizations parent
            INNER JOIN RecursiveOrg child ON child.ParentOrganizationID = parent.Id
        )
        -- BUSINESS UNIT HIERARCHY WITH USERS
        SELECT 
            'BusinessUnit' AS EntityType,
            bu.Id AS EntityId,
			bu.Type,
            bu.Name,
            --bu.IsActive,
            bu.RelationType AS ParentOrCurrent,
            ug.Id AS UserGroupId,
            ug.GroupName AS UserGroupName,
            u.Id AS UserId,
            u.UniqueID AS UserUniqueID,
            (u.FirstName + ' ' + u.LastName) AS FullName,
			ed.Email
        FROM RecursiveBU bu
        LEFT JOIN OrganizationBusinessUnitGroupMappers ogm ON ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID = bu.Id
        LEFT JOIN UserGroups ug ON ug.Id = ogm.OrganizationBusinessUnitGroupMapper_UserGroupID
        LEFT JOIN OrganizationBusinessUnitGroupUserMappers obgum ON obgum.OrganizationGroupMapperID = ogm.Id
        LEFT JOIN Users u ON u.Id = obgum.UserID
		LEFT JOIN EmailDetails ed ON ed.EmailDetail_UserID = u.Id

        UNION ALL

        -- ORGANIZATION HIERARCHY WITH USERS
        SELECT 
            'Organization' AS EntityType,
            org.Id AS EntityId,
			org.Type,
            org.Name,
            --org.IsActive,
            org.RelationType AS ParentOrCurrent,
            ug.Id AS UserGroupId,
            ug.GroupName AS UserGroupName,
            u.Id AS UserId,
            u.UniqueID AS UserUniqueID,
            (u.FirstName + ' ' + u.LastName) AS FullName,
            ed.Email
        FROM RecursiveOrg org
        LEFT JOIN OrganizationBusinessUnitGroupMappers ogm ON ogm.OrganizationBusinessUnitGroupMapper_OrganizationID = org.Id
        LEFT JOIN UserGroups ug ON ug.Id = ogm.OrganizationBusinessUnitGroupMapper_UserGroupID
        LEFT JOIN OrganizationBusinessUnitGroupUserMappers obgum ON obgum.OrganizationGroupMapperID = ogm.Id
        LEFT JOIN Users u ON u.Id = obgum.UserID
		LEFT JOIN EmailDetails ed ON ed.EmailDetail_UserID = u.Id;";
    }

    /// <summary>
    /// Constructs a SQL query to retrieve lender organization IDs associated with the business units belonging to a specific user.
    /// </summary>
    /// <param name="userID">The unique identifier of the user whose related lender organization IDs will be retrieved.</param>
    /// <returns>
    /// A <see cref="FormattableString"/> containing the SQL query to fetch lender organization IDs linked to the given user's business units.
    /// </returns>
    public static FormattableString GetLenderIDWithUserIDQuery(int userID)
    {
        return $@"WITH UserBU AS(
    SELECT
        bu.Id AS BusinessUnitID,
        bu.ParentBusinessUnitID,
        bu.BusinessUnit_OrganizationID
    FROM Users u
    INNER JOIN OrganizationBusinessUnitGroupUserMappers ubgm ON ubgm.UserID = u.Id
    INNER JOIN OrganizationBusinessUnitGroupMappers ogm ON ogm.Id = ubgm.OrganizationGroupMapperID
    INNER JOIN BusinessUnits bu ON bu.Id = ogm.OrganizationBusinessUnitGroupMapper_BusinessUnitID
    WHERE u.Id = {userID}
         ),
         RecursiveBU AS(
             --current BU(s)
             SELECT
                 bu.Id,
                 bu.ParentBusinessUnitID,
                 bu.BusinessUnit_OrganizationID
             FROM BusinessUnits bu
             INNER JOIN UserBU u ON u.BusinessUnitID = bu.Id
         
             UNION ALL
         
             --parent BU(s)
             SELECT
                 parent.Id,
                 parent.ParentBusinessUnitID,
                 parent.BusinessUnit_OrganizationID
             FROM BusinessUnits parent
             INNER JOIN RecursiveBU child ON child.ParentBusinessUnitID = parent.Id
         ),
         RecursiveOrg AS(
             --current org(s)
             SELECT
                 o.Id,
                 o.ParentOrganizationID,
                 o.OrganizationType
             FROM Organizations o
             WHERE o.Id IN(SELECT BusinessUnit_OrganizationID FROM RecursiveBU)
         
             UNION ALL
         
             --parent org(s)
             SELECT
                 parent.Id,
                 parent.ParentOrganizationID,
                 parent.OrganizationType
             FROM Organizations parent
             INNER JOIN RecursiveOrg child ON child.ParentOrganizationID = parent.Id
         )
         SELECT DISTINCT
             Id AS LenderOrganizationID
         FROM RecursiveOrg
         WHERE OrganizationType = 'Lender'; ";
    }
}
