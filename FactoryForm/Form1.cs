namespace FactoryForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        var frmName = e.Node.Tag.ToString();
        var form = FormFactory.CreateForm(frmName);
        if (form != null) form.Show();
    }

    private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
    {
    }
}