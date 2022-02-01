using System;
using System.Windows.Forms;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CustomerEditForm : Form
    {
        private readonly Customer _customer;

        public CustomerEditForm(Customer customer)
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
