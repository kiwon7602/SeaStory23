namespace SeaStory.UI.AdminFoodManagement
{
    partial class ManageFoodParent
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
            title = new System.Windows.Forms.Label();
            flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title.Location = new System.Drawing.Point(49, 33);
            title.Name = "title";
            title.Size = new System.Drawing.Size(104, 30);
            title.TabIndex = 0;
            title.Text = "음식 목록";
            // 
            // flowLayoutPanelMenuItems
            // 
            flowLayoutPanelMenuItems.AutoScroll = true;
            flowLayoutPanelMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanelMenuItems.Location = new System.Drawing.Point(49, 75);
            flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            flowLayoutPanelMenuItems.Size = new System.Drawing.Size(602, 334);
            flowLayoutPanelMenuItems.TabIndex = 3;
            // 
            // ManageFoodParent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flowLayoutPanelMenuItems);
            Controls.Add(title);
            Name = "ManageFoodParent";
            Text = "ManageFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label title;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
    }
}