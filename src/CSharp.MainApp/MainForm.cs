using CSharp.Forms;
using CSharp.Repository.Interfaces;

namespace CSharp.MainApp
{
    public partial class MainForm : Form
    {
        private readonly IHelloWorkRepository _repository;
        private readonly IFormFactory _formFactory;

        public MainForm(IHelloWorkRepository repository, IFormFactory formFactory)
        {
            _formFactory = formFactory;
            _repository = repository;
            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello);
        }

        private void bnOpenForm_Click(object sender, EventArgs e)
        {
            using var form = _formFactory.CreateForm<Form1>();
            form.ShowDialog();
        }
    }
}