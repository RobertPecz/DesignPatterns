using System;

namespace DesignPatterns
{
    public class PersonValidator
    {
        /// <summary>
        /// Validate that the person first and lastname is not null or empty or white space.
        /// </summary>
        /// <param name="person">The Person object which is under validation.</param>
        /// <returns>True if the Person object first and last name is not null or empty or white space. False if the Person object first or last name is null or empty or white space.</returns>
        public static bool Validate(Person person)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(person.FirstName))
                {
                    StandardMessages.DisplayValidationError("first name");
                    return false;
                }
                if(string.IsNullOrWhiteSpace(person.LastName))
                {
                    StandardMessages.DisplayValidationError("last name");
                    return false;
                }               
            }           
            catch(NullReferenceException e)
            {
                if(person == null)
                {
                    Console.WriteLine("Your person cannot be null.");
                    throw e;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
    }
}