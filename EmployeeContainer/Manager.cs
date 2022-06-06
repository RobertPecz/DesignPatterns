namespace DesignPatterns
{
    public class Manager : IEmployeeModel
    {
        public string FirstName { get; set ; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EmployeeLevel Level { get; private set; }

        public void SetEmployeeLevel(EmployeeLevel level)
        {
            Level = level;
        }
    }
}