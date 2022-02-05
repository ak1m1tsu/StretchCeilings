using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class ServiceEditForm : Form
    {
        private readonly Service _service;
        private List<AdditionalService> _addedAdditionalServices;
        private List<AdditionalService> _removedAdditionalServices;

        public ServiceEditForm(Service service)
        {
            _service = service;
            _addedAdditionalServices = new List<AdditionalService>();
            _removedAdditionalServices = new List<AdditionalService>();

            InitializeComponent();
        }

        private void SetupGrid()
        {
            dgvAdditServs.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditServs.AddDataGridViewTextBoxColumn("Название", DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditServs.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditServs.AddDataGridViewTextBoxColumn("Кол-во", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditServs.Columns["Кол-во"].ReadOnly = false;
            dgvAdditServs.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvAdditServs.Font = GoogleFont.OpenSans;
            dgvAdditServs.ForeColor = DraculaColor.Background;
            dgvAdditServs.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvAdditServs.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {

        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new AdditionalServicesForm(FormState.ForSearching);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var rows = dgvAdditServs.Rows.Count;
            var additionalService = form.GetAdditionalService();

            _addedAdditionalServices.Add(additionalService);

            for (var i = rows; i < rows+1; i++)
            {
                dgvAdditServs.Rows.Add(new DataGridViewRow());
                dgvAdditServs.Rows[i].Cells[0].Value = additionalService.Id;
                dgvAdditServs.Rows[i].Cells[1].Value = additionalService.Name;
                dgvAdditServs.Rows[i].Cells[2].Value = additionalService.Price;
                dgvAdditServs.Rows[i].Cells[3].Value = 1;
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupGrid();
        }
    }
}
