using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Nulable<T> where T : struct
    {
        public T _obj { get; set; }

        public bool _hasValue { get; }

        public Nulable()
        {
            
        }

        public Nulable(T obj)
        {
            this._obj = obj;
            this._hasValue = true;
        }

        public T GetValue()
        {
            if (!this._hasValue)
            {
                Console.WriteLine("Printing the default value");
                return default(T);
            }

            return _obj;
        }
    }
}
