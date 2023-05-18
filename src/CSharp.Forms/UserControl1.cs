using CSharp.Repository.Interfaces;
using CSharp.Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Forms
{
    public partial class UserControl1 : UserControl
    {

        private readonly IHelloWorkRepository _repository;

        public UserControl1()
        {
            _repository = ServiceConfiguration.GetProviderService<IHelloWorkRepository>();
            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello);
        }
    }
}
