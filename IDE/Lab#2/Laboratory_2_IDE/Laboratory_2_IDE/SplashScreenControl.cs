using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Laboratory_2_IDE
{
    public partial class SplashScreenControl : UserControl
    {
        private SoundPlayer player;
        public SplashScreenControl()
        {
            InitializeComponent();
            this.label1.Text = "A long long time ago, an evil army decided to take \n control over the entire universe\n" +
                              "In order to do that they started to build a super \n arm that  could destroy any oposing they army.\n" +
                              "The last of the survived from regresion decided \n to destroy that weapon with all cost.\n" +
                              "\nAs one of the best spy you were send in order to \n install a virus and destroy their \n base and to free entire universe.";
        }
        void PlayMusic()
        {
            player = new SoundPlayer(Properties.Resources.start);
            player.Play();
        }


        void timer_Tick(object sender, EventArgs e)
        {
            this.specialButton1.Visible = true;
        }


        private void specialButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            player.Stop();
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new MainControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));
            

        }

        private void SplashScreenControl_Load(object sender, EventArgs e)
        {
            PlayMusic();
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
    }
}
