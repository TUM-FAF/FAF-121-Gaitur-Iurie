namespace Laboratory_2_IDE
{
    partial class FinalControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalControl));
            this.specialButton1 = new CustomButton.SpecialButton();
            this.specialButton2 = new CustomButton.SpecialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Gray;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(196, 395);
            this.specialButton1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton1.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton1.Size = new System.Drawing.Size(150, 35);
            this.specialButton1.TabIndex = 4;
            this.specialButton1.Text = "Finish";
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // specialButton2
            // 
            this.specialButton2.BackColor = System.Drawing.Color.Gray;
            this.specialButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton2.ForeColor = System.Drawing.Color.White;
            this.specialButton2.Location = new System.Drawing.Point(408, 395);
            this.specialButton2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton2.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton2.Name = "specialButton2";
            this.specialButton2.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton2.Size = new System.Drawing.Size(150, 35);
            this.specialButton2.TabIndex = 5;
            this.specialButton2.Text = "Restart";
            this.specialButton2.UseVisualStyleBackColor = false;
            this.specialButton2.Click += new System.EventHandler(this.specialButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(240, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // FinalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialButton2);
            this.Controls.Add(this.specialButton1);
            this.Name = "FinalControl";
            this.Size = new System.Drawing.Size(764, 454);
            this.Load += new System.EventHandler(this.FinalControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton.SpecialButton specialButton1;
        private CustomButton.SpecialButton specialButton2;
        private System.Windows.Forms.Label label1;
    }
}
