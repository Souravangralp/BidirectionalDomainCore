namespace Bidirectional.DomainCore.BidOnboard.Permission
{
    /// <summary>
    /// Represents an access policy that defines permission rules for entities and user groups within the system.
    /// </summary>
    public class EntityAccessPolicy : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the name of the policy, such as "BranchAccessPolicy" or "CompanyAccessPolicy".
        /// </summary>
        public string? PolicyName { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity to which this policy applies, such as "LoanApplication" or "User".
        /// </summary>
        public string? EntityName { get; set; }

        /// <summary>
        /// Gets or sets the name of the property used in the access rule, such as "BranchID" or "CompanyID".
        /// </summary>
        [TextClass(TextFieldClass.EntityAccessPolicyToken)]
        public string? PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the comparison operator used in the policy, such as "Equals", "In", or "Contains".
        /// </summary>
        [TextClass(TextFieldClass.EntityAccessPolicyToken)]
        public string? ComparisonOperator { get; set; }

        /// <summary>
        /// Gets or sets the source of the value to compare against, which may refer to a user property, claim, or static value (e.g., "User:BranchID", "Claim:CompanyID", or "123").
        /// </summary>
        [TextClass(TextFieldClass.EntityAccessPolicyToken)]
        public string? ValueSource { get; set; }

        /// <summary>
        /// Gets or sets the type of access permitted by the policy, such as "Read" or "Write".
        /// </summary>
        [TextClass(TextFieldClass.EntityAccessPolicyToken)]
        public string? AccessType { get; set; }

        /// <summary>
        /// Gets or sets an optional group identifier for combining conditions (e.g., for OR groupings).
        /// </summary>
        [TextClass(TextFieldClass.EntityAccessPolicyToken)]
        public string? ConditionGroup { get; set; }

        /// <summary>
        /// Gets or sets the collection of mappings between this access policy and user groups.
        /// </summary>
        public List<EntityAccessPolicyGroupMapper> EntityAccessPolicyGroupMapper { get; set; } = [];
    }
}
