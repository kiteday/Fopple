using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;

using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;
using System.Diagnostics;   //new add
using System.Collections;

using System.Timers;


namespace fopple_window
{
    public partial class Level_1 : Form
    {
        //// Slider 변경 타이머
        //private System.Timers.Timer timer1;
        //private static System.Windows.Forms.Timer timerEEG;
        //private static System.Timers.Timer aTimer;
        // public static string bring_state = string.Empty;
        //System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer() { Interval = 1000 };
        public static int graph_w;
        public static int graph_h = 24;
        public static int appleBox_player_width; //플레이어 게이지바 가로길이
        public static int appleBox_player_height = 25; // 플레이어 게이지바 세로길이
        public static int appleBox_NPC_width;
        public static int appleBox_NPC_height = 25;
        public static int excite_symbol_width;
        public static int complete_data;
        public static int NPC_Level;
        public static int User_Level;
        public static double[] Delta_arr = new double[50];   //플레이어의 델타파를 저장해둘 배열
        public static int Delta_arr_index = 0;    // 델타파를 저장할 배열의 인덱스 
        public static int Delta_data_length;      // 델타파를 저장할 배열의 사용할 길이, 난이도 별로 30, 40, 50 까지 사용
        public static double Delta_avg = 1.0;
        public static int Lose_player_width = 0;

        private int _ticks;         //0.1초 player타이머
        private int NPC_ticks;      //npc 타이머
        private int Delta_ticks;    //Delta파를 받아올 주기
        private int player = 0;     //난이도 플레이어 사과 측정을 위한 변수
        
        //private int player_m = 0;   //난이도 중 플레이어 사과 측정을 위한 변수
        //private int player_h = 0;   //난이도 상 플레이어 사과 측정을 위한 변수     //이 변수들 말고 다른 것을 이용해서 필요 없어짐

        public static int first_time = 0;

        //private static int easy = 0, normal = 0, hard = 0;      //게임오버 or 게임 윈에서 다시 하기를 위한 변수

        public Level_1()
        {
            InitializeComponent();

            //이미지겹치기
            //background.controls.add(apple_box_npc_bck);
            //apple_box_npc_bck.location = new point(928, 786);
            //background.controls.add(applebox_player_bck);
            //applebox_player_bck.location = new point(261, 786);
            //background.controls.add(picturebox3);
            //picturebox3.location = new point(261, 738);
            //picturebox3.controls.add(attention_symbol);
            //attention_symbol.location = new point(237, 732);
            //applebox_player_bck.controls.add(apple_symbol_player);
            //apple_symbol_player.location = new point(233, 782);
            //applebox_npc.controls.add(apple_symbol_npc);
            //apple_symbol_npc.location = new point(904, 782);

            //background.controls.add(attention_symbol);
            //attention_symbol.location = new point(237, 732);
            //background.controls.add(apple_symbol_player);
            //apple_symbol_player.location = new point(233, 782);
            //background.controls.add(apple_symbol_npc);
            //apple_symbol_npc.location = new point(904, 782);


            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            timer1.Enabled = true;
            timer1.Start();
            NPC_Timer.Enabled = true;
            NPC_Timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;

            if (_ticks > 1) { 
                graph_w = 5*Int32.Parse(Game_window.state_attention);
                pictureBox2.Size = new System.Drawing.Size(graph_w, graph_h);   // picture box2는 집중도
                Brainbox.Text = Game_window.state_attention.ToString();

                //exciteBox.Text = (100 - Int32.Parse(Game_window.state_meditation)).ToString(); // 임시 흥분수치 확인
                tree_Girl.Size = new System.Drawing.Size(0,0);
                state_tree_girl.Size = new System.Drawing.Size(0, 0);
                excite_symbol_width = Int32.Parse(Game_window.state_meditation);

                if (Int32.Parse(Game_window.state_attention) >= 30 && (Game_window.easy_level_num ==30))  //Level_1일 때 기준을 30으로 하고 기준을 만족할 때 실행
                {
                    //집중도는 0 ~ 100까지 범위로 구현함.
                    User_Level = 10;
                    if (first_time == 0)
                    {
                        appleBox_player_width += 50; //처음 임계점을 넘었을 때는 즉시 사과 얻은걸 표시
                        first_time++;
                    }

                    player++;
                    tree_Girl.Size = new System.Drawing.Size(1280, 720);    //움직이는 모습이 집중이 30이상이면 나타남
                    //사과 게이지 올라가는거 구현
                    if (player% User_Level == 0)
                    {
                        player = 0;
                        appleBox_player_width += 50;

                    }

                    appleBox_player.Size = new System.Drawing.Size(appleBox_player_width, appleBox_player_height);
                    Lose_player_width = appleBox_player_width / 5;

                    //이겼을 때 화면
                    if (appleBox_player_width >= 500)  // player의 게이지바가 전부 차면 
                    {
                        this.Hide();
                        complete_data = appleBox_NPC_width / 50;
                        appleBox_player_width = 0;
                        appleBox_NPC_width = 0;
                        first_time = 0;
                        Game_win EZ = new Game_win();
                        EZ.Show();
                        this.Close();
                    }
                }

                else if (Int32.Parse(Game_window.state_attention) >= 50 && (Game_window.normal_level_num==50))     // medium 단계
                {
                    User_Level = 20;
                    if (first_time == 0)
                    {
                        appleBox_player_width += 50; //처음 임계점을 넘었을 때는 즉시 사과 얻은걸 표시
                        first_time++;
                    }

                    player++;
                    tree_Girl.Size = new System.Drawing.Size(1280, 720);    //움직이는 모습이 집중이 50이상이면 나타남
                    //사과 게이지 올라가는거 구현
                    if (player % User_Level == 0)
                    {
                        player = 0;
                        appleBox_player_width += 50;
                    }

                    appleBox_player.Size = new System.Drawing.Size(appleBox_player_width, appleBox_player_height);
                    Lose_player_width = appleBox_player_width / 5;

                    // !여기에 이겼을 때 화면 구축
                    if (appleBox_player_width >= 500)  // player의 게이지바가 전부 차면 
                    {
                        this.Hide();
                        complete_data = appleBox_NPC_width /50;
                        appleBox_player_width = 0;
                        appleBox_NPC_width = 0;
                        first_time = 0;
                        Game_win EZ = new Game_win();
                        EZ.Show();
                        this.Close();
                    }
                }

                else if (Int32.Parse(Game_window.state_attention) >= 70 && (Game_window.hard_level_num==70))     // hard 단계
                {
                    User_Level = 30;
                    if (first_time == 0)
                    {
                        appleBox_player_width += 50; //처음 임계점을 넘었을 때는 즉시 사과 얻은걸 표시
                        first_time++;
                    }

                    player++;
                    tree_Girl.Size = new System.Drawing.Size(1280, 720);    //움직이는 모습이 집중이 70이상이면 나타남
                    //사과 게이지 올라가는거 구현
                    if (player % User_Level == 0)
                    {
                        player = 0;
                        //Delta_data_length = 50;                         // 델타파가 유저가 집중력 수치를 넘길때만 측정함으로 변경함
                        //if (Game_window.state_delta == 0)
                        //{
                        //    Game_window.state_delta++;
                        //}
                        //Delta_arr[Delta_arr_index] = Game_window.state_delta; // 델타파 값을 배열에 저장
                        //Delta_arr_index++;

                        //if (Delta_arr_index >= Delta_data_length)   // 델타 배열의 인덱스가 게임 완료 시간 보다 길면 
                        //{
                        //    Delta_arr_index = 0;
                        //} 
                        appleBox_player_width += 50;

                    }

                    appleBox_player.Size = new System.Drawing.Size(appleBox_player_width, appleBox_player_height);
                    Lose_player_width = appleBox_player_width / 5;

                    // !여기에 이겼을 때 화면 구축
                    if (appleBox_player_width >= 500)  // player의 게이지바가 전부 차면 
                    {
                        this.Hide();
                        complete_data = appleBox_NPC_width / 50;
                        appleBox_player_width = 0;
                        appleBox_NPC_width = 0;
                        first_time = 0;
                        Game_win EZ = new Game_win();
                        EZ.Show();
                        this.Close();
                    }
                }

                else
                {
                    state_tree_girl.Size = new System.Drawing.Size(1280, 720); // 집중도가 낮을 때 움직이지 않는 기본 화면
                }

                if (Delta_ticks % 10 == 0)
                {
                    if (Game_window.easy_level_num == 30)
                    {
                        Delta_data_length = 30;
                    }
                    else if (Game_window.normal_level_num == 50)
                    {
                        Delta_data_length = 40;
                    }
                    else if (Game_window.hard_level_num == 70)
                    {
                        Delta_data_length = 50;
                    }

                    Delta_arr[Delta_arr_index] = Game_window.state_delta; // 델타파 값을 배열에 저장
                    Delta_arr_index++;

                    if (Delta_arr_index >= Delta_data_length)
                    {
                        Delta_arr_index = 0;
                    }
                }
                //if (Int32.Parse(Game_window.state_attention) > 40)
                //{
                //    show_tree.Image = tree_Girl.Image;
                //}
                //else
                //{
                //    show_tree.Image = state_tree_girl.Image;
                //}
            }
        }
        // 시행착오 코드들 시작
        
        //public void TicTok()
        //{
        //    timerEEG = new System.Windows.Forms.Timer() { Interval = 1000 }; //타이머 간격 1초
        //    timerEEG.Tick += new EventHandler(CheckFocus_Tick);
        //    timerEEG.Enabled = true;

        //    timerEEG2 = new System.Windows.Forms.Timer() { Interval = 1000 }; //타이머 간격 5초
        //    timerEEG2.Tick += new EventHandler(OnDataReceived);
        //    timerEEG2.Enabled = true;
        //}

        //public void CheckFocus_Tick(object sender, System.EventArgs e)
        //{
        //    if (EEGavg < 10)//EEGavg < personalization.EEGlimit)
        //    {
        //        //MediaPause();   //게임 중지로 수정해야 함

        //        swUnFocus.Start(); //비집중StopWatch 0에서부터 시간 측정 시작
        //        swFocus.Stop(); //집중StopWatch 측정 중지
        //    }
        //    else
        //    {
        //        //MediaPlay();    //게임 시작으로 수정해야 함

        //        swFocus.Start(); //집중StopWatch 0에서부터 시간 측정 시작
        //        swUnFocus.Stop(); //비집중StopWatch 측정 중지
        //    }

        //    focustime = swFocus.ElapsedMilliseconds / 1000;
        //    unfocustime = swUnFocus.ElapsedMilliseconds / 1000;

        //    if (swUnFocus.IsRunning)
        //    {
        //        //Console.WriteLine("\n뇌파 낮음 미디어 멈춤\n비집중스탑워치 {0}s", swUnFocus.ElapsedMilliseconds / 1000);
        //        EEGavgPrt = Math.Round(EEGavg, 2);
        //        Brainbox.Text = "뇌파 낮음 " + EEGavgPrt + " 미디어 멈춤";
        //    }
        //    if (swFocus.IsRunning)
        //    {
        //        //Console.WriteLine("\n뇌파 높음 미디어 재생\n집중스탑워치 {0}s", swFocus.ElapsedMilliseconds / 1000);
        //        EEGavgPrt = Math.Round(EEGavg, 2);
        //        Brainbox.Text = "뇌파 높음 " + EEGavgPrt + " 미디어 재생";
        //    }

        //}

        //public void timerEEG_Tick(object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        DateTime pre1sec = new DateTime();
        //        pre1sec = DateTime.Now.AddSeconds(-3);
        //        string source = pre1sec.ToString("yyyy-MM-dd-HH-mm-ss");
        //        string path = @"C:\Users\Ex1\Desktop\result\" + source + ".txt";
        //        FileInfo fi = new FileInfo(path);
        //        EEGavg = double.Parse(System.IO.File.ReadAllText(path));
        //        Console.WriteLine("\n\t기준뇌파 {0}s\n\t평균측정뇌파 {1}s", 0.5, EEGavg);  //원래는  personalization.EEGlimit
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}

        //public void TicTok()
        //{
        //    timerEEG = new System.Windows.Forms.Timer() { Interval = 1000 }; //타이머 간격 1초
        //    timerEEG.Tick += new EventHandler();B
        //    timerEEG.Enabled = true;

        //    timerEEG2 = new System.Windows.Forms.Timer() { Interval = 1000 }; //타이머 간격 5초
        //    timerEEG2.Tick += new EventHandler(timerEEG_Tick);
        //    timerEEG2.Enabled = true;
        //}

        //public static string state_att = string.Empty;

        private void Brainbox_TextChanged(object sender, EventArgs e)
        {
            //while (bring_state != Game_window.state_attention)
            //{
            //    Brainbox.Text = bring_state;
            //    bring_state = Game_window.state_attention;
            //}
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)

        {
            ////aTimer.Elapsed += OnTimedEvent;
            //aTimer.Enabled = true;
            //aTimer.Interval = 1000;
            //aTimer.Start();


        }   //문제 가득한 곳,,,
        
        /* public static void Main(string[] args)
         {
             Console.WriteLine("HelloEEG!");

             // Initialize a new Connector and add event handlers

             connector = new Connector();
             connector.DeviceConnected += new EventHandler(OnDeviceConnected);
             connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
             connector.DeviceValidating += new EventHandler(OnDeviceValidating);

             // Scan for devices across COM ports
             // The COM port named will be the first COM port that is checked.
             connector.ConnectScan("COM8");

             // Blink detection needs to be manually turned on
             connector.setBlinkDetectionEnabled(true);
             Thread.Sleep(450000);




             System.Console.WriteLine("Goodbye.");
             connector.Close();
             Environment.Exit(0);
         } */

        //static void OnDeviceConnected(object sender, EventArgs e)
        //{

        //    Connector.DeviceEventArgs de = (Connector.DeviceEventArgs)e;

        //    MessageBox.Show("Device found on: " + de.Device.PortName);
        //    de.Device.DataReceived += new EventHandler(OnDataReceived);

        //}

        //static void OnDeviceFail(object sender, EventArgs e)
        //{

        //    MessageBox.Show("No devices found! :(");

        //}

        //static void OnDeviceValidating(object sender, EventArgs e)
        //{

        //    MessageBox.Show("Validating: ");

        //}

        //static void OnDataReceived(object sender, EventArgs e)     //static을 빼버리니까 안되네
        //{

        //    //Device d = (Device)sender;

        //    Device.DataEventArgs de = (Device.DataEventArgs)e;
        //    DataRow[] tempDataRowArray = de.DataRowArray;

        //    TGParser tgParser = new TGParser();
        //    tgParser.Read(de.DataRowArray);


        //    TGParser NowEEG = new TGParser();   //현재 나오는 사용자 뇌파 (내가추가한거긴한데..
        //    //이게 지역변수로 잡혀서 밖으로도 못나가고 static변수라 밖에 거가 못들어오는 문제가 있음...

        //    /* Loops through the newly parsed data of the connected headset*/
        //    // The comments below indicate and can be used to print out the different data outputs. 

        //    for (int i = 0; i < tgParser.ParsedData.Length; i++)
        //    {

        //        if (tgParser.ParsedData[i].ContainsKey("Raw"))
        //        {

        //            //Console.WriteLine("Raw Value:" + tgParser.ParsedData[i]["Raw"]);

        //        }

        //        if (tgParser.ParsedData[i].ContainsKey("PoorSignal"))
        //        {

        //            //The following line prints the Time associated with the parsed data
        //            //Console.WriteLine("Time:" + tgParser.ParsedData[i]["Time"]);

        //            //A Poor Signal value of 0 indicates that your headset is fitting properly
        //            //Console.WriteLine("Poor Signal:" + tgParser.ParsedData[i]["PoorSignal"]);

        //            poorSig = (byte)tgParser.ParsedData[i]["PoorSignal"];
        //        }


        //        if (tgParser.ParsedData[i].ContainsKey("Attention"))
        //        {

        //            //Console.WriteLine("Att Value:" + tgParser.ParsedData[i]["Attention"]);
        //            //NowEEG.ParsedData[i]["Attention"] = tgParser.ParsedData[i]["Attention"];  //겁나 어렵네 이건 아닌듯

        //        }


        //        if (tgParser.ParsedData[i].ContainsKey("Meditation"))
        //        {

        //            //Console.WriteLine("Med Value:" + tgParser.ParsedData[i]["Meditation"]);

        //        }


        //        if (tgParser.ParsedData[i].ContainsKey("EegPowerDelta"))
        //        {

        //            //Console.WriteLine("Delta: " + tgParser.ParsedData[i]["EegPowerDelta"]);

        //        }

        //        if (tgParser.ParsedData[i].ContainsKey("BlinkStrength"))
        //        {

        //            //Console.WriteLine("Eyeblink " + tgParser.ParsedData[i]["BlinkStrength"]);

        //        }


        //    }

        //}


        //시행착오 코드 끝

        private void Exit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("정말 종료하시겠습니까?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    appleBox_player_width = 0;
            //    appleBox_NPC_width = 0;
            //    first_time = 0;
            //    Close();
            //    Game_window Gwdw = new Game_window();
            //    Gwdw.Show();
            //}
            StopGame Stop = new StopGame(this);
            Stop.Show();
        }
        

        private void Level_1_Load(object sender, EventArgs e)
        {
            
        }
        //StringBuilder sb = new StringBuilder();
        private void State_btn_Click(object sender, EventArgs e)
        {
            //sb.AppendLine(Game_window.state_attention);
            // Brainbox.Text = sb.ToString();
            // Brainbox.Text = Game_window.state_attention;
            
        }

        private void NPC_Start()
        {
            appleBox_NPC_width += 50;
            appleBox_NPC.Size = new System.Drawing.Size(appleBox_NPC_width, appleBox_NPC_height);
            if (appleBox_NPC_width >= 500)
            {
                complete_data = appleBox_player_width / 50;
                appleBox_player_width = 0;
                appleBox_NPC_width = 0;
                first_time = 0;

                double sum = 0.0;                                   //측정한 델타값의 총합을 구하기 위한 sum변수
                for(int i = 0; i < Delta_data_length; i++)
                {
                    sum += Delta_arr[i];                                
                }
                Delta_avg = sum / (double)Delta_data_length;             //측정한 델타값의 평균 계산
                Delta_arr_index = 0;                             //델타값 배열의 인덱스 초기화

                Game_over GG = new Game_over();
                GG.Show();
                this.Close();   //npc게이지가 다 차면 게임 오버
            }

        }

        private void NPC_Timer_Tick(object sender, EventArgs e) //3초에 한 번 씩 npc바 증가
        {
            NPC_ticks++;
            //if (Game_window.easy_level_num == 30)     // NPC의 사과따는 속도를 난이도에 따라 늘렸으나, 난이도를 낮추는 것 같아서 제외
            //{
            //    NPC_Level = 3;
            //}
            //else if(Game_window.normal_level_num == 50)
            //{
            //    NPC_Level = 4;
            //}
            //else if(Game_window.hard_level_num == 70)
            //{
            //    NPC_Level = 5;
            //}

            if(NPC_ticks % 9 == 0)
                NPC_Start();
        }

        private void AII_end_Click(object sender, EventArgs e)  //모든 시스템 종료
        {
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void show_tree_Click(object sender, EventArgs e)
        {

        }

        private void tree_Girl_Click(object sender, EventArgs e)
        {

        }

        private void apple_symbol_player_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
