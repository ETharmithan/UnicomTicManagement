namespace UnicomTICManagementSystem.View
{
    partial class StudentRegisterForm1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bst_back = new System.Windows.Forms.Button();
            this.bst_clear = new System.Windows.Forms.Button();
            this.bst_submit = new System.Windows.Forms.Button();
            this.tst_firstname = new System.Windows.Forms.TextBox();
            this.tst_lastname = new System.Windows.Forms.TextBox();
            this.tst_nationality = new System.Windows.Forms.TextBox();
            this.tst_nic = new System.Windows.Forms.TextBox();
            this.tst_gmail = new System.Windows.Forms.TextBox();
            this.tst_mobile = new System.Windows.Forms.TextBox();
            this.tst_address = new System.Windows.Forms.TextBox();
            this.rst_male = new System.Windows.Forms.RadioButton();
            this.rst_female = new System.Windows.Forms.RadioButton();
            this.dst_dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.lst_firstname = new System.Windows.Forms.Label();
            this.lst_lastname = new System.Windows.Forms.Label();
            this.lst_dateofbirth = new System.Windows.Forms.Label();
            this.lst_gender = new System.Windows.Forms.Label();
            this.lst_nationality = new System.Windows.Forms.Label();
            this.lst_nic = new System.Windows.Forms.Label();
            this.lst_gmail = new System.Windows.Forms.Label();
            this.lst_mobile = new System.Windows.Forms.Label();
            this.lst_address = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lst_fathername = new System.Windows.Forms.Label();
            this.tst_fathername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lst_mothername = new System.Windows.Forms.Label();
            this.tst_mothername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lst_emc = new System.Windows.Forms.Label();
            this.tst_emc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lst_department = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lst_course = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cst_department = new System.Windows.Forms.ComboBox();
            this.cst_Course = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW STUDENT REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(865, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(865, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nationality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(865, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "NIC No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "G-Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(865, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 370);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Address";
            // 
            // bst_back
            // 
            this.bst_back.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bst_back.Location = new System.Drawing.Point(883, 629);
            this.bst_back.Margin = new System.Windows.Forms.Padding(4);
            this.bst_back.Name = "bst_back";
            this.bst_back.Size = new System.Drawing.Size(100, 39);
            this.bst_back.TabIndex = 10;
            this.bst_back.Text = "Back";
            this.bst_back.UseVisualStyleBackColor = true;
            this.bst_back.Click += new System.EventHandler(this.bst_back_Click);
            // 
            // bst_clear
            // 
            this.bst_clear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bst_clear.Location = new System.Drawing.Point(1078, 629);
            this.bst_clear.Margin = new System.Windows.Forms.Padding(4);
            this.bst_clear.Name = "bst_clear";
            this.bst_clear.Size = new System.Drawing.Size(100, 39);
            this.bst_clear.TabIndex = 11;
            this.bst_clear.Text = "Clear";
            this.bst_clear.UseVisualStyleBackColor = true;
            this.bst_clear.Click += new System.EventHandler(this.bst_clear_Click);
            // 
            // bst_submit
            // 
            this.bst_submit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bst_submit.Location = new System.Drawing.Point(1283, 629);
            this.bst_submit.Margin = new System.Windows.Forms.Padding(4);
            this.bst_submit.Name = "bst_submit";
            this.bst_submit.Size = new System.Drawing.Size(100, 39);
            this.bst_submit.TabIndex = 12;
            this.bst_submit.Text = "Submit";
            this.bst_submit.UseVisualStyleBackColor = true;
            this.bst_submit.Click += new System.EventHandler(this.bst_submit_Click);
            // 
            // tst_firstname
            // 
            this.tst_firstname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_firstname.Location = new System.Drawing.Point(307, 107);
            this.tst_firstname.Margin = new System.Windows.Forms.Padding(4);
            this.tst_firstname.Name = "tst_firstname";
            this.tst_firstname.Size = new System.Drawing.Size(287, 27);
            this.tst_firstname.TabIndex = 13;
            this.tst_firstname.TextChanged += new System.EventHandler(this.tst_firstname_TextChanged);
            // 
            // tst_lastname
            // 
            this.tst_lastname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_lastname.Location = new System.Drawing.Point(1037, 107);
            this.tst_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.tst_lastname.Name = "tst_lastname";
            this.tst_lastname.Size = new System.Drawing.Size(287, 27);
            this.tst_lastname.TabIndex = 14;
            this.tst_lastname.TextChanged += new System.EventHandler(this.tst_lastname_TextChanged);
            // 
            // tst_nationality
            // 
            this.tst_nationality.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_nationality.Location = new System.Drawing.Point(1037, 182);
            this.tst_nationality.Margin = new System.Windows.Forms.Padding(4);
            this.tst_nationality.Name = "tst_nationality";
            this.tst_nationality.Size = new System.Drawing.Size(287, 27);
            this.tst_nationality.TabIndex = 15;
            this.tst_nationality.TextChanged += new System.EventHandler(this.tst_nationality_TextChanged);
            // 
            // tst_nic
            // 
            this.tst_nic.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_nic.Location = new System.Drawing.Point(1037, 246);
            this.tst_nic.Margin = new System.Windows.Forms.Padding(4);
            this.tst_nic.Name = "tst_nic";
            this.tst_nic.Size = new System.Drawing.Size(287, 27);
            this.tst_nic.TabIndex = 16;
            this.tst_nic.TextChanged += new System.EventHandler(this.tst_nic_TextChanged);
            // 
            // tst_gmail
            // 
            this.tst_gmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_gmail.Location = new System.Drawing.Point(307, 302);
            this.tst_gmail.Margin = new System.Windows.Forms.Padding(4);
            this.tst_gmail.Name = "tst_gmail";
            this.tst_gmail.Size = new System.Drawing.Size(287, 27);
            this.tst_gmail.TabIndex = 17;
            this.tst_gmail.TextChanged += new System.EventHandler(this.tst_gmail_TextChanged);
            // 
            // tst_mobile
            // 
            this.tst_mobile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_mobile.Location = new System.Drawing.Point(1037, 309);
            this.tst_mobile.Margin = new System.Windows.Forms.Padding(4);
            this.tst_mobile.Name = "tst_mobile";
            this.tst_mobile.Size = new System.Drawing.Size(287, 27);
            this.tst_mobile.TabIndex = 18;
            this.tst_mobile.TextChanged += new System.EventHandler(this.tst_mobile_TextChanged);
            // 
            // tst_address
            // 
            this.tst_address.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_address.Location = new System.Drawing.Point(307, 367);
            this.tst_address.Margin = new System.Windows.Forms.Padding(4);
            this.tst_address.Name = "tst_address";
            this.tst_address.Size = new System.Drawing.Size(287, 27);
            this.tst_address.TabIndex = 19;
            this.tst_address.TextChanged += new System.EventHandler(this.tst_address_TextChanged);
            // 
            // rst_male
            // 
            this.rst_male.AutoSize = true;
            this.rst_male.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst_male.Location = new System.Drawing.Point(307, 243);
            this.rst_male.Margin = new System.Windows.Forms.Padding(4);
            this.rst_male.Name = "rst_male";
            this.rst_male.Size = new System.Drawing.Size(68, 23);
            this.rst_male.TabIndex = 20;
            this.rst_male.TabStop = true;
            this.rst_male.Text = "Male";
            this.rst_male.UseVisualStyleBackColor = true;
            // 
            // rst_female
            // 
            this.rst_female.AutoSize = true;
            this.rst_female.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst_female.Location = new System.Drawing.Point(442, 242);
            this.rst_female.Margin = new System.Windows.Forms.Padding(4);
            this.rst_female.Name = "rst_female";
            this.rst_female.Size = new System.Drawing.Size(85, 23);
            this.rst_female.TabIndex = 21;
            this.rst_female.TabStop = true;
            this.rst_female.Text = "Female";
            this.rst_female.UseVisualStyleBackColor = true;
            // 
            // dst_dateofbirth
            // 
            this.dst_dateofbirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dst_dateofbirth.Location = new System.Drawing.Point(307, 179);
            this.dst_dateofbirth.Margin = new System.Windows.Forms.Padding(4);
            this.dst_dateofbirth.MaxDate = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dst_dateofbirth.Name = "dst_dateofbirth";
            this.dst_dateofbirth.Size = new System.Drawing.Size(287, 27);
            this.dst_dateofbirth.TabIndex = 22;
            this.dst_dateofbirth.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dst_dateofbirth.ValueChanged += new System.EventHandler(this.dst_dateofbirth_ValueChanged);
            // 
            // lst_firstname
            // 
            this.lst_firstname.AutoSize = true;
            this.lst_firstname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_firstname.ForeColor = System.Drawing.Color.Red;
            this.lst_firstname.Location = new System.Drawing.Point(316, 138);
            this.lst_firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_firstname.Name = "lst_firstname";
            this.lst_firstname.Size = new System.Drawing.Size(0, 19);
            this.lst_firstname.TabIndex = 23;
            // 
            // lst_lastname
            // 
            this.lst_lastname.AutoSize = true;
            this.lst_lastname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_lastname.ForeColor = System.Drawing.Color.Red;
            this.lst_lastname.Location = new System.Drawing.Point(1046, 144);
            this.lst_lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_lastname.Name = "lst_lastname";
            this.lst_lastname.Size = new System.Drawing.Size(0, 19);
            this.lst_lastname.TabIndex = 24;
            // 
            // lst_dateofbirth
            // 
            this.lst_dateofbirth.AutoSize = true;
            this.lst_dateofbirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_dateofbirth.ForeColor = System.Drawing.Color.Red;
            this.lst_dateofbirth.Location = new System.Drawing.Point(318, 208);
            this.lst_dateofbirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_dateofbirth.Name = "lst_dateofbirth";
            this.lst_dateofbirth.Size = new System.Drawing.Size(0, 19);
            this.lst_dateofbirth.TabIndex = 25;
            // 
            // lst_gender
            // 
            this.lst_gender.AutoSize = true;
            this.lst_gender.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_gender.ForeColor = System.Drawing.Color.Red;
            this.lst_gender.Location = new System.Drawing.Point(318, 274);
            this.lst_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_gender.Name = "lst_gender";
            this.lst_gender.Size = new System.Drawing.Size(0, 19);
            this.lst_gender.TabIndex = 26;
            // 
            // lst_nationality
            // 
            this.lst_nationality.AutoSize = true;
            this.lst_nationality.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_nationality.ForeColor = System.Drawing.Color.Red;
            this.lst_nationality.Location = new System.Drawing.Point(1046, 219);
            this.lst_nationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_nationality.Name = "lst_nationality";
            this.lst_nationality.Size = new System.Drawing.Size(0, 19);
            this.lst_nationality.TabIndex = 27;
            // 
            // lst_nic
            // 
            this.lst_nic.AutoSize = true;
            this.lst_nic.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_nic.ForeColor = System.Drawing.Color.Red;
            this.lst_nic.Location = new System.Drawing.Point(1046, 282);
            this.lst_nic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_nic.Name = "lst_nic";
            this.lst_nic.Size = new System.Drawing.Size(0, 19);
            this.lst_nic.TabIndex = 28;
            // 
            // lst_gmail
            // 
            this.lst_gmail.AutoSize = true;
            this.lst_gmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_gmail.ForeColor = System.Drawing.Color.Red;
            this.lst_gmail.Location = new System.Drawing.Point(316, 339);
            this.lst_gmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_gmail.Name = "lst_gmail";
            this.lst_gmail.Size = new System.Drawing.Size(0, 19);
            this.lst_gmail.TabIndex = 29;
            // 
            // lst_mobile
            // 
            this.lst_mobile.AutoSize = true;
            this.lst_mobile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_mobile.ForeColor = System.Drawing.Color.Red;
            this.lst_mobile.Location = new System.Drawing.Point(1046, 346);
            this.lst_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_mobile.Name = "lst_mobile";
            this.lst_mobile.Size = new System.Drawing.Size(0, 19);
            this.lst_mobile.TabIndex = 30;
            // 
            // lst_address
            // 
            this.lst_address.AutoSize = true;
            this.lst_address.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_address.ForeColor = System.Drawing.Color.Red;
            this.lst_address.Location = new System.Drawing.Point(316, 407);
            this.lst_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_address.Name = "lst_address";
            this.lst_address.Size = new System.Drawing.Size(0, 19);
            this.lst_address.TabIndex = 31;
            // 
            // lst_fathername
            // 
            this.lst_fathername.AutoSize = true;
            this.lst_fathername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_fathername.ForeColor = System.Drawing.Color.Red;
            this.lst_fathername.Location = new System.Drawing.Point(316, 515);
            this.lst_fathername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_fathername.Name = "lst_fathername";
            this.lst_fathername.Size = new System.Drawing.Size(0, 19);
            this.lst_fathername.TabIndex = 34;
            // 
            // tst_fathername
            // 
            this.tst_fathername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_fathername.Location = new System.Drawing.Point(307, 479);
            this.tst_fathername.Margin = new System.Windows.Forms.Padding(4);
            this.tst_fathername.Name = "tst_fathername";
            this.tst_fathername.Size = new System.Drawing.Size(287, 27);
            this.tst_fathername.TabIndex = 33;
            this.tst_fathername.TextChanged += new System.EventHandler(this.tst_fathername_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 482);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "Father Name";
            // 
            // lst_mothername
            // 
            this.lst_mothername.AutoSize = true;
            this.lst_mothername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_mothername.ForeColor = System.Drawing.Color.Red;
            this.lst_mothername.Location = new System.Drawing.Point(316, 586);
            this.lst_mothername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_mothername.Name = "lst_mothername";
            this.lst_mothername.Size = new System.Drawing.Size(0, 19);
            this.lst_mothername.TabIndex = 37;
            // 
            // tst_mothername
            // 
            this.tst_mothername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_mothername.Location = new System.Drawing.Point(307, 548);
            this.tst_mothername.Margin = new System.Windows.Forms.Padding(4);
            this.tst_mothername.Name = "tst_mothername";
            this.tst_mothername.Size = new System.Drawing.Size(287, 27);
            this.tst_mothername.TabIndex = 36;
            this.tst_mothername.TextChanged += new System.EventHandler(this.tst_mothername_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(62, 556);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 19);
            this.label14.TabIndex = 35;
            this.label14.Text = "Mother Name";
            // 
            // lst_emc
            // 
            this.lst_emc.AutoSize = true;
            this.lst_emc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_emc.ForeColor = System.Drawing.Color.Red;
            this.lst_emc.Location = new System.Drawing.Point(316, 649);
            this.lst_emc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_emc.Name = "lst_emc";
            this.lst_emc.Size = new System.Drawing.Size(0, 19);
            this.lst_emc.TabIndex = 40;
            // 
            // tst_emc
            // 
            this.tst_emc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst_emc.Location = new System.Drawing.Point(307, 609);
            this.tst_emc.Margin = new System.Windows.Forms.Padding(4);
            this.tst_emc.Name = "tst_emc";
            this.tst_emc.Size = new System.Drawing.Size(287, 27);
            this.tst_emc.TabIndex = 39;
            this.tst_emc.TextChanged += new System.EventHandler(this.tst_emc_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(62, 614);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 19);
            this.label16.TabIndex = 38;
            this.label16.Text = "Emergency Contact Number";
            // 
            // lst_department
            // 
            this.lst_department.AutoSize = true;
            this.lst_department.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_department.ForeColor = System.Drawing.Color.Red;
            this.lst_department.Location = new System.Drawing.Point(1046, 426);
            this.lst_department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_department.Name = "lst_department";
            this.lst_department.Size = new System.Drawing.Size(0, 19);
            this.lst_department.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(865, 387);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 19);
            this.label18.TabIndex = 41;
            this.label18.Text = "Department";
            // 
            // lst_course
            // 
            this.lst_course.AutoSize = true;
            this.lst_course.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_course.ForeColor = System.Drawing.Color.Red;
            this.lst_course.Location = new System.Drawing.Point(1046, 494);
            this.lst_course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lst_course.Name = "lst_course";
            this.lst_course.Size = new System.Drawing.Size(0, 19);
            this.lst_course.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(865, 455);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 19);
            this.label20.TabIndex = 44;
            this.label20.Text = "Course";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(47, 445);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 23);
            this.label21.TabIndex = 47;
            this.label21.Text = "Parents Details";
            // 
            // cst_department
            // 
            this.cst_department.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_department.FormattingEnabled = true;
            this.cst_department.Location = new System.Drawing.Point(1037, 386);
            this.cst_department.Name = "cst_department";
            this.cst_department.Size = new System.Drawing.Size(287, 27);
            this.cst_department.TabIndex = 48;
            this.cst_department.SelectedIndexChanged += new System.EventHandler(this.cst_department_SelectedIndexChanged);
            // 
            // cst_Course
            // 
            this.cst_Course.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_Course.FormattingEnabled = true;
            this.cst_Course.Location = new System.Drawing.Point(1037, 454);
            this.cst_Course.Name = "cst_Course";
            this.cst_Course.Size = new System.Drawing.Size(287, 27);
            this.cst_Course.TabIndex = 49;
            // 
            // StudentRegisterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 719);
            this.Controls.Add(this.cst_Course);
            this.Controls.Add(this.cst_department);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lst_course);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lst_department);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lst_emc);
            this.Controls.Add(this.tst_emc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lst_mothername);
            this.Controls.Add(this.tst_mothername);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lst_fathername);
            this.Controls.Add(this.tst_fathername);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lst_address);
            this.Controls.Add(this.lst_mobile);
            this.Controls.Add(this.lst_gmail);
            this.Controls.Add(this.lst_nic);
            this.Controls.Add(this.lst_nationality);
            this.Controls.Add(this.lst_gender);
            this.Controls.Add(this.lst_dateofbirth);
            this.Controls.Add(this.lst_lastname);
            this.Controls.Add(this.lst_firstname);
            this.Controls.Add(this.dst_dateofbirth);
            this.Controls.Add(this.rst_female);
            this.Controls.Add(this.rst_male);
            this.Controls.Add(this.tst_address);
            this.Controls.Add(this.tst_mobile);
            this.Controls.Add(this.tst_gmail);
            this.Controls.Add(this.tst_nic);
            this.Controls.Add(this.tst_nationality);
            this.Controls.Add(this.tst_lastname);
            this.Controls.Add(this.tst_firstname);
            this.Controls.Add(this.bst_submit);
            this.Controls.Add(this.bst_clear);
            this.Controls.Add(this.bst_back);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentRegisterForm1";
            this.Text = "H";
            this.Load += new System.EventHandler(this.StudentRegisterForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bst_back;
        private System.Windows.Forms.Button bst_clear;
        private System.Windows.Forms.Button bst_submit;
        private System.Windows.Forms.TextBox tst_firstname;
        private System.Windows.Forms.TextBox tst_lastname;
        private System.Windows.Forms.TextBox tst_nationality;
        private System.Windows.Forms.TextBox tst_nic;
        private System.Windows.Forms.TextBox tst_gmail;
        private System.Windows.Forms.TextBox tst_mobile;
        private System.Windows.Forms.TextBox tst_address;
        private System.Windows.Forms.RadioButton rst_male;
        private System.Windows.Forms.RadioButton rst_female;
        private System.Windows.Forms.DateTimePicker dst_dateofbirth;
        private System.Windows.Forms.Label lst_firstname;
        private System.Windows.Forms.Label lst_lastname;
        private System.Windows.Forms.Label lst_dateofbirth;
        private System.Windows.Forms.Label lst_gender;
        private System.Windows.Forms.Label lst_nationality;
        private System.Windows.Forms.Label lst_nic;
        private System.Windows.Forms.Label lst_gmail;
        private System.Windows.Forms.Label lst_mobile;
        private System.Windows.Forms.Label lst_address;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lst_fathername;
        private System.Windows.Forms.TextBox tst_fathername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lst_mothername;
        private System.Windows.Forms.TextBox tst_mothername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lst_emc;
        private System.Windows.Forms.TextBox tst_emc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lst_department;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lst_course;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cst_department;
        private System.Windows.Forms.ComboBox cst_Course;
    }
}