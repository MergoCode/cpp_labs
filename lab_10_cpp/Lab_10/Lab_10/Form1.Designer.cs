namespace Lab_10
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
            X0_dgv = new DataGridView();
            X_dgv = new DataGridView();
            textBoxEps = new TextBox();
            textBoxKmax = new TextBox();
            textBoxIter = new TextBox();
            buttonSolve = new Button();
            labelDebug = new Label();
            ((System.ComponentModel.ISupportInitialize)X0_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)X_dgv).BeginInit();
            SuspendLayout();
            // 
            // X0_dgv
            // 
            X0_dgv.AllowUserToAddRows = false;
            X0_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            X0_dgv.ColumnHeadersVisible = false;
            X0_dgv.Location = new Point(46, 88);
            X0_dgv.Name = "X0_dgv";
            X0_dgv.RowHeadersVisible = false;
            X0_dgv.RowHeadersWidth = 51;
            X0_dgv.Size = new Size(217, 188);
            X0_dgv.TabIndex = 0;
            // 
            // X_dgv
            // 
            X_dgv.AllowUserToAddRows = false;
            X_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            X_dgv.ColumnHeadersVisible = false;
            X_dgv.Location = new Point(561, 88);
            X_dgv.Name = "X_dgv";
            X_dgv.RowHeadersVisible = false;
            X_dgv.RowHeadersWidth = 51;
            X_dgv.Size = new Size(182, 188);
            X_dgv.TabIndex = 1;
            // 
            // textBoxEps
            // 
            textBoxEps.Location = new Point(357, 97);
            textBoxEps.Name = "textBoxEps";
            textBoxEps.Size = new Size(125, 27);
            textBoxEps.TabIndex = 2;
            // 
            // textBoxKmax
            // 
            textBoxKmax.Location = new Point(357, 161);
            textBoxKmax.Name = "textBoxKmax";
            textBoxKmax.Size = new Size(125, 27);
            textBoxKmax.TabIndex = 3;
            // 
            // textBoxIter
            // 
            textBoxIter.Location = new Point(561, 301);
            textBoxIter.Name = "textBoxIter";
            textBoxIter.Size = new Size(125, 27);
            textBoxIter.TabIndex = 4;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(633, 35);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(94, 29);
            buttonSolve.TabIndex = 5;
            buttonSolve.Text = "button1";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // labelDebug
            // 
            labelDebug.AutoSize = true;
            labelDebug.Location = new Point(357, 226);
            labelDebug.Name = "labelDebug";
            labelDebug.Size = new Size(50, 20);
            labelDebug.TabIndex = 6;
            labelDebug.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDebug);
            Controls.Add(buttonSolve);
            Controls.Add(textBoxIter);
            Controls.Add(textBoxKmax);
            Controls.Add(textBoxEps);
            Controls.Add(X_dgv);
            Controls.Add(X0_dgv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)X0_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)X_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView X0_dgv;
        private DataGridView X_dgv;
        private TextBox textBoxEps;
        private TextBox textBoxKmax;
        private TextBox textBoxIter;
        private Button buttonSolve;
        private Label labelDebug;
    }
}
