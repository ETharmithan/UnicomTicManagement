namespace UnicomTICManagementSystem.View
{
    partial class MarkRegister
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
            this.label4 = new System.Windows.Forms.Label();
            this.tm_score = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tm_delete = new System.Windows.Forms.Button();
            this.tm_update = new System.Windows.Forms.Button();
            this.tm_search = new System.Windows.Forms.Button();
            this.tm_add = new System.Windows.Forms.Button();
            this.tm_grade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dm_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cm_course = new System.Windows.Forms.ComboBox();
            this.cm_subject = new System.Windows.Forms.ComboBox();
            this.bm_back = new System.Windows.Forms.Button();
            this.cm_exam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tm_studentname = new System.Windows.Forms.Label();
            this.cm_department = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cm_student = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dm_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Subject";
            // 
            // tm_score
            // 
            this.tm_score.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_score.Location = new System.Drawing.Point(779, 154);
            this.tm_score.Margin = new System.Windows.Forms.Padding(4);
            this.tm_score.Name = "tm_score";
            this.tm_score.Size = new System.Drawing.Size(308, 27);
            this.tm_score.TabIndex = 26;
            this.tm_score.TextChanged += new System.EventHandler(this.tm_score_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(643, 162);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 19);
            this.label.TabIndex = 25;
            this.label.Text = "Score";
            // 
            // tm_delete
            // 
            this.tm_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_delete.Location = new System.Drawing.Point(931, 287);
            this.tm_delete.Margin = new System.Windows.Forms.Padding(4);
            this.tm_delete.Name = "tm_delete";
            this.tm_delete.Size = new System.Drawing.Size(101, 41);
            this.tm_delete.TabIndex = 24;
            this.tm_delete.Text = "Delete";
            this.tm_delete.UseVisualStyleBackColor = true;
            this.tm_delete.Click += new System.EventHandler(this.tm_delete_Click);
            // 
            // tm_update
            // 
            this.tm_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_update.Location = new System.Drawing.Point(797, 287);
            this.tm_update.Margin = new System.Windows.Forms.Padding(4);
            this.tm_update.Name = "tm_update";
            this.tm_update.Size = new System.Drawing.Size(101, 41);
            this.tm_update.TabIndex = 23;
            this.tm_update.Text = "Update";
            this.tm_update.UseVisualStyleBackColor = true;
            this.tm_update.Click += new System.EventHandler(this.tm_update_Click);
            // 
            // tm_search
            // 
            this.tm_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_search.Location = new System.Drawing.Point(535, 287);
            this.tm_search.Margin = new System.Windows.Forms.Padding(4);
            this.tm_search.Name = "tm_search";
            this.tm_search.Size = new System.Drawing.Size(101, 41);
            this.tm_search.TabIndex = 22;
            this.tm_search.Text = "Search";
            this.tm_search.UseVisualStyleBackColor = true;
            this.tm_search.Click += new System.EventHandler(this.tm_search_Click);
            // 
            // tm_add
            // 
            this.tm_add.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_add.Location = new System.Drawing.Point(667, 287);
            this.tm_add.Margin = new System.Windows.Forms.Padding(4);
            this.tm_add.Name = "tm_add";
            this.tm_add.Size = new System.Drawing.Size(101, 41);
            this.tm_add.TabIndex = 21;
            this.tm_add.Text = "Add";
            this.tm_add.UseVisualStyleBackColor = true;
            this.tm_add.Click += new System.EventHandler(this.tm_add_Click);
            // 
            // tm_grade
            // 
            this.tm_grade.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_grade.Location = new System.Drawing.Point(779, 208);
            this.tm_grade.Margin = new System.Windows.Forms.Padding(4);
            this.tm_grade.Name = "tm_grade";
            this.tm_grade.Size = new System.Drawing.Size(308, 27);
            this.tm_grade.TabIndex = 20;
            this.tm_grade.TextChanged += new System.EventHandler(this.tm_grade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Grade";
            // 
            // dm_view
            // 
            this.dm_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dm_view.Location = new System.Drawing.Point(51, 336);
            this.dm_view.Margin = new System.Windows.Forms.Padding(4);
            this.dm_view.Name = "dm_view";
            this.dm_view.RowHeadersWidth = 51;
            this.dm_view.Size = new System.Drawing.Size(1124, 330);
            this.dm_view.TabIndex = 16;
            this.dm_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dm_view_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 53);
            this.label1.TabIndex = 29;
            this.label1.Text = "NEW MARK REGISTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Course";
            // 
            // cm_course
            // 
            this.cm_course.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_course.FormattingEnabled = true;
            this.cm_course.Location = new System.Drawing.Point(198, 136);
            this.cm_course.Name = "cm_course";
            this.cm_course.Size = new System.Drawing.Size(308, 27);
            this.cm_course.TabIndex = 32;
            this.cm_course.SelectedIndexChanged += new System.EventHandler(this.cm_course_SelectedIndexChanged);
            // 
            // cm_subject
            // 
            this.cm_subject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_subject.FormattingEnabled = true;
            this.cm_subject.Location = new System.Drawing.Point(198, 193);
            this.cm_subject.Name = "cm_subject";
            this.cm_subject.Size = new System.Drawing.Size(308, 27);
            this.cm_subject.TabIndex = 33;
            this.cm_subject.SelectedIndexChanged += new System.EventHandler(this.cm_subject_SelectedIndexChanged);
            // 
            // bm_back
            // 
            this.bm_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bm_back.Location = new System.Drawing.Point(1040, 287);
            this.bm_back.Margin = new System.Windows.Forms.Padding(4);
            this.bm_back.Name = "bm_back";
            this.bm_back.Size = new System.Drawing.Size(108, 41);
            this.bm_back.TabIndex = 34;
            this.bm_back.Text = "Back";
            this.bm_back.UseVisualStyleBackColor = true;
            this.bm_back.Click += new System.EventHandler(this.bm_back_Click);
            // 
            // cm_exam
            // 
            this.cm_exam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_exam.FormattingEnabled = true;
            this.cm_exam.Location = new System.Drawing.Point(198, 244);
            this.cm_exam.Name = "cm_exam";
            this.cm_exam.Size = new System.Drawing.Size(308, 27);
            this.cm_exam.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Exam";
            // 
            // tm_studentname
            // 
            this.tm_studentname.AutoSize = true;
            this.tm_studentname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm_studentname.Location = new System.Drawing.Point(634, 110);
            this.tm_studentname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tm_studentname.Name = "tm_studentname";
            this.tm_studentname.Size = new System.Drawing.Size(111, 19);
            this.tm_studentname.TabIndex = 37;
            this.tm_studentname.Text = "Student Name";
            // 
            // cm_department
            // 
            this.cm_department.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_department.FormattingEnabled = true;
            this.cm_department.Location = new System.Drawing.Point(198, 84);
            this.cm_department.Name = "cm_department";
            this.cm_department.Size = new System.Drawing.Size(308, 27);
            this.cm_department.TabIndex = 40;
            this.cm_department.SelectedIndexChanged += new System.EventHandler(this.cm_department_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Department";
            // 
            // cm_student
            // 
            this.cm_student.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_student.FormattingEnabled = true;
            this.cm_student.Location = new System.Drawing.Point(779, 102);
            this.cm_student.Name = "cm_student";
            this.cm_student.Size = new System.Drawing.Size(308, 27);
            this.cm_student.TabIndex = 41;
            // 
            // MarkRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.cm_student);
            this.Controls.Add(this.cm_department);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tm_studentname);
            this.Controls.Add(this.cm_exam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bm_back);
            this.Controls.Add(this.cm_subject);
            this.Controls.Add(this.cm_course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tm_score);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tm_delete);
            this.Controls.Add(this.tm_update);
            this.Controls.Add(this.tm_search);
            this.Controls.Add(this.tm_add);
            this.Controls.Add(this.tm_grade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dm_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MarkRegister";
            this.Text = "MarkRegister";
            this.Load += new System.EventHandler(this.MarkRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dm_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tm_score;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button tm_delete;
        private System.Windows.Forms.Button tm_update;
        private System.Windows.Forms.Button tm_search;
        private System.Windows.Forms.Button tm_add;
        private System.Windows.Forms.TextBox tm_grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dm_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cm_course;
        private System.Windows.Forms.ComboBox cm_subject;
        private System.Windows.Forms.Button bm_back;
        private System.Windows.Forms.ComboBox cm_exam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tm_studentname;
        private System.Windows.Forms.ComboBox cm_department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cm_student;
    }
}