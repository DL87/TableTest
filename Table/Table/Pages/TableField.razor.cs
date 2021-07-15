using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Table.Shared;

namespace Table.Web.Pages
{
    public partial class TableField
    {
        private TableObject TableObject { get; set; } = new TableObject();
        private IEnumerable<object> FilteredList { get; set; }

        private string GetValue(object row, Column column)
        {
            var value = row.GetType().GetProperty(column.Field).GetValue(row, null);

            switch (value)
            {
                case DateTime dt:
                    return !string.IsNullOrEmpty(column.Format) ? dt.ToString(column.Format) : dt.ToString();
                default:
                    return value.ToString();
            }

        }

        private void Sort(Type type, Column column)
        {
            column.Descending = !column.Descending;
            var propertyInfo = type.GetProperty(column.Field);

            if (column.Descending)
            {
                FilteredList = FilteredList.OrderByDescending(x => propertyInfo.GetValue(x, null));
            }
            else
            {
                FilteredList = FilteredList.OrderBy(x => propertyInfo.GetValue(x, null));
            }
        }
    }
}
