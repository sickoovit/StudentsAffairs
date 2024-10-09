namespace Tutors.Client.Components
{
	public partial class AddNewTutorForm
	{
		[Inject] private ITutorRepository? TutorRepo { get; set; }
		private Tutor newTutor = new();

		private async Task HandleValidSubmit()
		{
			await TutorRepo.AddAsync(newTutor);
			newTutor = new Tutor();
		}
	}
}