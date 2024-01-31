using System.Drawing;
using AfghanCalendar;
//using AfghanCalendar;

namespace TestControl
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            DariDate dariDate3 = new AfghanCalendar.DariDate();
            DariDate dariDate4 = new AfghanCalendar.DariDate();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridPerson = new System.Windows.Forms.DataGridView();
            this.BirthDate = new AfghanCalendar.DataGridViewDariDatePickerColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDariDatePickerColumn1 = new AfghanCalendar.DataGridViewDariDatePickerColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DariCalendar1 = new AfghanCalendar.DariCalendar();
            this.DariCalendar2 = new AfghanCalendar.DariCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date Picker Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month Calendar Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dari DatePicker Column:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gridPerson
            // 
            this.gridPerson.AllowUserToAddRows = false;
            this.gridPerson.AllowUserToDeleteRows = false;
            this.gridPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPerson.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BirthDate,
            this.Fullname});
            this.gridPerson.Location = new System.Drawing.Point(128, 200);
            this.gridPerson.Name = "gridPerson";
            this.gridPerson.RowHeadersVisible = false;
            this.gridPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridPerson.Size = new System.Drawing.Size(280, 102);
            this.gridPerson.TabIndex = 5;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.DateFormat = AfghanCalendar.DateFormat.Long;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.BirthDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.BirthDate.HeaderText = "تاریخ تولد";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ShowDariDigitInCell = true;
            this.BirthDate.Theme = AfghanCalendar.CalendarTheme.WhiteSmoke;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "نام";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Width = 70;
            // 
            // dataGridViewDariDatePickerColumn1
            // 
            this.dataGridViewDariDatePickerColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewDariDatePickerColumn1.DataPropertyName = "BirthDate";
            this.dataGridViewDariDatePickerColumn1.DateFormat = AfghanCalendar.DateFormat.Short;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewDariDatePickerColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDariDatePickerColumn1.HeaderText = "تاریخ تولد";
            this.dataGridViewDariDatePickerColumn1.Name = "dataGridViewDariDatePickerColumn1";
            this.dataGridViewDariDatePickerColumn1.ShowDariDigitInCell = false;
            this.dataGridViewDariDatePickerColumn1.Theme = AfghanCalendar.CalendarTheme.Gold;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fullname";
            this.dataGridViewTextBoxColumn1.HeaderText = "نام";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // DariCalendar1
            // 
            this.DariCalendar1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DariCalendar1.Location = new System.Drawing.Point(128, 39);
            this.DariCalendar1.Name = "DariCalendar1";
            this.DariCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DariCalendar1.Size = new System.Drawing.Size(280, 155);
            this.DariCalendar1.TabIndex = 2;
            dariDate3.DariSelectedDate = "1392/01/08";
            dariDate3.Mode = AfghanCalendar.ControlType.MonthCalendar;
            dariDate3.Theme = AfghanCalendar.CalendarTheme.Gold;
            this.DariCalendar1.Value = dariDate3;
            this.DariCalendar1.DateChanged += new AfghanCalendar.DateChangedHandler(this.DatePicker_DateChanged);
            // 
            // DariCalendar2
            // 
            this.DariCalendar2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DariCalendar2.Location = new System.Drawing.Point(128, 12);
            this.DariCalendar2.Name = "DariCalendar2";
            this.DariCalendar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DariCalendar2.Size = new System.Drawing.Size(280, 21);
            this.DariCalendar2.TabIndex = 1;
            dariDate4.DariSelectedDate = "1392/01/20";
            dariDate4.Theme = AfghanCalendar.CalendarTheme.Green;
            this.DariCalendar2.Value = dariDate4;
            this.DariCalendar2.DateChanged += new AfghanCalendar.DateChangedHandler(this.DatePicker_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 306);
            this.Controls.Add(this.gridPerson);
            this.Controls.Add(this.DariCalendar1);
            this.Controls.Add(this.DariCalendar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DariCalendar DariCalendar2;
        private DariCalendar DariCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridPerson;
        private System.Windows.Forms.Label label3;
        private DataGridViewDariDatePickerColumn dataGridViewDariDatePickerColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewDariDatePickerColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;

    }
}

