using Bidirectional.DomainCore.Postcode.Entities.Generals;

namespace Bidirectional.DomainCore.Common
{
    public class LookupValueRelation : BaseAuditableEntity
    {
        public int? ParentID { get; set; }

        public int? ChildID { get; set; }

        public GeneralLookup? Parent { get; set; }

        public GeneralLookup? Child { get; set; }
    }

}
