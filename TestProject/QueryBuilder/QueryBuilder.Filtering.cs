using TestProject.QueryBuilder.Models;

namespace TestProject.QueryBuilder
{
    public partial class QueryBuilder
    {
        private MatchFilter _matchFilter = new();
        private IncludeFilter _includeFilter = new();
        private ExistFilter _existFilter = new();
        private RegexFilter _regexFilter = new();
        private LessGreaterFilter _lessGreaterFilter = new();


        public QueryBuilder Match(string propertyName, string value)
        {
            _matchFilter.Add(propertyName, value, true);
            AddDictionaryString(nameof(_matchFilter), _matchFilter);

            return this;
        }

        public QueryBuilder NotMatch(string propertyName, string value)
        {
            _matchFilter.Add(propertyName, value, false);
            AddDictionaryString(nameof(_matchFilter), _matchFilter);

            return this;
        }

        public QueryBuilder Include(string propertyName, params string[] values)
        {
            _includeFilter.Add(propertyName, true, values);
            AddDictionaryString(nameof(_includeFilter), _includeFilter);

            return this;
        }

        public QueryBuilder Exclude(string propertyName, params string[] values)
        {
            _includeFilter.Add(propertyName, false, values);

            AddDictionaryString(nameof(_includeFilter), _includeFilter);

            return this;
        }

        public QueryBuilder Exist(string propertyName)
        {
            _existFilter.Add(propertyName, true);
            AddDictionaryString(nameof(_existFilter), _existFilter);

            return this;
        }

        public QueryBuilder NotExist(string propertyName)
        {
            _existFilter.Add(propertyName, false);
            AddDictionaryString(nameof(_existFilter), _existFilter);
            
            return this;
        }

        public QueryBuilder Regex(string propertyName, string value)
        {
            _regexFilter.Add(propertyName, value, true);
            AddDictionaryString(nameof(_regexFilter), _regexFilter);

            return this;
        }

        public QueryBuilder NotRegex(string propertyName, string value)
        {
            _regexFilter.Add(propertyName, value, false);
            AddDictionaryString(nameof(_existFilter), _existFilter);

            return this;
        }

        // TODO: зробити одним методом

        public QueryBuilder LessThan(string propertyName, int value)
        {
            _lessGreaterFilter.Add(propertyName, value, "<");
            AddDictionaryString(nameof(_lessGreaterFilter), _lessGreaterFilter);

            return this;
        }

        public QueryBuilder LessOrEqualThen(string propertyName, int value)
        {
            _lessGreaterFilter.Add(propertyName, value, "<=");
            AddDictionaryString(nameof(_lessGreaterFilter), _lessGreaterFilter);

            return this;
        }

        public QueryBuilder GreaterThen(string propertyName, int value)
        {
            _lessGreaterFilter.Add(propertyName, value, ">");
            AddDictionaryString(nameof(_lessGreaterFilter), _lessGreaterFilter);

            return this;
        }

        public QueryBuilder GreaterOrEqualThen(string propertyName, int value)
        {
            _lessGreaterFilter.Add(propertyName, value, ">=");
            AddDictionaryString(nameof(_lessGreaterFilter), _lessGreaterFilter);

            return this;
        }
    }
}