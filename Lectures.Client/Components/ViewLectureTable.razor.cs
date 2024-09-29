namespace Lectures.Client.Components;

public partial class ViewLectureTable
{
    [Parameter]
    public IEnumerable<Lecture> LecturesList { get; set; }
}