using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
{
    public partial class CustomerFormEdit : Form
    {
        private readonly Customer _customer;

        public CustomerFormEdit(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            tbFullName.Text = _customer.FullName;
            mtbPhoneNumber.Text = _customer.PhoneNumber;
        }

        private void btnAddEstate_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {

        }

        private void CustomerFormEdit_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }
    }
}
