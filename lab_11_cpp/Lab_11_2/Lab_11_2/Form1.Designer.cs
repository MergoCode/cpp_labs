namespace Lab_11_2
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
            buttonCheck = new Button();
            textBoxRate = new TextBox();
            labelOutput = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(317, 12);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(125, 29);
            buttonCheck.TabIndex = 0;
            buttonCheck.Text = "Перевірити";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(317, 47);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(125, 27);
            textBoxRate.TabIndex = 1;
            // 
            // labelOutput
            // 
            labelOutput.BorderStyle = BorderStyle.FixedSingle;
            labelOutput.Location = new Point(224, 100);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(318, 313);
            labelOutput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 50);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "Ціна долара в гривнях";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelOutput);
            Controls.Add(textBoxRate);
            Controls.Add(buttonCheck);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCheck;
        private TextBox textBoxRate;
        private Label labelOutput;
        private Label label2;
    }
}
