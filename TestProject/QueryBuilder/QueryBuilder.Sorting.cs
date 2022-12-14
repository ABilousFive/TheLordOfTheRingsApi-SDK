using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestProject.QueryBuilder.Models;

namespace TestProject.QueryBuilder
{
    public partial class QueryBuilder
    {
        private Sorting _sorting = new();

        public QueryBuilder Sort(string propertyName)
        {
            _sorting.Add(propertyName, true);
            AddDictionaryString(nameof(_sorting), _sorting);

            return this;
        }
        public QueryBuilder SortByDescending(string propertyName)
        {
            _sorting.Add(propertyName, false);
            AddDictionaryString(nameof(_sorting), _sorting);

            return this;
        }
    }
}