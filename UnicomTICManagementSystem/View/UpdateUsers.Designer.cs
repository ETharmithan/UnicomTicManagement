namespace UnicomTICManagementSystem.View
{
    partial class UpdateUsers
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
            this.b_uadmin = new System.Windows.Forms.Button();
            this.b_ustaff = new System.Windows.Forms.Button();
            this.b_ulecture = new System.Windows.Forms.Button();
            this.b_ustudent = new System.Windows.Forms.Button();
            this.b_vack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_uadmin
            // 
            this.b_uadmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_uadmin.Location = new System.Drawing.Point(484, 169);
            this.b_uadmin.Name = "b_uadmin";
            this.b_uadmin.Size = new System.Drawing.Size(207, 56);
            this.b_uadmin.TabIndex = 8;
            this.b_uadmin.Text = "Update Admin";
            this.b_uadmin.UseVisualStyleBackColor = true;
            this.b_uadmin.Click += new System.EventHandler(this.b_uadmin_Click);
            // 
            // b_ustaff
            // 
            this.b_ustaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ustaff.Location = new System.Drawing.Point(484, 242);
            this.b_ustaff.Name = "b_ustaff";
            this.b_ustaff.Size = new System.Drawing.Size(207, 56);
            this.b_ustaff.TabIndex = 7;
            this.b_ustaff.Text = "Update Staff";
            this.b_ustaff.UseVisualStyleBackColor = true;
            this.b_ustaff.Click += new System.EventHandler(this.b_ustaff_Click);
            // 
            // b_ulecture
            // 
            this.b_ulecture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ulecture.Location = new System.Drawing.Point(484, 317);
            this.b_ulecture.Name = "b_ulecture";
            this.b_ulecture.Size = new System.Drawing.Size(207, 56);
            this.b_ulecture.TabIndex = 6;
            this.b_ulecture.Text = "Update Lecturer";
            this.b_ulecture.UseVisualStyleBackColor = true;
            this.b_ulecture.Click += new System.EventHandler(this.b_ulecture_Click);
            // 
            // b_ustudent
            // 
            this.b_ustudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ustudent.Location = new System.Drawing.Point(484, 394);
            this.b_ustudent.Name = "b_ustudent";
            this.b_ustudent.Size = new System.Drawing.Size(207, 56);
            this.b_ustudent.TabIndex = 5;
            this.b_ustudent.Text = "Update Student";
            this.b_ustudent.UseVisualStyleBackColor = true;
            this.b_ustudent.Click += new System.EventHandler(this.b_ustudent_Click);
            // 
            // b_vack
            // 
            this.b_vack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_vack.Location = new System.Drawing.Point(939, 564);
            this.b_vack.Name = "b_vack";
            this.b_vack.Size = new System.Drawing.Size(179, 49);
            this.b_vack.TabIndex = 9;
            this.b_vack.Text = "Back";
            this.b_vack.UseVisualStyleBackColor = true;
            this.b_vack.Click += new System.EventHandler(this.b_vack_Click);
            // 
            // UpdateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.b_vack);
            this.Controls.Add(this.b_uadmin);
            this.Controls.Add(this.b_ustaff);
            this.Controls.Add(this.b_ulecture);
            this.Controls.Add(this.b_ustudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateUsers";
            this.Text = "UpdateUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_uadmin;
        private System.Windows.Forms.Button b_ustaff;
        private System.Windows.Forms.Button b_ulecture;
        private System.Windows.Forms.Button b_ustudent;
        private System.Windows.Forms.Button b_vack;
    }
}