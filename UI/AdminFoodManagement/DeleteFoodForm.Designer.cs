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
            labelTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(58, 37);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(95, 25);
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
            buttonDeleteCheckedFood.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            buttonDeleteCheckedFood.BackgroundImage = Properties.Resources.Button_PNG_Free_Download;
            buttonDeleteCheckedFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonDeleteCheckedFood.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDeleteCheckedFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonDeleteCheckedFood.Location = new System.Drawing.Point(540, 394);
            buttonDeleteCheckedFood.Name = "buttonDeleteCheckedFood";
            buttonDeleteCheckedFood.Size = new System.Drawing.Size(93, 44);
            buttonDeleteCheckedFood.TabIndex = 2;
            buttonDeleteCheckedFood.Text = "삭제";
            buttonDeleteCheckedFood.UseVisualStyleBackColor = false;
            buttonDeleteCheckedFood.Click += buttonDeleteCheckedFood_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            buttonCancel.BackgroundImage = Properties.Resources.Button_PNG_Free_Download;
            buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCancel.Location = new System.Drawing.Point(652, 394);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(85, 44);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // DeleteFoodForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Yellow;
            BackgroundImage = Properties.Resources._0268f49d4d229bcee46589954838b252d9aa3f89;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDeleteCheckedFood);
            Controls.Add(flowLayoutPanelMenuItems);
            Controls.Add(labelTitle);
            Name = "DeleteFoodForm";
            Text = "DeleteFoodForm";
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