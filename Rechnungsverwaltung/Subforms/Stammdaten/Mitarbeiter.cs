using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datenbankverwaltung;

namespace Rechnungsverwaltung
{
    public partial class Abteilungen : Form
    {
        List<Dictionary<string, object>> abteilungen;

        public Abteilungen(BEARBEITUNGSMODUS modus)
        {
            InitializeComponent();

            abteilungen = DB.SqlRead("SELECT abt_nr, abt_bez FROM abteilung");
            foreach (var item in abteilungen)
            {
                comboBox1.Items.Add(item["abt_bez"]);
            }

            if (modus == BEARBEITUNGSMODUS.HINZUFÜGEN) btnHinzu.Visible = true;
            if (modus == BEARBEITUNGSMODUS.BEARBEITEN) btnBea.Visible = true;
            if (modus == BEARBEITUNGSMODUS.DEAKTIVIEREN) btnDeak.Visible = true;
        }

        private void btnHinzu_Click(object sender, EventArgs e)
        {

        }
    }
}
