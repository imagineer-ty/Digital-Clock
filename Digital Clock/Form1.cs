using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class digitalClock : Form
    {
        public digitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            whiteButton.FlatStyle = FlatStyle.Flat;
            greyButton.FlatStyle = FlatStyle.Flat;

        }

        private void clockLabel_Click(object sender, EventArgs e)
        {

        }
        private void digitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void greyButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Gray;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.White;

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;

        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Green;

        }

        private void style1Button_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Microsoft Sans Serif", 50, FontStyle.Regular);
        }

        private void style2Button_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Edwardian Script ITC", 50, FontStyle.Regular);

        }

        private void style3Button_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Bauhaus 93", 50, FontStyle.Regular);

        }
    }
}
