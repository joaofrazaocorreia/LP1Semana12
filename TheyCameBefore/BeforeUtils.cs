using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore(IEnumerable<T> list, T limit)
        where T : IComparable<T> where T : struct
        {
            foreach (T item in list)
            {
                if (item > limit)
                    yield return item;
            }
        }
    }
}