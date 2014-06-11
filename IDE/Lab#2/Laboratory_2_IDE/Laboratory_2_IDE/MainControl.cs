using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Models;

namespace Laboratory_2_IDE
{
    public partial class MainControl : UserControl
    {

        
        private SoundPlayer player;
        

        int _charIndex = 0;
        String _text_alien_1 = @"Hello newbie" + Environment.NewLine + "we heard that you want"
                + Environment.NewLine + "to enter in our army";
        String _text_alien_2 = @"If yes then" + Environment.NewLine + "you have to pass next"
                + Environment.NewLine + "test in order to enroll you";

        String _text_alien_3 = @"Congratulate with " + Environment.NewLine + "your first test"
                + Environment.NewLine + "I saw you had a good result";

        String _text_alien_4 = @"We think that you" + Environment.NewLine + "will become a great"
                + Environment.NewLine + "citizen of dark side";

        String _text_alien_5 = @"Congratulations!!! " + Environment.NewLine + "You passed all"
                + Environment.NewLine + "tests";

        String _text_alien_6 = @"Now you can go " + Environment.NewLine + "to rest."
                + Environment.NewLine + "From tommorow you will serve your duty";

        public MainControl()
        {
            InitializeComponent();
            if (Form1.Instance.firstClick && Form1.Instance.secondClick)
            {
                this.specialButton2.Enabled = false;
                this.specialButton3.Enabled = true;
                this.specialButton1.Enabled = false;
            }

        }

        private void specialButton2_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new LoyalityControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));
        }

        private void specialButton3_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new FinalControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));
        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new KnowledgeControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));
        }

        private void specialButton5_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new SplashScreenControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));

            ResetData();
        }

        private void ResetData()
        {
            this.specialButton2.Enabled = true;
            this.specialButton3.Enabled = false;
            this.specialButton1.Enabled = true;
            Form1.Instance.firstClick = false;
            Form1.Instance.secondClick = false;
            Form1.Instance.status = StatusGame.Entry;
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            PlayMusic();
            List<String> listText = new List<string>();
            if (Form1.Instance.status == StatusGame.Entry)
            {
                listText.Add(_text_alien_1);
                listText.Add(_text_alien_2);
                Form1.Instance.status = StatusGame.FirstTest;
            }
            else if (Form1.Instance.status == StatusGame.FirstTest)
            {
                listText.Add(_text_alien_3);
                listText.Add(_text_alien_4);
                Form1.Instance.status = StatusGame.LastTest;

            }
            else if(Form1.Instance.status == StatusGame.LastTest)
            {
                listText.Add(_text_alien_5);
                listText.Add(_text_alien_6);
                Form1.Instance.status = StatusGame.Entry;
            }

            label1.Text = string.Empty;
            Thread th = new Thread(() => TypewriteText(listText));
            th.Start();


            //for image
            timer1.Interval = 8000;
            timer1.Tick += new EventHandler(timer_alien_Tick);
            timer1.Enabled = true;
                
            
            

        }
        private void TypewriteText(List<String> _text)
        {
            foreach (var inner_text in _text)
            {
                _charIndex = 0;
                Invoke((MethodInvoker)(() => label1.Text = ""));
                while (_charIndex < inner_text.Length)
                {
                    Thread.Sleep(50);
                    label1.Invoke(new Action(() =>
                    {
                        label1.Text += inner_text[_charIndex];
                    }));
                    _charIndex++;
                }


            }

        }
        void PlayMusic()
        {
            player = new SoundPlayer(Properties.Resources.main);
            player.Play();
        }

        void timer_alien_Tick(object sender, EventArgs e)
        {
            this.pcb_alien.Visible = false;
            this.label1.Visible = false;
            this.ovalShape1.Visible = false;
            this.specialButton1.Visible = true;
            this.specialButton2.Visible = true;
            this.specialButton3.Visible = true;
        }
    }
}
