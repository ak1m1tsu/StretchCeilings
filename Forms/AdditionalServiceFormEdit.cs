using stretch_ceilings_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class AdditionalServiceFormEdit : Form
    {
        private AdditionalService _currentService;
        public AdditionalServiceFormEdit(AdditionalService service)
        {
            _currentService = service;
            InitializeComponent();
        }

        private void SaveChanges()
        {
            _currentService.Name = tbName.Text;
            _currentService.Price = nudPrice.Value;
            _currentService.Update();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }
    }
}
