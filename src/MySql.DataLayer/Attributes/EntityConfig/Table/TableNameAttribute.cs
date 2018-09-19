using System;

namespace MySql.DataLayer.Attributes.EntityConfig.Table
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class TableNameAttribute : Attribute
    {
        /// <summary>
        /// The real table mapped name in database.
        /// </summary>
        /// <value></value>
        public string Name { get; private set; }

        public TableNameAttribute(string tableName)
        {
            Name = tableName;
        }
    }
}
