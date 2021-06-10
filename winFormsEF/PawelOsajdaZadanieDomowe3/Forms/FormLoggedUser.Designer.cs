
namespace PawelOsajdaZadanieDomowe3.Forms
{
    partial class FormLoggedUser
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
            this.dataGridViewLaptops = new System.Windows.Forms.DataGridView();
            this.linkLabelUserData = new System.Windows.Forms.LinkLabel();
            this.textBoxCheckedLaptop = new System.Windows.Forms.TextBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.labelCheckedLaptop = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLaptops
            // 
            this.dataGridViewLaptops.AllowUserToAddRows = false;
            this.dataGridViewLaptops.AllowUserToDeleteRows = false;
            this.dataGridViewLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaptops.Location = new System.Drawing.Point(29, 54);
            this.dataGridViewLaptops.MultiSelect = false;
            this.dataGridViewLaptops.Name = "dataGridViewLaptops";
            this.dataGridViewLaptops.ReadOnly = true;
            this.dataGridViewLaptops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLaptops.Size = new System.Drawing.Size(843, 383);
            this.dataGridViewLaptops.TabIndex = 1;
            this.dataGridViewLaptops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLaptops_CellClick);
            // 
            // linkLabelUserData
            // 
            this.linkLabelUserData.AutoSize = true;
            this.linkLabelUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelUserData.Location = new System.Drawing.Point(726, 24);
            this.linkLabelUserData.Name = "linkLabelUserData";
            this.linkLabelUserData.Size = new System.Drawing.Size(146, 16);
            this.linkLabelUserData.TabIndex = 2;
            this.linkLabelUserData.TabStop = true;
            this.linkLabelUserData.Text = "Imie Nazwisko Wyloguj";
            this.linkLabelUserData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabelUserData_MouseClick);
            // 
            // textBoxCheckedLaptop
            // 
            this.textBoxCheckedLaptop.Location = new System.Drawing.Point(30, 489);
            this.textBoxCheckedLaptop.Name = "textBoxCheckedLaptop";
            this.textBoxCheckedLaptop.ReadOnly = true;
            this.textBoxCheckedLaptop.Size = new System.Drawing.Size(334, 20);
            this.textBoxCheckedLaptop.TabIndex = 0;
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxQuantity.Location = new System.Drawing.Point(370, 489);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(89, 21);
            this.comboBoxQuantity.TabIndex = 3;
            this.comboBoxQuantity.Text = "1";
            this.comboBoxQuantity.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuantity_SelectedIndexChanged);
            // 
            // labelCheckedLaptop
            // 
            this.labelCheckedLaptop.AutoSize = true;
            this.labelCheckedLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCheckedLaptop.Location = new System.Drawing.Point(27, 470);
            this.labelCheckedLaptop.Name = "labelCheckedLaptop";
            this.labelCheckedLaptop.Size = new System.Drawing.Size(106, 16);
            this.labelCheckedLaptop.TabIndex = 4;
            this.labelCheckedLaptop.Text = "Wybrany laptop:";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(465, 489);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(117, 23);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Dodaj do koszyka";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.Location = new System.Drawing.Point(729, 472);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(142, 40);
            this.buttonCart.TabIndex = 6;
            this.buttonCart.Text = "Koszyk";
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // FormLoggedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 547);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.labelCheckedLaptop);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.textBoxCheckedLaptop);
            this.Controls.Add(this.linkLabelUserData);
            this.Controls.Add(this.dataGridViewLaptops);
            this.Name = "FormLoggedUser";
            this.Text = "Sklep z laptopami";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoggedUser_FormClosed);
            this.Load += new System.EventHandler(this.FormLoggedUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLaptops;
        private System.Windows.Forms.LinkLabel linkLabelUserData;
        private System.Windows.Forms.TextBox textBoxCheckedLaptop;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.Label labelCheckedLaptop;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonCart;
    }
}