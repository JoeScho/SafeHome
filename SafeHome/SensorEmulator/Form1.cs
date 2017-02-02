using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorEmulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboSensor.Items.Add("Door / Window Contact");
            comboSensor.Items.Add("Movement");
            comboSensor.Items.Add("Fire");
            comboSensor.Items.Add("Breaking Glass");
            comboSensor.Items.Add("Vibration");
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {

        }
    }
}
