namespace BaseControlLibrary
{
    partial class Button
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
            this.Xbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Xbutton
            // 
            this.Xbutton.Location = new System.Drawing.Point(0, 0);
            this.Xbutton.Name = "Xbutton";
            this.Xbutton.Size = new System.Drawing.Size(75, 23);
            this.Xbutton.TabIndex = 0;
            this.Xbutton.Text = "Button";
            this.Xbutton.UseVisualStyleBackColor = true;
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Xbutton);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(74, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Xbutton;
    }
}
