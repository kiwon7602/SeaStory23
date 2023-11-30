namespace SeaStory.UI.AdminFoodManagement
{
    partial class DeleteFoodForm
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
            labelTitle = new System.Windows.Forms.Label();
            flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            buttonDeleteCheckedFood = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new System.Drawing.Point(58, 37);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(59, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "음식 삭제";
            // 
            // flowLayoutPanelMenuItems
            // 
            flowLayoutPanelMenuItems.AutoScroll = true;
            flowLayoutPanelMenuItems.Location = new System.Drawing.Point(58, 69);
            flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            flowLayoutPanelMenuItems.Size = new System.Drawing.Size(679, 309);
            flowLayoutPanelMenuItems.TabIndex = 1;
            // 
            // buttonDeleteCheckedFood
            // 
            buttonDeleteCheckedFood.Location = new System.Drawing.Point(543, 404);
            buttonDeleteCheckedFood.Name = "buttonDeleteCheckedFood";
            buttonDeleteCheckedFood.Size = new System.Drawing.Size(75, 23);
            buttonDeleteCheckedFood.TabIndex = 2;
            buttonDeleteCheckedFood.Text = "삭제";
            buttonDeleteCheckedFood.UseVisualStyleBackColor = true;
            buttonDeleteCheckedFood.Click += buttonDeleteCheckedFood_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(662, 404);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // DeleteFoodForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDeleteCheckedFood);
            Controls.Add(flowLayoutPanelMenuItems);
            Controls.Add(labelTitle);
            Name = "DeleteFoodForm";
            Text = "음식 삭제";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
        private System.Windows.Forms.Button buttonDeleteCheckedFood;
        private System.Windows.Forms.Button buttonCancel;
    }
}