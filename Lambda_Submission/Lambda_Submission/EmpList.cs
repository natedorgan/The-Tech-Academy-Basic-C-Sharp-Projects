using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    public class EmpList
    {
        public List<Employee> EmpLists()
        {
            List<Employee> Emps = new List<Employee>();
            List<string> Names = new List<string>() { "Joe", "Non-Joe" };
            List<int> Ids = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };             

            foreach (string name in Names)
            {
                foreach (int Id in Ids)
                {
                    Employee emp = new Employee();
                    emp.FirstName = name;
                    emp.ID = Id;
                    Emps.Add(emp);
                }
            }
            return Emps;
        }
    }
}
