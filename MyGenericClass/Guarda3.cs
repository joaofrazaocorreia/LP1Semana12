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
                case 0: return var1;
                case 1: return var2;
                case 2: return var3;
                default: return default;
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0: var1 = item;
                case 1: var2 = item;
                case 2: var3 = item;
                default: throw new IndexOutOfRangeException();
            }
        }
    }
}