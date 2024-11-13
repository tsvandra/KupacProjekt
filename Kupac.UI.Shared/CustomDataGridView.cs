using System.Windows.Forms;
using System.Drawing;

namespace Kupac.UI.Shared.BaseClasses
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            SetModernStyle();
        }

        private void SetModernStyle()
        {
            // Fejlec stilus
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 68, 90);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            // Sorszinezes
            this.RowsDefaultCellStyle.BackColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Racsvonal szinezes
            this.GridColor = Color.LightGray;

            // Szegely es cellahatar stilus
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Sor margok elrejtese
            this.RowHeadersVisible = false;
            this.EnableHeadersVisualStyles = false;

            // Automatikus oszlop meretezes
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Nem engedelyezett szerkesztes kozvetlenul a gridben
            this.ReadOnly = true;
        }
    }
}
