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


namespace Reproductor
{
    public partial class Media_Player : Form
    {

        String[] paths, files;


        public Media_Player()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.volume = 100;
            axWindowsMediaPlayer1.uiMode = "none";
            pbVolumen0.Visible = false;
            TimeFull.Visible = false;
            TimeNow.Visible = false;
            trackBar1.Value = 100;
            labelVolum.Text = axWindowsMediaPlayer1.settings.volume.ToString() + " %";
            pbShuffle.Visible = false;
            pbRetweee.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            pictureBoxPlay.Visible = false;
            pictureBoxPause.Visible = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            labelVolum.Text = axWindowsMediaPlayer1.settings.volume.ToString() + " %";
            if(trackBar1.Value == 0)
            {
                pbVolumen.Visible = false;
                pbVolumen0.Visible = true;
            }
            else if (trackBar1.Value > 0)
            {
                pbVolumen.Visible = true;
                pbVolumen0.Visible = false;
            }

        }

        private void listPlaySongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(paths.Length > 0)
            {
                try
                {
                 axWindowsMediaPlayer1.URL = paths[listPlaySongs.SelectedIndex];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
            
        }

        private void AddSongs(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listPlaySongs.Items.Add(files[i]);
                }
            }
        }

        private void Stop(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            TimeFull.Visible = false;
            TimeNow.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Forward(object sender, EventArgs e)
        {
            if(listPlaySongs.SelectedIndex < listPlaySongs.Items.Count - 1)
            {
                listPlaySongs.SelectedIndex = listPlaySongs.SelectedIndex + 1;
            }
        }

        private void Back(object sender, EventArgs e)
        {
            if(listPlaySongs.SelectedIndex > 0)
            {
                listPlaySongs.SelectedIndex = listPlaySongs.SelectedIndex - 1;
            }
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBoxPause.Visible = false;
            pictureBoxPlay.Visible = true;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pictureBoxPause.Visible = true;
                pictureBoxPlay.Visible = false;
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                pictureBoxPause.Visible = false;
                pictureBoxPlay.Visible = true;
                timer1.Stop();
            }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                pictureBoxPause.Visible = false;
                pictureBoxPlay.Visible = true;
                timer1.Stop();
                progressBar1.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeFull.Visible = true;
            TimeNow.Visible = true;
            TimeNow.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            TimeFull.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void listPlaySongs_DoubleClick(object sender, EventArgs e)
        {

            if(listPlaySongs.SelectedIndex > 0 )
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;
                    for (int i = 0; i < files.Length; i++)
                    {
                        listPlaySongs.Items.Add(files[i]);
                    }
                }
            }
        }

        private void listPlaySongs_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            String[] path = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //listPlaySongs.Items.Add(path[0]);

            for (int i = 0; i < path.Length; i++)
            {
                listPlaySongs.Items.Add(path[i]);
            }


        }

        private void listPlaySongs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Media_Player_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                
                    axWindowsMediaPlayer1.fullScreen = false;

                }
            }
        }

        private void axWindowsMediaPlayer1_KeyUpEvent(object sender, AxWMPLib._WMPOCXEvents_KeyUpEvent e)
        {

        }

        private void FullScreen(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }
    }
}
