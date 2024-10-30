using Admins.Client.Managers;

namespace Admins.Client.Components
{
	public partial class ViewAdminTable
	{
		[Inject]
		private IAdminsManager AdminsManager { get; set; }
		private IEnumerable<Admin> AdminsList = [];

		protected async override Task OnInitializedAsync()
		{
			AdminsList = await AdminsManager.GetAdmins();
			await base.OnInitializedAsync();
		}
	}
}