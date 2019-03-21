using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arlo {
    public partial class Arlo : Form {

        private Multiplyer mult;

        public Arlo() {
            InitializeComponent();
            mult = new Multiplyer(this);
        }

        private void StartStop_Click(object sender, EventArgs e) {
            if(!mult.IsRunning) {
                BigInteger start = 0;
                BigInteger.TryParse(StartFrom.Text, out start);
                StartFrom.Text = start.ToString();
                StartStop.Text = "Stop";
                timer1.Enabled = true;
                mult.Start(start);
            } else {
                mult.Stop();
                StartFrom.Text = mult.NextEval.ToString();
                StartStop.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Log.AppendText(mult.Log);
            StartFrom.Text = mult.NextEval.ToString();
            PassesTextBox.Text = mult.LargestPass.Item1.ToString();
            NumberTextBox.Text = mult.LargestPass.Item2.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            mult.Stop();
            StartFrom.Text = "Enter a number...";
            StartStop.Text = "Start";
            timer1.Enabled = false;
            Log.Text = "";
            PassesTextBox.Text = "";
            NumberTextBox.Text = "";
            SpeedBar.Value = 5;
            mult.Delay = (SpeedBar.Value == SpeedBar.Maximum) ? 0 : (int) Math.Pow(2, SpeedBar.Maximum - SpeedBar.Value);
        }

        private void SpeedBar_Scroll(object sender, EventArgs e) {
            mult.Delay = (SpeedBar.Value == SpeedBar.Maximum) ? 0 : (int) Math.Pow(2, SpeedBar.Maximum - SpeedBar.Value);
        }
    }
}
