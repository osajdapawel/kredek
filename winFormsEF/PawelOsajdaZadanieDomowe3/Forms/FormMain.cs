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
            dataGridViewLaptops.DataSource = laptopsRepository.GetLaptopsViewModel();
            dataGridViewLaptops.Columns[0].Width = 40;      // id
            dataGridViewLaptops.Columns[0].HeaderText = "Nr";     
            dataGridViewLaptops.Columns[1].Width = 208;     // model
            dataGridViewLaptops.Columns[1].HeaderText = "Model";
            dataGridViewLaptops.Columns[2].Width = 60;      // cena
            dataGridViewLaptops.Columns[2].HeaderText = "Cena";
            dataGridViewLaptops.Columns[3].Width = 156;     //model proca
            dataGridViewLaptops.Columns[3].HeaderText = "Procesor";
            dataGridViewLaptops.Columns[4].Width = 50;      // rdzenie
            dataGridViewLaptops.Columns[4].HeaderText = "Rdzenie";
            dataGridViewLaptops.Columns[5].Width = 136;     // karta
            dataGridViewLaptops.Columns[5].HeaderText = "Karta graficzna";
            dataGridViewLaptops.Columns[6].Width = 50;      // vram
            dataGridViewLaptops.Columns[6].HeaderText = "VRam";
            dataGridViewLaptops.Columns[7].Width = 50;      // ram
            dataGridViewLaptops.Columns[7].HeaderText = "Ram";
            dataGridViewLaptops.Columns[8].Width = 50;      // quantity
            dataGridViewLaptops.Columns[8].HeaderText = "Ilość";
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
