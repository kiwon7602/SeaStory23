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
            buttonSelect = new System.Windows.Forms.Button();
            labelSeatNum = new System.Windows.Forms.Label();
            labelUser = new System.Windows.Forms.Label();
            labelRemainingTime = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new System.Drawing.Point(36, 113);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new System.Drawing.Size(75, 23);
            buttonSelect.TabIndex = 0;
            buttonSelect.Text = "선택";
            buttonSelect.UseVisualStyleBackColor = true;
            // 
            // labelSeatNum
            // 
            labelSeatNum.AutoSize = true;
            labelSeatNum.Location = new System.Drawing.Point(56, 30);
            labelSeatNum.Name = "labelSeatNum";
            labelSeatNum.Size = new System.Drawing.Size(55, 15);
            labelSeatNum.TabIndex = 1;
            labelSeatNum.Text = "자리번호";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new System.Drawing.Point(56, 59);
            labelUser.Name = "labelUser";
            labelUser.Size = new System.Drawing.Size(18, 15);
            labelUser.TabIndex = 2;
            labelUser.Text = "ID";
            // 
            // labelRemainingTime
            // 
            labelRemainingTime.AutoSize = true;
            labelRemainingTime.Location = new System.Drawing.Point(56, 86);
            labelRemainingTime.Name = "labelRemainingTime";
            labelRemainingTime.Size = new System.Drawing.Size(33, 15);
            labelRemainingTime.TabIndex = 3;
            labelRemainingTime.Text = "Time";
            // 
            // Seat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(labelRemainingTime);
            Controls.Add(labelUser);
            Controls.Add(labelSeatNum);
            Controls.Add(buttonSelect);
            Name = "Seat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelSeatNum;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelRemainingTime;
    }
}
