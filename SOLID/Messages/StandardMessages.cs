using System;

namespace DesignPatterns
{
    /// <summary>
    /// Solution wide messages.
    /// </summary>   
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application.");
        }

        public static void EndMessage()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        } 

        public static void DisplayValidationError(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Your name parameter cannot be null.");
            }           
            Console.WriteLine($"You didn't give your {name}");
                                 
        }

        public static void DisplayNameQuestion(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Your name parameter cannot be null.");
            }     
            Console.Write($"What is your {name}: ");
        }
    }
}