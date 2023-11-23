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
    public partial class DeleteTime : Form
    {
        public DeleteTime()
        {
            DatabaseAut database = new DatabaseAut();
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
            var values = source.GetRowValues(rowIndex);

            if (values.Count > 0)
            {
                target.AddRow(values.ToArray());
                source.RemoveRowAt(rowIndex);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var rowsToDelete = timeTableDelete.GetAllRowsData();

            foreach (var rowValues in rowsToDelete)
            {
                string time = rowValues[0].ToString();
                string name = rowValues[1].ToString();

                DatabaseAut.DeleteSubscription(time, name);
            }
            timeTableDelete.Clear();
            this.Close();
        }
    }
}
