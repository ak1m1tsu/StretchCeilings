using System.Drawing;
using System.Windows.Forms;

namespace StretchCeilings.Helpers.Extensions.Controls
{
    public static class DataGridViewExtensions
    {
        public static void AddDataGridViewTextBoxColumn(this DataGridView dataGrid, string name, DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn() { Name = name, AutoSizeMode = sizeColumnMode });
        }

        public static void AddDataGridViewCheckBoxColumn(this DataGridView dataGrid, string name, DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            dataGrid.Columns.Add(new DataGridViewCheckBoxColumn() { Name = name, AutoSizeMode = sizeColumnMode });
        }

        public static void AddDataGridViewButtonColumn(this DataGridView dataGrid, Color color)
        {
            dataGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FlatStyle = FlatStyle.Flat,
                Name = " ",
                DefaultCellStyle = new DataGridViewCellStyle() { BackColor = color }
            });
        }
    }
}
