using System;
using System.Collections.Generic;
using System.Text;

namespace Alschy.Blazor.Sieve.Models
{
    public class ColumnDefinition
    {
        public ColumnDefinition(string propertyName, string columnName, bool canFilter, bool canSort, bool isNumericValue, Func<string, string> converter)
        {
            PropertyName = propertyName;
            ColumnName = columnName;
            CanFilter = canFilter;
            CanSort = canSort;
            IsNumericValue = isNumericValue;
            Converter = converter;
        }

        public string PropertyName { get; }
        public string ColumnName { get; }
        public bool CanFilter { get; }
        public bool CanSort { get; }
        public bool IsNumericValue { get; }
        public Func<string, string> Converter { get; }
    }
}
