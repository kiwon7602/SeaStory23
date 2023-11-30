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
            buttonAddFood.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAddFood.ForeColor = System.Drawing.Color.Blue;
            buttonAddFood.Location = new System.Drawing.Point(669, 75);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new System.Drawing.Size(104, 48);
            buttonAddFood.TabIndex = 4;
            buttonAddFood.Text = "음식 추가";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonDeleteFood
            // 
            buttonDeleteFood.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDeleteFood.ForeColor = System.Drawing.Color.Red;
            buttonDeleteFood.Location = new System.Drawing.Point(669, 168);
            buttonDeleteFood.Name = "buttonDeleteFood";
            buttonDeleteFood.Size = new System.Drawing.Size(104, 48);
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
            Controls.Add(buttonAddFood);
            Controls.Add(buttonDeleteFood);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ManageFoodChildAdmin";
            Text = "음식 관리";
            Controls.SetChildIndex(flowLayoutPanelMenuItems, 0);
            Controls.SetChildIndex(buttonDeleteFood, 0);
            Controls.SetChildIndex(buttonAddFood, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonDeleteFood;
    }
}