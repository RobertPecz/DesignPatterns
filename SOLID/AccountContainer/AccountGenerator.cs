using System;

namespace DesignPatterns
{
    public class AccountGenerator
    {
        /// <summary>
        /// A mock that an account is created.
        /// </summary>
        /// <param name="person"></param>
        public static void CreateAccount(Person person)
        {
            Console.WriteLine($"Your account {person.FirstName.Substring(0,1)}{person.LastName} created.");
        }
    }
}