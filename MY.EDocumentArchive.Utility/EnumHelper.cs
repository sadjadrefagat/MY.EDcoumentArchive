using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MY
{
    static public class EnumHelper
    {
        static public void FillByEnum<T>(this ComboBox comboBox) where T : EnumItem
        {
            comboBox.Items.Clear();
            var list = new List<EnumItem>();
            var enumType = typeof(T);
            foreach (var property in enumType.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public))
                list.Add((EnumItem)property.GetValue(null));
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = list;
        }
    }
}
