namespace SeaStory.manage_menu_branch
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
            panel1 = new System.Windows.Forms.Panel();
            pictureBoxFood = new System.Windows.Forms.PictureBox();
            labelFoodName = new System.Windows.Forms.Label();
            labelPrice = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Yellow;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBoxFood);
            panel1.Controls.Add(labelFoodName);
            panel1.Controls.Add(labelPrice);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(122, 140);
            panel1.TabIndex = 3;
            // 
            // pictureBoxFood
            // 
            pictureBoxFood.BackColor = System.Drawing.SystemColors.Highlight;
            pictureBoxFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBoxFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBoxFood.Location = new System.Drawing.Point(12, 14);
            pictureBoxFood.Name = "pictureBoxFood";
            pictureBoxFood.Size = new System.Drawing.Size(91, 69);
            pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxFood.TabIndex = 5;
            pictureBoxFood.TabStop = false;
            // 
            // labelFoodName
            // 
            labelFoodName.AutoSize = true;
            labelFoodName.BackColor = System.Drawing.Color.Lime;
            labelFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelFoodName.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFoodName.Location = new System.Drawing.Point(12, 86);
            labelFoodName.Name = "labelFoodName";
            labelFoodName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            labelFoodName.Size = new System.Drawing.Size(91, 27);
            labelFoodName.TabIndex = 4;
            labelFoodName.Text = "음식 이름";
            labelFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelFoodName.Click += labelFoodName_Click_1;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = System.Drawing.Color.DodgerBlue;
            labelPrice.Location = new System.Drawing.Point(12, 113);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(54, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "10000원";
            labelPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            labelPrice.Click += labelPrice_Click;
            // 
            // MenuItemControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MenuItemControl";
            Size = new System.Drawing.Size(145, 158);
            Load += MenuItemControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelPrice;
    }
}
