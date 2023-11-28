
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
            button11 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            appCloseButton1 = new UI.AppCloseButton();
            timeTable1 = new UI.TimeManagement.TimeTable();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.White;
            button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button7.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(334, 226);
            button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(111, 46);
            button7.TabIndex = 1;
            button7.Text = "랭킹보기";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.White;
            button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button10.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button10.Location = new System.Drawing.Point(334, 309);
            button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(111, 46);
            button10.TabIndex = 2;
            button10.Text = "요리주문";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.Color.White;
            button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button11.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button11.ForeColor = System.Drawing.Color.Black;
            button11.Location = new System.Drawing.Point(599, 349);
            button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(104, 81);
            button11.TabIndex = 4;
            button11.Text = "사용종료";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 15);
            label1.TabIndex = 12;
            label1.Text = "회원요금";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(334, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(392, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(19, 15);
            label4.TabIndex = 15;
            label4.Text = "님";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(494, 41);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 15);
            label5.TabIndex = 16;
            label5.Text = "남은 적립 시간";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(640, 41);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 15);
            label6.TabIndex = 17;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(334, 92);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 15);
            label7.TabIndex = 18;
            label7.Text = "좌석 번호";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(334, 119);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(39, 15);
            label8.TabIndex = 19;
            label8.Text = "label8";
            // 
            // appCloseButton1
            // 
            appCloseButton1.BackColor = System.Drawing.Color.White;
            appCloseButton1.Location = new System.Drawing.Point(677, 521);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(111, 29);
            appCloseButton1.TabIndex = 5;
            appCloseButton1.Load += appCloseButton1_Load;
            // 
            // timeTable1
            // 
            timeTable1.Location = new System.Drawing.Point(44, 119);
            timeTable1.Name = "timeTable1";
            timeTable1.Size = new System.Drawing.Size(259, 311);
            timeTable1.TabIndex = 21;
            timeTable1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(334, 384);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 46);
            button1.TabIndex = 3;
            button1.Text = "주문목록";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // user_interface_main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 562);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(timeTable1);
            Controls.Add(appCloseButton1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "user_interface_main";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private UI.AppCloseButton appCloseButton1;
        private UI.TimeManagement.TimeTable timeTable1;
        private System.Windows.Forms.Button button1;
    }
}