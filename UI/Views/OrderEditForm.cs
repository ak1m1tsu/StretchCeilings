using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Helpers;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class OrderEditForm : Form
    {
        private readonly Order _order;
        private List<Employee> _employees;
        private List<Service> _services;
        private List<Log> _logs;
        private List<OrderWorkDate> _workDates;

        public OrderEditForm(Order order = null)
        {
            _order = order;

            if (_order == null)
            {
                _order = new Order()
                {

                    DatePlaced = new DateTime(DateTime.Now.Year,
                        DateTime.Now.Month,
                        DateTime.Now.Day,
                        DateTime.Now.Hour,
                        DateTime.Now.Minute,
                        DateTime.Now.Second)
                };

                _order.Add();

                new Log()
                {
                    OrderId = _order.Id,
                    Comment = $"Заказ создан в \"{_order.DatePlaced}\""
                }.Add();
            }

            InitializeComponent();
        }
        
        private string TotalToString => $"{_order.Total ?? 0} руб.";

        public Order GetOrder() => _order;

        private void SetupForm()
        {
            SetupWorkDatesGrid();
            SetupServicesGrid();
            SetupEmployeesGrid();
            SetupLogsGrid();

            linkCustomer.Text = _order?.Customer?.FullName ?? Resources.No;
            linkCustomer.ActiveLinkColor = DraculaColor.Pink;
            linkCustomer.VisitedLinkColor = DraculaColor.Purple;

            lblPriceValue.Text = TotalToString;
            lblDatePlacedValue.Text = _order?.DatePlaced.ToString();

            if (_order?.DateOfMeasurements == null)
                dtpDateOfMeasurements.CustomFormat = Resources.Space;
            else
            {
                dtpDateOfMeasurements.Text = _order?.DateOfMeasurements.ToString();
                dtpDateOfMeasurements.CustomFormat = Resources.FilterDateTimePickerCustomFormat;
            }
            
            if (_order?.DatePaid == null)
                dtpDatePaid.CustomFormat = Resources.Space;
            else
            {
                dtpDatePaid.Text = _order?.DatePaid.ToString();
                dtpDateOfMeasurements.CustomFormat = Resources.FilterDateTimePickerCustomFormat;
            }

            dtpDateOfMeasurements.ValueChanged += DateOfMeasurementsValueChanged;
            dtpDatePaid.ValueChanged += DatePaidValueChanged;

            FillStatusComboBox();
            FillPaidByCashComboBox();
        }

        private void FillStatusComboBox()
        {
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown)
                    continue;

                var item = new ComboBoxItem()
                {
                    Content = status.ParseString(),
                    Tag = status,
                };

                cbStatus.Items.Add(item);
            }

            cbStatus.DisplayMember = Resources.DisplayMember;
            cbStatus.SelectedItem = null;

            foreach (ComboBoxItem item in cbStatus.Items)
            {
                if((OrderStatus)item.Tag == _order?.Status)
                    cbStatus.SelectedItem = item;
            }

            cbStatus.SelectedIndexChanged += StatusSelectedIndexChanged;
        }

        private void FillPaidByCashComboBox()
        {
            foreach (var paidByCashItem in Resources.PaidByCashItems)
            {
                var item = new ComboBoxItem()
                {
                    Content = paidByCashItem.Key,
                    Tag = paidByCashItem.Value,
                };

                cbPaidByCash.Items.Add(item);
            }

            cbPaidByCash.DisplayMember = Resources.DisplayMember;
            cbPaidByCash.SelectedItem = cbPaidByCash.Items[0];

            foreach (ComboBoxItem item in cbPaidByCash.Items)
                if ((bool)item.Tag == _order.PaidByCash)
                    cbPaidByCash.SelectedItem = item;

            cbPaidByCash.SelectedIndexChanged += PaidByCashSelectedIndexChanged;
        }

        private void SetupEmployeesGrid()
        {
            _employees = _order?.GetEmployees();
            
            dgvEmployees.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.CreateTextBoxColumn(Resources.PersonName, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.CreateTextBoxColumn(Resources.PhoneNumber, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.CreateButtonColumn();

            FillEmployeeGrid();
        }

        private void FillEmployeeGrid()
        {
            dgvEmployees.Rows.Clear();

            for (var i = 0; i < _employees?.Count; i++)
            {
                dgvEmployees.Rows.Add(new DataGridViewRow());

                dgvEmployees.Rows[i].Cells[0].Value = dgvEmployees.Rows.Count;
                dgvEmployees.Rows[i].Cells[1].Value = _employees[i].FullName;
                dgvEmployees.Rows[i].Cells[2].Value = _employees[i].Login;
            }
        }

        private void SetupServicesGrid()
        {
            _services = _order?.GetServices();

            dgvServices.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.CreateTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateTextBoxColumn(Resources.Ceiling, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateButtonColumn();

            FillServiceGrid();
        }

        private void FillServiceGrid()
        {
            dgvServices.Rows.Clear();

            for (var i = 0; i < _services?.Count; i++)
            {
                dgvServices.Rows.AddRange(new DataGridViewRow());

                dgvServices.Rows[i].Cells[0].Value = dgvServices.Rows.Count;
                dgvServices.Rows[i].Cells[1].Value = _services[i].Manufacturer.Name;
                dgvServices.Rows[i].Cells[2].Value = _services[i].Ceiling.Name;
                dgvServices.Rows[i].Cells[3].Value = _services[i].Price;
            }
        }

        private void SetupLogsGrid()
        {
            _logs = _order?.GetLogs();

            dgvLogs.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvLogs.CreateTextBoxColumn(Resources.DateCreated, DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.CreateTextBoxColumn(Resources.Action, DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.CreateButtonColumn();

            FillLogsGrid();
        }

        private void FillLogsGrid()
        {
            dgvLogs.Rows.Clear();

            for (var i = 0; i < _logs?.Count; i++)
            {
                dgvLogs.Rows.Add(new DataGridViewRow());

                dgvLogs.Rows[i].Cells[0].Value = dgvLogs.Rows.Count;
                dgvLogs.Rows[i].Cells[1].Value = _logs[i].DateCreated;
                dgvLogs.Rows[i].Cells[2].Value = _logs[i].Comment;
            }
        }

        private void SetupWorkDatesGrid()
        {
            _workDates = _order?.GetWorkDates();

            dgvWorkDates.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWorkDates.CreateTextBoxColumn(Resources.Date, DataGridViewAutoSizeColumnMode.Fill);
            dgvWorkDates.CreateButtonColumn();

            FillWorkDatesGrid();
        }

        private void FillWorkDatesGrid()
        {
            dgvWorkDates.Rows.Clear();

            for (var i = 0; i < _workDates?.Count; i++)
            {
                dgvWorkDates.Rows.Add(new DataGridViewRow());

                dgvWorkDates.Rows[i].Cells[0].Value = dgvWorkDates.Rows.Count;
                dgvWorkDates.Rows[i].Cells[1].Value = _workDates[i].DateOfWork;
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_order.HasNullField())
                _order.Delete();

            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void AddWorkDate(object sender, EventArgs e)
        {
            var form = new OrderWorkDateForm();

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var workDate = form.GetWorkDate();

            if (_order.GetWorkDates().Any(x => x.DateOfWork == workDate))
            {
                FlatMessageBox.ShowDialog("Текущая дата и время уже есть в заказе", Caption.Error);
                return;
            }

            new OrderWorkDate()
            {
                OrderId = _order.Id,
                DateOfWork = workDate
            }.Add();

            new Log()
            {
                OrderId = _order.Id,
                Comment = $"Добавлена дата выполнения работ \"{workDate}\""
            }.Add();

            _workDates = _order.GetWorkDates();
            _logs = _order.GetLogs();

            FillLogsGrid();
            FillWorkDatesGrid();

            FlatMessageBox.ShowDialog("Дата успешно добавлена", Caption.Info);
        }

        private void SelectCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new CustomersForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;
            
            new Log()
            {
                OrderId = _order.Id,
                Comment = $"Клиент изменен на \"{form.GetCustomer().FullName}\""
            }.Add();

            linkCustomer.Text = form.GetCustomer().FullName;
            _order.CustomerId = form.GetCustomer().Id;
            _logs = _order.GetLogs();

            FillLogsGrid();
        }

        private void AddService(object sender, EventArgs e)
        {
            var form = new ServicesForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var service = form.GetService();

            if (_order.GetServices().Any(x => x.Id == service.Id))
            {
                FlatMessageBox.ShowDialog("Данная услуга уже есть в заказе", Caption.Error);
                return;
            }

            new OrderService()
            {
                OrderId = _order.Id,
                ServiceId = service.Id
            }.Add();

            new Log()
            {
                OrderId = _order.Id,
                Comment = "Добавлена новая услуга"
            }.Add();

            _services = _order.GetServices();
            _logs = _order.GetLogs();
            _order.CalculateTotal();

            lblPriceValue.Text = TotalToString;

            FillLogsGrid();
            FillServiceGrid();

            FlatMessageBox.ShowDialog("Услуга успешно добавлена", Caption.Info);
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            var form = new EmployeesForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var employee = form.GetEmployee();

            if (_order.GetEmployees().Any(x => x.Id == employee.Id))
            {
                FlatMessageBox.ShowDialog("Данный мастер уже есть в заказе", Caption.Error);
                return;
            }

            new OrderEmployee()
            {
                OrderId = _order.Id,
                EmployeeId = form.GetEmployee().Id
            }.Add();

            new Log()
            {
                OrderId = _order.Id,
                Comment = $"Добавлен новый мастер \"{employee.FullName}\""
            }.Add();

            _employees = _order.GetEmployees();
            _logs = _order.GetLogs();

            FillLogsGrid();
            FillEmployeeGrid();

            FlatMessageBox.ShowDialog("Мастер успешно добавлен", Caption.Info);
        }

        private void DateOfMeasurementsValueChanged(object sender, EventArgs e)
        {
            var senderDateTimePicker = (DateTimePicker)sender;
            senderDateTimePicker.CustomFormat = Resources.FilterDateTimePickerCustomFormat;

            new Log()
            {
                OrderId = _order.Id,
                Comment = $"Дата замеров изменена на \"{dtpDateOfMeasurements.Value}\""
            }.Add();

            _logs = _order.GetLogs();
            FillLogsGrid();
        }

        private void DatePaidValueChanged(object sender, EventArgs e)
        {
            var senderDateTimePicker = (DateTimePicker)sender;
            senderDateTimePicker.CustomFormat = Resources.FilterDateTimePickerCustomFormat;

            new Log()
            {
                OrderId = _order.Id,
                Comment = $"Дата оплаты изменена на \"{dtpDatePaid.Value}\""
            }.Add();

            _logs = _order.GetLogs();
            FillLogsGrid();
        }

        private void StatusSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbStatus.Items)
                if (item == cbStatus.SelectedItem)
                    new Log()
                    {
                        OrderId = _order.Id,
                        Comment = $"Статус заказа изменен на \"{item.Content}\""
                    }.Add();

            _logs = _order.GetLogs();
            FillLogsGrid();
        }

        private void PaidByCashSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbPaidByCash.Items)
                if (item == cbPaidByCash.SelectedItem)
                    new Log()
                    {
                        OrderId = _order.Id,
                        Comment = $"Оплата наличными изменена на \"{item.Content}\""
                    }.Add();

            _logs = _order.GetLogs();
            FillLogsGrid();
        }

        private bool CanUpdate()
        {
            var can = true;

            if (dtpDateOfMeasurements.CustomFormat == Resources.Space)
            {
                errorProvider.SetError(dtpDateOfMeasurements, Resources.RequiredToFill);
                can = false;
            }

            if (cbStatus.SelectedItem == null)
            {
                errorProvider.SetError(cbStatus, Resources.RequiredToFill);
                can = false;
            }

            if (_order.CustomerId == null)
            {
                errorProvider.SetError(linkCustomer, Resources.RequiredToFill);
                can = false;
            }

            return can;
        }

        private void UpdateOrderFields()
        {
            foreach (ComboBoxItem item in cbStatus.Items)
                if (item == cbStatus.SelectedItem)
                    _order.Status = (OrderStatus)item.Tag;

            foreach (ComboBoxItem item in cbPaidByCash.Items)
                if (item == cbPaidByCash.SelectedItem)
                    _order.PaidByCash = (bool)item.Tag;

            if (dtpDateOfMeasurements.CustomFormat != Resources.Space)
                _order.DateOfMeasurements = dtpDateOfMeasurements.Value;

            if (dtpDatePaid.CustomFormat != Resources.Space)
                _order.DatePaid = dtpDatePaid.Value;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            if (CanUpdate() == false)
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateOrderFields();
            _order.Update();

            DialogResult = DialogResult.OK;
        }

        private void RemoveService(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить эту услугу из заказа?", Caption.Warning, MessageBoxState.Question) !=
                DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _services[index - 1];
            _order.RemoveService(service.Id);
            _services = _order.GetServices();
            _order.CalculateTotal();
            lblPriceValue.Text = TotalToString;

            FillServiceGrid();
            FlatMessageBox.ShowDialog("Услуга успешно удалена", Caption.Info);
        }

        private void RemoveWorkDate(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить эту дату?", Caption.Warning, MessageBoxState.Question) !=
                DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvWorkDates.Rows[e.RowIndex].Cells[0].Value);
            _workDates[index - 1].Delete();
            _workDates = _order.GetWorkDates();

            FillWorkDatesGrid();
            FlatMessageBox.ShowDialog("Дата успешно удалена", Caption.Info);
        }

        private void RemoveEmployee(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить этого сотрудника из заказа?", Caption.Warning, MessageBoxState.Question) !=
                DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            var employee = _employees[index - 1];
            _order.RemoveEmployee(employee.Id);
            _employees = _order.GetEmployees();

            FillEmployeeGrid();
            FlatMessageBox.ShowDialog("Сотрудник успешно удален", Caption.Info);
        }

        private void RemoveLog(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить этот лог?", Caption.Warning, MessageBoxState.Question) !=
                DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvLogs.Rows[e.RowIndex].Cells[0].Value);
            _logs[index - 1].Delete();
            _logs = _order.GetLogs();

            FillLogsGrid();
            FlatMessageBox.ShowDialog("Лог успешно удален", Caption.Info);
        }
    }
}
