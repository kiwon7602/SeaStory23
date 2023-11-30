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
            buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buttonPay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonPay.Location = new System.Drawing.Point(684, 75);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new System.Drawing.Size(86, 40);
            buttonPay.TabIndex = 4;
            buttonPay.Text = "결제";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += MakePayment_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buttonCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCancel.ForeColor = System.Drawing.Color.Red;
            buttonCancel.Location = new System.Drawing.Point(684, 156);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(86, 40);
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
            Controls.Add(buttonPay);
            Controls.Add(buttonCancel);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ManageFoodChildUser";
            Text = "음식 목록";
            Controls.SetChildIndex(flowLayoutPanelMenuItems, 0);
            Controls.SetChildIndex(buttonCancel, 0);
            Controls.SetChildIndex(buttonPay, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonCancel;
    }
}