namespace SeaStory.UI.TimeManagement
{
    partial class ManageTimeAdmin
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
            timeTable = new TimeTable();
            buttonAddTime = new System.Windows.Forms.Button();
            buttonDeleteTime = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timeTable
            // 
            timeTable.Location = new System.Drawing.Point(60, 80);
            timeTable.Name = "timeTable";
            timeTable.Size = new System.Drawing.Size(571, 328);
            timeTable.TabIndex = 0;
            // 
            // buttonAddTime
            // 
            buttonAddTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAddTime.ForeColor = System.Drawing.Color.Blue;
            buttonAddTime.Location = new System.Drawing.Point(648, 80);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new System.Drawing.Size(113, 44);
            buttonAddTime.TabIndex = 1;
            buttonAddTime.Text = "요금제 추가";
            buttonAddTime.UseVisualStyleBackColor = true;
            buttonAddTime.Click += OpenAddTimeForm_Click;
            // 
            // buttonDeleteTime
            // 
            buttonDeleteTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDeleteTime.ForeColor = System.Drawing.Color.Red;
            buttonDeleteTime.Location = new System.Drawing.Point(648, 181);
            buttonDeleteTime.Name = "buttonDeleteTime";
            buttonDeleteTime.Size = new System.Drawing.Size(113, 44);
            buttonDeleteTime.TabIndex = 2;
            buttonDeleteTime.Text = "요금제 삭제";
            buttonDeleteTime.UseVisualStyleBackColor = true;
            buttonDeleteTime.Click += OpenDeleteTimeForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(60, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 25);
            label1.TabIndex = 3;
            label1.Text = "요금제 관리";
            // 
            // ManageTimeAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonDeleteTime);
            Controls.Add(buttonAddTime);
            Controls.Add(timeTable);
            Name = "ManageTimeAdmin";
            Text = "요금제 관리";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TimeTable timeTable;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Button buttonDeleteTime;
        private System.Windows.Forms.Label label1;
    }
}