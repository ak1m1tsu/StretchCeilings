using System;
using System.Windows.Forms;
using StretchCeilings.Extensions;

namespace StretchCeilings.Views
{
    public partial class OrderWorkDateForm : Form
    {
        private DateTime _date;

        public OrderWorkDateForm()
        {
            InitializeComponent();
        }

        public DateTime GetWorkDate() => _date;

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }

        private void AddWorkDate(object sender, EventArgs e)
        {
            _date = new DateTime(
                dtp.Value.Year,
                dtp.Value.Month,
                dtp.Value.Day,
                dtp.Value.Hour,
                dtp.Value.Minute,
                dtp.Value.Second);

            DialogResult = DialogResult.OK;
        }
    }
}
