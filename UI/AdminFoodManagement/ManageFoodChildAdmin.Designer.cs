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
            this.buttonDeleteFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            buttonAddFood = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Location = new System.Drawing.Point(33, 80);
            buttonAddFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new System.Drawing.Size(109, 49);
            buttonAddFood.TabIndex = 4;
            buttonAddFood.Text = "음식 추가";
            buttonAddFood.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFood
            // 
            this.buttonDeleteFood.Location = new System.Drawing.Point(33, 156);
            this.buttonDeleteFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteFood.Name = "buttonDeleteFood";
            this.buttonDeleteFood.Size = new System.Drawing.Size(109, 49);
            this.buttonDeleteFood.TabIndex = 5;
            this.buttonDeleteFood.Text = "음식 삭제";
            this.buttonDeleteFood.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(buttonAddFood);
            this.panel1.Controls.Add(this.buttonDeleteFood);
            this.panel1.Location = new System.Drawing.Point(843, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 445);
            this.panel1.TabIndex = 6;
            // 
            // ManageFoodChildAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ManageFoodChildAdmin";
            this.Text = "ManageFoodChildAdmin";
            this.Controls.SetChildIndex(this.flowLayoutPanelMenuItems, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.Panel panel1;
    }
}