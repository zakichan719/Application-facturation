
namespace facturation
{
    partial class configuration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.txtRC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIF = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_NomSociete = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSiegeSocial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txt_Ref = new System.Windows.Forms.ComboBox();
            this.txt_abrv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.minimaze);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 47);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::facturation.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(47, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::facturation.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(1014, 6);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(31, 33);
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
            this.close.Location = new System.Drawing.Point(1064, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 33);
            this.close.TabIndex = 14;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtRC
            // 
            this.txtRC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRC.ForeColor = System.Drawing.Color.Black;
            this.txtRC.HintForeColor = System.Drawing.Color.Empty;
            this.txtRC.HintText = "";
            this.txtRC.isPassword = false;
            this.txtRC.LineFocusedColor = System.Drawing.Color.White;
            this.txtRC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRC.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtRC.LineThickness = 3;
            this.txtRC.Location = new System.Drawing.Point(549, 396);
            this.txtRC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRC.Name = "txtRC";
            this.txtRC.Size = new System.Drawing.Size(281, 41);
            this.txtRC.TabIndex = 17;
            this.txtRC.Text = "RC";
            this.txtRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRC.Enter += new System.EventHandler(this.txtRC_Enter);
            this.txtRC.Leave += new System.EventHandler(this.txtRC_Leave);
            // 
            // txtIF
            // 
            this.txtIF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIF.ForeColor = System.Drawing.Color.Black;
            this.txtIF.HintForeColor = System.Drawing.Color.Empty;
            this.txtIF.HintText = "";
            this.txtIF.isPassword = false;
            this.txtIF.LineFocusedColor = System.Drawing.Color.White;
            this.txtIF.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIF.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtIF.LineThickness = 3;
            this.txtIF.Location = new System.Drawing.Point(549, 449);
            this.txtIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtIF.Name = "txtIF";
            this.txtIF.Size = new System.Drawing.Size(281, 41);
            this.txtIF.TabIndex = 18;
            this.txtIF.Text = "IF";
            this.txtIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIF.Enter += new System.EventHandler(this.txtIF_Enter);
            this.txtIF.Leave += new System.EventHandler(this.txtIF_Leave);
            // 
            // txtICE
            // 
            this.txtICE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtICE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtICE.ForeColor = System.Drawing.Color.Black;
            this.txtICE.HintForeColor = System.Drawing.Color.Empty;
            this.txtICE.HintText = "";
            this.txtICE.isPassword = false;
            this.txtICE.LineFocusedColor = System.Drawing.Color.White;
            this.txtICE.LineIdleColor = System.Drawing.Color.Gray;
            this.txtICE.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtICE.LineThickness = 3;
            this.txtICE.Location = new System.Drawing.Point(550, 504);
            this.txtICE.Margin = new System.Windows.Forms.Padding(4);
            this.txtICE.Name = "txtICE";
            this.txtICE.Size = new System.Drawing.Size(280, 41);
            this.txtICE.TabIndex = 21;
            this.txtICE.Text = "ICE";
            this.txtICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtICE.Enter += new System.EventHandler(this.txtICE_Enter);
            this.txtICE.Leave += new System.EventHandler(this.txtICE_Leave);
            // 
            // txt_NomSociete
            // 
            this.txt_NomSociete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_NomSociete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomSociete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NomSociete.ForeColor = System.Drawing.Color.Black;
            this.txt_NomSociete.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NomSociete.HintText = "";
            this.txt_NomSociete.isPassword = false;
            this.txt_NomSociete.LineFocusedColor = System.Drawing.Color.White;
            this.txt_NomSociete.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NomSociete.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_NomSociete.LineThickness = 3;
            this.txt_NomSociete.Location = new System.Drawing.Point(550, 222);
            this.txt_NomSociete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomSociete.Name = "txt_NomSociete";
            this.txt_NomSociete.Size = new System.Drawing.Size(280, 41);
            this.txt_NomSociete.TabIndex = 22;
            this.txt_NomSociete.Text = "Nom de Societe";
            this.txt_NomSociete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NomSociete.Enter += new System.EventHandler(this.txt_NomSociete_Enter);
            this.txt_NomSociete.Leave += new System.EventHandler(this.txt_NomSociete_Leave);
            // 
            // txtSiegeSocial
            // 
            this.txtSiegeSocial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSiegeSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSiegeSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSiegeSocial.ForeColor = System.Drawing.Color.Black;
            this.txtSiegeSocial.HintForeColor = System.Drawing.Color.Empty;
            this.txtSiegeSocial.HintText = "";
            this.txtSiegeSocial.isPassword = false;
            this.txtSiegeSocial.LineFocusedColor = System.Drawing.Color.White;
            this.txtSiegeSocial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSiegeSocial.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSiegeSocial.LineThickness = 3;
            this.txtSiegeSocial.Location = new System.Drawing.Point(550, 281);
            this.txtSiegeSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSiegeSocial.Name = "txtSiegeSocial";
            this.txtSiegeSocial.Size = new System.Drawing.Size(280, 41);
            this.txtSiegeSocial.TabIndex = 23;
            this.txtSiegeSocial.Text = "Siege Social";
            this.txtSiegeSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSiegeSocial.Enter += new System.EventHandler(this.txtSiegeSocial_Enter);
            this.txtSiegeSocial.Leave += new System.EventHandler(this.txtSiegeSocial_Leave);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(550, 575);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(280, 61);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "Ajouter  |  Maudifier";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txt_Ref
            // 
            this.txt_Ref.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Ref.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ref.FormattingEnabled = true;
            this.txt_Ref.Items.AddRange(new object[] {
            "(F ou D)-Annee-000001"});
            this.txt_Ref.Location = new System.Drawing.Point(176, 278);
            this.txt_Ref.Name = "txt_Ref";
            this.txt_Ref.Size = new System.Drawing.Size(281, 29);
            this.txt_Ref.TabIndex = 93;
            this.txt_Ref.Text = "            Chaine de reference";
            this.txt_Ref.Enter += new System.EventHandler(this.txt_Ref_Enter);
            this.txt_Ref.Leave += new System.EventHandler(this.txt_Ref_Leave);
            // 
            // txt_abrv
            // 
            this.txt_abrv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_abrv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_abrv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_abrv.ForeColor = System.Drawing.Color.Black;
            this.txt_abrv.HintForeColor = System.Drawing.Color.Empty;
            this.txt_abrv.HintText = "";
            this.txt_abrv.isPassword = false;
            this.txt_abrv.LineFocusedColor = System.Drawing.Color.White;
            this.txt_abrv.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_abrv.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_abrv.LineThickness = 3;
            this.txt_abrv.Location = new System.Drawing.Point(176, 224);
            this.txt_abrv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_abrv.Name = "txt_abrv";
            this.txt_abrv.Size = new System.Drawing.Size(201, 41);
            this.txt_abrv.TabIndex = 94;
            this.txt_abrv.Text = "Abriviation Nom de Societe";
            this.txt_abrv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_abrv.Enter += new System.EventHandler(this.txt_abrv_Enter);
            this.txt_abrv.Leave += new System.EventHandler(this.txt_abrv_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(409, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 41);
            this.button2.TabIndex = 95;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_telephone
            // 
            this.txt_telephone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_telephone.ForeColor = System.Drawing.Color.Black;
            this.txt_telephone.HintForeColor = System.Drawing.Color.Empty;
            this.txt_telephone.HintText = "";
            this.txt_telephone.isPassword = false;
            this.txt_telephone.LineFocusedColor = System.Drawing.Color.White;
            this.txt_telephone.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_telephone.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_telephone.LineThickness = 3;
            this.txt_telephone.Location = new System.Drawing.Point(549, 340);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(281, 41);
            this.txt_telephone.TabIndex = 97;
            this.txt_telephone.Text = "Telephone";
            this.txt_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telephone.Enter += new System.EventHandler(this.txt_telephone_Enter);
            this.txt_telephone.Leave += new System.EventHandler(this.txt_telephone_Leave);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.Location = new System.Drawing.Point(176, 379);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(281, 131);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 99;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(176, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 61);
            this.button1.TabIndex = 100;
            this.button1.Text = "ajouter logo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::facturation.Properties.Resources.Sans_titre___3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1116, 788);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIF);
            this.Controls.Add(this.txt_abrv);
            this.Controls.Add(this.txtRC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Ref);
            this.Controls.Add(this.txtSiegeSocial);
            this.Controls.Add(this.txtICE);
            this.Controls.Add(this.txt_NomSociete);
            this.Controls.Add(this.btnAjouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuration";
            this.Load += new System.EventHandler(this.configuration_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIF;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtICE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NomSociete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSiegeSocial;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox txt_Ref;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_abrv;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_telephone;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}