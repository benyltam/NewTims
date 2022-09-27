
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
            this.Schedule_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.dataListView1.Location = new System.Drawing.Point(12, 12);
            this.dataListView1.Name = "dataListView1";
            this.dataListView1.Size = new System.Drawing.Size(259, 337);
            this.dataListView1.TabIndex = 0;
            this.dataListView1.UseCompatibleStateImageBehavior = false;
            this.dataListView1.View = System.Windows.Forms.View.Details;
            // 
            // dataListView2
            // 
            this.dataListView2.CellEditUseWholeCell = false;
            this.dataListView2.DataSource = null;
            this.dataListView2.HideSelection = false;
            this.dataListView2.Location = new System.Drawing.Point(279, 12);
            this.dataListView2.Name = "dataListView2";
            this.dataListView2.Size = new System.Drawing.Size(259, 337);
            this.dataListView2.TabIndex = 1;
            this.dataListView2.UseCompatibleStateImageBehavior = false;
            this.dataListView2.View = System.Windows.Forms.View.Details;
            // 
            // dataListView3
            // 
            this.dataListView3.CellEditUseWholeCell = false;
            this.dataListView3.DataSource = null;
            this.dataListView3.HideSelection = false;
            this.dataListView3.Location = new System.Drawing.Point(546, 12);
            this.dataListView3.Name = "dataListView3";
            this.dataListView3.Size = new System.Drawing.Size(259, 337);
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
            // Schedule_dateTimePicker
            // 
            this.Schedule_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.Schedule_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Schedule_dateTimePicker.Location = new System.Drawing.Point(850, 43);
            this.Schedule_dateTimePicker.Margin = new System.Windows.Forms.Padding(96, 3, 3, 3);
            this.Schedule_dateTimePicker.Name = "Schedule_dateTimePicker";
            this.Schedule_dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.Schedule_dateTimePicker.TabIndex = 6;
            this.Schedule_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(849, 105);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(96, 3, 3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // DaySchedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.From_label);
            this.Controls.Add(this.Schedule_dateTimePicker);
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
        private System.Windows.Forms.DateTimePicker Schedule_dateTimePicker;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}