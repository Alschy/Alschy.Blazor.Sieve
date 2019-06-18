using Alschy.Blazor.Sieve.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alschy.Blazor.Sieve.Builders
{
    public class ColumnBuilder
    {
        private readonly string propertyName;
        private string columnName;
        private bool canFilter = false;
        private bool canSort = false;
        private bool isNumericValue = false;
        private Func<string, string> convert = input => input;

        public ColumnBuilder(string propertyName, Type propertyType)
        {
            this.propertyName = propertyName;
            columnName = propertyName;
            isNumericValue |= IsNumericType(propertyType);
            isNumericValue |= IsNumericType(propertyType.UnderlyingSystemType);
        }

        private bool IsNumericType(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                default:
                    return false;
            }
        }

        public ColumnBuilder SetCaption(string caption)
        {
            columnName = caption;
            return this;
        }

        public ColumnBuilder CanFilter(bool canFilter = true)
        {
            this.canFilter = canFilter;
            return this;
        }

        public ColumnBuilder CanSort(bool canSort = true)
        {
            this.canSort = canSort;
            return this;
        }

        public ColumnBuilder SetConverter(Func<string, string> convert)
        {
            this.convert = convert;
            return this;
        }

        public ColumnDefinition Build()
        {
            return new ColumnDefinition(propertyName, columnName, canFilter, canSort, isNumericValue, convert);
        }

    }
}
