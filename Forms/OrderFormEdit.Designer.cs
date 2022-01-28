
namespace StretchCeilingsApp.Forms
{
    partial class OrderFormEdit
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tcOrder = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.linkLblCustomer = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateCanceledValue = new System.Windows.Forms.Label();
            this.lblDateCanceled = new System.Windows.Forms.Label();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblDateOfMeasurements = new System.Windows.Forms.Label();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtpDatePlaced = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePaid = new System.Windows.Forms.DateTimePicker();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.cbPaidByCash = new System.Windows.Forms.CheckBox();
            this.dtpDateOfMeasurements = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbStatusValue = new System.Windows.Forms.ComboBox();
            this.gpWorkDates = new System.Windows.Forms.GroupBox();
            this.dgvWorkDates = new System.Windows.Forms.DataGridView();
            this.panelWorkDatesButtons = new System.Windows.Forms.Panel();
            this.btnAddWorkDay = new System.Windows.Forms.Button();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.panelServiceButtons = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelEmployeesButtons = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tpLogs = new System.Windows.Forms.TabPage();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tcOrder.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.gpWorkDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).BeginInit();
            this.panelWorkDatesButtons.SuspendLayout();
            this.tpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelServiceButtons.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panelEmployeesButtons.SuspendLayout();
            this.tpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 25);
            this.panelTop.TabIndex = 78;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(1075, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tcOrder
            // 
            this.tcOrder.Controls.Add(this.tpInfo);
            this.tcOrder.Controls.Add(this.tpServices);
            this.tcOrder.Controls.Add(this.tpEmployees);
            this.tcOrder.Controls.Add(this.tpLogs);
            this.tcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOrder.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tcOrder.Location = new System.Drawing.Point(0, 25);
            this.tcOrder.Name = "tcOrder";
            this.tcOrder.SelectedIndex = 0;
            this.tcOrder.Size = new System.Drawing.Size(1100, 375);
            this.tcOrder.TabIndex = 79;
            // 
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpInfo.Controls.Add(this.linkLblCustomer);
            this.tpInfo.Controls.Add(this.lblStatus);
            this.tpInfo.Controls.Add(this.lblDateCanceledValue);
            this.tpInfo.Controls.Add(this.lblDateCanceled);
            this.tpInfo.Controls.Add(this.lblDatePaid);
            this.tpInfo.Controls.Add(this.lblDateOfMeasurements);
            this.tpInfo.Controls.Add(this.lblDatePlaced);
            this.tpInfo.Controls.Add(this.lblCustomer);
            this.tpInfo.Controls.Add(this.dtpDatePlaced);
            this.tpInfo.Controls.Add(this.dtpDatePaid);
            this.tpInfo.Controls.Add(this.lblPriceValue);
            this.tpInfo.Controls.Add(this.cbPaidByCash);
            this.tpInfo.Controls.Add(this.dtpDateOfMeasurements);
            this.tpInfo.Controls.Add(this.lblPrice);
            this.tpInfo.Controls.Add(this.cbStatusValue);
            this.tpInfo.Controls.Add(this.gpWorkDates);
            this.tpInfo.Location = new System.Drawing.Point(4, 32);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(1092, 339);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Основная информация";
            // 
            // linkLblCustomer
            // 
            this.linkLblCustomer.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblCustomer.AutoSize = true;
            this.linkLblCustomer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.linkLblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCustomer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCustomer.Location = new System.Drawing.Point(172, 7);
            this.linkLblCustomer.MaximumSize = new System.Drawing.Size(100, 23);
            this.linkLblCustomer.Name = "linkLblCustomer";
            this.linkLblCustomer.Size = new System.Drawing.Size(29, 23);
            this.linkLblCustomer.TabIndex = 98;
            this.linkLblCustomer.TabStop = true;
            this.linkLblCustomer.Text = "👤";
            this.linkLblCustomer.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblStatus.Location = new System.Drawing.Point(6, 156);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 23);
            this.lblStatus.TabIndex = 69;
            this.lblStatus.Text = "Статус:";
            // 
            // lblDateCanceledValue
            // 
            this.lblDateCanceledValue.AutoSize = true;
            this.lblDateCanceledValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDateCanceledValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateCanceledValue.Location = new System.Drawing.Point(172, 128);
            this.lblDateCanceledValue.Name = "lblDateCanceledValue";
            this.lblDateCanceledValue.Size = new System.Drawing.Size(39, 23);
            this.lblDateCanceledValue.TabIndex = 68;
            this.lblDateCanceledValue.Text = "Нет";
            // 
            // lblDateCanceled
            // 
            this.lblDateCanceled.AutoSize = true;
            this.lblDateCanceled.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDateCanceled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateCanceled.Location = new System.Drawing.Point(6, 126);
            this.lblDateCanceled.Name = "lblDateCanceled";
            this.lblDateCanceled.Size = new System.Drawing.Size(116, 23);
            this.lblDateCanceled.TabIndex = 67;
            this.lblDateCanceled.Text = "Дата отмены:";
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDatePaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDatePaid.Location = new System.Drawing.Point(6, 96);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(113, 23);
            this.lblDatePaid.TabIndex = 66;
            this.lblDatePaid.Text = "Дата оплаты:";
            // 
            // lblDateOfMeasurements
            // 
            this.lblDateOfMeasurements.AutoSize = true;
            this.lblDateOfMeasurements.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDateOfMeasurements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateOfMeasurements.Location = new System.Drawing.Point(6, 66);
            this.lblDateOfMeasurements.Name = "lblDateOfMeasurements";
            this.lblDateOfMeasurements.Size = new System.Drawing.Size(122, 23);
            this.lblDateOfMeasurements.TabIndex = 65;
            this.lblDateOfMeasurements.Text = "Дата замеров:";
            // 
            // lblDatePlaced
            // 
            this.lblDatePlaced.AutoSize = true;
            this.lblDatePlaced.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDatePlaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDatePlaced.Location = new System.Drawing.Point(6, 36);
            this.lblDatePlaced.Name = "lblDatePlaced";
            this.lblDatePlaced.Size = new System.Drawing.Size(155, 23);
            this.lblDatePlaced.TabIndex = 64;
            this.lblDatePlaced.Text = "Дата размещения:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCustomer.Location = new System.Drawing.Point(6, 6);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(70, 23);
            this.lblCustomer.TabIndex = 48;
            this.lblCustomer.Text = "Клиент:";
            // 
            // dtpDatePlaced
            // 
            this.dtpDatePlaced.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatePlaced.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpDatePlaced.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePlaced.Location = new System.Drawing.Point(172, 36);
            this.dtpDatePlaced.Name = "dtpDatePlaced";
            this.dtpDatePlaced.Size = new System.Drawing.Size(157, 29);
            this.dtpDatePlaced.TabIndex = 50;
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatePaid.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePaid.Location = new System.Drawing.Point(172, 96);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(157, 29);
            this.dtpDatePaid.TabIndex = 52;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(172, 218);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(41, 23);
            this.lblPriceValue.TabIndex = 60;
            this.lblPriceValue.Text = "0.00";
            // 
            // cbPaidByCash
            // 
            this.cbPaidByCash.AutoSize = true;
            this.cbPaidByCash.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbPaidByCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbPaidByCash.Location = new System.Drawing.Point(4, 190);
            this.cbPaidByCash.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidByCash.Name = "cbPaidByCash";
            this.cbPaidByCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPaidByCash.Size = new System.Drawing.Size(186, 27);
            this.cbPaidByCash.TabIndex = 59;
            this.cbPaidByCash.Text = ":Оплата наличными";
            this.cbPaidByCash.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfMeasurements
            // 
            this.dtpDateOfMeasurements.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateOfMeasurements.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpDateOfMeasurements.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfMeasurements.Location = new System.Drawing.Point(172, 66);
            this.dtpDateOfMeasurements.Name = "dtpDateOfMeasurements";
            this.dtpDateOfMeasurements.Size = new System.Drawing.Size(157, 29);
            this.dtpDateOfMeasurements.TabIndex = 54;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(6, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 23);
            this.lblPrice.TabIndex = 58;
            this.lblPrice.Text = "Цена:";
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
            this.cbStatusValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbStatusValue.FormattingEnabled = true;
            this.cbStatusValue.Location = new System.Drawing.Point(172, 156);
            this.cbStatusValue.Name = "cbStatusValue";
            this.cbStatusValue.Size = new System.Drawing.Size(280, 31);
            this.cbStatusValue.TabIndex = 60;
            // 
            // gpWorkDates
            // 
            this.gpWorkDates.Controls.Add(this.dgvWorkDates);
            this.gpWorkDates.Controls.Add(this.panelWorkDatesButtons);
            this.gpWorkDates.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpWorkDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.gpWorkDates.Location = new System.Drawing.Point(518, 3);
            this.gpWorkDates.Name = "gpWorkDates";
            this.gpWorkDates.Size = new System.Drawing.Size(571, 333);
            this.gpWorkDates.TabIndex = 0;
            this.gpWorkDates.TabStop = false;
            this.gpWorkDates.Text = "Дата(ы) выполнения";
            // 
            // dgvWorkDates
            // 
            this.dgvWorkDates.AllowUserToAddRows = false;
            this.dgvWorkDates.AllowUserToDeleteRows = false;
            this.dgvWorkDates.AllowUserToResizeColumns = false;
            this.dgvWorkDates.AllowUserToResizeRows = false;
            this.dgvWorkDates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvWorkDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkDates.Location = new System.Drawing.Point(3, 25);
            this.dgvWorkDates.Name = "dgvWorkDates";
            this.dgvWorkDates.RowHeadersVisible = false;
            this.dgvWorkDates.Size = new System.Drawing.Size(565, 265);
            this.dgvWorkDates.TabIndex = 1;
            // 
            // panelWorkDatesButtons
            // 
            this.panelWorkDatesButtons.Controls.Add(this.btnAddWorkDay);
            this.panelWorkDatesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWorkDatesButtons.Location = new System.Drawing.Point(3, 290);
            this.panelWorkDatesButtons.Name = "panelWorkDatesButtons";
            this.panelWorkDatesButtons.Size = new System.Drawing.Size(565, 40);
            this.panelWorkDatesButtons.TabIndex = 0;
            // 
            // btnAddWorkDay
            // 
            this.btnAddWorkDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddWorkDay.FlatAppearance.BorderSize = 0;
            this.btnAddWorkDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkDay.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAddWorkDay.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkDay.Location = new System.Drawing.Point(441, 5);
            this.btnAddWorkDay.Name = "btnAddWorkDay";
            this.btnAddWorkDay.Size = new System.Drawing.Size(120, 30);
            this.btnAddWorkDay.TabIndex = 43;
            this.btnAddWorkDay.Text = "Добавить";
            this.btnAddWorkDay.UseVisualStyleBackColor = false;
            // 
            // tpServices
            // 
            this.tpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpServices.Controls.Add(this.dgvServices);
            this.tpServices.Controls.Add(this.panelServiceButtons);
            this.tpServices.Location = new System.Drawing.Point(4, 32);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(1176, 400);
            this.tpServices.TabIndex = 1;
            this.tpServices.Text = "Услуги";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(3, 3);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.Size = new System.Drawing.Size(1170, 354);
            this.dgvServices.TabIndex = 4;
            // 
            // panelServiceButtons
            // 
            this.panelServiceButtons.Controls.Add(this.btnAddService);
            this.panelServiceButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelServiceButtons.Location = new System.Drawing.Point(3, 357);
            this.panelServiceButtons.Name = "panelServiceButtons";
            this.panelServiceButtons.Size = new System.Drawing.Size(1170, 40);
            this.panelServiceButtons.TabIndex = 3;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnAddService.Location = new System.Drawing.Point(1043, 5);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(120, 30);
            this.btnAddService.TabIndex = 44;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = false;
            // 
            // tpEmployees
            // 
            this.tpEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpEmployees.Controls.Add(this.dgvEmployees);
            this.tpEmployees.Controls.Add(this.panelEmployeesButtons);
            this.tpEmployees.Location = new System.Drawing.Point(4, 32);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(1176, 400);
            this.tpEmployees.TabIndex = 2;
            this.tpEmployees.Text = "Мастера";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1170, 354);
            this.dgvEmployees.TabIndex = 2;
            // 
            // panelEmployeesButtons
            // 
            this.panelEmployeesButtons.Controls.Add(this.btnAddEmployee);
            this.panelEmployeesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeesButtons.Location = new System.Drawing.Point(3, 357);
            this.panelEmployeesButtons.Name = "panelEmployeesButtons";
            this.panelEmployeesButtons.Size = new System.Drawing.Size(1170, 40);
            this.panelEmployeesButtons.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(1043, 5);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 30);
            this.btnAddEmployee.TabIndex = 44;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // tpLogs
            // 
            this.tpLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpLogs.Controls.Add(this.dgvLogs);
            this.tpLogs.Location = new System.Drawing.Point(4, 32);
            this.tpLogs.Name = "tpLogs";
            this.tpLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogs.Size = new System.Drawing.Size(1176, 400);
            this.tpLogs.TabIndex = 3;
            this.tpLogs.Text = "События";
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToResizeRows = false;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 3);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.Size = new System.Drawing.Size(1170, 394);
            this.dgvLogs.TabIndex = 4;
            // 
            // OrderFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1100, 400);
            this.Controls.Add(this.tcOrder);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderFormEdit";
            this.Load += new System.EventHandler(this.OrderFormEdit_Load);
            this.panelTop.ResumeLayout(false);
            this.tcOrder.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.gpWorkDates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).EndInit();
            this.panelWorkDatesButtons.ResumeLayout(false);
            this.tpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelServiceButtons.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panelEmployeesButtons.ResumeLayout(false);
            this.tpLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TabControl tcOrder;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.LinkLabel linkLblCustomer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateCanceledValue;
        private System.Windows.Forms.Label lblDateCanceled;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblDateOfMeasurements;
        private System.Windows.Forms.Label lblDatePlaced;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DateTimePicker dtpDatePlaced;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.CheckBox cbPaidByCash;
        private System.Windows.Forms.DateTimePicker dtpDateOfMeasurements;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbStatusValue;
        private System.Windows.Forms.GroupBox gpWorkDates;
        private System.Windows.Forms.DataGridView dgvWorkDates;
        private System.Windows.Forms.Panel panelWorkDatesButtons;
        private System.Windows.Forms.Button btnAddWorkDay;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Panel panelServiceButtons;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panelEmployeesButtons;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TabPage tpLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
    }
}