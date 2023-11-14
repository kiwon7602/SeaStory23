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
            buttonAddTime.Location = new System.Drawing.Point(677, 102);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new System.Drawing.Size(84, 23);
            buttonAddTime.TabIndex = 1;
            buttonAddTime.Text = "요금제 추가";
            buttonAddTime.UseVisualStyleBackColor = true;
            buttonAddTime.Click += OpenAddTimeForm_Click;
            // 
            // buttonDeleteTime
            // 
            buttonDeleteTime.Location = new System.Drawing.Point(677, 145);
            buttonDeleteTime.Name = "buttonDeleteTime";
            buttonDeleteTime.Size = new System.Drawing.Size(84, 23);
            buttonDeleteTime.TabIndex = 2;
            buttonDeleteTime.Text = "요금제 삭제";
            buttonDeleteTime.UseVisualStyleBackColor = true;
            buttonDeleteTime.Click += OpenDeleteTimeForm_Click;
            // 
            // ManageTimeAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonDeleteTime);
            Controls.Add(buttonAddTime);
            Controls.Add(timeTable);
            Name = "ManageTimeAdmin";
            Text = "ManageTimeAdmin";
            ResumeLayout(false);
        }

        #endregion

        private TimeTable timeTable;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Button buttonDeleteTime;
    }
}