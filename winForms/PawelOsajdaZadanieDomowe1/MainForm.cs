using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawelOsajdaZadanieDomowe1
{  

    public partial class MainForm : Form
    {
        
        Random random = new Random();       // utworzenie obiektu służącego do losowania liczb;

        // deklaracja zasobów
        int money;                          // Zmienna przechowująca aktualnie posiadaną ilość pieniędzy
        int tea;                            // Zmienna przechowująca aktualną ilość herbaty
        int beer;                           // Zmienna przechowująca aktualną ilość piwa
        int toiletPaper;                    // Zmienna przechowująca aktualną ilość papieru toaletowego
        int eggs;                           // Zmienna przechowująca aktualną ilość jajek
        int chips;                          // Zmienna przechowująca aktualną ilość paczek chrupków
        
        // delkaracja zmiennych opisujących zachowanie symulacji
        int speed = 7;                      // zmienna definiująca szybkość symulacji; więcej = wolniej, min = 4 - najszybciej, max=12 - najwolniej
        int klocuProbability = 4;           // zmienna definiująca jak często współlokator o pseudonimie Klocu chce wejść do mieszkania i zużyć nasze zasoby  

        // deklaracja cen poszczególnych zasobów
        int teaCost = 8;                    // Koszt zakupu herbaty
        int beerCost = 4;                   // Koszt zakupu piwa
        int toiletPaperCost = 10;           // Koszt zakupu papieru toaletowego
        int eggsCost = 7;                   // Koszt zakupu jaj
        int chipsCost = 3;                  // Koszt zakupu paczki chrupków

        /// <summary>
        /// Funkcja ustawiająca domyślne wartości wszstkich zasobów
        /// </summary>
        void SetDefaultValues()
        {
            money = 50;
            tea = 10;
            beer = 10;
            toiletPaper = 10;
            eggs = 10;
            chips = 10;
        }

        /// <summary>
        /// Funkcja odejmująca zasoby
        /// </summary>
        /// <param name="teaToSubtract">Ilość herbaty do odjęcia; domyślnie 1</param>
        /// <param name="beerToSubtract">Ilość piwa do odjęcia; domyślnie 1</param>
        /// <param name="toiletPaperToSubtract">Ilość papieru toaletowego do odjęcia; domyślnie 1</param>
        /// <param name="eggsToSubtract">Ilość jajek do odjęcia; domyślnie 1</param>
        /// <param name="chipsToSubtract">Ilość paczek chrupków do odjęcia; domyślnie 1</param>
        /// <returns>Zwraca 0 jeśli żaden z zasobów nie został wyczerpany</returns>
        int SubtractResources(int teaToSubtract = 1, int beerToSubtract = 1, int toiletPaperToSubtract = 1, int eggsToSubtract = 1, int chipsToSubtract = 1)
        {
            int emptyResourceNumber = 0;
            
            tea -= teaToSubtract;
            if (tea < 0) 
            { 
                tea = 0;
                emptyResourceNumber = 1;
            }    
               
            beer -= beerToSubtract;
            if (beer < 0)
            {
                beer = 0;            
                emptyResourceNumber = 2;
            }

            toiletPaper -= toiletPaperToSubtract;
            if (toiletPaper < 0)
            {
                toiletPaper = 0;
                emptyResourceNumber = 3;
            }

            eggs -= eggsToSubtract;
            if (eggs < 0)
            {
                eggs = 0;
                emptyResourceNumber = 4;
            }
            
            chips -= chipsToSubtract;
            if (chips < 0)
            {
                chips = 0;
                emptyResourceNumber = 5;
            }
            RefreshResources();
            return emptyResourceNumber;
        }

        /// <summary>
        /// Funkcja zatrzymująca wszystkie timery
        /// </summary>
        void StopTimers()
        {
            timerMain.Stop();
            timerShops.Stop();
            timerKlocu.Stop();
            timerMoney.Stop();
        }

        /// <summary>
        /// Funkcja realizująca odejmująca zasoby, po zużyciu ich przez Kloca - wspólokatora, przed którym należy zamykać drzwi
        /// </summary>
        /// <returns>Zwraca 0 jeśli żaden z zasobów nie został wyczerpany</returns>
        int SuddenKlocuAttack ()
        {
            int resultOfSubstractResources = SubtractResources(random.Next(0, 3), random.Next(0, 3), random.Next(0, 2), random.Next(0, 2), random.Next(0, 3));
            RefreshResources();
            return resultOfSubstractResources;
        }

        /// <summary>
        /// Funkcja zwracjąca prawdę w (klocuProbability*10) procentach wywołań
        /// </summary>
        /// <returns>Zwraca prawdę w około (klocuProbability*10) procentach wywołań</returns>
        bool KlocuProbabilityGenerator()
        {
            if (random.Next(1, 10) < klocuProbability)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Funkcja doładowująca pieniądze oraz aktualizująca ich wartość na ekranie
        /// </summary>
        /// <param name="moneyToAdd"> Ilośc pieniędzy do doładowania </param>
        void AddMoney(int moneyToAdd)
        {
            money += moneyToAdd;
            labelMoneyValue.Text = money.ToString();
        }

        /// <summary>
        /// Funkcja zamykająca sklepy - wyłączenie możliwości kupowania oraz zmieniająca wygląd labelShopStatus
        /// </summary>
        void CloseShops()
        {
            buttonTeaPurchase.Enabled = false;
            buttonBeerPurchase.Enabled = false;
            buttonToiletPaperPurchase.Enabled = false;
            buttonEggsPurchase.Enabled = false;
            buttonChipsPurchase.Enabled = false;
            labelShopStatus.ForeColor = Color.OrangeRed;
            labelShopStatus.Text = "Sklepy zamknięte";
        }

        /// <summary>
        /// Funkcja otwierająca sklepy - włączenie możliwości kupowania oraz zmieniająca wygląd labelShopStatus
        /// </summary>
        void OpenShops()
        {
            buttonTeaPurchase.Enabled = true;
            buttonBeerPurchase.Enabled = true;
            buttonToiletPaperPurchase.Enabled = true;
            buttonEggsPurchase.Enabled = true;
            buttonChipsPurchase.Enabled = true;
            labelShopStatus.ForeColor = Color.Lime;
            labelShopStatus.Text = "Sklepy otwarte";
        }

        /// <summary>
        /// Funkcja odświeżająca wartośc zasobów na ekranie  
        /// </summary>
        void RefreshResources()
        {
            labelMoneyValue.Text = money.ToString();
            pbTea.Value = tea;
            pbBeer.Value = beer;
            pbToiletPaper.Value = toiletPaper;
            pbEggs.Value = eggs;
            pbChips.Value = chips;
            labelMoneyValue.Text = money.ToString();
        }

        /// <summary>
        /// Funkcja ustawiająca parametry początkowe niektórych elementów interfejsu
        /// </summary>
        void SetComponentDefaultProperies()
        {
            labelShopStatus.ForeColor = Color.Azure;
            labelShopStatus.Text = "Status sklepów";
            buttonLockDoor.Enabled = false;
        }

        // konstruktor MainForm
        public MainForm()
        {
            InitializeComponent();
        }

        // funkcja uruchamiana po zainicjalizowaniu obiektu FormMain
        private void MainForm_Load(object sender, EventArgs e)
        {
            pbTea.Maximum = 15;
            pbEggs.Maximum = 15;
            pbBeer.Maximum = 15;
            pbToiletPaper.Maximum = 15;
            pbChips.Maximum = 15;
            trackBarSpeed.Value = speed;
            trackBarKlocuProbability.Value = klocuProbability;
            SetDefaultValues();
            RefreshResources();
            SetComponentDefaultProperies();
        }

        /// <summary>
        /// Przycisk włączający lub resetujący symulację 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            RefreshResources();
            SetComponentDefaultProperies();
            OpenShops();
            timerMain.Start();
            timerMoney.Start();

            buttonStart.Text = "Restart";
        }

        /// <summary>
        /// Przycisk zatrzymujący symulację
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopTimers();
            buttonStart.Text = "Start";
        }

        /// <summary>
        /// Przycisk umożliwiający zamknięcie drzwi przed Klocem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLockDoor_Click(object sender, EventArgs e)
        {
            timerKlocu.Stop();
            buttonLockDoor.BackColor = SystemColors.Control;
            buttonLockDoor.Enabled = false;
        }
      
        /// <summary>
        /// Funkcja uruchamiająca wywołanie timera głównego odpowiadajcego za wywoływanie zdarzeń odejmowania zasobów, próby wejścia Kloca do mieszkania oraz zamykanie/otwieranie sklepów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            if ( KlocuProbabilityGenerator() )
            {
                buttonLockDoor.BackColor = Color.OrangeRed;
                buttonLockDoor.Enabled = true;
                timerKlocu.Start();
            }
            
            if(random.Next(1,10) == 1)                                                    
            {
                if(SubtractResources() != 0)
                {
                    StopTimers();
                    MessageBox.Show("Niestety nie udało Ci się dopilnować zasobów w mieszkaniu. \n \nGra skończona!");
                }

            }

            if(random.Next(1,10) == 1)
            {
                CloseShops();
                timerShops.Start();
            }

        }

        /// <summary>
        /// Funkcja uruchamiająca wywołanie timera odpowiadającego za obsługe zużycia przez współlokatora Kloca zasobów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerKlocu_Tick(object sender, EventArgs e)
        {
            timerKlocu.Stop();
            if(SuddenKlocuAttack() != 0)
            {
                StopTimers();
                MessageBox.Show("Niestety nie udało Ci się dopilnować zasobów w mieszkaniu. \nKlocu jest niezadowolony \n \nGra skończona!");
            }
            buttonLockDoor.BackColor = SystemColors.Control;
            buttonLockDoor.Enabled = false;
        }

        /// <summary>
        /// Funkcja uruchamiająca wywołanie timera odpowiadającego za włączenie wcześniej zamkniętych sklepów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerShops_Tick(object sender, EventArgs e)
        {
            OpenShops();
            timerShops.Stop();
        }

        /// <summary>
        /// Funkcja obsługująca wzbudzenia timerMoney odpowiadająca za losowe włączanie/wyłączanie przycisków doładowujących pieniądze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMoney_Tick(object sender, EventArgs e)
        {
            int randomValue = random.Next(0, 6);                // pomocnicza zmienna przechowująca wylosowaną liczbę służącą do wprowadzenia elementu losowości do symulacji                

            if (randomValue == 1)
            {
                buttonAddMoneyLeft.BackColor = Color.Lime;
                buttonAddMoneyLeft.Enabled = true;
                buttonAddMoneyRight.BackColor = SystemColors.Control;
                buttonAddMoneyRight.Enabled = false;
            }
            else if (randomValue == 2)
            {
                buttonAddMoneyLeft.BackColor = SystemColors.Control;
                buttonAddMoneyLeft.Enabled = false;
                buttonAddMoneyRight.BackColor = Color.Lime;
                buttonAddMoneyRight.Enabled = true;
            }
            else
            {
                buttonAddMoneyLeft.BackColor = SystemColors.Control;
                buttonAddMoneyLeft.Enabled = false;
                buttonAddMoneyRight.BackColor = SystemColors.Control;
                buttonAddMoneyRight.Enabled = false;
            }

        }

        /// <summary>
        /// Trackbar odpowiadający za zmianę prędkości działania symulacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            speed = trackBarSpeed.Value;
            timerMain.Interval = trackBarSpeed.Value * 100;
        }

        /// <summary>
        /// Trackbar odpowiadający za poziom trudności - zmieniający częstotliwość wizyt współlokatora Kloca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarKlocuProbability_Scroll(object sender, EventArgs e)
        {
            klocuProbability = trackBarKlocuProbability.Value;
        }

        /// <summary>
        /// Lewy przycisk dodający pieniądze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMoneyLeft_Click(object sender, EventArgs e)
        {
            AddMoney(random.Next(10, 35));
        }

        /// <summary>
        /// Przycisk przycisk dodający pieniądze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMoneyRight_Click(object sender, EventArgs e)
        {
            AddMoney(random.Next(10, 35));
        }


        /// <summary>
        /// Przycisk odpowiadający za kupno herbaty oraz pomniejszenie ilości pieniędzy o koszt zakupu tego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTeaPurchase_Click(object sender, EventArgs e)
        {
            if(tea < 15 && money >= teaCost)
            {
                tea++;
                money -= teaCost;
                RefreshResources();
            }
            
        }

        /// <summary>
        /// Przycisk odpowiadający za kupno piwa oraz pomniejszenie ilości pieniędzy o koszt zakupu tego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBeerPurchase_Click(object sender, EventArgs e)
        {
            if (beer < 15 && money >= beerCost)
            {
                beer++;
                money -= beerCost;
                RefreshResources();
            }
        }

        /// <summary>
        /// Przycisk odpowiadający za kupno papieru toaletowego oraz pomniejszenie ilości pieniędzy o koszt zakupu tego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToiletPaperPurchase_Click(object sender, EventArgs e)
        {
            if (toiletPaper < 15 && money >= toiletPaperCost)
            {
                toiletPaper++;
                money -= toiletPaperCost;
                RefreshResources();
            }
        }

        /// <summary>
        /// Przycisk odpowiadający za kupno jaj oraz pomniejszenie ilości pieniędzy o koszt zakupu tego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEggsPurchase_Click(object sender, EventArgs e)
        {
            if (eggs < 15 && money >= eggsCost)
            {
                eggs++;
                money -= eggsCost;
                RefreshResources();
            }
        }

        /// <summary>
        /// Przycisk odpowiadający za kupno paczek chrupków oraz pomniejszenie ilości pieniędzy o koszt zakupu tego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChipsPurchase_Click(object sender, EventArgs e)
        {
            if (chips < 15 && money >= chipsCost)
            {
                chips++;
                money -= chipsCost;
                RefreshResources();
            }
        }

    }
}
