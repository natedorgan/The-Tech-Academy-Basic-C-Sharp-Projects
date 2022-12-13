using System;

namespace Class_Void
{
    class Class1
    {
        public void Method(int num)
        {
            var result = num / 2;
            Console.WriteLine(result);
        }
        public void Method(int num1, int num2)
        {
            var total = num1 + num2;
        }
        public void Method2(out int a)
        {
            a = 2;
        }
    }
    static class Class2
    {

    }
}
