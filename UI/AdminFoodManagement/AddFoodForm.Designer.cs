namespace SeaStory.UI.AdminFoodManagement
{
    partial class AddFoodForm
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
            pictureBoxFoodImage = new System.Windows.Forms.PictureBox();
            txtBoxFoodName = new System.Windows.Forms.TextBox();
            labelFoodName = new System.Windows.Forms.Label();
            labelFoodPrice = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnBrowse = new System.Windows.Forms.Button();
            numericUpDownFoodPrice = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoodImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFoodPrice).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoodImage
            // 
            pictureBoxFoodImage.Location = new System.Drawing.Point(46, 67);
            pictureBoxFoodImage.Name = "pictureBoxFoodImage";
            pictureBoxFoodImage.Size = new System.Drawing.Size(176, 195);
            pictureBoxFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxFoodImage.TabIndex = 0;
            pictureBoxFoodImage.TabStop = false;
            // 
            // txtBoxFoodName
            // 
            txtBoxFoodName.Location = new System.Drawing.Point(344, 104);
            txtBoxFoodName.Name = "txtBoxFoodName";
            txtBoxFoodName.Size = new System.Drawing.Size(181, 23);
            txtBoxFoodName.TabIndex = 1;
            // 
            // labelFoodName
            // 
            labelFoodName.AutoSize = true;
            labelFoodName.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            labelFoodName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFoodName.Location = new System.Drawing.Point(243, 102);
            labelFoodName.Name = "labelFoodName";
            labelFoodName.Size = new System.Drawing.Size(95, 25);
            labelFoodName.TabIndex = 3;
            labelFoodName.Text = "음식 이름";
            // 
            // labelFoodPrice
            // 
            labelFoodPrice.AutoSize = true;
            labelFoodPrice.BackColor = System.Drawing.Color.Cyan;
            labelFoodPrice.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFoodPrice.Location = new System.Drawing.Point(243, 157);
            labelFoodPrice.Name = "labelFoodPrice";
            labelFoodPrice.Size = new System.Drawing.Size(95, 25);
            labelFoodPrice.TabIndex = 4;
            labelFoodPrice.Text = "음식 가격";
            // 
            // btnOK
            // 
            btnOK.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnOK.BackgroundImage = Properties.Resources.Button_PNG_Free_Download;
            btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnOK.Location = new System.Drawing.Point(344, 278);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(91, 32);
            btnOK.TabIndex = 5;
            btnOK.Text = "등록";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnCancel.BackgroundImage = Properties.Resources.Button_PNG_Free_Download;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancel.Location = new System.Drawing.Point(451, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(85, 32);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            btnBrowse.BackgroundImage = Properties.Resources.Button_PNG_Free_Download;
            btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBrowse.Location = new System.Drawing.Point(85, 278);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(87, 32);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = "사진 찾기";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click_1;
            // 
            // numericUpDownFoodPrice
            // 
            numericUpDownFoodPrice.Location = new System.Drawing.Point(344, 159);
            numericUpDownFoodPrice.Name = "numericUpDownFoodPrice";
            numericUpDownFoodPrice.Size = new System.Drawing.Size(181, 23);
            numericUpDownFoodPrice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Red;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(46, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 25);
            label1.TabIndex = 9;
            label1.Text = "음식 추가";
            // 
            // AddFoodForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0268f49d4d229bcee46589954838b252d9aa3f89;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(575, 337);
            Controls.Add(label1);
            Controls.Add(numericUpDownFoodPrice);
            Controls.Add(btnBrowse);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(labelFoodPrice);
            Controls.Add(labelFoodName);
            Controls.Add(txtBoxFoodName);
            Controls.Add(pictureBoxFoodImage);
            Name = "AddFoodForm";
            Text = "AddFoodForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoodImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFoodPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFoodImage;
        private System.Windows.Forms.TextBox txtBoxFoodName;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelFoodPrice;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.NumericUpDown numericUpDownFoodPrice;
        private System.Windows.Forms.Label label1;
    }
}