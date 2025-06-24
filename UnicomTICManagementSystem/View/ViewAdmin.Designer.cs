namespace UnicomTICManagementSystem.View
{
    partial class ViewAdmin
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
            this.ba_back = new System.Windows.Forms.Button();
            this.bl_addadmin = new System.Windows.Forms.Button();
            this.ba_delete = new System.Windows.Forms.Button();
            this.ba_update = new System.Windows.Forms.Button();
            this.ba_search = new System.Windows.Forms.Button();
            this.ta_search = new System.Windows.Forms.TextBox();
            this.da_admin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.da_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 53);
            this.label1.TabIndex = 30;
            this.label1.Text = "Admin Details";
            // 
            // ba_back
            // 
            this.ba_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_back.Location = new System.Drawing.Point(400, 196);
            this.ba_back.Name = "ba_back";
            this.ba_back.Size = new System.Drawing.Size(110, 35);
            this.ba_back.TabIndex = 29;
            this.ba_back.Text = "Back";
            this.ba_back.UseVisualStyleBackColor = true;
            this.ba_back.Click += new System.EventHandler(this.ba_back_Click);
            // 
            // bl_addadmin
            // 
            this.bl_addadmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_addadmin.Location = new System.Drawing.Point(967, -2);
            this.bl_addadmin.Name = "bl_addadmin";
            this.bl_addadmin.Size = new System.Drawing.Size(201, 39);
            this.bl_addadmin.TabIndex = 28;
            this.bl_addadmin.Text = "Admin Register ";
            this.bl_addadmin.UseVisualStyleBackColor = true;
            this.bl_addadmin.Click += new System.EventHandler(this.bl_addadmin_Click);
            // 
            // ba_delete
            // 
            this.ba_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_delete.Location = new System.Drawing.Point(686, 196);
            this.ba_delete.Name = "ba_delete";
            this.ba_delete.Size = new System.Drawing.Size(110, 35);
            this.ba_delete.TabIndex = 27;
            this.ba_delete.Text = "Delete";
            this.ba_delete.UseVisualStyleBackColor = true;
            this.ba_delete.Click += new System.EventHandler(this.ba_delete_Click);
            // 
            // ba_update
            // 
            this.ba_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_update.Location = new System.Drawing.Point(544, 196);
            this.ba_update.Name = "ba_update";
            this.ba_update.Size = new System.Drawing.Size(110, 35);
            this.ba_update.TabIndex = 26;
            this.ba_update.Text = "Update";
            this.ba_update.UseVisualStyleBackColor = true;
            this.ba_update.Click += new System.EventHandler(this.ba_update_Click);
            // 
            // ba_search
            // 
            this.ba_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba_search.Location = new System.Drawing.Point(768, 107);
            this.ba_search.Name = "ba_search";
            this.ba_search.Size = new System.Drawing.Size(97, 34);
            this.ba_search.TabIndex = 25;
            this.ba_search.Text = "Search";
            this.ba_search.UseVisualStyleBackColor = true;
            this.ba_search.Click += new System.EventHandler(this.ba_search_Click);
            // 
            // ta_search
            // 
            this.ta_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_search.Location = new System.Drawing.Point(425, 112);
            this.ta_search.Name = "ta_search";
            this.ta_search.Size = new System.Drawing.Size(299, 27);
            this.ta_search.TabIndex = 24;
            // 
            // da_admin
            // 
            this.da_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.da_admin.Location = new System.Drawing.Point(29, 274);
            this.da_admin.Name = "da_admin";
            this.da_admin.RowHeadersWidth = 51;
            this.da_admin.RowTemplate.Height = 24;
            this.da_admin.Size = new System.Drawing.Size(1129, 360);
            this.da_admin.TabIndex = 23;
            // 
            // ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ba_back);
            this.Controls.Add(this.bl_addadmin);
            this.Controls.Add(this.ba_delete);
            this.Controls.Add(this.ba_update);
            this.Controls.Add(this.ba_search);
            this.Controls.Add(this.ta_search);
            this.Controls.Add(this.da_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAdmin";
            this.Text = "ViewAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.da_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ba_back;
        private System.Windows.Forms.Button bl_addadmin;
        private System.Windows.Forms.Button ba_delete;
        private System.Windows.Forms.Button ba_update;
        private System.Windows.Forms.Button ba_search;
        private System.Windows.Forms.TextBox ta_search;
        private System.Windows.Forms.DataGridView da_admin;
    }
}