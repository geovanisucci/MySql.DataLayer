using System;

namespace MySql.DataLayer.Attributes.StoredProcedureConfig.StoredProcedure
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class StoredProcedureNameAttribute : Attribute
    {
        /// <summary>
        /// The actual name the StoredProcedure in database.
        /// </summary>
        /// <value></value>
        public string Name { get; private set; }

        public StoredProcedureNameAttribute(string storedProcedureName)
        {
            Name = storedProcedureName;
        }
    }
}
