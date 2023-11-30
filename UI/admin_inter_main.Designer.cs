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
            button2 = new System.Windows.Forms.Button();
            button24 = new System.Windows.Forms.Button();
            button25 = new System.Windows.Forms.Button();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            seatPanelAdmin1 = new UI.Seats.SeatPanelAdmin();
            button3 = new System.Windows.Forms.Button();
            appCloseButton1 = new UI.AppCloseButton();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(29, 21);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(144, 64);
            button2.TabIndex = 3;
            button2.Text = "요리 주문 목록";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button24
            // 
            button24.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button24.Location = new System.Drawing.Point(473, 21);
            button24.Name = "button24";
            button24.Size = new System.Drawing.Size(105, 56);
            button24.TabIndex = 1;
            button24.Text = "요금제 관리";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button25.Location = new System.Drawing.Point(603, 21);
            button25.Name = "button25";
            button25.Size = new System.Drawing.Size(105, 56);
            button25.TabIndex = 2;
            button25.Text = "음식 관리";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button25_Click;
            // 
            // seatPanelAdmin1
            // 
            seatPanelAdmin1.BackColor = System.Drawing.Color.FromArgb(251, 251, 251);
            seatPanelAdmin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            seatPanelAdmin1.Location = new System.Drawing.Point(254, 90);
            seatPanelAdmin1.Name = "seatPanelAdmin1";
            seatPanelAdmin1.Size = new System.Drawing.Size(471, 309);
            seatPanelAdmin1.TabIndex = 6;
            seatPanelAdmin1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(330, 21);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(105, 56);
            button3.TabIndex = 0;
            button3.Text = "회원 관리";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // appCloseButton1
            // 
            appCloseButton1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            appCloseButton1.Location = new System.Drawing.Point(34, 358);
            appCloseButton1.Margin = new System.Windows.Forms.Padding(4);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(156, 41);
            appCloseButton1.TabIndex = 7;
            // 
            // admin_inter_main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            ClientSize = new System.Drawing.Size(780, 450);
            ControlBox = false;
            Controls.Add(appCloseButton1);
            Controls.Add(button3);
            Controls.Add(seatPanelAdmin1);
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button2);
            Name = "admin_inter_main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "관리자";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private UI.Seats.SeatPanelAdmin seatPanelAdmin1;
        private System.Windows.Forms.Button button3;
        private UI.AppCloseButton appCloseButton1;
    }
}