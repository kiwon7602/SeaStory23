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
            panel1 = new System.Windows.Forms.Panel();
            seatPanel1 = new Seats.SeatPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // seat_opend
            // 
            seat_opend.AutoSize = true;
            seat_opend.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            seat_opend.Location = new System.Drawing.Point(59, 83);
            seat_opend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seat_opend.Name = "seat_opend";
            seat_opend.Size = new System.Drawing.Size(58, 21);
            seat_opend.TabIndex = 1;
            seat_opend.Text = "잔여석";
            // 
            // seat_used
            // 
            seat_used.AutoSize = true;
            seat_used.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            seat_used.ForeColor = System.Drawing.Color.Red;
            seat_used.Location = new System.Drawing.Point(208, 83);
            seat_used.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seat_used.Name = "seat_used";
            seat_used.Size = new System.Drawing.Size(58, 21);
            seat_used.TabIndex = 2;
            seat_used.Text = "사용중";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(59, 151);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 21);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(208, 151);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 21);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Back_Button
            // 
            Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Back_Button.Location = new System.Drawing.Point(896, 45);
            Back_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new System.Drawing.Size(96, 42);
            Back_Button.TabIndex = 99;
            Back_Button.Text = "뒤로 가기";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(444, 83);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 21);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(567, 83);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 21);
            label4.TabIndex = 7;
            label4.Text = "님 환영합니다";
            // 
            // appCloseButton1
            // 
            appCloseButton1.BackColor = System.Drawing.Color.Red;
            appCloseButton1.Location = new System.Drawing.Point(59, 559);
            appCloseButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(143, 41);
            appCloseButton1.TabIndex = 100;
            // 
            // panel1
            // 
            panel1.Controls.Add(seatPanel1);
            panel1.Location = new System.Drawing.Point(266, 129);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(747, 470);
            panel1.TabIndex = 101;
            // 
            // seatPanel1
            // 
            seatPanel1.Location = new System.Drawing.Point(23, 11);
            seatPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            seatPanel1.Name = "seatPanel1";
            seatPanel1.Size = new System.Drawing.Size(703, 455);
            seatPanel1.TabIndex = 10;
            seatPanel1.Load += seatPanel1_Load;
            // 
            // user_seat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1029, 630);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(appCloseButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Back_Button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(seat_used);
            Controls.Add(seat_opend);
            Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "user_seat";
            Text = "user_seat";
            panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private Seats.SeatPanel seatPanel1;
    }
}