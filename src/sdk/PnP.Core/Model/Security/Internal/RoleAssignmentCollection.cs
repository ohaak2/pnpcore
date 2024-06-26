using PnP.Core.QueryModel;
using PnP.Core.Services;

namespace PnP.Core.Model.Security
{
    internal sealed class RoleAssignmentCollection : QueryableDataModelCollection<IRoleAssignment>, IRoleAssignmentCollection
    {
        public RoleAssignmentCollection(PnPContext context, IDataModelParent parent, string memberName = null) : base(context, parent, memberName)
        {
            PnPContext = context;
            Parent = parent;
        }
    }
}
