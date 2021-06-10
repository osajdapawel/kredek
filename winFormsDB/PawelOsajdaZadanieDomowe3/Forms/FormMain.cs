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
using PawelOsajdaZadanieDomowe3.Forms;

namespace PawelOsajdaZadanieDomowe3
{   
    /// <summary>
    /// Klasa głównego okna aplikacji
    /// </summary>
    public partial class FormMain : Form
    {
        // obiekt repozytorium laptopów do wykonywania operacji na tymże repozytorium
        LaptopsRepository laptopsRepository = new LaptopsRepository();

        /// <summary>
        /// Konstruktor okna głównego
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Metoda wywoływana podczas ładownaia okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewLaptops();
        }

        /// <summary>
        /// Metoda odświeżająca dane laptopów w DataGridzie
        /// </summary>
        private void RefreshDataGridViewLaptops()
        {
            dataGridViewLaptops.DataSource = null;
            dataGridViewLaptops.DataSource = laptopsRepository.GetLaptops();
            dataGridViewLaptops.Columns[0].Width = 40;
            dataGridViewLaptops.Columns[1].Width = 208;
            dataGridViewLaptops.Columns[2].Width = 60;
            dataGridViewLaptops.Columns[3].Width = 156;
            dataGridViewLaptops.Columns[4].Width = 50;
            dataGridViewLaptops.Columns[5].Width = 136;
            dataGridViewLaptops.Columns[6].Width = 50;
            dataGridViewLaptops.Columns[7].Width = 50;
            dataGridViewLaptops.Columns[8].Width = 50;
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku logowania - pojawi się nowe okno obsługujące logowanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin LoginForm = new FormLogin();
            LoginForm.Show();          
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku kup - pojawi się okno informujące o konieczności zalogowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyUserNotLogged_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Najpierw musisz się zalogować");
        }
    }
}
