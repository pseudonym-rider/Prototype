using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketClass;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace BOB프로젝트_프로토타입_개인
{
    public partial class Personal_main : Form
    {
        private NetworkStream m_networkStream;
        private TcpClient m_client;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bConnect = false;

        public PersonalData LoginData;

        public OTP generatedOTP;

        List<string> gpsList;

        Thread virusRoute;


        public Personal_main()
        {
            InitializeComponent();


            gpsList = new List<string>();

            this.m_client = new TcpClient();
            try
            {
                this.m_client.Connect(IPAddress.Parse("127.0.0.1"), 7777);
            }
            catch
            {
                MessageBox.Show("접속 에러");
                return;
            }
            this.m_bConnect = true;
            this.m_networkStream = this.m_client.GetStream();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_form registerForm = new Register_form();
            registerForm.ShowDialog();

            PersonalData registerData = registerForm.PassValue;
            registerData.Type = (int)PacketType.회원가입;
            Packet.Serialize(registerData).CopyTo(this.sendBuffer, 0);

            this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkStream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
                this.sendBuffer[i] = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!this.m_bConnect)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtID.Text) == true ||
                string.IsNullOrEmpty(txtPW.Text) == true ) {
                MessageBox.Show("ID나 PW를 다시 입력해주세요.");
                return;
            }

            if (rdbtnPerson.Checked || rdbtnStaff.Checked || rdbtnManager.Checked)
            {

                PersonalData loginData = new PersonalData(null, null, -1, true, txtID.Text, txtPW.Text, -1, null, null);
                loginData.Type = (int)PacketType.로그인;
                if (rdbtnPerson.Checked)
                    loginData.rule = (int)PacketClass.Rule.개인;
                else if (rdbtnStaff.Checked)
                    loginData.rule = (int)PacketClass.Rule.직원;
                else if (rdbtnManager.Checked)
                    loginData.rule = (int)PacketClass.Rule.점주;

                Packet.Serialize(loginData).CopyTo(this.sendBuffer, 0);

                this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                this.m_networkStream.Flush();

                for (int i = 0; i < 1024 * 4; i++)
                    this.sendBuffer[i] = 0;

                try
                {
                    int nRead = 0;
                    nRead = this.m_networkStream.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_networkStream = null;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch ((int)packet.Type)
                {
                    case (int)PacketType.로그인:
                        {
                            loginData = (PersonalData)Packet.Desserialize(this.readBuffer);
                            if (loginData.Send == (int)PacketSendERROR.정상)
                            {
                                LoginData = new PersonalData(loginData);
                                MessageBox.Show("로그인 하였습니다.", "성공");
                                LoginPanel.Visible = false;
                                MainPanel.Visible = true;

                                lbl_Name.Text = loginData.name + "님";
                                if (loginData.rule == (int)PacketClass.Rule.개인)
                                    lblRule.Text = "개인";
                                else if (loginData.rule == (int)PacketClass.Rule.직원)
                                {
                                    lblRule.Text = "직원";
                                    btnOTPInput.Enabled = true;
                                }
                                else if (loginData.rule == (int)PacketClass.Rule.점주)
                                {
                                    lblRule.Text = "점주";
                                    btnOTPInput.Enabled = true;
                                    btnList.Enabled = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("ID나 PW를 잘못 입력하였습니다.", "실패");
                            }
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("어느 사용자로 로그인 할 것인지 체크해주세요.", "경고");
            }
        }
 
        private void Personal_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkStream.Close();
        }

        private void btnOTPGen_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            OTPGenPanel.Visible = true;

            generatedOTP = new OTP(LoginData);
            generatedOTP.Type = (int)PacketType.OTP생성;
            lblOTPGen.Text = generatedOTP.otp.ToString();
            
            Packet.Serialize(generatedOTP).CopyTo(this.sendBuffer, 0);

            this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkStream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
                this.sendBuffer[i] = 0;
            

        }

        private void btnOTPGen_back_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            OTPGenPanel.Visible = false;

            OTP canceledOTP = new OTP(generatedOTP);
            canceledOTP.Type = (int)PacketType.OTP취소;

            Packet.Serialize(canceledOTP).CopyTo(this.sendBuffer, 0);

            this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkStream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
                this.sendBuffer[i] = 0;
        }

        private void txtOTPInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back)) { }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSendServer_Click(object sender, EventArgs e)
        {
            OTP inputOTP = new OTP(LoginData);
            inputOTP.otp = Int32.Parse(txtOTPInput.Text);
            inputOTP.Type = (int)PacketType.OTP입력;

            Packet.Serialize(inputOTP).CopyTo(this.sendBuffer, 0);

            this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkStream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
                this.sendBuffer[i] = 0;

            try
            {
                int nRead = 0;
                nRead = this.m_networkStream.Read(readBuffer, 0, 1024 * 4);
            }
            catch
            {
                this.m_networkStream = null;
            }

            Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

            switch ((int)packet.Send)
            {
                case (int)PacketSendERROR.정상: 
                    {
                        MessageBox.Show("성공적으로 전달하였습니다.");
                        break;
                    }
                case (int)PacketSendERROR.에러:
                    {
                        MessageBox.Show("없는 OTP 입니다. 다시 확인해주세요.");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("아무것도 안왔습니다.");
                        break;
                    }
            }
        }

        private void btnOTPInput_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            OTPInputPanel.Visible = true;
        }

        private void btnOTPInput_back_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            OTPInputPanel.Visible = false;
        }

        private void btnCheckGPS_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            checkGPSPanel.Visible = true;

            gMapGPS.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //gMapGPS.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            //gMapGPS.SetPositionByKeywords("Seoul, South Korea");
            gMapGPS.Position = new PointLatLng(37.599999, 126.9265333);

            //gMapGPS.ShowCenter = false;
            
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(37.599999, 126.9265333));
            points.Add(new PointLatLng(37.601020, 126.9275333));
            GMapRoute route = new GMapRoute(points, "My route");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gMapGPS.Overlays.Add(routes);

        }

        private void checkVirus()
        {
            Packet requestVirus = new Packet();
            requestVirus.Type = (int)PacketType.GPS요청;
            Packet.Serialize(requestVirus).CopyTo(this.sendBuffer, 0);
            
            this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkStream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
                this.sendBuffer[i] = 0;

            try
            {
                int nRead = 0;
                nRead = this.m_networkStream.Read(readBuffer, 0, 1024 * 4);
            }
            catch
            {
                this.m_networkStream = null;
            }

            Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

            switch ((int)packet.Type)
            {
                case (int)PacketType.GPS전송:
                    {
                        MessageBox.Show("성공적으로 전달하였습니다.");
                        break;
                    }
                case (int)PacketType.GPS요청:
                    {
                        MessageBox.Show("현재 확진자가 없습니다.나중에 다시 눌러주세요.");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("아무것도 안왔습니다.");
                        break;
                    }
            }
        }

        private void btnCheckGPS_back_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            checkGPSPanel.Visible = false;
            virusRoute.Interrupt();
        }

        private void btnCheckVirus_Click(object sender, EventArgs e)
        {

            MessageBox.Show("확진자들의 경로를 갱신완료했습니다!");
        }

    }
}
