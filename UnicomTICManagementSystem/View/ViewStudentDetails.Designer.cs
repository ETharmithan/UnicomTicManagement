namespace UnicomTICManagementSystem.View
{
    partial class ViewStudentDetails
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
            this.ds_student = new System.Windows.Forms.DataGridView();
            this.ts_search = new System.Windows.Forms.TextBox();
            this.bs_search = new System.Windows.Forms.Button();
            this.bs_update = new System.Windows.Forms.Button();
            this.bs_delete = new System.Windows.Forms.Button();
            this.bs_addstudent = new System.Windows.Forms.Button();
            this.bs_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds_student)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_student
            // 
            this.ds_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_student.Location = new System.Drawing.Point(39, 298);
            this.ds_student.Name = "ds_student";
            this.ds_student.RowHeadersWidth = 51;
            this.ds_student.RowTemplate.Height = 24;
            this.ds_student.Size = new System.Drawing.Size(1538, 392);
            this.ds_student.TabIndex = 0;
            // 
            // ts_search
            // 
            this.ts_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_search.Location = new System.Drawing.Point(577, 120);
            this.ts_search.Name = "ts_search";
            this.ts_search.Size = new System.Drawing.Size(299, 27);
            this.ts_search.TabIndex = 1;
            // 
            // bs_search
            // 
            this.bs_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_search.Location = new System.Drawing.Point(920, 115);
            this.bs_search.Name = "bs_search";
            this.bs_search.Size = new System.Drawing.Size(97, 34);
            this.bs_search.TabIndex = 2;
            this.bs_search.Text = "Search";
            this.bs_search.UseVisualStyleBackColor = true;
            this.bs_search.Click += new System.EventHandler(this.bs_search_Click);
            // 
            // bs_update
            // 
            this.bs_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_update.Location = new System.Drawing.Point(696, 204);
            this.bs_update.Name = "bs_update";
            this.bs_update.Size = new System.Drawing.Size(110, 35);
            this.bs_update.TabIndex = 4;
            this.bs_update.Text = "Update";
            this.bs_update.UseVisualStyleBackColor = true;
            this.bs_update.Click += new System.EventHandler(this.bs_update_Click);
            // 
            // bs_delete
            // 
            this.bs_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_delete.Location = new System.Drawing.Point(838, 204);
            this.bs_delete.Name = "bs_delete";
            this.bs_delete.Size = new System.Drawing.Size(110, 35);
            this.bs_delete.TabIndex = 5;
            this.bs_delete.Text = "Delete";
            this.bs_delete.UseVisualStyleBackColor = true;
            this.bs_delete.Click += new System.EventHandler(this.bs_delete_Click);
            // 
            // bs_addstudent
            // 
            this.bs_addstudent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_addstudent.Location = new System.Drawing.Point(1232, 30);
            this.bs_addstudent.Name = "bs_addstudent";
            this.bs_addstudent.Size = new System.Drawing.Size(201, 39);
            this.bs_addstudent.TabIndex = 6;
            this.bs_addstudent.Text = "Student Register ";
            this.bs_addstudent.UseVisualStyleBackColor = true;
            this.bs_addstudent.Click += new System.EventHandler(this.bs_addstudent_Click);
            // 
            // bs_back
            // 
            this.bs_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bs_back.Location = new System.Drawing.Point(552, 204);
            this.bs_back.Name = "bs_back";
            this.bs_back.Size = new System.Drawing.Size(110, 35);
            this.bs_back.TabIndex = 7;
            this.bs_back.Text = "Back";
            this.bs_back.UseVisualStyleBackColor = true;
            this.bs_back.Click += new System.EventHandler(this.bs_back_Click);
            // 
            // ViewStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.bs_back);
            this.Controls.Add(this.bs_addstudent);
            this.Controls.Add(this.bs_delete);
            this.Controls.Add(this.bs_update);
            this.Controls.Add(this.bs_search);
            this.Controls.Add(this.ts_search);
            this.Controls.Add(this.ds_student);
            this.Name = "ViewStudentDetails";
            this.Text = "ViewStudentDetails";
            this.Load += new System.EventHandler(this.ViewStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ds_student;
        private System.Windows.Forms.TextBox ts_search;
        private System.Windows.Forms.Button bs_search;
        private System.Windows.Forms.Button bs_update;
        private System.Windows.Forms.Button bs_delete;
        private System.Windows.Forms.Button bs_addstudent;
        private System.Windows.Forms.Button bs_back;
    }
}