namespace BOB프로젝트_프로토타입_개인
{
    partial class Register_form
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbPersonal = new System.Windows.Forms.CheckBox();
            this.cbGPS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtRePW = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtCompanyNum = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.gpbSex = new System.Windows.Forms.GroupBox();
            this.gpbRole = new System.Windows.Forms.GroupBox();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbPerson = new System.Windows.Forms.RadioButton();
            this.txtCompanyManager = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.gpbSex.SuspendLayout();
            this.gpbRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID";
            // 
            // cbPersonal
            // 
            this.cbPersonal.AutoSize = true;
            this.cbPersonal.Location = new System.Drawing.Point(31, 702);
            this.cbPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(229, 19);
            this.cbPersonal.TabIndex = 14;
            this.cbPersonal.Text = "개인 정보 방역당국 제공 동의";
            this.cbPersonal.UseVisualStyleBackColor = true;
            // 
            // cbGPS
            // 
            this.cbGPS.AutoSize = true;
            this.cbGPS.Location = new System.Drawing.Point(31, 655);
            this.cbGPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGPS.Name = "cbGPS";
            this.cbGPS.Size = new System.Drawing.Size(199, 19);
            this.cbGPS.TabIndex = 13;
            this.cbGPS.Text = "개인 위치 정보 수집 동의";
            this.cbGPS.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "성별";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 40F);
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 67);
            this.label3.TabIndex = 10;
            this.label3.Text = "회원가입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 135);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 25);
            this.txtName.TabIndex = 16;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(110, 196);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 25);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 349);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(183, 25);
            this.txtID.TabIndex = 20;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(110, 395);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(183, 25);
            this.txtPW.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "PW";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(31, 754);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(263, 68);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "가입완료";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtRePW
            // 
            this.txtRePW.Location = new System.Drawing.Point(110, 442);
            this.txtRePW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRePW.Name = "txtRePW";
            this.txtRePW.PasswordChar = '*';
            this.txtRePW.Size = new System.Drawing.Size(183, 25);
            this.txtRePW.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "PW재입력";
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(14, 14);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(43, 19);
            this.rdbtnMale.TabIndex = 26;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "남";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(109, 16);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(43, 19);
            this.rdbtnFemale.TabIndex = 27;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "여";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtCompanyNum
            // 
            this.txtCompanyNum.Location = new System.Drawing.Point(141, 604);
            this.txtCompanyNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyNum.Name = "txtCompanyNum";
            this.txtCompanyNum.Size = new System.Drawing.Size(153, 25);
            this.txtCompanyNum.TabIndex = 29;
            this.txtCompanyNum.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(29, 609);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(67, 15);
            this.lblCompany.TabIndex = 28;
            this.lblCompany.Text = "업체번호";
            this.lblCompany.Visible = false;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(110, 255);
            this.nudAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(184, 25);
            this.nudAge.TabIndex = 30;
            // 
            // gpbSex
            // 
            this.gpbSex.Controls.Add(this.rdbtnMale);
            this.gpbSex.Controls.Add(this.rdbtnFemale);
            this.gpbSex.Location = new System.Drawing.Point(110, 294);
            this.gpbSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbSex.Name = "gpbSex";
            this.gpbSex.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbSex.Size = new System.Drawing.Size(198, 34);
            this.gpbSex.TabIndex = 31;
            this.gpbSex.TabStop = false;
            // 
            // gpbRole
            // 
            this.gpbRole.Controls.Add(this.rbManager);
            this.gpbRole.Controls.Add(this.rbStaff);
            this.gpbRole.Controls.Add(this.rbPerson);
            this.gpbRole.Location = new System.Drawing.Point(31, 509);
            this.gpbRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbRole.Name = "gpbRole";
            this.gpbRole.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbRole.Size = new System.Drawing.Size(263, 49);
            this.gpbRole.TabIndex = 0;
            this.gpbRole.TabStop = false;
            this.gpbRole.Text = "사용자 구분";
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(202, 21);
            this.rbManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(58, 19);
            this.rbManager.TabIndex = 2;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "점주";
            this.rbManager.UseVisualStyleBackColor = true;
            this.rbManager.CheckedChanged += new System.EventHandler(this.rbManager_CheckedChanged);
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(79, 21);
            this.rbStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(93, 19);
            this.rbStaff.TabIndex = 1;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "점포 직원";
            this.rbStaff.UseVisualStyleBackColor = true;
            this.rbStaff.CheckedChanged += new System.EventHandler(this.rbManager_CheckedChanged);
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Location = new System.Drawing.Point(3, 21);
            this.rbPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(58, 19);
            this.rbPerson.TabIndex = 0;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "개인";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbManager_CheckedChanged);
            // 
            // txtCompanyManager
            // 
            this.txtCompanyManager.Location = new System.Drawing.Point(141, 570);
            this.txtCompanyManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyManager.Name = "txtCompanyManager";
            this.txtCompanyManager.Size = new System.Drawing.Size(153, 25);
            this.txtCompanyManager.TabIndex = 33;
            this.txtCompanyManager.Visible = false;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(29, 574);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(112, 15);
            this.lblManager.TabIndex = 32;
            this.lblManager.Text = "사업자등록번호";
            this.lblManager.Visible = false;
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 860);
            this.Controls.Add(this.txtCompanyManager);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.gpbRole);
            this.Controls.Add(this.gpbSex);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtCompanyNum);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtRePW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPersonal);
            this.Controls.Add(this.cbGPS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register_form";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.gpbSex.ResumeLayout(false);
            this.gpbSex.PerformLayout();
            this.gpbRole.ResumeLayout(false);
            this.gpbRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbPersonal;
        private System.Windows.Forms.CheckBox cbGPS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.TextBox txtCompanyNum;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtRePW;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.GroupBox gpbSex;
        private System.Windows.Forms.GroupBox gpbRole;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbPerson;
        private System.Windows.Forms.TextBox txtCompanyManager;
        private System.Windows.Forms.Label lblManager;
    }
}