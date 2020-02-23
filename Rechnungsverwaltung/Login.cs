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

namespace Rechnungsverwaltung {
    public partial class Login : Form {
        public bool success = false;

        public Login() {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            if (DB.validLogin(textLoginName.Text, textPasswort.Text)) {
                success = true;
                Close();
            }
            else {
                errorLabel.Text = "Benutzername/Passwort ist falsch!";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            errorLabel.Text = "";
            timer1.Stop();
        }
    }
}