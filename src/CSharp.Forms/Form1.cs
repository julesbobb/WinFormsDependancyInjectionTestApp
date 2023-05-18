using CSharp.Forms.Data.Models;
using CSharp.Repository.Interfaces;

namespace CSharp.Forms
{
    public partial class Form1 : Form
    {

        private readonly IHelloWorkRepository _repository;
        private readonly IUsersRepository _dbContext;

        public Form1(IHelloWorkRepository repository, IUsersRepository usersRepository)
        {
            _repository = repository;
            _dbContext = usersRepository;

            InitializeComponent();
        }

        private void bnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_repository.SayHello);
        }

        private async void bnAddUser_Click(object sender, EventArgs e)
        {
            await AddUser();
        }

        private async Task AddUser()
        {
            string userName = tbUserName.Text;
            if (userName.Length > 0)
            {
                if (await _dbContext.UserExists(userName))
                {
                    MessageBox.Show($"User {userName} already exists");
                }
                else
                {
                    await _dbContext.Add(new Data.Models.User(userName));
                    userBindingSource.DataSource = await _dbContext.GetAll();
                    tbUserName.Clear();
                    tbUserName.Focus();
                }
            }
        }

        private async void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                await AddUser();

        }

        private async void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row?.DataBoundItem != null)
                await _dbContext.Delete((User)e.Row.DataBoundItem);
        }

        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
                await _dbContext.Update((User)dataGridView1.Rows[e.RowIndex].DataBoundItem);
        }

        private async void bnRefresh_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = await _dbContext.GetAll();
        }
    }
}
