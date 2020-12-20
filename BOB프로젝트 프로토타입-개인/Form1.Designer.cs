namespace BOB프로젝트_프로토타입_개인
{
    partial class Personal_main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.rdbtnManager = new System.Windows.Forms.RadioButton();
            this.rdbtnStaff = new System.Windows.Forms.RadioButton();
            this.rdbtnPerson = new System.Windows.Forms.RadioButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblRule = new System.Windows.Forms.Label();
            this.btnOTPGen = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCheckGPS = new System.Windows.Forms.Button();
            this.btnOTPInput = new System.Windows.Forms.Button();
            this.btnCheckVirus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.OTPGenPanel = new System.Windows.Forms.Panel();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOTPGen = new System.Windows.Forms.Label();
            this.btnOTPGen_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OTPInputPanel = new System.Windows.Forms.Panel();
            this.btnSendServer = new System.Windows.Forms.Button();
            this.txtOTPInput = new System.Windows.Forms.TextBox();
            this.btnOTPInput_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkGPSPanel = new System.Windows.Forms.Panel();
            this.btnCheckGPS_back = new System.Windows.Forms.Button();
            this.gMapGPS = new GMap.NET.WindowsForms.GMapControl();
            this.LoginPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.OTPGenPanel.SuspendLayout();
            this.OTPInputPanel.SuspendLayout();
            this.checkGPSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 190);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(23, 272);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(36, 15);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "PW:";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("굴림", 40F);
            this.lblMain.Location = new System.Drawing.Point(72, 46);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(230, 67);
            this.lblMain.TabIndex = 11;
            this.lblMain.Text = "로그인";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(61, 186);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 25);
            this.txtID.TabIndex = 12;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(61, 269);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(222, 25);
            this.txtPW.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(61, 388);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 29);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "회원가입";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(187, 388);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 29);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.lblMain);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.txtID);
            this.LoginPanel.Controls.Add(this.btnRegister);
            this.LoginPanel.Controls.Add(this.lblID);
            this.LoginPanel.Controls.Add(this.txtPW);
            this.LoginPanel.Controls.Add(this.lblPW);
            this.LoginPanel.Controls.Add(this.rdbtnManager);
            this.LoginPanel.Controls.Add(this.rdbtnStaff);
            this.LoginPanel.Controls.Add(this.rdbtnPerson);
            this.LoginPanel.Location = new System.Drawing.Point(1, 1);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(357, 560);
            this.LoginPanel.TabIndex = 16;
            // 
            // rdbtnManager
            // 
            this.rdbtnManager.AutoSize = true;
            this.rdbtnManager.Location = new System.Drawing.Point(230, 318);
            this.rdbtnManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnManager.Name = "rdbtnManager";
            this.rdbtnManager.Size = new System.Drawing.Size(58, 19);
            this.rdbtnManager.TabIndex = 20;
            this.rdbtnManager.TabStop = true;
            this.rdbtnManager.Text = "점주";
            this.rdbtnManager.UseVisualStyleBackColor = true;
            // 
            // rdbtnStaff
            // 
            this.rdbtnStaff.AutoSize = true;
            this.rdbtnStaff.Location = new System.Drawing.Point(150, 318);
            this.rdbtnStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnStaff.Name = "rdbtnStaff";
            this.rdbtnStaff.Size = new System.Drawing.Size(58, 19);
            this.rdbtnStaff.TabIndex = 19;
            this.rdbtnStaff.TabStop = true;
            this.rdbtnStaff.Text = "직원";
            this.rdbtnStaff.UseVisualStyleBackColor = true;
            // 
            // rdbtnPerson
            // 
            this.rdbtnPerson.AutoSize = true;
            this.rdbtnPerson.Location = new System.Drawing.Point(62, 318);
            this.rdbtnPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnPerson.Name = "rdbtnPerson";
            this.rdbtnPerson.Size = new System.Drawing.Size(58, 19);
            this.rdbtnPerson.TabIndex = 18;
            this.rdbtnPerson.TabStop = true;
            this.rdbtnPerson.Text = "개인";
            this.rdbtnPerson.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.lblRule);
            this.MainPanel.Controls.Add(this.btnOTPGen);
            this.MainPanel.Controls.Add(this.btnList);
            this.MainPanel.Controls.Add(this.btnCheckGPS);
            this.MainPanel.Controls.Add(this.btnOTPInput);
            this.MainPanel.Controls.Add(this.btnCheckVirus);
            this.MainPanel.Controls.Add(this.lblStatus);
            this.MainPanel.Controls.Add(this.lbl_Name);
            this.MainPanel.Location = new System.Drawing.Point(364, 1);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(384, 560);
            this.MainPanel.TabIndex = 18;
            this.MainPanel.Visible = false;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(21, 16);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(37, 15);
            this.lblRule.TabIndex = 7;
            this.lblRule.Text = "직책";
            // 
            // btnOTPGen
            // 
            this.btnOTPGen.Location = new System.Drawing.Point(43, 209);
            this.btnOTPGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOTPGen.Name = "btnOTPGen";
            this.btnOTPGen.Size = new System.Drawing.Size(121, 61);
            this.btnOTPGen.TabIndex = 6;
            this.btnOTPGen.Text = "OTP코드 생성";
            this.btnOTPGen.UseVisualStyleBackColor = true;
            this.btnOTPGen.Click += new System.EventHandler(this.btnOTPGen_Click);
            // 
            // btnList
            // 
            this.btnList.Enabled = false;
            this.btnList.Location = new System.Drawing.Point(203, 316);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(121, 61);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "점포 직원 관리";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnCheckGPS
            // 
            this.btnCheckGPS.Location = new System.Drawing.Point(203, 208);
            this.btnCheckGPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckGPS.Name = "btnCheckGPS";
            this.btnCheckGPS.Size = new System.Drawing.Size(121, 61);
            this.btnCheckGPS.TabIndex = 4;
            this.btnCheckGPS.Text = "본인 동선 확인";
            this.btnCheckGPS.UseVisualStyleBackColor = true;
            this.btnCheckGPS.Click += new System.EventHandler(this.btnCheckGPS_Click);
            // 
            // btnOTPInput
            // 
            this.btnOTPInput.Enabled = false;
            this.btnOTPInput.Location = new System.Drawing.Point(43, 316);
            this.btnOTPInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOTPInput.Name = "btnOTPInput";
            this.btnOTPInput.Size = new System.Drawing.Size(121, 61);
            this.btnOTPInput.TabIndex = 3;
            this.btnOTPInput.Text = "OTP코드 입력";
            this.btnOTPInput.UseVisualStyleBackColor = true;
            this.btnOTPInput.Click += new System.EventHandler(this.btnOTPInput_Click);
            // 
            // btnCheckVirus
            // 
            this.btnCheckVirus.Location = new System.Drawing.Point(99, 91);
            this.btnCheckVirus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckVirus.Name = "btnCheckVirus";
            this.btnCheckVirus.Size = new System.Drawing.Size(163, 61);
            this.btnCheckVirus.TabIndex = 2;
            this.btnCheckVirus.Text = "밀접접촉여부확인";
            this.btnCheckVirus.UseVisualStyleBackColor = true;
            this.btnCheckVirus.Click += new System.EventHandler(this.btnCheckVirus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("굴림", 15F);
            this.lblStatus.Location = new System.Drawing.Point(39, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(328, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "현재 밀첩접촉자가 아닙니다";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(267, 16);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(37, 15);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "이름";
            // 
            // OTPGenPanel
            // 
            this.OTPGenPanel.Controls.Add(this.lblTimeLeft);
            this.OTPGenPanel.Controls.Add(this.label3);
            this.OTPGenPanel.Controls.Add(this.lblOTPGen);
            this.OTPGenPanel.Controls.Add(this.btnOTPGen_back);
            this.OTPGenPanel.Controls.Add(this.label1);
            this.OTPGenPanel.Location = new System.Drawing.Point(754, 1);
            this.OTPGenPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OTPGenPanel.Name = "OTPGenPanel";
            this.OTPGenPanel.Size = new System.Drawing.Size(389, 560);
            this.OTPGenPanel.TabIndex = 19;
            this.OTPGenPanel.Visible = false;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("굴림", 15F);
            this.lblTimeLeft.Location = new System.Drawing.Point(42, 398);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(304, 25);
            this.lblTimeLeft.TabIndex = 12;
            this.lblTimeLeft.Text = "만료까지 15초 남았습니다";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 30F);
            this.label3.Location = new System.Drawing.Point(104, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "입니다";
            // 
            // lblOTPGen
            // 
            this.lblOTPGen.AutoSize = true;
            this.lblOTPGen.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOTPGen.Location = new System.Drawing.Point(120, 150);
            this.lblOTPGen.Name = "lblOTPGen";
            this.lblOTPGen.Size = new System.Drawing.Size(132, 47);
            this.lblOTPGen.TabIndex = 10;
            this.lblOTPGen.Text = "0000";
            // 
            // btnOTPGen_back
            // 
            this.btnOTPGen_back.Location = new System.Drawing.Point(35, 450);
            this.btnOTPGen_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOTPGen_back.Name = "btnOTPGen_back";
            this.btnOTPGen_back.Size = new System.Drawing.Size(299, 60);
            this.btnOTPGen_back.TabIndex = 9;
            this.btnOTPGen_back.Text = "메인화면으로";
            this.btnOTPGen_back.UseVisualStyleBackColor = true;
            this.btnOTPGen_back.Click += new System.EventHandler(this.btnOTPGen_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "생성된 OTP는";
            // 
            // OTPInputPanel
            // 
            this.OTPInputPanel.Controls.Add(this.btnSendServer);
            this.OTPInputPanel.Controls.Add(this.txtOTPInput);
            this.OTPInputPanel.Controls.Add(this.btnOTPInput_back);
            this.OTPInputPanel.Controls.Add(this.label6);
            this.OTPInputPanel.Location = new System.Drawing.Point(1149, 1);
            this.OTPInputPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OTPInputPanel.Name = "OTPInputPanel";
            this.OTPInputPanel.Size = new System.Drawing.Size(389, 560);
            this.OTPInputPanel.TabIndex = 20;
            this.OTPInputPanel.Visible = false;
            // 
            // btnSendServer
            // 
            this.btnSendServer.Location = new System.Drawing.Point(105, 206);
            this.btnSendServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(157, 52);
            this.btnSendServer.TabIndex = 11;
            this.btnSendServer.Text = "서버로 전송";
            this.btnSendServer.UseVisualStyleBackColor = true;
            this.btnSendServer.Click += new System.EventHandler(this.btnSendServer_Click);
            // 
            // txtOTPInput
            // 
            this.txtOTPInput.Font = new System.Drawing.Font("굴림", 20F);
            this.txtOTPInput.Location = new System.Drawing.Point(95, 138);
            this.txtOTPInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOTPInput.Name = "txtOTPInput";
            this.txtOTPInput.Size = new System.Drawing.Size(178, 46);
            this.txtOTPInput.TabIndex = 10;
            this.txtOTPInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTPInput_KeyPress);
            // 
            // btnOTPInput_back
            // 
            this.btnOTPInput_back.Location = new System.Drawing.Point(35, 450);
            this.btnOTPInput_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOTPInput_back.Name = "btnOTPInput_back";
            this.btnOTPInput_back.Size = new System.Drawing.Size(299, 60);
            this.btnOTPInput_back.TabIndex = 9;
            this.btnOTPInput_back.Text = "메인화면으로";
            this.btnOTPInput_back.UseVisualStyleBackColor = true;
            this.btnOTPInput_back.Click += new System.EventHandler(this.btnOTPInput_back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 20F);
            this.label6.Location = new System.Drawing.Point(45, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "생성된 OTP 입력";
            // 
            // checkGPSPanel
            // 
            this.checkGPSPanel.Controls.Add(this.btnCheckGPS_back);
            this.checkGPSPanel.Controls.Add(this.gMapGPS);
            this.checkGPSPanel.Location = new System.Drawing.Point(27, 581);
            this.checkGPSPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkGPSPanel.Name = "checkGPSPanel";
            this.checkGPSPanel.Size = new System.Drawing.Size(1018, 359);
            this.checkGPSPanel.TabIndex = 19;
            // 
            // btnCheckGPS_back
            // 
            this.btnCheckGPS_back.Location = new System.Drawing.Point(422, 77);
            this.btnCheckGPS_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckGPS_back.Name = "btnCheckGPS_back";
            this.btnCheckGPS_back.Size = new System.Drawing.Size(299, 60);
            this.btnCheckGPS_back.TabIndex = 21;
            this.btnCheckGPS_back.Text = "메인화면으로";
            this.btnCheckGPS_back.UseVisualStyleBackColor = true;
            this.btnCheckGPS_back.Click += new System.EventHandler(this.btnCheckGPS_back_Click);
            // 
            // gMapGPS
            // 
            this.gMapGPS.Bearing = 0F;
            this.gMapGPS.CanDragMap = true;
            this.gMapGPS.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapGPS.GrayScaleMode = false;
            this.gMapGPS.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapGPS.LevelsKeepInMemory = 5;
            this.gMapGPS.Location = new System.Drawing.Point(26, 19);
            this.gMapGPS.MarkersEnabled = true;
            this.gMapGPS.MaxZoom = 18;
            this.gMapGPS.MinZoom = 2;
            this.gMapGPS.MouseWheelZoomEnabled = true;
            this.gMapGPS.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapGPS.Name = "gMapGPS";
            this.gMapGPS.NegativeMode = false;
            this.gMapGPS.PolygonsEnabled = true;
            this.gMapGPS.RetryLoadTile = 0;
            this.gMapGPS.RoutesEnabled = true;
            this.gMapGPS.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapGPS.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapGPS.ShowTileGridLines = false;
            this.gMapGPS.Size = new System.Drawing.Size(325, 295);
            this.gMapGPS.TabIndex = 20;
            this.gMapGPS.Zoom = 16D;
            // 
            // Personal_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.OTPInputPanel);
            this.Controls.Add(this.checkGPSPanel);
            this.Controls.Add(this.OTPGenPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Personal_main";
            this.Text = "Personal_app";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Personal_main_FormClosed);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.OTPGenPanel.ResumeLayout(false);
            this.OTPGenPanel.PerformLayout();
            this.OTPInputPanel.ResumeLayout(false);
            this.OTPInputPanel.PerformLayout();
            this.checkGPSPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.RadioButton rdbtnManager;
        private System.Windows.Forms.RadioButton rdbtnStaff;
        private System.Windows.Forms.RadioButton rdbtnPerson;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Button btnOTPGen;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCheckGPS;
        private System.Windows.Forms.Button btnOTPInput;
        private System.Windows.Forms.Button btnCheckVirus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel OTPGenPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOTPGen;
        private System.Windows.Forms.Button btnOTPGen_back;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Panel OTPInputPanel;
        private System.Windows.Forms.Button btnOTPInput_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOTPInput;
        private System.Windows.Forms.Button btnSendServer;
        private System.Windows.Forms.Panel checkGPSPanel;
        private GMap.NET.WindowsForms.GMapControl gMapGPS;
        private System.Windows.Forms.Button btnCheckGPS_back;
    }
}

