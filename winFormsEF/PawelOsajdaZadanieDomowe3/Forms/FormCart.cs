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
    /// Klasa okna koszyka
    /// </summary>
    public partial class FormCart : Form
    {
        // zmienna przechowująca numer zamówienia, które jest obsługiwane, przypisanie watości następuje w konstruktorze
        private int orderId;

        // obiekty repozytoriów do wykonywania operacji na tychże ropozytoriach
        SubordersRepository subordersRepository = new SubordersRepository();
        DeliveriesRepository deliveriesRepository = new DeliveriesRepository();
        OrdersRepository ordersRepository = new OrdersRepository();

        // lista przechowująca nazwę typu dostawy oraz jej cenę
        List<(string s, int n)> listOfDeliveries;


        /// <summary>
        /// Konstruktor FormCart
        /// </summary>
        /// <param name="orderId">Numer zamówienia, dla którego koszyk jest wywoływany</param>
        public FormCart(int orderId)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.orderId = orderId;
        }

        /// <summary>
        /// Metoda wywoływana podczas ładownaia okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCart_Load(object sender, EventArgs e)
        {
            dataGridViewLaptopsInCart.DataSource = subordersRepository.GetSubordersOfParticularOrder(orderId);
            dataGridViewLaptopsInCart.Columns[0].Width = 256;

            listOfDeliveries = deliveriesRepository.getDeliveryTypes();
            comboBoxDeliveryType.DataSource = listOfDeliveries.Select(p => p.s).ToList();
        }

        /// <summary>
        /// Metoda wywoływana po wybraniu nowego elementu w comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDeliveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDeliveryPrice.Text = listOfDeliveries.Where( p =>  p.s == comboBoxDeliveryType.Text ).First().n.ToString();
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu na przycisk kup - do zamówienia zostanie przypisana dostawa oraz status "niespakowane"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            ordersRepository.FinaliseOrder(orderId, comboBoxDeliveryType.Text);

            MessageBox.Show("Kupiono, ale nie obawiaj się, nic Ci nie pobrało z portfela, bo to biedny program :'( ");
        }
    }
}
