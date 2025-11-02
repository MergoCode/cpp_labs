using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        int N = 1;
        int i = 0;
        int j = 0;
        int Change;
        double[,] A = new double[6, 6];
        double[] B = new double[6];
        double[] X = new double[6];
        double[] Y = new double[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Decomp(int N, ref int Change)
        {
            Change = 1;
            int kMax = 1;
            double maxAbs = Math.Abs(A[1, 1]);
            for (int k = 2; k <= N; k++)
            {
                if (Math.Abs(A[k, 1]) > maxAbs)
                {
                    maxAbs = Math.Abs(A[k, 1]);
                    kMax = k;
                }
            }
            if (kMax != 1)
            {
                Change = kMax;
                for (int col = 1; col <= N; col++)
                {
                    double tmp = A[1, col];
                    A[1, col] = A[kMax, col];
                    A[kMax, col] = tmp;
                }
            }
            if (Math.Abs(A[1, 1]) < 1e-14) throw new Exception();

            for (int col = 2; col <= N; col++)
                A[1, col] = A[1, col] / A[1, 1];

            for (int i = 2; i <= N; i++)
            {
                for (int row = i; row <= N; row++)
                {
                    double s = 0.0;
                    for (int j = 1; j <= i - 1; j++)
                        s += A[row, j] * A[j, i];
                    A[row, i] = A[row, i] - s;
                }

                if (Math.Abs(A[i, i]) < 1e-14) throw new Exception();

                for (int col = i + 1; col <= N; col++)
                {
                    double s = 0.0;
                    for (int j = 1; j <= i - 1; j++)
                        s += A[i, j] * A[j, col];
                    A[i, col] = (A[i, col] - s) / A[i, i];
                }
            }

            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                    C_matrix_dgv.Rows[r].Cells[c].Value = Convert.ToString(A[r + 1, c + 1]);

            label2.Text = "LU";
        }

        private void Solve(int Change, int N)
        {
            if (Change != 1)
            {
                double tmp = B[1];
                B[1] = B[Change];
                B[Change] = tmp;
            }

            Y[1] = B[1] / A[1, 1];
            for (int i = 2; i <= N; i++)
            {
                double s = 0.0;
                for (int j = 1; j <= i - 1; j++)
                    s += A[i, j] * Y[j];
                Y[i] = (B[i] - s) / A[i, i];
            }

            X[N] = Y[N];
            for (int i = N - 1; i >= 1; i--)
            {
                double s = 0.0;
                for (int j = i + 1; j <= N; j++)
                    s += A[i, j] * X[j];
                X[i] = Y[i] - s;
            }
        }

        private void GaussSolve(int N)
        {
            for (int k = 1; k <= N - 1; k++)
            {
                for (int i = k + 1; i <= N; i++)
                {
                    double t = A[i, k] / A[k, k];
                    for (int j = k; j <= N; j++)
                        A[i, j] = A[i, j] - t * A[k, j];
                    B[i] = B[i] - t * B[k];
                }
            }

            for (int i = N; i >= 1; i--)
            {
                double s = 0.0;
                for (int j = i + 1; j <= N; j++)
                    s += A[i, j] * X[j];
                X[i] = (B[i] - s) / A[i, i];
            }

            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                    C_matrix_dgv.Rows[r].Cells[c].Value = Convert.ToString(A[r + 1, c + 1]);

            label2.Text = "Gauss";
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(NUD_rozmir.Value);
            A_matrix_dgv.RowCount = N;
            A_matrix_dgv.ColumnCount = N;
            X_vector_dgv.RowCount = N;
            B_vector_dgv.RowCount = N;
            C_matrix_dgv.RowCount = N;
            C_matrix_dgv.ColumnCount = N;
        }

        private void BСreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    try
                    {
                        A[i, j] = Convert.ToDouble(A_matrix_dgv[j - 1, i - 1].Value);
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Black;
                    }
                    catch
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }
                }
            }

            for (j = 0; j < N; j++)
            {
                try
                {
                    B[j + 1] = Convert.ToDouble(B_vector_dgv[0, j].Value);
                    B_vector_dgv[0, j].Style.ForeColor = Color.Black;
                }
                catch
                {
                    B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                    exc_B = true;
                }
            }

            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка введення!");
                return;
            }

            try
            {
                if (CB_method.SelectedIndex == 0)
                {
                    Decomp(N, ref Change);
                    Solve(Change, N);
                }
                else
                {
                    GaussSolve(N);
                }

                for (i = 0; i < N; i++)
                    X_vector_dgv[0, i].Value = X[i + 1].ToString();

                MessageBox.Show("Розв'язок знайдено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка обчислень: " + ex.Message);
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    C_matrix_dgv[j, i].Value = "";
                }

            for (j = 0; j < N; j++)
            {
                B_vector_dgv[0, j].Value = "";
                X_vector_dgv[0, j].Value = "";
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
