namespace StudentsAffairs.Server.Components.Pages;

public partial class ManageEntities
{
bool studentFormActive;
bool courseFormActive;
bool lectureFormActive;
bool assignmentFormActive;

private void ShowStudentForm()
{
	studentFormActive = true;
	courseFormActive = false;
	lectureFormActive = false;
	assignmentFormActive = false;
	StateHasChanged();
}

private void ShowCourseForm()
{
	studentFormActive = false;
	courseFormActive = true;
	lectureFormActive = false;
	assignmentFormActive = false;
	StateHasChanged();
}

private void ShowLectureForm()
{
	studentFormActive = false;
	courseFormActive = false;
	lectureFormActive = true;
	assignmentFormActive = false;
	StateHasChanged();
}

private void ShowAssignmentForm()
{
	studentFormActive = false;
	courseFormActive = false;
	lectureFormActive = false;
	assignmentFormActive = true;
	StateHasChanged();
}

}