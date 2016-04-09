using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCombine.Core.Test.Helpers
{
    public static class LinqHelpers
    {
        public static HashSet<TProp> GetPropertySet<T,TProp>(this IEnumerable<T> collection, Func<T, TProp> prop)
        {
            return new HashSet<TProp>(collection.Select(prop).Distinct());
        }

        public static IEnumerable<TProp> GetDistinct<T, TProp>(this IEnumerable<T> collection, Func<T, TProp> prop)
        {
            return collection.Select(prop).Distinct();
        }
    }
}
