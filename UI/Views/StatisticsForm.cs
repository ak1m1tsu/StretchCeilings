using System;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Controls;

namespace StretchCeilings.UI.Views
{
    /// <inheritdoc />
    public partial class StatisticsForm : Form
    {
        private readonly IAdditionalServiceRepository _additionalServiceRepository;
        private readonly ICustomerRepository _customerRepository;

        /// <inheritdoc />
        public StatisticsForm()
        {
            InitializeComponent();

            panelAdditionalServicesButtons.Controls.Add(new FlatButton("additionalService", "Показать", BuildAdditionalServiceStatistics));
            panelCustomerButtons.Controls.Add(new FlatButton("customer", "Показать", BuildCustomerStatistics));

            _additionalServiceRepository = new AdditionalServiceRepository();
            _customerRepository = new CustomerRepository();
            
        }

        private bool IsPeriodValid(DateTime from, DateTime until)
        {
            return from < until;
        }

        private void BuildAdditionalServiceStatistics(object sender, EventArgs e)
        {
            if (IsPeriodValid(dateTimePickerServicePeriodFrom.Value, dateTimePickerAdditionalServicePeriodUntil.Value) == false)
            {
                FlatMessageBox.ShowDialog("Не верно указан период", Caption.Error);
                return;
            }

            chartAdditionalService.Series[0].Points.Clear();
            chartAdditionalService.Titles[0].Text = $@"Кол-во доп. услуг в заказах за {dateTimePickerServicePeriodFrom.Value:d} - {dateTimePickerAdditionalServicePeriodUntil.Value:d}";

            var additionalServices = _additionalServiceRepository.GetAll().ToList();
            var index = 0;

            foreach (var additionalService in additionalServices)
            {
                var count = additionalService.CountInOrders(dateTimePickerServicePeriodFrom.Value, dateTimePickerAdditionalServicePeriodUntil.Value);

                if (count == 0)
                    continue;

                chartAdditionalService.Series[0].Points.AddXY(index + 1, count);
                chartAdditionalService.Series[0].Points[index].Label = additionalService.Name;
                index++;
            }
        }

        private void BuildCustomerStatistics(object sender, EventArgs e)
        {
            if (IsPeriodValid(dateTimePickerCustomerPeriodFrom.Value, dateTimePickerCustomerPeriodUntil.Value) == false)
            {
                FlatMessageBox.ShowDialog("Не верно указан период", Caption.Error);
                return;
            }

            chartCustomers.Series[0].Points.Clear();
            chartCustomers.Titles[0].Text = $@"Кол-во заказов у клиентов за {dateTimePickerCustomerPeriodFrom.Value:d} - {dateTimePickerCustomerPeriodUntil.Value:d}";

            var customers = _customerRepository.GetAll().ToList();
            var index = 0;

            foreach (var customer in customers)
            {
                var count = customer.GetOrdersCount(dateTimePickerCustomerPeriodFrom.Value, dateTimePickerCustomerPeriodUntil.Value);

                if (count == 0)
                    continue;

                chartCustomers.Series[0].Points.AddXY(index + 1, count);
                chartCustomers.Series[0].Points[index].Label = customer.FullName;
                index++;
            }
        }

        private static void CorrectDateTimePickerValue(DateTimePicker dateTimePicker, EventArgs e)
        {
            var year = dateTimePicker.Value.Year;
            var month = dateTimePicker.Value.Month;
            var day = dateTimePicker.Value.Day;

            dateTimePicker.Value = new DateTime(year, month, day, 0, 0, 0);
        }

        private void dateTimePickerPeriodFrom_ValueChanged(object sender, EventArgs e)
        {
            CorrectDateTimePickerValue(sender as DateTimePicker, e);
        }

        private void dateTimePickerPeriodUntil_ValueChanged(object sender, EventArgs e)
        {
            CorrectDateTimePickerValue(sender as DateTimePicker, e);
        }
    }
}
