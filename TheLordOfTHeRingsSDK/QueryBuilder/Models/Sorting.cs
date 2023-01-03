using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.QueryBuilder.Models
{
    internal class Sorting
    {
        internal Dictionary<string, bool> dictionaryQuery;

        internal Sorting()
        {
            dictionaryQuery = new();
        }

        internal void Add(string key, bool isAscending)
        {
            if (dictionaryQuery.Any())
                throw new InvalidOperationException();

            dictionaryQuery.Add(key, isAscending);
        }

        public override string ToString()
        {
            return string.Join('&',
                dictionaryQuery.Select(e =>
                    $"sort={e.Key}{(e.Value ? ":asc" : ":desc")}"));
        }
    }
}
