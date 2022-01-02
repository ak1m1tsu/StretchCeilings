using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
{
    public partial class OrderFormEdit : Form
    {
        private Order _currentOrder;
        public OrderFormEdit(Order order)
        {
            _currentOrder = order;
            InitializeComponent();
        }

        public OrderFormEdit()
        {
            InitializeComponent();
        }

        private void OrderFormEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
