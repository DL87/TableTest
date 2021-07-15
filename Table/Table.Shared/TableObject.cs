using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table.Shared
{
    public class TableObject
    {
        public IEnumerable<object> Data { get; set; }
        public List<Column> Columns { get; set; }
        public Type ObjectType { get; set; }
        public TableObject()
        {
            Data = new List().Objects;
            Columns = new List<Column>()
            {
                new Column() { Field = "Id" },
                new Column() { Field = "Name" },
                new Column() { Field = "CreateDate", Format = "dd-MM-yyyy" }
            };
            ObjectType = Data.First().GetType();
        }
    }
}
