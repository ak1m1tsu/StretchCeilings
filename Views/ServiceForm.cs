using System;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Models;

namespace StretchCeilings.Views
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
