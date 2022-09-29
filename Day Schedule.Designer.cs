
namespace NewTims
{
    partial class DaySchedule_Form
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
            this.dataListView1 = new BrightIdeasSoftware.DataListView();
            this.dataListView2 = new BrightIdeasSoftware.DataListView();
            this.dataListView3 = new BrightIdeasSoftware.DataListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ScheduleFrom_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_label = new System.Windows.Forms.Label();
            this.To_label = new System.Windows.Forms.Label();
            this.ScheduleTo_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListView1
            // 
            this.dataListView1.CellEditUseWholeCell = false;
            this.dataListView1.DataSource = null;
            this.dataListView1.HideSelection = false;
            this.dataListView1.Location = new System.Drawing.Point(12, 43);
            this.dataListView1.Name = "dataListView1";
            this.dataListView1.Size = new System.Drawing.Size(259, 306);
            this.dataListView1.TabIndex = 0;
            this.dataListView1.UseCompatibleStateImageBehavior = false;
            this.dataListView1.View = System.Windows.Forms.View.Details;
            // 
            // dataListView2
            // 
            this.dataListView2.CellEditUseWholeCell = false;
            this.dataListView2.DataSource = null;
            this.dataListView2.HideSelection = false;
            this.dataListView2.Location = new System.Drawing.Point(279, 43);
            this.dataListView2.Name = "dataListView2";
            this.dataListView2.Size = new System.Drawing.Size(259, 306);
            this.dataListView2.TabIndex = 1;
            this.dataListView2.UseCompatibleStateImageBehavior = false;
            this.dataListView2.View = System.Windows.Forms.View.Details;
            // 
            // dataListView3
            // 
            this.dataListView3.CellEditUseWholeCell = false;
            this.dataListView3.DataSource = null;
            this.dataListView3.HideSelection = false;
            this.dataListView3.Location = new System.Drawing.Point(546, 43);
            this.dataListView3.Name = "dataListView3";
            this.dataListView3.Size = new System.Drawing.Size(259, 306);
            this.dataListView3.TabIndex = 2;
            this.dataListView3.UseCompatibleStateImageBehavior = false;
            this.dataListView3.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 355);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 48);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 355);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 48);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(546, 355);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 48);
            this.textBox3.TabIndex = 5;
            // 
            // ScheduleFrom_dateTimePicker
            // 
            this.ScheduleFrom_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ScheduleFrom_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ScheduleFrom_dateTimePicker.Location = new System.Drawing.Point(850, 43);
            this.ScheduleFrom_dateTimePicker.Margin = new System.Windows.Forms.Padding(96, 3, 3, 3);
            this.ScheduleFrom_dateTimePicker.Name = "ScheduleFrom_dateTimePicker";
            this.ScheduleFrom_dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.ScheduleFrom_dateTimePicker.TabIndex = 6;
            // 
            // From_label
            // 
            this.From_label.AutoSize = true;
            this.From_label.Location = new System.Drawing.Point(811, 46);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(30, 13);
            this.From_label.TabIndex = 7;
            this.From_label.Text = "From";
            // 
            // To_label
            // 
            this.To_label.AutoSize = true;
            this.To_label.Location = new System.Drawing.Point(810, 108);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(20, 13);
            this.To_label.TabIndex = 9;
            this.To_label.Text = "To";
            // 
            // ScheduleTo_dateTimePicker
            // 
            this.ScheduleTo_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ScheduleTo_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ScheduleTo_dateTimePicker.Location = new System.Drawing.Point(849, 105);
            this.ScheduleTo_dateTimePicker.Margin = new System.Windows.Forms.Padding(96, 3, 3, 3);
            this.ScheduleTo_dateTimePicker.Name = "ScheduleTo_dateTimePicker";
            this.ScheduleTo_dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.ScheduleTo_dateTimePicker.TabIndex = 8;
            // 
            // DaySchedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 412);
            this.Controls.Add(this.To_label);
            this.Controls.Add(this.ScheduleTo_dateTimePicker);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.ScheduleFrom_dateTimePicker);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataListView3);
            this.Controls.Add(this.dataListView2);
            this.Controls.Add(this.dataListView1);
            this.Name = "DaySchedule_Form";
            this.Text = "Day Schedule";
            this.Load += new System.EventHandler(this.DaySchedule_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.DataListView dataListView1;
        private BrightIdeasSoftware.DataListView dataListView2;
        private BrightIdeasSoftware.DataListView dataListView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker ScheduleFrom_dateTimePicker;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.DateTimePicker ScheduleTo_dateTimePicker;
    }
}