namespace SeaStory.ui
{
    partial class admin_inter_main
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button24 = new System.Windows.Forms.Button();
            button25 = new System.Windows.Forms.Button();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.BackgroundImage = Properties.Resources._366033;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(12, 21);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(107, 91);
            button1.TabIndex = 0;
            button1.Text = "강제 종료";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(12, 164);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(107, 90);
            button2.TabIndex = 1;
            button2.Text = "요리 주문 목록";
            button2.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Location = new System.Drawing.Point(492, 21);
            button24.Name = "button24";
            button24.Size = new System.Drawing.Size(100, 56);
            button24.TabIndex = 3;
            button24.Text = "요금제 관리";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.Location = new System.Drawing.Point(625, 21);
            button25.Name = "button25";
            button25.Size = new System.Drawing.Size(100, 56);
            button25.TabIndex = 4;
            button25.Text = "음식 관리";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button25_Click;
            // 
            // admin_inter_main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.배경;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "admin_inter_main";
            Text = "admin_inter_main";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private UI.AppCloseButton appCloseButton1;
        private UI.Seats.SeatPanel seatPanel1;
    }
}