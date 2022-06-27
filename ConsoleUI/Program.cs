using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Populate the applicants list.                
            List<DesignPatterns.IPersonModel> applicants = new List<DesignPatterns.IPersonModel>
            {
                DesignPatterns.PersonFactory.CreatePerson("Kenya", "Christina"),
                DesignPatterns.PersonFactory.CreatePerson("Jess", "Cornelia"),
                DesignPatterns.PersonFactory.CreatePerson("Stering", "Ray")
            };

            //Everybody whos last name starts with 'C' is going to be an employee.
            var futureEmployee = applicants.Where(nonManager => nonManager.LastName.StartsWith('C'));
            foreach (var employee in futureEmployee)
            {
                employee.SetEmployeeLevel(DesignPatterns.EmployeeLevel.employee);
            }

            //Everyone else is going to be a manager.
            var futureManager = applicants.Where(nonEmployee => !futureEmployee.Contains(nonEmployee));
            foreach (var manager in futureManager)
            {
                manager.SetEmployeeLevel(DesignPatterns.EmployeeLevel.manager);
            }

            //Create employees. If it's pre-setted as employee it's going to be an employee else it's going to be a manager. Create employee first and lastname and the email as well.
            List<DesignPatterns.IEmployeeModel> employees = new List<DesignPatterns.IEmployeeModel>();
            for(int i = 0; i < applicants.Count; i++)
            {
                if (applicants[i].Level == DesignPatterns.EmployeeLevel.employee)
                {                       
                    employees.Add(DesignPatterns.PersonFactory.CreateEmployee()); 

                }
                else if (applicants[i].Level == DesignPatterns.EmployeeLevel.manager)
                {
                    employees.Add(DesignPatterns.PersonFactory.CreateManager());
                }             
                DesignPatterns.IAccountModel creatNewEmployee = DesignPatterns.AccountFactory.FinalizeEmployee();
                creatNewEmployee.CreateEmployee(applicants[i],employees[i]);
            }            
        }
    }
}