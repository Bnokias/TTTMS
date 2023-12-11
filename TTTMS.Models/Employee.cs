namespace TTTMS.Models
{
    public class Employee(int id, string email, string firstName, string lastName, string jobTitle, string department)
    {
        public int Id { get; set; } = id;

        public string Email { get; set; } = email;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public string JobTitle { get; set; } = jobTitle;
        public string Department { get; set; } = department;
        public string AssignedGroup { get; set; }
    }

}
