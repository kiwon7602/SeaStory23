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
    public partial class DeleteTime : Form
    {
        public DeleteTime()
        {
            InitializeComponent();

            timeTableDelete.Clear();
            timeTableKeep.SetRowClickEventHandler(TimeTableKeep_CellDoubleClick);
            timeTableDelete.SetRowClickEventHandler(TimeTableDelete_CellDoubleClick);
        }

        private void TimeTableKeep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TransferRow(timeTableKeep, timeTableDelete, e.RowIndex);
        }

        private void TimeTableDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TransferRow(timeTableDelete, timeTableKeep, e.RowIndex);
        }

        private void TransferRow(TimeTable source, TimeTable target, int rowIndex)
        {
            // Get the values from the source row
            var values = source.GetRowValues(rowIndex);

            // Add a new row to the target TimeTable with the values from the source row
            if (values.Count > 0)
            {
                target.AddRow(values.ToArray());

                // Remove the row from the source TimeTable
                source.RemoveRowAt(rowIndex);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Get all the rows from the UserControl's DataGridView
            var rowsToDelete = timeTableDelete.GetAllRowsData();

            foreach (var rowValues in rowsToDelete)
            {
                // Assuming the first cell is 'time' and the second cell is 'name'
                string time = rowValues[0].ToString();
                string name = rowValues[1].ToString();

                // Call the placeholder function to delete from the database
                DeleteSubscriptionFromDatabase(time, name);
            }

            // Clear the DataGridView in UserControl after deletion
            timeTableDelete.Clear();

            // Optionally, refresh the data on the form or close the form
            // RefreshTimeTable(); // This would need to be a method that refreshes both UserControl tables
            this.Close();
        }

        // Placeholder function for deleting from the database
        private void DeleteSubscriptionFromDatabase(string time, string name)
        {
            // Your code to delete the subscription from the database would go here
            Console.WriteLine($"Deleting subscription: Time - {time}, Name - {name}");
        }
    }
}
