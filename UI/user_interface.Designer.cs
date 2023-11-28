
namespace SeaStory
{
    partial class user_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_interface));
            ID_Box = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            PW_Box = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            PHONE_Box = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            NAME_Box = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            PW_Box2 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            CloseButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ID_Box
            // 
            ID_Box.Location = new System.Drawing.Point(94, 65);
            ID_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ID_Box.Name = "ID_Box";
            ID_Box.Size = new System.Drawing.Size(100, 23);
            ID_Box.TabIndex = 0;
            ID_Box.TextChanged += ID_Box_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(31, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(31, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "비밀번호";
            // 
            // PW_Box
            // 
            PW_Box.Location = new System.Drawing.Point(94, 151);
            PW_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box.Name = "PW_Box";
            PW_Box.Size = new System.Drawing.Size(100, 23);
            PW_Box.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Yellow;
            label3.Location = new System.Drawing.Point(31, 311);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "연락처";
            // 
            // PHONE_Box
            // 
            PHONE_Box.Location = new System.Drawing.Point(94, 308);
            PHONE_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PHONE_Box.Name = "PHONE_Box";
            PHONE_Box.Size = new System.Drawing.Size(100, 23);
            PHONE_Box.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Yellow;
            label4.Location = new System.Drawing.Point(31, 231);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "이름";
            // 
            // NAME_Box
            // 
            NAME_Box.Location = new System.Drawing.Point(94, 228);
            NAME_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NAME_Box.Name = "NAME_Box";
            NAME_Box.Size = new System.Drawing.Size(100, 23);
            NAME_Box.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Blue;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Location = new System.Drawing.Point(296, 62);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 29);
            button1.TabIndex = 8;
            button1.Text = "중복확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(294, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 15);
            label5.TabIndex = 10;
            label5.Text = "비밀번호 확인";
            // 
            // PW_Box2
            // 
            PW_Box2.Location = new System.Drawing.Point(381, 148);
            PW_Box2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box2.Name = "PW_Box2";
            PW_Box2.Size = new System.Drawing.Size(100, 23);
            PW_Box2.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.ForeColor = System.Drawing.Color.Red;
            button3.Location = new System.Drawing.Point(222, 426);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 80);
            button3.TabIndex = 12;
            button3.Text = "등록";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CloseButton.ForeColor = System.Drawing.Color.Red;
            CloseButton.Location = new System.Drawing.Point(393, 426);
            CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(75, 80);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "취소";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += button4_Click;
            // 
            // user_interface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(CloseButton);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(PW_Box2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(NAME_Box);
            Controls.Add(label3);
            Controls.Add(PHONE_Box);
            Controls.Add(label2);
            Controls.Add(PW_Box);
            Controls.Add(label1);
            Controls.Add(ID_Box);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "user_interface";
            Text = "user_interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PW_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PHONE_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PW_Box2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseButton;
    }
}