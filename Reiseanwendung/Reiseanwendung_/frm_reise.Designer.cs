namespace Reiseanwendung_
{
    partial class frm_reise
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_autoAktualisieren = new System.Windows.Forms.Button();
            this.grB_auswahlAuto = new System.Windows.Forms.GroupBox();
            this.lbl_auto = new System.Windows.Forms.Label();
            this.btn_auto = new System.Windows.Forms.Button();
            this.cB_auto = new System.Windows.Forms.ComboBox();
            this.btn_ortAktualisieren = new System.Windows.Forms.Button();
            this.grB_auswahlOrt = new System.Windows.Forms.GroupBox();
            this.lbl_startort = new System.Windows.Forms.Label();
            this.lbl_zielort = new System.Windows.Forms.Label();
            this.cB_startort = new System.Windows.Forms.ComboBox();
            this.btn_ort = new System.Windows.Forms.Button();
            this.cB_zielort = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.riTB_ausgabe = new System.Windows.Forms.RichTextBox();
            this.btn_datenAusgeben = new System.Windows.Forms.Button();
            this.grB_auswahlAuto.SuspendLayout();
            this.grB_auswahlOrt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_autoAktualisieren
            // 
            this.btn_autoAktualisieren.Location = new System.Drawing.Point(512, 19);
            this.btn_autoAktualisieren.Name = "btn_autoAktualisieren";
            this.btn_autoAktualisieren.Size = new System.Drawing.Size(70, 27);
            this.btn_autoAktualisieren.TabIndex = 14;
            this.btn_autoAktualisieren.Text = "Update";
            this.btn_autoAktualisieren.UseVisualStyleBackColor = true;
            this.btn_autoAktualisieren.Visible = false;
            this.btn_autoAktualisieren.Click += new System.EventHandler(this.btn_autoaktualisieren_Click);
            // 
            // grB_auswahlAuto
            // 
            this.grB_auswahlAuto.Controls.Add(this.lbl_auto);
            this.grB_auswahlAuto.Controls.Add(this.btn_auto);
            this.grB_auswahlAuto.Controls.Add(this.cB_auto);
            this.grB_auswahlAuto.Location = new System.Drawing.Point(318, 51);
            this.grB_auswahlAuto.Name = "grB_auswahlAuto";
            this.grB_auswahlAuto.Size = new System.Drawing.Size(264, 174);
            this.grB_auswahlAuto.TabIndex = 13;
            this.grB_auswahlAuto.TabStop = false;
            this.grB_auswahlAuto.Text = "Auswahl des Autos:";
            // 
            // lbl_auto
            // 
            this.lbl_auto.AutoSize = true;
            this.lbl_auto.Location = new System.Drawing.Point(15, 60);
            this.lbl_auto.Name = "lbl_auto";
            this.lbl_auto.Size = new System.Drawing.Size(32, 13);
            this.lbl_auto.TabIndex = 5;
            this.lbl_auto.Text = "Auto:";
            // 
            // btn_auto
            // 
            this.btn_auto.Location = new System.Drawing.Point(18, 123);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(214, 33);
            this.btn_auto.TabIndex = 6;
            this.btn_auto.Text = "Auto hinzufügen";
            this.btn_auto.UseVisualStyleBackColor = true;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // cB_auto
            // 
            this.cB_auto.FormattingEnabled = true;
            this.cB_auto.Location = new System.Drawing.Point(96, 60);
            this.cB_auto.Name = "cB_auto";
            this.cB_auto.Size = new System.Drawing.Size(136, 21);
            this.cB_auto.TabIndex = 4;
            // 
            // btn_ortAktualisieren
            // 
            this.btn_ortAktualisieren.Location = new System.Drawing.Point(209, 19);
            this.btn_ortAktualisieren.Name = "btn_ortAktualisieren";
            this.btn_ortAktualisieren.Size = new System.Drawing.Size(70, 27);
            this.btn_ortAktualisieren.TabIndex = 11;
            this.btn_ortAktualisieren.Text = "Update";
            this.btn_ortAktualisieren.UseVisualStyleBackColor = true;
            this.btn_ortAktualisieren.Visible = false;
            this.btn_ortAktualisieren.Click += new System.EventHandler(this.btn_ortaktualisieren_Click);
            // 
            // grB_auswahlOrt
            // 
            this.grB_auswahlOrt.Controls.Add(this.lbl_startort);
            this.grB_auswahlOrt.Controls.Add(this.lbl_zielort);
            this.grB_auswahlOrt.Controls.Add(this.cB_startort);
            this.grB_auswahlOrt.Controls.Add(this.btn_ort);
            this.grB_auswahlOrt.Controls.Add(this.cB_zielort);
            this.grB_auswahlOrt.Location = new System.Drawing.Point(15, 51);
            this.grB_auswahlOrt.Name = "grB_auswahlOrt";
            this.grB_auswahlOrt.Size = new System.Drawing.Size(264, 174);
            this.grB_auswahlOrt.TabIndex = 12;
            this.grB_auswahlOrt.TabStop = false;
            this.grB_auswahlOrt.Text = "Auswahl des Star- und Zielorts";
            // 
            // lbl_startort
            // 
            this.lbl_startort.AutoSize = true;
            this.lbl_startort.Location = new System.Drawing.Point(15, 41);
            this.lbl_startort.Name = "lbl_startort";
            this.lbl_startort.Size = new System.Drawing.Size(44, 13);
            this.lbl_startort.TabIndex = 3;
            this.lbl_startort.Text = "Startort:";
            // 
            // lbl_zielort
            // 
            this.lbl_zielort.AutoSize = true;
            this.lbl_zielort.Location = new System.Drawing.Point(15, 85);
            this.lbl_zielort.Name = "lbl_zielort";
            this.lbl_zielort.Size = new System.Drawing.Size(36, 13);
            this.lbl_zielort.TabIndex = 5;
            this.lbl_zielort.Text = "Zielort";
            // 
            // cB_startort
            // 
            this.cB_startort.FormattingEnabled = true;
            this.cB_startort.Location = new System.Drawing.Point(96, 38);
            this.cB_startort.Name = "cB_startort";
            this.cB_startort.Size = new System.Drawing.Size(136, 21);
            this.cB_startort.TabIndex = 2;
            // 
            // btn_ort
            // 
            this.btn_ort.Location = new System.Drawing.Point(18, 123);
            this.btn_ort.Name = "btn_ort";
            this.btn_ort.Size = new System.Drawing.Size(214, 33);
            this.btn_ort.TabIndex = 6;
            this.btn_ort.Text = "Ort hinzufügen";
            this.btn_ort.UseVisualStyleBackColor = true;
            this.btn_ort.Click += new System.EventHandler(this.btn_ort_Click);
            // 
            // cB_zielort
            // 
            this.cB_zielort.FormattingEnabled = true;
            this.cB_zielort.Location = new System.Drawing.Point(96, 82);
            this.cB_zielort.Name = "cB_zielort";
            this.cB_zielort.Size = new System.Drawing.Size(136, 21);
            this.cB_zielort.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(336, 492);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(214, 37);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // riTB_ausgabe
            // 
            this.riTB_ausgabe.Location = new System.Drawing.Point(15, 240);
            this.riTB_ausgabe.Name = "riTB_ausgabe";
            this.riTB_ausgabe.Size = new System.Drawing.Size(568, 235);
            this.riTB_ausgabe.TabIndex = 16;
            this.riTB_ausgabe.Text = "";
            // 
            // btn_datenAusgeben
            // 
            this.btn_datenAusgeben.Location = new System.Drawing.Point(33, 492);
            this.btn_datenAusgeben.Name = "btn_datenAusgeben";
            this.btn_datenAusgeben.Size = new System.Drawing.Size(214, 37);
            this.btn_datenAusgeben.TabIndex = 15;
            this.btn_datenAusgeben.Text = "Daten ausgeben";
            this.btn_datenAusgeben.UseVisualStyleBackColor = true;
            this.btn_datenAusgeben.Click += new System.EventHandler(this.btn_datenAusgeben_Click);
            // 
            // frm_reise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 542);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.riTB_ausgabe);
            this.Controls.Add(this.btn_datenAusgeben);
            this.Controls.Add(this.btn_autoAktualisieren);
            this.Controls.Add(this.grB_auswahlAuto);
            this.Controls.Add(this.btn_ortAktualisieren);
            this.Controls.Add(this.grB_auswahlOrt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_reise";
            this.grB_auswahlAuto.ResumeLayout(false);
            this.grB_auswahlAuto.PerformLayout();
            this.grB_auswahlOrt.ResumeLayout(false);
            this.grB_auswahlOrt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_autoAktualisieren;
        private System.Windows.Forms.GroupBox grB_auswahlAuto;
        private System.Windows.Forms.Label lbl_auto;
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.ComboBox cB_auto;
        private System.Windows.Forms.Button btn_ortAktualisieren;
        private System.Windows.Forms.GroupBox grB_auswahlOrt;
        private System.Windows.Forms.Label lbl_startort;
        private System.Windows.Forms.Label lbl_zielort;
        private System.Windows.Forms.ComboBox cB_startort;
        private System.Windows.Forms.Button btn_ort;
        private System.Windows.Forms.ComboBox cB_zielort;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox riTB_ausgabe;
        private System.Windows.Forms.Button btn_datenAusgeben;
    }
}

