using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;
using StretchCeilingsApp.Utility.Enums;

namespace StretchCeilingsApp.Forms
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
            if (UserSession.Can(PermissionCode.EditService) == false || 
                UserSession.IsAdmin == false)
                btnEdit.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ShowDialog(new ServiceFormEdit(_currentService)) == DialogResult.OK)
                this.Close();
        }
    }
}
