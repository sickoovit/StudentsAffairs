using Lectures.Client.Managers;

namespace Lectures.Client.Components;

public partial class ViewLectureTable
{
	[Inject]
	private ILecturesManager LecturesManager { get; set; }
	private IEnumerable<Lecture> LecturesList = [];

	protected async override Task OnInitializedAsync()
	{
		LecturesList = await LecturesManager.GetLectures();
		await base.OnInitializedAsync();
	}
}