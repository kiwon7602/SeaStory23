namespace SeaStory.ui
{
    partial class UserInterFacePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterFacePayment));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            labelPrice = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Location = new System.Drawing.Point(58, 118);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(159, 170);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.Location = new System.Drawing.Point(297, 118);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(159, 170);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.Location = new System.Drawing.Point(540, 118);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(159, 170);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new System.Drawing.Point(76, 42);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(33, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // user_interface_pay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(labelPrice);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "user_interface_pay";
            Text = "user_interface_pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPrice;
    }
}