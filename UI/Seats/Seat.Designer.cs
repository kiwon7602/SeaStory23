namespace SeaStory.UI.Seats
{
    partial class Seat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            labelRemainingTime = new System.Windows.Forms.Label();
            labelUser = new System.Windows.Forms.Label();
            labelSeatNum = new System.Windows.Forms.Label();
            buttonSelect = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(labelRemainingTime);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(labelSeatNum);
            panel1.Controls.Add(buttonSelect);
            panel1.Location = new System.Drawing.Point(14, 13);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(122, 127);
            panel1.TabIndex = 4;
            // 
            // labelRemainingTime
            // 
            labelRemainingTime.AutoSize = true;
            labelRemainingTime.Location = new System.Drawing.Point(44, 64);
            labelRemainingTime.Name = "labelRemainingTime";
            labelRemainingTime.Size = new System.Drawing.Size(33, 15);
            labelRemainingTime.TabIndex = 7;
            labelRemainingTime.Text = "Time";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new System.Drawing.Point(44, 38);
            labelUser.Name = "labelUser";
            labelUser.Size = new System.Drawing.Size(19, 15);
            labelUser.TabIndex = 6;
            labelUser.Text = "ID";
            // 
            // labelSeatNum
            // 
            labelSeatNum.AutoSize = true;
            labelSeatNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSeatNum.Location = new System.Drawing.Point(8, 10);
            labelSeatNum.Name = "labelSeatNum";
            labelSeatNum.Size = new System.Drawing.Size(88, 25);
            labelSeatNum.TabIndex = 5;
            labelSeatNum.Text = "자리번호";
            labelSeatNum.Click += labelSeatNum_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.BackColor = System.Drawing.Color.Silver;
            buttonSelect.Location = new System.Drawing.Point(22, 95);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new System.Drawing.Size(75, 23);
            buttonSelect.TabIndex = 4;
            buttonSelect.Text = "선택";
            buttonSelect.UseVisualStyleBackColor = false;
            // 
            // Seat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Seat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSeatNum;
        private System.Windows.Forms.Button buttonSelect;
    }
}
