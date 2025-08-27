using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double input = 0.0;
        public double convertedValue = 0.0;
        public double multiplier = 0.453592;

        private void convertKG_Click(object sender, EventArgs e)
        {
            input = (double)lbsInput.Value;
            convertedValue = input * multiplier;

            resultBox.Text = convertedValue.ToString();
        }
    }
}
