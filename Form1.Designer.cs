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
            this.panel_homepage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_introduction = new System.Windows.Forms.Button();
            this.button_leadboard = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_newgame = new System.Windows.Forms.Button();
            this.panel_gameplay = new System.Windows.Forms.Panel();
            this.button_pause = new System.Windows.Forms.Button();
            this.label_try_count = new System.Windows.Forms.Label();
            this.button_hint = new System.Windows.Forms.Button();
            this.label_wave = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_question = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_endgame = new System.Windows.Forms.Button();
            this.panel_homepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_gameplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_question)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_homepage
            // 
            this.panel_homepage.AutoSize = true;
            this.panel_homepage.Controls.Add(this.pictureBox1);
            this.panel_homepage.Controls.Add(this.panel2);
            this.panel_homepage.Controls.Add(this.panel1);
            this.panel_homepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_homepage.Location = new System.Drawing.Point(0, 0);
            this.panel_homepage.Name = "panel_homepage";
            this.panel_homepage.Size = new System.Drawing.Size(700, 450);
            this.panel_homepage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 142);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(29, 191);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 239);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
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
            // 
            // button_leadboard
            // 
            this.button_leadboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_leadboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_leadboard.Location = new System.Drawing.Point(20, 166);
            this.button_leadboard.Name = "button_leadboard";
            this.button_leadboard.Size = new System.Drawing.Size(212, 73);
            this.button_leadboard.TabIndex = 1;
            this.button_leadboard.Text = "BẢNG XẾP HẠNG";
            this.button_leadboard.UseVisualStyleBackColor = true;
            // 
            // button_load
            // 
            this.button_load.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(20, 93);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(212, 73);
            this.button_load.TabIndex = 2;
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
            // 
            // panel_gameplay
            // 
            this.panel_gameplay.Controls.Add(this.button_endgame);
            this.panel_gameplay.Controls.Add(this.button_save);
            this.panel_gameplay.Controls.Add(this.button_pause);
            this.panel_gameplay.Controls.Add(this.label_try_count);
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
            // 
            // button_pause
            // 
            this.button_pause.AutoSize = true;
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_pause.Location = new System.Drawing.Point(4, 190);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(116, 35);
            this.button_pause.TabIndex = 6;
            this.button_pause.Text = "Tạm dừng";
            this.button_pause.UseVisualStyleBackColor = true;
            // 
            // label_try_count
            // 
            this.label_try_count.AutoSize = true;
            this.label_try_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_try_count.Location = new System.Drawing.Point(498, 23);
            this.label_try_count.Name = "label_try_count";
            this.label_try_count.Size = new System.Drawing.Size(177, 25);
            this.label_try_count.TabIndex = 5;
            this.label_try_count.Text = "Số lần cố gắng:";
            // 
            // button_hint
            // 
            this.button_hint.AutoSize = true;
            this.button_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hint.Location = new System.Drawing.Point(4, 149);
            this.button_hint.Name = "button_hint";
            this.button_hint.Size = new System.Drawing.Size(116, 35);
            this.button_hint.TabIndex = 4;
            this.button_hint.Text = "Gợi ý";
            this.button_hint.UseVisualStyleBackColor = true;
            // 
            // label_wave
            // 
            this.label_wave.AutoSize = true;
            this.label_wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wave.Location = new System.Drawing.Point(215, 23);
            this.label_wave.Name = "label_wave";
            this.label_wave.Size = new System.Drawing.Size(57, 25);
            this.label_wave.TabIndex = 3;
            this.label_wave.Text = "Màn";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(380, 23);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(72, 25);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Điểm:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(33, 23);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(117, 25);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "Thời gian:";
            // 
            // pictureBox_question
            // 
            this.pictureBox_question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_question.Location = new System.Drawing.Point(125, 83);
            this.pictureBox_question.Name = "pictureBox_question";
            this.pictureBox_question.Size = new System.Drawing.Size(450, 270);
            this.pictureBox_question.TabIndex = 0;
            this.pictureBox_question.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.AutoSize = true;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_save.Location = new System.Drawing.Point(4, 231);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 35);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Lưu";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_endgame
            // 
            this.button_endgame.AutoSize = true;
            this.button_endgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_endgame.Location = new System.Drawing.Point(4, 272);
            this.button_endgame.Name = "button_endgame";
            this.button_endgame.Size = new System.Drawing.Size(116, 35);
            this.button_endgame.TabIndex = 8;
            this.button_endgame.Text = "Kết thúc";
            this.button_endgame.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel_gameplay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(716, 489);
            this.Name = "Game";
            this.Text = "ABC";
            this.panel_homepage.ResumeLayout(false);
            this.panel_homepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_gameplay.ResumeLayout(false);
            this.panel_gameplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_question)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_homepage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_introduction;
        private System.Windows.Forms.Button button_leadboard;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_newgame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_gameplay;
        private System.Windows.Forms.Label label_wave;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pictureBox_question;
        private System.Windows.Forms.Button button_hint;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Label label_try_count;
        private System.Windows.Forms.Button button_endgame;
        private System.Windows.Forms.Button button_save;
    }
}

