using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;
using ClassArray;

namespace HomeWork4
{
    internal class ArrayListNumber : Class1
    {
        public ArrayListNumber(int n, int start, short step) : base(n, start, step)
        {
        }

        static void Main(string[] args)
        {
            Class1 class1 = new Class1(20, 1, 2);
            class1.SumNumber(0);
            class1.Inverse();
            class1.Multi(2);
        }
    }
}
