using System;
using System.Windows.Forms;

public class SimpleForm : Form
{
    private TextBox textBox;
    private Button button;

    public SimpleForm()
    {
        textBox = new TextBox();
        textBox.Location = new System.Drawing.Point(20, 20);
        textBox.Width = 200;

        button = new Button();
        button.Text = "Button";
        button.Location = new System.Drawing.Point(20, 60);
        button.Click += new EventHandler(Button_Click);

        this.Controls.Add(textBox);
        this.Controls.Add(button);

        this.Text = "Form";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Width = 300;
        this.Height = 150;
    }

    private void Button_Click(object sender, EventArgs e)
    {
        textBox.Text = "Pressed Button";
    }

    public static void Main()
    {
        Application.Run(new SimpleForm());
    }
}
