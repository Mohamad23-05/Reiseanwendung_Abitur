using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reiseanwendung_
{
    public partial class frm_ort : Form
    {
        public frm_ort()
        {
            InitializeComponent();
        }

        // Methode zum Instanziieren eines neuen Ortes
        private void btn_ortHinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                Ort ort = new Ort(tB_ortsName.Text);

                // Initialisieren der Attribute abhängig von gewählter Eingabemethode im Formular
                if (rB_e1.Checked)
                {
                    if (rB_nord.Checked)
                        ort.setBreitengrad(format('N', Convert.ToInt32(tB_brGr.Text), Convert.ToInt32(tB_brMin.Text), Convert.ToDouble(tB_brSek.Text)));
                    else
                        ort.setBreitengrad(format('S', Convert.ToInt32(tB_brGr.Text), Convert.ToInt32(tB_brMin.Text), Convert.ToDouble(tB_brSek.Text)));

                    if (rB_west.Checked)
                        ort.setLaengengrad(format('W', Convert.ToInt32(tB_laeGr.Text), Convert.ToInt32(tB_laeMin.Text), Convert.ToDouble(tB_laeSek.Text)));
                    else
                        ort.setLaengengrad(format('E', Convert.ToInt32(tB_laeGr.Text), Convert.ToInt32(tB_laeMin.Text), Convert.ToDouble(tB_laeSek.Text)));
                }
                if (rB_e2.Checked)
                {
                    ort.setBreitengrad(Convert.ToDouble(tB_brGrE2.Text.Replace(".",",")));
                    ort.setLaengengrad(Convert.ToDouble(tB_laeGrE2.Text.Replace(".",",")));
                }

                // Ortsobjekt in Array ortsListe speichern
                Array.Resize(ref frm_reise.ortsListe, frm_reise.ortsListe.Length + 1);
                frm_reise.ortsListe[frm_reise.ortsListe.Length - 1] = ort;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Methode zur Umrechnung in Dezimal-Koordinaten
        private double format(char richtung, int grad, int min, double sek)
        {
            if (richtung == 'N' || richtung == 'E')
                return grad + (min / 60) + (sek / 3600);
            else if (richtung == 'S' || richtung == 'W')
                return (-1 * grad) - (min / 60) - (sek / 3600);
            else
                return 0;
        }

        // Formularsteuerung
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rB_e2.Checked)
            {
                gB_dezGr.Enabled = true;
                lbl_gr.Enabled = false;
                lbl_min.Enabled = false;
                lbl_sek.Enabled = false;
                gB_brGr.Enabled = false;
                gB_laeGr.Enabled = false;
            }
            else
            {
                gB_dezGr.Enabled = false;
                lbl_gr.Enabled = true;
                lbl_min.Enabled = true;
                lbl_sek.Enabled = true;
                gB_brGr.Enabled = true;
                gB_laeGr.Enabled = true;
            }
        }

        // Methode für Internet-Link
        private void linklbl_koordinaten_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gpskoordinaten.de/");
        }
    }
}
