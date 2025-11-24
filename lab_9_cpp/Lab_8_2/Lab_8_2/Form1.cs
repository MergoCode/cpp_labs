using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCars();
        }

        interface ICar
        {
            string Name { get; }
            int MaxSpeed { get; }
            string Info();
        }

        class BMW : ICar
        {
            public string Name => "BMW M5";
            public int MaxSpeed => 305;
            public string Info() => $"{Name}, Max: {MaxSpeed}";
        }

        class Audi : ICar
        {
            public string Name => "Audi RS7";
            public int MaxSpeed => 300;
            public string Info() => $"{Name}, Max: {MaxSpeed}";
        }

        class Tesla : ICar
        {
            public string Name => "Tesla Model S Plaid";
            public int MaxSpeed => 322;
            public string Info() => $"{Name}, Max: {MaxSpeed}";
        }

        List<ICar> cars = new List<ICar>();
        int index = 0;

        private void LoadCars()
        {
            cars.Add(new BMW());
            cars.Add(new Audi());
            cars.Add(new Tesla());
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var c in cars)
                s += c.Info() + "\n";
            label1.Text = s;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            var c = cars[index];
            label1.Text = c.Info();
            index = (index + 1) % cars.Count;
        }
    }
}
