using PawelOsajdaZadanieDomowe3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawelOsajdaZadanieDomowe3.Forms
{
    public partial class FormLoggedUser : Form
    {
        // zmienna opisująca aktualnie wybranego laptopa
        int checkedLaptopId = 0;
        // zmienna przechowująca wybraną liczbę laptopów do kupienia
        int checkedQuantity = 1;

        // zmienna opisująca to czy nie dokonano jeszcze zamówienia
        bool orderWasNotCreated = true;
        // zmienna przechowujaca nr zamówienia, które tworzone jest podczas pierwszego kliknięcia na przycisk "Dodaj do koszyka"
        int createdOrderId = 0;

        // obiekty repozytoriów do wykonywania operacji na tychże ropozytoriach
        LaptopsRepository laptopsRepository = new LaptopsRepository();
        UsersRepository usersRepository = new UsersRepository();
        SubordersRepository subordersRepository = new SubordersRepository();
        OrdersRepository ordersRepository = new OrdersRepository();

        // obiekt formsa koszyka 
        FormCart formCart;

        /// <summary>
        /// Konstruktor 
        /// </summary>
        public FormLoggedUser()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Metoda wywoływana podczas ładownaia okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoggedUser_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewLaptops();
            RefreshTextAndComboBox();
            linkLabelUserData.Text = usersRepository.getName(Program.currentUserId) + "  Wyloguj";
        }

        /// <summary>
        /// Metoda odświeżająca zawartość DataGridViewLaptops
        /// </summary>
        private void RefreshDataGridViewLaptops()
        {
            dataGridViewLaptops.DataSource = null;
            dataGridViewLaptops.DataSource = laptopsRepository.GetLaptops();
            dataGridViewLaptops.Columns[0].Width = 40;      // id
            dataGridViewLaptops.Columns[1].Width = 208;
            dataGridViewLaptops.Columns[2].Width = 60;
            dataGridViewLaptops.Columns[3].Width = 156;
            dataGridViewLaptops.Columns[4].Width = 50;
            dataGridViewLaptops.Columns[5].Width = 136;
            dataGridViewLaptops.Columns[6].Width = 50;
            dataGridViewLaptops.Columns[7].Width = 50;
            dataGridViewLaptops.Columns[8].Width = 50;      // quantity
        }

        /// <summary>
        /// Metoda odświeżająca zawartość jedynego textBoxa i comboBoxa na formie
        /// </summary>
        private void RefreshTextAndComboBox()
        {
            checkedLaptopId = (int)dataGridViewLaptops.SelectedRows[0].Cells[0].Value;
            
            // wpisanie nazwy laptopa do textboxa nie łącząc się z bazą danych tylko pobierając z dataGrida
            textBoxCheckedLaptop.Text = dataGridViewLaptops.SelectedRows[0].Cells[1].Value.ToString();

            // ogólna liczba laptopów
            int quantity = (int)dataGridViewLaptops.SelectedRows[0].Cells[8].Value;

            // dodaj do dropdownu comboboxa wszystkie liczby od 1 do quantity
            List<int> lista = Enumerable.Range(1, quantity).ToList();
            comboBoxQuantity.DataSource = lista;

            if (quantity != 0)
                buttonAddToCart.Enabled = true;
            else
                buttonAddToCart.Enabled = false;
        }

        /// <summary>
        /// Metoda wywoływana po wybraniu nowego elementu w comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedQuantity = (int)(comboBoxQuantity.SelectedValue);
            //MessageBox.Show(checkedQuantity.ToString());
        }

        /// <summary>
        /// Metoda wywoływana po wybraniu nowego elementu w GridViewLaptops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewLaptops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTextAndComboBox();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku dodawania elementu do koszyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (orderWasNotCreated)
            {
                createdOrderId = ordersRepository.CreateOrder(Program.currentUserId);
                orderWasNotCreated = false;
                formCart = new FormCart(createdOrderId);
            }
            
            subordersRepository.CreateSuborder(createdOrderId, checkedLaptopId, checkedQuantity);
            laptopsRepository.DecreaseLaptopNumber(checkedLaptopId, checkedQuantity);

            RefreshTextAndComboBox();
            RefreshDataGridViewLaptops();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku koszyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCart_Click(object sender, EventArgs e)
        {
            if (orderWasNotCreated)
                MessageBox.Show("Pusto tutaj.\nDodaj coś do koszyka.");
            else
            {
                formCart.Show();
            }
        }

        /// <summary>
        /// Link Labelka wyświetlająca imię i nazwisko usera oraz opcję wylogowywania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelUserData_MouseClick(object sender, MouseEventArgs e)
        {
            Program.currentUserId = 0;
            Close();
        }

        /// <summary>
        /// Metoda wywoływana przy zamykaniu formsa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoggedUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(formCart != null)
                formCart.Close();
        }
    }
}
