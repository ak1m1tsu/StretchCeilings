using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Forms
{
    public partial class AdditionalServicesForm : Form
    {
        public AdditionalServicesForm()
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
            var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить");
            btnAddService.Click += btnAddAdditionalService_Click;
            panelUserButtons.Controls.Add(btnAddService);
        }

        private void AdditionalServicesForm_Load(object sender, EventArgs e)
        {
            CheckUserPermissions();
            nudIdValue.Maximum = uint.MaxValue;
        }

        private void btnAddAdditionalService_Click(object sender, EventArgs e)
        {
            new AdditionalServiceFormEdit(new AdditionalService()).ShowDialog();
        }
    }
}
