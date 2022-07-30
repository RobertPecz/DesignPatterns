namespace DesignPatterns
{
    public interface IPersonDataCapture
    {
        void Capture(Person person);
        void PopulateApplicantsList(string firstName, string LastName, string middleName = "");
    }
}