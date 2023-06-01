using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T var1, var2, var3;
        private List<T> varList = new List<T>();

        public Guarda3()
        {
            var1 = default;
            var2 = default;
            var3 = default;

            varList.Add(var1);
            varList.Add(var2);
            varList.Add(var3);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return varList.GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T GetItem(int i)
        {
            return varList[i];
        }

        public void SetItem(int i, T item)
        {
            if (i>2 || i<0)
                throw new IndexOutOfRangeException();
                
            else
                varList[i] = item;
        }

    }
}