using CSharp.Forms.Data.Models;
using CSharp.Repository.Interfaces;
using Microsoft.Extensions.Logging;

namespace CSharp.Forms
{
    public partial class Form1 : Form
    {

        private readonly IUsersRepository _userRepository;
        private readonly ILogger _logger;

        public Form1(IUsersRepository usersRepository, ILogger<Form1> logger)
        {
            _logger = logger;
            _userRepository = usersRepository;

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
                if (await _userRepository.UserExists(userName))
                {
                    _logger.LogError($"User {userName} already exists");
                    MessageBox.Show($"User {userName} already exists");
                }
                else
                {
                    await _userRepository.Add(new Data.Models.User(userName));
                    userBindingSource.DataSource = await _userRepository.GetAll();
                    _logger.LogInformation($"Added user {userName}");
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
            {
                User item = (User)e.Row.DataBoundItem;
                await _userRepository.Delete(item);
                _logger.LogWarning($"Deleted user {item.Name}");
            }
        }

        private async void bnRefresh_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = await _userRepository.GetAll();
        }
    }
}
