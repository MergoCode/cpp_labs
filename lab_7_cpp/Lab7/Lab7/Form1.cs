using System;
using System.Windows.Forms;

namespace Lab7
{
    public enum stanMjacha
    {
        vGriA,
        vGriB,
        pozaGroju,
        vCentri,
        vVorotahA,
        vVorotahB
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string newline = "\r";
        public static string sumText = "";
        public static string PlanText = "";
        public static int j = 1;

        public class Sphere
        {
            public const double Pi = Math.PI;
            double r, l, v, s, m;
            public double r_kuli
            {
                get { return r; }
                set
                {
                    r = value;
                    l = 2 * Pi * r;
                    v = 4 * Pi * r * r * r;
                    s = 4 * Pi * r * r;
                }
            }
            public double l_kola { get { return l; } }
            public double v_kuli { get { return v; } }
            public double s_kuli { get { return s; } }
            public double masa { get { return m; } set { m = value; } }

            virtual public double kotytys(double t, double v)
            {
                Form1.sumText += Form1.j + ". Виконано метод kotytys(double, double) класу Sphere" + Form1.newline;
                Form1.j++;
                return 2 * Pi * r * t * v;
            }

            virtual public double letity(double t, double v)
            {
                Form1.sumText += Form1.j + ". Виконано метод letity(double,double) класу Sphere" + Form1.newline;
                Form1.j++;
                return t * v;
            }

            virtual public double udar(double t, out double v, double f, double t1)
            {
                v = f * t1 / m;
                Form1.sumText += Form1.j + ". Виконано метод udar(double, out double,double,double) класу Sphera s = v * t= " + (t * v) + Form1.newline;
                Form1.j++;
                return t * v;
            }
        }

        public class mjach : Sphere
        {
            virtual public void popav(bool je, ref int kilkist)
            {
                if (je) kilkist++;
                Form1.sumText += Form1.j + ". Виконано метод popav(bool, ref int) класу mjach. kilkist=" + kilkist + Form1.newline;
                Form1.j++;
            }

            virtual public double letity(double t, double v, double f_tertja)
            {
                Form1.sumText += Form1.j + ". Виконано метод letity(double, double, double ) класу mjach" + Form1.newline;
                Form1.j++;
                return t * v - f_tertja / masa * t * t / 2;
            }

            public double letityBase(double t, double v)
            {
                Form1.sumText += Form1.j + ". Виконано метод letityBase(double, double) класу mjach" + Form1.newline;
                Form1.j++;
                return base.letity(t, v);
            }
        }

        public class povitrjana_kulja : Sphere
        {
            double tysk, maxTysk;
            public double tyskGazu { get { return tysk; } set { tysk = value; } }
            public double maxTyskGazu { get { return maxTysk; } set { maxTysk = value; } }

            public bool lopatys()
            {
                Form1.sumText += Form1.j + ". Виконано метод lopatys(); класу povitrjana_kulja" + Form1.newline;
                Form1.j++;
                return tysk > maxTysk;
            }

            public double letity(double t, double v, double v_Vitru, double kutVitru)
            {
                Form1.sumText += Form1.j + ". Виконано метод lletity(double t, double v, double v_Vitru, double kutVitru) класу povitrjana_kulja" + Form1.newline;
                Form1.j++;
                return t * v - v_Vitru * Math.Sin(kutVitru);
            }

            new public double letity(double t, double v)
            {
                double s = t * v;
                Form1.sumText += Form1.j + ". Виконано метод letity(double t, double v ) класу povitrjana_kulja. Ми пролетіли " + s + " метрів!" + Form1.newline;
                Form1.j++;
                return s;
            }
        }

        public class futbol_mjach : mjach
        {
            stanMjacha stanM;
            public stanMjacha tstanMjacha { get { return stanM; } set { stanM = value; } }
            public bool standout { get { return stanM == stanMjacha.pozaGroju; } }

            public futbol_mjach(stanMjacha sm)
            {
                Form1.sumText += Form1.j + ". Виконано конструктор futbol_mjach(stanMjacha sm) " + Form1.newline;
                Form1.j++;
                stanM = sm;
                masa = 0.5F;
                r_kuli = 0.1F;
            }

            public void popav(bool je, ref int kilkistA, ref int kilkistB)
            {
                if (je)
                {
                    if (stanM == stanMjacha.vGriA) kilkistA++;
                    else if (stanM == stanMjacha.vGriB) kilkistB++;
                }
                Form1.sumText += Form1.j + ". Виконано метод popav класу futbol_mjach з сигнатурою (bool, ref int, ref int)" + Form1.newline;
                Form1.j++;
            }

            public void popavBase(bool b, ref int i)
            {
                Form1.sumText += Form1.j + ". Виконано метод popavBase(bool b, ref int i) класу futbol_mjach, який викликає метод popav(b, ref i) класу mjach )" + Form1.newline;
                Form1.j++;
                base.popav(b, ref i);
            }

            override public void popav(bool je, ref int kilkist)
            {
                if (je) kilkist++;
                Form1.sumText += Form1.j + ". Виконано метод  popav(bool je, ref int kilkist) (override) класу  futbol_mjach " + Form1.newline;
                Form1.j++;
            }

            override public double letity(double t, double v, double ftertja)
            {
                Form1.sumText += Form1.j + ". Виконано метод letity(double t, double v, double ftertja) ( override) класу futbol_mjach " + Form1.newline;
                Form1.j++;
                return t * v - ftertja / masa * t * t / 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanText = "Планується зробити:" + newline;
            sumText = "Початок роботи" + newline;
            int i = 1;
            label2.Text = sumText + newline;

            PlanText += i++ + ". Плануємо створите екземпляр класу futbol_mjach, викликавши конструктор з параметром " + newline;
            futbol_mjach fm = new futbol_mjach(stanMjacha.vCentri);
            int GolA = 0, GolB = 0;
            fm.masa = 0.6F;
            fm.r_kuli = 0.12F;
            fm.tstanMjacha = stanMjacha.vGriA;

            PlanText += i++ + ". Плануємо викликати метод popav(true, ref GolA); (override)" + newline;
            fm.popav(true, ref GolA);

            PlanText += i++ + ". Плануємо викликати метод popav(true, ref GolA, ref GolB)" + newline;
            fm.popav(true, ref GolA, ref GolB);

            PlanText += i++ + ". Плануємо викликати метод popavBase(true, ref GolA)" + newline;
            fm.popavBase(true, ref GolA);

            double s, v;
            PlanText += i++ + ". Плануємо викликати метод udar(2, out v, 200, 0.1)" + newline;
            s = fm.udar(2, out v, 200, 0.1);

            PlanText += i++ + ". Плануємо викликати метод kotytys(5, 1)" + newline;
            s = fm.kotytys(5, 1);

            PlanText += i++ + ". Плануємо викликати метод letity(20, 30)" + newline;
            s = fm.letity(20, 30);

            PlanText += i++ + ". Плануємо викликати перевизначений метод letity(20, 30, 5)" + newline;
            s = fm.letity(20, 30, 5);

            label1.Text = PlanText;
            label2.Text = sumText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
