namespace UnicomTICManagementSystem.View
{
    partial class cs_lecturer
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
            this.bs_addtocourse = new System.Windows.Forms.Button();
            this.cs_course = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bs_back = new System.Windows.Forms.Button();
            this.bs_clear = new System.Windows.Forms.Button();
            this.bs_add = new System.Windows.Forms.Button();
            this.ts_credit = new System.Windows.Forms.TextBox();
            this.ts_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bs_addtodepartment = new System.Windows.Forms.Button();
            this.cs_department = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bs_addtocourse
            // 
            this.bs_addtocourse.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_addtocourse.Location = new System.Drawing.Point(748, 238);
            this.bs_addtocourse.Name = "bs_addtocourse";
            this.bs_addtocourse.Size = new System.Drawing.Size(228, 42);
            this.bs_addtocourse.TabIndex = 43;
            this.bs_addtocourse.Text = "Add to Course";
            this.bs_addtocourse.UseVisualStyleBackColor = true;
            this.bs_addtocourse.Click += new System.EventHandler(this.bs_addtocourse_Click);
            // 
            // cs_course
            // 
            this.cs_course.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_course.FormattingEnabled = true;
            this.cs_course.Location = new System.Drawing.Point(455, 241);
            this.cs_course.Name = "cs_course";
            this.cs_course.Size = new System.Drawing.Size(245, 28);
            this.cs_course.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Course";
            // 
            // bs_back
            // 
            this.bs_back.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_back.Location = new System.Drawing.Point(318, 509);
            this.bs_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bs_back.Name = "bs_back";
            this.bs_back.Size = new System.Drawing.Size(147, 38);
            this.bs_back.TabIndex = 40;
            this.bs_back.Text = "Back";
            this.bs_back.UseVisualStyleBackColor = true;
            this.bs_back.Click += new System.EventHandler(this.bs_back_Click);
            // 
            // bs_clear
            // 
            this.bs_clear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_clear.Location = new System.Drawing.Point(518, 509);
            this.bs_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bs_clear.Name = "bs_clear";
            this.bs_clear.Size = new System.Drawing.Size(147, 38);
            this.bs_clear.TabIndex = 39;
            this.bs_clear.Text = "Clear";
            this.bs_clear.UseVisualStyleBackColor = true;
            this.bs_clear.Click += new System.EventHandler(this.bs_clear_Click);
            // 
            // bs_add
            // 
            this.bs_add.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_add.Location = new System.Drawing.Point(718, 509);
            this.bs_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bs_add.Name = "bs_add";
            this.bs_add.Size = new System.Drawing.Size(147, 38);
            this.bs_add.TabIndex = 38;
            this.bs_add.Text = "Add";
            this.bs_add.UseVisualStyleBackColor = true;
            this.bs_add.Click += new System.EventHandler(this.bs_add_Click);
            // 
            // ts_credit
            // 
            this.ts_credit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_credit.Location = new System.Drawing.Point(455, 378);
            this.ts_credit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ts_credit.Name = "ts_credit";
            this.ts_credit.Size = new System.Drawing.Size(245, 28);
            this.ts_credit.TabIndex = 37;
            this.ts_credit.TextChanged += new System.EventHandler(this.ts_credit_TextChanged);
            // 
            // ts_name
            // 
            this.ts_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_name.Location = new System.Drawing.Point(455, 314);
            this.ts_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ts_name.Name = "ts_name";
            this.ts_name.Size = new System.Drawing.Size(245, 28);
            this.ts_name.TabIndex = 35;
            this.ts_name.TextChanged += new System.EventHandler(this.ts_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 53);
            this.label1.TabIndex = 31;
            this.label1.Text = "NEW SUBJECT REGISTER";
            // 
            // bs_addtodepartment
            // 
            this.bs_addtodepartment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_addtodepartment.Location = new System.Drawing.Point(748, 171);
            this.bs_addtodepartment.Name = "bs_addtodepartment";
            this.bs_addtodepartment.Size = new System.Drawing.Size(228, 42);
            this.bs_addtodepartment.TabIndex = 48;
            this.bs_addtodepartment.Text = "Add to Department";
            this.bs_addtodepartment.UseVisualStyleBackColor = true;
            this.bs_addtodepartment.Click += new System.EventHandler(this.bs_addtodepartment_Click);
            // 
            // cs_department
            // 
            this.cs_department.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_department.FormattingEnabled = true;
            this.cs_department.Location = new System.Drawing.Point(455, 179);
            this.cs_department.Name = "cs_department";
            this.cs_department.Size = new System.Drawing.Size(245, 28);
            this.cs_department.TabIndex = 47;
            this.cs_department.SelectedIndexChanged += new System.EventHandler(this.cs_department_SelectedIndexChanged);
            this.cs_department.TextChanged += new System.EventHandler(this.cs_department_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Department";
            // 
            // cs_lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.bs_addtodepartment);
            this.Controls.Add(this.cs_department);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bs_addtocourse);
            this.Controls.Add(this.cs_course);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bs_back);
            this.Controls.Add(this.bs_clear);
            this.Controls.Add(this.bs_add);
            this.Controls.Add(this.ts_credit);
            this.Controls.Add(this.ts_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cs_lecturer";
            this.Text = "SubjectRegisterForm";
            this.Load += new System.EventHandler(this.cs_lecturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bs_addtocourse;
        private System.Windows.Forms.ComboBox cs_course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bs_back;
        private System.Windows.Forms.Button bs_clear;
        private System.Windows.Forms.Button bs_add;
        private System.Windows.Forms.TextBox ts_credit;
        private System.Windows.Forms.TextBox ts_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bs_addtodepartment;
        private System.Windows.Forms.ComboBox cs_department;
        private System.Windows.Forms.Label label5;
    }
}