using System;
using System.Collections.Generic;
using Alschy.Blazor.Sieve.Models;
using System.Text;
using System.Linq.Expressions;

namespace Alschy.Blazor.Sieve.Builders
{
        public class BlazorGridBuilder<TModel>
        where TModel : class, new()
        {
            List<ColumnBuilder> columnBuilders;

            public BlazorGridBuilder()
            {
                columnBuilders = new List<ColumnBuilder>();
            }

            public ColumnBuilder ForColumn<TProperty>(Expression<Func<TModel, TProperty>> property)
            {
                var member = ((MemberExpression)property.Body).Member;
                var builder = new ColumnBuilder(member.Name, member.GetType());
                columnBuilders.Add(builder);
                return builder;
            }

            public IEnumerable<ColumnDefinition> Build()
            {
                foreach (var item in columnBuilders)
                {
                    yield return item.Build();
                }
            }
        }
}
