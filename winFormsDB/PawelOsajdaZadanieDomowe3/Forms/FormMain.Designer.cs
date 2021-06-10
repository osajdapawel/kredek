
namespace PawelOsajdaZadanieDomowe3
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
            this.dataGridViewLaptops = new System.Windows.Forms.DataGridView();
            this.labelShopOffer = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonBuyUserNotLogged = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLaptops
            // 
            this.dataGridViewLaptops.AllowUserToAddRows = false;
            this.dataGridViewLaptops.AllowUserToDeleteRows = false;
            this.dataGridViewLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaptops.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewLaptops.MultiSelect = false;
            this.dataGridViewLaptops.Name = "dataGridViewLaptops";
            this.dataGridViewLaptops.ReadOnly = true;
            this.dataGridViewLaptops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLaptops.Size = new System.Drawing.Size(843, 383);
            this.dataGridViewLaptops.TabIndex = 0;
            // 
            // labelShopOffer
            // 
            this.labelShopOffer.AutoSize = true;
            this.labelShopOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShopOffer.Location = new System.Drawing.Point(12, 27);
            this.labelShopOffer.Name = "labelShopOffer";
            this.labelShopOffer.Size = new System.Drawing.Size(262, 25);
            this.labelShopOffer.TabIndex = 4;
            this.labelShopOffer.Text = "Oferta sklepu z laptopami:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(755, 20);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 29);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Zaloguj się";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonBuyUserNotLogged
            // 
            this.buttonBuyUserNotLogged.Location = new System.Drawing.Point(755, 444);
            this.buttonBuyUserNotLogged.Name = "buttonBuyUserNotLogged";
            this.buttonBuyUserNotLogged.Size = new System.Drawing.Size(100, 29);
            this.buttonBuyUserNotLogged.TabIndex = 6;
            this.buttonBuyUserNotLogged.Text = "Kup";
            this.buttonBuyUserNotLogged.UseVisualStyleBackColor = true;
            this.buttonBuyUserNotLogged.Click += new System.EventHandler(this.buttonBuyUserNotLogged_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.buttonBuyUserNotLogged);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelShopOffer);
            this.Controls.Add(this.dataGridViewLaptops);
            this.Name = "FormMain";
            this.Text = "Przglądanie oferty sklepu z laptopami ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLaptops;
        private System.Windows.Forms.Label labelShopOffer;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonBuyUserNotLogged;
    }
}

