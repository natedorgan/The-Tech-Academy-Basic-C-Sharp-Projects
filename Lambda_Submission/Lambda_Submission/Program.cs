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
            EmpLists();

            List<Employee> joeList = new List<Employee>();

            foreach (Employee emp in Emps)
            {
                if (emp.FirstName == "Joe")
                {
                    joeList.Add(emp);
                }
            }
            List<Employee> lambdaJoe = new List<EmpList> Emps.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> lambdaInt = new List<EmpList> Emps.Where(x => x.ID > 5).ToList();

        }   

    }
}
