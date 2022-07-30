namespace DesignPatterns
{
    public interface IEmployeeLevelModel
    {
        public EmployeeLevel Level { get; }       
        public void SetEmployeeLevel(EmployeeLevel level);
    }
}