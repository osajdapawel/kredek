
namespace PawelOsajdaZadanieDomowe1
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelShopStatus = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pbTea = new System.Windows.Forms.ProgressBar();
            this.pbBeer = new System.Windows.Forms.ProgressBar();
            this.pbToiletPaper = new System.Windows.Forms.ProgressBar();
            this.pbEggs = new System.Windows.Forms.ProgressBar();
            this.pbChips = new System.Windows.Forms.ProgressBar();
            this.labelTea = new System.Windows.Forms.Label();
            this.labelBeer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelMoneyValue = new System.Windows.Forms.Label();
            this.buttonLockDoor = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelTeaValue = new System.Windows.Forms.Label();
            this.buttonTeaPurchase = new System.Windows.Forms.Button();
            this.buttonBeerPurchase = new System.Windows.Forms.Button();
            this.labelBeerCost = new System.Windows.Forms.Label();
            this.buttonToiletPaperPurchase = new System.Windows.Forms.Button();
            this.labelToiletPaperCost = new System.Windows.Forms.Label();
            this.buttonEggsPurchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChipsPurchase = new System.Windows.Forms.Button();
            this.labelChipsCost = new System.Windows.Forms.Label();
            this.buttonAddMoneyLeft = new System.Windows.Forms.Button();
            this.buttonAddMoneyRight = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerKlocu = new System.Windows.Forms.Timer(this.components);
            this.timerShops = new System.Windows.Forms.Timer(this.components);
            this.timerMoney = new System.Windows.Forms.Timer(this.components);
            this.labelKlocuProbability = new System.Windows.Forms.Label();
            this.trackBarKlocuProbability = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKlocuProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShopStatus
            // 
            this.labelShopStatus.AutoSize = true;
            this.labelShopStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelShopStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShopStatus.ForeColor = System.Drawing.Color.Lime;
            this.labelShopStatus.Location = new System.Drawing.Point(939, 154);
            this.labelShopStatus.Name = "labelShopStatus";
            this.labelShopStatus.Size = new System.Drawing.Size(193, 31);
            this.labelShopStatus.TabIndex = 13;
            this.labelShopStatus.Text = "Sklepy otwarte";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpeed.ForeColor = System.Drawing.Color.Azure;
            this.labelSpeed.Location = new System.Drawing.Point(803, 389);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(136, 31);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "Prędkość:";
            // 
            // pbTea
            // 
            this.pbTea.Location = new System.Drawing.Point(237, 136);
            this.pbTea.Maximum = 15;
            this.pbTea.Name = "pbTea";
            this.pbTea.Size = new System.Drawing.Size(313, 31);
            this.pbTea.Step = 1;
            this.pbTea.TabIndex = 0;
            // 
            // pbBeer
            // 
            this.pbBeer.Location = new System.Drawing.Point(237, 246);
            this.pbBeer.Maximum = 15;
            this.pbBeer.Name = "pbBeer";
            this.pbBeer.Size = new System.Drawing.Size(313, 31);
            this.pbBeer.Step = 1;
            this.pbBeer.TabIndex = 1;
            // 
            // pbToiletPaper
            // 
            this.pbToiletPaper.Location = new System.Drawing.Point(237, 360);
            this.pbToiletPaper.Maximum = 15;
            this.pbToiletPaper.Name = "pbToiletPaper";
            this.pbToiletPaper.Size = new System.Drawing.Size(313, 31);
            this.pbToiletPaper.Step = 1;
            this.pbToiletPaper.TabIndex = 2;
            // 
            // pbEggs
            // 
            this.pbEggs.Location = new System.Drawing.Point(237, 472);
            this.pbEggs.Maximum = 15;
            this.pbEggs.Name = "pbEggs";
            this.pbEggs.Size = new System.Drawing.Size(313, 31);
            this.pbEggs.Step = 1;
            this.pbEggs.TabIndex = 3;
            // 
            // pbChips
            // 
            this.pbChips.Location = new System.Drawing.Point(237, 571);
            this.pbChips.Maximum = 15;
            this.pbChips.Name = "pbChips";
            this.pbChips.Size = new System.Drawing.Size(313, 31);
            this.pbChips.Step = 1;
            this.pbChips.TabIndex = 4;
            // 
            // labelTea
            // 
            this.labelTea.AutoSize = true;
            this.labelTea.BackColor = System.Drawing.Color.Transparent;
            this.labelTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTea.ForeColor = System.Drawing.Color.Azure;
            this.labelTea.Location = new System.Drawing.Point(120, 136);
            this.labelTea.Name = "labelTea";
            this.labelTea.Size = new System.Drawing.Size(111, 31);
            this.labelTea.TabIndex = 5;
            this.labelTea.Text = "Herbata";
            // 
            // labelBeer
            // 
            this.labelBeer.AutoSize = true;
            this.labelBeer.BackColor = System.Drawing.Color.Transparent;
            this.labelBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeer.ForeColor = System.Drawing.Color.Azure;
            this.labelBeer.Location = new System.Drawing.Point(158, 246);
            this.labelBeer.Name = "labelBeer";
            this.labelBeer.Size = new System.Drawing.Size(73, 31);
            this.labelBeer.TabIndex = 6;
            this.labelBeer.Text = "Piwo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(16, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Papier toaletowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(150, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jajka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(120, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chrupki";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoney.ForeColor = System.Drawing.Color.Azure;
            this.labelMoney.Location = new System.Drawing.Point(146, 44);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(84, 31);
            this.labelMoney.TabIndex = 10;
            this.labelMoney.Text = "Kasa:";
            // 
            // labelMoneyValue
            // 
            this.labelMoneyValue.AutoSize = true;
            this.labelMoneyValue.BackColor = System.Drawing.Color.Transparent;
            this.labelMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoneyValue.ForeColor = System.Drawing.Color.Azure;
            this.labelMoneyValue.Location = new System.Drawing.Point(236, 44);
            this.labelMoneyValue.Name = "labelMoneyValue";
            this.labelMoneyValue.Size = new System.Drawing.Size(191, 31);
            this.labelMoneyValue.TabIndex = 11;
            this.labelMoneyValue.Text = "ilosc pieniedzy";
            // 
            // buttonLockDoor
            // 
            this.buttonLockDoor.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLockDoor.Enabled = false;
            this.buttonLockDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLockDoor.Location = new System.Drawing.Point(945, 207);
            this.buttonLockDoor.Name = "buttonLockDoor";
            this.buttonLockDoor.Size = new System.Drawing.Size(203, 70);
            this.buttonLockDoor.TabIndex = 12;
            this.buttonLockDoor.Text = "Zamknij drzwi przed klocem";
            this.buttonLockDoor.UseVisualStyleBackColor = false;
            this.buttonLockDoor.Click += new System.EventHandler(this.buttonLockDoor_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarSpeed.LargeChange = 4;
            this.trackBarSpeed.Location = new System.Drawing.Point(945, 389);
            this.trackBarSpeed.Maximum = 12;
            this.trackBarSpeed.Minimum = 4;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarSpeed.Size = new System.Drawing.Size(203, 45);
            this.trackBarSpeed.TabIndex = 14;
            this.trackBarSpeed.Value = 7;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelTeaValue
            // 
            this.labelTeaValue.AutoSize = true;
            this.labelTeaValue.BackColor = System.Drawing.Color.Transparent;
            this.labelTeaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTeaValue.ForeColor = System.Drawing.Color.Azure;
            this.labelTeaValue.Location = new System.Drawing.Point(238, 188);
            this.labelTeaValue.Name = "labelTeaValue";
            this.labelTeaValue.Size = new System.Drawing.Size(97, 24);
            this.labelTeaValue.TabIndex = 16;
            this.labelTeaValue.Text = "Cena: 8 zł";
            // 
            // buttonTeaPurchase
            // 
            this.buttonTeaPurchase.Enabled = false;
            this.buttonTeaPurchase.Location = new System.Drawing.Point(366, 188);
            this.buttonTeaPurchase.Name = "buttonTeaPurchase";
            this.buttonTeaPurchase.Size = new System.Drawing.Size(90, 35);
            this.buttonTeaPurchase.TabIndex = 17;
            this.buttonTeaPurchase.Text = "Kup";
            this.buttonTeaPurchase.UseVisualStyleBackColor = true;
            this.buttonTeaPurchase.Click += new System.EventHandler(this.buttonTeaPurchase_Click);
            // 
            // buttonBeerPurchase
            // 
            this.buttonBeerPurchase.Enabled = false;
            this.buttonBeerPurchase.Location = new System.Drawing.Point(366, 292);
            this.buttonBeerPurchase.Name = "buttonBeerPurchase";
            this.buttonBeerPurchase.Size = new System.Drawing.Size(90, 35);
            this.buttonBeerPurchase.TabIndex = 19;
            this.buttonBeerPurchase.Text = "Kup";
            this.buttonBeerPurchase.UseVisualStyleBackColor = true;
            this.buttonBeerPurchase.Click += new System.EventHandler(this.buttonBeerPurchase_Click);
            // 
            // labelBeerCost
            // 
            this.labelBeerCost.AutoSize = true;
            this.labelBeerCost.BackColor = System.Drawing.Color.Transparent;
            this.labelBeerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeerCost.ForeColor = System.Drawing.Color.Azure;
            this.labelBeerCost.Location = new System.Drawing.Point(238, 292);
            this.labelBeerCost.Name = "labelBeerCost";
            this.labelBeerCost.Size = new System.Drawing.Size(97, 24);
            this.labelBeerCost.TabIndex = 18;
            this.labelBeerCost.Text = "Cena: 4 zł";
            // 
            // buttonToiletPaperPurchase
            // 
            this.buttonToiletPaperPurchase.Enabled = false;
            this.buttonToiletPaperPurchase.Location = new System.Drawing.Point(366, 411);
            this.buttonToiletPaperPurchase.Name = "buttonToiletPaperPurchase";
            this.buttonToiletPaperPurchase.Size = new System.Drawing.Size(90, 35);
            this.buttonToiletPaperPurchase.TabIndex = 21;
            this.buttonToiletPaperPurchase.Text = "Kup";
            this.buttonToiletPaperPurchase.UseVisualStyleBackColor = true;
            this.buttonToiletPaperPurchase.Click += new System.EventHandler(this.buttonToiletPaperPurchase_Click);
            // 
            // labelToiletPaperCost
            // 
            this.labelToiletPaperCost.AutoSize = true;
            this.labelToiletPaperCost.BackColor = System.Drawing.Color.Transparent;
            this.labelToiletPaperCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelToiletPaperCost.ForeColor = System.Drawing.Color.Azure;
            this.labelToiletPaperCost.Location = new System.Drawing.Point(238, 411);
            this.labelToiletPaperCost.Name = "labelToiletPaperCost";
            this.labelToiletPaperCost.Size = new System.Drawing.Size(107, 24);
            this.labelToiletPaperCost.TabIndex = 20;
            this.labelToiletPaperCost.Text = "Cena: 10 zł";
            // 
            // buttonEggsPurchase
            // 
            this.buttonEggsPurchase.Enabled = false;
            this.buttonEggsPurchase.Location = new System.Drawing.Point(366, 518);
            this.buttonEggsPurchase.Name = "buttonEggsPurchase";
            this.buttonEggsPurchase.Size = new System.Drawing.Size(90, 35);
            this.buttonEggsPurchase.TabIndex = 23;
            this.buttonEggsPurchase.Text = "Kup";
            this.buttonEggsPurchase.UseVisualStyleBackColor = true;
            this.buttonEggsPurchase.Click += new System.EventHandler(this.buttonEggsPurchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(238, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cena: 7 zł";
            // 
            // buttonChipsPurchase
            // 
            this.buttonChipsPurchase.Enabled = false;
            this.buttonChipsPurchase.Location = new System.Drawing.Point(366, 613);
            this.buttonChipsPurchase.Name = "buttonChipsPurchase";
            this.buttonChipsPurchase.Size = new System.Drawing.Size(90, 35);
            this.buttonChipsPurchase.TabIndex = 25;
            this.buttonChipsPurchase.Text = "Kup";
            this.buttonChipsPurchase.UseVisualStyleBackColor = true;
            this.buttonChipsPurchase.Click += new System.EventHandler(this.buttonChipsPurchase_Click);
            // 
            // labelChipsCost
            // 
            this.labelChipsCost.AutoSize = true;
            this.labelChipsCost.BackColor = System.Drawing.Color.Transparent;
            this.labelChipsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChipsCost.ForeColor = System.Drawing.Color.White;
            this.labelChipsCost.Location = new System.Drawing.Point(238, 613);
            this.labelChipsCost.Name = "labelChipsCost";
            this.labelChipsCost.Size = new System.Drawing.Size(97, 24);
            this.labelChipsCost.TabIndex = 24;
            this.labelChipsCost.Text = "Cena: 3 zł";
            // 
            // buttonAddMoneyLeft
            // 
            this.buttonAddMoneyLeft.Enabled = false;
            this.buttonAddMoneyLeft.Location = new System.Drawing.Point(237, 82);
            this.buttonAddMoneyLeft.Name = "buttonAddMoneyLeft";
            this.buttonAddMoneyLeft.Size = new System.Drawing.Size(90, 35);
            this.buttonAddMoneyLeft.TabIndex = 26;
            this.buttonAddMoneyLeft.Text = "Doładuj";
            this.buttonAddMoneyLeft.UseVisualStyleBackColor = true;
            this.buttonAddMoneyLeft.Click += new System.EventHandler(this.buttonAddMoneyLeft_Click);
            // 
            // buttonAddMoneyRight
            // 
            this.buttonAddMoneyRight.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddMoneyRight.Enabled = false;
            this.buttonAddMoneyRight.Location = new System.Drawing.Point(333, 82);
            this.buttonAddMoneyRight.Name = "buttonAddMoneyRight";
            this.buttonAddMoneyRight.Size = new System.Drawing.Size(90, 35);
            this.buttonAddMoneyRight.TabIndex = 27;
            this.buttonAddMoneyRight.Text = "Doładuj";
            this.buttonAddMoneyRight.UseVisualStyleBackColor = false;
            this.buttonAddMoneyRight.Click += new System.EventHandler(this.buttonAddMoneyRight_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(945, 44);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 35);
            this.buttonStart.TabIndex = 28;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1058, 44);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(90, 35);
            this.buttonStop.TabIndex = 29;
            this.buttonStop.Text = "Zakończ";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 500;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerKlocu
            // 
            this.timerKlocu.Interval = 1500;
            this.timerKlocu.Tick += new System.EventHandler(this.timerKlocu_Tick);
            // 
            // timerShops
            // 
            this.timerShops.Interval = 1000;
            this.timerShops.Tick += new System.EventHandler(this.timerShops_Tick);
            // 
            // timerMoney
            // 
            this.timerMoney.Interval = 800;
            this.timerMoney.Tick += new System.EventHandler(this.timerMoney_Tick);
            // 
            // labelKlocuProbability
            // 
            this.labelKlocuProbability.AutoSize = true;
            this.labelKlocuProbability.BackColor = System.Drawing.Color.Transparent;
            this.labelKlocuProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKlocuProbability.ForeColor = System.Drawing.Color.Azure;
            this.labelKlocuProbability.Location = new System.Drawing.Point(699, 453);
            this.labelKlocuProbability.Name = "labelKlocuProbability";
            this.labelKlocuProbability.Size = new System.Drawing.Size(246, 25);
            this.labelKlocuProbability.TabIndex = 30;
            this.labelKlocuProbability.Text = "Szanse na wizytę Kloca:";
            // 
            // trackBarKlocuProbability
            // 
            this.trackBarKlocuProbability.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarKlocuProbability.LargeChange = 4;
            this.trackBarKlocuProbability.Location = new System.Drawing.Point(945, 453);
            this.trackBarKlocuProbability.Minimum = 1;
            this.trackBarKlocuProbability.Name = "trackBarKlocuProbability";
            this.trackBarKlocuProbability.Size = new System.Drawing.Size(203, 45);
            this.trackBarKlocuProbability.TabIndex = 31;
            this.trackBarKlocuProbability.Value = 4;
            this.trackBarKlocuProbability.Scroll += new System.EventHandler(this.trackBarKlocuProbability_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PawelOsajdaZadanieDomowe1.Properties.Resources.home;
            this.ClientSize = new System.Drawing.Size(1180, 766);
            this.Controls.Add(this.trackBarKlocuProbability);
            this.Controls.Add(this.labelKlocuProbability);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAddMoneyRight);
            this.Controls.Add(this.buttonAddMoneyLeft);
            this.Controls.Add(this.buttonChipsPurchase);
            this.Controls.Add(this.labelChipsCost);
            this.Controls.Add(this.buttonEggsPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToiletPaperPurchase);
            this.Controls.Add(this.labelToiletPaperCost);
            this.Controls.Add(this.buttonBeerPurchase);
            this.Controls.Add(this.labelBeerCost);
            this.Controls.Add(this.buttonTeaPurchase);
            this.Controls.Add(this.labelTeaValue);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelShopStatus);
            this.Controls.Add(this.buttonLockDoor);
            this.Controls.Add(this.labelMoneyValue);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBeer);
            this.Controls.Add(this.labelTea);
            this.Controls.Add(this.pbChips);
            this.Controls.Add(this.pbEggs);
            this.Controls.Add(this.pbToiletPaper);
            this.Controls.Add(this.pbBeer);
            this.Controls.Add(this.pbTea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Symulator mieszkania";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKlocuProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbTea;
        private System.Windows.Forms.ProgressBar pbBeer;
        private System.Windows.Forms.ProgressBar pbToiletPaper;
        private System.Windows.Forms.ProgressBar pbEggs;
        private System.Windows.Forms.ProgressBar pbChips;
        private System.Windows.Forms.Label labelTea;
        private System.Windows.Forms.Label labelBeer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelMoneyValue;
        private System.Windows.Forms.Button buttonLockDoor;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelTeaValue;
        private System.Windows.Forms.Button buttonTeaPurchase;
        private System.Windows.Forms.Button buttonBeerPurchase;
        private System.Windows.Forms.Label labelBeerCost;
        private System.Windows.Forms.Button buttonToiletPaperPurchase;
        private System.Windows.Forms.Label labelToiletPaperCost;
        private System.Windows.Forms.Button buttonEggsPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChipsPurchase;
        private System.Windows.Forms.Label labelChipsCost;
        private System.Windows.Forms.Button buttonAddMoneyLeft;
        private System.Windows.Forms.Button buttonAddMoneyRight;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Timer timerKlocu;
        private System.Windows.Forms.Timer timerShops;
        private System.Windows.Forms.Timer timerMoney;
        private System.Windows.Forms.Label labelShopStatus;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelKlocuProbability;
        private System.Windows.Forms.TrackBar trackBarKlocuProbability;
    }
}

