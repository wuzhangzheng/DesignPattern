using System.ComponentModel;

namespace SingleForm;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }
    protected override void OnClosing(CancelEventArgs e)
    {
        e.Cancel = true;
        this.Hide();
        Console.WriteLine();
    }
}