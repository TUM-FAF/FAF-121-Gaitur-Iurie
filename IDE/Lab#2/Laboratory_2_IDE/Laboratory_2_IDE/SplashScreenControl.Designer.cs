namespace Laboratory_2_IDE
{
    partial class SplashScreenControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenControl));
            this.specialButton1 = new CustomButton.SpecialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Gray;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(282, 354);
            this.specialButton1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton1.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton1.Size = new System.Drawing.Size(190, 43);
            this.specialButton1.TabIndex = 2;
            this.specialButton1.Text = "Next ->";
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Visible = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // SplashScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialButton1);
            this.Name = "SplashScreenControl";
            this.Size = new System.Drawing.Size(764, 454);
            this.Load += new System.EventHandler(this.SplashScreenControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton.SpecialButton specialButton1;
        private System.Windows.Forms.Label label1;
    }
}
