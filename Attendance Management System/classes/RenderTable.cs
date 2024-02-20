using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    internal class RenderTable
    {
        public static DataTable RenderDateTable<T>(List<T> myList)
        {
            DataTable table = new DataTable();
            int indexRow;
            foreach (var key in myList.ElementAt(0).GetType().GetProperties())
            {
                table.Columns.Add(key.Name, key.PropertyType);
            }
            foreach (var item in myList)
            {
                DataRow row = table.NewRow();
                foreach (var key in item.GetType().GetProperties())
                {
                    row[key.Name] = key.GetValue(item, null);
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
