using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal class StringComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if(x is null || y is null )
                return false;
            return string.Concat(x.OrderBy(Ch => Ch)) == string.Concat(y.OrderBy(Ch => Ch));
        }

        public int GetHashCode([DisallowNull] string obj)
        {
           return String.Concat(obj.OrderBy(Ch => Ch)).GetHashCode();
        }
    }
}
