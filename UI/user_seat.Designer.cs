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
            this.seat_opend = new System.Windows.Forms.Label();
            this.seat_used = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.appCloseButton1 = new SeaStory.UI.AppCloseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seatPanel1 = new SeaStory.UI.Seats.SeatPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // seat_opend
            // 
            this.seat_opend.AutoSize = true;
            this.seat_opend.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat_opend.Location = new System.Drawing.Point(16, 16);
            this.seat_opend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seat_opend.Name = "seat_opend";
            this.seat_opend.Size = new System.Drawing.Size(72, 28);
            this.seat_opend.TabIndex = 1;
            this.seat_opend.Text = "잔여석";
            // 
            // seat_used
            // 
            this.seat_used.AutoSize = true;
            this.seat_used.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seat_used.ForeColor = System.Drawing.Color.Red;
            this.seat_used.Location = new System.Drawing.Point(165, 16);
            this.seat_used.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seat_used.Name = "seat_used";
            this.seat_used.Size = new System.Drawing.Size(72, 28);
            this.seat_used.TabIndex = 2;
            this.seat_used.Text = "사용중";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Back_Button
            // 
            this.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Button.Location = new System.Drawing.Point(790, 45);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(141, 48);
            this.Back_Button.TabIndex = 99;
            this.Back_Button.Text = "뒤로 가기";
            this.Back_Button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "님 환영합니다";
            // 
            // appCloseButton1
            // 
            this.appCloseButton1.BackColor = System.Drawing.Color.White;
            this.appCloseButton1.Location = new System.Drawing.Point(59, 481);
            this.appCloseButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appCloseButton1.Name = "appCloseButton1";
            this.appCloseButton1.Size = new System.Drawing.Size(172, 54);
            this.appCloseButton1.TabIndex = 100;
            this.appCloseButton1.Load += new System.EventHandler(this.appCloseButton1_Load);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.seatPanel1);
            this.panel1.Location = new System.Drawing.Point(327, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 348);
            this.panel1.TabIndex = 101;
            // 
            // seatPanel1
            // 
            this.seatPanel1.AutoSize = true;
            this.seatPanel1.Location = new System.Drawing.Point(23, 11);
            this.seatPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seatPanel1.Name = "seatPanel1";
            this.seatPanel1.Size = new System.Drawing.Size(560, 331);
            this.seatPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.seat_opend);
            this.panel2.Controls.Add(this.seat_used);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 125);
            this.panel2.TabIndex = 102;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(327, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 125);
            this.panel3.TabIndex = 103;
            // 
            // user_seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 630);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.appCloseButton1);
            this.Controls.Add(this.Back_Button);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "user_seat";
            this.Text = "user_seat";
            this.Load += new System.EventHandler(this.user_seat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}