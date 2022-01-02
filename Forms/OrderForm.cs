using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Forms
{
    public partial class OrderForm : Form
    {
        private Order _currentOrder;
        public OrderForm(Order order)
        {
            _currentOrder = order;
            InitializeComponent();
        }

        private void SetupEditButton()
        {
            btnEditOrder.Visible = CanUserEdit();
        }

        private bool CanUserEdit()
        {
            return UserSession.Can(PermissionCode.EditOrder);
        }

        private void OrderForm_Load(object sender, System.EventArgs e)
        {
            SetupEditButton();
        }

        private void btnEditOrder_Click(object sender, System.EventArgs e)
        {
            new OrderForm(_currentOrder).ShowDialog();
        }
    }
}
