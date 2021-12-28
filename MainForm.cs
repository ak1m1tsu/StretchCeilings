using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;
using stretch_ceilings_app.Utility.CustomBtn;

namespace stretch_ceilings_app
{
    public partial class MainForm : Form
    {
        private Form _activeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NavigationButton btnOrders = new NavigationButton("btnOrder", "Заказы");
            btnOrders.Click += btnOrders_Click;
            panelNav.Controls.Add(btnOrders);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            OpenChildForm(ordersForm);
        }
    }
}
