
namespace facturation
{
    partial class facturation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridFD = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICE_Destinateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_ajouterD = new System.Windows.Forms.Button();
            this.txtPrixUnitaire = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btn_modifierD = new System.Windows.Forms.Button();
            this.btn_SupprimerD = new System.Windows.Forms.Button();
            this.btnAjouterDF = new System.Windows.Forms.Button();
            this.btnSupprimerDF = new System.Windows.Forms.Button();
            this.btnModifierDF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTVA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSousTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ref = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnRechercherDF = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_reff = new System.Windows.Forms.ComboBox();
            this.txt_Destinateur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.DataGridDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_ligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ICE_Destinateur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblsous_totalToWords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetail)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridFD
            // 
            this.DataGridFD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridFD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridFD.BackgroundColor = System.Drawing.Color.White;
            this.DataGridFD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFD,
            this.Type,
            this.Reference,
            this.Date,
            this.Destinateur,
            this.ICE_Destinateur});
            this.DataGridFD.DoubleBuffered = true;
            this.DataGridFD.EnableHeadersVisualStyles = false;
            this.DataGridFD.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DataGridFD.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridFD.Location = new System.Drawing.Point(17, 96);
            this.DataGridFD.Name = "DataGridFD";
            this.DataGridFD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridFD.Size = new System.Drawing.Size(540, 307);
            this.DataGridFD.TabIndex = 36;
            this.DataGridFD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFD_CellClick);
            // 
            // idFD
            // 
            this.idFD.HeaderText = "idFD";
            this.idFD.Name = "idFD";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Destinateur
            // 
            this.Destinateur.HeaderText = "Destinateur";
            this.Destinateur.Name = "Destinateur";
            // 
            // ICE_Destinateur
            // 
            this.ICE_Destinateur.HeaderText = "ICE_Destinateur";
            this.ICE_Destinateur.Name = "ICE_Destinateur";
            // 
            // txtQuantite
            // 
            this.txtQuantite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuantite.ForeColor = System.Drawing.Color.Black;
            this.txtQuantite.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantite.HintText = "";
            this.txtQuantite.isPassword = false;
            this.txtQuantite.LineFocusedColor = System.Drawing.Color.White;
            this.txtQuantite.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantite.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtQuantite.LineThickness = 3;
            this.txtQuantite.Location = new System.Drawing.Point(605, 477);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(219, 34);
            this.txtQuantite.TabIndex = 41;
            this.txtQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ajouterD
            // 
            this.btn_ajouterD.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ajouterD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouterD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouterD.ForeColor = System.Drawing.Color.White;
            this.btn_ajouterD.Location = new System.Drawing.Point(877, 469);
            this.btn_ajouterD.Name = "btn_ajouterD";
            this.btn_ajouterD.Size = new System.Drawing.Size(217, 34);
            this.btn_ajouterD.TabIndex = 49;
            this.btn_ajouterD.Text = "Ajouter";
            this.btn_ajouterD.UseVisualStyleBackColor = false;
            this.btn_ajouterD.Click += new System.EventHandler(this.btn_ajouterD_Click);
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrixUnitaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixUnitaire.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrixUnitaire.ForeColor = System.Drawing.Color.Black;
            this.txtPrixUnitaire.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrixUnitaire.HintText = "";
            this.txtPrixUnitaire.isPassword = false;
            this.txtPrixUnitaire.LineFocusedColor = System.Drawing.Color.White;
            this.txtPrixUnitaire.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrixUnitaire.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtPrixUnitaire.LineThickness = 3;
            this.txtPrixUnitaire.Location = new System.Drawing.Point(607, 535);
            this.txtPrixUnitaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(219, 34);
            this.txtPrixUnitaire.TabIndex = 44;
            this.txtPrixUnitaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(607, 604);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(219, 100);
            this.txtDescription.TabIndex = 50;
            this.txtDescription.Text = "";
            // 
            // btn_modifierD
            // 
            this.btn_modifierD.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_modifierD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifierD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifierD.ForeColor = System.Drawing.Color.White;
            this.btn_modifierD.Location = new System.Drawing.Point(877, 510);
            this.btn_modifierD.Name = "btn_modifierD";
            this.btn_modifierD.Size = new System.Drawing.Size(217, 41);
            this.btn_modifierD.TabIndex = 54;
            this.btn_modifierD.Text = "maudifier";
            this.btn_modifierD.UseVisualStyleBackColor = false;
            // 
            // btn_SupprimerD
            // 
            this.btn_SupprimerD.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_SupprimerD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SupprimerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SupprimerD.ForeColor = System.Drawing.Color.White;
            this.btn_SupprimerD.Location = new System.Drawing.Point(877, 557);
            this.btn_SupprimerD.Name = "btn_SupprimerD";
            this.btn_SupprimerD.Size = new System.Drawing.Size(217, 41);
            this.btn_SupprimerD.TabIndex = 55;
            this.btn_SupprimerD.Text = "supprimer";
            this.btn_SupprimerD.UseVisualStyleBackColor = false;
            // 
            // btnAjouterDF
            // 
            this.btnAjouterDF.BackColor = System.Drawing.Color.Navy;
            this.btnAjouterDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterDF.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDF.Location = new System.Drawing.Point(604, 363);
            this.btnAjouterDF.Name = "btnAjouterDF";
            this.btnAjouterDF.Size = new System.Drawing.Size(224, 41);
            this.btnAjouterDF.TabIndex = 56;
            this.btnAjouterDF.Text = "ajouter";
            this.btnAjouterDF.UseVisualStyleBackColor = false;
            this.btnAjouterDF.Click += new System.EventHandler(this.btnAjouterDF_Click);
            // 
            // btnSupprimerDF
            // 
            this.btnSupprimerDF.BackColor = System.Drawing.Color.Navy;
            this.btnSupprimerDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerDF.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerDF.Location = new System.Drawing.Point(874, 362);
            this.btnSupprimerDF.Name = "btnSupprimerDF";
            this.btnSupprimerDF.Size = new System.Drawing.Size(224, 41);
            this.btnSupprimerDF.TabIndex = 57;
            this.btnSupprimerDF.Text = "supprimer";
            this.btnSupprimerDF.UseVisualStyleBackColor = false;
            // 
            // btnModifierDF
            // 
            this.btnModifierDF.BackColor = System.Drawing.Color.Navy;
            this.btnModifierDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifierDF.ForeColor = System.Drawing.Color.White;
            this.btnModifierDF.Location = new System.Drawing.Point(873, 315);
            this.btnModifierDF.Name = "btnModifierDF";
            this.btnModifierDF.Size = new System.Drawing.Size(224, 41);
            this.btnModifierDF.TabIndex = 58;
            this.btnModifierDF.Text = "maudifier";
            this.btnModifierDF.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(683, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Reference ";
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_date.BorderRadius = 1;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_date.ForeColor = System.Drawing.Color.White;
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date.FormatCustom = null;
            this.txt_date.Location = new System.Drawing.Point(607, 211);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(223, 35);
            this.txt_date.TabIndex = 61;
            this.txt_date.Value = new System.DateTime(2021, 3, 29, 14, 57, 2, 545);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(696, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Date";
            // 
            // minimaze
            // 
            this.minimaze.BackColor = System.Drawing.Color.Transparent;
            this.minimaze.BackgroundImage = global::facturation.Properties.Resources.minimize__1_;
            this.minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze.Location = new System.Drawing.Point(1019, 9);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(26, 29);
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
            this.close.Location = new System.Drawing.Point(1056, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 29);
            this.close.TabIndex = 14;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.minimaze);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 43);
            this.panel1.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::facturation.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTVA);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSousTotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(877, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 100);
            this.panel2.TabIndex = 70;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(95, 66);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(12, 18);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Total         :";
            // 
            // lblTVA
            // 
            this.lblTVA.AutoSize = true;
            this.lblTVA.BackColor = System.Drawing.Color.Transparent;
            this.lblTVA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTVA.ForeColor = System.Drawing.Color.White;
            this.lblTVA.Location = new System.Drawing.Point(95, 39);
            this.lblTVA.Name = "lblTVA";
            this.lblTVA.Size = new System.Drawing.Size(12, 17);
            this.lblTVA.TabIndex = 55;
            this.lblTVA.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "T.V.A         :";
            // 
            // lblSousTotal
            // 
            this.lblSousTotal.AutoSize = true;
            this.lblSousTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSousTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblSousTotal.ForeColor = System.Drawing.Color.White;
            this.lblSousTotal.Location = new System.Drawing.Point(95, 12);
            this.lblSousTotal.Name = "lblSousTotal";
            this.lblSousTotal.Size = new System.Drawing.Size(12, 17);
            this.lblSousTotal.TabIndex = 54;
            this.lblSousTotal.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sous-Total :";
            // 
            // txt_Ref
            // 
            this.txt_Ref.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Ref.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ref.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Ref.ForeColor = System.Drawing.Color.Black;
            this.txt_Ref.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Ref.HintText = "";
            this.txt_Ref.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Ref.isPassword = false;
            this.txt_Ref.LineFocusedColor = System.Drawing.Color.White;
            this.txt_Ref.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Ref.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_Ref.LineThickness = 3;
            this.txt_Ref.Location = new System.Drawing.Point(609, 159);
            this.txt_Ref.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ref.Name = "txt_Ref";
            this.txt_Ref.Size = new System.Drawing.Size(221, 33);
            this.txt_Ref.TabIndex = 83;
            this.txt_Ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(897, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 17);
            this.label10.TabIndex = 95;
            this.label10.Text = "Recheche par Reference:";
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.Navy;
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnImprimer.Location = new System.Drawing.Point(887, 246);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(200, 38);
            this.btnImprimer.TabIndex = 94;
            this.btnImprimer.Text = "imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnRechercherDF
            // 
            this.btnRechercherDF.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRechercherDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherDF.ForeColor = System.Drawing.Color.Aqua;
            this.btnRechercherDF.Location = new System.Drawing.Point(887, 197);
            this.btnRechercherDF.Name = "btnRechercherDF";
            this.btnRechercherDF.Size = new System.Drawing.Size(200, 38);
            this.btnRechercherDF.TabIndex = 91;
            this.btnRechercherDF.Text = "rechercher";
            this.btnRechercherDF.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Location = new System.Drawing.Point(875, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 3);
            this.panel3.TabIndex = 80;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Location = new System.Drawing.Point(875, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 3);
            this.panel4.TabIndex = 81;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Location = new System.Drawing.Point(874, 91);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 205);
            this.panel6.TabIndex = 97;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Cyan;
            this.panel7.Location = new System.Drawing.Point(1095, 92);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 205);
            this.panel7.TabIndex = 82;
            // 
            // txt_reff
            // 
            this.txt_reff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reff.FormattingEnabled = true;
            this.txt_reff.Location = new System.Drawing.Point(883, 140);
            this.txt_reff.Name = "txt_reff";
            this.txt_reff.Size = new System.Drawing.Size(204, 33);
            this.txt_reff.TabIndex = 98;
            // 
            // txt_Destinateur
            // 
            this.txt_Destinateur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Destinateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Destinateur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Destinateur.ForeColor = System.Drawing.Color.Black;
            this.txt_Destinateur.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Destinateur.HintText = "";
            this.txt_Destinateur.isPassword = false;
            this.txt_Destinateur.LineFocusedColor = System.Drawing.Color.White;
            this.txt_Destinateur.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Destinateur.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_Destinateur.LineThickness = 3;
            this.txt_Destinateur.Location = new System.Drawing.Point(607, 266);
            this.txt_Destinateur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Destinateur.Name = "txt_Destinateur";
            this.txt_Destinateur.Size = new System.Drawing.Size(222, 33);
            this.txt_Destinateur.TabIndex = 103;
            this.txt_Destinateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(679, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "Destinateur";
            // 
            // DataGridDetail
            // 
            this.DataGridDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridDetail.BackgroundColor = System.Drawing.Color.White;
            this.DataGridDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idT,
            this.Quantité,
            this.Description,
            this.prix_unitaire,
            this.Total_ligne});
            this.DataGridDetail.DoubleBuffered = true;
            this.DataGridDetail.EnableHeadersVisualStyles = false;
            this.DataGridDetail.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DataGridDetail.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridDetail.Location = new System.Drawing.Point(17, 439);
            this.DataGridDetail.Name = "DataGridDetail";
            this.DataGridDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridDetail.Size = new System.Drawing.Size(540, 316);
            this.DataGridDetail.TabIndex = 106;
            // 
            // idT
            // 
            this.idT.HeaderText = "idT";
            this.idT.Name = "idT";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // prix_unitaire
            // 
            this.prix_unitaire.HeaderText = "prix_unitaire";
            this.prix_unitaire.Name = "prix_unitaire";
            // 
            // Total_ligne
            // 
            this.Total_ligne.HeaderText = "Total_ligne";
            this.Total_ligne.Name = "Total_ligne";
            // 
            // txt_ICE_Destinateur
            // 
            this.txt_ICE_Destinateur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_ICE_Destinateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ICE_Destinateur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ICE_Destinateur.ForeColor = System.Drawing.Color.Black;
            this.txt_ICE_Destinateur.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ICE_Destinateur.HintText = "";
            this.txt_ICE_Destinateur.isPassword = false;
            this.txt_ICE_Destinateur.LineFocusedColor = System.Drawing.Color.White;
            this.txt_ICE_Destinateur.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ICE_Destinateur.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_ICE_Destinateur.LineThickness = 3;
            this.txt_ICE_Destinateur.Location = new System.Drawing.Point(603, 322);
            this.txt_ICE_Destinateur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ICE_Destinateur.Name = "txt_ICE_Destinateur";
            this.txt_ICE_Destinateur.Size = new System.Drawing.Size(226, 33);
            this.txt_ICE_Destinateur.TabIndex = 108;
            this.txt_ICE_Destinateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(658, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 107;
            this.label7.Text = "ICE De Destinateur";
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Items.AddRange(new object[] {
            "DEVIS",
            "FACTURE"});
            this.txt_type.Location = new System.Drawing.Point(644, 108);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(113, 28);
            this.txt_type.TabIndex = 110;
            this.txt_type.Text = "FACTURE";
            this.txt_type.SelectedIndexChanged += new System.EventHandler(this.txt_type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(696, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(681, 456);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 113;
            this.label13.Text = "Quantite";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(677, 580);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 112;
            this.label14.Text = "Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(675, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 111;
            this.label15.Text = "Prix unitaire";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(769, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 27);
            this.button1.TabIndex = 114;
            this.button1.Text = "REF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblsous_totalToWords);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(604, 721);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 34);
            this.panel5.TabIndex = 71;
            // 
            // lblsous_totalToWords
            // 
            this.lblsous_totalToWords.BackColor = System.Drawing.Color.Transparent;
            this.lblsous_totalToWords.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblsous_totalToWords.ForeColor = System.Drawing.Color.White;
            this.lblsous_totalToWords.Location = new System.Drawing.Point(3, 1);
            this.lblsous_totalToWords.Name = "lblsous_totalToWords";
            this.lblsous_totalToWords.Size = new System.Drawing.Size(487, 34);
            this.lblsous_totalToWords.TabIndex = 55;
            this.lblsous_totalToWords.Text = "..";
            this.lblsous_totalToWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::facturation.Properties.Resources.Sans_titre___3;
            this.ClientSize = new System.Drawing.Size(1116, 797);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ICE_Destinateur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataGridDetail);
            this.Controls.Add(this.txt_Destinateur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_reff);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnRechercherDF);
            this.Controls.Add(this.txt_Ref);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModifierDF);
            this.Controls.Add(this.btnSupprimerDF);
            this.Controls.Add(this.btnAjouterDF);
            this.Controls.Add(this.btn_SupprimerD);
            this.Controls.Add(this.btn_modifierD);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btn_ajouterD);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.DataGridFD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facturation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.facturation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetail)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridFD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantite;
        private System.Windows.Forms.Button btn_ajouterD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrixUnitaire;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btn_modifierD;
        private System.Windows.Forms.Button btn_SupprimerD;
        private System.Windows.Forms.Button btnAjouterDF;
        private System.Windows.Forms.Button btnSupprimerDF;
        private System.Windows.Forms.Button btnModifierDF;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker txt_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Ref;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnRechercherDF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox txt_reff;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Destinateur;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDetail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ICE_Destinateur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICE_Destinateur;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblTVA;
        public System.Windows.Forms.Label lblSousTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_unitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_ligne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label lblsous_totalToWords;
    }
}