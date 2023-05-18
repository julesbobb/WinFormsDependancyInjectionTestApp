
using CSharp.Forms;
using CSharp.Repository.Interfaces;
using CSharp.Repository.Services;
using System.CodeDom;
using System.Configuration;

namespace CSharp.MainApp
{
    public partial class MainForm : Form
    {
        private readonly IHelloWorkRepository _repository;

        public MainForm(IHelloWorkRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello);
        }

        private void bnOpenForm_Click(object sender, EventArgs e)
        {
            using var form = ServiceConfiguration.CreateForm<Form1>();
            form.ShowDialog();
        }
    }
}