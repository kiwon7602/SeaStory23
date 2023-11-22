using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Tls;
using SeaStory.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaStory.UI.Seats
{
    public partial class SeatPanel : UserControl
    {
        protected FlowLayoutPanel flowLayoutPanel;
        private Timer updateTimer;
        public delegate void SeatClickHandler(string userId, int userType, string seat);
        protected SeatClickHandler seatClickHandler;

        public SeatPanel()
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
            InitializeTimer();
        }
        public void SetSeatClickHandler(SeatClickHandler handler)
        {
            seatClickHandler = handler;
        }
        private void InitializeFlowLayoutPanel()
        {
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(flowLayoutPanel);
            UpdateSeats();
        }
        private void UpdateSeats()
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
                    existingSeatControl.UpdateSeat(seat.SeatNumber, seat.UserID, seat.UsageTime);
                    seatControl = existingSeatControl;
                }
                else
                {
                    // Create new control and add it
                    seatControl = new Seat(seat.SeatNumber, seat.UserID, seat.UsageTime);
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
        protected void AttachEventHandler(Seat seatControl)
        {    
            // Attach the new event handler

            if (seatClickHandler != null)
            {
                seatControl.AttachEventHandler(seatClickHandler);
            }
        }

        private void InitializeTimer()
        {
            updateTimer = new Timer
            {
                Interval = 1000 // 1 second
            };
            updateTimer.Tick += (sender, e) => UpdateSeats();
            updateTimer.Start();
        }
    }
}
