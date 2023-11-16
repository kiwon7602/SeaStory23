namespace SeaStory.UI.AdminFoodManagement
{
    partial class MenuItemControl
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
            labelPrice = new System.Windows.Forms.Label();
            labelFoodName = new System.Windows.Forms.Label();
            pictureBoxFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).BeginInit();
            SuspendLayout();
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new System.Drawing.Point(52, 133);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(54, 15);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "10000원";
            // 
            // labelFoodName
            // 
            labelFoodName.AutoSize = true;
            labelFoodName.Location = new System.Drawing.Point(43, 106);
            labelFoodName.Name = "labelFoodName";
            labelFoodName.Size = new System.Drawing.Size(59, 15);
            labelFoodName.TabIndex = 1;
            labelFoodName.Text = "음식 이름";
            // 
            // pictureBoxFood
            // 
            pictureBoxFood.Location = new System.Drawing.Point(22, 3);
            pictureBoxFood.Name = "pictureBoxFood";
            pictureBoxFood.Size = new System.Drawing.Size(102, 91);
            pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxFood.TabIndex = 2;
            pictureBoxFood.TabStop = false;
            // 
            // MenuItemControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureBoxFood);
            Controls.Add(labelFoodName);
            Controls.Add(labelPrice);
            Name = "MenuItemControl";
            Size = new System.Drawing.Size(145, 158);
            Load += MenuItemControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.PictureBox pictureBoxFood;
    }
}
