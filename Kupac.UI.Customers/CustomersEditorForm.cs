using Kupac.AdatbazisTablak;
using Kupac.DbContexts;
using Kupac.UI.Customers;
using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kupac
{
    public partial class CustomersEditorForm : BaseForm
    {
        public CustomerManager _customerManager;
        private const string defaultText = "Zadat hodnotu";
        private CustomDataGridView customerDataGridView;
        private CustomersEditorForm customersEditorForm;

        public CustomersEditorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _customerManager = new CustomerManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (var context = new CapillarContext())
            {
                RefreshGrid();
                CustomizeColumns();
            }


        }


        private void CustomizeColumns()
        {
            if (customerDataGridView.Columns["ID"] != null)
            {
                customerDataGridView.Columns["ID"].Visible = false; // Elrejti az ID-t
            }

            if (customerDataGridView.Columns["FirstName"] != null)
            {
                var firstNameColumn = customerDataGridView.Columns["FirstName"];
                firstNameColumn.HeaderText = "Keresztnév";
                firstNameColumn.MinimumWidth = GetHeaderTextWidth(firstNameColumn);
                firstNameColumn.Width = GetOptimalColumnWidth(firstNameColumn);
                firstNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            if (customerDataGridView.Columns["LastName"] != null)
            {
                var lastNameColumn = customerDataGridView.Columns["LastName"];
                lastNameColumn.HeaderText = "Vezetéknév";
                lastNameColumn.MinimumWidth = GetHeaderTextWidth(lastNameColumn);
                lastNameColumn.Width = GetOptimalColumnWidth(lastNameColumn);
                lastNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            }

            if (customerDataGridView.Columns["Email"] != null)
            {
                customerDataGridView.Columns["Email"].HeaderText = "Email cím";
            }

            if (customerDataGridView.Columns["MobilPhone"] != null)
            {
                customerDataGridView.Columns["MobilPhone"].HeaderText = "Mobiltelefon";
            }
        }

        private int GetHeaderTextWidth(DataGridViewColumn column)
        {
            using (Graphics g = customerDataGridView.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(column.HeaderText, customerDataGridView.Font);
                return (int)(textSize.Width * 1.5) + 10;
            }
        }

        private int GetOptimalColumnWidth(DataGridViewColumn column)
        {
            // Kiszámítja az optimális szélességet a fejléchez és az első néhány adat sorhoz igazítva
            using (Graphics g = customerDataGridView.CreateGraphics())
            {
                // Mérjük meg a fejléc szélességét
                SizeF headerSize = g.MeasureString(column.HeaderText, customerDataGridView.Font);

                // Vegyük figyelembe az első néhány cella szélességét is
                float maxWidth = headerSize.Width;

                foreach (DataGridViewRow row in customerDataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null)
                    {
                        SizeF cellSize = g.MeasureString(row.Cells[column.Index].Value.ToString(), customerDataGridView.Font);
                        maxWidth = Math.Max(maxWidth, cellSize.Width);
                    }
                }

                var headerWidth = GetHeaderTextWidth(column);
                if (headerWidth > ((int)maxWidth + 20))
                {
                    return headerWidth;
                }
                // Biztonsági tartalék hozzáadása és kerekítés egész számra
                else
                {
                    return (int)maxWidth + 20;
                }
            }
        }

        private void addNewCustomerButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new CustomerAddForm())
            {
                addForm.CustomerAdded += RefreshGrid;
                addForm.ShowDialog();
                
            }

        }

        public async void RefreshGrid()
        {
            try
            {
                // Betöltési animáció megjelenítése
                loadingPictureBox.Visible = true;

                await Task.Run(() =>
                {
                    using (var context = new CapillarContext())
                    {
                        _customerManager.LoadCustomersFromDatabase(context);
                    }
                });

                // Adatok frissítése
                customerDataGridView.DataSource = null;
                customerDataGridView.DataSource = _customerManager.GetCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok betöltésekor: {ex.Message}");
            }
            finally
            {
                // Betöltési animáció elrejtése
                loadingPictureBox.Visible = false;
            }
        }

    }


}
