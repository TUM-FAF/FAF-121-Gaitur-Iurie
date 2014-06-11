using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratory_2_IDE
{
    public partial class LoyalityControl : UserControl
    {
        public LoyalityControl()
        {
            InitializeComponent();
        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            Form1.Instance.secondClick = true;
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new MainControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));
        }
    }
}
