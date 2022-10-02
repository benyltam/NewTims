namespace BaseControlLibrary
{
    partial class CheckBox
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
            this.XcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // XcheckBox
            // 
            this.XcheckBox.AutoSize = true;
            this.XcheckBox.Location = new System.Drawing.Point(0, 0);
            this.XcheckBox.Name = "XcheckBox";
            this.XcheckBox.Size = new System.Drawing.Size(75, 17);
            this.XcheckBox.TabIndex = 0;
            this.XcheckBox.Text = "CheckBox";
            this.XcheckBox.UseVisualStyleBackColor = true;
            this.XcheckBox.CheckedChanged += new System.EventHandler(this.XcheckBox_CheckedChanged);
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.XcheckBox);
            this.Name = "CheckBox";
            this.Size = new System.Drawing.Size(82, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox XcheckBox;
    }
}
