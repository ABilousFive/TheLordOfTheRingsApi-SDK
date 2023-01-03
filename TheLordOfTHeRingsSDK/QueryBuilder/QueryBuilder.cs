namespace TestProject.QueryBuilder
{
    public partial class QueryBuilder
    {
        private Dictionary<string, object> _allFilters = new();

        public QueryBuilder()
        { }


        private void AddDictionaryString(string key, object value)
        {
            if (_allFilters.ContainsKey(key))
            {
                throw new InvalidOperationException();
            }
            _allFilters.Add(key, value);
        }


        internal string Build()
        {
            return string.Format("?{0}", string.Join('&',
                _allFilters.Select(e => e.Value)));
        }
    }
}