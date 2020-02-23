using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnungsverwaltung {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public void cleanViewport()
        {
            foreach (var item in mainViewPanel.Controls.OfType<Form>()) {
                item.Close();
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            //foreach (var item in mainViewPanel.Controls.OfType<Form>())
            //{
            //    item.Size = mainViewPanel.Size;
            //    Debug.WriteLine(item.Size);
            //}
        }

        private void stammdatenBtn_Click(object sender, EventArgs e)
        {
            cleanViewport();
            StammdatenSelect stammSelectForm = new StammdatenSelect();

            stammSelectForm.TopLevel = false;
            stammSelectForm.Dock = DockStyle.Fill;
            mainViewPanel.Controls.Add(stammSelectForm);
            stammSelectForm.Show();

            headlineLabel.Text = "Stammdaten auswählen";
        }
    }
}
