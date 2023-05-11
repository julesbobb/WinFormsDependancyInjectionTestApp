using DotNet6CSharp.Repository;
using DotNet6CSharp.Repository.Interfaces;

namespace DotNet6CSharp.TestApp
{
    public partial class MainForm : Form
    {
        private readonly IHelloWorkRepository _repository;

        public MainForm()
        {
            _repository = ServiceConfiguration.GetProviderService<IHelloWorkRepository>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello());
        }
    }
}