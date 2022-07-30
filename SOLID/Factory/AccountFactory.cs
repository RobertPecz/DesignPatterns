namespace DesignPatterns
{
    public class AccountFactory
    {
        public static IAccountModel FinalizeEmployee()
        {
            return new Account();
        }
    }
}