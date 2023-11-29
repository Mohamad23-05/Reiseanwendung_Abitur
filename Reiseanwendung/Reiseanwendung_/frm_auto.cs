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
    public partial class frm_auto : Form
    {
        public frm_auto()
        {
            InitializeComponent();
        }

        // Speichern eines Autos anhand der Formulareingaben in der globalen Autoliste
        private void btn_autoHinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                Auto auto = new Auto(tB_hersteller.Text, tB_modell.Text, Convert.ToInt32(tB_reichweite.Text), Convert.ToInt32(tb_geschwindigkeit.Text));

                Array.Resize(ref frm_reise.autoListe, frm_reise.autoListe.Length + 1);
                frm_reise.autoListe[frm_reise.autoListe.Length - 1] = auto;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
