namespace SeaStory.UI.TimeManagement
{
    partial class DeleteTime
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
            timeTableKeep = new TimeTable();
            timeTableDelete = new TimeTable();
            buttonConfirm = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            labelKeep = new System.Windows.Forms.Label();
            labelDelete = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timeTableKeep
            // 
            timeTableKeep.Location = new System.Drawing.Point(22, 87);
            timeTableKeep.Name = "timeTableKeep";
            timeTableKeep.Size = new System.Drawing.Size(320, 313);
            timeTableKeep.TabIndex = 0;
            // 
            // timeTableDelete
            // 
            timeTableDelete.Location = new System.Drawing.Point(459, 87);
            timeTableDelete.Name = "timeTableDelete";
            timeTableDelete.Size = new System.Drawing.Size(320, 313);
            timeTableDelete.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonConfirm.Location = new System.Drawing.Point(362, 121);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new System.Drawing.Size(75, 39);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "확인";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCancel.Location = new System.Drawing.Point(362, 195);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            buttonCancel.Size = new System.Drawing.Size(75, 39);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelKeep
            // 
            labelKeep.AutoSize = true;
            labelKeep.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelKeep.Location = new System.Drawing.Point(141, 50);
            labelKeep.Name = "labelKeep";
            labelKeep.Size = new System.Drawing.Size(50, 25);
            labelKeep.TabIndex = 4;
            labelKeep.Text = "유지";
            // 
            // labelDelete
            // 
            labelDelete.AutoSize = true;
            labelDelete.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDelete.ForeColor = System.Drawing.Color.Red;
            labelDelete.Location = new System.Drawing.Point(595, 50);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new System.Drawing.Size(50, 25);
            labelDelete.TabIndex = 5;
            labelDelete.Text = "삭제";
            // 
            // DeleteTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(labelDelete);
            Controls.Add(labelKeep);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(timeTableDelete);
            Controls.Add(timeTableKeep);
            Name = "DeleteTime";
            Text = "요금제 삭제";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TimeTable timeTableKeep;
        private TimeTable timeTableDelete;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelKeep;
        private System.Windows.Forms.Label labelDelete;
    }
}