namespace InternetKafe
{
    partial class frmistifadeci
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtistifadecii = new System.Windows.Forms.TextBox();
            this.txtsifree = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Istifadeci Adi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(395, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroCheckBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroCheckBox1.Location = new System.Drawing.Point(26, 440);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(105, 20);
            this.metroCheckBox1.TabIndex = 6;
            this.metroCheckBox1.Text = "Meni Xatirla";
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sifre :";
            // 
            // btngiris
            // 
            this.btngiris.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btngiris.ButtonImage = null;
            this.btngiris.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btngiris.ButtonText = "Giris";
            this.btngiris.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btngiris.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btngiris.CornerRadius = 15;
            this.btngiris.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btngiris.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btngiris.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btngiris.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btngiris.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btngiris.Location = new System.Drawing.Point(80, 515);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(262, 55);
            this.btngiris.TabIndex = 8;
            this.btngiris.TextColor = System.Drawing.Color.DodgerBlue;
            this.btngiris.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(188, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sifremi Xatirlamiram";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InternetKafe.Properties.Resources.man_icon;
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtistifadecii
            // 
            this.txtistifadecii.Font = new System.Drawing.Font("CATIA Symbols", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtistifadecii.Location = new System.Drawing.Point(32, 262);
            this.txtistifadecii.Name = "txtistifadecii";
            this.txtistifadecii.Size = new System.Drawing.Size(262, 34);
            this.txtistifadecii.TabIndex = 10;
            this.txtistifadecii.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsifree
            // 
            this.txtsifree.Font = new System.Drawing.Font("CATIA Symbols", 10.8F);
            this.txtsifree.Location = new System.Drawing.Point(32, 365);
            this.txtsifree.Name = "txtsifree";
            this.txtsifree.PasswordChar = '*';
            this.txtsifree.Size = new System.Drawing.Size(262, 34);
            this.txtsifree.TabIndex = 11;
            this.txtsifree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsifree.UseSystemPasswordChar = true;
            // 
            // frmistifadeci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(428, 582);
            this.Controls.Add(this.txtsifree);
            this.Controls.Add(this.txtistifadecii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmistifadeci";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Istifadeci Emeliyyatlari";
            this.Load += new System.EventHandler(this.frmistifadeci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btngiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtistifadecii;
        private System.Windows.Forms.TextBox txtsifree;
    }
}