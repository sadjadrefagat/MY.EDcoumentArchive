using System;

namespace MY
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    sealed public class PrimaryKeyAttribute : Attribute
    {
    }
}
