using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PawelOsajdaZadanieDomowe3.Repositories;

namespace PawelOsajdaZadanieDomowe3.Forms
{
    /// <summary>
    /// Klasa okna logowania
    /// </summary>
    public partial class FormLogin : Form
    {
        // obiekt repozytorium użytkowników do wykonywania operacji na tymże repozytorium
        UsersRepository usersRepositroy = new UsersRepository();

        /// <summary>
        /// Konstruktor okna logowania
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu na przycisk zaloguj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            String login = textBoxLogin.Text;
            String password = textBoxPassword.Text;

            int UserId = usersRepositroy.Login(login, password);
            
            if (UserId != 0)
            {
                Program.currentUserId = UserId;
                Close();
                new FormLoggedUser().Show();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                new FormMain().Show();
            }
        }
    }
}
