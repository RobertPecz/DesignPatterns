namespace DesignPatterns
{
    public interface IPersonModel : IEmployeeLevelModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set;}
             
    }
}