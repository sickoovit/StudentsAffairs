
namespace StudentsAffairsWASM.Auto.Client.Managers
{
	public interface IManageEntitiesManager
	{
		Task<AllEntitiesDTO> GetAllEntities();
	}
}