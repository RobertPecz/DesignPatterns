namespace DesignPatterns
{
    public class Person : IPersonModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = "";
        public EmployeeLevel Level { get; private set; }       

        public Person(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public void SetEmployeeLevel(EmployeeLevel level)
        {
            Level = level;
        }
    }
}