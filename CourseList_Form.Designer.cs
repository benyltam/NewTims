
namespace NewTims
{
    partial class CourseList_Form
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
            this.ShowDetails_button = new System.Windows.Forms.Button();
            this.CourseList_dataListView = new BrightIdeasSoftware.DataListView();
            ((System.ComponentModel.ISupportInitialize)(this.CourseList_dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDetails_button
            // 
            this.ShowDetails_button.Location = new System.Drawing.Point(15, 292);
            this.ShowDetails_button.Name = "ShowDetails_button";
            this.ShowDetails_button.Size = new System.Drawing.Size(125, 24);
            this.ShowDetails_button.TabIndex = 2;
            this.ShowDetails_button.Text = "Show Details";
            this.ShowDetails_button.UseVisualStyleBackColor = true;
            // 
            // CourseList_dataListView
            // 
            this.CourseList_dataListView.CellEditUseWholeCell = false;
            this.CourseList_dataListView.DataSource = null;
            this.CourseList_dataListView.HideSelection = false;
            this.CourseList_dataListView.Location = new System.Drawing.Point(16, 16);
            this.CourseList_dataListView.Name = "CourseList_dataListView";
            this.CourseList_dataListView.Size = new System.Drawing.Size(771, 269);
            this.CourseList_dataListView.TabIndex = 0;
            this.CourseList_dataListView.UseCompatibleStateImageBehavior = false;
            this.CourseList_dataListView.View = System.Windows.Forms.View.Details;
            // 
            // CourseList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.ShowDetails_button);
            this.Controls.Add(this.CourseList_dataListView);
            this.Name = "CourseList_Form";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.CourseList_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseList_dataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.DataListView CourseList_dataListView;
        private System.Windows.Forms.Button ShowDetails_button;
    }
}