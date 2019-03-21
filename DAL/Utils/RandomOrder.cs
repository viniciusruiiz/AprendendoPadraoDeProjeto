using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace DAL.Utils
{
    public class RandomOrder : Order
    {
        public RandomOrder() : base("", true) { }
        public override SqlString ToSqlString(
            ICriteria criteria, ICriteriaQuery criteriaQuery)
        {
            return new SqlString("RAND()");
        }
    }

    public static class NHibernateExtensions
    {
        public static IQueryOver<TRoot, TSubType>
            OrderByRandom<TRoot, TSubType>(
              this IQueryOver<TRoot, TSubType> query)
        {
            query.UnderlyingCriteria.AddOrder(new RandomOrder());
            return query;
        }
    }
}
