using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawelOsajdaZadanieDomowe2
{
    public partial class FormMain : Form
    {
       
        Random random = new Random();                                   // obiekt typu Random, który posłuży do otrzymania wartości "losowych"
        Factory factory = new Factory();                                // obiekt typu Factory służący do tworzenia obiektów, w naszym przypadku tylko pasażerów i kierowców
        List<BusStop> busStopsList = new List<BusStop>();               // lista wszystkich przystanków obsługiwanych w programie
        List<Driver> driversList = new List<Driver>();                  // lista wszystkich kierowców w programie 
        Bus bus = new Bus();                                            // główny obiekt tyu Bus
        List<DataGridView> dataGridViews = new List<DataGridView>();    // lista elemntów typu DataGridView, w tym programie zapisane do niej są tylko takie DataGridy, które wyświetlaja listy pasażerów przystanków
    
        /// <summary>
        /// Funkcja odświeżająca wybrany dataGridView, działa poprawnie tylko z DataGridami przystanków 
        /// </summary>
        /// <param name="dataGrid">Datagrid do zmniany</param>
        /// <param name="numberOnStopList">Numer przystanku </param>
        private void RefreshBusStopDataGrid(DataGridView dataGrid, int numberOnBusStopList)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = busStopsList[numberOnBusStopList].passengers;
            dataGrid.Columns["Destination"].DisplayIndex = 3;
            dataGrid.Columns[1].Width = 70;
            dataGrid.Columns[2].Width = 80;
            dataGrid.Columns[3].Width = 31;
        }

        /// <summary>
        /// Funkcja odświeżająca DataGridView odpowiadający za listę kierowców
        /// </summary>
        private void RefreshDriverListDataGrid()
        {
            dataGridViewDriversList.DataSource = null;
            dataGridViewDriversList.DataSource = driversList;
            dataGridViewDriversList.Columns["YearsOfExperience"].DisplayIndex = 3;
            dataGridViewDriversList.Columns[1].Width = 70;
            dataGridViewDriversList.Columns[2].Width = 80;
            dataGridViewDriversList.Columns[3].Width = 33;
        }

        /// <summary>
        /// Funkcja odświeżająca DataGrid pasażerów autobusu
        /// </summary>
        private void RefreshBusPassengerDataGrid()
        {
            dataGridViewBusPassengersList.DataSource = null;
            dataGridViewBusPassengersList.DataSource = bus.passengersToTransport;
            dataGridViewBusPassengersList.Columns["Destination"].DisplayIndex = 3;
            dataGridViewBusPassengersList.Columns[1].Width = 70;
            dataGridViewBusPassengersList.Columns[2].Width = 80;
            dataGridViewBusPassengersList.Columns[3].Width = 33;
        }

        public FormMain()
        {
            InitializeComponent();

            busStopsList.Add(new BusStop("Hallera"));
            busStopsList.Add(new BusStop("Traugutta"));
            busStopsList.Add(new BusStop("Sienkiewicza"));
            busStopsList.Add(new BusStop("Wyszynskiego"));

            driversList.Add(new Driver("Jarek", "Walczykiewicz", 60, 30));
            driversList.Add(new Driver("Mirek", "Kowalczyk", 50, 25));
            driversList.Add(new Driver("Gienek", "Laskowski", 60, 10));
            driversList.Add(new Driver("Sylwek", "Mikołajczyk", 30, 5));

            bus.CurrentBusStop = busStopsList[0];
            textBoxCurrentBusStop.Text = busStopsList[0].ToString();
            bus.driver = driversList[3];
            textBoxCurrentDriver.Text = driversList[3].FirstName + " " + driversList[3].LastName;

            dataGridViews.Add(dataGridViewBusStop1PassengerList);
            dataGridViews.Add(dataGridViewBusStop2PassengerList);
            dataGridViews.Add(dataGridViewBusStop3PassengerList);
            dataGridViews.Add(dataGridViewBusStop4PassengerList);

            RefreshDriverListDataGrid();
            dataGridViewBusStopsList.DataSource = busStopsList;
            
            timerAddPassenger.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Przycisk odpowiadający za dodanie pasażera na pierwszym przystanku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPasengerBusStop1_Click(object sender, EventArgs e)
        {
            busStopsList[0].passengers.Add(factory.CreatePassengerAtBusStop(busStopsList[0], busStopsList));

            RefreshBusStopDataGrid(dataGridViewBusStop1PassengerList, 0);
            
/*            dataGridViewBusStop1PassengerList.DataSource = null;
            dataGridViewBusStop1PassengerList.DataSource = busStopsList[0].passengers;
            dataGridViewBusStop1PassengerList.Columns["Destination"].DisplayIndex = 3;
            dataGridViewBusStop1PassengerList.Columns[1].Width = 70;
            dataGridViewBusStop1PassengerList.Columns[2].Width = 80;
            dataGridViewBusStop1PassengerList.Columns[3].Width = 33;*/
            
        }

        /// <summary>
        /// Przycisk odpowiadający za dodanie pasażera na drugim przystanku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPasengerBusStop2_Click(object sender, EventArgs e)
        {
            busStopsList[1].passengers.Add(factory.CreatePassengerAtBusStop(busStopsList[1], busStopsList));
            dataGridViewBusStop2PassengerList.DataSource = null;
            dataGridViewBusStop2PassengerList.DataSource = busStopsList[1].passengers;
            dataGridViewBusStop2PassengerList.Columns["Destination"].DisplayIndex = 3;
            dataGridViewBusStop2PassengerList.Columns[1].Width = 70;
            dataGridViewBusStop2PassengerList.Columns[2].Width = 80;
            dataGridViewBusStop2PassengerList.Columns[3].Width = 33;
        }

        /// <summary>
        /// Przycisk odpowiadający za dodanie pasażera na trzecim przystanku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPasengerBusStop3_Click(object sender, EventArgs e)
        {
            busStopsList[2].passengers.Add(factory.CreatePassengerAtBusStop(busStopsList[2], busStopsList));
            dataGridViewBusStop3PassengerList.DataSource = null;
            dataGridViewBusStop3PassengerList.DataSource = busStopsList[2].passengers;
            dataGridViewBusStop3PassengerList.Columns["Destination"].DisplayIndex = 3;
            dataGridViewBusStop3PassengerList.Columns[1].Width = 70;
            dataGridViewBusStop3PassengerList.Columns[2].Width = 80;
            dataGridViewBusStop3PassengerList.Columns[3].Width = 33;
        }

        /// <summary>
        /// Przycisk odpowiadający za dodanie pasażera na czwartym przystanku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPasengerBusStop4_Click(object sender, EventArgs e)
        {
            busStopsList[3].passengers.Add(factory.CreatePassengerAtBusStop(busStopsList[3], busStopsList));
            dataGridViewBusStop4PassengerList.DataSource = null;
            dataGridViewBusStop4PassengerList.DataSource = busStopsList[3].passengers;
            dataGridViewBusStop4PassengerList.Columns["Destination"].DisplayIndex = 3;
            dataGridViewBusStop4PassengerList.Columns[1].Width = 70;
            dataGridViewBusStop4PassengerList.Columns[2].Width = 80;
            dataGridViewBusStop4PassengerList.Columns[3].Width = 33;
        }

        /// <summary>
        /// Przycisk odpowiadający za zatwierdzenie nazwy przystanku po wpisaniu jej w text boxa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmBusStop_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Destination = busStopsList.Where(p => p.Name == textBoxNextStop.Text).First();
            }
            catch (Exception)
            {

                MessageBox.Show("Wprowadź poprawną nazwę przystanku!");
            }            
        }

        /// <summary>
        /// Funkcja obsługująca wywołania timera odpowiadającego za dodawanie na losowych przystankach co określony czas pasażera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAddPassenger_Tick(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, busStopsList.Count());
            busStopsList[randomNumber].passengers.Add(factory.CreatePassengerAtBusStop(busStopsList[randomNumber], busStopsList));

            RefreshBusStopDataGrid(dataGridViews[randomNumber], randomNumber);


        }

        /// <summary>
        /// Przycisk odpowiadający za wywołanie funkcji Load z obiektu typu Bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            bus.Load();
            RefreshBusPassengerDataGrid();

            RefreshBusStopDataGrid(dataGridViews[busStopsList.Where(p => p == bus.CurrentBusStop).FirstOrDefault().Number], busStopsList.Where(p => p == bus.CurrentBusStop).FirstOrDefault().Number);
            buttonLoad.Enabled = false;
            buttonTransport.Enabled = true;
        }

        /// <summary>
        /// Przycisk odpowiadający za wywołanie funkcji Empty z obiektu typu Bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            bus.Empty();
            RefreshBusPassengerDataGrid();
            buttonLoad.Enabled = true;
            buttonEmpty.Enabled = false;
        }

        /// <summary>
        /// Przycisk odpowiadający za wywołanie funkcji Transport z obiektu typu Bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransport_Click(object sender, EventArgs e)
        {
            if(bus.Transport())
            {
                MessageBox.Show("Nastąpiło zdarzenie drogowe, pasażerowie w wieku do lat 5 oraz powyżej 60 roku życia trafili na badania! \nAutobus jest sprawny. Dokończy kurs.");
                dataGridViewBusPassengersList.DataSource = null;
            }
            RefreshBusPassengerDataGrid();

            textBoxCurrentBusStop.Text = bus.CurrentBusStop.ToString();
            textBoxNextStop.Text = "";
            buttonEmpty.Enabled = true;
            buttonTransport.Enabled = false;
        }

        /// <summary>
        /// Funkcja odpoiadająca za obsługę kliknięć w dataGridViewBusStopsList. Po kliknięciu na wybrany element jest on wybierany jako przystanek docelowy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBusStopsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedBusStop = dataGridViewBusStopsList.SelectedRows[0].DataBoundItem as BusStop;
            bus.Destination = selectedBusStop;
            textBoxNextStop.Text = selectedBusStop.Name;
        }

        /// <summary>
        /// Funkcja odpoiadająca za obsługę kliknięć w dataGridViewDriversList. Po kliknięciu na wybrany element jest on wybierany jako kierowca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDriversList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedDriver =  dataGridViewDriversList.SelectedRows[0].DataBoundItem as Driver;
            bus.driver = selectedDriver;
            textBoxCurrentDriver.Text = selectedDriver.FirstName + " " + selectedDriver.LastName;
        }

        /// <summary>
        /// Przycisk odpowiadający za wylosowanie przystanku docelowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandomBusStop_Click(object sender, EventArgs e)
        {
            BusStop randomBusStop = null;

            do
            {
                randomBusStop = busStopsList[random.Next(0, busStopsList.Count())];
            } while (randomBusStop == bus.CurrentBusStop);

            bus.Destination = randomBusStop;
            textBoxNextStop.Text = randomBusStop.ToString();
        }

        /// <summary>
        /// Przycisk dodający nowego kierowcę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            driversList.Add(factory.CreateDriver());

            busStopsList[1].passengers.Add(factory.CreatePassengerAtBusStop(busStopsList[1], busStopsList));
            RefreshDriverListDataGrid();
        }
    }
}
