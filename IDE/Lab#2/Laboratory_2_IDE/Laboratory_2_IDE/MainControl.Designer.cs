namespace Laboratory_2_IDE
{
    partial class MainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.specialButton3 = new CustomButton.SpecialButton();
            this.specialButton2 = new CustomButton.SpecialButton();
            this.specialButton1 = new CustomButton.SpecialButton();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pcb_alien = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_alien)).BeginInit();
            this.SuspendLayout();
            // 
            // specialButton3
            // 
            this.specialButton3.BackColor = System.Drawing.Color.Gray;
            this.specialButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton3.Enabled = false;
            this.specialButton3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton3.ForeColor = System.Drawing.Color.White;
            this.specialButton3.Location = new System.Drawing.Point(303, 308);
            this.specialButton3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton3.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton3.Name = "specialButton3";
            this.specialButton3.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton3.Size = new System.Drawing.Size(150, 35);
            this.specialButton3.TabIndex = 11;
            this.specialButton3.Text = "Install the virus";
            this.specialButton3.UseVisualStyleBackColor = false;
            this.specialButton3.Visible = false;
            this.specialButton3.Click += new System.EventHandler(this.specialButton3_Click);
            // 
            // specialButton2
            // 
            this.specialButton2.BackColor = System.Drawing.Color.Gray;
            this.specialButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton2.ForeColor = System.Drawing.Color.White;
            this.specialButton2.Location = new System.Drawing.Point(537, 308);
            this.specialButton2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton2.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton2.Name = "specialButton2";
            this.specialButton2.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton2.Size = new System.Drawing.Size(150, 35);
            this.specialButton2.TabIndex = 10;
            this.specialButton2.Text = "Loyality";
            this.specialButton2.UseVisualStyleBackColor = false;
            this.specialButton2.Visible = false;
            this.specialButton2.Click += new System.EventHandler(this.specialButton2_Click);
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Gray;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(100, 308);
            this.specialButton1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton1.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton1.Size = new System.Drawing.Size(150, 35);
            this.specialButton1.TabIndex = 9;
            this.specialButton1.Text = "Knowledge";
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Visible = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.YellowGreen;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.FillGradientColor = System.Drawing.Color.Honeydew;
            this.ovalShape1.Location = new System.Drawing.Point(497, 9);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.SelectionColor = System.Drawing.Color.ForestGreen;
            this.ovalShape1.Size = new System.Drawing.Size(148, 79);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(764, 454);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // pcb_alien
            // 
            this.pcb_alien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_alien.BackColor = System.Drawing.Color.Transparent;
            this.pcb_alien.Image = ((System.Drawing.Image)(resources.GetObject("pcb_alien.Image")));
            this.pcb_alien.Location = new System.Drawing.Point(667, 9);
            this.pcb_alien.Name = "pcb_alien";
            this.pcb_alien.Size = new System.Drawing.Size(81, 62);
            this.pcb_alien.TabIndex = 14;
            this.pcb_alien.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(517, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(523, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_alien_Tick);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_alien);
            this.Controls.Add(this.specialButton3);
            this.Controls.Add(this.specialButton2);
            this.Controls.Add(this.specialButton1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(764, 454);
            this.Load += new System.EventHandler(this.MainControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_alien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton.SpecialButton specialButton3;
        private CustomButton.SpecialButton specialButton2;
        private CustomButton.SpecialButton specialButton1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pcb_alien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
