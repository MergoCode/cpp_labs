using System;
using System.Drawing;
using System.Windows.Forms;

namespace LU_WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        DataGridView A_matrix_dgv;
        DataGridView C_matrix_dgv;
        DataGridView B_vector_dgv;
        DataGridView X_vector_dgv;
        NumericUpDown NUD_rozmir;
        Button BCreateGrid;
        Button BClear;
        Button BClose;
        Label lblA, lblC, lblB, lblX;

        int N = 1;
        int Change = 1;
        double[,] A = new double[6, 6];
        double[,] L = new double[6, 6];
        double[,] U = new double[6, 6];
        double[] B = new double[6];
        double[] X = new double[6];

        public Form1()
        {
            Text = "Метод L/U перетворення для розв'язання СЛАР";
            Width = 900;
            Height = 520;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponents();
        }

        void InitializeComponents()
        {
            lblA = new Label() { Text = "Матриця A", Left = 10, Top = 10, Width = 100 };
            lblC = new Label() { Text = "Матриця C (LU)", Left = 330, Top = 10, Width = 120 };
            lblB = new Label() { Text = "Вектор B", Left = 650, Top = 10, Width = 80 };
            lblX = new Label() { Text = "Вектор X", Left = 650, Top = 200, Width = 80 };
            Controls.Add(lblA);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblX);

            A_matrix_dgv = new DataGridView() { Left = 10, Top = 30, Width = 300, Height = 300, AllowUserToAddRows = false };
            C_matrix_dgv = new DataGridView() { Left = 330, Top = 30, Width = 300, Height = 300, AllowUserToAddRows = false, ReadOnly = true };
            B_vector_dgv = new DataGridView() { Left = 650, Top = 30, Width = 200, Height = 140, AllowUserToAddRows = false };
            X_vector_dgv = new DataGridView() { Left = 650, Top = 220, Width = 200, Height = 110, AllowUserToAddRows = false, ReadOnly = true };

            A_matrix_dgv.RowHeadersVisible = false; A_matrix_dgv.ColumnHeadersVisible = false;
            C_matrix_dgv.RowHeadersVisible = false; C_matrix_dgv.ColumnHeadersVisible = false;
            B_vector_dgv.RowHeadersVisible = false; B_vector_dgv.ColumnHeadersVisible = false;
            X_vector_dgv.RowHeadersVisible = false; X_vector_dgv.ColumnHeadersVisible = false;

            A_matrix_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            C_matrix_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            B_vector_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            X_vector_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(A_matrix_dgv);
            Controls.Add(C_matrix_dgv);
            Controls.Add(B_vector_dgv);
            Controls.Add(X_vector_dgv);

            Label lblN = new Label() { Text = "Розмір N:", Left = 10, Top = 350, Width = 70 };
            NUD_rozmir = new NumericUpDown() { Left = 90, Top = 347, Width = 60, Minimum = 1, Maximum = 5, Value = 1 };
            NUD_rozmir.ValueChanged += NUD_rozmir_ValueChanged;
            Controls.Add(lblN);
            Controls.Add(NUD_rozmir);

            BCreateGrid = new Button() { Text = "Розв'язати", Left = 180, Top = 345, Width = 90 };
            BClear = new Button() { Text = "Очистити", Left = 280, Top = 345, Width = 90 };
            BClose = new Button() { Text = "Вихід", Left = 380, Top = 345, Width = 90 };

            BCreateGrid.Click += BCreateGrid_Click;
            BClear.Click += BClear_Click;
            BClose.Click += BClose_Click;

            Controls.Add(BCreateGrid);
            Controls.Add(BClear);
            Controls.Add(BClose);

            A_matrix_dgv.CellClick += A_matrix_dgv_CellClick;
            B_vector_dgv.CellClick += B_vector_dgv_CellClick;

            SetupGrids(1);
        }

        private void SetupGrids(int n)
        {
            N = n;
            A_matrix_dgv.ColumnCount = n;
            A_matrix_dgv.RowCount = n;
            C_matrix_dgv.ColumnCount = n;
            C_matrix_dgv.RowCount = n;
            B_vector_dgv.ColumnCount = 1;
            B_vector_dgv.RowCount = n;
            X_vector_dgv.ColumnCount = 1;
            X_vector_dgv.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    C_matrix_dgv[j, i].Value = "";
                }
                B_vector_dgv[0, i].Value = "";
                X_vector_dgv[0, i].Value = "";
            }
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            SetupGrids(Convert.ToInt32(NUD_rozmir.Value));
        }

        private void BCreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;

            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                    try
                    {
                        object val = A_matrix_dgv[j - 1, i - 1].Value;
                        if (val == null || val.ToString().Trim() == "") throw new Exception();
                        A[i, j] = Convert.ToDouble(val);
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Black;
                    }
                    catch
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }

            for (int j = 1; j <= N; j++)
                try
                {
                    object val = B_vector_dgv[0, j - 1].Value;
                    if (val == null || val.ToString().Trim() == "") throw new Exception();
                    B[j] = Convert.ToDouble(val);
                    B_vector_dgv[0, j - 1].Style.ForeColor = Color.Black;
                }
                catch
                {
                    B_vector_dgv[0, j - 1].Style.ForeColor = Color.Red;
                    exc_B = true;
                }

            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка введення!");
                return;
            }

            Decomp(N, ref Change);
            bool solved = Solve(Change, N);
            if (!solved) return;

            for (int i = 1; i <= N; i++)
                X_vector_dgv[0, i - 1].Value = X[i].ToString("G6");

            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                {
                    double val = 0.0;
                    if (i > j) val = L[i, j];
                    else val = U[i, j];
                    C_matrix_dgv[j - 1, i - 1].Value = val.ToString("G6");
                }

            MessageBox.Show("Розв'язок знайдено");
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            SetupGrids(N);
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_matrix_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                A_matrix_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void B_vector_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                B_vector_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void Decomp(int N, ref int Change)
        {
            double[,] A_local = new double[6, 6];
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                    A_local[i, j] = A[i, j];

            int maxRow = 1;
            double maxAbs = Math.Abs(A_local[1, 1]);
            for (int i = 2; i <= N; i++)
            {
                double v = Math.Abs(A_local[i, 1]);
                if (v > maxAbs) { maxAbs = v; maxRow = i; }
            }
            Change = 1;
            if (maxRow != 1)
            {
                for (int j = 1; j <= N; j++)
                {
                    double tmp = A_local[1, j];
                    A_local[1, j] = A_local[maxRow, j];
                    A_local[maxRow, j] = tmp;
                }
                Change = maxRow;
            }

            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                {
                    L[i, j] = 0.0;
                    U[i, j] = 0.0;
                }

            for (int i = 1; i <= N; i++)
            {
                for (int k = i; k <= N; k++)
                {
                    double sum = 0.0;
                    for (int p = 1; p <= i - 1; p++)
                        sum += L[i, p] * U[p, k];
                    U[i, k] = A_local[i, k] - sum;
                }

                L[i, i] = 1.0;
                if (Math.Abs(U[i, i]) < 1e-12)
                {
                    MessageBox.Show($"Проблема: нульовий діагональний елемент U[{i},{i}]");
                    return;
                }
                for (int k = i + 1; k <= N; k++)
                {
                    double sum = 0.0;
                    for (int p = 1; p <= i - 1; p++)
                        sum += L[k, p] * U[p, i];
                    L[k, i] = (A_local[k, i] - sum) / U[i, i];
                }
            }
        }

        private bool Solve(int Change, int N)
        {
            double[] B_copy = new double[6];
            for (int i = 1; i <= N; i++) B_copy[i] = B[i];
            if (Change != 1)
            {
                double tmp = B_copy[1];
                B_copy[1] = B_copy[Change];
                B_copy[Change] = tmp;
            }

            double[] y = new double[6];
            for (int i = 1; i <= N; i++)
            {
                double sum = 0.0;
                for (int j = 1; j <= i - 1; j++) sum += L[i, j] * y[j];
                y[i] = B_copy[i] - sum;
            }

            for (int i = N; i >= 1; i--)
            {
                double sum = 0.0;
                for (int j = i + 1; j <= N; j++) sum += U[i, j] * X[j];
                if (Math.Abs(U[i, i]) < 1e-12)
                {
                    MessageBox.Show($"Проблема: нульовий діагональний елемент U[{i},{i}]");
                    return false;
                }
                X[i] = (y[i] - sum) / U[i, i];
            }
            return true;
        }
    }
}
