namespace SeaStory.UI.TimeManagement
{
    partial class AddTime
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
            textBoxName = new System.Windows.Forms.TextBox();
            labelTime = new System.Windows.Forms.Label();
            labelMemberPrice = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            buttonAddTime = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxName.Location = new System.Drawing.Point(178, 78);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(120, 29);
            textBoxName.TabIndex = 2;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTime.Location = new System.Drawing.Point(39, 33);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(80, 21);
            labelTime.TabIndex = 3;
            labelTime.Text = "추가 시간";
            // 
            // labelMemberPrice
            // 
            labelMemberPrice.AutoSize = true;
            labelMemberPrice.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMemberPrice.Location = new System.Drawing.Point(39, 135);
            labelMemberPrice.Name = "labelMemberPrice";
            labelMemberPrice.Size = new System.Drawing.Size(80, 21);
            labelMemberPrice.TabIndex = 4;
            labelMemberPrice.Text = "회원 요금";
            labelMemberPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(39, 86);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(80, 21);
            labelName.TabIndex = 5;
            labelName.Text = "요금제 명";
            // 
            // buttonAddTime
            // 
            buttonAddTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddTime.ForeColor = System.Drawing.Color.Blue;
            buttonAddTime.Location = new System.Drawing.Point(86, 203);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new System.Drawing.Size(74, 32);
            buttonAddTime.TabIndex = 6;
            buttonAddTime.Text = "등록";
            buttonAddTime.UseVisualStyleBackColor = true;
            buttonAddTime.Click += buttonAddTime_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCancel.ForeColor = System.Drawing.Color.Red;
            buttonCancel.Location = new System.Drawing.Point(192, 203);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(74, 32);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "취소";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDownTime.Location = new System.Drawing.Point(178, 31);
            numericUpDownTime.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new System.Drawing.Size(120, 29);
            numericUpDownTime.TabIndex = 8;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDownPrice.Location = new System.Drawing.Point(178, 127);
            numericUpDownPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new System.Drawing.Size(120, 29);
            numericUpDownPrice.TabIndex = 9;
            // 
            // AddTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            ClientSize = new System.Drawing.Size(367, 281);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownTime);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddTime);
            Controls.Add(labelName);
            Controls.Add(labelMemberPrice);
            Controls.Add(labelTime);
            Controls.Add(textBoxName);
            Name = "AddTime";
            Text = "요금제 추가";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMemberPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
    }
}