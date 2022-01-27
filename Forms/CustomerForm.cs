using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;

namespace stretch_ceilings_app.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly Customer _currentCustomer;

        public CustomerForm(Customer customer)
        {
            _currentCustomer = customer;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            lblFullNameValue.Text = _currentCustomer.FullName;
            lblPhoneNumberValue.Text = _currentCustomer.PhoneNumber;
            
            SetUpEstatesGrid();
            SetUpEditBtn();
        }

        private void SetUpEstatesGrid()
        {
            var estates = _currentCustomer.GetEstates();

            var idCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var addressCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

            dgvEstates.Columns.AddRange(idCol, addressCol);
            dgvEstates.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvEstates.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;

            for (var i = 0; i < estates?.Count; i++)
            {
                dgvEstates.Rows.Add(new DataGridViewRow());

                dgvEstates.Rows[i].Cells[0].Value = estates[i].Id;
                dgvEstates.Rows[i].Cells[1].Value = estates[i].Address;
            }
        }

        private void SetUpEditBtn()
        {
            if (UserSession.Can(PermissionCode.EditCustomer) == false || 
                UserSession.IsAdmin == false)
                btnChangeInfo.Visible = false;
        }

        private void OpenEditForm()
        {
            this.Hide();
            new CustomerFormEdit(_currentCustomer).ShowDialog();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
    }
}
