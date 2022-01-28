
namespace StretchCeilingsApp.Forms
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tcOrder = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblDatePaidValue = new System.Windows.Forms.Label();
            this.lblDateOfMeasurementsValue = new System.Windows.Forms.Label();
            this.lblDatePlacedValue = new System.Windows.Forms.Label();
            this.linkLblCustomer = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateCanceledValue = new System.Windows.Forms.Label();
            this.lblDateCanceled = new System.Windows.Forms.Label();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblDateOfMeasurements = new System.Windows.Forms.Label();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.cbPaidByCash = new System.Windows.Forms.CheckBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gpWorkDates = new System.Windows.Forms.GroupBox();
            this.dgvWorkDates = new System.Windows.Forms.DataGridView();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.tpLogs = new System.Windows.Forms.TabPage();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tcOrder.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.gpWorkDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).BeginInit();
            this.tpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
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
            this.panelTop.TabIndex = 77;
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
            this.tcOrder.TabIndex = 78;
            // 
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpInfo.Controls.Add(this.btnEditOrder);
            this.tpInfo.Controls.Add(this.lblStatusValue);
            this.tpInfo.Controls.Add(this.lblDatePaidValue);
            this.tpInfo.Controls.Add(this.lblDateOfMeasurementsValue);
            this.tpInfo.Controls.Add(this.lblDatePlacedValue);
            this.tpInfo.Controls.Add(this.linkLblCustomer);
            this.tpInfo.Controls.Add(this.lblStatus);
            this.tpInfo.Controls.Add(this.lblDateCanceledValue);
            this.tpInfo.Controls.Add(this.lblDateCanceled);
            this.tpInfo.Controls.Add(this.lblDatePaid);
            this.tpInfo.Controls.Add(this.lblDateOfMeasurements);
            this.tpInfo.Controls.Add(this.lblDatePlaced);
            this.tpInfo.Controls.Add(this.lblCustomer);
            this.tpInfo.Controls.Add(this.lblPriceValue);
            this.tpInfo.Controls.Add(this.cbPaidByCash);
            this.tpInfo.Controls.Add(this.lblPrice);
            this.tpInfo.Controls.Add(this.gpWorkDates);
            this.tpInfo.Location = new System.Drawing.Point(4, 32);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(1092, 339);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Основная информация";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(392, 301);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(120, 30);
            this.btnEditOrder.TabIndex = 75;
            this.btnEditOrder.Text = "Изменить";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Visible = false;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblStatusValue.Location = new System.Drawing.Point(193, 156);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(39, 23);
            this.lblStatusValue.TabIndex = 74;
            this.lblStatusValue.Text = "Нет";
            // 
            // lblDatePaidValue
            // 
            this.lblDatePaidValue.AutoSize = true;
            this.lblDatePaidValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDatePaidValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDatePaidValue.Location = new System.Drawing.Point(193, 96);
            this.lblDatePaidValue.Name = "lblDatePaidValue";
            this.lblDatePaidValue.Size = new System.Drawing.Size(39, 23);
            this.lblDatePaidValue.TabIndex = 73;
            this.lblDatePaidValue.Text = "Нет";
            // 
            // lblDateOfMeasurementsValue
            // 
            this.lblDateOfMeasurementsValue.AutoSize = true;
            this.lblDateOfMeasurementsValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDateOfMeasurementsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDateOfMeasurementsValue.Location = new System.Drawing.Point(193, 66);
            this.lblDateOfMeasurementsValue.Name = "lblDateOfMeasurementsValue";
            this.lblDateOfMeasurementsValue.Size = new System.Drawing.Size(39, 23);
            this.lblDateOfMeasurementsValue.TabIndex = 72;
            this.lblDateOfMeasurementsValue.Text = "Нет";
            // 
            // lblDatePlacedValue
            // 
            this.lblDatePlacedValue.AutoSize = true;
            this.lblDatePlacedValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDatePlacedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblDatePlacedValue.Location = new System.Drawing.Point(193, 36);
            this.lblDatePlacedValue.Name = "lblDatePlacedValue";
            this.lblDatePlacedValue.Size = new System.Drawing.Size(39, 23);
            this.lblDatePlacedValue.TabIndex = 71;
            this.lblDatePlacedValue.Text = "Нет";
            // 
            // linkLblCustomer
            // 
            this.linkLblCustomer.AutoSize = true;
            this.linkLblCustomer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.linkLblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCustomer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCustomer.Location = new System.Drawing.Point(193, 6);
            this.linkLblCustomer.Name = "linkLblCustomer";
            this.linkLblCustomer.Size = new System.Drawing.Size(39, 23);
            this.linkLblCustomer.TabIndex = 70;
            this.linkLblCustomer.TabStop = true;
            this.linkLblCustomer.Text = "Нет";
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
            this.lblDateCanceledValue.Location = new System.Drawing.Point(193, 126);
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
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(193, 216);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(39, 23);
            this.lblPriceValue.TabIndex = 60;
            this.lblPriceValue.Text = "Нет";
            // 
            // cbPaidByCash
            // 
            this.cbPaidByCash.AutoSize = true;
            this.cbPaidByCash.Enabled = false;
            this.cbPaidByCash.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbPaidByCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbPaidByCash.Location = new System.Drawing.Point(10, 186);
            this.cbPaidByCash.Name = "cbPaidByCash";
            this.cbPaidByCash.Size = new System.Drawing.Size(182, 27);
            this.cbPaidByCash.TabIndex = 59;
            this.cbPaidByCash.Text = "Оплата наличными";
            this.cbPaidByCash.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(6, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 23);
            this.lblPrice.TabIndex = 58;
            this.lblPrice.Text = "Цена:";
            // 
            // gpWorkDates
            // 
            this.gpWorkDates.Controls.Add(this.dgvWorkDates);
            this.gpWorkDates.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpWorkDates.Font = new System.Drawing.Font("Open Sans", 12F);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkDates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWorkDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkDates.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWorkDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkDates.Location = new System.Drawing.Point(3, 25);
            this.dgvWorkDates.Name = "dgvWorkDates";
            this.dgvWorkDates.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkDates.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvWorkDates.RowHeadersVisible = false;
            this.dgvWorkDates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkDates.Size = new System.Drawing.Size(565, 305);
            this.dgvWorkDates.TabIndex = 1;
            // 
            // tpServices
            // 
            this.tpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpServices.Controls.Add(this.dgvServices);
            this.tpServices.Location = new System.Drawing.Point(4, 32);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(1092, 339);
            this.tpServices.TabIndex = 1;
            this.tpServices.Text = "Услуги";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(3, 3);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(1086, 333);
            this.dgvServices.TabIndex = 4;
            // 
            // tpEmployees
            // 
            this.tpEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpEmployees.Controls.Add(this.dgvEmployees);
            this.tpEmployees.Location = new System.Drawing.Point(4, 32);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(1092, 339);
            this.tpEmployees.TabIndex = 2;
            this.tpEmployees.Text = "Мастера";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1086, 333);
            this.dgvEmployees.TabIndex = 2;
            // 
            // tpLogs
            // 
            this.tpLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tpLogs.Controls.Add(this.dgvLogs);
            this.tpLogs.Location = new System.Drawing.Point(4, 32);
            this.tpLogs.Name = "tpLogs";
            this.tpLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogs.Size = new System.Drawing.Size(1092, 339);
            this.tpLogs.TabIndex = 3;
            this.tpLogs.Text = "События";
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToResizeColumns = false;
            this.dgvLogs.AllowUserToResizeRows = false;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 3);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(1086, 333);
            this.dgvLogs.TabIndex = 4;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1100, 400);
            this.Controls.Add(this.tcOrder);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panelTop.ResumeLayout(false);
            this.tcOrder.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.gpWorkDates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).EndInit();
            this.tpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.tpEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tpLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TabControl tcOrder;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblDatePaidValue;
        private System.Windows.Forms.Label lblDateOfMeasurementsValue;
        private System.Windows.Forms.Label lblDatePlacedValue;
        private System.Windows.Forms.LinkLabel linkLblCustomer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateCanceledValue;
        private System.Windows.Forms.Label lblDateCanceled;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblDateOfMeasurements;
        private System.Windows.Forms.Label lblDatePlaced;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.CheckBox cbPaidByCash;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gpWorkDates;
        private System.Windows.Forms.DataGridView dgvWorkDates;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TabPage tpLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
    }
}