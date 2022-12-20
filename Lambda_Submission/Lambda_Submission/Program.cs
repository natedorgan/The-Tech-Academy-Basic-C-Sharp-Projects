using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program                         
    {
        static void Main(string[] args)
        {
            EmpList Emps = new EmpList();

            List<Employee> joeList = new List<Employee>();

            foreach (Employee emp in Emps.EmpLists())
            {
                if (emp.FirstName == "Joe")
                {
                    joeList.Add(emp);
                }
            }
            List<Employee> lambdaJoe = Emps.EmpLists().Where(x => x.FirstName == "Joe").ToList();
            List<Employee> lambdaInt = Emps.EmpLists().Where(x => x.ID > 5).ToList();
            Console.ReadLine();
            
        }   
        

    }
    
}
