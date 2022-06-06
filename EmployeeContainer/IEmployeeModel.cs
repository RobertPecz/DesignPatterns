namespace DesignPatterns
{
    public interface IEmployeeModel : IEmployeeLevelModel
    {
        public string FirstName { get; set; }
        public string LastName {get; set; }  
        public string Email { get; set; }
    }
}