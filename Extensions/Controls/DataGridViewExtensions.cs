using System.Windows.Forms;
using StretchCeilings.Structs;

namespace StretchCeilings.Extensions.Controls
{
    public static class DataGridViewExtensions
    {
        public static void CreateTextBoxColumn(this DataGridView dataGridView, string name, DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = name,
                AutoSizeMode = sizeColumnMode,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    ForeColor = DraculaColor.Background,
                    SelectionForeColor = DraculaColor.Foreground,
                    SelectionBackColor = DraculaColor.Selection
                }
            });
        }

        public static void CreateCheckBoxColumn(this DataGridView dataGrid, string name, DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            dataGrid.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = name, 
                AutoSizeMode = sizeColumnMode
            });
        }

        public static void CreateButtonColumn(this DataGridView dataGrid)
        {
            dataGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = Resources.Space,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                CellTemplate = new DataGridViewButtonCell()
                {
                    FlatStyle = FlatStyle.Flat,
                    Style = new DataGridViewCellStyle()
                    {
                        BackColor = DraculaColor.Red,
                        ForeColor = DraculaColor.Foreground,
                        SelectionBackColor = DraculaColor.Red,
                        SelectionForeColor = DraculaColor.Selection
                    }
                }
            });
        }
    }
}
