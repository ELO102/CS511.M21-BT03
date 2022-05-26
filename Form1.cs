using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Speech;
using System.Speech.Synthesis;

namespace CS511.M21_BT03
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            init_global();
        }

        // global var (init)
        string proj_path = "E:/Study/CS511.M21/CS511.M21-BT03/";
        string lead_path = "E:/Study/CS511.M21/CS511.M21-BT03/Data/ListPlayer_new.bat";
        XuLyUser ListUsr;
        User usr;
        SpeechSynthesizer speechSynthesizerObj;

        private void init_global()
        {
            // init Leadboard file
            ListUsr = new XuLyUser();
            if (!File.Exists(lead_path))
            {
                ListUsr.them(new User(ListUsr.List.Count, "Cheater1", 99999));
                ListUsr.them(new User(ListUsr.List.Count, "Cheater2", 9999));
                ListUsr.them(new User(ListUsr.List.Count, "Cheater3", 999));
                ListUsr.them(new User(ListUsr.List.Count, "NormalGuy", 100));
                ListUsr.them(new User(ListUsr.List.Count, "NormalGuy", 100));
                ListUsr.them(new User(ListUsr.List.Count, "NormalGuy", 100));
                ListUsr.them(new User(ListUsr.List.Count, "NormalGuy", 100));
                ListUsr.them(new User(ListUsr.List.Count, "NormalGuy", 100));
                ListUsr.them(new User(ListUsr.List.Count, "NormalGuy", 100));
                ListUsr.GhiFile(lead_path);
            }
            else
            {
                ListUsr.List = ListUsr.DocFile(lead_path);
                ListUsr.List = ListUsr.SapXep();
            }

        }

        // main panel order
        private void main_panel_order()
        {
            this.Controls.Add(this.panel_homepage);
            this.Controls.Add(this.panel_gameplay);
        }

        // Choose Subject
        int subject_index = -1;
        private void pictureBox_SubjectChoose(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == "pictureBox_fruit")
            {
                subject_index = 0;
                label_subject.Text = "FRUIT";
            }

                
            else if (((PictureBox)sender).Name == "pictureBox_food")
            {
                subject_index = 1;
                label_subject.Text = "FOOD";
            }
            else if (((PictureBox)sender).Name == "pictureBox_sport")
            {
                subject_index = 2;
                label_subject.Text = "SPORT";
            }
            else if (((PictureBox)sender).Name == "pictureBox_transport")
            {
                subject_index = 3;
                label_subject.Text = "TRANSPORT";
            }
        }

        // Play button
        private void GameStart_Click(object sender, EventArgs e)
        {
            if (subject_index != -1)
            {
                panel_homepage.Visible = false;
                panel_gameplay.Visible = true;
            }
            Game_start();
        }

        // Background music

        WMPLib.WindowsMediaPlayer Player;
        int nhac = 1;
        bool trangthai = true;

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //Actions on stop
                if (trangthai)
                {
                    nhac++;
                    if (nhac == 6)
                    {
                        nhac = 1;
                    }
                    string url = proj_path + "Data/Music/nhac" + nhac + ".mp3";
                    PlayFile(url);
                }
            }
        }
        bool k = false;
        bool first_click = true;
        private void PlayFile(string url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange += Player_PlayStateChange;
            Player.URL = url;
            Player.settings.volume = 30;
            //Player.controls.play();
            Player.controls.pause();
        }
        private void pbvolume_Click(object sender, EventArgs e)
        {
            if (first_click)
            {
                PlayFile(proj_path + "Data/Music/nhac" + nhac + ".mp3");
                first_click = false;
                pictureBox_musicBG.BackgroundImage = Properties.Resources.pause;
                k = true;
                return;
            }
            if (k)
            {
                Player.controls.pause();
                pictureBox_musicBG.BackgroundImage = Properties.Resources.play;
                k = false;
            }
            else
            {
                Player.controls.play();
                pictureBox_musicBG.BackgroundImage = Properties.Resources.pause;
                k = true;
            }
            return;
        }

        private void disable_all_panel_in_option1()
        {
            panel_newgame_option.Visible = false;
            panel_introduction.Visible = false;
            panel_leadboard1.Visible = false;
        }
        private void button_newgame_Click(object sender, EventArgs e)
        {
            disable_all_panel_in_option1();
            panel_newgame_option.Visible = true;
        }
        private void button_introduction_Click(object sender, EventArgs e)
        {
            disable_all_panel_in_option1();
            panel_introduction.Visible = true;
        }
        // Show leadboard
        private void button_leadboard_Click(object sender, EventArgs e)
        {
            disable_all_panel_in_option1();
            Show_Leadboard(panel_leadboard1);
        }
        private void Show_Leadboard(Panel panel_Lead)
        {
            ListUsr.List = ListUsr.SapXep();

            if (panel_Lead.Name == "panel_leadboard1")
            {
                panel_leadboard1.Visible = true;
                Delete_all_controls_in_Control(panel_smallLeadboard);
                Label lb_STT = label3;
                Label lb_Name = label4;
                Label lb_Score = label5;
                List_user_to_leadboard(panel_smallLeadboard, lb_STT, lb_Name, lb_Score);
            }
        }
        private void Delete_all_controls_in_Control(Control obj)
        {
            foreach (Control control in obj.Controls.OfType<Control>().ToList())
            {
                obj.Controls.Remove(control);
            }
        }
        private void List_user_to_leadboard(Panel pnl_leadboard, Label lb_STT, Label lb_Name, Label lb_Score)
        {
            int CanChinh = 0;
            for (int i = 0; i < ListUsr.List.Count; i++)
            {
                Label Rank = new Label();
                Rank.BackColor = Color.White;
                Rank.Location = new Point(lb_STT.Location.X, lb_STT.Location.Y + CanChinh);
                Rank.Size = lb_STT.Size;
                Rank.Text = (i + 1).ToString();
                Rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnl_leadboard.Controls.Add(Rank);

                Label Name = new Label();
                Name.BackColor = Color.White;
                Name.Location = new Point(lb_Name.Location.X, lb_Name.Location.Y + CanChinh);
                Name.Size = lb_Name.Size;
                Name.Text = ListUsr.List[i].Ten;
                Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnl_leadboard.Controls.Add(Name);

                Label Score = new Label();
                Score.BackColor = Color.White;
                Score.Location = new Point(lb_Score.Location.X, lb_Score.Location.Y + CanChinh);
                Score.Size = lb_Score.Size;
                Score.Text = ListUsr.List[i].Diem.ToString();
                Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                pnl_leadboard.Controls.Add(Score);

                CanChinh += 30;
            }
        }

        // Game Stage
        string[] FRUIT =
        {
            "APPLE",
            "PINEAPPLE",
            "COCONUT",
            "MANGO"
        };
        string[] FOOD;
        string[] SPORT;
        string[] TRANSPORT;

        double[,] Diem = { {10,2},
                            {20,3},
                            {30,4},
                            {40,5},
                            {50,6},
                            {60,7},
                            {70,8},
                            {80,9},
                            {90,10},
                            {100,15},
                            {120,20},
                            {150,25},
                            {180,30},
                            {220,40},
                            {250,50},
        };
        int Wave = 1;
        string[] ListPtr;
        int index;
        int[] ListUsed;
        int indexUsed;
        TextBox[] ListTxt;
        Button[] Listbtn;
        Random r;
        double TongDiem;
        double TongXu;
        int TimeLeft;
        string[] KetQua;
        private void Game_start()
        {
            TongDiem = 0;
            TongXu = 200;
            TimeLeft = 180;
            label_score.Text = "Điểm:" + TongDiem.ToString();
            label_coin.Text = "Xu: " + TongXu.ToString();
            ListPtr = new string[4];
            ListUsed = new int[ListPtr.Length];

            if (subject_index == 0)
                KetQua = FRUIT;
            else if (subject_index == 1)
                KetQua = FOOD;
            else if (subject_index == 2)
                KetQua = SPORT;
            else
                KetQua = TRANSPORT;

            for (int i = 0; i < ListPtr.Length; i++)
            {
                ListPtr[i] = proj_path + "Data/Question/" + label_subject.Text + (i + 1).ToString() + ".jpg";
            }

            r = new Random();
            index = r.Next(0, ListPtr.Length);
            
            Game_init();
        }
        private void Game_init()
        {
            pictureBox_question.Image = Image.FromFile(ListPtr[index]);
            ListUsed[indexUsed++] = index;

            label_wave.Text = "Màn " + indexUsed.ToString() + " (" + Diem[indexUsed - 1, 0].ToString() + " điểm, " + Diem[indexUsed - 1, 1].ToString() + " xu)";

            Listbtn = new Button[KetQua[index].Length * 2];
            Listbtn[0] = new Button();
            Listbtn[0].Padding = new System.Windows.Forms.Padding(1);
            Listbtn[0].Size = new System.Drawing.Size(50, 25);
            Listbtn[0].TabIndex = 1;
            Listbtn[0].UseVisualStyleBackColor = true;
            Listbtn[0].Click += DuoiHinhBatChu_Btn_Click;
            flowLayoutPanel_answer_btnContain.Controls.Add(Listbtn[0]);
            for (int i = 1; i < Listbtn.Length; i++)
            {
                Listbtn[i] = new Button();
                Listbtn[i].Padding = new System.Windows.Forms.Padding(1);
                Listbtn[i].Size = new System.Drawing.Size(50, 25);
                Listbtn[i].TabIndex = i + 1;
                Listbtn[i].UseVisualStyleBackColor = true;
                Listbtn[i].Click += DuoiHinhBatChu_Btn_Click;
                flowLayoutPanel_answer_btnContain.Controls.Add(Listbtn[i]);
            }

            ListTxt = new TextBox[KetQua[index].Length];
            ListTxt[0] = new TextBox();
            ListTxt[0].Location = new Point(14 + 128 + 15, 363);
            ListTxt[0].Text = "";
            ListTxt[0].Size = new System.Drawing.Size(30, 30);
            ListTxt[0].Click += DuoiHinhBatChu_Click;
            ListTxt[0].ReadOnly = true;
            ListTxt[0].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel_gameplay.Controls.Add(ListTxt[0]);
            for (int i = 1; i < ListTxt.Length; i++)
            {
                ListTxt[i] = new TextBox();
                ListTxt[i].Location = new Point(ListTxt[i - 1].Location.X + 32, label_answer.Location.Y);
                ListTxt[i].Text = "";
                ListTxt[i].Size = new System.Drawing.Size(30, 30);
                ListTxt[i].Click += DuoiHinhBatChu_Click;
                ListTxt[i].ReadOnly = true;
                ListTxt[i].Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel_gameplay.Controls.Add(ListTxt[i]);
            }

            int ChuCaiNgauNhien;
            bool KiemTraTrung;
            for (int i = 0; i < KetQua[index].Length; i++)
            {
                do
                {
                    KiemTraTrung = true;
                    ChuCaiNgauNhien = r.Next(0, Listbtn.Length);
                    if (Listbtn[ChuCaiNgauNhien].Text == "") Listbtn[ChuCaiNgauNhien].Text = KetQua[index][i].ToString();
                    else KiemTraTrung = false;

                } while (!KiemTraTrung);
            }

            foreach (Button btn in Listbtn)
            {
                if (btn.Text == "")
                {
                    ChuCaiNgauNhien = r.Next(65, 91);
                    char chucai = (char)ChuCaiNgauNhien;
                    btn.Text = chucai.ToString();

                }
            }
        }
        void DuoiHinhBatChu_Btn_Click(object sender, EventArgs e)
        {
            int EndPoint = 0;
            for (int i = 0; i < ListTxt.Length; i++)
            {
                if (ListTxt[i].Text == "")
                {
                    ListTxt[i].Text = ((Button)sender).Text;
                    EndPoint = i;
                    break;
                }
            }

            ((Button)sender).Visible = false;
            if (EndPoint == ListTxt.Length - 1)
            {
                CheckResult(sender, e);
            }
        }
        private void CheckResult(object sender, EventArgs e)
        {
            string Kq = "";
            foreach (TextBox txt in ListTxt)
            {
                Kq += txt.Text;
            }
            if (Kq == KetQua[index])
            {
                if (indexUsed == ListPtr.Length)
                {

                    TongDiem += Diem[indexUsed - 1, 0];
                    TongXu += Diem[indexUsed - 1, 1];
                    label_coin.Text = "Tổng xu : " + TongXu.ToString();
                    label_score.Text = "Tổng điểm : " + TongDiem.ToString();
                    MessageBox.Show("You Won with ToTal Point: " + TongDiem.ToString() + ",Tổng xu còn dư: " + TongXu.ToString() + "!");
                    Exit_Click(sender, e);
                }
                else
                {
                    label_coin.Text = "Tổng xu : " + TongXu.ToString();
                    TongDiem += Diem[indexUsed - 1, 0];
                    TongXu += Diem[indexUsed - 1, 1];
                    speechSynthesizerObj = new SpeechSynthesizer();
                    speechSynthesizerObj.SpeakAsync(KetQua[index]);
                    MessageBox.Show("Đúng rồi!");
                    label_score.Text = "Tổng điểm : " + TongDiem.ToString();
                    
                    NextQuestion();
                }
            }
            else MessageBox.Show("Sai rồi!");
        }
        private void NextQuestion()
        {
            bool Check;
            r = new Random();
            do
            {
                Check = true;
                index = r.Next(0, ListPtr.Length);

                for (int i = 0; i < indexUsed; i++)
                {
                    if (ListUsed[i] == index)
                    {
                        Check = false;
                        break;
                    }
                }
            } while (!Check);

            TimeLeft = 179;
            timer1.Start();

            foreach (TextBox txt in ListTxt)
            {
                panel_gameplay.Controls.Remove(txt);
            }

            foreach (Button btn in Listbtn)
            {
                flowLayoutPanel_answer_btnContain.Controls.Remove(btn);
            }
            Game_init();
        }

        void DuoiHinhBatChu_Click(object sender, EventArgs e)
        {
            foreach (Button btn in Listbtn)
            {
                if (!btn.Visible && btn.Text == ((TextBox)sender).Text)
                {
                    btn.Visible = true; break;
                }
            }
            ((TextBox)sender).ResetText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = "Thời gian: " + TimeLeft.ToString() + " giây";

            if (TimeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian!");
                Exit_Click(sender, e);
            }
            TimeLeft--;
        }

        void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
