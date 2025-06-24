namespace UnicomTICManagementSystem.View
{
    partial class CreateEducation
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
            this.b_department = new System.Windows.Forms.Button();
            this.b_course = new System.Windows.Forms.Button();
            this.b_subject = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_department
            // 
            this.b_department.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_department.Location = new System.Drawing.Point(451, 77);
            this.b_department.Name = "b_department";
            this.b_department.Size = new System.Drawing.Size(351, 116);
            this.b_department.TabIndex = 0;
            this.b_department.Text = "Create Department";
            this.b_department.UseVisualStyleBackColor = true;
            this.b_department.Click += new System.EventHandler(this.b_department_Click);
            // 
            // b_course
            // 
            this.b_course.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_course.Location = new System.Drawing.Point(451, 251);
            this.b_course.Name = "b_course";
            this.b_course.Size = new System.Drawing.Size(351, 116);
            this.b_course.TabIndex = 1;
            this.b_course.Text = "Create Course";
            this.b_course.UseVisualStyleBackColor = true;
            this.b_course.Click += new System.EventHandler(this.b_course_Click);
            // 
            // b_subject
            // 
            this.b_subject.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_subject.Location = new System.Drawing.Point(451, 421);
            this.b_subject.Name = "b_subject";
            this.b_subject.Size = new System.Drawing.Size(351, 116);
            this.b_subject.TabIndex = 2;
            this.b_subject.Text = "Create Subject";
            this.b_subject.UseVisualStyleBackColor = true;
            this.b_subject.Click += new System.EventHandler(this.b_subject_Click);
            // 
            // b_back
            // 
            this.b_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_back.Location = new System.Drawing.Point(1053, 619);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(99, 53);
            this.b_back.TabIndex = 3;
            this.b_back.Text = "Back";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // CreateEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_subject);
            this.Controls.Add(this.b_course);
            this.Controls.Add(this.b_department);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEducation";
            this.Text = "CreateEducation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_department;
        private System.Windows.Forms.Button b_course;
        private System.Windows.Forms.Button b_subject;
        private System.Windows.Forms.Button b_back;
    }
}