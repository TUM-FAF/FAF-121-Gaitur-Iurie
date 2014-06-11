namespace Laboratory_2_IDE
{
    partial class KnowledgeControl
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.specialButton2 = new CustomButton.SpecialButton();
            this.specialButton1 = new CustomButton.SpecialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.richTextBox1.Location = new System.Drawing.Point(53, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(656, 54);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r4);
            this.groupBox1.Controls.Add(this.r3);
            this.groupBox1.Controls.Add(this.r2);
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(53, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answers";
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r4.Location = new System.Drawing.Point(7, 150);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(152, 29);
            this.r4.TabIndex = 3;
            this.r4.TabStop = true;
            this.r4.Text = "radioButton4";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r3.Location = new System.Drawing.Point(7, 107);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(152, 29);
            this.r3.TabIndex = 2;
            this.r3.TabStop = true;
            this.r3.Text = "radioButton3";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r2.Location = new System.Drawing.Point(7, 61);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(152, 29);
            this.r2.TabIndex = 1;
            this.r2.TabStop = true;
            this.r2.Text = "radioButton2";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r1.Location = new System.Drawing.Point(7, 20);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(152, 29);
            this.r1.TabIndex = 0;
            this.r1.TabStop = true;
            this.r1.Text = "radioButton1";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // specialButton2
            // 
            this.specialButton2.BackColor = System.Drawing.Color.Gray;
            this.specialButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton2.ForeColor = System.Drawing.Color.White;
            this.specialButton2.Location = new System.Drawing.Point(460, 342);
            this.specialButton2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton2.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton2.Name = "specialButton2";
            this.specialButton2.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton2.Size = new System.Drawing.Size(183, 43);
            this.specialButton2.TabIndex = 7;
            this.specialButton2.Text = "Next ->";
            this.specialButton2.UseVisualStyleBackColor = false;
            this.specialButton2.Click += new System.EventHandler(this.specialButton2_Click);
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Gray;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton1.Enabled = false;
            this.specialButton1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(60, 342);
            this.specialButton1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton1.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton1.Size = new System.Drawing.Size(185, 43);
            this.specialButton1.TabIndex = 6;
            this.specialButton1.Text = "Finish\r\n";
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // KnowledgeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.specialButton2);
            this.Controls.Add(this.specialButton1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "KnowledgeControl";
            this.Size = new System.Drawing.Size(764, 454);
            this.Load += new System.EventHandler(this.KnowledgeControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private CustomButton.SpecialButton specialButton2;
        private CustomButton.SpecialButton specialButton1;
    }
}
