using System;

namespace DesignPatterns
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            Console.WriteLine($"Your account {person.FirstName.Substring(0,1)}{person.LastName} created.");
        }
    }
}