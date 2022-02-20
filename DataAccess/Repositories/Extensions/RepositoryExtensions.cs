using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using StretchCeilings.Domain.Enums;

namespace StretchCeilings.DataAccess.Repositories.Extensions
{
    public static class RepositoryExtensions
    {
        private const string ORDER_BY_DESCENDING = "OrderByDescending";
        private const string ORDER_BY_ASCENDING = "OrderBy";
        private const string PARAMETER_NAME = "parameter";

        public static IEnumerable<TEntity> SortBy<TEntity>(this IEnumerable<TEntity> source, string propName, SortOption option)
            where TEntity : class
        {
            // lambda parameter
            var param = Expression.Parameter(typeof(TEntity), PARAMETER_NAME);

            // sort method
            var sortMethod = option == SortOption.Descending ? ORDER_BY_DESCENDING : ORDER_BY_ASCENDING;

            // search selected method
            var methodInfo = typeof(Enumerable)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(m => m.Name == sortMethod && m.GetParameters().Count() == 2);

            // get entity's property
            var propExp = Expression.Property(param, propName);

            // set property's type
            methodInfo = methodInfo.MakeGenericMethod(typeof(TEntity), propExp.Type);

            // get result
            var result = methodInfo.Invoke(null, new object[]
            {
                source,
                Expression.Lambda(propExp, param).Compile()
            });

            return result as IEnumerable<TEntity>;
        }

    }
}