using System;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class PersonDataCapture : IPersonDataCapture
    {
        public List<IPersonModel> applicants;
        public IEnumerable<IPersonModel> futureEmployee;
        public IEnumerable<IPersonModel> futureManager;
        public PersonDataCapture()
        {
            applicants = new List<IPersonModel>();
            futureEmployee = new List<IPersonModel>();
            futureManager = new List<IPersonModel>();
        }
        /// <summary>
        /// Populate a Person object.
        /// </summary>
        /// <param name="person">The actual person object which is going to be populated.</param>
        public void Capture(Person person)
        {
            try
            {
                StandardMessages.DisplayNameQuestion("first name");
                person.FirstName = Console.ReadLine();

                StandardMessages.DisplayNameQuestion("last name");
                person.LastName = Console.ReadLine();
            }
            catch (NullReferenceException e)
            {
                if (person == null)
                {
                    Console.WriteLine("Your person cannot be null.");
                    throw e;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Populating a list which is containing the applicants. This objects are going to be the employees or the managers.
        /// </summary>
        /// <param name="firstName">Person first name. Can't be null or empty.</param>
        /// <param name="LastName">Person last name. Can't be null or empty.</param>
        /// <param name="middleName">Person middle name. Empty on default.</param>
        public void PopulateApplicantsList(string firstName, string LastName, string middleName = "")
        {
            applicants.Add(PersonFactory.CreatePerson(firstName, LastName));
            //Populate the applicants list.                
            applicants = new List<DesignPatterns.IPersonModel>
            {
                DesignPatterns.PersonFactory.CreatePerson("Kenya", "Christina"),
                DesignPatterns.PersonFactory.CreatePerson("Jess", "Cornelia"),
                DesignPatterns.PersonFactory.CreatePerson("Stering", "Ray")
            };
        }

        /// <summary>
        /// Populate futureEmployee and futureManager list and set the employee level.
        /// </summary>
        public void PopulateFutureEmployeelist()
        {
            //Everybody whos last name starts with 'C' is going to be an employee.
            futureEmployee = applicants.Where(nonManager => nonManager.LastName.StartsWith('C'));
            foreach (var employee in futureEmployee)
            {
                employee.SetEmployeeLevel(DesignPatterns.EmployeeLevel.employee);
            }

            //Everyone else is going to be a manager.
            futureManager = applicants.Where(nonEmployee => !futureEmployee.Contains(nonEmployee));
            foreach (var manager in futureManager)
            {
                manager.SetEmployeeLevel(DesignPatterns.EmployeeLevel.manager);
            }
        }
    }
}