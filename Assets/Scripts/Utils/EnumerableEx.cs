using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public static class EnumerableEx
    {
        public static IEnumerable<T> Concat<T>(params IEnumerable<T>[] sequences)
        {
            return sequences.SelectMany(x => x);
        }
    }
}