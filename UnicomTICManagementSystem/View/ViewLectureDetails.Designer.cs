namespace UnicomTICManagementSystem.View
{
    partial class ViewLectureDetails
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
            this.bl_back = new System.Windows.Forms.Button();
            this.bl_addregister = new System.Windows.Forms.Button();
            this.bl_delete = new System.Windows.Forms.Button();
            this.bl_update = new System.Windows.Forms.Button();
            this.bl_search = new System.Windows.Forms.Button();
            this.tl_search = new System.Windows.Forms.TextBox();
            this.dl_lecturer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dl_lecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // bl_back
            // 
            this.bl_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_back.Location = new System.Drawing.Point(554, 203);
            this.bl_back.Name = "bl_back";
            this.bl_back.Size = new System.Drawing.Size(110, 35);
            this.bl_back.TabIndex = 21;
            this.bl_back.Text = "Back";
            this.bl_back.UseVisualStyleBackColor = true;
            this.bl_back.Click += new System.EventHandler(this.bl_back_Click);
            // 
            // bl_addregister
            // 
            this.bl_addregister.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_addregister.Location = new System.Drawing.Point(1234, 29);
            this.bl_addregister.Name = "bl_addregister";
            this.bl_addregister.Size = new System.Drawing.Size(201, 39);
            this.bl_addregister.TabIndex = 20;
            this.bl_addregister.Text = "Lecturer Register ";
            this.bl_addregister.UseVisualStyleBackColor = true;
            this.bl_addregister.Click += new System.EventHandler(this.bl_addregister_Click);
            // 
            // bl_delete
            // 
            this.bl_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_delete.Location = new System.Drawing.Point(840, 203);
            this.bl_delete.Name = "bl_delete";
            this.bl_delete.Size = new System.Drawing.Size(110, 35);
            this.bl_delete.TabIndex = 19;
            this.bl_delete.Text = "Delete";
            this.bl_delete.UseVisualStyleBackColor = true;
            this.bl_delete.Click += new System.EventHandler(this.bl_delete_Click);
            // 
            // bl_update
            // 
            this.bl_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_update.Location = new System.Drawing.Point(698, 203);
            this.bl_update.Name = "bl_update";
            this.bl_update.Size = new System.Drawing.Size(110, 35);
            this.bl_update.TabIndex = 18;
            this.bl_update.Text = "Update";
            this.bl_update.UseVisualStyleBackColor = true;
            this.bl_update.Click += new System.EventHandler(this.bl_update_Click);
            // 
            // bl_search
            // 
            this.bl_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_search.Location = new System.Drawing.Point(922, 114);
            this.bl_search.Name = "bl_search";
            this.bl_search.Size = new System.Drawing.Size(97, 34);
            this.bl_search.TabIndex = 17;
            this.bl_search.Text = "Search";
            this.bl_search.UseVisualStyleBackColor = true;
            this.bl_search.Click += new System.EventHandler(this.bl_search_Click);
            // 
            // tl_search
            // 
            this.tl_search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl_search.Location = new System.Drawing.Point(579, 119);
            this.tl_search.Name = "tl_search";
            this.tl_search.Size = new System.Drawing.Size(299, 27);
            this.tl_search.TabIndex = 16;
            // 
            // dl_lecturer
            // 
            this.dl_lecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dl_lecturer.Location = new System.Drawing.Point(41, 297);
            this.dl_lecturer.Name = "dl_lecturer";
            this.dl_lecturer.RowHeadersWidth = 51;
            this.dl_lecturer.RowTemplate.Height = 24;
            this.dl_lecturer.Size = new System.Drawing.Size(1538, 392);
            this.dl_lecturer.TabIndex = 15;
            // 
            // ViewLectureDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.bl_back);
            this.Controls.Add(this.bl_addregister);
            this.Controls.Add(this.bl_delete);
            this.Controls.Add(this.bl_update);
            this.Controls.Add(this.bl_search);
            this.Controls.Add(this.tl_search);
            this.Controls.Add(this.dl_lecturer);
            this.Name = "ViewLectureDetails";
            this.Text = "ViewLectureDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dl_lecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bl_back;
        private System.Windows.Forms.Button bl_addregister;
        private System.Windows.Forms.Button bl_delete;
        private System.Windows.Forms.Button bl_update;
        private System.Windows.Forms.Button bl_search;
        private System.Windows.Forms.TextBox tl_search;
        private System.Windows.Forms.DataGridView dl_lecturer;
    }
}