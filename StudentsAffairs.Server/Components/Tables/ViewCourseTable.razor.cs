using System.Reflection.Metadata;


namespace StudentsAffairs.Server.Components.Tables;

public partial class ViewCourseTable
{
    [Parameter]
    public IEnumerable<Course> Courses { get; set; }
}