namespace DesignPatterns
{
    public class Person : IPersonModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeLevel Level { get; private set; }       

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void SetEmployeeLevel(EmployeeLevel level)
        {
            Level = level;
        }
    }
}