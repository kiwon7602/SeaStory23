namespace SeaStory.ui
{
    partial class AdminFoodManagement
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
            PageName = new System.Windows.Forms.Label();
            AddFood = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // PageName
            // 
            PageName.AutoSize = true;
            PageName.Location = new System.Drawing.Point(44, 31);
            PageName.Name = "PageName";
            PageName.Size = new System.Drawing.Size(58, 15);
            PageName.TabIndex = 0;
            PageName.Text = "음식 목록";
            // 
            // AddFood
            // 
            AddFood.Location = new System.Drawing.Point(670, 93);
            AddFood.Name = "AddFood";
            AddFood.Size = new System.Drawing.Size(75, 23);
            AddFood.TabIndex = 1;
            AddFood.Text = "음식 추가";
            AddFood.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(670, 166);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminFoodManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button2);
            Controls.Add(AddFood);
            Controls.Add(PageName);
            Name = "AdminFoodManagement";
            Text = "AdminFoodManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.Button button2;
    }
}