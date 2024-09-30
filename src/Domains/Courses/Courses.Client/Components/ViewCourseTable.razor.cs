namespace Courses.Client.Components;

public partial class ViewCourseTable
{
    [Parameter]
    public IEnumerable<Course> Courses { get; set; }
}