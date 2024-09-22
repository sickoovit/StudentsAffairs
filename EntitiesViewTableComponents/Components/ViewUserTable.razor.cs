

namespace StudentsAffairs.Server.Components.Tables;

public partial class ViewUserTable
{
    [Parameter]
    public IEnumerable<User>? Users { get; set; }
}