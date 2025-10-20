using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double f(double x, ref int k1)
        {
            switch (k1)
            {
                case 0: return x * x - 4;
                case 1: return 3 * x - 4 * Math.Log(x) - 5;
                case 2: return Math.Pow(x, 3) - Math.Pow(x*3, 2) + 7;
            }
            return 0;
        }

        double fp(double x, double d, ref int k1)
        {
            return (f(x + d, ref k1) - f(x, ref k1)) / d;
        }

        double f2p(double x, double d, ref int k1)
        {
            return (f(x + d, ref k1) + f(x - d, ref k1) - 2 * f(x, ref k1)) / (d * d);
        }

        void MDP(double a, double b, double Eps, ref int k1)
        {
            int L = 0;
            double c = 0, Fc;

            while (b - a > Eps)
            {
                c = 0.5 * (b - a) + a;
                L++;
                Fc = f(c, ref k1);
                if (Math.Abs(Fc) < Eps)
                {
                    textBox5.Text = c.ToString();
                    textBox6.Text = L.ToString();
                    label10.Text = "К-ть поділів =";
                    return;
                }
                if (f(a, ref k1) * Fc > 0) a = c;
                else b = c;
            }

            textBox5.Text = c.ToString();
            textBox6.Text = L.ToString();
            label10.Text = "К-ть поділів =";
        }

        void MN(double a, double b, double Eps, ref int k1, int Kmax)
        {
            double x, Dx, D;
            int i;
            int L = 0;

            Dx = 0.0;
            D = Eps / 100.0;
            x = b;

            if (f(x, ref k1) * f2p(x, D, ref k1) < 0) x = a;

            if (f(x, ref k1) * f2p(x, D, ref k1) < 0)
                MessageBox.Show("Для цього рівняння збіжність ітерацій не гарантована");

            for (i = 1; i <= Kmax; i++)
            {
                Dx = f(x, ref k1) / fp(x, D, ref k1);
                x = x - Dx;
                if (Math.Abs(Dx) < Eps)
                {
                    textBox5.Text = x.ToString();
                    textBox6.Text = i.ToString();
                    label10.Text = "К-ть ітерац. =";
                    return;
                }
            }

            MessageBox.Show("За задану кількість ітерацій кореня не знайдено");
            textBox5.Text = "-";
            textBox6.Text = "-";
        }

        private void radioMN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMN.Checked)
            {
                label7.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void radioMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMDP.Checked)
            {
                label7.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = -1, Kmax = 0;
            double D, Eps = 0, a, b;

            if (!radioMDP.Checked && !radioMN.Checked)
            {
                MessageBox.Show("Оберіть метод!");
                return;
            }

            switch (comboBox2.SelectedIndex)
            {
                case 0: k = 0; break;
                case 1: k = 1; break;
                case 2: k = 2; break;
            }

            if (k == -1)
            {
                MessageBox.Show("Оберіть рівняння!");
                comboBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введіть число в textBox1");
                textBox1.Focus();
                return;
            }

            a = Convert.ToDouble(textBox1.Text);

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введіть число в textBox2");
                textBox2.Focus();
                return;
            }

            b = Convert.ToDouble(textBox2.Text);

            if (a > b)
            {
                D = a;
                a = b;
                b = D;
                textBox1.Text = a.ToString();
                textBox2.Text = b.ToString();
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Введіть похибку Eps");
                textBox3.Focus();
                return;
            }

            Eps = Convert.ToDouble(textBox3.Text);
            if ((Eps > 1e-1) || (Eps <= 0))
            {
                Eps = 1e-4;
                textBox3.Text = Eps.ToString();
            }

            if (radioMDP.Checked && f(a, ref k) * f(b, ref k) > 0)
            {
                MessageBox.Show("Введіть правильний інтервал [a, b]!");
                textBox1.Clear();
                textBox2.Clear();
                return;
            }

            if (radioMDP.Checked)
            {
                MDP(a, b, Eps, ref k);
            }
            else if (radioMN.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Введіть Kmax!");
                    textBox4.Focus();
                    return;
                }
                Kmax = Convert.ToInt32(textBox4.Text);
                MN(a, b, Eps, ref k, Kmax);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
