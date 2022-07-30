using System;

namespace DesignPatterns
{
    public class AccountGenerator : IAccountGenerator
    {
        /// <summary>
        /// A mock that an account is created.
        /// </summary>
        /// <param name="person">The Person object which from an Account object created.</param>
        public void CreateAccount(Person person)
        {
            Console.WriteLine($"Your account {person.FirstName.Substring(0, 1)}{person.LastName} created.");
        }
    }
}