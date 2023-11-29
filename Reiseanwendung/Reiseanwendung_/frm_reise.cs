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
    public partial class frm_reise : Form
    {
        // globale Datenfelder zum formularübergreifenden Speichern der Objekte
        // "static" erlaubt Zugriff von anderen Formularen über das Hauptformular auf das Feld
        public static Ort[] ortsListe = new Ort[6];
        public static Auto[] autoListe = new Auto[3];
        
        public frm_reise()
        {
            InitializeComponent();

            // Orte instanziieren
            ortsListe[0] = new Ort("Dresden", 51.0493286, 13.7381437);
            ortsListe[1] = new Ort("New York City", 40.712784, -74.005941);
            ortsListe[2] = new Ort("Tokyo", 35.6894875, 139.6917064);
            ortsListe[3] = new Ort("London", 51.5073509, -0.1277583);
            ortsListe[4] = new Ort("Moskau", 55.755826, 37.617300);
            ortsListe[5] = new Ort("Sidney", -33.867487, 151.206990);

            //Autos instanziieren
            autoListe[0] = new Auto("BMW", "M5", 700, 260);
            autoListe[1] = new Auto("Ferrari", "F40", 600, 320);
            autoListe[2] = new Auto("Sachsenring", "Trabant", 250, 60);

            orteAktualisieren();
            autosAktualisieren();
        }


        private void btn_ort_Click(object sender, EventArgs e)
        {
            frm_ort ort = new frm_ort();
            ort.Show();
            grB_auswahlOrt.Enabled = false;
            btn_ortAktualisieren.Visible = true;

        }
        private void btn_auto_Click(object sender, EventArgs e)
        {
            frm_auto auto = new frm_auto();
            auto.Show();
            grB_auswahlAuto.Enabled = false;
            btn_autoAktualisieren.Visible = true;
        }

        private void btn_datenAusgeben_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanziieren eines neuen Reiseobjekts
                Reise reise = new Reise(ortsListe[cB_startort.SelectedIndex], ortsListe[cB_zielort.SelectedIndex], autoListe[cB_auto.SelectedIndex]);

                // Speichern der Daten des Reiseobjekts in Variablen
                // Ortsdaten
                string startort = reise.getStartort().Name;
                string zielort = reise.getZielort().Name;
                double startBr = reise.getStartort().getBreitengrad();
                double startLae = reise.getStartort().getLaengengrad();
                double zielBr = reise.getZielort().getBreitengrad();
                double zielLae = reise.getZielort().getLaengengrad();
                // Autodaten
                string hersteller = reise.GetAuto().getHersteller();
                string modell = reise.GetAuto().getModell();
                int reichweite = reise.GetAuto().getReichweite();
                int geschwindigkeit = reise.GetAuto().getGeschwindigkeit();
                // Reisedaten
                double entfernung = reise.berechneEntfernung();
                double reisezeit = reise.berechneReisezeit(entfernung);

                // Ausgabe der Daten des Start- und Zielortes
                riTB_ausgabe.Text = "Startort:\n" + startort + "\nBreitengrad: " +
                    Math.Round(startBr, 6) + "\nLängengrad: " + Math.Round(startLae, 6) +
                    "\n\nZielort:\n" + zielort + "\nBreitengrad: " + Math.Round(zielBr, 6) +
                    "\nLängengrad: " + Math.Round(zielLae, 6) + "\n\nEntfernung:\n" +
                    Math.Round(entfernung).ToString() + " km";

                // Ausgabe der Daten des Autos
                riTB_ausgabe.Text += "\n\nAuto:\nHersteller: " + hersteller + "\nModell: " + modell +
                    "\nReichweite: " + reichweite + " km\nGeschwindigkeit: " + geschwindigkeit + " km/h";
                
                // Ausgabe der berechneten Reisezeit
                riTB_ausgabe.Text += "\n\nReisezeit: " + Math.Round(reisezeit, 2) + " h\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Oberflächensteuerung
        private void btn_ortaktualisieren_Click(object sender, EventArgs e)
        {
            orteAktualisieren();
            grB_auswahlOrt.Enabled = true;
            cB_startort.ResetText();
            cB_zielort.ResetText();
            btn_ortAktualisieren.Visible = false;
        }

        private void btn_autoaktualisieren_Click(object sender, EventArgs e)
        {
            autosAktualisieren();
            grB_auswahlAuto.Enabled = true;
            cB_auto.ResetText();
            btn_autoAktualisieren.Visible = false;
        }

        // Methode zum Aktualisieren der Orte im Forumlar
        private void orteAktualisieren()
        {
            cB_startort.Items.Clear();
            cB_zielort.Items.Clear();

            foreach (Ort ort in ortsListe)
            {
                cB_startort.Items.Add(ort.Name);
                cB_zielort.Items.Add(ort.Name);
            }
        }
        // Methode zum Aktualisieren der Orte im Forumlar
        private void autosAktualisieren()
        {
            cB_auto.Items.Clear();

            foreach (Auto auto in autoListe)
            {
                cB_auto.Items.Add(auto.getHersteller() + " " + auto.getModell());
            }
        }

        // Form schließen
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
