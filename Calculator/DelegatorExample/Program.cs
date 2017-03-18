using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorExample
{
    delegate void PrintCalc ();

    public class first 
    {
        public int sum (int a, int b)
        {
            int res = a + b;
            return res;
        }
    
    }
    public class second 
    {
        public PrintCalc calc;
        public void PrintRes() 
        {
            calc.Invoke();
        }
    }
    public class third 
    { 
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            first f = new first();
            int res = f.sum(a, b); 
            Console.WriteLine(res);
        }
    }
}
