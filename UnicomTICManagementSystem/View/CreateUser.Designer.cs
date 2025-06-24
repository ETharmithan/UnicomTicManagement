namespace UnicomTICManagementSystem.View
{
    partial class CreateUser
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
            this.b_admin = new System.Windows.Forms.Button();
            this.b_lecture = new System.Windows.Forms.Button();
            this.b_Staff = new System.Windows.Forms.Button();
            this.b_student = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_admin
            // 
            this.b_admin.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_admin.Location = new System.Drawing.Point(238, 123);
            this.b_admin.Name = "b_admin";
            this.b_admin.Size = new System.Drawing.Size(313, 157);
            this.b_admin.TabIndex = 0;
            this.b_admin.Text = "Admin";
            this.b_admin.UseVisualStyleBackColor = true;
            this.b_admin.Click += new System.EventHandler(this.b_admin_Click);
            // 
            // b_lecture
            // 
            this.b_lecture.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lecture.Location = new System.Drawing.Point(238, 338);
            this.b_lecture.Name = "b_lecture";
            this.b_lecture.Size = new System.Drawing.Size(313, 157);
            this.b_lecture.TabIndex = 1;
            this.b_lecture.Text = "Lecture";
            this.b_lecture.UseVisualStyleBackColor = true;
            this.b_lecture.Click += new System.EventHandler(this.b_lecture_Click);
            // 
            // b_Staff
            // 
            this.b_Staff.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Staff.Location = new System.Drawing.Point(723, 123);
            this.b_Staff.Name = "b_Staff";
            this.b_Staff.Size = new System.Drawing.Size(313, 157);
            this.b_Staff.TabIndex = 2;
            this.b_Staff.Text = "Staff";
            this.b_Staff.UseVisualStyleBackColor = true;
            this.b_Staff.Click += new System.EventHandler(this.b_Staff_Click);
            // 
            // b_student
            // 
            this.b_student.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_student.Location = new System.Drawing.Point(723, 338);
            this.b_student.Name = "b_student";
            this.b_student.Size = new System.Drawing.Size(313, 157);
            this.b_student.TabIndex = 3;
            this.b_student.Text = "Student";
            this.b_student.UseVisualStyleBackColor = true;
            this.b_student.Click += new System.EventHandler(this.b_student_Click);
            // 
            // b_back
            // 
            this.b_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_back.Location = new System.Drawing.Point(1058, 630);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(98, 46);
            this.b_back.TabIndex = 4;
            this.b_back.Text = "Back";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_student);
            this.Controls.Add(this.b_Staff);
            this.Controls.Add(this.b_lecture);
            this.Controls.Add(this.b_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_admin;
        private System.Windows.Forms.Button b_lecture;
        private System.Windows.Forms.Button b_Staff;
        private System.Windows.Forms.Button b_student;
        private System.Windows.Forms.Button b_back;
    }
}