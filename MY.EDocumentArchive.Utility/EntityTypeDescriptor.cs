using System;
using System.Collections.Generic;

namespace MY
{
    public class EntityTypeDescriptor<T>
        where T : BaseEntity
    {
        private Type entityType;

        public EntityTypeDescriptor()
        {
            entityType = typeof(T);
        }

        public string Name
        {
            get
            {
                return entityType.Name;
            }
        }

        public string GetPrimaryKeyProperty()
        {
            foreach (var property in entityType.GetProperties())
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is PrimaryKeyAttribute)
                        return property.Name;
            return null;
        }

        public U GetValue<U>(T entity, string proprty)
        {
            return (U)entityType.GetProperty(proprty).GetValue(entity);
        }

        public object GetValue(T entity, string proprty)
        {
            return entityType.GetProperty(proprty).GetValue(entity) ?? DBNull.Value;
        }

        public void SetValue(T entity, string proprty, object value)
        {
            if (!Convert.IsDBNull(value))
                entityType.GetProperty(proprty).SetValue(entity, value);
        }

        public IEnumerable<string> GetInsertFields()
        {
            foreach (var property in entityType.GetProperties())
            {
                var insert = true;
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is NoInsertAttribute)
                    {
                        insert = false;
                        break;
                    }
                if (insert)
                    yield return property.Name;
            }
        }

        public IEnumerable<string> GetFields()
        {
            foreach (var property in entityType.GetProperties())
            {
                var select = true;
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is NoSelectAttribute)
                    {
                        select = false;
                        break;
                    }
                if (select)
                    yield return property.Name;
            }
        }
    }
}
