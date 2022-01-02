using System;
using System.Windows.Forms;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void CheckUserPermissions()
        {
            if (UserSession.Can(PermissionCode.AddAdditionalService))
            {
                FillDataGrid(true);
                DrawAddServiceButton();
                return;
            }

            FillDataGrid();
        }
        private void FillDataGrid(bool hasPermission = false)
        {
            if (hasPermission)
            {
                return;
            }


        }

        private void DrawAddServiceButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить");
            btnAddOrder.Click += btnAddOrder_Click;
            panelUserButtons.Controls.Add(btnAddOrder);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            CheckUserPermissions();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            new OrderFormEdit().ShowDialog();
        }
    }
}
