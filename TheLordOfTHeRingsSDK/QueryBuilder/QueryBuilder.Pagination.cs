using TheLordOfTHeRingsSDK.QueryBuilder.Models;

namespace TheLordOfTHeRingsSDK.QueryBuilder
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