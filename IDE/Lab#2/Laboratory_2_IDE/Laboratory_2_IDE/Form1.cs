using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Models;

namespace Laboratory_2_IDE
{
    public partial class Form1 : Form
    {


        public StatusGame status = StatusGame.Entry;
        public bool firstClick, secondClick;
        

        public Panel panel;

         private static Form1 instance;

         private Form1()
         {
             InitializeComponent();
             panel = this.panel1;
         }

         public static Form1 Instance
         {
            get 
            {
                if (instance == null)
                {
                instance = new Form1();
                }
                return instance;
            }
          }
        public void Reset()
        {
            SplashScreenControl splash = new SplashScreenControl();
            this.panel.Controls.Clear();
            this.panel1.Controls.Add(splash);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreenControl splash = new SplashScreenControl();
            this.panel1.Controls.Add(splash);
        }


    }
}
