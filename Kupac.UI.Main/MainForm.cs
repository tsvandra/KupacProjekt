﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kupac.UI.Main.BaseClasses;
using Kupac.UI.Customers;

namespace Kupac.UI.Main
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Button previousButton = null;

        private void SetButtonColor(Button currentButton, Color activeColor)
        {
            // Az előző gomb visszaállítása az eredeti színre
            if (previousButton != null)
            {
                previousButton.BackColor = Color.SeaShell;  // Eredeti szín
            }

            // Az aktuális gomb háttérszínének megváltoztatása
            currentButton.BackColor = activeColor;

            // Az aktuális gomb mentése, mint az előző gomb
            previousButton = currentButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadFormIntoPanel(Form form)
        {
            // Előzőleg betöltött form bezárása, ha van
            if (this.mainInformationPanel.Controls.Count > 0)
            {
                this.mainInformationPanel.Controls[0].Dispose();
            }

            // Új form betöltése a panelbe
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Hozzáadjuk a formot a panelhez
            this.mainInformationPanel.Controls.Add(form);

            form.Show();
        }

        private void dashBoardButton_Click(object sender, EventArgs e)
        {
            SetButtonColor(dashBoardButton, Color.AntiqueWhite);
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new CustomersEditorForm());
            SetButtonColor(customersButton, Color.AntiqueWhite);
        }
    }
}
