using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
{
    public partial class AdditionalServiceForm : Form
    {
        private readonly AdditionalService _currentService;

        public AdditionalServiceForm(AdditionalService service)
        {
            _currentService = service;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (ShowDialog(new AdditionalServiceFormEdit(_currentService)) == DialogResult.OK)
                this.Close();
        }

        private void AdditionalServiceForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Can(PermissionCode.EditService) == false)
                btnChange.Visible = false;
        }
    }
}
