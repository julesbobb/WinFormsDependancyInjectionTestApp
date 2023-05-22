using CSharp.Repository.Interfaces;
using CSharp.Repository.Services;

namespace CSharp.Forms
{
    public partial class UserControl1 : UserControl
    {

        private readonly IHelloWorkRepository? _repository;

        public UserControl1()
        {
            if (ServiceLocator.ServiceProvider != null)
                _repository = ServiceLocator.GetService<IHelloWorkRepository>();
            
            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository?.SayHello);
        }
    }
}
