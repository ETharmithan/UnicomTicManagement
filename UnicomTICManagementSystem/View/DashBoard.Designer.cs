﻿namespace UnicomTICManagementSystem.View
{
    partial class DashBoardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_updateusers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_exammark = new System.Windows.Forms.Button();
            this.b_education = new System.Windows.Forms.Button();
            this.bd_cUser = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.b_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_updateusers);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.b_exammark);
            this.panel1.Controls.Add(this.b_education);
            this.panel1.Controls.Add(this.bd_cUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 776);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // b_updateusers
            // 
            this.b_updateusers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_updateusers.Location = new System.Drawing.Point(27, 179);
            this.b_updateusers.Name = "b_updateusers";
            this.b_updateusers.Size = new System.Drawing.Size(179, 49);
            this.b_updateusers.TabIndex = 4;
            this.b_updateusers.Text = "Update Users";
            this.b_updateusers.UseVisualStyleBackColor = true;
            this.b_updateusers.Click += new System.EventHandler(this.b_updateusers_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Room ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_exammark
            // 
            this.b_exammark.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_exammark.Location = new System.Drawing.Point(27, 340);
            this.b_exammark.Name = "b_exammark";
            this.b_exammark.Size = new System.Drawing.Size(179, 49);
            this.b_exammark.TabIndex = 2;
            this.b_exammark.Text = "Exam and Mark ";
            this.b_exammark.UseVisualStyleBackColor = true;
            this.b_exammark.Click += new System.EventHandler(this.b_exammark_Click);
            // 
            // b_education
            // 
            this.b_education.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_education.Location = new System.Drawing.Point(27, 434);
            this.b_education.Name = "b_education";
            this.b_education.Size = new System.Drawing.Size(179, 49);
            this.b_education.TabIndex = 1;
            this.b_education.Text = "Create Education";
            this.b_education.UseVisualStyleBackColor = true;
            this.b_education.Click += new System.EventHandler(this.b_education_Click);
            // 
            // bd_cUser
            // 
            this.bd_cUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd_cUser.Location = new System.Drawing.Point(27, 529);
            this.bd_cUser.Name = "bd_cUser";
            this.bd_cUser.Size = new System.Drawing.Size(179, 49);
            this.bd_cUser.TabIndex = 0;
            this.bd_cUser.Text = "Create User";
            this.bd_cUser.UseVisualStyleBackColor = true;
            this.bd_cUser.Click += new System.EventHandler(this.bd_cUser_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel4);
            this.panel_Main.Controls.Add(this.hScrollBar1);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(258, 68);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1215, 708);
            this.panel_Main.TabIndex = 1;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1638, 763);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(255, 168);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.b_logout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 68);
            this.panel3.TabIndex = 1;
            // 
            // b_logout
            // 
            this.b_logout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.Location = new System.Drawing.Point(1044, 12);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(149, 44);
            this.b_logout.TabIndex = 5;
            this.b_logout.Text = "Log Out";
            this.b_logout.UseVisualStyleBackColor = true;
            this.b_logout.Click += new System.EventHandler(this.b_logout_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 776);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoardForm";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bd_cUser;
        private System.Windows.Forms.Button b_education;
        private System.Windows.Forms.Button b_exammark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_updateusers;
        private System.Windows.Forms.Button b_logout;
        private System.Windows.Forms.Label label1;
    }
}