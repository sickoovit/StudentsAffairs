namespace StudentsAffairsWASM.Auto.Client.Components;

public partial class ViewUserTable
{
    [Parameter]
    public UsersDTO UsersList { get; set; }

    [Parameter]
    public string selectedRole { get; set; }
}