﻿
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
            button3 = new System.Windows.Forms.Button();
            CloseButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            PW_Box2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            PW_Box = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            NAME_Box = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            PHONE_Box = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ID_Box = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.Blue;
            button3.Location = new System.Drawing.Point(220, 413);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(141, 80);
            button3.TabIndex = 12;
            button3.Text = "등록";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonRegister;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = System.Drawing.Color.White;
            CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CloseButton.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CloseButton.ForeColor = System.Drawing.Color.Red;
            CloseButton.Location = new System.Drawing.Point(415, 413);
            CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(144, 80);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "취소";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += buttonClose;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(58, 38);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(676, 354);
            panel1.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(PW_Box2);
            panel6.Controls.Add(textBox1);
            panel6.Location = new System.Drawing.Point(335, 106);
            panel6.Margin = new System.Windows.Forms.Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(312, 94);
            panel6.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.Control;
            label5.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(25, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 28);
            label5.TabIndex = 25;
            label5.Text = "비밀번호 확인";
            // 
            // PW_Box2
            // 
            PW_Box2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PW_Box2.Location = new System.Drawing.Point(179, 30);
            PW_Box2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box2.Name = "PW_Box2";
            PW_Box2.Size = new System.Drawing.Size(100, 29);
            PW_Box2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(-188, 39);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 29);
            textBox1.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(PW_Box);
            panel4.Location = new System.Drawing.Point(20, 106);
            panel4.Margin = new System.Windows.Forms.Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(308, 94);
            panel4.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.Location = new System.Drawing.Point(313, 0);
            panel5.Margin = new System.Windows.Forms.Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(194, 94);
            panel5.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(16, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 28);
            label2.TabIndex = 23;
            label2.Text = "비밀번호";
            // 
            // PW_Box
            // 
            PW_Box.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PW_Box.Location = new System.Drawing.Point(127, 29);
            PW_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PW_Box.Name = "PW_Box";
            PW_Box.Size = new System.Drawing.Size(100, 29);
            PW_Box.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(NAME_Box);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(PHONE_Box);
            panel3.Location = new System.Drawing.Point(20, 212);
            panel3.Margin = new System.Windows.Forms.Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(627, 127);
            panel3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Control;
            label4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(16, 21);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 28);
            label4.TabIndex = 22;
            label4.Text = "이름";
            // 
            // NAME_Box
            // 
            NAME_Box.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NAME_Box.Location = new System.Drawing.Point(127, 20);
            NAME_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NAME_Box.Name = "NAME_Box";
            NAME_Box.Size = new System.Drawing.Size(100, 29);
            NAME_Box.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Control;
            label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(16, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 28);
            label3.TabIndex = 20;
            label3.Text = "연락처";
            // 
            // PHONE_Box
            // 
            PHONE_Box.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PHONE_Box.Location = new System.Drawing.Point(127, 78);
            PHONE_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PHONE_Box.Name = "PHONE_Box";
            PHONE_Box.Size = new System.Drawing.Size(100, 29);
            PHONE_Box.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ID_Box);
            panel2.Controls.Add(button1);
            panel2.Location = new System.Drawing.Point(20, 14);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(627, 77);
            panel2.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 28);
            label1.TabIndex = 12;
            label1.Text = "아이디";
            // 
            // ID_Box
            // 
            ID_Box.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ID_Box.Location = new System.Drawing.Point(127, 22);
            ID_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ID_Box.Name = "ID_Box";
            ID_Box.Size = new System.Drawing.Size(100, 29);
            ID_Box.TabIndex = 11;
            ID_Box.TextChanged += ID_Box_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(258, 23);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 29);
            button1.TabIndex = 19;
            button1.Text = "중복확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonCheckDuplicate;
            // 
            // user_interface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 529);
            Controls.Add(panel1);
            Controls.Add(CloseButton);
            Controls.Add(button3);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "user_interface";
            Text = "회원가입";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PW_Box2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PW_Box;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PHONE_Box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}