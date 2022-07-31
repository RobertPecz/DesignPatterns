namespace DesignPatterns
{
    public interface IPersonDataCapture
    {
        void CaptureManually(Person person);
        void PersonCapturer();
        void PopulateApplicantsList(Person person);
    }
}