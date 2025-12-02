using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Theaters.UserControls
{
    public partial class DataGridViewUC : UserControl
    {
        public Dictionary<string, Delegate> events = new Dictionary<string, Delegate>();

        public DataGridViewUC()
        {
            InitializeComponent();
        }

        public void Setup(List<CustomDataGridViewColumn> columns)
        {
            foreach (var c in columns)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.Name = c.getName();
                column.HeaderText = c.getHeaderText();
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = c.getFillWeight();
                column.CellTemplate = new DataGridViewTextBoxCell();

                if (c.getClickEvent() != null)
                {
                    events[c.getName()] = c.getClickEvent();
                }

                dataGridView.Columns.Add(column);
            }
        }

        public DataGridViewRow GetRow(int index)
        {
            return dataGridView.Rows[index];
        }

        public void AddRow(object[] values)
        {
            dataGridView.Rows.Add(values);
        }

        public void Clear() {
            dataGridView.Rows.Clear(); 
        }

        private void dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("CellMouseEnter");

            string colname = dataGridView.Columns[e.ColumnIndex].Name;

            if (e.RowIndex >= 0)
            {
                dataGridView.Rows[e.RowIndex].Selected = true;

                if (events.ContainsKey(colname))
                {
                    dataGridView.Cursor = Cursors.Hand;
                }
            }
            else
            {
                dataGridView.Cursor = Cursors.Default;
            }
        }

        private void dataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView.Columns[e.ColumnIndex].Name;

            if (e.RowIndex >= 0)
            {
                if (events.ContainsKey(colname))
                {
                    dataGridView.Cursor = Cursors.Default;
                }
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colname = dataGridView.Columns[e.ColumnIndex].Name;

            if (e.RowIndex >= 0)
            {
                if (events.ContainsKey(colname))
                {
                    events[colname].DynamicInvoke(e.RowIndex);
                }
            }
        }
    }
}
