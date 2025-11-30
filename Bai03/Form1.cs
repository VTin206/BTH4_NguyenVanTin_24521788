using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfiledialog = new OpenFileDialog();
            DialogResult ofd = Openfiledialog.ShowDialog();
            Openfiledialog.Filter = "Video Files|*.wav;*.avi;*.mpeg;*.mid;*.mp4;*.mp3";
            if (ofd == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = Openfiledialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
