using SeaStory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.UI.TimeManagement
{
    public partial class TimeTable : UserControl
    {
        private DataGridView dataGridViewTimeTable;
        private DatabaseNonAut db = new DatabaseNonAut();

        public TimeTable()
        {
            InitializeComponent();

            dataGridViewTimeTable = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToResizeRows = false, // Prevent the user from resizing rows
                AllowUserToResizeColumns = false, // Prevent the user from resizing columns
                RowHeadersVisible = false, // Add this line to hide row headers
                SelectionMode = DataGridViewSelectionMode.FullRowSelect // Set selection mode to full row select
            };

            // Columns setup
            SetupColumns();
            RefreshTimeTable();

            // Add the DataGridView to the UserControl's Controls collection
            this.Controls.Add(dataGridViewTimeTable);
        }

        public void AddRow(params object[] values)
        {
            dataGridViewTimeTable.Rows.Add(values);
        }

        public void RemoveRowAt(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewTimeTable.Rows.Count)
            {
                dataGridViewTimeTable.Rows.RemoveAt(rowIndex);
            }
        }


        public List<object> GetRowValues(int rowIndex)
        {
            var values = new List<object>();
            if (rowIndex >= 0 && rowIndex < dataGridViewTimeTable.Rows.Count)
            {
                foreach (DataGridViewCell cell in dataGridViewTimeTable.Rows[rowIndex].Cells)
                {
                    values.Add(cell.Value);
                }
            }
            return values;
        }

        private void SetupColumns()
        {
            // Add columns
            dataGridViewTimeTable.Columns.Add("time", "추가 시간");
            dataGridViewTimeTable.Columns.Add("name", "요금제 명");
            dataGridViewTimeTable.Columns.Add("member_price", "회원 요금");
            // dataGridViewTimeTable.Columns.Add("nonmember_price", "비회원 요금");
        }

        public void RefreshTimeTable()
        {
            // Clear existing rows
            dataGridViewTimeTable.Rows.Clear();

            // Get new data from database
            var subscriptions = DatabaseNonAut.GetSubscriptions();

            // Add new rows with the fresh data
            foreach (var subscription in subscriptions)
            {
                string formattedTime = $"{subscription.SubscriptionHours}";

                // Assuming SubscriptionTable has properties that match the columns you want to display
                dataGridViewTimeTable.Rows.Add(
                    formattedTime,
                    subscription.SubscriptionName,
                    subscription.SubscriptionAmount
                );
            }
        }

        public void Clear()
        {
            // Clear existing rows
            dataGridViewTimeTable.Rows.Clear();
        }

        public void SetRowClickEventHandler(DataGridViewCellEventHandler handler)
        {
            // Assign the new event handler
            if (handler != null)
            {
                // Remove any previous handlers to avoid duplication
                dataGridViewTimeTable.CellDoubleClick -= handler;

                // Add the new handler
                dataGridViewTimeTable.CellDoubleClick += handler;
            }
        }

        public List<List<object>> GetAllRowsData()
        {
            var allRowsData = new List<List<object>>();
            foreach (DataGridViewRow row in dataGridViewTimeTable.Rows)
            {
                var rowData = new List<object>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add(cell.Value);
                }
                allRowsData.Add(rowData);
            }
            return allRowsData;
        }
    }
}
