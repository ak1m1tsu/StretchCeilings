using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Forms
{
    public partial class ServiceForm : Form
    {
        private readonly Service _currentService;
        public ServiceForm(Service service)
        {
            _currentService = service;
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Can(PermissionCode.EditService) == false)
                btnEdit.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ShowDialog(new ServiceFormEdit(_currentService)) == DialogResult.OK)
                this.Close();
        }
    }
}
