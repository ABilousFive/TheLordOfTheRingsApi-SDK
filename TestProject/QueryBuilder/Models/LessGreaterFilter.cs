using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.QueryBuilder.Models
{
    internal class LessGreaterFilter
    {
        private readonly Dictionary<string, (int, string)> dictionaryQuery;

        internal LessGreaterFilter()
        {
            dictionaryQuery = new();
        }

        internal void Add(string key, int value, string sign)
        {
            if (dictionaryQuery.ContainsKey(key))
            {
                throw new InvalidOperationException();
            }

            dictionaryQuery.Add(key, (value, sign));
        }

        public override string ToString()
        {
            return string.Join('&', dictionaryQuery.Select(e => $"{e.Key}{e.Value.Item2}{e.Value.Item1}"));
        }
    }
}
