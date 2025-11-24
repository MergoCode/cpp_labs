using System;
using System.Windows.Forms;

namespace Lab_9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class CaseTransistors
        {
            public string transType { get; set; }
            public string transName { get; set; }
            public string transModelName { get; set; }

            struct transPrefixName
            {
                public string PrefixName;
                public string PrefixText;
            }

            transPrefixName[] Prefixs;
            CaseTransistors[] transistors;

            public int Length;
            public int ErrorKod;

            public CaseTransistors(int size, string type, string tname, string modelName)
            {
                transistors = new CaseTransistors[size];
                Length = size;
                setPrefixName();
                transType = type;
                transName = tname;
                transModelName = modelName;
            }

            public override string ToString()
            {
                return "Транзистор " + transName + " Тип- " + transType + " модель- " + transModelName;
            }

            void setPrefixName()
            {
                Prefixs = new transPrefixName[14];

                Prefixs[0].PrefixName = "AC";
                Prefixs[1].PrefixName = "AD";
                Prefixs[2].PrefixName = "AF";
                Prefixs[3].PrefixName = "AL";
                Prefixs[4].PrefixName = "AS";
                Prefixs[5].PrefixName = "AU";
                Prefixs[6].PrefixName = "BC";
                Prefixs[7].PrefixName = "BD";
                Prefixs[8].PrefixName = "BF";
                Prefixs[9].PrefixName = "BS";
                Prefixs[10].PrefixName = "BL";
                Prefixs[11].PrefixName = "BU";
                Prefixs[12].PrefixName = "CF";
                Prefixs[13].PrefixName = "CL";
            }

            bool OkPrefixName(string prefix)
            {
                for (int i = 0; i < 14; i++)
                    if (Prefixs[i].PrefixName == prefix) return true;
                return false;
            }

            bool OkIndex(int i)
            {
                return (i >= 0 && i < Length);
            }

            public CaseTransistors this[int index]
            {
                get
                {
                    if (OkIndex(index))
                    {
                        ErrorKod = 0;
                        return transistors[index];
                    }
                    else
                    {
                        ErrorKod = 1;
                        return null;
                    }
                }
                set
                {
                    if (!OkIndex(index))
                    {
                        ErrorKod = 1;
                        return;
                    }

                    if (!OkPrefixName(value.transName.Substring(0, 2)))
                    {
                        ErrorKod = 2;
                        return;
                    }

                    transistors[index] = value;
                    ErrorKod = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaseTransistors MyTr = new CaseTransistors(5, "Bipolar", "AC126", "EbbersMoll");
            CaseTransistors MyTr1 = new CaseTransistors(1, "Field-effet", "AC126", "Gummel-Poon");
            CaseTransistors MyTr2 = new CaseTransistors(1, "Field-effet", "AD133", "Gummel-Poon");
            CaseTransistors MyTr3 = new CaseTransistors(1, "Schottky", "BD139", "Gummel-Poon");
            CaseTransistors MyTr4 = new CaseTransistors(1, "Avalanche", "OO117", "EbbersMoll");
            CaseTransistors MyTr5 = new CaseTransistors(1, "Darlington", "BLW34", "EbbersMoll");
            CaseTransistors MyTr6 = new CaseTransistors(1, "Photo", "BU508", "EbbersMoll");
            CaseTransistors MyTr7 = new CaseTransistors(1, "Bipolar", "CLY10", "EbbersMoll");

            string sMessage = "";

            MyTr[0] = MyTr1;
            sMessage += Msg("1", MyTr1, MyTr.ErrorKod);

            MyTr[1] = MyTr2;
            sMessage += Msg("2", MyTr2, MyTr.ErrorKod);

            MyTr[2] = MyTr3;
            sMessage += Msg("3", MyTr3, MyTr.ErrorKod);

            MyTr[3] = MyTr4;
            sMessage += Msg("4", MyTr4, MyTr.ErrorKod);

            MyTr[4] = MyTr5;
            sMessage += Msg("5", MyTr5, MyTr.ErrorKod);

            MyTr[5] = MyTr6;
            sMessage += Msg("6", MyTr6, MyTr.ErrorKod);

            MyTr[6] = MyTr7;
            sMessage += Msg("7", MyTr7, MyTr.ErrorKod);

            label1.Text = sMessage;

            string s2 = "";
            for (int i = 0; i < MyTr.Length; i++)
                if (MyTr[i] != null) s2 += "\n" + MyTr[i].ToString();

            label2.Text = s2;
        }

        string Msg(string n, CaseTransistors t, int code)
        {
            if (code > 0)
                return $"\n {n} Транзистор НЕ додано {t.transName} (код {code})";
            else
                return $"\n {n} Транзистор додано {t.transName}";
        }
    }
}
