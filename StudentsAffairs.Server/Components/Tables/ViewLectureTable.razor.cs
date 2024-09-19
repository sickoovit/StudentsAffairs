using StudentsAffairs.Server.Entities;

namespace StudentsAffairs.Server.Components.Tables;

public partial class ViewLectureTable
{
    [Parameter]
    public IEnumerable<Lecture> Lectures { get; set; }
}