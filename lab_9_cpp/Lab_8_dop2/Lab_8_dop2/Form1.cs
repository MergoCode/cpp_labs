using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab_8_dop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class MyTextBox : TextBox, ICloneable
        {
            public object Clone()
            {
                MyTextBox clone = new MyTextBox();
                clone.Text = this.Text;
                clone.Font = this.Font;
                clone.Size = this.Size;
                clone.BackColor = this.BackColor;
                clone.ForeColor = this.ForeColor;
                clone.Multiline = this.Multiline;
                return clone;
            }
        }

        MyTextBox original = null;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            original = new MyTextBox();
            original.Text = "Оригінал";
            original.Location = new Point(30, 30);
            original.Size = new Size(150, 25);

            this.Controls.Add(original);

            label1.Text = "Створено оригінал TextBox";
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                label1.Text = "Спочатку створіть оригінал";
                return;
            }

            MyTextBox clone = (MyTextBox)original.Clone();
            clone.Location = new Point(30, 80);
            clone.Text = "Клон";
            this.Controls.Add(clone);

            label1.Text = "Створено клон TextBox";
        }
    }
}
