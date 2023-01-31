using System.ComponentModel;

namespace SingleForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
