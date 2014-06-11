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
    public partial class FinalControl : UserControl
    {
        private SoundPlayer player;
        public FinalControl()
        {
            InitializeComponent();
            this.label1.Text = "So the universe was saved again\n by a young heroe" +
                                "who was able to infiltrate and to  \n install th deadly virus.\n" +
                                "Bla bla bla.\n" +
                                "\nHe lived happy till he died \n The END";

        }
        void PlayMusic()
        {
            player = new SoundPlayer(Properties.Resources.John_Williams___Star_Wars_Main_Title_and_the_Arrival_at_Naboo___audiopoisk_com_);
            player.Play();
        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void specialButton2_Click(object sender, EventArgs e)
        {
            Form1.Instance.Reset();
        }

        private void FinalControl_Load(object sender, EventArgs e)
        {
            PlayMusic();
        }
    }
}
