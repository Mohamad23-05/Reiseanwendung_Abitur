namespace Reiseanwendung_
{
    partial class frm_ort
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
            this.linklbl_koordinaten = new System.Windows.Forms.LinkLabel();
            this.tB_ortsName = new System.Windows.Forms.TextBox();
            this.lbl_ortsName = new System.Windows.Forms.Label();
            this.btn_ortHinzufuegen = new System.Windows.Forms.Button();
            this.gb_koordinaten = new System.Windows.Forms.GroupBox();
            this.rB_e2 = new System.Windows.Forms.RadioButton();
            this.rB_e1 = new System.Windows.Forms.RadioButton();
            this.lbl_sek = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_gr = new System.Windows.Forms.Label();
            this.gB_laeGr = new System.Windows.Forms.GroupBox();
            this.lbl_hinweis2 = new System.Windows.Forms.Label();
            this.lbl_laeGr = new System.Windows.Forms.Label();
            this.lbl_laeSek = new System.Windows.Forms.Label();
            this.lbl_laeMin = new System.Windows.Forms.Label();
            this.tB_laeGr = new System.Windows.Forms.TextBox();
            this.rB_ost = new System.Windows.Forms.RadioButton();
            this.rB_west = new System.Windows.Forms.RadioButton();
            this.tB_laeMin = new System.Windows.Forms.TextBox();
            this.tB_laeSek = new System.Windows.Forms.TextBox();
            this.gB_brGr = new System.Windows.Forms.GroupBox();
            this.lbl_hinweis1 = new System.Windows.Forms.Label();
            this.lbl_brMin = new System.Windows.Forms.Label();
            this.lbl_brGr = new System.Windows.Forms.Label();
            this.rB_nord = new System.Windows.Forms.RadioButton();
            this.lbl_brSek = new System.Windows.Forms.Label();
            this.rB_sued = new System.Windows.Forms.RadioButton();
            this.tB_brGr = new System.Windows.Forms.TextBox();
            this.tB_brMin = new System.Windows.Forms.TextBox();
            this.tB_brSek = new System.Windows.Forms.TextBox();
            this.gB_dezGr = new System.Windows.Forms.GroupBox();
            this.lbl_hinweis3 = new System.Windows.Forms.Label();
            this.lbl_hinweis4 = new System.Windows.Forms.Label();
            this.tB_laeGrE2 = new System.Windows.Forms.TextBox();
            this.tB_brGrE2 = new System.Windows.Forms.TextBox();
            this.lbl_brGrE2 = new System.Windows.Forms.Label();
            this.lbl_laeGrE2 = new System.Windows.Forms.Label();
            this.gb_koordinaten.SuspendLayout();
            this.gB_laeGr.SuspendLayout();
            this.gB_brGr.SuspendLayout();
            this.gB_dezGr.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklbl_koordinaten
            // 
            this.linklbl_koordinaten.AccessibleName = "";
            this.linklbl_koordinaten.AutoSize = true;
            this.linklbl_koordinaten.Location = new System.Drawing.Point(357, 33);
            this.linklbl_koordinaten.Name = "linklbl_koordinaten";
            this.linklbl_koordinaten.Size = new System.Drawing.Size(140, 16);
            this.linklbl_koordinaten.TabIndex = 14;
            this.linklbl_koordinaten.TabStop = true;
            this.linklbl_koordinaten.Text = "-->GPS Koordinaten<--";
            this.linklbl_koordinaten.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_koordinaten_LinkClicked);
            // 
            // tB_ortsName
            // 
            this.tB_ortsName.Location = new System.Drawing.Point(134, 30);
            this.tB_ortsName.Margin = new System.Windows.Forms.Padding(4);
            this.tB_ortsName.Name = "tB_ortsName";
            this.tB_ortsName.Size = new System.Drawing.Size(197, 22);
            this.tB_ortsName.TabIndex = 13;
            // 
            // lbl_ortsName
            // 
            this.lbl_ortsName.AutoSize = true;
            this.lbl_ortsName.Location = new System.Drawing.Point(23, 33);
            this.lbl_ortsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ortsName.Name = "lbl_ortsName";
            this.lbl_ortsName.Size = new System.Drawing.Size(68, 16);
            this.lbl_ortsName.TabIndex = 12;
            this.lbl_ortsName.Text = "Ortsname:";
            // 
            // btn_ortHinzufuegen
            // 
            this.btn_ortHinzufuegen.Location = new System.Drawing.Point(26, 479);
            this.btn_ortHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ortHinzufuegen.Name = "btn_ortHinzufuegen";
            this.btn_ortHinzufuegen.Size = new System.Drawing.Size(771, 57);
            this.btn_ortHinzufuegen.TabIndex = 11;
            this.btn_ortHinzufuegen.Text = "Ort hinzufügen";
            this.btn_ortHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_ortHinzufuegen.Click += new System.EventHandler(this.btn_ortHinzufuegen_Click);
            // 
            // gb_koordinaten
            // 
            this.gb_koordinaten.Controls.Add(this.rB_e2);
            this.gb_koordinaten.Controls.Add(this.rB_e1);
            this.gb_koordinaten.Controls.Add(this.lbl_sek);
            this.gb_koordinaten.Controls.Add(this.lbl_min);
            this.gb_koordinaten.Controls.Add(this.lbl_gr);
            this.gb_koordinaten.Controls.Add(this.gB_laeGr);
            this.gb_koordinaten.Controls.Add(this.gB_brGr);
            this.gb_koordinaten.Controls.Add(this.gB_dezGr);
            this.gb_koordinaten.Location = new System.Drawing.Point(26, 85);
            this.gb_koordinaten.Margin = new System.Windows.Forms.Padding(4);
            this.gb_koordinaten.Name = "gb_koordinaten";
            this.gb_koordinaten.Padding = new System.Windows.Forms.Padding(4);
            this.gb_koordinaten.Size = new System.Drawing.Size(771, 386);
            this.gb_koordinaten.TabIndex = 10;
            this.gb_koordinaten.TabStop = false;
            this.gb_koordinaten.Text = "Koordinaten Startort";
            // 
            // rB_e2
            // 
            this.rB_e2.AutoSize = true;
            this.rB_e2.Location = new System.Drawing.Point(23, 287);
            this.rB_e2.Margin = new System.Windows.Forms.Padding(4);
            this.rB_e2.Name = "rB_e2";
            this.rB_e2.Size = new System.Drawing.Size(17, 16);
            this.rB_e2.TabIndex = 26;
            this.rB_e2.TabStop = true;
            this.rB_e2.UseVisualStyleBackColor = true;
            this.rB_e2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rB_e1
            // 
            this.rB_e1.AutoSize = true;
            this.rB_e1.Checked = true;
            this.rB_e1.Location = new System.Drawing.Point(23, 102);
            this.rB_e1.Margin = new System.Windows.Forms.Padding(4);
            this.rB_e1.Name = "rB_e1";
            this.rB_e1.Size = new System.Drawing.Size(17, 16);
            this.rB_e1.TabIndex = 25;
            this.rB_e1.TabStop = true;
            this.rB_e1.UseVisualStyleBackColor = true;
            this.rB_e1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // lbl_sek
            // 
            this.lbl_sek.AutoSize = true;
            this.lbl_sek.Location = new System.Drawing.Point(632, 37);
            this.lbl_sek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sek.Name = "lbl_sek";
            this.lbl_sek.Size = new System.Drawing.Size(77, 16);
            this.lbl_sek.TabIndex = 14;
            this.lbl_sek.Text = "Sekunden \'\'";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(503, 37);
            this.lbl_min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(52, 16);
            this.lbl_min.TabIndex = 13;
            this.lbl_min.Text = "Minute \'";
            // 
            // lbl_gr
            // 
            this.lbl_gr.AutoSize = true;
            this.lbl_gr.Location = new System.Drawing.Point(376, 37);
            this.lbl_gr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gr.Name = "lbl_gr";
            this.lbl_gr.Size = new System.Drawing.Size(44, 16);
            this.lbl_gr.TabIndex = 12;
            this.lbl_gr.Text = "Grad °";
            // 
            // gB_laeGr
            // 
            this.gB_laeGr.Controls.Add(this.lbl_hinweis2);
            this.gB_laeGr.Controls.Add(this.lbl_laeGr);
            this.gB_laeGr.Controls.Add(this.lbl_laeSek);
            this.gB_laeGr.Controls.Add(this.lbl_laeMin);
            this.gB_laeGr.Controls.Add(this.tB_laeGr);
            this.gB_laeGr.Controls.Add(this.rB_ost);
            this.gB_laeGr.Controls.Add(this.rB_west);
            this.gB_laeGr.Controls.Add(this.tB_laeMin);
            this.gB_laeGr.Controls.Add(this.tB_laeSek);
            this.gB_laeGr.Location = new System.Drawing.Point(72, 138);
            this.gB_laeGr.Margin = new System.Windows.Forms.Padding(4);
            this.gB_laeGr.Name = "gB_laeGr";
            this.gB_laeGr.Padding = new System.Windows.Forms.Padding(4);
            this.gB_laeGr.Size = new System.Drawing.Size(675, 82);
            this.gB_laeGr.TabIndex = 24;
            this.gB_laeGr.TabStop = false;
            this.gB_laeGr.Text = "Längengrad";
            // 
            // lbl_hinweis2
            // 
            this.lbl_hinweis2.AutoSize = true;
            this.lbl_hinweis2.Location = new System.Drawing.Point(316, 44);
            this.lbl_hinweis2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hinweis2.Name = "lbl_hinweis2";
            this.lbl_hinweis2.Size = new System.Drawing.Size(53, 16);
            this.lbl_hinweis2.TabIndex = 34;
            this.lbl_hinweis2.Text = "[0 - 180]";
            // 
            // lbl_laeGr
            // 
            this.lbl_laeGr.AutoSize = true;
            this.lbl_laeGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laeGr.Location = new System.Drawing.Point(393, 12);
            this.lbl_laeGr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_laeGr.Name = "lbl_laeGr";
            this.lbl_laeGr.Size = new System.Drawing.Size(20, 25);
            this.lbl_laeGr.TabIndex = 16;
            this.lbl_laeGr.Text = "°";
            // 
            // lbl_laeSek
            // 
            this.lbl_laeSek.AutoSize = true;
            this.lbl_laeSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laeSek.Location = new System.Drawing.Point(655, 16);
            this.lbl_laeSek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_laeSek.Name = "lbl_laeSek";
            this.lbl_laeSek.Size = new System.Drawing.Size(20, 25);
            this.lbl_laeSek.TabIndex = 20;
            this.lbl_laeSek.Text = "\'\'";
            // 
            // lbl_laeMin
            // 
            this.lbl_laeMin.AutoSize = true;
            this.lbl_laeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laeMin.Location = new System.Drawing.Point(521, 12);
            this.lbl_laeMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_laeMin.Name = "lbl_laeMin";
            this.lbl_laeMin.Size = new System.Drawing.Size(16, 25);
            this.lbl_laeMin.TabIndex = 17;
            this.lbl_laeMin.Text = "\'";
            // 
            // tB_laeGr
            // 
            this.tB_laeGr.Location = new System.Drawing.Point(308, 16);
            this.tB_laeGr.Margin = new System.Windows.Forms.Padding(4);
            this.tB_laeGr.Name = "tB_laeGr";
            this.tB_laeGr.Size = new System.Drawing.Size(76, 22);
            this.tB_laeGr.TabIndex = 5;
            // 
            // rB_ost
            // 
            this.rB_ost.AutoSize = true;
            this.rB_ost.Location = new System.Drawing.Point(195, 16);
            this.rB_ost.Margin = new System.Windows.Forms.Padding(4);
            this.rB_ost.Name = "rB_ost";
            this.rB_ost.Size = new System.Drawing.Size(37, 20);
            this.rB_ost.TabIndex = 9;
            this.rB_ost.Text = "E";
            this.rB_ost.UseVisualStyleBackColor = true;
            // 
            // rB_west
            // 
            this.rB_west.AutoSize = true;
            this.rB_west.Checked = true;
            this.rB_west.Location = new System.Drawing.Point(128, 16);
            this.rB_west.Margin = new System.Windows.Forms.Padding(4);
            this.rB_west.Name = "rB_west";
            this.rB_west.Size = new System.Drawing.Size(41, 20);
            this.rB_west.TabIndex = 8;
            this.rB_west.TabStop = true;
            this.rB_west.Text = "W";
            this.rB_west.UseVisualStyleBackColor = true;
            // 
            // tB_laeMin
            // 
            this.tB_laeMin.Location = new System.Drawing.Point(435, 16);
            this.tB_laeMin.Margin = new System.Windows.Forms.Padding(4);
            this.tB_laeMin.Name = "tB_laeMin";
            this.tB_laeMin.Size = new System.Drawing.Size(77, 22);
            this.tB_laeMin.TabIndex = 6;
            // 
            // tB_laeSek
            // 
            this.tB_laeSek.Location = new System.Drawing.Point(564, 16);
            this.tB_laeSek.Margin = new System.Windows.Forms.Padding(4);
            this.tB_laeSek.Name = "tB_laeSek";
            this.tB_laeSek.Size = new System.Drawing.Size(89, 22);
            this.tB_laeSek.TabIndex = 7;
            // 
            // gB_brGr
            // 
            this.gB_brGr.Controls.Add(this.lbl_hinweis1);
            this.gB_brGr.Controls.Add(this.lbl_brMin);
            this.gB_brGr.Controls.Add(this.lbl_brGr);
            this.gB_brGr.Controls.Add(this.rB_nord);
            this.gB_brGr.Controls.Add(this.lbl_brSek);
            this.gB_brGr.Controls.Add(this.rB_sued);
            this.gB_brGr.Controls.Add(this.tB_brGr);
            this.gB_brGr.Controls.Add(this.tB_brMin);
            this.gB_brGr.Controls.Add(this.tB_brSek);
            this.gB_brGr.Location = new System.Drawing.Point(72, 57);
            this.gB_brGr.Margin = new System.Windows.Forms.Padding(4);
            this.gB_brGr.Name = "gB_brGr";
            this.gB_brGr.Padding = new System.Windows.Forms.Padding(4);
            this.gB_brGr.Size = new System.Drawing.Size(675, 74);
            this.gB_brGr.TabIndex = 23;
            this.gB_brGr.TabStop = false;
            this.gB_brGr.Text = "Breitengrad";
            // 
            // lbl_hinweis1
            // 
            this.lbl_hinweis1.AutoSize = true;
            this.lbl_hinweis1.Location = new System.Drawing.Point(316, 44);
            this.lbl_hinweis1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hinweis1.Name = "lbl_hinweis1";
            this.lbl_hinweis1.Size = new System.Drawing.Size(46, 16);
            this.lbl_hinweis1.TabIndex = 33;
            this.lbl_hinweis1.Text = "[0 - 90]";
            // 
            // lbl_brMin
            // 
            this.lbl_brMin.AutoSize = true;
            this.lbl_brMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brMin.Location = new System.Drawing.Point(521, 12);
            this.lbl_brMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brMin.Name = "lbl_brMin";
            this.lbl_brMin.Size = new System.Drawing.Size(16, 25);
            this.lbl_brMin.TabIndex = 18;
            this.lbl_brMin.Text = "\'";
            // 
            // lbl_brGr
            // 
            this.lbl_brGr.AutoSize = true;
            this.lbl_brGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brGr.Location = new System.Drawing.Point(393, 14);
            this.lbl_brGr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brGr.Name = "lbl_brGr";
            this.lbl_brGr.Size = new System.Drawing.Size(20, 25);
            this.lbl_brGr.TabIndex = 15;
            this.lbl_brGr.Text = "°";
            // 
            // rB_nord
            // 
            this.rB_nord.AutoSize = true;
            this.rB_nord.Checked = true;
            this.rB_nord.Location = new System.Drawing.Point(128, 16);
            this.rB_nord.Margin = new System.Windows.Forms.Padding(4);
            this.rB_nord.Name = "rB_nord";
            this.rB_nord.Size = new System.Drawing.Size(38, 20);
            this.rB_nord.TabIndex = 3;
            this.rB_nord.TabStop = true;
            this.rB_nord.Text = "N";
            this.rB_nord.UseVisualStyleBackColor = true;
            // 
            // lbl_brSek
            // 
            this.lbl_brSek.AutoSize = true;
            this.lbl_brSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brSek.Location = new System.Drawing.Point(655, 12);
            this.lbl_brSek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brSek.Name = "lbl_brSek";
            this.lbl_brSek.Size = new System.Drawing.Size(20, 25);
            this.lbl_brSek.TabIndex = 19;
            this.lbl_brSek.Text = "\'\'";
            // 
            // rB_sued
            // 
            this.rB_sued.AutoSize = true;
            this.rB_sued.Location = new System.Drawing.Point(195, 16);
            this.rB_sued.Margin = new System.Windows.Forms.Padding(4);
            this.rB_sued.Name = "rB_sued";
            this.rB_sued.Size = new System.Drawing.Size(37, 20);
            this.rB_sued.TabIndex = 4;
            this.rB_sued.Text = "S";
            this.rB_sued.UseVisualStyleBackColor = true;
            // 
            // tB_brGr
            // 
            this.tB_brGr.Location = new System.Drawing.Point(308, 16);
            this.tB_brGr.Margin = new System.Windows.Forms.Padding(4);
            this.tB_brGr.Name = "tB_brGr";
            this.tB_brGr.Size = new System.Drawing.Size(76, 22);
            this.tB_brGr.TabIndex = 0;
            // 
            // tB_brMin
            // 
            this.tB_brMin.Location = new System.Drawing.Point(435, 16);
            this.tB_brMin.Margin = new System.Windows.Forms.Padding(4);
            this.tB_brMin.Name = "tB_brMin";
            this.tB_brMin.Size = new System.Drawing.Size(77, 22);
            this.tB_brMin.TabIndex = 1;
            // 
            // tB_brSek
            // 
            this.tB_brSek.Location = new System.Drawing.Point(564, 16);
            this.tB_brSek.Margin = new System.Windows.Forms.Padding(4);
            this.tB_brSek.Name = "tB_brSek";
            this.tB_brSek.Size = new System.Drawing.Size(89, 22);
            this.tB_brSek.TabIndex = 2;
            // 
            // gB_dezGr
            // 
            this.gB_dezGr.Controls.Add(this.lbl_hinweis3);
            this.gB_dezGr.Controls.Add(this.lbl_hinweis4);
            this.gB_dezGr.Controls.Add(this.tB_laeGrE2);
            this.gB_dezGr.Controls.Add(this.tB_brGrE2);
            this.gB_dezGr.Controls.Add(this.lbl_brGrE2);
            this.gB_dezGr.Controls.Add(this.lbl_laeGrE2);
            this.gB_dezGr.Enabled = false;
            this.gB_dezGr.Location = new System.Drawing.Point(72, 241);
            this.gB_dezGr.Margin = new System.Windows.Forms.Padding(4);
            this.gB_dezGr.Name = "gB_dezGr";
            this.gB_dezGr.Padding = new System.Windows.Forms.Padding(4);
            this.gB_dezGr.Size = new System.Drawing.Size(675, 122);
            this.gB_dezGr.TabIndex = 29;
            this.gB_dezGr.TabStop = false;
            this.gB_dezGr.Text = "Eingabe Dezimalgrad";
            // 
            // lbl_hinweis3
            // 
            this.lbl_hinweis3.AutoSize = true;
            this.lbl_hinweis3.Location = new System.Drawing.Point(385, 39);
            this.lbl_hinweis3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hinweis3.Name = "lbl_hinweis3";
            this.lbl_hinweis3.Size = new System.Drawing.Size(71, 16);
            this.lbl_hinweis3.TabIndex = 32;
            this.lbl_hinweis3.Text = "[-90 bis 90]";
            // 
            // lbl_hinweis4
            // 
            this.lbl_hinweis4.AutoSize = true;
            this.lbl_hinweis4.Location = new System.Drawing.Point(385, 81);
            this.lbl_hinweis4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hinweis4.Name = "lbl_hinweis4";
            this.lbl_hinweis4.Size = new System.Drawing.Size(85, 16);
            this.lbl_hinweis4.TabIndex = 31;
            this.lbl_hinweis4.Text = "[-180 bis 180]";
            // 
            // tB_laeGrE2
            // 
            this.tB_laeGrE2.Location = new System.Drawing.Point(175, 78);
            this.tB_laeGrE2.Margin = new System.Windows.Forms.Padding(4);
            this.tB_laeGrE2.Name = "tB_laeGrE2";
            this.tB_laeGrE2.Size = new System.Drawing.Size(165, 22);
            this.tB_laeGrE2.TabIndex = 30;
            // 
            // tB_brGrE2
            // 
            this.tB_brGrE2.Location = new System.Drawing.Point(175, 36);
            this.tB_brGrE2.Margin = new System.Windows.Forms.Padding(4);
            this.tB_brGrE2.Name = "tB_brGrE2";
            this.tB_brGrE2.Size = new System.Drawing.Size(165, 22);
            this.tB_brGrE2.TabIndex = 29;
            // 
            // lbl_brGrE2
            // 
            this.lbl_brGrE2.AutoSize = true;
            this.lbl_brGrE2.Location = new System.Drawing.Point(20, 39);
            this.lbl_brGrE2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brGrE2.Name = "lbl_brGrE2";
            this.lbl_brGrE2.Size = new System.Drawing.Size(80, 16);
            this.lbl_brGrE2.TabIndex = 27;
            this.lbl_brGrE2.Text = "Breitengrad:";
            // 
            // lbl_laeGrE2
            // 
            this.lbl_laeGrE2.AutoSize = true;
            this.lbl_laeGrE2.Location = new System.Drawing.Point(20, 81);
            this.lbl_laeGrE2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_laeGrE2.Name = "lbl_laeGrE2";
            this.lbl_laeGrE2.Size = new System.Drawing.Size(83, 16);
            this.lbl_laeGrE2.TabIndex = 28;
            this.lbl_laeGrE2.Text = "Längengrad:";
            // 
            // frm_ort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 563);
            this.Controls.Add(this.linklbl_koordinaten);
            this.Controls.Add(this.tB_ortsName);
            this.Controls.Add(this.lbl_ortsName);
            this.Controls.Add(this.btn_ortHinzufuegen);
            this.Controls.Add(this.gb_koordinaten);
            this.Name = "frm_ort";
            this.Text = "frm_ort";
            this.gb_koordinaten.ResumeLayout(false);
            this.gb_koordinaten.PerformLayout();
            this.gB_laeGr.ResumeLayout(false);
            this.gB_laeGr.PerformLayout();
            this.gB_brGr.ResumeLayout(false);
            this.gB_brGr.PerformLayout();
            this.gB_dezGr.ResumeLayout(false);
            this.gB_dezGr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_koordinaten;
        private System.Windows.Forms.TextBox tB_ortsName;
        private System.Windows.Forms.Label lbl_ortsName;
        private System.Windows.Forms.Button btn_ortHinzufuegen;
        private System.Windows.Forms.GroupBox gb_koordinaten;
        private System.Windows.Forms.RadioButton rB_e2;
        private System.Windows.Forms.RadioButton rB_e1;
        private System.Windows.Forms.Label lbl_sek;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_gr;
        private System.Windows.Forms.GroupBox gB_laeGr;
        private System.Windows.Forms.Label lbl_hinweis2;
        private System.Windows.Forms.Label lbl_laeGr;
        private System.Windows.Forms.Label lbl_laeSek;
        private System.Windows.Forms.Label lbl_laeMin;
        private System.Windows.Forms.TextBox tB_laeGr;
        private System.Windows.Forms.RadioButton rB_ost;
        private System.Windows.Forms.RadioButton rB_west;
        private System.Windows.Forms.TextBox tB_laeMin;
        private System.Windows.Forms.TextBox tB_laeSek;
        private System.Windows.Forms.GroupBox gB_brGr;
        private System.Windows.Forms.Label lbl_hinweis1;
        private System.Windows.Forms.Label lbl_brMin;
        private System.Windows.Forms.Label lbl_brGr;
        private System.Windows.Forms.RadioButton rB_nord;
        private System.Windows.Forms.Label lbl_brSek;
        private System.Windows.Forms.RadioButton rB_sued;
        private System.Windows.Forms.TextBox tB_brGr;
        private System.Windows.Forms.TextBox tB_brMin;
        private System.Windows.Forms.TextBox tB_brSek;
        private System.Windows.Forms.GroupBox gB_dezGr;
        private System.Windows.Forms.Label lbl_hinweis3;
        private System.Windows.Forms.Label lbl_hinweis4;
        private System.Windows.Forms.TextBox tB_laeGrE2;
        private System.Windows.Forms.TextBox tB_brGrE2;
        private System.Windows.Forms.Label lbl_brGrE2;
        private System.Windows.Forms.Label lbl_laeGrE2;
    }
}