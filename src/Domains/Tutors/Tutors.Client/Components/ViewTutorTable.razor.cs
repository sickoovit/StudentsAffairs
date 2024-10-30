using Tutors.Client.Managers;

namespace Tutors.Client.Components;

public partial class ViewTutorTable
{
	[Inject]
	private ITutorsManager _tutorsManager { get; set; }
	private IEnumerable<Tutor> TutorsList = [];

	protected async override Task OnInitializedAsync()
	{
		TutorsList = await _tutorsManager.GetTutors();
		await base.OnInitializedAsync();
	}
}