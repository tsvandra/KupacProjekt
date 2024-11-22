using Kupac.AdatbazisTablak;
using Kupac.DbContexts;
using Kupac.UI.Customers;
using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kupac.Resources;

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

        private void CustomerDataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.BeginInvoke(new Action(() => SetLastColumnFillColumnWidthChanged()));
        }

        private void SetLastColumnFillColumnWidthChanged()
        {
            if (customerDataGridView.Columns.Count > 0)
            {
                foreach (DataGridViewColumn column in customerDataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }

                // Az utolsó oszlop kitöltése
                var lastColumn = customerDataGridView.Columns[customerDataGridView.Columns.Count - 1];
                lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetLastColumnFill()
        {
            if (customerDataGridView.Columns.Count > 0)
            {
                // Az utolsó oszlop kitöltésének engedélyezése
                var lastColumn = customerDataGridView.Columns[customerDataGridView.Columns.Count - 1];
                lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // A többi oszlop fix méretű
                foreach (DataGridViewColumn column in customerDataGridView.Columns)
                {
                    if (column != lastColumn)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    }
                }
            }
        }

        private void CustomersEditorForm_Resize(object sender, EventArgs e)
        {
            SetLastColumnFill();
        }

        private void CustomizeColumns()
        {
            if (customerDataGridView.Columns["ID"] != null)
            {
                var idColumn = customerDataGridView.Columns["ID"];
#if DEBUG
                idColumn.Visible = true;
#else
                idColumn.Visible = false; // Elrejti az ID-t
#endif
                idColumn.Width = 50;

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

            if (customerDataGridView.Columns["Address"] != null)
            {
                customerDataGridView.Columns["Address"].HeaderText = "Utca, házszám";
            }

            if (customerDataGridView.Columns["City"] != null)
            {
                customerDataGridView.Columns["City"].HeaderText = "Város";
            }

            if (customerDataGridView.Columns["PostalCode"] != null)
            {
                customerDataGridView.Columns["PostalCode"].HeaderText = "Irányítószám";
            }

            if (customerDataGridView.Columns["Country"] != null)
            {
                customerDataGridView.Columns["Country"].HeaderText = "Ország";
            }

            if (customerDataGridView.Columns["Phone"] != null)
            {
                customerDataGridView.Columns["Phone"].HeaderText = "Telefon2";
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

                CustomizeColumns();
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

        private void customerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Az ügyfél ID-jének lekérése
                    int customerId = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                    using (var context = new CapillarContext())
                    {
                        var customer = context.Customers.Find(customerId);
                        if (customer != null)
                        {
                            // Nyisd meg a CustomerAddForm-ot szerkesztési módban
                            using (var editForm = new CustomerAddForm(true, customer))
                            {
                                editForm.CustomerAdded += RefreshGrid;
                                editForm.ShowDialog();
                                RefreshGrid(); // Frissítsd az adatokat
                            }
                        }
                        else
                        {
                            MessageBox.Show("Az ugyfel nem talalhato az adatbazisban");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba tortent: {ex.Message}");
                }
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Kérlek, válassz ki egy ügyfelet a törléshez.");
                return;
            }

            var result = MessageBox.Show("Biztosan törölni szeretnéd ezt az ügyfelet?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int customerId = Convert.ToInt32(customerDataGridView.SelectedRows[0].Cells["ID"].Value);

                    using (var context = new CapillarContext())
                    {
                        var customer = context.Customers.Find(customerId);
                        if (customer != null)
                        {
                            context.Customers.Remove(customer);
                            context.SaveChanges();
                            MessageBox.Show("Az ügyfél sikeresen törölve.");
                            RefreshGrid();
                        }
                        else
                        {
                            MessageBox.Show("Az ügyfél nem található az adatbázisban.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a törlés során: {ex.Message}");
                }
            }
        }

        private void CustomerEditorForm_Load(object sender, EventArgs e)
        {
            
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "Fountain2.gif");
            loadingPictureBox.Image = Image.FromFile(imagePath);
                
            using (var context = new CapillarContext())
            {

                RefreshGrid();
                CustomizeColumns();
            }

            SetLastColumnFill();
            customerDataGridView.ColumnWidthChanged += CustomerDataGridView_ColumnWidthChanged;
            this.Resize += CustomersEditorForm_Resize;
            
        }
    }


}
