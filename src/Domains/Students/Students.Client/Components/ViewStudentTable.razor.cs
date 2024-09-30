namespace Students.Client.Components
{
	public partial class ViewStudentTable
	{
		[Parameter]
		public IEnumerable<Student>? StudentsList { get; set; }
	}
}