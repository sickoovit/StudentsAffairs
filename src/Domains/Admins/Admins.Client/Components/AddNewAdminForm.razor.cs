namespace Admins.Client.Components
{
    public partial class AddNewAdminForm
    {
        [Inject] private IAdminRepository? AdminRepo { get; set; }

        private Admin newAdmin = new();

        private async Task HandleValidSubmit()
        {
            await AdminRepo.AddAsync(newAdmin);
            newAdmin = new Admin();
        }
    }
}