namespace UnicomTICManagementSystem.View
{
    partial class ExamRegisterForm
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
            this.be_back = new System.Windows.Forms.Button();
            this.be_clear = new System.Windows.Forms.Button();
            this.ce_subject = new System.Windows.Forms.ComboBox();
            this.ce_course = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.de_time = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ce_room = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.te_remarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.te_duration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ce_examtype = new System.Windows.Forms.ComboBox();
            this.de_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.be_register = new System.Windows.Forms.Button();
            this.te_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.le_name = new System.Windows.Forms.Label();
            this.le_date = new System.Windows.Forms.Label();
            this.le_time = new System.Windows.Forms.Label();
            this.le_course = new System.Windows.Forms.Label();
            this.le_subject = new System.Windows.Forms.Label();
            this.le_examtype = new System.Windows.Forms.Label();
            this.le_duration = new System.Windows.Forms.Label();
            this.le_room = new System.Windows.Forms.Label();
            this.le_remarks = new System.Windows.Forms.Label();
            this.ce_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.le_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // be_back
            // 
            this.be_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.be_back.Location = new System.Drawing.Point(739, 626);
            this.be_back.Margin = new System.Windows.Forms.Padding(4);
            this.be_back.Name = "be_back";
            this.be_back.Size = new System.Drawing.Size(111, 38);
            this.be_back.TabIndex = 80;
            this.be_back.Text = "Back";
            this.be_back.UseVisualStyleBackColor = true;
            this.be_back.Click += new System.EventHandler(this.be_back_Click);
            // 
            // be_clear
            // 
            this.be_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.be_clear.Location = new System.Drawing.Point(900, 626);
            this.be_clear.Margin = new System.Windows.Forms.Padding(4);
            this.be_clear.Name = "be_clear";
            this.be_clear.Size = new System.Drawing.Size(111, 38);
            this.be_clear.TabIndex = 79;
            this.be_clear.Text = "Clear";
            this.be_clear.UseVisualStyleBackColor = true;
            this.be_clear.Click += new System.EventHandler(this.be_clear_Click);
            // 
            // ce_subject
            // 
            this.ce_subject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce_subject.FormattingEnabled = true;
            this.ce_subject.Location = new System.Drawing.Point(187, 457);
            this.ce_subject.Margin = new System.Windows.Forms.Padding(4);
            this.ce_subject.Name = "ce_subject";
            this.ce_subject.Size = new System.Drawing.Size(270, 28);
            this.ce_subject.TabIndex = 78;
            this.ce_subject.SelectedIndexChanged += new System.EventHandler(this.ce_subject_SelectedIndexChanged);
            // 
            // ce_course
            // 
            this.ce_course.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce_course.FormattingEnabled = true;
            this.ce_course.Location = new System.Drawing.Point(187, 397);
            this.ce_course.Margin = new System.Windows.Forms.Padding(4);
            this.ce_course.Name = "ce_course";
            this.ce_course.Size = new System.Drawing.Size(270, 28);
            this.ce_course.TabIndex = 77;
            this.ce_course.SelectedIndexChanged += new System.EventHandler(this.ce_course_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 396);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 76;
            this.label12.Text = "Course";
            // 
            // de_time
            // 
            this.de_time.Checked = false;
            this.de_time.CustomFormat = "";
            this.de_time.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.de_time.Location = new System.Drawing.Point(187, 332);
            this.de_time.Margin = new System.Windows.Forms.Padding(4);
            this.de_time.Name = "de_time";
            this.de_time.Size = new System.Drawing.Size(270, 28);
            this.de_time.TabIndex = 75;
            this.de_time.Value = new System.DateTime(2025, 6, 22, 23, 59, 0, 0);
            this.de_time.ValueChanged += new System.EventHandler(this.de_time_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 335);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "Exam Time";
            // 
            // ce_room
            // 
            this.ce_room.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce_room.FormattingEnabled = true;
            this.ce_room.Location = new System.Drawing.Point(773, 337);
            this.ce_room.Margin = new System.Windows.Forms.Padding(4);
            this.ce_room.Name = "ce_room";
            this.ce_room.Size = new System.Drawing.Size(270, 28);
            this.ce_room.TabIndex = 73;
            this.ce_room.SelectedIndexChanged += new System.EventHandler(this.ce_room_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(656, 339);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 72;
            this.label10.Text = "Room";
            // 
            // te_remarks
            // 
            this.te_remarks.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_remarks.Location = new System.Drawing.Point(773, 397);
            this.te_remarks.Margin = new System.Windows.Forms.Padding(4);
            this.te_remarks.Name = "te_remarks";
            this.te_remarks.Size = new System.Drawing.Size(270, 28);
            this.te_remarks.TabIndex = 70;
            this.te_remarks.TextChanged += new System.EventHandler(this.te_remarks_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(656, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Remarks";
            // 
            // te_duration
            // 
            this.te_duration.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_duration.Location = new System.Drawing.Point(773, 266);
            this.te_duration.Margin = new System.Windows.Forms.Padding(4);
            this.te_duration.Name = "te_duration";
            this.te_duration.Size = new System.Drawing.Size(270, 28);
            this.te_duration.TabIndex = 68;
            this.te_duration.TextChanged += new System.EventHandler(this.te_duration_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(544, 53);
            this.label6.TabIndex = 67;
            this.label6.Text = "NEW EXAM REGISTER";
            // 
            // ce_examtype
            // 
            this.ce_examtype.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce_examtype.FormattingEnabled = true;
            this.ce_examtype.Items.AddRange(new object[] {
            "Written",
            "Practical",
            "Online",
            "Computer-Based Test"});
            this.ce_examtype.Location = new System.Drawing.Point(773, 199);
            this.ce_examtype.Margin = new System.Windows.Forms.Padding(4);
            this.ce_examtype.Name = "ce_examtype";
            this.ce_examtype.Size = new System.Drawing.Size(270, 28);
            this.ce_examtype.TabIndex = 66;
            this.ce_examtype.SelectedIndexChanged += new System.EventHandler(this.ce_examtype_SelectedIndexChanged);
            this.ce_examtype.Click += new System.EventHandler(this.ce_examtype_Click);
            // 
            // de_date
            // 
            this.de_date.Checked = false;
            this.de_date.CustomFormat = "";
            this.de_date.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_date.Location = new System.Drawing.Point(187, 267);
            this.de_date.Margin = new System.Windows.Forms.Padding(4);
            this.de_date.Name = "de_date";
            this.de_date.Size = new System.Drawing.Size(270, 28);
            this.de_date.TabIndex = 65;
            this.de_date.Value = new System.DateTime(2025, 6, 22, 0, 0, 0, 0);
            this.de_date.ValueChanged += new System.EventHandler(this.de_date_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(656, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Exam Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Exam Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Subject";
            // 
            // be_register
            // 
            this.be_register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.be_register.Location = new System.Drawing.Point(1055, 626);
            this.be_register.Margin = new System.Windows.Forms.Padding(4);
            this.be_register.Name = "be_register";
            this.be_register.Size = new System.Drawing.Size(111, 38);
            this.be_register.TabIndex = 59;
            this.be_register.Text = "Register";
            this.be_register.UseVisualStyleBackColor = true;
            this.be_register.Click += new System.EventHandler(this.be_register_Click);
            // 
            // te_name
            // 
            this.te_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_name.Location = new System.Drawing.Point(187, 201);
            this.te_name.Margin = new System.Windows.Forms.Padding(4);
            this.te_name.Name = "te_name";
            this.te_name.Size = new System.Drawing.Size(270, 28);
            this.te_name.TabIndex = 58;
            this.te_name.TextChanged += new System.EventHandler(this.te_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Exam Name";
            // 
            // le_name
            // 
            this.le_name.AutoSize = true;
            this.le_name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_name.ForeColor = System.Drawing.Color.Red;
            this.le_name.Location = new System.Drawing.Point(196, 233);
            this.le_name.Name = "le_name";
            this.le_name.Size = new System.Drawing.Size(0, 19);
            this.le_name.TabIndex = 81;
            this.le_name.Click += new System.EventHandler(this.label5_Click);
            // 
            // le_date
            // 
            this.le_date.AutoSize = true;
            this.le_date.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_date.ForeColor = System.Drawing.Color.Red;
            this.le_date.Location = new System.Drawing.Point(196, 299);
            this.le_date.Name = "le_date";
            this.le_date.Size = new System.Drawing.Size(0, 19);
            this.le_date.TabIndex = 82;
            this.le_date.Click += new System.EventHandler(this.label13_Click);
            // 
            // le_time
            // 
            this.le_time.AutoSize = true;
            this.le_time.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_time.ForeColor = System.Drawing.Color.Red;
            this.le_time.Location = new System.Drawing.Point(196, 364);
            this.le_time.Name = "le_time";
            this.le_time.Size = new System.Drawing.Size(0, 19);
            this.le_time.TabIndex = 83;
            this.le_time.Click += new System.EventHandler(this.label14_Click);
            // 
            // le_course
            // 
            this.le_course.AutoSize = true;
            this.le_course.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_course.ForeColor = System.Drawing.Color.Red;
            this.le_course.Location = new System.Drawing.Point(196, 429);
            this.le_course.Name = "le_course";
            this.le_course.Size = new System.Drawing.Size(0, 19);
            this.le_course.TabIndex = 84;
            // 
            // le_subject
            // 
            this.le_subject.AutoSize = true;
            this.le_subject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_subject.ForeColor = System.Drawing.Color.Red;
            this.le_subject.Location = new System.Drawing.Point(196, 489);
            this.le_subject.Name = "le_subject";
            this.le_subject.Size = new System.Drawing.Size(0, 19);
            this.le_subject.TabIndex = 85;
            // 
            // le_examtype
            // 
            this.le_examtype.AutoSize = true;
            this.le_examtype.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_examtype.ForeColor = System.Drawing.Color.Red;
            this.le_examtype.Location = new System.Drawing.Point(792, 231);
            this.le_examtype.Name = "le_examtype";
            this.le_examtype.Size = new System.Drawing.Size(0, 19);
            this.le_examtype.TabIndex = 86;
            this.le_examtype.Click += new System.EventHandler(this.label17_Click);
            // 
            // le_duration
            // 
            this.le_duration.AutoSize = true;
            this.le_duration.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_duration.ForeColor = System.Drawing.Color.Red;
            this.le_duration.Location = new System.Drawing.Point(792, 298);
            this.le_duration.Name = "le_duration";
            this.le_duration.Size = new System.Drawing.Size(0, 19);
            this.le_duration.TabIndex = 87;
            this.le_duration.Click += new System.EventHandler(this.label18_Click);
            // 
            // le_room
            // 
            this.le_room.AutoSize = true;
            this.le_room.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_room.ForeColor = System.Drawing.Color.Red;
            this.le_room.Location = new System.Drawing.Point(792, 369);
            this.le_room.Name = "le_room";
            this.le_room.Size = new System.Drawing.Size(0, 19);
            this.le_room.TabIndex = 89;
            this.le_room.Click += new System.EventHandler(this.label20_Click);
            // 
            // le_remarks
            // 
            this.le_remarks.AutoSize = true;
            this.le_remarks.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_remarks.ForeColor = System.Drawing.Color.Red;
            this.le_remarks.Location = new System.Drawing.Point(792, 433);
            this.le_remarks.Name = "le_remarks";
            this.le_remarks.Size = new System.Drawing.Size(0, 19);
            this.le_remarks.TabIndex = 90;
            this.le_remarks.Click += new System.EventHandler(this.label21_Click);
            // 
            // ce_status
            // 
            this.ce_status.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce_status.FormattingEnabled = true;
            this.ce_status.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Cancelled",
            "Postponed",
            "Rescheduled"});
            this.ce_status.Location = new System.Drawing.Point(773, 457);
            this.ce_status.Margin = new System.Windows.Forms.Padding(4);
            this.ce_status.Name = "ce_status";
            this.ce_status.Size = new System.Drawing.Size(270, 28);
            this.ce_status.TabIndex = 92;
            this.ce_status.SelectedIndexChanged += new System.EventHandler(this.ce_status_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 458);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 91;
            this.label5.Text = "Status";
            // 
            // le_status
            // 
            this.le_status.AutoSize = true;
            this.le_status.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le_status.ForeColor = System.Drawing.Color.Red;
            this.le_status.Location = new System.Drawing.Point(782, 492);
            this.le_status.Name = "le_status";
            this.le_status.Size = new System.Drawing.Size(0, 19);
            this.le_status.TabIndex = 93;
            // 
            // ExamRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.le_status);
            this.Controls.Add(this.ce_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.le_remarks);
            this.Controls.Add(this.le_room);
            this.Controls.Add(this.le_duration);
            this.Controls.Add(this.le_examtype);
            this.Controls.Add(this.le_subject);
            this.Controls.Add(this.le_course);
            this.Controls.Add(this.le_time);
            this.Controls.Add(this.le_date);
            this.Controls.Add(this.le_name);
            this.Controls.Add(this.be_back);
            this.Controls.Add(this.be_clear);
            this.Controls.Add(this.ce_subject);
            this.Controls.Add(this.ce_course);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.de_time);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ce_room);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.te_remarks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.te_duration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ce_examtype);
            this.Controls.Add(this.de_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.be_register);
            this.Controls.Add(this.te_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamRegisterForm";
            this.Load += new System.EventHandler(this.ExamRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button be_back;
        private System.Windows.Forms.Button be_clear;
        private System.Windows.Forms.ComboBox ce_subject;
        private System.Windows.Forms.ComboBox ce_course;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker de_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ce_room;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox te_remarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox te_duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ce_examtype;
        private System.Windows.Forms.DateTimePicker de_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button be_register;
        private System.Windows.Forms.TextBox te_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label le_name;
        private System.Windows.Forms.Label le_date;
        private System.Windows.Forms.Label le_time;
        private System.Windows.Forms.Label le_course;
        private System.Windows.Forms.Label le_subject;
        private System.Windows.Forms.Label le_examtype;
        private System.Windows.Forms.Label le_duration;
        private System.Windows.Forms.Label le_room;
        private System.Windows.Forms.Label le_remarks;
        private System.Windows.Forms.ComboBox ce_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label le_status;
    }
}