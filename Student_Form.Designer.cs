namespace NewTims
{
    partial class Student_Form
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
            this.CoursesTaken_listViewCustom = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Surname_textBox = new System.Windows.Forms.TextBox();
            this.ContactPerson_textBox = new System.Windows.Forms.TextBox();
            this.ContactPerson_label = new System.Windows.Forms.Label();
            this.Sex_label = new System.Windows.Forms.Label();
            this.Remark_label = new System.Windows.Forms.Label();
            this.Sex_comboBox = new System.Windows.Forms.ComboBox();
            this.Remark_textBox = new System.Windows.Forms.TextBox();
            this.Prior_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.Course_listViewCustom = new ListViewCustom();
            this.StudentID_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Course_listViewCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesTaken_listViewCustom
            // 
            this.CoursesTaken_listViewCustom.AutoSize = true;
            this.CoursesTaken_listViewCustom.Location = new System.Drawing.Point(12, 60);
            this.CoursesTaken_listViewCustom.Name = "CoursesTaken_listViewCustom";
            this.CoursesTaken_listViewCustom.Size = new System.Drawing.Size(79, 13);
            this.CoursesTaken_listViewCustom.TabIndex = 7;
            this.CoursesTaken_listViewCustom.Text = "Courses Taken";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(11, 15);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(49, 13);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Surname";
            // 
            // Surname_textBox
            // 
            this.Surname_textBox.Location = new System.Drawing.Point(69, 12);
            this.Surname_textBox.Name = "Surname_textBox";
            this.Surname_textBox.Size = new System.Drawing.Size(280, 20);
            this.Surname_textBox.TabIndex = 2;
            // 
            // ContactPerson_textBox
            // 
            this.ContactPerson_textBox.Location = new System.Drawing.Point(580, 12);
            this.ContactPerson_textBox.Name = "ContactPerson_textBox";
            this.ContactPerson_textBox.Size = new System.Drawing.Size(112, 20);
            this.ContactPerson_textBox.TabIndex = 4;
            // 
            // ContactPerson_label
            // 
            this.ContactPerson_label.AutoSize = true;
            this.ContactPerson_label.Location = new System.Drawing.Point(499, 15);
            this.ContactPerson_label.Name = "ContactPerson_label";
            this.ContactPerson_label.Size = new System.Drawing.Size(80, 13);
            this.ContactPerson_label.TabIndex = 5;
            this.ContactPerson_label.Text = "Contact Person";
            // 
            // Sex_label
            // 
            this.Sex_label.AutoSize = true;
            this.Sex_label.Location = new System.Drawing.Point(354, 15);
            this.Sex_label.Name = "Sex_label";
            this.Sex_label.Size = new System.Drawing.Size(25, 13);
            this.Sex_label.TabIndex = 3;
            this.Sex_label.Text = "Sex";
            // 
            // Remark_label
            // 
            this.Remark_label.AutoSize = true;
            this.Remark_label.Location = new System.Drawing.Point(357, 60);
            this.Remark_label.Name = "Remark_label";
            this.Remark_label.Size = new System.Drawing.Size(44, 13);
            this.Remark_label.TabIndex = 9;
            this.Remark_label.Text = "Remark";
            // 
            // Sex_comboBox
            // 
            this.Sex_comboBox.FormattingEnabled = true;
            this.Sex_comboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Organization"});
            this.Sex_comboBox.Location = new System.Drawing.Point(380, 10);
            this.Sex_comboBox.Name = "Sex_comboBox";
            this.Sex_comboBox.Size = new System.Drawing.Size(114, 21);
            this.Sex_comboBox.TabIndex = 4;
            this.Sex_comboBox.Text = "Male";
            // 
            // Remark_textBox
            // 
            this.Remark_textBox.Location = new System.Drawing.Point(359, 76);
            this.Remark_textBox.Multiline = true;
            this.Remark_textBox.Name = "Remark_textBox";
            this.Remark_textBox.Size = new System.Drawing.Size(333, 214);
            this.Remark_textBox.TabIndex = 10;
            // 
            // Prior_button
            // 
            this.Prior_button.Location = new System.Drawing.Point(699, 12);
            this.Prior_button.Name = "Prior_button";
            this.Prior_button.Size = new System.Drawing.Size(75, 23);
            this.Prior_button.TabIndex = 11;
            this.Prior_button.Text = "Prior_button";
            this.Prior_button.UseVisualStyleBackColor = true;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(699, 41);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 23);
            this.Next_button.TabIndex = 12;
            this.Next_button.Text = "Next_button";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Course_listViewCustom
            // 
            this.Course_listViewCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Course_listViewCustom.CellEditUseWholeCell = false;
            this.Course_listViewCustom.DataSource = null;
            this.Course_listViewCustom.FullRowSelect = true;
            this.Course_listViewCustom.HideSelection = false;
            this.Course_listViewCustom.Location = new System.Drawing.Point(13, 76);
            this.Course_listViewCustom.Name = "Course_listViewCustom";
            this.Course_listViewCustom.Size = new System.Drawing.Size(336, 215);
            this.Course_listViewCustom.TabIndex = 8;
            this.Course_listViewCustom.UseCompatibleStateImageBehavior = false;
            this.Course_listViewCustom.View = System.Windows.Forms.View.Details;
            // 
            // StudentID_label
            // 
            this.StudentID_label.AutoSize = true;
            this.StudentID_label.Location = new System.Drawing.Point(11, 40);
            this.StudentID_label.Name = "StudentID_label";
            this.StudentID_label.Size = new System.Drawing.Size(58, 13);
            this.StudentID_label.TabIndex = 7;
            this.StudentID_label.Text = "Student ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 301);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StudentID_label);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Prior_button);
            this.Controls.Add(this.Remark_textBox);
            this.Controls.Add(this.Sex_comboBox);
            this.Controls.Add(this.Remark_label);
            this.Controls.Add(this.Sex_label);
            this.Controls.Add(this.ContactPerson_label);
            this.Controls.Add(this.ContactPerson_textBox);
            this.Controls.Add(this.Surname_textBox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.CoursesTaken_listViewCustom);
            this.Controls.Add(this.Course_listViewCustom);
            this.Name = "Student_Form";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.Course_listViewCustom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewCustom Course_listViewCustom;
        private System.Windows.Forms.Label CoursesTaken_listViewCustom;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Surname_textBox;
        private System.Windows.Forms.TextBox ContactPerson_textBox;
        private System.Windows.Forms.Label ContactPerson_label;
        private System.Windows.Forms.Label Sex_label;
        private System.Windows.Forms.Label Remark_label;
        private System.Windows.Forms.ComboBox Sex_comboBox;
        private System.Windows.Forms.TextBox Remark_textBox;
        private System.Windows.Forms.Button Prior_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Label StudentID_label;
        private System.Windows.Forms.TextBox textBox1;
    }
}