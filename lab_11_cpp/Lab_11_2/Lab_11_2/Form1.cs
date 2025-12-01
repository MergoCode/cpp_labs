using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab_11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class DollarRateMonitor
        {
            public delegate void RateEventHandler(string msg);
            public RateEventHandler handlers;

            public void Register(RateEventHandler h)
            {
                handlers += h;
            }

            public void CheckRate(double rate)
            {
                if (handlers == null) return;

                if (rate < 40)
                    handlers("Гривня сильна! Курс: " + rate);
                else if (rate <= 42)
                    handlers("Стабільно. Курс: " + rate);
                else
                    handlers("Гривня падає! Курс: " + rate);
            }
        }

        public void OutputToLabel(string msg)
        {
            labelOutput.Text += msg + "\n";
        }

        public void OutputWithTimestamp(string msg)
        {
            labelOutput.Text += DateTime.Now.ToString("HH:mm:ss") + " → " + msg + "\n";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "";

            DollarRateMonitor monitor = new DollarRateMonitor();

            monitor.Register(OutputToLabel);
            monitor.Register(OutputWithTimestamp);

            if (!double.TryParse(textBoxRate.Text, out double rate))
            {
                labelOutput.Text = "Помилка: введи курс!";
                return;
            }

            monitor.CheckRate(rate);
        }
    }
}
