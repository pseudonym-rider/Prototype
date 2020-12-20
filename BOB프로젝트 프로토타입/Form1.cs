using PacketClass;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace BOB프로젝트_프로토타입
{
    public partial class Server : Form
    {
        //private NetworkStream m_networkStream;
        private TcpListener m_listener;

        TcpClient client;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false;

        private Thread m_thread;

        public List<PersonalData> m_personalData;
        public List<PersonalData> m_StaffData;
        public List<PersonalData> m_ManagerData;

        public Packet OTPpacket;
        public Dictionary<int, PersonalData> OTPList;
        public Dictionary<PersonalData, Dictionary<DateTime, string>> VisitList;
        public Dictionary<PersonalData, Dictionary<DateTime, PointLatLng>> VirusList;

        public Server()
        {
            InitializeComponent();
            m_personalData = new List<PersonalData>();
            m_StaffData = new List<PersonalData>();
            m_ManagerData = new List<PersonalData>();

            OTPList = new Dictionary<int, PersonalData>();
            VisitList = new Dictionary<PersonalData, Dictionary<DateTime, string>>();
            VirusList = new Dictionary<PersonalData, Dictionary<DateTime, PointLatLng>>();

            m_personalData.Add(new PersonalData("이은표", "010-2675-3706", 25, true, "dldmsvy1010", "123123123", (int)PacketClass.Rule.개인, "",""));
            m_personalData.Add(new PersonalData("이은표", "010-2675-3706", 25, true, "dldmsvy", "123123123", (int)PacketClass.Rule.개인, "", ""));
            m_StaffData.Add(new PersonalData("박승민", "010-3688-1547", 25, true, "qkrtmdals", "123123", (int)PacketClass.Rule.직원, "abcd", ""));
            m_ManagerData.Add(new PersonalData("신명수", "010-7545-9902", 23, true, "tlsaudtn", "123", (int)PacketClass.Rule.점주, "abcd", "1010"));
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private void Run() {
            this.m_listener = new TcpListener(7777);
            this.m_listener.Start();

            if (!this.m_bClientOn)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    Message("클라이언트 접속 대기중");
                }));
            }
            while (true)
            {
                client = this.m_listener.AcceptTcpClient();
                if (client.Connected)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Message("클라이언트 접속");
                    }));
                    m_thread = new Thread(new ThreadStart(GetClient));
                    m_thread.Start();
                }
            }
        }
        private void GetClient()
        {
            NetworkStream m_networkStream = client.GetStream();

            m_bClientOn = true;

            int nRead = 0;
            while (this.m_bClientOn)
            {
                try
                {
                    nRead = 0;
                    ////nRead = this.m_networkStream.Read(readBuffer, 0, 1024 * 4);
                    nRead = m_networkStream.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_bClientOn = false;
                    //this.m_networkStream = null;
                    m_networkStream = null;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch ((int)packet.Type)
                {
                    case (int)PacketType.회원가입:
                        {
                            PersonalData registerData = (PersonalData)Packet.Desserialize(this.readBuffer);

                            if (registerData.rule == (int)Rule.개인)
                                m_personalData.Add(registerData);
                            else if (registerData.rule == (int)Rule.직원)
                                m_StaffData.Add(registerData);
                            else if (registerData.rule == (int)Rule.점주)
                                m_ManagerData.Add(registerData);

                            Message("회원가입: \r\n이름: " + registerData.name +
                                "\r\n나이: " + registerData.age +
                                "\r\n성별: " + registerData.sex +
                                "\r\n전화번호: " + registerData.phoneNumber +
                                "\r\nID: " + registerData.ID +
                                "\r\nPW: " + registerData.password);
                            break;
                        }
                    case (int)PacketType.로그인:
                        {
                            PersonalData loginData = (PersonalData)Packet.Desserialize(this.readBuffer);
                            if (loginData.rule == (int)Rule.개인)
                                FindUser(m_personalData, loginData, m_networkStream);
                            else if (loginData.rule == (int)Rule.직원)
                                FindUser(m_StaffData, loginData, m_networkStream);
                            else if (loginData.rule == (int)Rule.점주)
                                FindUser(m_ManagerData, loginData, m_networkStream);
                            break;
                        }
                    case (int)PacketType.OTP생성:
                        {
                            OTP generatedOTP = (OTP)Packet.Desserialize(this.readBuffer);
                            OTPList.Add(generatedOTP.otp, generatedOTP.personalData);
                            Message("OTP생성: \r\n생성자 성함: " + generatedOTP.personalData.name +
                                    "\r\n생성자 ID: "+ generatedOTP.personalData.ID +
                                    "\r\n생성된 OTP: " + generatedOTP.otp);
                            //Thread time_countThread = new Thread(() => TimeCount(generatedOTP.otp));
                            //time_countThread.Start();

                            try
                            {
                                nRead = 0;
                                //nRead = this.m_networkStream.Read(readBuffer, 0, 1024 * 4);
                                nRead = m_networkStream.Read(readBuffer, 0, 1024 * 4);
                            }
                            catch
                            {
                                this.m_bClientOn = false;
                                //this.m_networkStream = null;
                                m_networkStream = null;
                            }

                            OTPpacket = (Packet)Packet.Desserialize(this.readBuffer);
                            if ((int)OTPpacket.Type == (int)PacketType.OTP취소)
                            {
                                //time_countThread.Interrupt();
                                OTP canceledOTP = (OTP)Packet.Desserialize(this.readBuffer);
                                Message("OTP취소: \r\n생성자 성함: " + canceledOTP.personalData.name +
                                    "\r\n생성자 ID: " + canceledOTP.personalData.ID +
                                    "\r\n생성된 OTP: " + canceledOTP.otp);
                                OTPList.Remove(canceledOTP.otp);
                            }

                            break;
                        }
                    case (int)PacketType.OTP입력:
                        {
                            OTP InputOTP = (OTP)Packet.Desserialize(this.readBuffer);
                            foreach(int otp in OTPList.Keys)
                            {
                                if (InputOTP.otp == otp) {
                                    Message("OTP입력: \r\n입력자 업체번호: " + InputOTP.personalData.CompanyNum +
                                            "\r\n입력자 ID: " + InputOTP.personalData.ID +
                                            "\r\n입력된 OTP: " + InputOTP.otp);
                                    if (VisitList.ContainsKey(OTPList[otp])) {
                                        VisitList[OTPList[otp]].Add(DateTime.Now, InputOTP.personalData.CompanyNum);
                                    }
                                    else {
                                        Dictionary<DateTime, string> visitValue = new Dictionary<DateTime, string>();
                                        visitValue.Add(DateTime.Now, InputOTP.personalData.CompanyNum);
                                        VisitList.Add(OTPList[otp], visitValue);
                                    }

                                    Packet successPacket = new Packet();
                                    successPacket.Send = (int)PacketSendERROR.정상;
                                    Packet.Serialize(successPacket).CopyTo(this.sendBuffer, 0);

                                    //this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                                    //this.m_networkStream.Flush();
                                    m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                                    m_networkStream.Flush();

                                    for (int i = 0; i < 1024 * 4; i++)
                                        this.sendBuffer[i] = 0;
                                    break;
                                }
                            }
                            Packet failPacket = new Packet();
                            failPacket.Send = (int)PacketSendERROR.에러;

                            Packet.Serialize(failPacket).CopyTo(this.sendBuffer, 0);

                            //this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                            //this.m_networkStream.Flush();
                            m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                            m_networkStream.Flush();

                            for (int i = 0; i < 1024 * 4; i++)
                                this.sendBuffer[i] = 0;

                            break;
                        }
                    case (int)PacketType.GPS요청:
                        {

                            break;
                        }
                }
            }
        }

        private void TimeCount(int OTPnum)
        {
            DateTime startTime = DateTime.Now;
            while (true)
            {
                DateTime endTime = DateTime.Now;
                TimeSpan seconds15 = endTime - startTime;
                if(seconds15.Seconds.ToString() == "15")
                {
                    OTPList.Remove(OTPnum);
                    break;
                }
            }
        }

        private void FindUser(List<PersonalData> TotalData, PersonalData loginData, NetworkStream m_networkStream)
        {
            //int count = 0;
            //Message(count.ToString());
            foreach (PersonalData DBData in TotalData)                 //개인말고도 점주, 직원들도 데이터베이스 비교해서 로그인 성공 시키기
            {
                //count++;
                //Message(count.ToString());
                if (loginData.ID == DBData.ID && loginData.password == DBData.password)
                {
                    PersonalData loginSuccess = new PersonalData(DBData);
                    loginSuccess.password = "";
                    loginSuccess.Type = (int)PacketType.로그인;
                    loginSuccess.Send = (int)PacketSendERROR.정상;
                    Packet.Serialize(loginSuccess).CopyTo(this.sendBuffer, 0);

                    //this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                    //this.m_networkStream.Flush();
                    m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
                    m_networkStream.Flush(); ;

                    for (int i = 0; i < 1024 * 4; i++)
                        this.sendBuffer[i] = 0;

                    Message("로그인:" +
                            "\r\nID: " + loginData.ID +
                            "\r\nPW: " + loginData.password + 
                            "\r\n로그인 시각: " + DateTime.Now);
                    break;
                }
            }
            PersonalData loginFail = new PersonalData();
            loginFail.Send = (int)PacketSendERROR.에러;
            Packet.Serialize(loginFail).CopyTo(this.sendBuffer, 0);

            //this.m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            //this.m_networkStream.Flush();
            m_networkStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            m_networkStream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
                this.sendBuffer[i] = 0;
        }

        private void Message(string msg)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txtStatus.AppendText(msg + "\r\n");
                txtStatus.Focus();

                txtStatus.ScrollToCaret();
            }));

        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_listener.Stop();
            //this.m_networkStream.Close();
            this.m_thread.Abort();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            txtDBList.Text = "";
            foreach (PersonalData DBData in m_personalData)
            {
                txtDBList.Text += "개인:\r\n이름: " + DBData.name + "\t성별: " + DBData.sex + " 나이: " + DBData.age + "\t전화번호: " + DBData.phoneNumber + "\tID: " + DBData.ID + "\r\n";
            }
            foreach (PersonalData DBData in m_StaffData)
            {
                txtDBList.Text += "직원:\r\n이름: " + DBData.name + "\t성별: " + DBData.sex + " 나이: " + DBData.age + "\t전화번호: " + DBData.phoneNumber + "\tID: " + DBData.ID + "\r\n";
            }
            foreach (PersonalData DBData in m_ManagerData)
            {
                txtDBList.Text += "점주:\r\n이름: " + DBData.name + "\t성별: " + DBData.sex + " 나이: " + DBData.age + "\t전화번호: " + DBData.phoneNumber + "\tID: " + DBData.ID + "\r\n";
            }
        }

        private void btnVisitList_Click(object sender, EventArgs e)
        {
            txtDBList.Text = "";
            foreach (PersonalData personalData in VisitList.Keys) {
                txtDBList.Text += "방문자이름: " + personalData.name + "\r\n방문자 전화번호: " + personalData.phoneNumber + "\r\n";
                foreach(DateTime time in VisitList[personalData].Keys){
                    txtDBList.Text +=  "방문 시각: " + time + "\r\n방문 업체 번호: " + VisitList[personalData][time] + "\r\n";
                }
            }
        }
    }
}
