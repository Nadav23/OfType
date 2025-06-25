using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    public class OfType : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            List<T> result = new List<T>();
            foreach (var item in enumerable)
            {
                if (item.GetType() == typeof(T))
                {
                    result.Add((T)item);

                }
            }

            return result;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return GetOfType<TOutput>(enumerable);
        }

    }
}
