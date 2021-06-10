
namespace PawelOsajdaZadanieDomowe3.Forms
{
    partial class FormCart
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
            this.dataGridViewLaptopsInCart = new System.Windows.Forms.DataGridView();
            this.labelDeliveryType = new System.Windows.Forms.Label();
            this.comboBoxDeliveryType = new System.Windows.Forms.ComboBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelDeliveryPrice = new System.Windows.Forms.Label();
            this.textBoxDeliveryPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptopsInCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLaptopsInCart
            // 
            this.dataGridViewLaptopsInCart.AllowUserToAddRows = false;
            this.dataGridViewLaptopsInCart.AllowUserToDeleteRows = false;
            this.dataGridViewLaptopsInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaptopsInCart.Location = new System.Drawing.Point(49, 30);
            this.dataGridViewLaptopsInCart.MultiSelect = false;
            this.dataGridViewLaptopsInCart.Name = "dataGridViewLaptopsInCart";
            this.dataGridViewLaptopsInCart.ReadOnly = true;
            this.dataGridViewLaptopsInCart.Size = new System.Drawing.Size(600, 341);
            this.dataGridViewLaptopsInCart.TabIndex = 0;
            // 
            // labelDeliveryType
            // 
            this.labelDeliveryType.AutoSize = true;
            this.labelDeliveryType.Location = new System.Drawing.Point(52, 395);
            this.labelDeliveryType.Name = "labelDeliveryType";
            this.labelDeliveryType.Size = new System.Drawing.Size(121, 13);
            this.labelDeliveryType.TabIndex = 1;
            this.labelDeliveryType.Text = "Wybierz rodzaj dostawy:";
            // 
            // comboBoxDeliveryType
            // 
            this.comboBoxDeliveryType.FormattingEnabled = true;
            this.comboBoxDeliveryType.Location = new System.Drawing.Point(179, 392);
            this.comboBoxDeliveryType.Name = "comboBoxDeliveryType";
            this.comboBoxDeliveryType.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDeliveryType.TabIndex = 2;
            this.comboBoxDeliveryType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeliveryType_SelectedIndexChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(549, 385);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(100, 28);
            this.buttonBuy.TabIndex = 3;
            this.buttonBuy.Text = "Kup";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelDeliveryPrice
            // 
            this.labelDeliveryPrice.AutoSize = true;
            this.labelDeliveryPrice.Location = new System.Drawing.Point(344, 395);
            this.labelDeliveryPrice.Name = "labelDeliveryPrice";
            this.labelDeliveryPrice.Size = new System.Drawing.Size(77, 13);
            this.labelDeliveryPrice.TabIndex = 4;
            this.labelDeliveryPrice.Text = "Cena dostawy:";
            // 
            // textBoxDeliveryPrice
            // 
            this.textBoxDeliveryPrice.Location = new System.Drawing.Point(427, 392);
            this.textBoxDeliveryPrice.Name = "textBoxDeliveryPrice";
            this.textBoxDeliveryPrice.ReadOnly = true;
            this.textBoxDeliveryPrice.Size = new System.Drawing.Size(30, 20);
            this.textBoxDeliveryPrice.TabIndex = 5;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.textBoxDeliveryPrice);
            this.Controls.Add(this.labelDeliveryPrice);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.comboBoxDeliveryType);
            this.Controls.Add(this.labelDeliveryType);
            this.Controls.Add(this.dataGridViewLaptopsInCart);
            this.Name = "FormCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptopsInCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLaptopsInCart;
        private System.Windows.Forms.Label labelDeliveryType;
        private System.Windows.Forms.ComboBox comboBoxDeliveryType;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelDeliveryPrice;
        private System.Windows.Forms.TextBox textBoxDeliveryPrice;
    }
}