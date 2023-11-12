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
    public partial class ManageTimeAdmin : Form
    {
        public ManageTimeAdmin()
        {
            InitializeComponent();
            timeTable.SetRowClickEventHandler(dataGridViewTimeTable_CellDoubleClick);

        }

        private void OpenAddTimeForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddTime form
            using (var addTimeForm = new AddTime())
            {
                // Show AddTime form as a modal dialog box
                addTimeForm.ShowDialog(this);

            }
            timeTable.Refresh();
        }

        private void OpenDeleteTimeForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddTime form
            using (var deleteTimeForm = new DeleteTime())
            {
                // Show AddTime form as a modal dialog box
                deleteTimeForm.ShowDialog(this);

            }
            timeTable.Refresh();
        }

        private void dataGridViewTimeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the click is on a row, not the column header
            if (e.RowIndex != -1) // Header row has RowIndex -1
            {
                // Cast sender to DataGridView and get the current row
                var dataGridView = sender as DataGridView;
                if (dataGridView != null)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    // Perform the action you need on row click
                    // For example, you can retrieve the data using the row index and show it
                    var subscriptionTime = row.Cells["time"].Value.ToString();
                    var subscriptionName = row.Cells["name"].Value.ToString();
                    var memberPrice = row.Cells["member_price"].Value.ToString();

                    // Let's say you want to show a message box with the subscription name
                    MessageBox.Show($"Time: {subscriptionTime}, Subscription: {subscriptionName}, Price: {memberPrice}", "Row Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return;
        }
    }
}
