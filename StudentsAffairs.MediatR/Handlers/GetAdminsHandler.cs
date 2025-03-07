namespace StudentsAffairs.MediatR.Handlers
{
    public class GetAdminsHandler : IRequestHandler<GetAdminsQuery, IEnumerable<Admin>>
    {
        private readonly IAdminRepository _adminRepository;

        public GetAdminsHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<IEnumerable<Admin>> Handle(GetAdminsQuery request, CancellationToken cancellationToken)
        {
            return _adminRepository.GetAllAsync();
        }
    }
}
