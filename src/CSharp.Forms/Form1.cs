using CSharp.Forms.Data.Models;
using CSharp.Repository.Interfaces;

namespace CSharp.Forms
{
    public partial class Form1 : Form
    {

        private readonly IUsersRepository _dbContext;

        public Form1(IUsersRepository usersRepository)
        {
            _dbContext = usersRepository;

            InitializeComponent();
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

        private async void bnRefresh_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = await _dbContext.GetAll();
        }
    }
}
