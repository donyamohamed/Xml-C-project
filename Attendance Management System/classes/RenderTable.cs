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
        /*
        public static string RenderDataTable(List<string> columns, List<string[]> rows)
        {
            string table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example'>";
            table += "<thead><tr>";
            foreach (string column in columns)
            {
                table += "<th>" + column + "</th>";
            }
            table += "</tr></thead>";
            table += "<tbody>";
            foreach (string[] row in rows)
            {
                table += "<tr>";
                foreach (string cell in row)
                {
                    table += "<td>" + cell + "</td>";
                }
                table += "</tr>";
            }
            table += "</tbody>";
            table += "</table>";
            return table;
        }
        */
    }
}
