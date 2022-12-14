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
        private Pagination _pagination = new();

        public QueryBuilder SetLimit(int value)
        {
            _pagination.Add("limit", value);
            AddDictionaryString(nameof(_pagination), _pagination);

            return this;
        }
        public QueryBuilder SetPage(int value)
        {
            _pagination.Add("page", value);
            AddDictionaryString(nameof(_pagination), _pagination);

            return this;
        }
        public QueryBuilder SetOffset(int value)
        {
            _pagination.Add("offset", value);
            AddDictionaryString(nameof(_pagination), _pagination);

            return this;
        }
    }
}