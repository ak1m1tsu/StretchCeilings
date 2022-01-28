using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;
using StretchCeilingsApp.Utility.Enums;
using StretchCeilingsApp.Utility.Extensions.Controls;

namespace StretchCeilingsApp.Forms
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

            dgvEstates.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEstates.AddDataGridViewTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

            dgvEstates.Font = Constants.DataGridViewFont;
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
