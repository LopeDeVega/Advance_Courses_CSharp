using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Delegates
{
    public delegate double OperationAction(double a, double b);
    public class Operation
    {
        public double Sum(double a, double b)
        {
            return (a + b);
        }

        public double Subract (double a, double b)
        {
            return (a - b);
        }

        public double Multiple (double a, double b)
        {
            return (a * b);
        }

        public double Devition(double a, double b)
        {
            return (a / b);
        }
    }
}
