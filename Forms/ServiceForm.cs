using stretch_ceilings_app.Forms;
using stretch_ceilings_app.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace stretch_ceilings_app
{
    public partial class ServiceForm : Form
    {
        private Service _currentService;
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
