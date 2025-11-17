using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab7_dop
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();

            cars = BuildCarsFromListBox();
        }

        private List<Car> BuildCarsFromListBox()
        {
            var list = new List<Car>();

            foreach (var item in listBox1.Items)
            {
                string name = item.ToString();

                if (name.Contains("Tesla", StringComparison.OrdinalIgnoreCase))
                {
                    list.Add(new ElectricCar(name, 250, 100));
                }
                else if (name.Contains("Ferrari", StringComparison.OrdinalIgnoreCase))
                {
                    list.Add(new SportsCar(name, 340, true));
                }
                else
                {
                    list.Add(new Car(name, 180));
                }
            }

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вибери авто зі списку!");
                return;
            }

            var car = cars[listBox1.SelectedIndex];

            label1.Text = $"{car.Name} ({car.GetType().Name})\n";
            label1.Text += car.StartEngine() + "\n";
            label1.Text += car.Drive(50) + "\n";
            label1.Text += car.Drive(20, 2) + "\n";
        }
    }


    public class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }

        public virtual string StartEngine() => "Двигун запущено.";

        public virtual string Drive(int km) =>
            $"Проїхав {km} км зі швидкістю до {MaxSpeed} км/год.";

        public string Drive(int km, int passengers) =>
            $"Проїхав {km} км з {passengers} пасажирами.";
    }


    public class ElectricCar : Car
    {
        public int Battery { get; set; }

        public ElectricCar(string name, int speed, int battery)
            : base(name, speed)
        {
            Battery = battery;
        }

        public override string StartEngine() => "Електромотор увімкнено";

        public override string Drive(int km)
        {
            Battery -= km / 10;
            if (Battery < 0) Battery = 0;
            return $"Проїхав {km} км на електротязі. Заряд: {Battery}%";
        }
    }


    public class SportsCar : Car
    {
        public bool Turbo { get; set; }

        public SportsCar(string name, int speed, bool turbo)
            : base(name, speed)
        {
            Turbo = turbo;
        }

        public override string StartEngine() =>
            Turbo ? "Турбомотор запущено" : "Двигун запущено.";

        public override string Drive(int km)
        {
            return Turbo
                ? $"Проїхав {km} км з турбо! (до {MaxSpeed + 50} км/год)"
                : base.Drive(km);
        }
    }
}
