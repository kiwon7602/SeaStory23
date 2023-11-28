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
            using (var addTimeForm = new AddTime())
            {
                addTimeForm.ShowDialog(this);
            }
            timeTable.RefreshTimeTable();
        }


        private void OpenDeleteTimeForm_Click(object sender, EventArgs e)
        {
            using (var deleteTimeForm = new DeleteTime())
            {
                deleteTimeForm.ShowDialog(this);
            }
            timeTable.RefreshTimeTable();
        }

        private void dataGridViewTimeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // Header row has RowIndex -1
            {
                // Cast sender to DataGridView and get the current row
                var dataGridView = sender as DataGridView;
                if (dataGridView != null)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    var subscriptionTime = row.Cells["time"].Value.ToString();
                    var subscriptionName = row.Cells["name"].Value.ToString();
                    var memberPrice = row.Cells["member_price"].Value.ToString();
                    MessageBox.Show($"Time: {subscriptionTime}, Subscription: {subscriptionName}, Price: {memberPrice}", "Row Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return;
        }
    }
}
