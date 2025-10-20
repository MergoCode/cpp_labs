namespace Lab5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            radioMDP = new RadioButton();
            radioMN = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(106, 37);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Оберіть метод";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(94, 177);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Оберіть рівняння";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(496, 37);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Вхідні дані";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 63);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 3;
            label4.Text = "а=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 137);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 4;
            label5.Text = "b=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 208);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Eps=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(418, 287);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 6;
            label7.Text = "Kmax=";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(851, 37);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 7;
            label8.Text = "Результати";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(750, 63);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 8;
            label9.Text = "Корінь х*=";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(692, 137);
            label10.Name = "label10";
            label10.Size = new Size(131, 20);
            label10.TabIndex = 9;
            label10.Text = "Кількість ітерацій";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "x^2 - 4 = 0", "3x - 4log(x) - 5 = 0", "x^3 - 3x^2 + 7 = 0" });
            comboBox2.Location = new Point(94, 200);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(782, 311);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Розв'язати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(920, 311);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Очистити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(829, 346);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 14;
            button3.Text = "Закрити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(474, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(474, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(474, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(840, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(829, 134);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 20;
            // 
            // radioMDP
            // 
            radioMDP.Location = new Point(106, 82);
            radioMDP.Name = "radioMDP";
            radioMDP.Size = new Size(201, 24);
            radioMDP.TabIndex = 23;
            radioMDP.Text = "Метод Ділення навпіл";
            radioMDP.CheckedChanged += radioMDP_CheckedChanged;
            // 
            // radioMN
            // 
            radioMN.AutoSize = true;
            radioMN.Location = new Point(106, 112);
            radioMN.Name = "radioMN";
            radioMN.Size = new Size(141, 24);
            radioMN.TabIndex = 22;
            radioMN.TabStop = true;
            radioMN.Text = "Метод Ньютона";
            radioMN.UseVisualStyleBackColor = true;
            radioMN.CheckedChanged += radioMN_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 574);
            Controls.Add(radioMN);
            Controls.Add(radioMDP);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Н.В.В Розв'язання нелінійних рівнянь за МДН та МН";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton radioMDP;
        private RadioButton radioMN;
    }
}
