﻿using System;
using System.Windows.Forms;
using StretchCeilings.UI.Extensions;

namespace StretchCeilings.UI.Views
{
    /// <inheritdoc />
    public partial class OrderWorkDateForm : Form
    {
        private DateTime _date;

        /// <inheritdoc />
        public OrderWorkDateForm()
        {
            InitializeComponent();
        }

        public DateTime GetWorkDate() => _date;

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void AddWorkDate(object sender, EventArgs e)
        {
            _date = new DateTime(
                dtp.Value.Year,
                dtp.Value.Month,
                dtp.Value.Day,
                dtp.Value.Hour,
                dtp.Value.Minute,
                dtp.Value.Second);

            DialogResult = DialogResult.OK;
        }
    }
}
