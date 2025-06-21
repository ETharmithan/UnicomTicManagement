namespace UnicomTICManagementSystem.View
{
    partial class UserSigninForm
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
            this.tlo_username = new System.Windows.Forms.TextBox();
            this.tlo_password = new System.Windows.Forms.TextBox();
            this.blo_login = new System.Windows.Forms.Button();
            this.blo_back = new System.Windows.Forms.Button();
            this.blo_forgot = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // tlo_username
            // 
            this.tlo_username.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlo_username.Location = new System.Drawing.Point(665, 153);
            this.tlo_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlo_username.Name = "tlo_username";
            this.tlo_username.Size = new System.Drawing.Size(355, 28);
            this.tlo_username.TabIndex = 3;
            // 
            // tlo_password
            // 
            this.tlo_password.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlo_password.Location = new System.Drawing.Point(665, 207);
            this.tlo_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlo_password.Name = "tlo_password";
            this.tlo_password.Size = new System.Drawing.Size(355, 28);
            this.tlo_password.TabIndex = 4;
            // 
            // blo_login
            // 
            this.blo_login.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blo_login.Location = new System.Drawing.Point(921, 346);
            this.blo_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blo_login.Name = "blo_login";
            this.blo_login.Size = new System.Drawing.Size(100, 36);
            this.blo_login.TabIndex = 5;
            this.blo_login.Text = "Login";
            this.blo_login.UseVisualStyleBackColor = true;
            // 
            // blo_back
            // 
            this.blo_back.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blo_back.Location = new System.Drawing.Point(647, 346);
            this.blo_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blo_back.Name = "blo_back";
            this.blo_back.Size = new System.Drawing.Size(100, 36);
            this.blo_back.TabIndex = 6;
            this.blo_back.Text = "Back";
            this.blo_back.UseVisualStyleBackColor = true;
            // 
            // blo_forgot
            // 
            this.blo_forgot.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blo_forgot.Location = new System.Drawing.Point(839, 256);
            this.blo_forgot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blo_forgot.Name = "blo_forgot";
            this.blo_forgot.Size = new System.Drawing.Size(183, 36);
            this.blo_forgot.TabIndex = 8;
            this.blo_forgot.Text = "Forgot My Password";
            this.blo_forgot.UseVisualStyleBackColor = true;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // UserSigninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.blo_forgot);
            this.Controls.Add(this.blo_back);
            this.Controls.Add(this.blo_login);
            this.Controls.Add(this.tlo_password);
            this.Controls.Add(this.tlo_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserSigninForm";
            this.Text = "UserSignupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tlo_username;
        private System.Windows.Forms.TextBox tlo_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button blo_login;
        private System.Windows.Forms.Button blo_back;
        private System.Windows.Forms.Button blo_forgot;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
    }
}