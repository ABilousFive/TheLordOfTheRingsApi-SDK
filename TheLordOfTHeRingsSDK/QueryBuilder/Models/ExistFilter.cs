using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.QueryBuilder.Models
{
    internal class ExistFilter
    {
        internal Dictionary<string, bool> dictionaryQuery;

        internal ExistFilter()
        {
            dictionaryQuery = new();
        }

        internal void Add(string key, bool isMatch)
        {
            if (dictionaryQuery.ContainsKey(key))
                throw new InvalidOperationException();

            dictionaryQuery.Add(key, isMatch);
        }

        public override string ToString()
        {
            return string.Join('&',
                dictionaryQuery.Select(e =>
                    $"{(e.Value ? "=" : "!=")}{e.Key}"));
        }
    }
}
