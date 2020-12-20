namespace BOB프로젝트_프로토타입
{
    partial class Server
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDBList = new System.Windows.Forms.Button();
            this.btnVisitList = new System.Windows.Forms.Button();
            this.txtDBList = new System.Windows.Forms.TextBox();
            this.btnAddVirus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(14, 15);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(505, 532);
            this.txtStatus.TabIndex = 0;
            // 
            // btnDBList
            // 
            this.btnDBList.Location = new System.Drawing.Point(554, 15);
            this.btnDBList.Name = "btnDBList";
            this.btnDBList.Size = new System.Drawing.Size(323, 52);
            this.btnDBList.TabIndex = 1;
            this.btnDBList.Text = "가입된 사용자 불러오기";
            this.btnDBList.UseVisualStyleBackColor = true;
            this.btnDBList.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnVisitList
            // 
            this.btnVisitList.Location = new System.Drawing.Point(554, 85);
            this.btnVisitList.Name = "btnVisitList";
            this.btnVisitList.Size = new System.Drawing.Size(323, 57);
            this.btnVisitList.TabIndex = 2;
            this.btnVisitList.Text = "방문정보 불러오기";
            this.btnVisitList.UseVisualStyleBackColor = true;
            this.btnVisitList.Click += new System.EventHandler(this.btnVisitList_Click);
            // 
            // txtDBList
            // 
            this.txtDBList.Location = new System.Drawing.Point(554, 232);
            this.txtDBList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDBList.Multiline = true;
            this.txtDBList.Name = "txtDBList";
            this.txtDBList.Size = new System.Drawing.Size(323, 315);
            this.txtDBList.TabIndex = 3;
            // 
            // btnAddVirus
            // 
            this.btnAddVirus.Location = new System.Drawing.Point(554, 158);
            this.btnAddVirus.Name = "btnAddVirus";
            this.btnAddVirus.Size = new System.Drawing.Size(323, 57);
            this.btnAddVirus.TabIndex = 4;
            this.btnAddVirus.Text = "확진자 정보 추가";
            this.btnAddVirus.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnAddVirus);
            this.Controls.Add(this.txtDBList);
            this.Controls.Add(this.btnVisitList);
            this.Controls.Add(this.btnDBList);
            this.Controls.Add(this.txtStatus);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnDBList;
        private System.Windows.Forms.Button btnVisitList;
        private System.Windows.Forms.TextBox txtDBList;
        private System.Windows.Forms.Button btnAddVirus;
    }
}

