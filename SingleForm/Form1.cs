namespace SingleForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = FormFactory.GetForm<Form2>();
        form.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var form2 = FormFactory.GetForm<Form3>();
        form2.Show();
    }
}