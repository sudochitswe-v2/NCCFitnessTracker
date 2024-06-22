using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker.Desktop.Common
{
    public static class CommonUtil
    {
        public static void ShowForm(Form form) => form.Show();
        public static void ShowDialogForm(Form form) => form.ShowDialog();
        public static T ConvertDataRowToObject<T>(DataRow row) where T : new()
        {
            T obj = new T();
            foreach (DataColumn col in row.Table.Columns)
            {
                var prop = obj.GetType().GetProperty(col.ColumnName);
                if (prop != null && row[col] != DBNull.Value)
                {
                    try
                    {
                        // Attempt type conversion before setting the property value
                        object convertedValue = Convert.ChangeType(row[col], prop.PropertyType);
                        prop.SetValue(obj, convertedValue);
                    }
                    catch (Exception ex)
                    {
                        // Handle potential conversion errors gracefully (e.g., log or throw)
                        // You may choose to skip the property or provide a default value
                        Console.WriteLine($"Error converting value for property '{prop.Name}': {ex.Message}");
                    }
                }
            }
            return obj;
        }

    }
}
