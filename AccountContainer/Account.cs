using System;

namespace DesignPatterns
{
    public class Account : IAccountModel
    {
        public void CreateEmployee(IPersonModel person, IEmployeeModel employee)
        {
            try
            {
                employee.FirstName = person.FirstName;
                employee.LastName = person.LastName;
                employee.Email = String.Format(person.FirstName[0] + person.LastName + "@testmail.com");
                employee.SetEmployeeLevel(person.Level);
            }
            catch(NullReferenceException e)
            {
                if(person == null)
                {
                    Console.WriteLine("Your person cannot be null.");
                    throw e;
                }
                else if (employee == null)
                {
                    Console.WriteLine("Your employee cannot be null.");
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