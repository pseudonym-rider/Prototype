using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using PacketClass;

namespace BOB프로젝트_프로토타입_개인
{
    public partial class Register_form : Form
    {
        private PersonalData registerData;
        public PersonalData PassValue
        {
            get { return this.registerData; }
            set { this.registerData = value; }
        }
        public Register_form()
        {
            InitializeComponent();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back)) {}
            else
            {
                e.Handled = true;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back)) { }
            else
            {
                e.Handled = false;
            }
        }
        private void rbManager_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            switch (rdb.Text.ToString())
            {
                case "개인":
                    {
                        lblManager.Visible = false;
                        txtCompanyManager.Visible = false;
                        lblCompany.Visible = false;
                        txtCompanyNum.Visible = false;
                        break;
                    }
                case "점포 직원":
                    {
                        lblManager.Visible = false;
                        txtCompanyManager.Visible = false;
                        lblCompany.Visible = true;
                        txtCompanyNum.Visible = true;
                        break;
                    }
                case "점주":
                    {
                        lblManager.Visible = true;
                        txtCompanyManager.Visible = true;
                        lblCompany.Visible = false;
                        txtCompanyNum.Visible = false;
                        break;
                    }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) == false &&
                String.IsNullOrEmpty(txtPhone.Text) == false &&
                String.IsNullOrEmpty(txtID.Text) == false &&
                String.IsNullOrEmpty(txtPW.Text) == false &&
                String.IsNullOrEmpty(txtRePW.Text) == false &&
                (rdbtnFemale.Checked || rdbtnMale.Checked) &&
                nudAge.Value > 10) 
            {
                if (txtPW.Text != txtRePW.Text)
                {
                    MessageBox.Show("두 비밀번호가 틀립니다. 확인해주세요.", "경고");
                    return;
                }
                else if (!cbGPS.Checked || !cbPersonal.Checked) {
                    MessageBox.Show("위치정보 수집 동의와 방역당국 제공 동의에 체크해주세요.", "경고");
                    return;
                }
                
                if (rbPerson.Checked)
                {
                    PassValue = new PersonalData(txtName.Text, txtPhone.Text, Decimal.ToInt32(nudAge.Value), rdbtnMale.Checked, txtID.Text, txtPW.Text, (int)PacketClass.Rule.개인,null,null);
                }
                else if (rbStaff.Checked)
                {
                    if (string.IsNullOrEmpty(txtCompanyNum.Text))
                    {
                        MessageBox.Show("업체번호를 입력해주세요. 직원이 아니시라면 개인으로 변경해주시기 바랍니다.", "경고");
                        return;
                    }
                    else
                    {
                        PassValue = new PersonalData(txtName.Text, txtPhone.Text, Decimal.ToInt32(nudAge.Value), rdbtnMale.Checked, txtID.Text, txtPW.Text, (int)PacketClass.Rule.직원, txtCompanyNum.Text, null);
                    }
                }
                else if (rbManager.Checked)
                {
                    if (string.IsNullOrEmpty(txtCompanyManager.Text)) {
                        MessageBox.Show("사업자 번호를 입력해주세요. 점주가 아니시라면 개인 혹은 직원으로 변경해주시기 바랍니다.", "경고");
                        return;
                    }
                    else
                    {
                        PassValue = new PersonalData(txtName.Text, txtPhone.Text, Decimal.ToInt32(nudAge.Value), rdbtnMale.Checked, txtID.Text, txtPW.Text, (int)PacketClass.Rule.점주, null, txtCompanyManager.Text);
                    }
                }
                MessageBox.Show("회원가입 완료", "완료");
                Application.OpenForms["Register_form"].Close();
            }
            else
            {
                MessageBox.Show("필요한 사항을 전부 작성해주세요", "경고");
            }
        }


    }
}
