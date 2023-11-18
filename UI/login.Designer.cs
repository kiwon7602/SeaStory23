
namespace SeaStory
{
    partial class login
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
            components = new System.ComponentModel.Container();
            radioButton1 = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            button2 = new System.Windows.Forms.Button();
            register = new System.Windows.Forms.Button();
            appCloseButton1 = new UI.AppCloseButton();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(46, 54);
            radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(89, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "회원 로그인";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 172);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "아이디";
            label1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(57, 191);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(289, 23);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(57, 281);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(289, 23);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 262);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "비밀번호";
            label2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(270, 385);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 29);
            button1.TabIndex = 6;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(709, 13);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(79, 58);
            button2.TabIndex = 8;
            button2.Text = "잔돈반환";
            button2.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            register.Location = new System.Drawing.Point(612, 13);
            register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            register.Name = "register";
            register.Size = new System.Drawing.Size(79, 58);
            register.TabIndex = 12;
            register.Text = "회원가입";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // appCloseButton1
            // 
            appCloseButton1.Location = new System.Drawing.Point(637, 491);
            appCloseButton1.Name = "appCloseButton1";
            appCloseButton1.Size = new System.Drawing.Size(111, 29);
            appCloseButton1.TabIndex = 13;
            // 
            // login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            ControlBox = false;
            Controls.Add(appCloseButton1);
            Controls.Add(register);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(radioButton1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button register;
        private UI.AppCloseButton appCloseButton1;
    }
}