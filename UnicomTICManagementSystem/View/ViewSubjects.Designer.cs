namespace UnicomTICManagementSystem.View
{
    partial class ViewSubjects
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
            this.dacs_view = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ca_department = new System.Windows.Forms.ComboBox();
            this.ca_course = new System.Windows.Forms.ComboBox();
            this.ca_subject = new System.Windows.Forms.ComboBox();
            this.ba_search = new System.Windows.Forms.Button();
            this.ba_update = new System.Windows.Forms.Button();
            this.ba_delete = new System.Windows.Forms.Button();
            this.ba_back = new System.Windows.Forms.Button();
            this.ba_adddepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dacs_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Structure Overview";
            // 
            // dacs_view
            // 
            this.dacs_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dacs_view.Location = new System.Drawing.Point(73, 326);
            this.dacs_view.Name = "dacs_view";
            this.dacs_view.RowHeadersWidth = 51;
            this.dacs_view.RowTemplate.Height = 24;
            this.dacs_view.Size = new System.Drawing.Size(1076, 358);
            this.dacs_view.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject";
            // 
            // ca_department
            // 
            this.ca_department.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ca_department.FormattingEnabled = true;
            this.ca_department.Location = new System.Drawing.Point(450, 102);
            this.ca_department.Name = "ca_department";
            this.ca_department.Size = new System.Drawing.Size(250, 28);
            this.ca_department.TabIndex = 5;
            this.ca_department.SelectedIndexChanged += new System.EventHandler(this.ca_department_SelectedIndexChanged);
            // 
            // ca_course
            // 
            this.ca_course.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ca_course.FormattingEnabled = true;
            this.ca_course.Location = new System.Drawing.Point(450, 168);
            this.ca_course.Name = "ca_course";
            this.ca_course.Size = new System.Drawing.Size(250, 28);
            this.ca_course.TabIndex = 6;
            this.ca_course.SelectedIndexChanged += new System.EventHandler(this.ca_course_SelectedIndexChanged);
            // 
            // ca_subject
            // 
            this.ca_subject.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ca_subject.FormattingEnabled = true;
            this.ca_subject.Location = new System.Drawing.Point(450, 232);
            this.ca_subject.Name = "ca_subject";
            this.ca_subject.Size = new System.Drawing.Size(250, 28);
            this.ca_subject.TabIndex = 7;
            this.ca_subject.SelectedIndexChanged += new System.EventHandler(this.ca_subject_SelectedIndexChanged);
            // 
            // ba_search
            // 
            this.ba_search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_search.Location = new System.Drawing.Point(776, 87);
            this.ba_search.Name = "ba_search";
            this.ba_search.Size = new System.Drawing.Size(97, 35);
            this.ba_search.TabIndex = 8;
            this.ba_search.Text = "Search";
            this.ba_search.UseVisualStyleBackColor = true;
            this.ba_search.Click += new System.EventHandler(this.ba_search_Click);
            // 
            // ba_update
            // 
            this.ba_update.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_update.Location = new System.Drawing.Point(776, 141);
            this.ba_update.Name = "ba_update";
            this.ba_update.Size = new System.Drawing.Size(97, 35);
            this.ba_update.TabIndex = 9;
            this.ba_update.Text = "Update";
            this.ba_update.UseVisualStyleBackColor = true;
            this.ba_update.Click += new System.EventHandler(this.ba_update_Click);
            // 
            // ba_delete
            // 
            this.ba_delete.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_delete.Location = new System.Drawing.Point(776, 195);
            this.ba_delete.Name = "ba_delete";
            this.ba_delete.Size = new System.Drawing.Size(97, 35);
            this.ba_delete.TabIndex = 10;
            this.ba_delete.Text = "Delete";
            this.ba_delete.UseVisualStyleBackColor = true;
            this.ba_delete.Click += new System.EventHandler(this.ba_delete_Click);
            // 
            // ba_back
            // 
            this.ba_back.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_back.Location = new System.Drawing.Point(776, 245);
            this.ba_back.Name = "ba_back";
            this.ba_back.Size = new System.Drawing.Size(97, 35);
            this.ba_back.TabIndex = 11;
            this.ba_back.Text = "Back";
            this.ba_back.UseVisualStyleBackColor = true;
            this.ba_back.Click += new System.EventHandler(this.ba_back_Click);
            // 
            // ba_adddepartment
            // 
            this.ba_adddepartment.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.ba_adddepartment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_adddepartment.Location = new System.Drawing.Point(895, 275);
            this.ba_adddepartment.Name = "ba_adddepartment";
            this.ba_adddepartment.Size = new System.Drawing.Size(254, 45);
            this.ba_adddepartment.TabIndex = 12;
            this.ba_adddepartment.Text = "Add ";
            this.ba_adddepartment.UseVisualStyleBackColor = true;
            this.ba_adddepartment.Click += new System.EventHandler(this.ba_adddepartment_Click);
            // 
            // ViewSubjects
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.ba_adddepartment);
            this.Controls.Add(this.ba_back);
            this.Controls.Add(this.ba_delete);
            this.Controls.Add(this.ba_update);
            this.Controls.Add(this.ba_search);
            this.Controls.Add(this.ca_subject);
            this.Controls.Add(this.ca_course);
            this.Controls.Add(this.ca_department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dacs_view);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSubjects";
            this.Text = "ViewSubjects";
            this.Load += new System.EventHandler(this.ViewSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dacs_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dacs_view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ca_department;
        private System.Windows.Forms.ComboBox ca_course;
        private System.Windows.Forms.ComboBox ca_subject;
        private System.Windows.Forms.Button ba_search;
        private System.Windows.Forms.Button ba_update;
        private System.Windows.Forms.Button ba_delete;
        private System.Windows.Forms.Button ba_back;
        private System.Windows.Forms.Button ba_adddepartment;
    }
}