using System.Drawing;
using System.Windows.Forms;

namespace stretch_ceilings_app.Utility.Extensions
{
    public class DataGridViewExtensions
    {
        public static DataGridViewTextBoxColumn CreateDataGridViewTextBoxColumn(string name, DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            return new DataGridViewTextBoxColumn()
            {
                Name = name, 
                AutoSizeMode = sizeColumnMode
            };
        }

        public static DataGridViewCheckBoxColumn CreateDataGridViewCheckBoxColumn(string name, DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            return new DataGridViewCheckBoxColumn()
            {
                Name = name, 
                AutoSizeMode = sizeColumnMode
            };
        }

        public static DataGridViewButtonColumn CreateDataGridViewButtonColumn(Color color)
        {
            return new DataGridViewButtonColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FlatStyle = FlatStyle.Popup,
                Name = " ",
                DefaultCellStyle = new DataGridViewCellStyle() { BackColor = color }
            };
        }
    }
}
