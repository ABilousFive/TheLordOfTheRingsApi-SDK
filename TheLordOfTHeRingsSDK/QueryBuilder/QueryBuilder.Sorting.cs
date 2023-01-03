using TheLordOfTHeRingsSDK.QueryBuilder.Models;

namespace TheLordOfTHeRingsSDK.QueryBuilder
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