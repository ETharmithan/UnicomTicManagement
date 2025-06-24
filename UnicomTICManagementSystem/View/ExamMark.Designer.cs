namespace UnicomTICManagementSystem.View
{
    partial class ExamMark
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
            this.b_examreg = new System.Windows.Forms.Button();
            this.b_examview = new System.Windows.Forms.Button();
            this.b_mark = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_examreg
            // 
            this.b_examreg.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_examreg.Location = new System.Drawing.Point(257, 130);
            this.b_examreg.Name = "b_examreg";
            this.b_examreg.Size = new System.Drawing.Size(599, 93);
            this.b_examreg.TabIndex = 0;
            this.b_examreg.Text = "Exam Register";
            this.b_examreg.UseVisualStyleBackColor = true;
            this.b_examreg.Click += new System.EventHandler(this.b_examreg_Click);
            // 
            // b_examview
            // 
            this.b_examview.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_examview.Location = new System.Drawing.Point(257, 268);
            this.b_examview.Name = "b_examview";
            this.b_examview.Size = new System.Drawing.Size(599, 93);
            this.b_examview.TabIndex = 1;
            this.b_examview.Text = "Exam Update/ Delete/View";
            this.b_examview.UseVisualStyleBackColor = true;
            this.b_examview.Click += new System.EventHandler(this.b_examview_Click);
            // 
            // b_mark
            // 
            this.b_mark.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mark.Location = new System.Drawing.Point(257, 409);
            this.b_mark.Name = "b_mark";
            this.b_mark.Size = new System.Drawing.Size(599, 93);
            this.b_mark.TabIndex = 2;
            this.b_mark.Text = "Mark Register/ Update/ Delete/View";
            this.b_mark.UseVisualStyleBackColor = true;
            this.b_mark.Click += new System.EventHandler(this.b_mark_Click);
            // 
            // b_back
            // 
            this.b_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_back.Location = new System.Drawing.Point(975, 609);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(129, 47);
            this.b_back.TabIndex = 3;
            this.b_back.Text = "Back";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // ExamMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_mark);
            this.Controls.Add(this.b_examview);
            this.Controls.Add(this.b_examreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamMark";
            this.Text = "ExamMark";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_examreg;
        private System.Windows.Forms.Button b_examview;
        private System.Windows.Forms.Button b_mark;
        private System.Windows.Forms.Button b_back;
    }
}