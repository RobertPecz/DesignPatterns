namespace DesignPatterns
{
    public class PersonFactory
    {
        public static IPersonModel CreatePerson(string firstName, string lastName)
        {
            return new Person(firstName, lastName);
        }

        public static IEmployeeModel CreateEmployee()
        {
            return new Employee();
        }

        public static IEmployeeModel CreateManager()
        {
            return new Manager();
        }
    }
}