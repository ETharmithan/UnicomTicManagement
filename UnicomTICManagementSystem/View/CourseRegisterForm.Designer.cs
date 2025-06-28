namespace UnicomTICManagementSystem.View
{
    partial class CourseRegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tc_description = new System.Windows.Forms.TextBox();
            this.tc_duration = new System.Windows.Forms.TextBox();
            this.bc_addtosubject = new System.Windows.Forms.Button();
            this.bc_clear = new System.Windows.Forms.Button();
            this.bc_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cc_department = new System.Windows.Forms.ComboBox();
            this.bc_addtodepartment = new System.Windows.Forms.Button();
            this.bc_subject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW COURSE REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duration";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(511, 219);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tc_description
            // 
            this.tc_description.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_description.Location = new System.Drawing.Point(511, 277);
            this.tc_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_description.Name = "tc_description";
            this.tc_description.Size = new System.Drawing.Size(245, 28);
            this.tc_description.TabIndex = 5;
            this.tc_description.TextChanged += new System.EventHandler(this.tc_description_TextChanged);
            // 
            // tc_duration
            // 
            this.tc_duration.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_duration.Location = new System.Drawing.Point(511, 342);
            this.tc_duration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_duration.Name = "tc_duration";
            this.tc_duration.Size = new System.Drawing.Size(245, 28);
            this.tc_duration.TabIndex = 6;
            this.tc_duration.TextChanged += new System.EventHandler(this.tc_duration_TextChanged);
            // 
            // bc_addtosubject
            // 
            this.bc_addtosubject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_addtosubject.Location = new System.Drawing.Point(716, 434);
            this.bc_addtosubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bc_addtosubject.Name = "bc_addtosubject";
            this.bc_addtosubject.Size = new System.Drawing.Size(147, 38);
            this.bc_addtosubject.TabIndex = 7;
            this.bc_addtosubject.Text = "Add";
            this.bc_addtosubject.UseVisualStyleBackColor = true;
            this.bc_addtosubject.Click += new System.EventHandler(this.bc_addtosubject_Click);
            // 
            // bc_clear
            // 
            this.bc_clear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_clear.Location = new System.Drawing.Point(516, 434);
            this.bc_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bc_clear.Name = "bc_clear";
            this.bc_clear.Size = new System.Drawing.Size(147, 38);
            this.bc_clear.TabIndex = 8;
            this.bc_clear.Text = "Clear";
            this.bc_clear.UseVisualStyleBackColor = true;
            this.bc_clear.Click += new System.EventHandler(this.bc_clear_Click);
            // 
            // bc_back
            // 
            this.bc_back.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_back.Location = new System.Drawing.Point(316, 434);
            this.bc_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bc_back.Name = "bc_back";
            this.bc_back.Size = new System.Drawing.Size(147, 38);
            this.bc_back.TabIndex = 9;
            this.bc_back.Text = "Back";
            this.bc_back.UseVisualStyleBackColor = true;
            this.bc_back.Click += new System.EventHandler(this.bc_back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department";
            // 
            // cc_department
            // 
            this.cc_department.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc_department.FormattingEnabled = true;
            this.cc_department.Location = new System.Drawing.Point(511, 166);
            this.cc_department.Name = "cc_department";
            this.cc_department.Size = new System.Drawing.Size(245, 28);
            this.cc_department.TabIndex = 16;
            this.cc_department.SelectedIndexChanged += new System.EventHandler(this.cc_department_SelectedIndexChanged);
            // 
            // bc_addtodepartment
            // 
            this.bc_addtodepartment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_addtodepartment.Location = new System.Drawing.Point(856, 156);
            this.bc_addtodepartment.Name = "bc_addtodepartment";
            this.bc_addtodepartment.Size = new System.Drawing.Size(237, 38);
            this.bc_addtodepartment.TabIndex = 17;
            this.bc_addtodepartment.Text = "Add to Department";
            this.bc_addtodepartment.UseVisualStyleBackColor = true;
            this.bc_addtodepartment.Click += new System.EventHandler(this.bc_addtodepartment_Click);
            // 
            // bc_subject
            // 
            this.bc_subject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc_subject.Location = new System.Drawing.Point(919, 605);
            this.bc_subject.Name = "bc_subject";
            this.bc_subject.Size = new System.Drawing.Size(237, 38);
            this.bc_subject.TabIndex = 20;
            this.bc_subject.Text = "Add to Subject";
            this.bc_subject.UseVisualStyleBackColor = true;
            this.bc_subject.Click += new System.EventHandler(this.bc_subject_Click);
            // 
            // CourseRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.bc_subject);
            this.Controls.Add(this.bc_addtodepartment);
            this.Controls.Add(this.cc_department);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bc_back);
            this.Controls.Add(this.bc_clear);
            this.Controls.Add(this.bc_addtosubject);
            this.Controls.Add(this.tc_duration);
            this.Controls.Add(this.tc_description);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseRegisterForm";
            this.Text = "CourseRegisterForm";
            this.Load += new System.EventHandler(this.CourseRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tc_description;
        private System.Windows.Forms.TextBox tc_duration;
        private System.Windows.Forms.Button bc_addtosubject;
        private System.Windows.Forms.Button bc_clear;
        private System.Windows.Forms.Button bc_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cc_department;
        private System.Windows.Forms.Button bc_addtodepartment;
        private System.Windows.Forms.Button bc_subject;
    }
}