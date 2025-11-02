namespace Lab_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            A_matrix_dgv = new DataGridView();
            C_matrix_dgv = new DataGridView();
            B_vector_dgv = new DataGridView();
            X_vector_dgv = new DataGridView();
            BСreateGrid = new Button();
            BClear = new Button();
            BClose = new Button();
            NUD_rozmir = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CB_method = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)A_matrix_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)C_matrix_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B_vector_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)X_vector_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_rozmir).BeginInit();
            SuspendLayout();
            // 
            // A_matrix_dgv
            // 
            A_matrix_dgv.AllowUserToAddRows = false;
            A_matrix_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            A_matrix_dgv.ColumnHeadersVisible = false;
            A_matrix_dgv.Location = new Point(68, 31);
            A_matrix_dgv.Name = "A_matrix_dgv";
            A_matrix_dgv.RowHeadersVisible = false;
            A_matrix_dgv.RowHeadersWidth = 51;
            A_matrix_dgv.Size = new Size(300, 174);
            A_matrix_dgv.TabIndex = 0;
            // 
            // C_matrix_dgv
            // 
            C_matrix_dgv.AllowUserToAddRows = false;
            C_matrix_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            C_matrix_dgv.ColumnHeadersVisible = false;
            C_matrix_dgv.Location = new Point(68, 239);
            C_matrix_dgv.Name = "C_matrix_dgv";
            C_matrix_dgv.RowHeadersWidth = 51;
            C_matrix_dgv.Size = new Size(300, 172);
            C_matrix_dgv.TabIndex = 1;
            // 
            // B_vector_dgv
            // 
            B_vector_dgv.AllowUserToAddRows = false;
            B_vector_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            B_vector_dgv.ColumnHeadersVisible = false;
            B_vector_dgv.Location = new Point(480, 31);
            B_vector_dgv.Name = "B_vector_dgv";
            B_vector_dgv.RowHeadersVisible = false;
            B_vector_dgv.RowHeadersWidth = 51;
            B_vector_dgv.Size = new Size(72, 188);
            B_vector_dgv.TabIndex = 2;
            // 
            // X_vector_dgv
            // 
            X_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            X_vector_dgv.ColumnHeadersVisible = false;
            X_vector_dgv.Location = new Point(607, 31);
            X_vector_dgv.Name = "X_vector_dgv";
            X_vector_dgv.ReadOnly = true;
            X_vector_dgv.RowHeadersVisible = false;
            X_vector_dgv.RowHeadersWidth = 51;
            X_vector_dgv.Size = new Size(72, 188);
            X_vector_dgv.TabIndex = 3;
            // 
            // BСreateGrid
            // 
            BСreateGrid.Location = new Point(480, 266);
            BСreateGrid.Name = "BСreateGrid";
            BСreateGrid.Size = new Size(94, 29);
            BСreateGrid.TabIndex = 4;
            BСreateGrid.Text = "Розв'язати";
            BСreateGrid.UseVisualStyleBackColor = true;
            BСreateGrid.Click += BСreateGrid_Click;
            // 
            // BClear
            // 
            BClear.Location = new Point(585, 266);
            BClear.Name = "BClear";
            BClear.Size = new Size(94, 29);
            BClear.TabIndex = 5;
            BClear.Text = "Очистити";
            BClear.UseVisualStyleBackColor = true;
            BClear.Click += BClear_Click;
            // 
            // BClose
            // 
            BClose.Location = new Point(534, 310);
            BClose.Name = "BClose";
            BClose.Size = new Size(94, 29);
            BClose.TabIndex = 6;
            BClose.Text = "Вийти";
            BClose.UseVisualStyleBackColor = true;
            BClose.Click += BClose_Click;
            // 
            // NUD_rozmir
            // 
            NUD_rozmir.Location = new Point(628, 384);
            NUD_rozmir.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            NUD_rozmir.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_rozmir.Name = "NUD_rozmir";
            NUD_rozmir.ReadOnly = true;
            NUD_rozmir.Size = new Size(36, 27);
            NUD_rozmir.TabIndex = 7;
            NUD_rozmir.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_rozmir.ValueChanged += NUD_rozmir_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 8);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 8;
            label1.Text = "Матриця А коефіцієнтів СЛАР";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 216);
            label2.Name = "label2";
            label2.Size = new Size(261, 20);
            label2.TabIndex = 9;
            label2.Text = "Матриця С коефіцієнтів LU розкладу";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 8);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Вектор В";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 8);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 11;
            label4.Text = "Вектор Х";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 384);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 12;
            label5.Text = "Оберіть розмір матриці А:";
            // 
            // CB_method
            // 
            CB_method.FormattingEnabled = true;
            CB_method.Items.AddRange(new object[] { "LU розклад", "Метод Гауса" });
            CB_method.Location = new Point(547, 350);
            CB_method.Name = "CB_method";
            CB_method.Size = new Size(151, 28);
            CB_method.TabIndex = 13;
            CB_method.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 353);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 14;
            label6.Text = "Оберіть метод:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(CB_method);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NUD_rozmir);
            Controls.Add(BClose);
            Controls.Add(BClear);
            Controls.Add(BСreateGrid);
            Controls.Add(X_vector_dgv);
            Controls.Add(B_vector_dgv);
            Controls.Add(C_matrix_dgv);
            Controls.Add(A_matrix_dgv);
            Name = "Form1";
            Text = "XIO Метод LU ";
            ((System.ComponentModel.ISupportInitialize)A_matrix_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)C_matrix_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)B_vector_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)X_vector_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_rozmir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView A_matrix_dgv;
        private DataGridView C_matrix_dgv;
        private DataGridView B_vector_dgv;
        private DataGridView X_vector_dgv;
        private Button BСreateGrid;
        private Button BClear;
        private Button BClose;
        private NumericUpDown NUD_rozmir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CB_method;
        private Label label6;
    }
}
