using System;

namespace DesignPatterns
{
    public class PersonValidator
    {
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