using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class ComparableHelper<T> where T : IComparable 
    {
        public T GetBiggerNumber(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public T GetSmallerNumber(T a, T b)
        {
            return a.CompareTo(b) < 0 ? a : b;
        }

        public T FirstAlphabetic(T a, T b)
        {
            return a.CompareTo(b) < 0 ? a : b;
        }

    }
}
