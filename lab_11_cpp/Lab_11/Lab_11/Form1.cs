using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Car
        {
            public int CurrentSpeed { get; set; }
            public int MaxSpeed { get; set; }
            public string PetName { get; set; }
            private bool carIsDead;

            public static double distance = 0;

            public Car()
            {
                MaxSpeed = 100;
            }

            public Car(string name, int maxSp, int currSp)
            {
                MaxSpeed = maxSp;
                CurrentSpeed = currSp;
                PetName = name;
            }

            public delegate void CarEngineHandler(string msgForCaller);

            CarEngineHandler listOfHandlers;

            public void RegisterWithCarEngine(CarEngineHandler metodToCall)
            {
                listOfHandlers += metodToCall;
            }

            public void Accselerate(int delta)
            {
                if (carIsDead)
                {
                    if (listOfHandlers != null)
                        listOfHandlers("На жаль, автомобіль зламався");
                }
                else
                {
                    distance += CurrentSpeed * 0.16;
                    CurrentSpeed += delta;

                    if ((MaxSpeed - CurrentSpeed <= 10)
                        && (CurrentSpeed < MaxSpeed)
                        && listOfHandlers != null)
                    {
                        listOfHandlers("Увага! Занадто велика швидкість!");
                    }
                    else
                    {
                        if (CurrentSpeed >= MaxSpeed)
                            carIsDead = true;
                        else
                            listOfHandlers("Поточна швидкість=" + CurrentSpeed.ToString());
                    }
                }
            }
        }

        public void OnCarEngineEvent1(string msg)
        {
            label1.Text += msg + " \n";
        }

        public void OnCarEngineEvent2(string msg)
        {
            label2.Text += $"Пробіг: {Car.distance} км.\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car myCar = new Car("Старенький Запорожець", 100, 0);

            Car.CarEngineHandler myDelegat1 =
                new Car.CarEngineHandler(OnCarEngineEvent1);

            Car.CarEngineHandler myDelegat2 =
                new Car.CarEngineHandler(OnCarEngineEvent2);

            myCar.RegisterWithCarEngine(myDelegat1);
            myCar.RegisterWithCarEngine(myDelegat2);

            OnCarEngineEvent1("Стартуємо");

            for (int i = 0; i < 11; i++)
                myCar.Accselerate(10);
        }
    }
}