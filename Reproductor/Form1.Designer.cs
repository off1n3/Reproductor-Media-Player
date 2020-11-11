namespace Reproductor
{
    partial class Media_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media_Player));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listPlaySongs = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelVolum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimeNow = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimeFull = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbVolumen = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbFullScreen = new System.Windows.Forms.PictureBox();
            this.pbShuffle = new System.Windows.Forms.PictureBox();
            this.pbRetweee = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxForward = new System.Windows.Forms.PictureBox();
            this.pictureboxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pbVolumen0 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetweee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumen0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pbMinimize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Reproductor.Properties.Resources.close_window_24px;
            this.pictureBox3.Location = new System.Drawing.Point(1100, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::Reproductor.Properties.Resources.minimize_window_24px;
            this.pbMinimize.Location = new System.Drawing.Point(1070, 8);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(24, 24);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimize.TabIndex = 3;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listPlaySongs);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 592);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de reproducción";
            // 
            // listPlaySongs
            // 
            this.listPlaySongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPlaySongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.listPlaySongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPlaySongs.FormattingEnabled = true;
            this.listPlaySongs.Location = new System.Drawing.Point(12, 19);
            this.listPlaySongs.Name = "listPlaySongs";
            this.listPlaySongs.Size = new System.Drawing.Size(169, 546);
            this.listPlaySongs.TabIndex = 3;
            this.listPlaySongs.SelectedIndexChanged += new System.EventHandler(this.listPlaySongs_SelectedIndexChanged);
            this.listPlaySongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.listPlaySongs_DragDrop);
            this.listPlaySongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.listPlaySongs_DragEnter);
            this.listPlaySongs.DoubleClick += new System.EventHandler(this.listPlaySongs_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(187, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 592);
            this.panel3.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(979, 564);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelVolum
            // 
            this.labelVolum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolum.AutoSize = true;
            this.labelVolum.ForeColor = System.Drawing.Color.White;
            this.labelVolum.Location = new System.Drawing.Point(1082, 567);
            this.labelVolum.Name = "labelVolum";
            this.labelVolum.Size = new System.Drawing.Size(24, 13);
            this.labelVolum.TabIndex = 6;
            this.labelVolum.Text = "0 %";
            // 
            // TimeNow
            // 
            this.TimeNow.AutoSize = true;
            this.TimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeNow.ForeColor = System.Drawing.Color.White;
            this.TimeNow.Location = new System.Drawing.Point(198, 545);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(39, 13);
            this.TimeNow.TabIndex = 7;
            this.TimeNow.Text = "00:00";
            // 
            // TimeFull
            // 
            this.TimeFull.AutoSize = true;
            this.TimeFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFull.ForeColor = System.Drawing.Color.White;
            this.TimeFull.Location = new System.Drawing.Point(1089, 545);
            this.TimeFull.Name = "TimeFull";
            this.TimeFull.Size = new System.Drawing.Size(39, 13);
            this.TimeFull.TabIndex = 7;
            this.TimeFull.Text = "00:00";
            // 
            // pbVolumen
            // 
            this.pbVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVolumen.Image = global::Reproductor.Properties.Resources.speaker_24px;
            this.pbVolumen.Location = new System.Drawing.Point(956, 563);
            this.pbVolumen.Name = "pbVolumen";
            this.pbVolumen.Size = new System.Drawing.Size(24, 24);
            this.pbVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVolumen.TabIndex = 2;
            this.pbVolumen.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbAdd.Image = global::Reproductor.Properties.Resources.add_file_24px;
            this.pbAdd.Location = new System.Drawing.Point(240, 567);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(24, 24);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdd.TabIndex = 2;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.AddSongs);
            // 
            // pbFullScreen
            // 
            this.pbFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbFullScreen.Image = global::Reproductor.Properties.Resources.full_page_view_24px;
            this.pbFullScreen.Location = new System.Drawing.Point(201, 567);
            this.pbFullScreen.Name = "pbFullScreen";
            this.pbFullScreen.Size = new System.Drawing.Size(24, 24);
            this.pbFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFullScreen.TabIndex = 2;
            this.pbFullScreen.TabStop = false;
            this.pbFullScreen.Click += new System.EventHandler(this.FullScreen);
            // 
            // pbShuffle
            // 
            this.pbShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbShuffle.Image = global::Reproductor.Properties.Resources.shuffle_24px;
            this.pbShuffle.Location = new System.Drawing.Point(393, 563);
            this.pbShuffle.Name = "pbShuffle";
            this.pbShuffle.Size = new System.Drawing.Size(24, 24);
            this.pbShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbShuffle.TabIndex = 2;
            this.pbShuffle.TabStop = false;
            // 
            // pbRetweee
            // 
            this.pbRetweee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbRetweee.Image = global::Reproductor.Properties.Resources.retweet_24px;
            this.pbRetweee.Location = new System.Drawing.Point(423, 563);
            this.pbRetweee.Name = "pbRetweee";
            this.pbRetweee.Size = new System.Drawing.Size(24, 24);
            this.pbRetweee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRetweee.TabIndex = 2;
            this.pbRetweee.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.Image = global::Reproductor.Properties.Resources.rewind_24px;
            this.pictureBoxBack.Location = new System.Drawing.Point(559, 563);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 2;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.Back);
            // 
            // pictureBoxForward
            // 
            this.pictureBoxForward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxForward.Image = global::Reproductor.Properties.Resources.fast_forward_24px;
            this.pictureBoxForward.Location = new System.Drawing.Point(691, 563);
            this.pictureBoxForward.Name = "pictureBoxForward";
            this.pictureBoxForward.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForward.TabIndex = 2;
            this.pictureBoxForward.TabStop = false;
            this.pictureBoxForward.Click += new System.EventHandler(this.Forward);
            // 
            // pictureboxStop
            // 
            this.pictureboxStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxStop.Image = global::Reproductor.Properties.Resources.stop_24px;
            this.pictureboxStop.Location = new System.Drawing.Point(647, 563);
            this.pictureboxStop.Name = "pictureboxStop";
            this.pictureboxStop.Size = new System.Drawing.Size(38, 37);
            this.pictureboxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxStop.TabIndex = 2;
            this.pictureboxStop.TabStop = false;
            this.pictureboxStop.Click += new System.EventHandler(this.Stop);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlay.Image = global::Reproductor.Properties.Resources.circled_play_24px;
            this.pictureBoxPlay.Location = new System.Drawing.Point(603, 563);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 2;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPause.Image = global::Reproductor.Properties.Resources.pause_24px;
            this.pictureBoxPause.Location = new System.Drawing.Point(603, 563);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPause.TabIndex = 2;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // pbVolumen0
            // 
            this.pbVolumen0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVolumen0.Image = global::Reproductor.Properties.Resources.mute_24px;
            this.pbVolumen0.Location = new System.Drawing.Point(956, 563);
            this.pbVolumen0.Name = "pbVolumen0";
            this.pbVolumen0.Size = new System.Drawing.Size(24, 24);
            this.pbVolumen0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVolumen0.TabIndex = 2;
            this.pbVolumen0.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(201, 530);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(923, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(194, 46);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(933, 469);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.KeyUpEvent += new AxWMPLib._WMPOCXEvents_KeyUpEventHandler(this.axWindowsMediaPlayer1_KeyUpEvent);
            // 
            // Media_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1139, 632);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TimeFull);
            this.Controls.Add(this.TimeNow);
            this.Controls.Add(this.labelVolum);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pbVolumen);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbFullScreen);
            this.Controls.Add(this.pbShuffle);
            this.Controls.Add(this.pbRetweee);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxForward);
            this.Controls.Add(this.pictureboxStop);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.pbVolumen0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Media_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Media_Player_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetweee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumen0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureboxStop;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.ListBox listPlaySongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbRetweee;
        private System.Windows.Forms.PictureBox pbVolumen;
        private System.Windows.Forms.PictureBox pbShuffle;
        private Bunifu.Framework.UI.BunifuCustomLabel labelVolum;
        private System.Windows.Forms.PictureBox pbVolumen0;
        private Bunifu.Framework.UI.BunifuCustomLabel TimeNow;
        private Bunifu.Framework.UI.BunifuCustomLabel TimeFull;
        private System.Windows.Forms.PictureBox pbFullScreen;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pictureBoxForward;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}

