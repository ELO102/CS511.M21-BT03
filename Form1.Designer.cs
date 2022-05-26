namespace CS511.M21_BT03
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel_homepage = new System.Windows.Forms.Panel();
            this.panel_option1 = new System.Windows.Forms.Panel();
            this.panel_newgame_option = new System.Windows.Forms.Panel();
            this.button_start = new System.Windows.Forms.Button();
            this.label_subject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_sport = new System.Windows.Forms.PictureBox();
            this.pictureBox_transport = new System.Windows.Forms.PictureBox();
            this.pictureBox_food = new System.Windows.Forms.PictureBox();
            this.pictureBox_fruit = new System.Windows.Forms.PictureBox();
            this.panel_leadboard1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_smallLeadboard = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_introduction = new System.Windows.Forms.Panel();
            this.richTextBox_introduction = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_introduction = new System.Windows.Forms.Button();
            this.button_leadboard = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_newgame = new System.Windows.Forms.Button();
            this.panel_gameplay = new System.Windows.Forms.Panel();
            this.label_coin = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.flowLayoutPanel_answer_btnContain = new System.Windows.Forms.FlowLayoutPanel();
            this.button_endgame = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_hint = new System.Windows.Forms.Button();
            this.label_wave = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_question = new System.Windows.Forms.PictureBox();
            this.pictureBox_musicBG = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_homepage.SuspendLayout();
            this.panel_option1.SuspendLayout();
            this.panel_newgame_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_transport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fruit)).BeginInit();
            this.panel_leadboard1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_introduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_gameplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_musicBG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_homepage
            // 
            this.panel_homepage.AutoSize = true;
            this.panel_homepage.BackColor = System.Drawing.Color.Cyan;
            this.panel_homepage.Controls.Add(this.panel_option1);
            this.panel_homepage.Controls.Add(this.pictureBox1);
            this.panel_homepage.Controls.Add(this.panel1);
            this.panel_homepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_homepage.Location = new System.Drawing.Point(0, 0);
            this.panel_homepage.Name = "panel_homepage";
            this.panel_homepage.Size = new System.Drawing.Size(700, 450);
            this.panel_homepage.TabIndex = 0;
            // 
            // panel_option1
            // 
            this.panel_option1.Controls.Add(this.panel_newgame_option);
            this.panel_option1.Controls.Add(this.panel_leadboard1);
            this.panel_option1.Controls.Add(this.panel_introduction);
            this.panel_option1.Location = new System.Drawing.Point(29, 184);
            this.panel_option1.Name = "panel_option1";
            this.panel_option1.Size = new System.Drawing.Size(364, 246);
            this.panel_option1.TabIndex = 6;
            // 
            // panel_newgame_option
            // 
            this.panel_newgame_option.BackColor = System.Drawing.Color.DimGray;
            this.panel_newgame_option.Controls.Add(this.button_start);
            this.panel_newgame_option.Controls.Add(this.label_subject);
            this.panel_newgame_option.Controls.Add(this.label1);
            this.panel_newgame_option.Controls.Add(this.pictureBox_sport);
            this.panel_newgame_option.Controls.Add(this.pictureBox_transport);
            this.panel_newgame_option.Controls.Add(this.pictureBox_food);
            this.panel_newgame_option.Controls.Add(this.pictureBox_fruit);
            this.panel_newgame_option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_newgame_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel_newgame_option.Location = new System.Drawing.Point(0, 0);
            this.panel_newgame_option.Margin = new System.Windows.Forms.Padding(20);
            this.panel_newgame_option.Name = "panel_newgame_option";
            this.panel_newgame_option.Size = new System.Drawing.Size(364, 246);
            this.panel_newgame_option.TabIndex = 1;
            this.panel_newgame_option.Tag = "Fruit";
            this.panel_newgame_option.Visible = false;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(24, 201);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(82, 35);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label_subject.ForeColor = System.Drawing.Color.White;
            this.label_subject.Location = new System.Drawing.Point(0, 37);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(106, 22);
            this.label_subject.TabIndex = 5;
            this.label_subject.Text = "Chưa chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chủ đề:";
            // 
            // pictureBox_sport
            // 
            this.pictureBox_sport.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_sport.BackgroundImage = global::CS511.M21_BT03.Properties.Resources.sport;
            this.pictureBox_sport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_sport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_sport.Location = new System.Drawing.Point(130, 126);
            this.pictureBox_sport.Name = "pictureBox_sport";
            this.pictureBox_sport.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_sport.TabIndex = 3;
            this.pictureBox_sport.TabStop = false;
            this.pictureBox_sport.Click += new System.EventHandler(this.pictureBox_SubjectChoose);
            // 
            // pictureBox_transport
            // 
            this.pictureBox_transport.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_transport.BackgroundImage = global::CS511.M21_BT03.Properties.Resources.transport;
            this.pictureBox_transport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_transport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_transport.Location = new System.Drawing.Point(246, 126);
            this.pictureBox_transport.Name = "pictureBox_transport";
            this.pictureBox_transport.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_transport.TabIndex = 2;
            this.pictureBox_transport.TabStop = false;
            this.pictureBox_transport.Click += new System.EventHandler(this.pictureBox_SubjectChoose);
            // 
            // pictureBox_food
            // 
            this.pictureBox_food.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_food.BackgroundImage = global::CS511.M21_BT03.Properties.Resources.food;
            this.pictureBox_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_food.Location = new System.Drawing.Point(246, 10);
            this.pictureBox_food.Name = "pictureBox_food";
            this.pictureBox_food.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_food.TabIndex = 1;
            this.pictureBox_food.TabStop = false;
            this.pictureBox_food.Click += new System.EventHandler(this.pictureBox_SubjectChoose);
            // 
            // pictureBox_fruit
            // 
            this.pictureBox_fruit.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_fruit.BackgroundImage = global::CS511.M21_BT03.Properties.Resources.fruit;
            this.pictureBox_fruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_fruit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_fruit.Location = new System.Drawing.Point(130, 10);
            this.pictureBox_fruit.Name = "pictureBox_fruit";
            this.pictureBox_fruit.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_fruit.TabIndex = 0;
            this.pictureBox_fruit.TabStop = false;
            this.pictureBox_fruit.Click += new System.EventHandler(this.pictureBox_SubjectChoose);
            // 
            // panel_leadboard1
            // 
            this.panel_leadboard1.BackColor = System.Drawing.Color.DimGray;
            this.panel_leadboard1.Controls.Add(this.panel2);
            this.panel_leadboard1.Controls.Add(this.label2);
            this.panel_leadboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_leadboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel_leadboard1.Location = new System.Drawing.Point(0, 0);
            this.panel_leadboard1.Margin = new System.Windows.Forms.Padding(20);
            this.panel_leadboard1.Name = "panel_leadboard1";
            this.panel_leadboard1.Size = new System.Drawing.Size(364, 246);
            this.panel_leadboard1.TabIndex = 7;
            this.panel_leadboard1.Tag = "Fruit";
            this.panel_leadboard1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_smallLeadboard);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 206);
            this.panel2.TabIndex = 6;
            // 
            // panel_smallLeadboard
            // 
            this.panel_smallLeadboard.AutoScroll = true;
            this.panel_smallLeadboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_smallLeadboard.Location = new System.Drawing.Point(0, 34);
            this.panel_smallLeadboard.Name = "panel_smallLeadboard";
            this.panel_smallLeadboard.Size = new System.Drawing.Size(358, 172);
            this.panel_smallLeadboard.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "ĐIỂM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "NICKNAME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "STT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "BẢNG XẾP HẠNG";
            // 
            // panel_introduction
            // 
            this.panel_introduction.BackColor = System.Drawing.Color.DimGray;
            this.panel_introduction.Controls.Add(this.richTextBox_introduction);
            this.panel_introduction.Controls.Add(this.label6);
            this.panel_introduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_introduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel_introduction.Location = new System.Drawing.Point(0, 0);
            this.panel_introduction.Margin = new System.Windows.Forms.Padding(20);
            this.panel_introduction.Name = "panel_introduction";
            this.panel_introduction.Size = new System.Drawing.Size(364, 246);
            this.panel_introduction.TabIndex = 7;
            this.panel_introduction.Tag = "Fruit";
            this.panel_introduction.Visible = false;
            // 
            // richTextBox_introduction
            // 
            this.richTextBox_introduction.Location = new System.Drawing.Point(3, 44);
            this.richTextBox_introduction.Name = "richTextBox_introduction";
            this.richTextBox_introduction.Size = new System.Drawing.Size(358, 199);
            this.richTextBox_introduction.TabIndex = 8;
            this.richTextBox_introduction.Text = "- Dựa vào hình ảnh xuất hiện mà nhập đáp án bằng các chữ cái được cho.\n- Nhập sai" +
    " có thể xóa và nhập lại\n- Nhập từ trái sang phải\n- Có gợi ý\n- Hết thời gian là k" +
    "ết thúc\n- Điểm mỗi màn sẽ tăng dần";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(108, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "HƯỚNG DẪN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CS511.M21_BT03.Properties.Resources.game_title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(29, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 142);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button_introduction);
            this.panel1.Controls.Add(this.button_leadboard);
            this.panel1.Controls.Add(this.button_load);
            this.panel1.Controls.Add(this.button_newgame);
            this.panel1.Location = new System.Drawing.Point(428, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(252, 332);
            this.panel1.TabIndex = 4;
            // 
            // button_introduction
            // 
            this.button_introduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_introduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_introduction.Location = new System.Drawing.Point(20, 239);
            this.button_introduction.Name = "button_introduction";
            this.button_introduction.Size = new System.Drawing.Size(212, 73);
            this.button_introduction.TabIndex = 3;
            this.button_introduction.Text = "HƯỚNG DẪN";
            this.button_introduction.UseVisualStyleBackColor = true;
            this.button_introduction.Click += new System.EventHandler(this.button_introduction_Click);
            // 
            // button_leadboard
            // 
            this.button_leadboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_leadboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_leadboard.Location = new System.Drawing.Point(20, 166);
            this.button_leadboard.Name = "button_leadboard";
            this.button_leadboard.Size = new System.Drawing.Size(212, 73);
            this.button_leadboard.TabIndex = 2;
            this.button_leadboard.Text = "BẢNG XẾP HẠNG";
            this.button_leadboard.UseVisualStyleBackColor = true;
            this.button_leadboard.Click += new System.EventHandler(this.button_leadboard_Click);
            // 
            // button_load
            // 
            this.button_load.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(20, 93);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(212, 73);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "TIẾP TỤC";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // button_newgame
            // 
            this.button_newgame.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newgame.Location = new System.Drawing.Point(20, 20);
            this.button_newgame.Name = "button_newgame";
            this.button_newgame.Size = new System.Drawing.Size(212, 73);
            this.button_newgame.TabIndex = 0;
            this.button_newgame.Text = "TRÒ CHƠI MỚI";
            this.button_newgame.UseVisualStyleBackColor = true;
            this.button_newgame.Click += new System.EventHandler(this.button_newgame_Click);
            // 
            // panel_gameplay
            // 
            this.panel_gameplay.Controls.Add(this.label_coin);
            this.panel_gameplay.Controls.Add(this.label_answer);
            this.panel_gameplay.Controls.Add(this.flowLayoutPanel_answer_btnContain);
            this.panel_gameplay.Controls.Add(this.button_endgame);
            this.panel_gameplay.Controls.Add(this.button_save);
            this.panel_gameplay.Controls.Add(this.button_pause);
            this.panel_gameplay.Controls.Add(this.button_hint);
            this.panel_gameplay.Controls.Add(this.label_wave);
            this.panel_gameplay.Controls.Add(this.label_score);
            this.panel_gameplay.Controls.Add(this.label_time);
            this.panel_gameplay.Controls.Add(this.pictureBox_question);
            this.panel_gameplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_gameplay.Location = new System.Drawing.Point(0, 0);
            this.panel_gameplay.Name = "panel_gameplay";
            this.panel_gameplay.Size = new System.Drawing.Size(700, 450);
            this.panel_gameplay.TabIndex = 0;
            this.panel_gameplay.Visible = false;
            // 
            // label_coin
            // 
            this.label_coin.AutoSize = true;
            this.label_coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_coin.Location = new System.Drawing.Point(454, 9);
            this.label_coin.Name = "label_coin";
            this.label_coin.Size = new System.Drawing.Size(47, 25);
            this.label_coin.TabIndex = 11;
            this.label_coin.Text = "Xu:";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_answer.Location = new System.Drawing.Point(14, 363);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(128, 25);
            this.label_answer.TabIndex = 10;
            this.label_answer.Text = "Câu trả lời:";
            // 
            // flowLayoutPanel_answer_btnContain
            // 
            this.flowLayoutPanel_answer_btnContain.Location = new System.Drawing.Point(521, 59);
            this.flowLayoutPanel_answer_btnContain.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_answer_btnContain.Name = "flowLayoutPanel_answer_btnContain";
            this.flowLayoutPanel_answer_btnContain.Size = new System.Drawing.Size(115, 287);
            this.flowLayoutPanel_answer_btnContain.TabIndex = 9;
            // 
            // button_endgame
            // 
            this.button_endgame.AutoSize = true;
            this.button_endgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_endgame.Location = new System.Drawing.Point(572, 404);
            this.button_endgame.Name = "button_endgame";
            this.button_endgame.Size = new System.Drawing.Size(116, 35);
            this.button_endgame.TabIndex = 8;
            this.button_endgame.Text = "Kết thúc";
            this.button_endgame.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.AutoSize = true;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_save.Location = new System.Drawing.Point(572, 363);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 35);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Lưu";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_pause
            // 
            this.button_pause.AutoSize = true;
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_pause.Location = new System.Drawing.Point(450, 403);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(116, 35);
            this.button_pause.TabIndex = 6;
            this.button_pause.Text = "Tạm dừng";
            this.button_pause.UseVisualStyleBackColor = true;
            // 
            // button_hint
            // 
            this.button_hint.AutoSize = true;
            this.button_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hint.Location = new System.Drawing.Point(450, 363);
            this.button_hint.Name = "button_hint";
            this.button_hint.Size = new System.Drawing.Size(116, 35);
            this.button_hint.TabIndex = 4;
            this.button_hint.Text = "Gợi ý";
            this.button_hint.UseVisualStyleBackColor = true;
            this.button_hint.Click += new System.EventHandler(this.btnGoiY_Click);
            // 
            // label_wave
            // 
            this.label_wave.AutoSize = true;
            this.label_wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wave.Location = new System.Drawing.Point(12, 9);
            this.label_wave.Name = "label_wave";
            this.label_wave.Size = new System.Drawing.Size(57, 25);
            this.label_wave.TabIndex = 3;
            this.label_wave.Text = "Màn";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(270, 9);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(72, 25);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Điểm:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(14, 408);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(117, 25);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "Thời gian:";
            // 
            // pictureBox_question
            // 
            this.pictureBox_question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_question.BackColor = System.Drawing.Color.White;
            this.pictureBox_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_question.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_question.Image")));
            this.pictureBox_question.Location = new System.Drawing.Point(17, 46);
            this.pictureBox_question.Name = "pictureBox_question";
            this.pictureBox_question.Size = new System.Drawing.Size(484, 300);
            this.pictureBox_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_question.TabIndex = 0;
            this.pictureBox_question.TabStop = false;
            // 
            // pictureBox_musicBG
            // 
            this.pictureBox_musicBG.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox_musicBG.BackgroundImage = global::CS511.M21_BT03.Properties.Resources.play;
            this.pictureBox_musicBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_musicBG.Location = new System.Drawing.Point(647, 3);
            this.pictureBox_musicBG.Name = "pictureBox_musicBG";
            this.pictureBox_musicBG.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_musicBG.TabIndex = 6;
            this.pictureBox_musicBG.TabStop = false;
            this.pictureBox_musicBG.Click += new System.EventHandler(this.pbvolume_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.pictureBox_musicBG);
            this.Controls.Add(this.panel_gameplay);
            this.Controls.Add(this.panel_homepage);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(716, 489);
            this.Name = "Game";
            this.Text = "ABC";
            this.panel_homepage.ResumeLayout(false);
            this.panel_homepage.PerformLayout();
            this.panel_option1.ResumeLayout(false);
            this.panel_newgame_option.ResumeLayout(false);
            this.panel_newgame_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_transport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fruit)).EndInit();
            this.panel_leadboard1.ResumeLayout(false);
            this.panel_leadboard1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_introduction.ResumeLayout(false);
            this.panel_introduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_gameplay.ResumeLayout(false);
            this.panel_gameplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_musicBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_homepage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_introduction;
        private System.Windows.Forms.Button button_leadboard;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_wave;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pictureBox_question;
        private System.Windows.Forms.Button button_hint;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_endgame;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_answer_btnContain;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.PictureBox pictureBox_musicBG;
        private System.Windows.Forms.Panel panel_option1;
        private System.Windows.Forms.Panel panel_leadboard1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_smallLeadboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_introduction;
        private System.Windows.Forms.RichTextBox richTextBox_introduction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_newgame_option;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_sport;
        private System.Windows.Forms.PictureBox pictureBox_transport;
        private System.Windows.Forms.PictureBox pictureBox_food;
        private System.Windows.Forms.PictureBox pictureBox_fruit;
        private System.Windows.Forms.Label label_coin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_gameplay;
    }
}

