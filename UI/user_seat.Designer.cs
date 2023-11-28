namespace SeaStory.UI
{
    partial class user_seat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            seat_opend = new System.Windows.Forms.Label();
            seat_used = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Back_Button = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            appCloseButton1 = new AppCloseButton();
            seatPanel1 = new Seats.SeatPanel();
            SuspendLayout();
            // 
            // seat_opend
            // 
            seat_opend.AutoSize = true;
            seat_opend.Location = new System.Drawing.Point(46, 59);
            seat_opend.Name = "seat_opend";
            seat_opend.Size = new System.Drawing.Size(43, 15);
            seat_opend.TabIndex = 1;
            seat_opend.Text = "잔여석";
            // 
            // seat_used
            // 
            seat_used.AutoSize = true;
            seat_used.ForeColor = System.Drawing.Color.Red;
            seat_used.Location = new System.Drawing.Point(162, 59);
            seat_used.Name = "seat_used";
            seat_used.Size = new System.Drawing.Size(43, 15);
            seat_used.TabIndex = 2;
            seat_used.Text = "사용중";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(162, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Back_Button
            // 
            Back_Button.Location = new System.Drawing.Point(697, 32);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new System.Drawing.Size(75, 23);
            Back_Button.TabIndex = 99;
            Back_Button.Text = "뒤로 가기";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(345, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(441, 59);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "님 환영합니다";
            // 
            // appCloseButton1
            // 
            appCloseButton1.Location = new System.Drawing.Point(46, 399);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(111, 29);
            appCloseButton1.TabIndex = 100;
            // 
            // seatPanel1
            // 
            seatPanel1.Location = new System.Drawing.Point(225, 103);
            seatPanel1.Name = "seatPanel1";
            seatPanel1.Size = new System.Drawing.Size(547, 325);
            seatPanel1.TabIndex = 9;
            // 
            // user_seat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(seatPanel1);
            Controls.Add(appCloseButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Back_Button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(seat_used);
            Controls.Add(seat_opend);
            Name = "user_seat";
            Text = "user_seat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label seat_opend;
        private System.Windows.Forms.Label seat_used;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AppCloseButton appCloseButton1;
        private Seats.SeatPanel seatPanel1;
    }
}