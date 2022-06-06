namespace DesignPatterns
{
    public class Person : IPersonModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeLevel Level { get; private set; }       

        public void SetEmployeeLevel(EmployeeLevel level)
        {
            Level = level;
        }
    }
}