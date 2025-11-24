namespace Lab_8_dop2
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
            btnCreate = new Button();
            btnClone = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(158, 128);
            label1.Name = "label1";
            label1.Size = new Size(456, 281);
            label1.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(158, 56);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(188, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Original";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClone
            // 
            btnClone.Location = new Point(442, 56);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(172, 29);
            btnClone.TabIndex = 2;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            btnClone.Click += btnClone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClone);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCreate;
        private Button btnClone;
    }
}
