using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Calculator
    {
        public void PrintResult (double a, double b, OperationAction operation)
        {
            var result =  operation(a, b);
            Console.WriteLine(result);
        }
    }
}
