
namespace stretch_ceilings_app.Forms
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
            this.panelButtonsSide = new System.Windows.Forms.Panel();
            this.paneUserButtons = new System.Windows.Forms.Panel();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnUseFilters = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.ibtnEmployee = new FontAwesome.Sharp.IconButton();
            this.ibtnCustomer = new FontAwesome.Sharp.IconButton();
            this.nudTotalTo = new System.Windows.Forms.NumericUpDown();
            this.nudTotalFrom = new System.Windows.Forms.NumericUpDown();
            this.nudIdValue = new System.Windows.Forms.NumericUpDown();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbPaidByCash = new System.Windows.Forms.CheckBox();
            this.cbStatusValue = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpDateToValue = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateFromValue = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelButtonsSide.SuspendLayout();
            this.panelSearchButtons.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdValue)).BeginInit();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtonsSide
            // 
            this.panelButtonsSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelButtonsSide.Controls.Add(this.paneUserButtons);
            this.panelButtonsSide.Controls.Add(this.panelSearchButtons);
            this.panelButtonsSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonsSide.Location = new System.Drawing.Point(1054, 0);
            this.panelButtonsSide.Name = "panelButtonsSide";
            this.panelButtonsSide.Size = new System.Drawing.Size(130, 565);
            this.panelButtonsSide.TabIndex = 0;
            // 
            // paneUserButtons
            // 
            this.paneUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneUserButtons.Location = new System.Drawing.Point(0, 110);
            this.paneUserButtons.Name = "paneUserButtons";
            this.paneUserButtons.Size = new System.Drawing.Size(130, 455);
            this.paneUserButtons.TabIndex = 1;
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Controls.Add(this.btnResetFilters);
            this.panelSearchButtons.Controls.Add(this.btnUseFilters);
            this.panelSearchButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchButtons.Location = new System.Drawing.Point(0, 0);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new System.Drawing.Size(130, 110);
            this.panelSearchButtons.TabIndex = 0;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetFilters.FlatAppearance.BorderSize = 0;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnResetFilters.Location = new System.Drawing.Point(0, 56);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(130, 55);
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
            this.btnUseFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnUseFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnUseFilters.Location = new System.Drawing.Point(0, 0);
            this.btnUseFilters.Name = "btnUseFilters";
            this.btnUseFilters.Size = new System.Drawing.Size(130, 56);
            this.btnUseFilters.TabIndex = 15;
            this.btnUseFilters.Text = "Применить";
            this.btnUseFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseFilters.UseVisualStyleBackColor = true;
            this.btnUseFilters.Click += new System.EventHandler(this.btnUseFilters_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelFilters.Controls.Add(this.ibtnEmployee);
            this.panelFilters.Controls.Add(this.ibtnCustomer);
            this.panelFilters.Controls.Add(this.nudTotalTo);
            this.panelFilters.Controls.Add(this.nudTotalFrom);
            this.panelFilters.Controls.Add(this.nudIdValue);
            this.panelFilters.Controls.Add(this.lblPriceTo);
            this.panelFilters.Controls.Add(this.lblPriceFrom);
            this.panelFilters.Controls.Add(this.lblId);
            this.panelFilters.Controls.Add(this.lblEmployee);
            this.panelFilters.Controls.Add(this.lblCustomer);
            this.panelFilters.Controls.Add(this.cbPaidByCash);
            this.panelFilters.Controls.Add(this.cbStatusValue);
            this.panelFilters.Controls.Add(this.lblStatus);
            this.panelFilters.Controls.Add(this.dtpDateToValue);
            this.panelFilters.Controls.Add(this.lblDateTo);
            this.panelFilters.Controls.Add(this.dtpDateFromValue);
            this.panelFilters.Controls.Add(this.lblDateFrom);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1054, 110);
            this.panelFilters.TabIndex = 1;
            // 
            // ibtnEmployee
            // 
            this.ibtnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtnEmployee.FlatAppearance.BorderSize = 0;
            this.ibtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibtnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnEmployee.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnEmployee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmployee.IconSize = 25;
            this.ibtnEmployee.Location = new System.Drawing.Point(873, 43);
            this.ibtnEmployee.Name = "ibtnEmployee";
            this.ibtnEmployee.Size = new System.Drawing.Size(25, 25);
            this.ibtnEmployee.TabIndex = 97;
            this.ibtnEmployee.UseVisualStyleBackColor = true;
            this.ibtnEmployee.Click += new System.EventHandler(this.ibtnEmployee_Click);
            // 
            // ibtnCustomer
            // 
            this.ibtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtnCustomer.FlatAppearance.BorderSize = 0;
            this.ibtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibtnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ibtnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCustomer.IconSize = 25;
            this.ibtnCustomer.Location = new System.Drawing.Point(873, 9);
            this.ibtnCustomer.Name = "ibtnCustomer";
            this.ibtnCustomer.Size = new System.Drawing.Size(25, 25);
            this.ibtnCustomer.TabIndex = 96;
            this.ibtnCustomer.UseVisualStyleBackColor = true;
            this.ibtnCustomer.Click += new System.EventHandler(this.ibtnCustomer_Click);
            // 
            // nudTotalTo
            // 
            this.nudTotalTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalTo.Location = new System.Drawing.Point(623, 41);
            this.nudTotalTo.Name = "nudTotalTo";
            this.nudTotalTo.Size = new System.Drawing.Size(122, 29);
            this.nudTotalTo.TabIndex = 95;
            this.nudTotalTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalTo.ValueChanged += new System.EventHandler(this.nudTotalTo_ValueChanged);
            // 
            // nudTotalFrom
            // 
            this.nudTotalFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalFrom.Location = new System.Drawing.Point(447, 41);
            this.nudTotalFrom.Name = "nudTotalFrom";
            this.nudTotalFrom.Size = new System.Drawing.Size(126, 29);
            this.nudTotalFrom.TabIndex = 94;
            this.nudTotalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalFrom.ValueChanged += new System.EventHandler(this.nudTotalFrom_ValueChanged);
            // 
            // nudIdValue
            // 
            this.nudIdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudIdValue.Location = new System.Drawing.Point(102, 75);
            this.nudIdValue.Name = "nudIdValue";
            this.nudIdValue.Size = new System.Drawing.Size(77, 29);
            this.nudIdValue.TabIndex = 93;
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceTo.Location = new System.Drawing.Point(579, 43);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Size = new System.Drawing.Size(38, 24);
            this.lblPriceTo.TabIndex = 91;
            this.lblPriceTo.Text = "до:";
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceFrom.Location = new System.Drawing.Point(297, 43);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Size = new System.Drawing.Size(141, 24);
            this.lblPriceFrom.TabIndex = 89;
            this.lblPriceFrom.Text = "Стоимость от:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblId.Location = new System.Drawing.Point(14, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 24);
            this.lblId.TabIndex = 88;
            this.lblId.Text = "Номер:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblEmployee.Location = new System.Drawing.Point(762, 43);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(100, 24);
            this.lblEmployee.TabIndex = 83;
            this.lblEmployee.Text = "Работник:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCustomer.Location = new System.Drawing.Point(762, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(80, 24);
            this.lblCustomer.TabIndex = 81;
            this.lblCustomer.Text = "Клиент:";
            // 
            // cbPaidByCash
            // 
            this.cbPaidByCash.AutoSize = true;
            this.cbPaidByCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbPaidByCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbPaidByCash.Location = new System.Drawing.Point(279, 76);
            this.cbPaidByCash.Name = "cbPaidByCash";
            this.cbPaidByCash.Size = new System.Drawing.Size(212, 28);
            this.cbPaidByCash.TabIndex = 80;
            this.cbPaidByCash.Text = "Оплачен наличными";
            this.cbPaidByCash.UseVisualStyleBackColor = false;
            // 
            // cbStatusValue
            // 
            this.cbStatusValue.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbStatusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbStatusValue.FormattingEnabled = true;
            this.cbStatusValue.Location = new System.Drawing.Point(447, 7);
            this.cbStatusValue.Name = "cbStatusValue";
            this.cbStatusValue.Size = new System.Drawing.Size(298, 32);
            this.cbStatusValue.TabIndex = 79;
            this.cbStatusValue.SelectedIndexChanged += new System.EventHandler(this.cbStatusValue_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblStatus.Location = new System.Drawing.Point(297, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 24);
            this.lblStatus.TabIndex = 78;
            this.lblStatus.Text = "Статус:";
            // 
            // dtpDateToValue
            // 
            this.dtpDateToValue.CustomFormat = " ";
            this.dtpDateToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateToValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateToValue.Location = new System.Drawing.Point(102, 41);
            this.dtpDateToValue.Name = "dtpDateToValue";
            this.dtpDateToValue.Size = new System.Drawing.Size(189, 29);
            this.dtpDateToValue.TabIndex = 77;
            this.dtpDateToValue.ValueChanged += new System.EventHandler(this.dtpDateToValue_ValueChanged);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateTo.Location = new System.Drawing.Point(12, 43);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(87, 24);
            this.lblDateTo.TabIndex = 76;
            this.lblDateTo.Text = "Дата до:";
            // 
            // dtpDateFromValue
            // 
            this.dtpDateFromValue.CustomFormat = " ";
            this.dtpDateFromValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateFromValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFromValue.Location = new System.Drawing.Point(102, 7);
            this.dtpDateFromValue.Name = "dtpDateFromValue";
            this.dtpDateFromValue.Size = new System.Drawing.Size(189, 29);
            this.dtpDateFromValue.TabIndex = 75;
            this.dtpDateFromValue.ValueChanged += new System.EventHandler(this.dtpDateFromValue_ValueChanged);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateFrom.Location = new System.Drawing.Point(12, 9);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(85, 24);
            this.lblDateFrom.TabIndex = 74;
            this.lblDateFrom.Text = "Дата от:";
            // 
            // panelPages
            // 
            this.panelPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPreviousPage);
            this.panelPages.Controls.Add(this.tbPage);
            this.panelPages.Controls.Add(this.btnNextPage);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 525);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1054, 40);
            this.panelPages.TabIndex = 2;
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(994, 4);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(55, 32);
            this.cbRows.TabIndex = 97;
            this.cbRows.SelectedIndexChanged += new System.EventHandler(this.cbRows_SelectedIndexChanged);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnPreviousPage.Location = new System.Drawing.Point(8, 5);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(30, 29);
            this.btnPreviousPage.TabIndex = 96;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbPage
            // 
            this.tbPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPage.Location = new System.Drawing.Point(44, 5);
            this.tbPage.Name = "tbPage";
            this.tbPage.ReadOnly = true;
            this.tbPage.Size = new System.Drawing.Size(80, 29);
            this.tbPage.TabIndex = 95;
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnNextPage.Location = new System.Drawing.Point(130, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(30, 29);
            this.btnNextPage.TabIndex = 94;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 110);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1054, 415);
            this.dgvOrders.TabIndex = 3;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 565);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelButtonsSide);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panelButtonsSide.ResumeLayout(false);
            this.panelSearchButtons.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdValue)).EndInit();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonsSide;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblPriceTo;
        private System.Windows.Forms.Label lblPriceFrom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.CheckBox cbPaidByCash;
        private System.Windows.Forms.ComboBox cbStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpDateToValue;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFromValue;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.NumericUpDown nudIdValue;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Panel paneUserButtons;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnUseFilters;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.NumericUpDown nudTotalFrom;
        private System.Windows.Forms.NumericUpDown nudTotalTo;
        private FontAwesome.Sharp.IconButton ibtnEmployee;
        private FontAwesome.Sharp.IconButton ibtnCustomer;
    }
}