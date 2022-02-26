using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.App.Services;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    /// <inheritdoc />
    public partial class CustomerForm : Form
    {
        private Customer _customer;
        private readonly FormState _state;
        private IList<Estate> _estates;
        private IList<Order> _orders;
        private IList<Service> _services;

        /// <inheritdoc />
        public CustomerForm(Customer customer, FormState state = FormState.Default)
        {
            _customer = customer;
            _state = state;
            InitializeComponent();
        }

        private void SetupForm()
        {
            lblFullNameValue.Text = _customer.FullName;
            lblPhoneNumberValue.Text = _customer.PhoneNumber;

            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            if (CanUserEdit())
                btnEdit.Enabled = true;

            SetupEstateGrid();
            SetupOrderGrid();
            SetupServiceGrid();

            FillEstateGrid();
            FillOrderGrid();
            FillServiceGrid();
        }

        private void SetupEstateGrid()
        {
            dataGridViewEstates.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dataGridViewEstates.CreateTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

            dataGridViewEstates.Font = GoogleFont.OpenSans;
            dataGridViewEstates.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dataGridViewEstates.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupOrderGrid()
        {
            dataGridViewOrders.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dataGridViewOrders.CreateTextBoxColumn("Дата размещения", DataGridViewAutoSizeColumnMode.Fill);
            dataGridViewOrders.CreateTextBoxColumn("Статус", DataGridViewAutoSizeColumnMode.Fill);
            dataGridViewOrders.CreateTextBoxColumn("Стоимость", DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void SetupServiceGrid()
        {
            dataGridViewServices.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dataGridViewServices.CreateTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dataGridViewServices.CreateTextBoxColumn(Resources.Ceiling, DataGridViewAutoSizeColumnMode.Fill);
            dataGridViewServices.CreateTextBoxColumn("Комната", DataGridViewAutoSizeColumnMode.Fill);
            dataGridViewServices.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void FillEstateGrid()
        {
            _estates = _customer.GetEstates();

            dataGridViewEstates.Rows.Clear();

            for (var i = 0; i < _estates?.Count; i++)
            {
                dataGridViewEstates.Rows.Add(new DataGridViewRow());

                dataGridViewEstates.Rows[i].Cells[0].Value = dataGridViewEstates.Rows.Count;
                dataGridViewEstates.Rows[i].Cells[1].Value = _estates[i].Address;
            }
        }

        private void FillOrderGrid()
        {
            _orders = _customer.GetOrders();

            dataGridViewOrders.Rows.Clear();

            for (var i = 0; i < _orders?.Count; i++)
            {
                dataGridViewOrders.Rows.Add(new DataGridViewRow());

                dataGridViewOrders.Rows[i].Cells[0].Value = _orders[i].Id;
                dataGridViewOrders.Rows[i].Cells[1].Value = _orders[i].DatePlaced;
                dataGridViewOrders.Rows[i].Cells[2].Value = _orders[i].Status?.ParseString();
                dataGridViewOrders.Rows[i].Cells[3].Value = _orders[i].Total;
            }
        }

        private void FillServiceGrid()
        {
            _services = _customer.GetServices();

            dataGridViewServices.Rows.Clear();

            for (var i = 0; i < _services?.Count; i++)
            {
                dataGridViewServices.Rows.Add(new DataGridViewRow());

                dataGridViewServices.Rows[i].Cells[0].Value = dataGridViewServices.Rows.Count;
                dataGridViewServices.Rows[i].Cells[1].Value = _services[i].Manufacturer?.Name;
                dataGridViewServices.Rows[i].Cells[2].Value = _services[i].Ceiling?.Name;
                dataGridViewServices.Rows[i].Cells[3].Value = _services[i].Room.Type?.ParseString();
                dataGridViewServices.Rows[i].Cells[4].Value = _services[i].Price;
            }
        }

        private void ReSetupForm()
        {
            lblFullNameValue.Text = _customer.FullName;
            lblPhoneNumberValue.Text = _customer.PhoneNumber;

            FillEstateGrid();
            FillOrderGrid();
            FillServiceGrid();
        }

        private static bool CanUserEdit() => UserSession.IsAdmin || UserSession.Can(PermissionCode.EditCustomer);
        
        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dataGridViewEstates.Rows[e.RowIndex].Cells[0].Value);
            var estate = _estates[index - 1];
            new EstateForm(estate).ShowDialog();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            var form = new CustomerEditForm(_customer);
            if (form.ShowDialog() != DialogResult.OK) 
                return;

            _customer = form.GetCustomer();
            ReSetupForm();
        }
    }
}
