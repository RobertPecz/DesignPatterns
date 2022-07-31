using System.Collections.Generic;

namespace DesignPatterns
{
    interface IEmployeeCreator
    {
        void InitialEmployeeCreator(List<IPersonModel> applicants);  
    }
}
