
namespace StretchCeilings.Views
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.ibtnEmployee = new FontAwesome.Sharp.IconButton();
            this.lblPayment = new System.Windows.Forms.Label();
            this.ibtnCustomer = new FontAwesome.Sharp.IconButton();
            this.cbStatusValue = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbPaidByCash = new System.Windows.Forms.ComboBox();
            this.nudTotalTo = new System.Windows.Forms.NumericUpDown();
            this.nudIdValue = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.nudTotalFrom = new System.Windows.Forms.NumericUpDown();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpDateToValue = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateFromValue = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnUseFilters = new System.Windows.Forms.Button();
            this.paneUserButtons = new System.Windows.Forms.Panel();
            this.panelButtonsSide = new System.Windows.Forms.Panel();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).BeginInit();
            this.panelSearchButtons.SuspendLayout();
            this.panelButtonsSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPages
            // 
            this.panelPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPreviousPage);
            this.panelPages.Controls.Add(this.tbPage);
            this.panelPages.Controls.Add(this.btnNextPage);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 560);
            this.panelPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1050, 40);
            this.panelPages.TabIndex = 2;
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(995, 4);
            this.cbRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(50, 31);
            this.cbRows.TabIndex = 97;
            this.cbRows.SelectedIndexChanged += new System.EventHandler(this.cbRows_SelectedIndexChanged);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnPreviousPage.Location = new System.Drawing.Point(5, 4);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(31, 31);
            this.btnPreviousPage.TabIndex = 96;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            // 
            // tbPage
            // 
            this.tbPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPage.Location = new System.Drawing.Point(38, 5);
            this.tbPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPage.Name = "tbPage";
            this.tbPage.ReadOnly = true;
            this.tbPage.Size = new System.Drawing.Size(60, 29);
            this.tbPage.TabIndex = 95;
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnNextPage.Location = new System.Drawing.Point(100, 4);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(31, 31);
            this.btnNextPage.TabIndex = 94;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 100);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1050, 460);
            this.dgvOrders.TabIndex = 3;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelFilters.Controls.Add(this.ibtnEmployee);
            this.panelFilters.Controls.Add(this.lblPayment);
            this.panelFilters.Controls.Add(this.ibtnCustomer);
            this.panelFilters.Controls.Add(this.cbStatusValue);
            this.panelFilters.Controls.Add(this.lblEmployee);
            this.panelFilters.Controls.Add(this.lblCustomer);
            this.panelFilters.Controls.Add(this.cbPaidByCash);
            this.panelFilters.Controls.Add(this.nudTotalTo);
            this.panelFilters.Controls.Add(this.nudIdValue);
            this.panelFilters.Controls.Add(this.lblId);
            this.panelFilters.Controls.Add(this.nudTotalFrom);
            this.panelFilters.Controls.Add(this.lblPriceTo);
            this.panelFilters.Controls.Add(this.lblPriceFrom);
            this.panelFilters.Controls.Add(this.lblStatus);
            this.panelFilters.Controls.Add(this.dtpDateToValue);
            this.panelFilters.Controls.Add(this.lblDateTo);
            this.panelFilters.Controls.Add(this.dtpDateFromValue);
            this.panelFilters.Controls.Add(this.lblDateFrom);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1050, 100);
            this.panelFilters.TabIndex = 1;
            // 
            // ibtnEmployee
            // 
            this.ibtnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtnEmployee.FlatAppearance.BorderSize = 0;
            this.ibtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnEmployee.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnEmployee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmployee.IconSize = 25;
            this.ibtnEmployee.Location = new System.Drawing.Point(643, 38);
            this.ibtnEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnEmployee.Name = "ibtnEmployee";
            this.ibtnEmployee.Size = new System.Drawing.Size(25, 25);
            this.ibtnEmployee.TabIndex = 114;
            this.ibtnEmployee.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPayment.Location = new System.Drawing.Point(290, 70);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(179, 23);
            this.lblPayment.TabIndex = 116;
            this.lblPayment.Text = "Оплачен наличными:";
            // 
            // ibtnCustomer
            // 
            this.ibtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtnCustomer.FlatAppearance.BorderSize = 0;
            this.ibtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCustomer.IconSize = 25;
            this.ibtnCustomer.Location = new System.Drawing.Point(643, 6);
            this.ibtnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnCustomer.Name = "ibtnCustomer";
            this.ibtnCustomer.Size = new System.Drawing.Size(25, 25);
            this.ibtnCustomer.TabIndex = 113;
            this.ibtnCustomer.UseVisualStyleBackColor = true;
            // 
            // cbStatusValue
            // 
            this.cbStatusValue.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbStatusValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbStatusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbStatusValue.FormattingEnabled = true;
            this.cbStatusValue.Location = new System.Drawing.Point(643, 68);
            this.cbStatusValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusValue.Name = "cbStatusValue";
            this.cbStatusValue.Size = new System.Drawing.Size(280, 31);
            this.cbStatusValue.TabIndex = 103;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblEmployee.Location = new System.Drawing.Point(553, 6);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(89, 23);
            this.lblEmployee.TabIndex = 106;
            this.lblEmployee.Text = "Работник:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCustomer.Location = new System.Drawing.Point(553, 39);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(70, 23);
            this.lblCustomer.TabIndex = 105;
            this.lblCustomer.Text = "Клиент:";
            // 
            // cbPaidByCash
            // 
            this.cbPaidByCash.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbPaidByCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbPaidByCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidByCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPaidByCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbPaidByCash.FormattingEnabled = true;
            this.cbPaidByCash.Location = new System.Drawing.Point(482, 68);
            this.cbPaidByCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaidByCash.Name = "cbPaidByCash";
            this.cbPaidByCash.Size = new System.Drawing.Size(67, 31);
            this.cbPaidByCash.TabIndex = 115;
            // 
            // nudTotalTo
            // 
            this.nudTotalTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudTotalTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudTotalTo.Location = new System.Drawing.Point(390, 35);
            this.nudTotalTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudTotalTo.Name = "nudTotalTo";
            this.nudTotalTo.Size = new System.Drawing.Size(159, 29);
            this.nudTotalTo.TabIndex = 112;
            this.nudTotalTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalTo.ValueChanged += new System.EventHandler(this.nudTotalTo_ValueChanged);
            // 
            // nudIdValue
            // 
            this.nudIdValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudIdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudIdValue.Location = new System.Drawing.Point(225, 68);
            this.nudIdValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudIdValue.Name = "nudIdValue";
            this.nudIdValue.Size = new System.Drawing.Size(62, 29);
            this.nudIdValue.TabIndex = 110;
            this.nudIdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIdValue.ValueChanged += new System.EventHandler(this.nudIdValue_ValueChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblId.Location = new System.Drawing.Point(3, 70);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 23);
            this.lblId.TabIndex = 107;
            this.lblId.Text = "Номер:";
            // 
            // nudTotalFrom
            // 
            this.nudTotalFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudTotalFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudTotalFrom.Location = new System.Drawing.Point(128, 35);
            this.nudTotalFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudTotalFrom.Name = "nudTotalFrom";
            this.nudTotalFrom.Size = new System.Drawing.Size(159, 29);
            this.nudTotalFrom.TabIndex = 111;
            this.nudTotalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalFrom.ValueChanged += new System.EventHandler(this.nudTotalFrom_ValueChanged);
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceTo.Location = new System.Drawing.Point(290, 39);
            this.lblPriceTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Size = new System.Drawing.Size(33, 23);
            this.lblPriceTo.TabIndex = 109;
            this.lblPriceTo.Text = "до:";
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceFrom.Location = new System.Drawing.Point(3, 39);
            this.lblPriceFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Size = new System.Drawing.Size(121, 23);
            this.lblPriceFrom.TabIndex = 108;
            this.lblPriceFrom.Text = "Стоимость от:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblStatus.Location = new System.Drawing.Point(553, 70);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 23);
            this.lblStatus.TabIndex = 102;
            this.lblStatus.Text = "Статус:";
            // 
            // dtpDateToValue
            // 
            this.dtpDateToValue.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateToValue.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dtpDateToValue.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dtpDateToValue.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateToValue.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateToValue.CustomFormat = " ";
            this.dtpDateToValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateToValue.Location = new System.Drawing.Point(390, 3);
            this.dtpDateToValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateToValue.Name = "dtpDateToValue";
            this.dtpDateToValue.Size = new System.Drawing.Size(159, 29);
            this.dtpDateToValue.TabIndex = 101;
            this.dtpDateToValue.ValueChanged += new System.EventHandler(this.dtpDateToValue_ValueChanged);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateTo.Location = new System.Drawing.Point(290, 6);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(33, 23);
            this.lblDateTo.TabIndex = 100;
            this.lblDateTo.Text = "до:";
            // 
            // dtpDateFromValue
            // 
            this.dtpDateFromValue.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateFromValue.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dtpDateFromValue.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dtpDateFromValue.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateFromValue.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateFromValue.CustomFormat = " ";
            this.dtpDateFromValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFromValue.Location = new System.Drawing.Point(128, 3);
            this.dtpDateFromValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFromValue.Name = "dtpDateFromValue";
            this.dtpDateFromValue.Size = new System.Drawing.Size(159, 29);
            this.dtpDateFromValue.TabIndex = 99;
            this.dtpDateFromValue.ValueChanged += new System.EventHandler(this.dtpDateFromValue_ValueChanged);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateFrom.Location = new System.Drawing.Point(3, 6);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(73, 23);
            this.lblDateFrom.TabIndex = 98;
            this.lblDateFrom.Text = "Дата от:";
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Controls.Add(this.btnResetFilters);
            this.panelSearchButtons.Controls.Add(this.btnUseFilters);
            this.panelSearchButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchButtons.Location = new System.Drawing.Point(0, 0);
            this.panelSearchButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new System.Drawing.Size(150, 100);
            this.panelSearchButtons.TabIndex = 0;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetFilters.FlatAppearance.BorderSize = 0;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnResetFilters.Location = new System.Drawing.Point(0, 50);
            this.btnResetFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(150, 50);
            this.btnResetFilters.TabIndex = 16;
            this.btnResetFilters.Text = "Сбросить";
            this.btnResetFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // btnUseFilters
            // 
            this.btnUseFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUseFilters.FlatAppearance.BorderSize = 0;
            this.btnUseFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnUseFilters.Location = new System.Drawing.Point(0, 0);
            this.btnUseFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUseFilters.Name = "btnUseFilters";
            this.btnUseFilters.Size = new System.Drawing.Size(150, 50);
            this.btnUseFilters.TabIndex = 15;
            this.btnUseFilters.Text = "Применить";
            this.btnUseFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseFilters.UseVisualStyleBackColor = true;
            this.btnUseFilters.Click += new System.EventHandler(this.btnUseFilters_Click);
            // 
            // paneUserButtons
            // 
            this.paneUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneUserButtons.Location = new System.Drawing.Point(0, 100);
            this.paneUserButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneUserButtons.Name = "paneUserButtons";
            this.paneUserButtons.Size = new System.Drawing.Size(150, 500);
            this.paneUserButtons.TabIndex = 1;
            // 
            // panelButtonsSide
            // 
            this.panelButtonsSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelButtonsSide.Controls.Add(this.paneUserButtons);
            this.panelButtonsSide.Controls.Add(this.panelSearchButtons);
            this.panelButtonsSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonsSide.Location = new System.Drawing.Point(1050, 0);
            this.panelButtonsSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtonsSide.Name = "panelButtonsSide";
            this.panelButtonsSide.Size = new System.Drawing.Size(150, 600);
            this.panelButtonsSide.TabIndex = 0;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelButtonsSide);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).EndInit();
            this.panelSearchButtons.ResumeLayout(false);
            this.panelButtonsSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnUseFilters;
        private System.Windows.Forms.Panel paneUserButtons;
        private System.Windows.Forms.Panel panelButtonsSide;
        private FontAwesome.Sharp.IconButton ibtnCustomer;
        private System.Windows.Forms.NumericUpDown nudTotalTo;
        private System.Windows.Forms.NumericUpDown nudTotalFrom;
        private System.Windows.Forms.NumericUpDown nudIdValue;
        private System.Windows.Forms.Label lblPriceTo;
        private System.Windows.Forms.Label lblPriceFrom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpDateToValue;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFromValue;
        private System.Windows.Forms.Label lblDateFrom;
        private FontAwesome.Sharp.IconButton ibtnEmployee;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cbPaidByCash;
    }
}