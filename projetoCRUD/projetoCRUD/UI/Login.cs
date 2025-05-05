using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoCRUD.BLL;

namespace projetoCRUD.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private readonly UserService _userService = new UserService();
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text;
            var senha = txtSenha.Text;
            var user = new projetoCRUD.Models.User();
            try
            {
                user = _userService.Login(login, senha);
                Console.WriteLine(user);
                if (user != null)
                {
                    MessageBox.Show("Login successful!");
                    // Proceed to the next form or functionality
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            MostrarFilme mostrarFilme = new ();
            mostrarFilme.Show();

        }
    }
}
