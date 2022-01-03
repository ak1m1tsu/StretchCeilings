using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class OrdersForm : Form
    {
        private List<Order> _orders;
        private const string _defaultLinkLblText = "🔍";
        private readonly string _defaultDateTimePickerCustomFormat = string.Empty;
        private const string _filterDateTimePickerCustomFormat = @"dd.MM.yyyy HH:mm";
        private const int _defaultNumericUpDownValue = 0;

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void CheckUserPermissions()
        {
            if (UserSession.Can(PermissionCode.AddAdditionalService))
            {
                DrawAddServiceButton();
            }
        }

        private void OpenDataGridRowForm()
        {
            if (dgvOrders.SelectedRows.Count <= 0) return;

            var order = OrderRepository.GetById((int) dgvOrders.SelectedRows[0].Cells[0].Value);

            if (new OrderForm(order).ShowDialog() == DialogResult.OK)
            {
                // FillDataGridView();
            }
        }

        private void SetUpDataGridView()
        {
            _orders = OrderRepository.GetOrders();

            var idColumn = new DataGridViewTextBoxColumn() {Name = "Id"};
            var datePlacedColumn = new DataGridViewTextBoxColumn() {Name = "Дата размещения"};
            var customerColumn = new DataGridViewTextBoxColumn() {Name = "Клиент"};
            var statusColumn = new DataGridViewTextBoxColumn() {Name = "Статус"};
            var paidByCashColumn = new DataGridViewCheckBoxColumn() { Name = "Оплачен наличными" };
            var totalColumn = new DataGridViewTextBoxColumn() { Name = "Стоимость" };
            
            dgvOrders.Columns.AddRange(idColumn, datePlacedColumn, customerColumn, statusColumn, paidByCashColumn,
                totalColumn);
        }

        private void SetUpFilterControls()
        {
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
                cbStatusValue.Items.Add(status.ParseString());
            cbStatusValue.SelectedItem = null;

            dtpDateFromValue.ValueChanged += DtpToValueChanged;
            dtpDateToValue.ValueChanged += DtpToValueChanged;
        }

        private void FilterDataGrid()
        {

        }
        private void ResetDataGridFilters()
        {
            dtpDateFromValue.CustomFormat = _defaultDateTimePickerCustomFormat;
            dtpDateToValue.CustomFormat = _defaultDateTimePickerCustomFormat;
            nudIdValue.Value = _defaultNumericUpDownValue;
            linkLblCustomerValue.Text = _defaultLinkLblText;
            linkLblEmployeeValue.Text = _defaultLinkLblText;
            linkLblServiceValue.Text = _defaultLinkLblText;
        }

        private void DrawAddServiceButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить");
            btnAddOrder.Click += btnAddOrder_Click;
            panelButtonsSide.Controls.Add(btnAddOrder);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            CheckUserPermissions();
            SetUpFilterControls();
            SetUpDataGridView();
        }

        private static void btnAddOrder_Click(object sender, EventArgs e)
        {
            new OrderFormEdit().ShowDialog();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {

        }

        private static void DtpToValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker) sender;
            dateTimePicker.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month,
                dateTimePicker.Value.Day, 0, 0, 0);
            dateTimePicker.CustomFormat = _filterDateTimePickerCustomFormat;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm();
        }
    }
}
