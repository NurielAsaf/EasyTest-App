﻿namespace EasyTest_App
{
    partial class AdminNewExamForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminNewExamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCourseCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_proctorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_lecturerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_exam_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_start_hour = new System.Windows.Forms.TextBox();
            this.textBox_end_hour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_class_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxMoed = new System.Windows.Forms.ComboBox();
            this.errorProviderExam = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1640, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = ":יצירת בחינה";
            // 
            // textBoxCourseCode
            // 
            this.textBoxCourseCode.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBoxCourseCode.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCourseCode.Location = new System.Drawing.Point(1483, 131);
            this.textBoxCourseCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCourseCode.Multiline = true;
            this.textBoxCourseCode.Name = "textBoxCourseCode";
            this.textBoxCourseCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCourseCode.Size = new System.Drawing.Size(200, 37);
            this.textBoxCourseCode.TabIndex = 1;
            this.textBoxCourseCode.TextChanged += new System.EventHandler(this.TextBoxCourseCode_TextChanged);
            this.textBoxCourseCode.Enter += new System.EventHandler(this.TextBoxCourseCode_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1691, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = ":קוד קורס";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1628, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = ":מספר משגיח";
            // 
            // textBox_proctorID
            // 
            this.textBox_proctorID.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBox_proctorID.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_proctorID.Location = new System.Drawing.Point(1420, 208);
            this.textBox_proctorID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_proctorID.Multiline = true;
            this.textBox_proctorID.Name = "textBox_proctorID";
            this.textBox_proctorID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_proctorID.Size = new System.Drawing.Size(200, 37);
            this.textBox_proctorID.TabIndex = 4;
            this.textBox_proctorID.TextChanged += new System.EventHandler(this.TextBox_proctorID_TextChanged);
            this.textBox_proctorID.Enter += new System.EventHandler(this.TextBox_proctorID_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1640, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = ":מספר מרצה";
            // 
            // textBox_lecturerID
            // 
            this.textBox_lecturerID.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBox_lecturerID.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_lecturerID.Location = new System.Drawing.Point(1432, 285);
            this.textBox_lecturerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_lecturerID.Multiline = true;
            this.textBox_lecturerID.Name = "textBox_lecturerID";
            this.textBox_lecturerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_lecturerID.Size = new System.Drawing.Size(200, 37);
            this.textBox_lecturerID.TabIndex = 6;
            this.textBox_lecturerID.TextChanged += new System.EventHandler(this.TextBox_lecturerID_TextChanged);
            this.textBox_lecturerID.Enter += new System.EventHandler(this.TextBox_lecturerID_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1628, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = ":תאריך בחינה";
            // 
            // textBox_exam_date
            // 
            this.textBox_exam_date.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBox_exam_date.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_exam_date.Location = new System.Drawing.Point(1420, 439);
            this.textBox_exam_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_exam_date.Multiline = true;
            this.textBox_exam_date.Name = "textBox_exam_date";
            this.textBox_exam_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_exam_date.Size = new System.Drawing.Size(200, 37);
            this.textBox_exam_date.TabIndex = 8;
            this.textBox_exam_date.TextChanged += new System.EventHandler(this.TextBox_exam_date_TextChanged);
            this.textBox_exam_date.Enter += new System.EventHandler(this.TextBox_exam_date_Enter);
            this.textBox_exam_date.Leave += new System.EventHandler(this.TextBox_exam_date_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1627, 505);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 48);
            this.label6.TabIndex = 9;
            this.label6.Text = ":שעת התחלה";
            // 
            // textBox_start_hour
            // 
            this.textBox_start_hour.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBox_start_hour.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_start_hour.Location = new System.Drawing.Point(1419, 516);
            this.textBox_start_hour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_start_hour.Multiline = true;
            this.textBox_start_hour.Name = "textBox_start_hour";
            this.textBox_start_hour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_start_hour.Size = new System.Drawing.Size(200, 37);
            this.textBox_start_hour.TabIndex = 10;
            this.textBox_start_hour.TextChanged += new System.EventHandler(this.TextBox_start_hour_TextChanged);
            this.textBox_start_hour.Leave += new System.EventHandler(this.TextBox_start_hour_Leave);
            // 
            // textBox_end_hour
            // 
            this.textBox_end_hour.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBox_end_hour.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_end_hour.Location = new System.Drawing.Point(1467, 593);
            this.textBox_end_hour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_end_hour.Multiline = true;
            this.textBox_end_hour.Name = "textBox_end_hour";
            this.textBox_end_hour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_end_hour.Size = new System.Drawing.Size(200, 37);
            this.textBox_end_hour.TabIndex = 11;
            this.textBox_end_hour.TextChanged += new System.EventHandler(this.TextBox_end_hour_TextChanged);
            this.textBox_end_hour.Leave += new System.EventHandler(this.TextBox_end_hour_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1675, 582);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = ":שעת סיום";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Transparent;
            this.button_confirm.Enabled = false;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.button_confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_confirm.Location = new System.Drawing.Point(1406, 738);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(452, 141);
            this.button_confirm.TabIndex = 13;
            this.button_confirm.Text = "אשר";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.Button_confirm_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Transparent;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(1213, 738);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(170, 141);
            this.button_reset.TabIndex = 14;
            this.button_reset.Text = "אפס";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(1690, 938);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(168, 72);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "חזור";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // textBox_class_number
            // 
            this.textBox_class_number.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBox_class_number.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_class_number.Location = new System.Drawing.Point(1441, 362);
            this.textBox_class_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_class_number.Multiline = true;
            this.textBox_class_number.Name = "textBox_class_number";
            this.textBox_class_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_class_number.Size = new System.Drawing.Size(200, 37);
            this.textBox_class_number.TabIndex = 16;
            this.textBox_class_number.TextChanged += new System.EventHandler(this.TextBox_class_number_TextChanged);
            this.textBox_class_number.Enter += new System.EventHandler(this.TextBox_class_number_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1649, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 48);
            this.label8.TabIndex = 17;
            this.label8.Text = ":מספר כיתה";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(933, 131);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(324, 144);
            this.listBox1.TabIndex = 18;
            this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_SelectedValueChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(1053, 439);
            this.calendar.Margin = new System.Windows.Forms.Padding(14);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 19;
            this.calendar.Visible = false;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1570, 659);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 48);
            this.label9.TabIndex = 20;
            this.label9.Text = ":סוג מועד הבחינה";
            // 
            // comboBoxMoed
            // 
            this.comboBoxMoed.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.comboBoxMoed.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxMoed.FormattingEnabled = true;
            this.comboBoxMoed.Items.AddRange(new object[] {
            "מועד א",
            "מועד ב",
            "מועד מיוחד"});
            this.comboBoxMoed.Location = new System.Drawing.Point(1406, 667);
            this.comboBoxMoed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMoed.Name = "comboBoxMoed";
            this.comboBoxMoed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxMoed.Size = new System.Drawing.Size(156, 40);
            this.comboBoxMoed.TabIndex = 21;
            this.comboBoxMoed.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoed_Leave);
            this.comboBoxMoed.Leave += new System.EventHandler(this.comboBoxMoed_Leave);
            // 
            // errorProviderExam
            // 
            this.errorProviderExam.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 1024);
            this.panel1.TabIndex = 22;
            // 
            // AdminNewExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.comboBoxMoed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_class_number);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_end_hour);
            this.Controls.Add(this.textBox_start_hour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_exam_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_lecturerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_proctorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCourseCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminNewExamForm";
            this.Text = "AdminNewExamForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminNewExamForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminNewExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCourseCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_proctorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_lecturerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_exam_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_start_hour;
        private System.Windows.Forms.TextBox textBox_end_hour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_class_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxMoed;
        private System.Windows.Forms.ErrorProvider errorProviderExam;
        private System.Windows.Forms.Panel panel1;
    }
}