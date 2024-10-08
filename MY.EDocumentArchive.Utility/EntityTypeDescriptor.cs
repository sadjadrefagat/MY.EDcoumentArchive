﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

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

        public Dictionary<string, Type> GetPrimaryKeys()
        {
            var primaryKeys = new Dictionary<string, Type>();
            foreach (var property in entityType.GetProperties())
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is PrimaryKeyAttribute)
                        primaryKeys.Add(property.Name, property.PropertyType);
            return primaryKeys;
        }

        public string GetIdentityProperty()
        {
            var identityProperty = "";
            foreach (var property in entityType.GetProperties())
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is AutoIdentityAttribute)
                    {
                        if (!string.IsNullOrEmpty(identityProperty))
                            throw new Exception($"بیش از شناسه خودکار برای موجودیت {Name} تعریف شده است.");
                        identityProperty = property.Name;
                    }
            return identityProperty;
        }

        public U GetValue<U>(T entity, string proprty)
        {
            return (U)entityType.GetProperty(proprty).GetValue(entity);
        }

        public object GetValue(T entity, string proprty)
        {
            var prop = entityType.GetProperty(proprty, BindingFlags.DeclaredOnly |
                BindingFlags.Public |
                BindingFlags.Instance);
            if (prop == null)
                prop = entityType.GetProperty(proprty);
            var val = prop.GetValue(entity) ?? DBNull.Value;
            if (val is EnumItem)
                return (val as EnumItem).Value;
            return val;
        }

        public void SetValue(T entity, string proprty, object value)
        {
            if (!Convert.IsDBNull(value))
            {
                var prop = entityType.GetProperty(proprty, value.GetType());
                prop.SetValue(entity, value);
            }
        }

        public List<string> GetInsertFields()
        {
            var list = new List<string>();
            foreach (var property in entityType.GetProperties())
            {
                var insert = true;
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is NoInsertAttribute)
                    {
                        insert = false;
                        break;
                    }
                if (insert && !list.Contains(property.Name))
                    list.Add(property.Name);
            }
            return list;
        }

        public List<string> GetFields()
        {
            var list = new List<string>();
            foreach (var property in entityType.GetProperties())
            {
                var select = true;
                foreach (var attrib in property.GetCustomAttributes(true))
                    if (attrib is NoSelectAttribute)
                    {
                        select = false;
                        break;
                    }
                if (select && !list.Contains(property.Name))
                    list.Add(property.Name);
            }
            return list;
        }
    }
}
