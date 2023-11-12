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
            timeTableKeep.Location = new System.Drawing.Point(36, 87);
            timeTableKeep.Name = "timeTableKeep";
            timeTableKeep.Size = new System.Drawing.Size(320, 313);
            timeTableKeep.TabIndex = 0;
            // 
            // timeTableDelete
            // 
            timeTableDelete.Location = new System.Drawing.Point(443, 87);
            timeTableDelete.Name = "timeTableDelete";
            timeTableDelete.Size = new System.Drawing.Size(320, 313);
            timeTableDelete.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new System.Drawing.Point(362, 137);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new System.Drawing.Size(75, 23);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "확인";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(362, 177);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelKeep
            // 
            labelKeep.AutoSize = true;
            labelKeep.Location = new System.Drawing.Point(184, 51);
            labelKeep.Name = "labelKeep";
            labelKeep.Size = new System.Drawing.Size(31, 15);
            labelKeep.TabIndex = 4;
            labelKeep.Text = "유지";
            // 
            // labelDelete
            // 
            labelDelete.AutoSize = true;
            labelDelete.Location = new System.Drawing.Point(592, 51);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new System.Drawing.Size(31, 15);
            labelDelete.TabIndex = 5;
            labelDelete.Text = "삭제";
            // 
            // DeleteTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(labelDelete);
            Controls.Add(labelKeep);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(timeTableDelete);
            Controls.Add(timeTableKeep);
            Name = "DeleteTime";
            Text = "DeleteTime";
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