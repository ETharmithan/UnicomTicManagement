namespace UnicomTICManagementSystem.View
{
    partial class ViewMarks
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
            this.dacs_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dacs_view)).BeginInit();
            this.SuspendLayout();
            // 
            // dacs_view
            // 
            this.dacs_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dacs_view.Location = new System.Drawing.Point(77, 134);
            this.dacs_view.Name = "dacs_view";
            this.dacs_view.RowHeadersWidth = 51;
            this.dacs_view.RowTemplate.Height = 24;
            this.dacs_view.Size = new System.Drawing.Size(1466, 552);
            this.dacs_view.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Course and Subjects";
            // 
            // ViewMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.dacs_view);
            this.Controls.Add(this.label1);
            this.Name = "ViewMarks";
            this.Text = "ViewMarks";
            ((System.ComponentModel.ISupportInitialize)(this.dacs_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dacs_view;
        private System.Windows.Forms.Label label1;
    }
}