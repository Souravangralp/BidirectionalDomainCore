namespace Bidirectional.DomainCore.BidOnboard.Application.Common.Models;

public class GetEntityNotificationDto
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? UserGroupName { get; set; }

    public string? ParentOrganizationName { get; set; }

    public string? OrganizationName { get; set; }

    public string? ParentBusinessUnitName { get; set; }

    public string? ChildOrganizationName { get; set; }

    public string? ChildBusinessUnitName { get; set; }

    public string? ChildBusinessUnitManagerName { get; set; }

    public string? ChildOrganizationManagerName { get; set; }

    public string? ChildOrganizationType { get; set; }

    public string? ChildBusinessUnitType { get; set; }

    public string? BusinessUnitName { get; set; }

    public string? DisplayStatusName { get; set; }

    public string? EmailTemplateID { get; set; }

    public string? NotificationSetting { get; set; }

    public string? Email { get; set; }

    public string? @ChildUserGroupName { get; set; }
}
