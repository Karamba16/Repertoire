using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Theaters
{
    static class Extensions
    {
        public static DataSet GetDataSet(this MySqlCommand command)
        {
            var dataSet = new DataSet();

            var dataAdapter = new MySqlDataAdapter { SelectCommand = command };

            dataAdapter.Fill(dataSet);

            return dataSet;
        }


        public static string ToPrettyString(this DataSet ds)
        {
            var sb = new StringBuilder();
            foreach (var table in ds.Tables.ToList())
            {
                sb.AppendLine("--" + table.TableName + "--");
                sb.AppendLine(String.Join(" | ", table.Columns.ToList()));
                foreach (DataRow row in table.Rows)
                {
                    sb.AppendLine(String.Join(" | ", row.ItemArray));
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static void Print(this DataSet ds)
        {
            Debug.WriteLine(ds.ToPrettyString());
        }

        public static void AddRange(this DataColumnCollection collection, params string[] columns)
        {
            foreach (var column in columns)
            {
                collection.Add(column);
            }
        }

        public static List<DataTable> ToList(this DataTableCollection collection)
        {
            var list = new List<DataTable>();
            foreach (var table in collection)
            {
                list.Add((DataTable)table);
            }
            return list;
        }

        public static List<DataColumn> ToList(this DataColumnCollection collection)
        {
            var list = new List<DataColumn>();
            foreach (var column in collection)
            {
                list.Add((DataColumn)column);
            }

            return list;
        }

        public static bool IsNumeric(this string s)
        {
            return Regex.IsMatch(s, @"\d");
        }

        public static void ReplaceWith(this UserControl uc, UserControl target)
        {
            Panel panelContainer = uc.FindForm().Controls.OfType<Panel>().First(t => t.Name == "panelWrapper").Controls.OfType<Panel>().First(t => t.Name == "panelContainer");

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(target);
        }

        public static void ReplaceWith(this Panel panelContainer, UserControl target)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(target);
        }

        public static string Localize(this DateTime dateTime)
        {
            var culture = CultureInfo.CreateSpecificCulture("ru-RU");
            return dateTime.ToString("d MMMM", culture);
        }
    }
}
