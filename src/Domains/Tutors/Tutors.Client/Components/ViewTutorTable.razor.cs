namespace Tutors.Client.Components
{
	public partial class ViewTutorTable
	{
		[Parameter]
		public IEnumerable<Tutor>? TutorsList { get; set; }
	}
}