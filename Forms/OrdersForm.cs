using stretch_ceilings_app.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace stretch_ceilings_app
{
    public partial class OrdersForm : Form
    {
        private OrderRepository repository;
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OrderForm().ShowDialog();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            repository = new OrderRepository();
            dataGridView1.DataSource = repository.Get();
        }
    }
}
