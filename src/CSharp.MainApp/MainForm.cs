using CSharp.Forms;
using CSharp.Repository.Interfaces;

namespace CSharp.MainApp
{
    public partial class MainForm : Form
    {
        private readonly IFormFactory _formFactory;

        public MainForm(IFormFactory formFactory)
        {
            _formFactory = formFactory;
            InitializeComponent();
        }

        private void bnOpenForm_Click(object sender, EventArgs e)
        {
            using var form = _formFactory.CreateForm<Form1>();
            form.ShowDialog();
        }
    }
}