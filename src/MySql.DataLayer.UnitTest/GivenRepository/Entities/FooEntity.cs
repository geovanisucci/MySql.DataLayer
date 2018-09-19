using MySql.DataLayer.Attributes.EntityConfig.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.DataLayer.UnitTest.GivenRepository.Entities
{
    [TableName("foo")]
    public class FooEntity : IDataEntity
    {
        [PK("id")]
        public Guid id { get; set; }
        [ColumnName("Description")]
        public string Description { get; set; }
    }
}
