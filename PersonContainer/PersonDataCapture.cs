using System;

namespace DesignPatterns
{
    public class PersonDataCapture
    {
        public static void Capture(Person person)
        { 
            try
            {           
                StandardMessages.DisplayNameQuestion("first name");
                person.FirstName = Console.ReadLine();

                StandardMessages.DisplayNameQuestion("last name");
                person.LastName = Console.ReadLine();
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
        }
    }
}