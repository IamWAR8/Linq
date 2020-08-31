using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                                 Func<T, bool> predicate)
        {
            
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    //yield would help build an IEnumerable
                    yield return item;
                }
            }
            
        }
    }
}
