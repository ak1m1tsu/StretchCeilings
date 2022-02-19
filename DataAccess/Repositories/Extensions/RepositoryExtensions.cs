using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using StretchCeilings.Domain.Enums;

namespace StretchCeilings.DataAccess.Repositories.Extensions
{
    public static class RepositoryExtensions
    {
        public static IEnumerable<TEntity> SortBy<TEntity>(this IEnumerable<TEntity> source, string propName, SortOption option)
            where TEntity : class
        {
            // lambda parameter
            var param = Expression.Parameter(typeof(TEntity), "parameter");

            // sort method
            var sortMethod = option == SortOption.Descending ? "OrderByDescending" : "OrderBy";

            // search methods
            var methodInfo = typeof(Enumerable)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(m => m.Name == sortMethod && m.GetParameters().Count() == 2);

            // get entity property
            var propExp = Expression.Property(param, propName);

            // set type
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