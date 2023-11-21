namespace SeaStory.UI.AdminFoodManagement
{
    partial class MenuItemWithCheckboxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CheckBoxControl = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // CheckBoxControl
            // 
            CheckBoxControl.AutoSize = true;
            CheckBoxControl.Location = new System.Drawing.Point(130, 3);
            CheckBoxControl.Name = "CheckBoxControl";
            CheckBoxControl.Size = new System.Drawing.Size(15, 14);
            CheckBoxControl.TabIndex = 3;
            CheckBoxControl.UseVisualStyleBackColor = true;
            // 
            // MenuItemWithCheckboxControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(CheckBoxControl);
            Name = "MenuItemWithCheckboxControl";
            Size = new System.Drawing.Size(153, 158);
            Controls.SetChildIndex(CheckBoxControl, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxControl;
    }
}
