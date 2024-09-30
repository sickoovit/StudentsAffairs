namespace Admins.Client.Components
{
    public partial class AddNewAdminForm
    {
        [Inject] private IAdminRepository? AdminRepo { get; set; }

        private Admin newAdmin = new();

        private async Task HandleValidSubmit()
        {
            await AdminRepo.AddAdminAsync(newAdmin);
            newAdmin = new Admin();
        }
    }
}