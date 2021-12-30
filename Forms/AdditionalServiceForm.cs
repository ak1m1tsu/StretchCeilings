using stretch_ceilings_app.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class AdditionalServiceForm : Form
    {
        private AdditionalService _currentService;

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
