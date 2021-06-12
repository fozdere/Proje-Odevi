namespace MuzikCalar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Muzik_sec = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chk_tekrarla = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tck_bas = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tck_tiz = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_muzik = new System.Windows.Forms.GroupBox();
            this.lbl_pozisyon_sn = new System.Windows.Forms.Label();
            this.lbl_toplam_sn = new System.Windows.Forms.Label();
            this.tck_muzik_durum = new System.Windows.Forms.TrackBar();
            this.chk_karistir = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tck_ana_ses = new System.Windows.Forms.TrackBar();
            this.btn_rastgele = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_muzik_durdur = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_liste_temizle = new System.Windows.Forms.Button();
            this.btn_muzik_oynat = new System.Windows.Forms.Button();
            this.btn_duraklat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müzikSeçToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müzikSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_Muzik_Liste = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_muzik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Muzik_sec
            // 
            this.btn_Muzik_sec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Muzik_sec.Image = ((System.Drawing.Image)(resources.GetObject("btn_Muzik_sec.Image")));
            this.btn_Muzik_sec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Muzik_sec.Location = new System.Drawing.Point(0, 0);
            this.btn_Muzik_sec.Name = "btn_Muzik_sec";
            this.btn_Muzik_sec.Size = new System.Drawing.Size(370, 89);
            this.btn_Muzik_sec.TabIndex = 2;
            this.btn_Muzik_sec.Text = "Oynatma Listesi Oluştur";
            this.btn_Muzik_sec.UseVisualStyleBackColor = true;
            this.btn_Muzik_sec.Click += new System.EventHandler(this.btn_Muzik_sec_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chk_tekrarla);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.chk_karistir);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_rastgele);
            this.splitContainer1.Panel1.Controls.Add(this.btn_sonraki);
            this.splitContainer1.Panel1.Controls.Add(this.btn_muzik_durdur);
            this.splitContainer1.Panel1.Controls.Add(this.btn_onceki);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_muzik_oynat);
            this.splitContainer1.Panel1.Controls.Add(this.btn_duraklat);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.list_Muzik_Liste);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 662);
            this.splitContainer1.SplitterDistance = 693;
            this.splitContainer1.TabIndex = 7;
            // 
            // chk_tekrarla
            // 
            this.chk_tekrarla.AutoSize = true;
            this.chk_tekrarla.Location = new System.Drawing.Point(511, 496);
            this.chk_tekrarla.Name = "chk_tekrarla";
            this.chk_tekrarla.Size = new System.Drawing.Size(129, 21);
            this.chk_tekrarla.TabIndex = 37;
            this.chk_tekrarla.Text = "Şarkıyı Tekrarla";
            this.chk_tekrarla.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tck_bas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tck_tiz);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(119, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 441);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ses Efekt";
            // 
            // tck_bas
            // 
            this.tck_bas.Location = new System.Drawing.Point(6, 21);
            this.tck_bas.Maximum = 100;
            this.tck_bas.Name = "tck_bas";
            this.tck_bas.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_bas.Size = new System.Drawing.Size(56, 385);
            this.tck_bas.TabIndex = 21;
            this.tck_bas.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_bas.Value = 100;
            this.tck_bas.Scroll += new System.EventHandler(this.tck_bas_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bas";
            // 
            // tck_tiz
            // 
            this.tck_tiz.Location = new System.Drawing.Point(99, 24);
            this.tck_tiz.Maximum = 100;
            this.tck_tiz.Name = "tck_tiz";
            this.tck_tiz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_tiz.Size = new System.Drawing.Size(56, 382);
            this.tck_tiz.TabIndex = 24;
            this.tck_tiz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_tiz.Value = 100;
            this.tck_tiz.Scroll += new System.EventHandler(this.tck_tiz_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tiz";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_muzik);
            this.panel1.Location = new System.Drawing.Point(7, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 90);
            this.panel1.TabIndex = 8;
            // 
            // grp_muzik
            // 
            this.grp_muzik.Controls.Add(this.lbl_pozisyon_sn);
            this.grp_muzik.Controls.Add(this.lbl_toplam_sn);
            this.grp_muzik.Controls.Add(this.tck_muzik_durum);
            this.grp_muzik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_muzik.Location = new System.Drawing.Point(0, 3);
            this.grp_muzik.Name = "grp_muzik";
            this.grp_muzik.Size = new System.Drawing.Size(686, 87);
            this.grp_muzik.TabIndex = 34;
            this.grp_muzik.TabStop = false;
            this.grp_muzik.Text = "Çalan Müzik : ...";
            // 
            // lbl_pozisyon_sn
            // 
            this.lbl_pozisyon_sn.AutoSize = true;
            this.lbl_pozisyon_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pozisyon_sn.Location = new System.Drawing.Point(591, 65);
            this.lbl_pozisyon_sn.Name = "lbl_pozisyon_sn";
            this.lbl_pozisyon_sn.Size = new System.Drawing.Size(64, 17);
            this.lbl_pozisyon_sn.TabIndex = 30;
            this.lbl_pozisyon_sn.Text = "00:00:00";
            this.lbl_pozisyon_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_toplam_sn
            // 
            this.lbl_toplam_sn.AutoSize = true;
            this.lbl_toplam_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplam_sn.Location = new System.Drawing.Point(515, 65);
            this.lbl_toplam_sn.Name = "lbl_toplam_sn";
            this.lbl_toplam_sn.Size = new System.Drawing.Size(64, 17);
            this.lbl_toplam_sn.TabIndex = 31;
            this.lbl_toplam_sn.Text = "00:00:00";
            this.lbl_toplam_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tck_muzik_durum
            // 
            this.tck_muzik_durum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tck_muzik_durum.Location = new System.Drawing.Point(6, 21);
            this.tck_muzik_durum.Maximum = 500;
            this.tck_muzik_durum.Name = "tck_muzik_durum";
            this.tck_muzik_durum.Size = new System.Drawing.Size(674, 56);
            this.tck_muzik_durum.TabIndex = 4;
            this.tck_muzik_durum.Scroll += new System.EventHandler(this.tck_muzik_durum_Scroll);
            // 
            // chk_karistir
            // 
            this.chk_karistir.AutoSize = true;
            this.chk_karistir.Location = new System.Drawing.Point(388, 496);
            this.chk_karistir.Name = "chk_karistir";
            this.chk_karistir.Size = new System.Drawing.Size(74, 21);
            this.chk_karistir.TabIndex = 36;
            this.chk_karistir.Text = "Karıştır";
            this.chk_karistir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tck_ana_ses);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 443);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ana Ses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ana Ses";
            // 
            // tck_ana_ses
            // 
            this.tck_ana_ses.Location = new System.Drawing.Point(6, 22);
            this.tck_ana_ses.Maximum = 100;
            this.tck_ana_ses.Name = "tck_ana_ses";
            this.tck_ana_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_ana_ses.Size = new System.Drawing.Size(56, 385);
            this.tck_ana_ses.TabIndex = 12;
            this.tck_ana_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_ana_ses.Value = 100;
            this.tck_ana_ses.Scroll += new System.EventHandler(this.tck_ana_ses_Scroll);
            // 
            // btn_rastgele
            // 
            this.btn_rastgele.BackColor = System.Drawing.Color.Transparent;
            this.btn_rastgele.Enabled = false;
            this.btn_rastgele.FlatAppearance.BorderSize = 0;
            this.btn_rastgele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rastgele.Image = ((System.Drawing.Image)(resources.GetObject("btn_rastgele.Image")));
            this.btn_rastgele.Location = new System.Drawing.Point(535, 119);
            this.btn_rastgele.Name = "btn_rastgele";
            this.btn_rastgele.Size = new System.Drawing.Size(75, 75);
            this.btn_rastgele.TabIndex = 35;
            this.btn_rastgele.UseVisualStyleBackColor = false;
            this.btn_rastgele.Click += new System.EventHandler(this.btn_rastgele_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackColor = System.Drawing.Color.Transparent;
            this.btn_sonraki.Enabled = false;
            this.btn_sonraki.FlatAppearance.BorderSize = 0;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Image = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.Image")));
            this.btn_sonraki.Location = new System.Drawing.Point(535, 342);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(74, 65);
            this.btn_sonraki.TabIndex = 32;
            this.btn_sonraki.UseVisualStyleBackColor = false;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_muzik_durdur
            // 
            this.btn_muzik_durdur.BackColor = System.Drawing.Color.Transparent;
            this.btn_muzik_durdur.Enabled = false;
            this.btn_muzik_durdur.FlatAppearance.BorderSize = 0;
            this.btn_muzik_durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_durdur.Image = ((System.Drawing.Image)(resources.GetObject("btn_muzik_durdur.Image")));
            this.btn_muzik_durdur.Location = new System.Drawing.Point(534, 223);
            this.btn_muzik_durdur.Name = "btn_muzik_durdur";
            this.btn_muzik_durdur.Size = new System.Drawing.Size(75, 75);
            this.btn_muzik_durdur.TabIndex = 4;
            this.btn_muzik_durdur.UseVisualStyleBackColor = false;
            this.btn_muzik_durdur.Click += new System.EventHandler(this.btn_muzik_durdur_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.BackColor = System.Drawing.Color.Transparent;
            this.btn_onceki.Enabled = false;
            this.btn_onceki.FlatAppearance.BorderSize = 0;
            this.btn_onceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onceki.Image = ((System.Drawing.Image)(resources.GetObject("btn_onceki.Image")));
            this.btn_onceki.Location = new System.Drawing.Point(387, 342);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(75, 75);
            this.btn_onceki.TabIndex = 33;
            this.btn_onceki.UseVisualStyleBackColor = false;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Muzik_sec);
            this.panel2.Controls.Add(this.btn_liste_temizle);
            this.panel2.Location = new System.Drawing.Point(1, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 89);
            this.panel2.TabIndex = 6;
            // 
            // btn_liste_temizle
            // 
            this.btn_liste_temizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_liste_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_liste_temizle.Image")));
            this.btn_liste_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_liste_temizle.Location = new System.Drawing.Point(377, 0);
            this.btn_liste_temizle.Name = "btn_liste_temizle";
            this.btn_liste_temizle.Size = new System.Drawing.Size(312, 89);
            this.btn_liste_temizle.TabIndex = 3;
            this.btn_liste_temizle.Text = "Listeyi Temizle";
            this.btn_liste_temizle.UseVisualStyleBackColor = true;
            this.btn_liste_temizle.Click += new System.EventHandler(this.btn_liste_temizle_Click);
            // 
            // btn_muzik_oynat
            // 
            this.btn_muzik_oynat.BackColor = System.Drawing.Color.Transparent;
            this.btn_muzik_oynat.Enabled = false;
            this.btn_muzik_oynat.FlatAppearance.BorderSize = 0;
            this.btn_muzik_oynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_oynat.Image = ((System.Drawing.Image)(resources.GetObject("btn_muzik_oynat.Image")));
            this.btn_muzik_oynat.Location = new System.Drawing.Point(387, 124);
            this.btn_muzik_oynat.Name = "btn_muzik_oynat";
            this.btn_muzik_oynat.Size = new System.Drawing.Size(75, 75);
            this.btn_muzik_oynat.TabIndex = 3;
            this.btn_muzik_oynat.UseVisualStyleBackColor = false;
            this.btn_muzik_oynat.Click += new System.EventHandler(this.btn_muzik_oynat_Click);
            // 
            // btn_duraklat
            // 
            this.btn_duraklat.BackColor = System.Drawing.Color.Transparent;
            this.btn_duraklat.Enabled = false;
            this.btn_duraklat.FlatAppearance.BorderSize = 0;
            this.btn_duraklat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duraklat.Image = ((System.Drawing.Image)(resources.GetObject("btn_duraklat.Image")));
            this.btn_duraklat.Location = new System.Drawing.Point(387, 223);
            this.btn_duraklat.Name = "btn_duraklat";
            this.btn_duraklat.Size = new System.Drawing.Size(75, 75);
            this.btn_duraklat.TabIndex = 7;
            this.btn_duraklat.UseVisualStyleBackColor = false;
            this.btn_duraklat.Click += new System.EventHandler(this.btn_duraklat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müzikSeçToolStripMenuItem1,
            this.listeyiTemizleToolStripMenuItem,
            this.listeyiKaydetToolStripMenuItem,
            this.müzikSeçToolStripMenuItem,
            this.hakkımdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // müzikSeçToolStripMenuItem1
            // 
            this.müzikSeçToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("müzikSeçToolStripMenuItem1.Image")));
            this.müzikSeçToolStripMenuItem1.Name = "müzikSeçToolStripMenuItem1";
            this.müzikSeçToolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.müzikSeçToolStripMenuItem1.Text = "Müzik Seç";
            this.müzikSeçToolStripMenuItem1.Click += new System.EventHandler(this.müzikSeçToolStripMenuItem1_Click);
            // 
            // listeyiTemizleToolStripMenuItem
            // 
            this.listeyiTemizleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeyiTemizleToolStripMenuItem.Image")));
            this.listeyiTemizleToolStripMenuItem.Name = "listeyiTemizleToolStripMenuItem";
            this.listeyiTemizleToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.listeyiTemizleToolStripMenuItem.Text = "Listeyi Temizle";
            this.listeyiTemizleToolStripMenuItem.Click += new System.EventHandler(this.listeyiTemizleToolStripMenuItem_Click);
            // 
            // listeyiKaydetToolStripMenuItem
            // 
            this.listeyiKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeyiKaydetToolStripMenuItem.Image")));
            this.listeyiKaydetToolStripMenuItem.Name = "listeyiKaydetToolStripMenuItem";
            this.listeyiKaydetToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.listeyiKaydetToolStripMenuItem.Text = "Listeyi Kaydet";
            this.listeyiKaydetToolStripMenuItem.Click += new System.EventHandler(this.listeyiKaydetToolStripMenuItem_Click);
            // 
            // müzikSeçToolStripMenuItem
            // 
            this.müzikSeçToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müzikSeçToolStripMenuItem.Image")));
            this.müzikSeçToolStripMenuItem.Name = "müzikSeçToolStripMenuItem";
            this.müzikSeçToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.müzikSeçToolStripMenuItem.Text = "Kayıtlı Listeyi Aç";
            this.müzikSeçToolStripMenuItem.Click += new System.EventHandler(this.müzikSeçToolStripMenuItem_Click);
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakkımdaToolStripMenuItem.Image")));
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            this.hakkımdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // list_Muzik_Liste
            // 
            this.list_Muzik_Liste.ContextMenuStrip = this.contextMenuStrip1;
            this.list_Muzik_Liste.Dock = System.Windows.Forms.DockStyle.Right;
            this.list_Muzik_Liste.FormattingEnabled = true;
            this.list_Muzik_Liste.ItemHeight = 16;
            this.list_Muzik_Liste.Location = new System.Drawing.Point(3, 0);
            this.list_Muzik_Liste.Name = "list_Muzik_Liste";
            this.list_Muzik_Liste.Size = new System.Drawing.Size(415, 662);
            this.list_Muzik_Liste.TabIndex = 5;
            this.list_Muzik_Liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.list_Muzik_Liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.list_Muzik_Liste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Musik_Liste_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 662);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Müzik Çalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grp_muzik.ResumeLayout(false);
            this.grp_muzik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Muzik_sec;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar tck_ana_ses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tck_tiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tck_bas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_liste_temizle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btn_muzik_oynat;
        private System.Windows.Forms.Button btn_duraklat;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_muzik_durdur;
        private System.Windows.Forms.GroupBox grp_muzik;
        private System.Windows.Forms.Label lbl_toplam_sn;
        private System.Windows.Forms.Label lbl_pozisyon_sn;
        private System.Windows.Forms.TrackBar tck_muzik_durum;
        private System.Windows.Forms.Button btn_rastgele;
        private System.Windows.Forms.CheckBox chk_karistir;
        private System.Windows.Forms.CheckBox chk_tekrarla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_Muzik_Liste;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müzikSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeyiTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeyiKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müzikSeçToolStripMenuItem1;
    }
}