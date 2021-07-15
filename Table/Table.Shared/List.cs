using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table.Shared
{
    public class List
    {
        public List<TestObject> Objects { get; set; }

        public List()
        {
            Objects = new List<TestObject>()
            {
                new TestObject()
                {
                    Id = 1,
                    Name = "Name 1",
                    Description = "Description 1",
                    CreateDate = new DateTime(2021, 5, 11),
                    ChangeDate = new DateTime(2021, 5, 12),
                    Something = "bjksdfjsdf",
                    Stuff = "sdfjskdfsdf"
                },
                new TestObject()
                {
                    Id = 2,
                    Name = "Name 2",
                    Description = "Description 2",
                    CreateDate = new DateTime(2021, 6, 11),
                    ChangeDate = new DateTime(2021, 7, 12),
                    Something = "jrtrtyertert",
                    Stuff = ",hjkhgj"
                },
                new TestObject()
                {
                    Id = 3,
                    Name = "Name 3",
                    Description = "Description 3",
                    CreateDate = new DateTime(2021, 4, 11),
                    ChangeDate = new DateTime(2021, 2, 12),
                    Something = "ytutuyujghjgh",
                    Stuff = "werqrfgdf"
                },
                new TestObject()
                {
                    Id = 4,
                    Name = "Name 4",
                    Description = "Description 4",
                    CreateDate = new DateTime(2023, 5, 11),
                    ChangeDate = new DateTime(2024, 5, 12),
                    Something = "dfgdfgdf",
                    Stuff = "dfgdfgsdfwer"
                },
            };
        }
    }
}
