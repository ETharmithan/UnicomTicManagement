namespace UnicomTICManagementSystem.View
{
    partial class DepartmentRegister
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
            this.td_name = new System.Windows.Forms.TextBox();
            this.td_description = new System.Windows.Forms.TextBox();
            this.bd_back = new System.Windows.Forms.Button();
            this.bd_clear = new System.Windows.Forms.Button();
            this.bd_add = new System.Windows.Forms.Button();
            this.ld_name = new System.Windows.Forms.Label();
            this.ld_description = new System.Windows.Forms.Label();
            this.bd_addtocourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW DEPARTMENT REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // td_name
            // 
            this.td_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_name.Location = new System.Drawing.Point(731, 147);
            this.td_name.Name = "td_name";
            this.td_name.Size = new System.Drawing.Size(283, 28);
            this.td_name.TabIndex = 3;
            this.td_name.TextChanged += new System.EventHandler(this.td_name_TextChanged);
            // 
            // td_description
            // 
            this.td_description.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_description.Location = new System.Drawing.Point(731, 218);
            this.td_description.Name = "td_description";
            this.td_description.Size = new System.Drawing.Size(283, 28);
            this.td_description.TabIndex = 4;
            this.td_description.TextChanged += new System.EventHandler(this.td_description_TextChanged);
            // 
            // bd_back
            // 
            this.bd_back.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_back.Location = new System.Drawing.Point(552, 303);
            this.bd_back.Name = "bd_back";
            this.bd_back.Size = new System.Drawing.Size(117, 42);
            this.bd_back.TabIndex = 5;
            this.bd_back.Text = "Back";
            this.bd_back.UseVisualStyleBackColor = true;
            this.bd_back.Click += new System.EventHandler(this.bd_back_Click);
            // 
            // bd_clear
            // 
            this.bd_clear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_clear.Location = new System.Drawing.Point(731, 303);
            this.bd_clear.Name = "bd_clear";
            this.bd_clear.Size = new System.Drawing.Size(117, 42);
            this.bd_clear.TabIndex = 6;
            this.bd_clear.Text = "Clear";
            this.bd_clear.UseVisualStyleBackColor = true;
            this.bd_clear.Click += new System.EventHandler(this.bd_clear_Click);
            // 
            // bd_add
            // 
            this.bd_add.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_add.Location = new System.Drawing.Point(897, 303);
            this.bd_add.Name = "bd_add";
            this.bd_add.Size = new System.Drawing.Size(117, 42);
            this.bd_add.TabIndex = 7;
            this.bd_add.Text = "Add";
            this.bd_add.UseVisualStyleBackColor = true;
            this.bd_add.Click += new System.EventHandler(this.bd_add_Click);
            // 
            // ld_name
            // 
            this.ld_name.AutoSize = true;
            this.ld_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld_name.Location = new System.Drawing.Point(1121, 152);
            this.ld_name.Name = "ld_name";
            this.ld_name.Size = new System.Drawing.Size(0, 20);
            this.ld_name.TabIndex = 8;
            // 
            // ld_description
            // 
            this.ld_description.AutoSize = true;
            this.ld_description.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld_description.Location = new System.Drawing.Point(1121, 224);
            this.ld_description.Name = "ld_description";
            this.ld_description.Size = new System.Drawing.Size(0, 20);
            this.ld_description.TabIndex = 9;
            // 
            // bd_addtocourse
            // 
            this.bd_addtocourse.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_addtocourse.Location = new System.Drawing.Point(1337, 643);
            this.bd_addtocourse.Name = "bd_addtocourse";
            this.bd_addtocourse.Size = new System.Drawing.Size(237, 38);
            this.bd_addtocourse.TabIndex = 18;
            this.bd_addtocourse.Text = "Add to Course";
            this.bd_addtocourse.UseVisualStyleBackColor = true;
            this.bd_addtocourse.Click += new System.EventHandler(this.bd_addtocourse_Click);
            // 
            // DepartmentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.bd_addtocourse);
            this.Controls.Add(this.ld_description);
            this.Controls.Add(this.ld_name);
            this.Controls.Add(this.bd_add);
            this.Controls.Add(this.bd_clear);
            this.Controls.Add(this.bd_back);
            this.Controls.Add(this.td_description);
            this.Controls.Add(this.td_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentRegister";
            this.Text = "DepartmentRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox td_name;
        private System.Windows.Forms.TextBox td_description;
        private System.Windows.Forms.Button bd_back;
        private System.Windows.Forms.Button bd_clear;
        private System.Windows.Forms.Button bd_add;
        private System.Windows.Forms.Label ld_name;
        private System.Windows.Forms.Label ld_description;
        private System.Windows.Forms.Button bd_addtocourse;
    }
}