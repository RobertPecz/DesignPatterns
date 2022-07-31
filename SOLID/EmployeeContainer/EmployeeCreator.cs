using System.Collections.Generic;

namespace DesignPatterns
{
    public class EmployeeCreator : IEmployeeCreator
    {
        List<DesignPatterns.IEmployeeModel> employees;
        public EmployeeCreator()
        {
            employees = new List<IEmployeeModel>();
        }
        public void InitialEmployeeCreator(List<IPersonModel> applicants)
        {
        employees = new List<DesignPatterns.IEmployeeModel>();
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