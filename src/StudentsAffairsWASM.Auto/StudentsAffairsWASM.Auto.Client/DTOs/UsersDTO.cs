namespace StudentsAffairsWASM.Auto.Client.DTOs
{
	public class UsersDTO
	{
		public IEnumerable<Student> Students { get; set; }
		public IEnumerable<Admin> Admins { get; set; }
		public IEnumerable<Tutor> Tutors { get; set; }
	}
}
