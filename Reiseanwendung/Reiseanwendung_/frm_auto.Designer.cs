namespace Reiseanwendung_
{
    partial class frm_auto
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
            this.tb_geschwindigkeit = new System.Windows.Forms.TextBox();
            this.tB_reichweite = new System.Windows.Forms.TextBox();
            this.tB_modell = new System.Windows.Forms.TextBox();
            this.tB_hersteller = new System.Windows.Forms.TextBox();
            this.lbl_geschwindigkeit = new System.Windows.Forms.Label();
            this.lbl_reichweite = new System.Windows.Forms.Label();
            this.lbl_modell = new System.Windows.Forms.Label();
            this.lbl_Hersteller = new System.Windows.Forms.Label();
            this.lbl_Auto = new System.Windows.Forms.Label();
            this.btn_autoHinzufuegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_geschwindigkeit
            // 
            this.tb_geschwindigkeit.Location = new System.Drawing.Point(155, 164);
            this.tb_geschwindigkeit.Name = "tb_geschwindigkeit";
            this.tb_geschwindigkeit.Size = new System.Drawing.Size(100, 20);
            this.tb_geschwindigkeit.TabIndex = 24;
            // 
            // tB_reichweite
            // 
            this.tB_reichweite.Location = new System.Drawing.Point(155, 128);
            this.tB_reichweite.Name = "tB_reichweite";
            this.tB_reichweite.Size = new System.Drawing.Size(100, 20);
            this.tB_reichweite.TabIndex = 23;
            // 
            // tB_modell
            // 
            this.tB_modell.Location = new System.Drawing.Point(155, 95);
            this.tB_modell.Name = "tB_modell";
            this.tB_modell.Size = new System.Drawing.Size(100, 20);
            this.tB_modell.TabIndex = 22;
            // 
            // tB_hersteller
            // 
            this.tB_hersteller.Location = new System.Drawing.Point(155, 58);
            this.tB_hersteller.Name = "tB_hersteller";
            this.tB_hersteller.Size = new System.Drawing.Size(100, 20);
            this.tB_hersteller.TabIndex = 21;
            // 
            // lbl_geschwindigkeit
            // 
            this.lbl_geschwindigkeit.AutoSize = true;
            this.lbl_geschwindigkeit.Location = new System.Drawing.Point(26, 167);
            this.lbl_geschwindigkeit.Name = "lbl_geschwindigkeit";
            this.lbl_geschwindigkeit.Size = new System.Drawing.Size(88, 13);
            this.lbl_geschwindigkeit.TabIndex = 20;
            this.lbl_geschwindigkeit.Text = "Geschwindigkeit:";
            // 
            // lbl_reichweite
            // 
            this.lbl_reichweite.AutoSize = true;
            this.lbl_reichweite.Location = new System.Drawing.Point(26, 132);
            this.lbl_reichweite.Name = "lbl_reichweite";
            this.lbl_reichweite.Size = new System.Drawing.Size(63, 13);
            this.lbl_reichweite.TabIndex = 19;
            this.lbl_reichweite.Text = "Reichweite:";
            // 
            // lbl_modell
            // 
            this.lbl_modell.AutoSize = true;
            this.lbl_modell.Location = new System.Drawing.Point(26, 98);
            this.lbl_modell.Name = "lbl_modell";
            this.lbl_modell.Size = new System.Drawing.Size(41, 13);
            this.lbl_modell.TabIndex = 18;
            this.lbl_modell.Text = "Modell:";
            // 
            // lbl_Hersteller
            // 
            this.lbl_Hersteller.AutoSize = true;
            this.lbl_Hersteller.Location = new System.Drawing.Point(26, 61);
            this.lbl_Hersteller.Name = "lbl_Hersteller";
            this.lbl_Hersteller.Size = new System.Drawing.Size(54, 13);
            this.lbl_Hersteller.TabIndex = 17;
            this.lbl_Hersteller.Text = "Hersteller:";
            // 
            // lbl_Auto
            // 
            this.lbl_Auto.AutoSize = true;
            this.lbl_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Auto.Location = new System.Drawing.Point(25, 20);
            this.lbl_Auto.Name = "lbl_Auto";
            this.lbl_Auto.Size = new System.Drawing.Size(100, 18);
            this.lbl_Auto.TabIndex = 15;
            this.lbl_Auto.Text = "Neues Auto:";
            // 
            // btn_autoHinzufuegen
            // 
            this.btn_autoHinzufuegen.Location = new System.Drawing.Point(29, 210);
            this.btn_autoHinzufuegen.Name = "btn_autoHinzufuegen";
            this.btn_autoHinzufuegen.Size = new System.Drawing.Size(226, 33);
            this.btn_autoHinzufuegen.TabIndex = 16;
            this.btn_autoHinzufuegen.Text = "Auto hinzufügen";
            this.btn_autoHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_autoHinzufuegen.Click += new System.EventHandler(this.btn_autoHinzufuegen_Click);
            // 
            // frm_auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 275);
            this.Controls.Add(this.tb_geschwindigkeit);
            this.Controls.Add(this.tB_reichweite);
            this.Controls.Add(this.tB_modell);
            this.Controls.Add(this.tB_hersteller);
            this.Controls.Add(this.lbl_geschwindigkeit);
            this.Controls.Add(this.lbl_reichweite);
            this.Controls.Add(this.lbl_modell);
            this.Controls.Add(this.lbl_Hersteller);
            this.Controls.Add(this.lbl_Auto);
            this.Controls.Add(this.btn_autoHinzufuegen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_auto";
            this.Text = "frm_auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_reichweite;
        private System.Windows.Forms.TextBox tB_modell;
        private System.Windows.Forms.TextBox tB_hersteller;
        private System.Windows.Forms.Label lbl_geschwindigkeit;
        private System.Windows.Forms.Label lbl_reichweite;
        private System.Windows.Forms.Label lbl_modell;
        private System.Windows.Forms.Label lbl_Hersteller;
        private System.Windows.Forms.Label lbl_Auto;
        private System.Windows.Forms.Button btn_autoHinzufuegen;
        private System.Windows.Forms.TextBox tb_geschwindigkeit;
    }
}