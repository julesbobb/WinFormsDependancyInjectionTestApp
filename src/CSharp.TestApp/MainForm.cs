using CSharp.Repository;
using CSharp.Repository.Interfaces;

namespace CSharp.TestApp
{
    public partial class MainForm : Form
    {
        private readonly IHelloWorkRepository _repository;

        public MainForm()
        {
            _repository = ServiceConfiguration.GetProviderService<IHelloWorkRepository>();
            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello());
        }

    }
}