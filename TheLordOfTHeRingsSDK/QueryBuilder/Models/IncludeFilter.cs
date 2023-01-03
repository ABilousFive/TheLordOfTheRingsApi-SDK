using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.QueryBuilder.Models
{
    internal class IncludeFilter
    {
        internal Dictionary<string, (List<string>, bool)> dictionaryQuery;

        internal IncludeFilter()
        {
            dictionaryQuery = new();
        }

        internal void Add(string key, bool isInclude, params string[] values)
        {
            if (dictionaryQuery.ContainsKey(key))
            {
                dictionaryQuery[key].Item1.AddRange(values);
            }

            dictionaryQuery.Add(key, (values.ToList(), isInclude));
        }

        public override string ToString()
        {
            return string.Join('&',
                dictionaryQuery.Select(e =>
                    $"{e.Key}{(e.Value.Item2 ? "=" : "!=")}{string.Join(',', e.Value.Item1)}"));
        }
    }
}
