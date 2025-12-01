using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        double[,] J = new double[3, 3];
        double[] X = new double[3];
        double[] F = new double[3];
        double[] Fp = new double[3];
        double[] Dx = new double[3];

        public Form1()
        {
            InitializeComponent();
            InitGrid(X0_dgv);
            InitGrid(X_dgv);
        }

        // ========================= GRID INIT =========================

        void InitGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            dgv.ColumnCount = 1;
            dgv.RowCount = 3;

            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.Columns[0].Width = 80;

            for (int i = 0; i < 3; i++)
                dgv[0, i].Value = "0";
        }

        // ========================= SAFE DOUBLE READ =========================

        double ReadDG(DataGridView dgv, int i)
        {
            dgv.EndEdit();

            string s = dgv[0, i].Value?.ToString() ?? "0";
            s = s.Replace(",", ".");
            double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double r);
            return r;
        }

        // ========================= SYSTEM F(X) =========================

        void Fsys(double[] X, double[] f)
        {
            double x1 = X[0];
            double x2 = X[1];
            double x3 = X[2];

            f[0] = x1 + Math.Exp(x1 - 1) + Math.Pow(x2 + x3, 2) - 27;
            f[1] = x1 * Math.Exp(x2 - 2) + x3 * x3 - 10;
            f[2] = x3 + Math.Sin(x2 - 2) + x2 * x2 - 7;
        }


        // ========================= JACOBIAN =========================

        void Jacob(double[] x)
        {
            double h = 1e-6;
            Fsys(x, F);

            for (int j = 0; j < 3; j++)
            {
                x[j] += h;
                Fsys(x, Fp);

                for (int i = 0; i < 3; i++)
                    J[i, j] = (Fp[i] - F[i]) / h;

                x[j] -= h;
            }
        }

        // ========================= GAUSS =========================

        bool Gauss(double[,] A, double[] B, double[] X)
        {
            double[,] M = new double[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    M[i, j] = A[i, j];
                M[i, 3] = -B[i];
            }

            for (int k = 0; k < 3; k++)
            {
                if (Math.Abs(M[k, k]) < 1e-12)
                    return false;

                for (int i = k + 1; i < 3; i++)
                {
                    double s = M[i, k] / M[k, k];
                    for (int j = k; j < 4; j++)
                        M[i, j] -= s * M[k, j];
                }
            }

            for (int i = 2; i >= 0; i--)
            {
                double s = M[i, 3];
                for (int j = i + 1; j < 3; j++)
                    s -= M[i, j] * X[j];
                X[i] = s / M[i, i];
            }

            return true;
        }

        // ========================= LOG PRINT =========================

        void Log(string msg)
        {
            labelDebug.Text += msg + "\n";
        }

        void ClearLog()
        {
            labelDebug.Text = "";
        }

        // ========================= BUTTON =========================

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            ClearLog();
            Log("=== START ===");

            double eps = double.Parse(textBoxEps.Text.Replace(",", "."), CultureInfo.InvariantCulture);
            int Kmax = int.Parse(textBoxKmax.Text);

            // Initial vector
            for (int i = 0; i < 3; i++)
            {
                X[i] = ReadDG(X0_dgv, i);
                Log($"X0[{i}] = {X[i]}");
            }

            for (int k = 1; k <= Kmax; k++)
            {
                Log($"\n--- Iter {k} ---");

                Fsys(X, F);
                Log($"F = [{F[0]}, {F[1]}, {F[2]}]");

                Jacob(X);

                Log("J:");
                Log($"{J[0, 0]}, {J[0, 1]}, {J[0, 2]}");
                Log($"{J[1, 0]}, {J[1, 1]}, {J[1, 2]}");
                Log($"{J[2, 0]}, {J[2, 1]}, {J[2, 2]}");

                if (!Gauss(J, F, Dx))
                {
                    Log("GAUSS FAILED");
                    MessageBox.Show("Гаус впав");
                    return;
                }

                Log($"Dx = [{Dx[0]}, {Dx[1]}, {Dx[2]}]");

                double dxmax = 0;
                for (int i = 0; i < 3; i++)
                {
                    X[i] -= Dx[i];
                    dxmax = Math.Max(dxmax, Math.Abs(Dx[i]));
                }

                Log($"New X = [{X[0]}, {X[1]}, {X[2]}]");
                Log($"dxmax = {dxmax}");

                if (dxmax < eps)
                {
                    Log("=== DONE ===");
                    textBoxIter.Text = k.ToString();

                    for (int i = 0; i < 3; i++)
                        X_dgv[0, i].Value = X[i].ToString("0.######", CultureInfo.InvariantCulture);

                    MessageBox.Show("Розв'язано!");
                    return;
                }
            }

            Log("=== FAIL ===");
            MessageBox.Show("Не зійшлося");
        }
    }
}
