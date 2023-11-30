
namespace SeaStory
{
    partial class user_interface_main
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
            button7 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            timeTable1 = new UI.TimeManagement.TimeTable();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            appCloseButton1 = new UI.AppCloseButton();
            button11 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button7.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(15, 10);
            button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(111, 46);
            button7.TabIndex = 1;
            button7.Text = "랭킹보기";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonViewRankings;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.SystemColors.ButtonFace;
            button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button10.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button10.Location = new System.Drawing.Point(145, 10);
            button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(111, 46);
            button10.TabIndex = 2;
            button10.Text = "요리주문";
            button10.UseVisualStyleBackColor = false;
            button10.Click += buttonOrderFood;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(84, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 28);
            label1.TabIndex = 12;
            label1.Text = "회원요금";
            // 
            // timeTable1
            // 
            timeTable1.Location = new System.Drawing.Point(4, 13);
            timeTable1.Margin = new System.Windows.Forms.Padding(4);
            timeTable1.Name = "timeTable1";
            timeTable1.Size = new System.Drawing.Size(267, 353);
            timeTable1.TabIndex = 21;
            timeTable1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(270, 10);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 46);
            button1.TabIndex = 3;
            button1.Text = "주문목록";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonViewOrderList;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(233, 233, 233);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new System.Drawing.Point(334, 32);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(397, 181);
            panel1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(19, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 30);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(165, 29);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 21);
            label5.TabIndex = 16;
            label5.Text = "남은 적립 시간";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(305, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 21);
            label6.TabIndex = 17;
            label6.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(19, 127);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 30);
            label8.TabIndex = 19;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(19, 92);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 21);
            label7.TabIndex = 18;
            label7.Text = "좌석 번호";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(233, 233, 233);
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button1);
            panel2.Location = new System.Drawing.Point(334, 228);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(397, 70);
            panel2.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel4.BackColor = System.Drawing.Color.FromArgb(233, 233, 233);
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(timeTable1);
            panel4.Location = new System.Drawing.Point(30, 87);
            panel4.Margin = new System.Windows.Forms.Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(277, 387);
            panel4.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.FromArgb(233, 233, 233);
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Controls.Add(label1);
            panel5.Location = new System.Drawing.Point(30, 32);
            panel5.Margin = new System.Windows.Forms.Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(277, 52);
            panel5.TabIndex = 26;
            // 
            // appCloseButton1
            // 
            appCloseButton1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            appCloseButton1.Location = new System.Drawing.Point(575, 434);
            appCloseButton1.Margin = new System.Windows.Forms.Padding(4);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(156, 40);
            appCloseButton1.TabIndex = 27;
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            button11.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button11.ForeColor = System.Drawing.Color.Black;
            button11.Location = new System.Drawing.Point(611, 330);
            button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(120, 81);
            button11.TabIndex = 4;
            button11.Text = "사용종료";
            button11.UseVisualStyleBackColor = false;
            button11.Click += buttonLogOut;
            // 
            // user_interface_main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(760, 515);
            ControlBox = false;
            Controls.Add(button11);
            Controls.Add(appCloseButton1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "user_interface_main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "한기대 PC방";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private UI.TimeManagement.TimeTable timeTable1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private UI.AppCloseButton appCloseButton1;
        private System.Windows.Forms.Button button11;
    }
}