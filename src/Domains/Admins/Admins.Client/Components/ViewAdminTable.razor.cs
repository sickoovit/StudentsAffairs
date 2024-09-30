namespace Admins.Client.Components
{
	public partial class ViewAdminTable
	{
		[Parameter]
		public IEnumerable<Admin>? AdminsList { get; set; }
	}
}