using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace CustomButton
{
    public partial class SpecialButton : Button
    {
        private SoundPlayer player;
        public SpecialButton()
        {
            InitializeComponent();
            //Set default property values for the button during start up
            SetNormalValues();
            player = new SoundPlayer(Properties.Resources.lightsaber_04);
        }
        /// <summary>
        /// To Set button properties when not active.i.e when button not in focus.
        /// </summary>
        private void SetNormalValues()
        {
            this.Font = new Font("Verdana", 8F, FontStyle.Bold);
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;
            this.Margin = new Padding(4, 1, 4, 1);
            this.Padding = new Padding(4);
            this.MinimumSize = new Size(150, 35);
            this.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// Set attributes to highlight button when it is under focus/active.
        /// Change the cursor also as Hand type
        /// </summary>
        private void SetValuesOnFocus()
        {
            //Increase the font size and colors on focus
            this.Font = new Font("Verdana", 10F, FontStyle.Bold);
            this.BackColor = Color.Green;
            this.ForeColor = Color.White;
            //Set the cursor to Hand type
            this.Cursor = Cursors.Hand;
            player.Play();
        }


        /// <summary>
        /// Default handler.Nothing to do here since we don't need to repaint the button.
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        /// <summary>
        /// Event handler which call SetValuesOnFocus() method to give apecial
        /// effect to button while active
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            SetValuesOnFocus();
        }

        /// <summary>
        /// Event handler which call SetNormalValues() method to set back the button
        /// to normal state
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetNormalValues();
        }        
    }
}
