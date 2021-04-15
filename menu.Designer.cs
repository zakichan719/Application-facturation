
namespace facturation
{
    partial class menu
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
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFacture = new System.Windows.Forms.Panel();
            this.BtnConfig = new System.Windows.Forms.Panel();
            this.BtnBackup = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::facturation.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(970, 37);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(29, 32);
            this.minimaze.TabIndex = 15;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::facturation.Properties.Resources.close__3_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(1009, 37);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 32);
            this.close.TabIndex = 14;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 35);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.Transparent;
            this.btnFacture.BackgroundImage = global::facturation.Properties.Resources._12;
            this.btnFacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFacture.Location = new System.Drawing.Point(142, 164);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(216, 194);
            this.btnFacture.TabIndex = 15;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            this.btnFacture.Paint += new System.Windows.Forms.PaintEventHandler(this.btnFacture_Paint);
            this.btnFacture.MouseLeave += new System.EventHandler(this.btnFacture_MouseLeave);
            this.btnFacture.MouseHover += new System.EventHandler(this.btnFacture_MouseHover);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfig.BackgroundImage = global::facturation.Properties.Resources._2;
            this.BtnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfig.Location = new System.Drawing.Point(81, 416);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(156, 144);
            this.BtnConfig.TabIndex = 16;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            this.BtnConfig.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnConfig_Paint);
            this.BtnConfig.MouseLeave += new System.EventHandler(this.BtnConfig_MouseLeave);
            this.BtnConfig.MouseHover += new System.EventHandler(this.BtnConfig_MouseHover);
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtnBackup.BackgroundImage = global::facturation.Properties.Resources._3;
            this.BtnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackup.Location = new System.Drawing.Point(273, 416);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(156, 144);
            this.BtnBackup.TabIndex = 16;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            this.BtnBackup.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnBackup_Paint);
            this.BtnBackup.MouseLeave += new System.EventHandler(this.BtnBackup_MouseLeave);
            this.BtnBackup.MouseHover += new System.EventHandler(this.BtnBackup_MouseHover);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::facturation.Properties.Resources.Sans_titre___1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 694);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimaze);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.btnFacture);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnFacture;
        private System.Windows.Forms.Panel BtnConfig;
        private System.Windows.Forms.Panel BtnBackup;
    }
}