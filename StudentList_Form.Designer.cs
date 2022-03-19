
namespace NewTims
{
    partial class StudentList_Form
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
            this.StudentList_dataListView = new BrightIdeasSoftware.DataListView();
            this.ShowDetails_button = new System.Windows.Forms.Button();
            this.Next_button_StudentList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList_dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentList_dataListView
            // 
            this.StudentList_dataListView.CellEditUseWholeCell = false;
            this.StudentList_dataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentList_dataListView.DataSource = null;
            this.StudentList_dataListView.HideSelection = false;
            this.StudentList_dataListView.Location = new System.Drawing.Point(12, 12);
            this.StudentList_dataListView.Name = "StudentList_dataListView";
            this.StudentList_dataListView.Size = new System.Drawing.Size(775, 265);
            this.StudentList_dataListView.TabIndex = 0;
            this.StudentList_dataListView.UseCompatibleStateImageBehavior = false;
            this.StudentList_dataListView.View = System.Windows.Forms.View.Details;
            this.StudentList_dataListView.SelectedIndexChanged += new System.EventHandler(this.StudentList_dataListView_SelectedIndexChanged);
            // 
            // ShowDetails_button
            // 
            this.ShowDetails_button.Location = new System.Drawing.Point(12, 287);
            this.ShowDetails_button.Name = "ShowDetails_button";
            this.ShowDetails_button.Size = new System.Drawing.Size(88, 24);
            this.ShowDetails_button.TabIndex = 1;
            this.ShowDetails_button.Text = "Show Details";
            this.ShowDetails_button.UseVisualStyleBackColor = true;
            this.ShowDetails_button.Click += new System.EventHandler(this.ShowDetails_button_Click);
            // 
            // Next_button_StudentList
            // 
            this.Next_button_StudentList.Location = new System.Drawing.Point(194, 287);
            this.Next_button_StudentList.Name = "Next_button_StudentList";
            this.Next_button_StudentList.Size = new System.Drawing.Size(88, 24);
            this.Next_button_StudentList.TabIndex = 2;
            this.Next_button_StudentList.Text = "Next Page";
            this.Next_button_StudentList.UseVisualStyleBackColor = true;
            this.Next_button_StudentList.Click += new System.EventHandler(this.Next_button_StudentList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Previous Page";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Next_button_StudentList);
            this.Controls.Add(this.ShowDetails_button);
            this.Controls.Add(this.StudentList_dataListView);
            this.Name = "StudentList_Form";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentList_Form_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.StudentList_dataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.DataListView StudentList_dataListView;
        private System.Windows.Forms.Button ShowDetails_button;
        private System.Windows.Forms.Button Next_button_StudentList;
        private System.Windows.Forms.Button button1;
    }
}

