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

namespace SeaStory.UI.Seats
{
    public partial class SeatPanelAdmin : SeatPanel
    {
        public SeatPanelAdmin()
        {
            InitializeComponent();
        }

        protected override void UpdateSeats()
        {
            var seats = DatabaseNonAut.GetSeats();
            var currentSeatControls = flowLayoutPanel.Controls.OfType<Seat>().ToList();

            foreach (var seat in seats)
            {
                Seat seatControl;
                var existingSeatControl = currentSeatControls.FirstOrDefault(s => s.SeatNumber == seat.SeatNumber);
                if (existingSeatControl != null)
                {
                    // Update existing control
                    existingSeatControl.UpdateSeat(seat.SeatNumber, seat.UserID, seat.UsageTime, false);
                    seatControl = existingSeatControl;
                }
                else
                {
                    // Create new control and add it
                    seatControl = new Seat(seat.SeatNumber, seat.UserID, seat.UsageTime, "강제종료");
                    flowLayoutPanel.Controls.Add(seatControl);
                }

                AttachEventHandler(seatControl);
            }

            // Remove any extra controls that no longer have corresponding data
            foreach (var control in currentSeatControls.Where(c => !seats.Any(s => s.SeatNumber == c.SeatNumber)))
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}
