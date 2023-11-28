namespace SeaStory.UI.AdminFoodManagement
{
    partial class UserManagement_update
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
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            PW_Box2 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            NAME_Box = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            PHONE_Box = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            PW_Box = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            ID_Box = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(41, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 28);
            label1.TabIndex = 0;
            label1.Text = "유저 정보 수정";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(320, 177);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 15);
            label5.TabIndex = 22;
            label5.Text = "비밀번호 확인";
            // 
            // PW_Box2
            // 
            PW_Box2.Location = new System.Drawing.Point(407, 174);
            PW_Box2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box2.Name = "PW_Box2";
            PW_Box2.Size = new System.Drawing.Size(100, 23);
            PW_Box2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(57, 257);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 15);
            label4.TabIndex = 19;
            label4.Text = "이름";
            // 
            // NAME_Box
            // 
            NAME_Box.Location = new System.Drawing.Point(120, 254);
            NAME_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NAME_Box.Name = "NAME_Box";
            NAME_Box.Size = new System.Drawing.Size(100, 23);
            NAME_Box.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(57, 337);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 17;
            label3.Text = "연락처";
            // 
            // PHONE_Box
            // 
            PHONE_Box.Location = new System.Drawing.Point(120, 334);
            PHONE_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PHONE_Box.Name = "PHONE_Box";
            PHONE_Box.Size = new System.Drawing.Size(100, 23);
            PHONE_Box.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(57, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 15;
            label2.Text = "비밀번호";
            // 
            // PW_Box
            // 
            PW_Box.Location = new System.Drawing.Point(120, 177);
            PW_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box.Name = "PW_Box";
            PW_Box.Size = new System.Drawing.Size(100, 23);
            PW_Box.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(57, 95);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "아이디";
            // 
            // ID_Box
            // 
            ID_Box.Enabled = false;
            ID_Box.Location = new System.Drawing.Point(120, 91);
            ID_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ID_Box.Name = "ID_Box";
            ID_Box.Size = new System.Drawing.Size(100, 23);
            ID_Box.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(275, 391);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "정보 수정";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(420, 391);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "취소";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserManagement_update
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(PW_Box2);
            Controls.Add(label4);
            Controls.Add(NAME_Box);
            Controls.Add(label3);
            Controls.Add(PHONE_Box);
            Controls.Add(label2);
            Controls.Add(PW_Box);
            Controls.Add(label6);
            Controls.Add(ID_Box);
            Controls.Add(label1);
            Name = "UserManagement_update";
            Text = "UserManagement_update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PW_Box2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PHONE_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PW_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}