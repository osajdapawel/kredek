
namespace PawelOsajdaZadanieDomowe2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBusStopsList = new System.Windows.Forms.DataGridView();
            this.labelBusStopList = new System.Windows.Forms.Label();
            this.dataGridViewBusPassengersList = new System.Windows.Forms.DataGridView();
            this.labelBusPassengersList = new System.Windows.Forms.Label();
            this.dataGridViewBusStop3PassengerList = new System.Windows.Forms.DataGridView();
            this.dataGridViewBusStop4PassengerList = new System.Windows.Forms.DataGridView();
            this.dataGridViewBusStop1PassengerList = new System.Windows.Forms.DataGridView();
            this.dataGridViewBusStop2PassengerList = new System.Windows.Forms.DataGridView();
            this.labelBusStop1PassengerList = new System.Windows.Forms.Label();
            this.labelBusStop3PassengerList = new System.Windows.Forms.Label();
            this.labelBusStop4PassengerList = new System.Windows.Forms.Label();
            this.labelBusStop2PassengerList = new System.Windows.Forms.Label();
            this.labelBusInformation = new System.Windows.Forms.Label();
            this.labelNextStopChooser = new System.Windows.Forms.Label();
            this.textBoxNextStop = new System.Windows.Forms.TextBox();
            this.labelDriversList = new System.Windows.Forms.Label();
            this.buttonConfirmBusStop = new System.Windows.Forms.Button();
            this.buttonRandomBusStop = new System.Windows.Forms.Button();
            this.dataGridViewDriversList = new System.Windows.Forms.DataGridView();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.labelCurrentDriver = new System.Windows.Forms.Label();
            this.timerAddPassenger = new System.Windows.Forms.Timer(this.components);
            this.buttonAddPasengerBusStop1 = new System.Windows.Forms.Button();
            this.buttonAddPasengerBusStop2 = new System.Windows.Forms.Button();
            this.buttonAddPasengerBusStop3 = new System.Windows.Forms.Button();
            this.buttonAddPasengerBusStop4 = new System.Windows.Forms.Button();
            this.labelCurrentBusStop = new System.Windows.Forms.Label();
            this.textBoxCurrentBusStop = new System.Windows.Forms.TextBox();
            this.textBoxCurrentDriver = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.buttonTransport = new System.Windows.Forms.Button();
            this.labelNextStopHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStopsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusPassengersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop3PassengerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop4PassengerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop1PassengerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop2PassengerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriversList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBusStopsList
            // 
            this.dataGridViewBusStopsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusStopsList.Location = new System.Drawing.Point(1039, 350);
            this.dataGridViewBusStopsList.MultiSelect = false;
            this.dataGridViewBusStopsList.Name = "dataGridViewBusStopsList";
            this.dataGridViewBusStopsList.ReadOnly = true;
            this.dataGridViewBusStopsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBusStopsList.Size = new System.Drawing.Size(320, 174);
            this.dataGridViewBusStopsList.TabIndex = 0;
            this.dataGridViewBusStopsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBusStopsList_CellContentClick);
            this.dataGridViewBusStopsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBusStopsList_CellContentClick);
            // 
            // labelBusStopList
            // 
            this.labelBusStopList.AutoSize = true;
            this.labelBusStopList.Location = new System.Drawing.Point(1037, 334);
            this.labelBusStopList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusStopList.Name = "labelBusStopList";
            this.labelBusStopList.Size = new System.Drawing.Size(94, 13);
            this.labelBusStopList.TabIndex = 1;
            this.labelBusStopList.Text = "Lista przystanków:";
            // 
            // dataGridViewBusPassengersList
            // 
            this.dataGridViewBusPassengersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusPassengersList.Location = new System.Drawing.Point(1039, 27);
            this.dataGridViewBusPassengersList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBusPassengersList.MultiSelect = false;
            this.dataGridViewBusPassengersList.Name = "dataGridViewBusPassengersList";
            this.dataGridViewBusPassengersList.ReadOnly = true;
            this.dataGridViewBusPassengersList.RowTemplate.Height = 24;
            this.dataGridViewBusPassengersList.Size = new System.Drawing.Size(324, 288);
            this.dataGridViewBusPassengersList.TabIndex = 2;
            // 
            // labelBusPassengersList
            // 
            this.labelBusPassengersList.AutoSize = true;
            this.labelBusPassengersList.Location = new System.Drawing.Point(1037, 11);
            this.labelBusPassengersList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusPassengersList.Name = "labelBusPassengersList";
            this.labelBusPassengersList.Size = new System.Drawing.Size(143, 13);
            this.labelBusPassengersList.TabIndex = 3;
            this.labelBusPassengersList.Text = "Lista pasażerów w autobusie";
            // 
            // dataGridViewBusStop3PassengerList
            // 
            this.dataGridViewBusStop3PassengerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusStop3PassengerList.Location = new System.Drawing.Point(16, 317);
            this.dataGridViewBusStop3PassengerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBusStop3PassengerList.MultiSelect = false;
            this.dataGridViewBusStop3PassengerList.Name = "dataGridViewBusStop3PassengerList";
            this.dataGridViewBusStop3PassengerList.ReadOnly = true;
            this.dataGridViewBusStop3PassengerList.RowTemplate.Height = 24;
            this.dataGridViewBusStop3PassengerList.Size = new System.Drawing.Size(324, 207);
            this.dataGridViewBusStop3PassengerList.TabIndex = 4;
            // 
            // dataGridViewBusStop4PassengerList
            // 
            this.dataGridViewBusStop4PassengerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusStop4PassengerList.Location = new System.Drawing.Point(364, 317);
            this.dataGridViewBusStop4PassengerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBusStop4PassengerList.MultiSelect = false;
            this.dataGridViewBusStop4PassengerList.Name = "dataGridViewBusStop4PassengerList";
            this.dataGridViewBusStop4PassengerList.ReadOnly = true;
            this.dataGridViewBusStop4PassengerList.RowTemplate.Height = 24;
            this.dataGridViewBusStop4PassengerList.Size = new System.Drawing.Size(324, 207);
            this.dataGridViewBusStop4PassengerList.TabIndex = 5;
            // 
            // dataGridViewBusStop1PassengerList
            // 
            this.dataGridViewBusStop1PassengerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusStop1PassengerList.Location = new System.Drawing.Point(16, 27);
            this.dataGridViewBusStop1PassengerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBusStop1PassengerList.MultiSelect = false;
            this.dataGridViewBusStop1PassengerList.Name = "dataGridViewBusStop1PassengerList";
            this.dataGridViewBusStop1PassengerList.ReadOnly = true;
            this.dataGridViewBusStop1PassengerList.RowTemplate.Height = 24;
            this.dataGridViewBusStop1PassengerList.Size = new System.Drawing.Size(324, 207);
            this.dataGridViewBusStop1PassengerList.TabIndex = 6;
            // 
            // dataGridViewBusStop2PassengerList
            // 
            this.dataGridViewBusStop2PassengerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusStop2PassengerList.Location = new System.Drawing.Point(364, 27);
            this.dataGridViewBusStop2PassengerList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBusStop2PassengerList.MultiSelect = false;
            this.dataGridViewBusStop2PassengerList.Name = "dataGridViewBusStop2PassengerList";
            this.dataGridViewBusStop2PassengerList.ReadOnly = true;
            this.dataGridViewBusStop2PassengerList.RowTemplate.Height = 24;
            this.dataGridViewBusStop2PassengerList.Size = new System.Drawing.Size(324, 207);
            this.dataGridViewBusStop2PassengerList.TabIndex = 7;
            // 
            // labelBusStop1PassengerList
            // 
            this.labelBusStop1PassengerList.AutoSize = true;
            this.labelBusStop1PassengerList.Location = new System.Drawing.Point(14, 11);
            this.labelBusStop1PassengerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusStop1PassengerList.Name = "labelBusStop1PassengerList";
            this.labelBusStop1PassengerList.Size = new System.Drawing.Size(191, 13);
            this.labelBusStop1PassengerList.TabIndex = 8;
            this.labelBusStop1PassengerList.Text = "Lista pasażerów na przystanku Hallera:";
            // 
            // labelBusStop3PassengerList
            // 
            this.labelBusStop3PassengerList.AutoSize = true;
            this.labelBusStop3PassengerList.Location = new System.Drawing.Point(14, 302);
            this.labelBusStop3PassengerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusStop3PassengerList.Name = "labelBusStop3PassengerList";
            this.labelBusStop3PassengerList.Size = new System.Drawing.Size(220, 13);
            this.labelBusStop3PassengerList.TabIndex = 9;
            this.labelBusStop3PassengerList.Text = "Lista pasażerów na przystanku Sienkiewicza:";
            // 
            // labelBusStop4PassengerList
            // 
            this.labelBusStop4PassengerList.AutoSize = true;
            this.labelBusStop4PassengerList.Location = new System.Drawing.Point(362, 302);
            this.labelBusStop4PassengerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusStop4PassengerList.Name = "labelBusStop4PassengerList";
            this.labelBusStop4PassengerList.Size = new System.Drawing.Size(223, 13);
            this.labelBusStop4PassengerList.TabIndex = 10;
            this.labelBusStop4PassengerList.Text = "Lista pasażerów na przystanku Wyszyńskiego";
            // 
            // labelBusStop2PassengerList
            // 
            this.labelBusStop2PassengerList.AutoSize = true;
            this.labelBusStop2PassengerList.Location = new System.Drawing.Point(362, 11);
            this.labelBusStop2PassengerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusStop2PassengerList.Name = "labelBusStop2PassengerList";
            this.labelBusStop2PassengerList.Size = new System.Drawing.Size(204, 13);
            this.labelBusStop2PassengerList.TabIndex = 11;
            this.labelBusStop2PassengerList.Text = "Lista pasażerów na przystanku Traugutta:";
            // 
            // labelBusInformation
            // 
            this.labelBusInformation.AutoSize = true;
            this.labelBusInformation.Location = new System.Drawing.Point(711, 11);
            this.labelBusInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusInformation.Name = "labelBusInformation";
            this.labelBusInformation.Size = new System.Drawing.Size(98, 13);
            this.labelBusInformation.TabIndex = 12;
            this.labelBusInformation.Text = "Obsługa autobusu:";
            // 
            // labelNextStopChooser
            // 
            this.labelNextStopChooser.AutoSize = true;
            this.labelNextStopChooser.Location = new System.Drawing.Point(711, 82);
            this.labelNextStopChooser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNextStopChooser.Name = "labelNextStopChooser";
            this.labelNextStopChooser.Size = new System.Drawing.Size(112, 13);
            this.labelNextStopChooser.TabIndex = 13;
            this.labelNextStopChooser.Text = "Następny przystanek: ";
            // 
            // textBoxNextStop
            // 
            this.textBoxNextStop.Location = new System.Drawing.Point(713, 118);
            this.textBoxNextStop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNextStop.Name = "textBoxNextStop";
            this.textBoxNextStop.Size = new System.Drawing.Size(305, 20);
            this.textBoxNextStop.TabIndex = 14;
            // 
            // labelDriversList
            // 
            this.labelDriversList.AutoSize = true;
            this.labelDriversList.Location = new System.Drawing.Point(710, 208);
            this.labelDriversList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDriversList.Name = "labelDriversList";
            this.labelDriversList.Size = new System.Drawing.Size(86, 13);
            this.labelDriversList.TabIndex = 15;
            this.labelDriversList.Text = "Lista kierowców:";
            // 
            // buttonConfirmBusStop
            // 
            this.buttonConfirmBusStop.Location = new System.Drawing.Point(868, 142);
            this.buttonConfirmBusStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmBusStop.Name = "buttonConfirmBusStop";
            this.buttonConfirmBusStop.Size = new System.Drawing.Size(73, 22);
            this.buttonConfirmBusStop.TabIndex = 16;
            this.buttonConfirmBusStop.Text = "Zatwierdź";
            this.buttonConfirmBusStop.UseVisualStyleBackColor = true;
            this.buttonConfirmBusStop.Click += new System.EventHandler(this.buttonConfirmBusStop_Click);
            // 
            // buttonRandomBusStop
            // 
            this.buttonRandomBusStop.Location = new System.Drawing.Point(945, 142);
            this.buttonRandomBusStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomBusStop.Name = "buttonRandomBusStop";
            this.buttonRandomBusStop.Size = new System.Drawing.Size(73, 22);
            this.buttonRandomBusStop.TabIndex = 17;
            this.buttonRandomBusStop.Text = "Losuj";
            this.buttonRandomBusStop.UseVisualStyleBackColor = true;
            this.buttonRandomBusStop.Click += new System.EventHandler(this.buttonRandomBusStop_Click);
            // 
            // dataGridViewDriversList
            // 
            this.dataGridViewDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriversList.Location = new System.Drawing.Point(714, 223);
            this.dataGridViewDriversList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDriversList.MultiSelect = false;
            this.dataGridViewDriversList.Name = "dataGridViewDriversList";
            this.dataGridViewDriversList.ReadOnly = true;
            this.dataGridViewDriversList.RowTemplate.Height = 24;
            this.dataGridViewDriversList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDriversList.Size = new System.Drawing.Size(305, 207);
            this.dataGridViewDriversList.TabIndex = 18;
            this.dataGridViewDriversList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriversList_CellClick);
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(929, 434);
            this.buttonAddDriver.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(90, 27);
            this.buttonAddDriver.TabIndex = 19;
            this.buttonAddDriver.Text = "Dodaj kierowce";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // labelCurrentDriver
            // 
            this.labelCurrentDriver.AutoSize = true;
            this.labelCurrentDriver.Location = new System.Drawing.Point(711, 160);
            this.labelCurrentDriver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDriver.Name = "labelCurrentDriver";
            this.labelCurrentDriver.Size = new System.Drawing.Size(90, 13);
            this.labelCurrentDriver.TabIndex = 21;
            this.labelCurrentDriver.Text = "Obecny kierowca";
            // 
            // timerAddPassenger
            // 
            this.timerAddPassenger.Interval = 5000;
            this.timerAddPassenger.Tick += new System.EventHandler(this.timerAddPassenger_Tick);
            // 
            // buttonAddPasengerBusStop1
            // 
            this.buttonAddPasengerBusStop1.Location = new System.Drawing.Point(251, 239);
            this.buttonAddPasengerBusStop1.Name = "buttonAddPasengerBusStop1";
            this.buttonAddPasengerBusStop1.Size = new System.Drawing.Size(90, 27);
            this.buttonAddPasengerBusStop1.TabIndex = 23;
            this.buttonAddPasengerBusStop1.Text = "Dodaj pasażera";
            this.buttonAddPasengerBusStop1.UseVisualStyleBackColor = true;
            this.buttonAddPasengerBusStop1.Click += new System.EventHandler(this.buttonAddPasengerBusStop1_Click);
            // 
            // buttonAddPasengerBusStop2
            // 
            this.buttonAddPasengerBusStop2.Location = new System.Drawing.Point(599, 239);
            this.buttonAddPasengerBusStop2.Name = "buttonAddPasengerBusStop2";
            this.buttonAddPasengerBusStop2.Size = new System.Drawing.Size(90, 27);
            this.buttonAddPasengerBusStop2.TabIndex = 24;
            this.buttonAddPasengerBusStop2.Text = "Dodaj pasażera";
            this.buttonAddPasengerBusStop2.UseVisualStyleBackColor = true;
            this.buttonAddPasengerBusStop2.Click += new System.EventHandler(this.buttonAddPasengerBusStop2_Click);
            // 
            // buttonAddPasengerBusStop3
            // 
            this.buttonAddPasengerBusStop3.Location = new System.Drawing.Point(252, 529);
            this.buttonAddPasengerBusStop3.Name = "buttonAddPasengerBusStop3";
            this.buttonAddPasengerBusStop3.Size = new System.Drawing.Size(90, 27);
            this.buttonAddPasengerBusStop3.TabIndex = 25;
            this.buttonAddPasengerBusStop3.Text = "Dodaj pasażera";
            this.buttonAddPasengerBusStop3.UseVisualStyleBackColor = true;
            this.buttonAddPasengerBusStop3.Click += new System.EventHandler(this.buttonAddPasengerBusStop3_Click);
            // 
            // buttonAddPasengerBusStop4
            // 
            this.buttonAddPasengerBusStop4.Location = new System.Drawing.Point(599, 529);
            this.buttonAddPasengerBusStop4.Name = "buttonAddPasengerBusStop4";
            this.buttonAddPasengerBusStop4.Size = new System.Drawing.Size(90, 27);
            this.buttonAddPasengerBusStop4.TabIndex = 26;
            this.buttonAddPasengerBusStop4.Text = "Dodaj pasażera";
            this.buttonAddPasengerBusStop4.UseVisualStyleBackColor = true;
            this.buttonAddPasengerBusStop4.Click += new System.EventHandler(this.buttonAddPasengerBusStop4_Click);
            // 
            // labelCurrentBusStop
            // 
            this.labelCurrentBusStop.AutoSize = true;
            this.labelCurrentBusStop.Location = new System.Drawing.Point(711, 35);
            this.labelCurrentBusStop.Name = "labelCurrentBusStop";
            this.labelCurrentBusStop.Size = new System.Drawing.Size(101, 13);
            this.labelCurrentBusStop.TabIndex = 28;
            this.labelCurrentBusStop.Text = "Obecny przystanek:";
            // 
            // textBoxCurrentBusStop
            // 
            this.textBoxCurrentBusStop.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCurrentBusStop.Location = new System.Drawing.Point(711, 52);
            this.textBoxCurrentBusStop.Name = "textBoxCurrentBusStop";
            this.textBoxCurrentBusStop.ReadOnly = true;
            this.textBoxCurrentBusStop.Size = new System.Drawing.Size(307, 20);
            this.textBoxCurrentBusStop.TabIndex = 29;
            // 
            // textBoxCurrentDriver
            // 
            this.textBoxCurrentDriver.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCurrentDriver.Location = new System.Drawing.Point(714, 178);
            this.textBoxCurrentDriver.Name = "textBoxCurrentDriver";
            this.textBoxCurrentDriver.ReadOnly = true;
            this.textBoxCurrentDriver.Size = new System.Drawing.Size(304, 20);
            this.textBoxCurrentDriver.TabIndex = 30;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(707, 492);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(113, 32);
            this.buttonLoad.TabIndex = 31;
            this.buttonLoad.Text = "Załaduj pasażerów";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Enabled = false;
            this.buttonEmpty.Location = new System.Drawing.Point(906, 492);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(113, 32);
            this.buttonEmpty.TabIndex = 32;
            this.buttonEmpty.Text = "Wypuść pasażerów";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // buttonTransport
            // 
            this.buttonTransport.Enabled = false;
            this.buttonTransport.Location = new System.Drawing.Point(825, 492);
            this.buttonTransport.Name = "buttonTransport";
            this.buttonTransport.Size = new System.Drawing.Size(75, 32);
            this.buttonTransport.TabIndex = 33;
            this.buttonTransport.Text = "Transportuj";
            this.buttonTransport.UseVisualStyleBackColor = true;
            this.buttonTransport.Click += new System.EventHandler(this.buttonTransport_Click);
            // 
            // labelNextStopHint
            // 
            this.labelNextStopHint.AutoSize = true;
            this.labelNextStopHint.Location = new System.Drawing.Point(711, 101);
            this.labelNextStopHint.Name = "labelNextStopHint";
            this.labelNextStopHint.Size = new System.Drawing.Size(221, 13);
            this.labelNextStopHint.TabIndex = 34;
            this.labelNextStopHint.Text = "(Wpisz nazwę lub wybierz z listy przystanków)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 564);
            this.Controls.Add(this.labelNextStopHint);
            this.Controls.Add(this.buttonTransport);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxCurrentDriver);
            this.Controls.Add(this.textBoxCurrentBusStop);
            this.Controls.Add(this.labelCurrentBusStop);
            this.Controls.Add(this.buttonAddPasengerBusStop4);
            this.Controls.Add(this.buttonAddPasengerBusStop3);
            this.Controls.Add(this.buttonAddPasengerBusStop2);
            this.Controls.Add(this.buttonAddPasengerBusStop1);
            this.Controls.Add(this.labelCurrentDriver);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.dataGridViewDriversList);
            this.Controls.Add(this.buttonRandomBusStop);
            this.Controls.Add(this.buttonConfirmBusStop);
            this.Controls.Add(this.labelDriversList);
            this.Controls.Add(this.textBoxNextStop);
            this.Controls.Add(this.labelNextStopChooser);
            this.Controls.Add(this.labelBusInformation);
            this.Controls.Add(this.labelBusStop2PassengerList);
            this.Controls.Add(this.labelBusStop4PassengerList);
            this.Controls.Add(this.labelBusStop3PassengerList);
            this.Controls.Add(this.labelBusStop1PassengerList);
            this.Controls.Add(this.dataGridViewBusStop2PassengerList);
            this.Controls.Add(this.dataGridViewBusStop1PassengerList);
            this.Controls.Add(this.dataGridViewBusStop4PassengerList);
            this.Controls.Add(this.dataGridViewBusStop3PassengerList);
            this.Controls.Add(this.labelBusPassengersList);
            this.Controls.Add(this.dataGridViewBusPassengersList);
            this.Controls.Add(this.labelBusStopList);
            this.Controls.Add(this.dataGridViewBusStopsList);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStopsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusPassengersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop3PassengerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop4PassengerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop1PassengerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusStop2PassengerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriversList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBusStopsList;
        private System.Windows.Forms.Label labelBusStopList;
        private System.Windows.Forms.DataGridView dataGridViewBusPassengersList;
        private System.Windows.Forms.Label labelBusPassengersList;
        private System.Windows.Forms.DataGridView dataGridViewBusStop3PassengerList;
        private System.Windows.Forms.DataGridView dataGridViewBusStop4PassengerList;
        private System.Windows.Forms.DataGridView dataGridViewBusStop1PassengerList;
        private System.Windows.Forms.DataGridView dataGridViewBusStop2PassengerList;
        private System.Windows.Forms.Label labelBusStop1PassengerList;
        private System.Windows.Forms.Label labelBusStop3PassengerList;
        private System.Windows.Forms.Label labelBusStop4PassengerList;
        private System.Windows.Forms.Label labelBusStop2PassengerList;
        private System.Windows.Forms.Label labelBusInformation;
        private System.Windows.Forms.Label labelNextStopChooser;
        private System.Windows.Forms.TextBox textBoxNextStop;
        private System.Windows.Forms.Label labelDriversList;
        private System.Windows.Forms.Button buttonConfirmBusStop;
        private System.Windows.Forms.Button buttonRandomBusStop;
        private System.Windows.Forms.DataGridView dataGridViewDriversList;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Label labelCurrentDriver;
        private System.Windows.Forms.Timer timerAddPassenger;
        private System.Windows.Forms.Button buttonAddPasengerBusStop1;
        private System.Windows.Forms.Button buttonAddPasengerBusStop2;
        private System.Windows.Forms.Button buttonAddPasengerBusStop3;
        private System.Windows.Forms.Button buttonAddPasengerBusStop4;
        private System.Windows.Forms.Label labelCurrentBusStop;
        private System.Windows.Forms.TextBox textBoxCurrentBusStop;
        private System.Windows.Forms.TextBox textBoxCurrentDriver;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Button buttonTransport;
        private System.Windows.Forms.Label labelNextStopHint;
    }
}

