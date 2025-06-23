namespace UnicomTICManagementSystem.View
{
    partial class ViewStaffDetails
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
            this.bsta_back = new System.Windows.Forms.Button();
            this.bsta_addstaff = new System.Windows.Forms.Button();
            this.bsta_delete = new System.Windows.Forms.Button();
            this.bsta_update = new System.Windows.Forms.Button();
            this.bsta_search = new System.Windows.Forms.Button();
            this.tsta_search = new System.Windows.Forms.TextBox();
            this.dsta_staff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsta_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // bsta_back
            // 
            this.bsta_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsta_back.Location = new System.Drawing.Point(554, 203);
            this.bsta_back.Name = "bsta_back";
            this.bsta_back.Size = new System.Drawing.Size(110, 35);
            this.bsta_back.TabIndex = 14;
            this.bsta_back.Text = "Back";
            this.bsta_back.UseVisualStyleBackColor = true;
            this.bsta_back.Click += new System.EventHandler(this.bsta_back_Click);
            // 
            // bsta_addstaff
            // 
            this.bsta_addstaff.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsta_addstaff.Location = new System.Drawing.Point(1234, 29);
            this.bsta_addstaff.Name = "bsta_addstaff";
            this.bsta_addstaff.Size = new System.Drawing.Size(201, 39);
            this.bsta_addstaff.TabIndex = 13;
            this.bsta_addstaff.Text = "Staff Register ";
            this.bsta_addstaff.UseVisualStyleBackColor = true;
            this.bsta_addstaff.Click += new System.EventHandler(this.bsta_addstaff_Click);
            // 
            // bsta_delete
            // 
            this.bsta_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsta_delete.Location = new System.Drawing.Point(840, 203);
            this.bsta_delete.Name = "bsta_delete";
            this.bsta_delete.Size = new System.Drawing.Size(110, 35);
            this.bsta_delete.TabIndex = 12;
            this.bsta_delete.Text = "Delete";
            this.bsta_delete.UseVisualStyleBackColor = true;
            this.bsta_delete.Click += new System.EventHandler(this.bsta_delete_Click);
            // 
            // bsta_update
            // 
            this.bsta_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsta_update.Location = new System.Drawing.Point(698, 203);
            this.bsta_update.Name = "bsta_update";
            this.bsta_update.Size = new System.Drawing.Size(110, 35);
            this.bsta_update.TabIndex = 11;
            this.bsta_update.Text = "Update";
            this.bsta_update.UseVisualStyleBackColor = true;
            this.bsta_update.Click += new System.EventHandler(this.bsta_update_Click);
            // 
            // bsta_search
            // 
            this.bsta_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsta_search.Location = new System.Drawing.Point(922, 114);
            this.bsta_search.Name = "bsta_search";
            this.bsta_search.Size = new System.Drawing.Size(97, 34);
            this.bsta_search.TabIndex = 10;
            this.bsta_search.Text = "Search";
            this.bsta_search.UseVisualStyleBackColor = true;
            this.bsta_search.Click += new System.EventHandler(this.bsta_search_Click);
            // 
            // tsta_search
            // 
            this.tsta_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsta_search.Location = new System.Drawing.Point(579, 119);
            this.tsta_search.Name = "tsta_search";
            this.tsta_search.Size = new System.Drawing.Size(299, 27);
            this.tsta_search.TabIndex = 9;
            // 
            // dsta_staff
            // 
            this.dsta_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsta_staff.Location = new System.Drawing.Point(41, 297);
            this.dsta_staff.Name = "dsta_staff";
            this.dsta_staff.RowHeadersWidth = 51;
            this.dsta_staff.RowTemplate.Height = 24;
            this.dsta_staff.Size = new System.Drawing.Size(1538, 392);
            this.dsta_staff.TabIndex = 8;
            // 
            // ViewStaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.bsta_back);
            this.Controls.Add(this.bsta_addstaff);
            this.Controls.Add(this.bsta_delete);
            this.Controls.Add(this.bsta_update);
            this.Controls.Add(this.bsta_search);
            this.Controls.Add(this.tsta_search);
            this.Controls.Add(this.dsta_staff);
            this.Name = "ViewStaffDetails";
            this.Text = "ViewStaffDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dsta_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsta_back;
        private System.Windows.Forms.Button bsta_addstaff;
        private System.Windows.Forms.Button bsta_delete;
        private System.Windows.Forms.Button bsta_update;
        private System.Windows.Forms.Button bsta_search;
        private System.Windows.Forms.TextBox tsta_search;
        private System.Windows.Forms.DataGridView dsta_staff;
    }
}