using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.QueryBuilder.Models
{
    internal class RegexFilter
    {
        internal Dictionary<string, (string, bool)> dictionaryQuery;

        internal RegexFilter()
        {
            dictionaryQuery = new();
        }

        internal void Add(string key, string value, bool isMatch)
        {
            if (dictionaryQuery.ContainsKey(key))
                throw new InvalidOperationException();

            dictionaryQuery.Add(key, (value, isMatch));
        }

        public override string ToString()
        {
            return string.Join('&',
                dictionaryQuery.Select(e =>
                    $"{e.Key}{(e.Value.Item2 ? "=" : "!=")}{e.Value.Item1}"));
        }
    }
}
