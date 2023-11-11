namespace SeaStory.UI.AdminFoodManagement
{
    partial class ManageFoodChildUser
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
            buttonPay = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // buttonPay
            // 
            buttonPay.Location = new System.Drawing.Point(695, 105);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new System.Drawing.Size(75, 23);
            buttonPay.TabIndex = 4;
            buttonPay.Text = "결제";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += GetInfoButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(695, 159);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += CloseButton_Click;
            // 
            // ManageFoodChildUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonPay);
            Name = "ManageFoodChildUser";
            Text = "ManageFoodChildUser";
            Controls.SetChildIndex(flowLayoutPanelMenuItems, 0);
            Controls.SetChildIndex(buttonPay, 0);
            Controls.SetChildIndex(buttonCancel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonCancel;
    }
}