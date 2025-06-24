namespace UnicomTICManagementSystem.View
{
    partial class RoomRegister
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
            this.label4 = new System.Windows.Forms.Label();
            this.tr_roomnumber = new System.Windows.Forms.TextBox();
            this.tl_capacity = new System.Windows.Forms.TextBox();
            this.br_add = new System.Windows.Forms.Button();
            this.br_update = new System.Windows.Forms.Button();
            this.br_delete = new System.Windows.Forms.Button();
            this.br_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cr_roomtype = new System.Windows.Forms.ComboBox();
            this.lr_roomtype = new System.Windows.Forms.Label();
            this.lr_roomnumber = new System.Windows.Forms.Label();
            this.lr_capacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROOM REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacity";
            // 
            // tr_roomnumber
            // 
            this.tr_roomnumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tr_roomnumber.Location = new System.Drawing.Point(490, 170);
            this.tr_roomnumber.Name = "tr_roomnumber";
            this.tr_roomnumber.Size = new System.Drawing.Size(297, 27);
            this.tr_roomnumber.TabIndex = 6;
            this.tr_roomnumber.Click += new System.EventHandler(this.tr_roomnumber_Click);
            this.tr_roomnumber.TextChanged += new System.EventHandler(this.tr_roomnumber_TextChanged);
            // 
            // tl_capacity
            // 
            this.tl_capacity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl_capacity.Location = new System.Drawing.Point(490, 227);
            this.tl_capacity.Name = "tl_capacity";
            this.tl_capacity.Size = new System.Drawing.Size(297, 27);
            this.tl_capacity.TabIndex = 7;
            this.tl_capacity.Click += new System.EventHandler(this.tl_capacity_Click);
            this.tl_capacity.TextChanged += new System.EventHandler(this.tl_capacity_TextChanged);
            // 
            // br_add
            // 
            this.br_add.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_add.Location = new System.Drawing.Point(849, 89);
            this.br_add.Name = "br_add";
            this.br_add.Size = new System.Drawing.Size(118, 32);
            this.br_add.TabIndex = 10;
            this.br_add.Text = "Add";
            this.br_add.UseVisualStyleBackColor = true;
            this.br_add.Click += new System.EventHandler(this.br_add_Click);
            // 
            // br_update
            // 
            this.br_update.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_update.Location = new System.Drawing.Point(849, 145);
            this.br_update.Name = "br_update";
            this.br_update.Size = new System.Drawing.Size(118, 32);
            this.br_update.TabIndex = 11;
            this.br_update.Text = "Update";
            this.br_update.UseVisualStyleBackColor = true;
            // 
            // br_delete
            // 
            this.br_delete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_delete.Location = new System.Drawing.Point(849, 199);
            this.br_delete.Name = "br_delete";
            this.br_delete.Size = new System.Drawing.Size(118, 32);
            this.br_delete.TabIndex = 12;
            this.br_delete.Text = "Delete";
            this.br_delete.UseVisualStyleBackColor = true;
            // 
            // br_back
            // 
            this.br_back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_back.Location = new System.Drawing.Point(849, 253);
            this.br_back.Name = "br_back";
            this.br_back.Size = new System.Drawing.Size(118, 32);
            this.br_back.TabIndex = 13;
            this.br_back.Text = "Back";
            this.br_back.UseVisualStyleBackColor = true;
            this.br_back.Click += new System.EventHandler(this.br_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 361);
            this.dataGridView1.TabIndex = 14;
            // 
            // cr_roomtype
            // 
            this.cr_roomtype.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr_roomtype.FormattingEnabled = true;
            this.cr_roomtype.Items.AddRange(new object[] {
            "Hall",
            "Lab"});
            this.cr_roomtype.Location = new System.Drawing.Point(490, 110);
            this.cr_roomtype.Name = "cr_roomtype";
            this.cr_roomtype.Size = new System.Drawing.Size(297, 27);
            this.cr_roomtype.TabIndex = 15;
            this.cr_roomtype.SelectedIndexChanged += new System.EventHandler(this.cr_roomtype_SelectedIndexChanged);
            // 
            // lr_roomtype
            // 
            this.lr_roomtype.AutoSize = true;
            this.lr_roomtype.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr_roomtype.ForeColor = System.Drawing.Color.Red;
            this.lr_roomtype.Location = new System.Drawing.Point(504, 144);
            this.lr_roomtype.Name = "lr_roomtype";
            this.lr_roomtype.Size = new System.Drawing.Size(0, 19);
            this.lr_roomtype.TabIndex = 16;
            // 
            // lr_roomnumber
            // 
            this.lr_roomnumber.AutoSize = true;
            this.lr_roomnumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr_roomnumber.ForeColor = System.Drawing.Color.Red;
            this.lr_roomnumber.Location = new System.Drawing.Point(504, 200);
            this.lr_roomnumber.Name = "lr_roomnumber";
            this.lr_roomnumber.Size = new System.Drawing.Size(0, 19);
            this.lr_roomnumber.TabIndex = 17;
            // 
            // lr_capacity
            // 
            this.lr_capacity.AutoSize = true;
            this.lr_capacity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr_capacity.ForeColor = System.Drawing.Color.Red;
            this.lr_capacity.Location = new System.Drawing.Point(504, 257);
            this.lr_capacity.Name = "lr_capacity";
            this.lr_capacity.Size = new System.Drawing.Size(0, 19);
            this.lr_capacity.TabIndex = 18;
            // 
            // RoomRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.lr_capacity);
            this.Controls.Add(this.lr_roomnumber);
            this.Controls.Add(this.lr_roomtype);
            this.Controls.Add(this.cr_roomtype);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.br_back);
            this.Controls.Add(this.br_delete);
            this.Controls.Add(this.br_update);
            this.Controls.Add(this.br_add);
            this.Controls.Add(this.tl_capacity);
            this.Controls.Add(this.tr_roomnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomRegister";
            this.Text = "RoomRegister";
            this.Load += new System.EventHandler(this.RoomRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tr_roomnumber;
        private System.Windows.Forms.TextBox tl_capacity;
        private System.Windows.Forms.Button br_add;
        private System.Windows.Forms.Button br_update;
        private System.Windows.Forms.Button br_delete;
        private System.Windows.Forms.Button br_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cr_roomtype;
        private System.Windows.Forms.Label lr_roomtype;
        private System.Windows.Forms.Label lr_roomnumber;
        private System.Windows.Forms.Label lr_capacity;
    }
}