using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Math
    {
        public int Operator(int data)
        {
            return data + 2;
        }
        public int Operator(decimal number)
        {
            int intNumber = Convert.ToInt32(number);
            return intNumber * 2;
        }
        public int Operator(string String)
        {
            int intString = Convert.ToInt32(String);
            return intString / 2;
        }
    }
}
