using System;

namespace MySql.DataLayer.Attributes.ViewConfig.View
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class ViewNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public ViewNameAttribute(string viewName)
        {
            Name = viewName;
        }
    }
}
