namespace SeaStory.UI.AdminFoodManagement
{
    partial class ManageFoodChildAdmin
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
            System.Windows.Forms.Button buttonAddFood;
            buttonDeleteFood = new System.Windows.Forms.Button();
            buttonAddFood = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // buttonAddFood
            // 
            buttonAddFood.Location = new System.Drawing.Point(675, 92);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new System.Drawing.Size(75, 23);
            buttonAddFood.TabIndex = 4;
            buttonAddFood.Text = "음식 추가";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonDeleteFood
            // 
            buttonDeleteFood.Location = new System.Drawing.Point(675, 149);
            buttonDeleteFood.Name = "buttonDeleteFood";
            buttonDeleteFood.Size = new System.Drawing.Size(75, 23);
            buttonDeleteFood.TabIndex = 5;
            buttonDeleteFood.Text = "음식 삭제";
            buttonDeleteFood.UseVisualStyleBackColor = true;
            buttonDeleteFood.Click += buttonDeleteFood_Click;
            // 
            // ManageFoodChildAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonDeleteFood);
            Controls.Add(buttonAddFood);
            Name = "ManageFoodChildAdmin";
            Text = "ManageFoodChildAdmin";
            Controls.SetChildIndex(flowLayoutPanelMenuItems, 0);
            Controls.SetChildIndex(buttonAddFood, 0);
            Controls.SetChildIndex(buttonDeleteFood, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonDeleteFood;
    }
}