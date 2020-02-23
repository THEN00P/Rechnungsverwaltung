using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnungsverwaltung {
    public partial class MainFormNeu : Form {
        Panel timerTarget;
        int ticks = 0;

        public MainFormNeu() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.BackColor = Color.FromArgb(62, 120, 178);

            label1.Text = button1.Text;

            timerTarget = panel2;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timerTarget.Height += 50;

            ticks++;
            if (ticks >= 3) {
                timer1.Stop();
                ticks = 0;
            }
        }
    }
}
