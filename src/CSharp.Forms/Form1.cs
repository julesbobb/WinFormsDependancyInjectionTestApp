using CSharp.Repository.Interfaces;
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
    public partial class Form1 : Form
    {

        private readonly IHelloWorkRepository _repository;

        public Form1(IHelloWorkRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello);
        }
    }
}
