using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T var1, var2, var3;

        public Guarda3()
        {
            var1 = default;
            var2 = default;
            var3 = default;
        }

        public T GetItem(int i)
        {
            switch (i)
            {
                case 1: return var1;
                case 2: return var2;
                case 3: return var3;
                default: return default;
            }
        }
    }
}