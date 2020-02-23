using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rechnungsverwaltung {
    public partial class StammdatenSelect : Form {
        public StammdatenSelect()
        {
            InitializeComponent();
        }

        private void mitHinz_Click(object sender, EventArgs e)
        {
            Abteilungen MA = new Abteilungen(BEARBEITUNGSMODUS.HINZUFÜGEN);

            MA.TopLevel = false;
            MA.Dock = DockStyle.Fill;
            (this.Parent as Panel).Controls.Add(MA);
            MA.Show();
            MA.BringToFront();

            ((this.Parent as Panel).Parent as MainForm).Controls["headlineLabel"].Text = "Mitarbeiter hinzufügen";
        }

        private void mitBea_Click(object sender, EventArgs e)
        {
            Abteilungen MA = new Abteilungen(BEARBEITUNGSMODUS.BEARBEITEN);

            MA.TopLevel = false;
            MA.Dock = DockStyle.Fill;
            (this.Parent as Panel).Controls.Add(MA);
            MA.Show();
            MA.BringToFront();

            ((this.Parent as Panel).Parent as MainForm).Controls["headlineLabel"].Text = "Mitarbeiter hinzufügen";
        }

        private void mitDea_Click(object sender, EventArgs e)
        {
            Abteilungen MA = new Abteilungen(BEARBEITUNGSMODUS.DEAKTIVIEREN);

            MA.TopLevel = false;
            MA.Dock = DockStyle.Fill;
            (this.Parent as Panel).Controls.Add(MA);
            MA.Show();
            MA.BringToFront();

            ((this.Parent as Panel).Parent as MainForm).Controls["headlineLabel"].Text = "Mitarbeiter hinzufügen";
        }

        private void abtHinzu_Click(object sender, EventArgs e)
        {

        }
    }
}
