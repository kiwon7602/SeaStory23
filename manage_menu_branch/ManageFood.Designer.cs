namespace SeaStory.manage_menu_branch
{
    partial class ManageFood
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
            buttonAddFood = new System.Windows.Forms.Button();
            buttonDeleteFood = new System.Windows.Forms.Button();
            flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new System.Drawing.Point(49, 33);
            title.Name = "title";
            title.Size = new System.Drawing.Size(58, 15);
            title.TabIndex = 0;
            title.Text = "음식 목록";
            // 
            // buttonAddFood
            // 
            buttonAddFood.Location = new System.Drawing.Point(675, 99);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new System.Drawing.Size(75, 23);
            buttonAddFood.TabIndex = 1;
            buttonAddFood.Text = "음식 추가";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonDeleteFood
            // 
            buttonDeleteFood.Location = new System.Drawing.Point(675, 186);
            buttonDeleteFood.Name = "buttonDeleteFood";
            buttonDeleteFood.Size = new System.Drawing.Size(75, 23);
            buttonDeleteFood.TabIndex = 2;
            buttonDeleteFood.Text = "음식 삭제";
            buttonDeleteFood.UseVisualStyleBackColor = true;
            buttonDeleteFood.Click += buttonDeleteFood_Click;
            // 
            // flowLayoutPanelMenuItems
            // 
            flowLayoutPanelMenuItems.AutoScroll = true;
            flowLayoutPanelMenuItems.Location = new System.Drawing.Point(49, 75);
            flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            flowLayoutPanelMenuItems.Size = new System.Drawing.Size(601, 334);
            flowLayoutPanelMenuItems.TabIndex = 3;
            // 
            // ManageFood
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flowLayoutPanelMenuItems);
            Controls.Add(buttonDeleteFood);
            Controls.Add(buttonAddFood);
            Controls.Add(title);
            Name = "ManageFood";
            Text = "ManageFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
    }
}