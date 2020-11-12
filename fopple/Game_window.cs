using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;
using System.Diagnostics;   //new add
using System.Collections;
using System.Timers;
using System.Threading;


namespace fopple_window
{
    public partial class Game_window : Form
    {
        static Connector connector;
        static byte poorSig;
        public static int easy_level_num = 0;
        public static int normal_level_num = 0;
        public static int hard_level_num = 0;
        public static int Click_num = 0;

        public Game_window()
        {
            InitializeComponent();

            //그림 겹치기 움직이게 하기
            apple_background.Controls.Add(All_end); //배경과 사진 합치기
            All_end.Location = new Point(1496, 12); //사진 위치 지정하기
            apple_background.Controls.Add(Back_btn);
            Back_btn.Location = new Point(12, 12);
            apple_background.Controls.Add(Easy_btn);
            Easy_btn.Location = new Point(166, 328);
            apple_background.Controls.Add(Normal_btn);
            Normal_btn.Location = new Point(616, 328);
            apple_background.Controls.Add(Hard_btn);
            Hard_btn.Location = new Point(1056, 328);
            apple_background.Controls.Add(Connect_btn);
            Connect_btn.Location = new Point(192, 202);

           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           // this.WindowState = FormWindowState.Maximized;
        }

        static void OnDeviceConnected(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs de = (Connector.DeviceEventArgs)e;
            MessageBox.Show("Device found on: " + de.Device.PortName);

            de.Device.DataReceived += new EventHandler(OnDataReceived);
        }

        static void OnDeviceFail(object sender, EventArgs e)
        {
            MessageBox.Show("No devices found! :(");
        }

        static void OnDeviceValidating(object sender, EventArgs e)
        {
            //MessageBox.Show("Validating: ");
        }

        public static string state_attention = string.Empty;
        public static string state_meditation = string.Empty;
        public static double state_delta = 0;

        static void OnDataReceived(object sender, EventArgs e)
        {

            //Device d = (Device)sender;

            Device.DataEventArgs de = (Device.DataEventArgs)e;
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);

            /* Loops through the newly parsed data of the connected headset*/
            // The comments below indicate and can be used to print out the different data outputs. 

            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {

                if (tgParser.ParsedData[i].ContainsKey("Raw"))
                {

                    //Console.WriteLine("Raw Value:" + tgParser.ParsedData[i]["Raw"]);

                }

                if (tgParser.ParsedData[i].ContainsKey("PoorSignal"))
                {

                    //The following line prints the Time associated with the parsed data
                    //Console.WriteLine("Time:" + tgParser.ParsedData[i]["Time"]);

                    //A Poor Signal value of 0 indicates that your headset is fitting properly
                    //Console.WriteLine("Poor Signal:" + tgParser.ParsedData[i]["PoorSignal"]);

                    poorSig = (byte)tgParser.ParsedData[i]["PoorSignal"];
                }


                if (tgParser.ParsedData[i].ContainsKey("Attention"))
                {
                    //Console.WriteLine("Att Value:" + tgParser.ParsedData[i]["Attention"]);
                    //NowEEG.ParsedData[i]["Attention"] = tgParser.ParsedData[i]["Attention"];  //겁나 어렵네 이건 아닌듯
                    state_attention = tgParser.ParsedData[i]["Attention"].ToString();

                }
                
                if (tgParser.ParsedData[i].ContainsKey("Meditation"))
                {

                    //Console.WriteLine("Med Value:" + tgParser.ParsedData[i]["Meditation"]);
                    state_meditation = tgParser.ParsedData[i]["Meditation"].ToString();

                }


                if (tgParser.ParsedData[i].ContainsKey("EegPowerDelta"))
                {

                    //Console.WriteLine("Delta: " + tgParser.ParsedData[i]["EegPowerDelta"]);
                    state_delta = tgParser.ParsedData[i]["EegPowerDelta"];

                }

                if (tgParser.ParsedData[i].ContainsKey("BlinkStrength"))
                {

                    //Console.WriteLine("Eyeblink " + tgParser.ParsedData[i]["BlinkStrength"]);
                }

            }

        }
     
        private void pictureBox2_Click(object sender, EventArgs e) 
        {
            //뒤로가기 (Mainform 화면으로 이동)
            Close();
            Mainform Mf = new Mainform();
            Mf.Show();
        }

        private void Hello_state_Click(object sender, EventArgs e)  //사용자 뇌파 받는 버튼
        {
            MessageBox.Show("HelloEEG!");

            // Initialize a new Connector and add event handlers

            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
            connector.DeviceValidating += new EventHandler(OnDeviceValidating);

            // Scan for devices across COM ports
            // The COM port named will be the first COM port that is checked.
            connector.ConnectScan("COM11");      //양혜민 노트북 com9 이연우 노트북 com5 윤대호 노트북 com11

            // Blink detection needs to be manually turned on
            //connector.setBlinkDetectionEnabled(true);
            //Thread.Sleep(450000);

            //System.Console.WriteLine("Goodbye.");
            //connector.Close();
            //Environment.Exit(0);  //이 줄이랑 바로 앞줄을 주석해줘야 실행됩니두~
        }

        private void Game_window_Load(object sender, EventArgs e)
        {
            easy_level_num = 0;
            normal_level_num = 0;
            hard_level_num = 0;
        }

        private void Easy_btn_Click(object sender, EventArgs e)
        {
            easy_level_num = 30;    //easy는 30이 기준이라 easy버튼을 누르면 30이 되게 했음
            Click_num++;
            this.Hide();
            Level_1 L1 = new Level_1();
            L1.Show();
        }

        private void Normal_btn_Click(object sender, EventArgs e)
        {
            normal_level_num = 50; //normal 난이도 50
            Click_num++;
            this.Hide();
            Level_1 L1 = new Level_1();
            L1.Show();
        }

        private void Hard_btn_Click(object sender, EventArgs e)
        {
            hard_level_num = 70; //hard 난이도 70
            Click_num++;
            this.Hide();
            Level_1 L1 = new Level_1();
            L1.Show();
        }

        private void All_end_Click(object sender, EventArgs e)
        {
            //게임 전체 종료
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HelloEEG!");

            // Initialize a new Connector and add event handlers

            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
            connector.DeviceValidating += new EventHandler(OnDeviceValidating);

            // Scan for devices across COM ports
            // The COM port named will be the first COM port that is checked.
            connector.ConnectScan("COM9");      //양혜민 노트북 com9
        }
    }
}
