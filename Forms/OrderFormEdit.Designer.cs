
namespace stretch_ceilings_app.Forms
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
            this.tcOrder = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.tpLogs = new System.Windows.Forms.TabPage();
            this.gpWorkDates = new System.Windows.Forms.GroupBox();
            this.panelWorkDatesButtons = new System.Windows.Forms.Panel();
            this.dgvWorkDates = new System.Windows.Forms.DataGridView();
            this.btnAddWorkDay = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtpDatePlaced = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePaid = new System.Windows.Forms.DateTimePicker();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.cbPaidByCash = new System.Windows.Forms.CheckBox();
            this.dtpDateOfMeasurements = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbStatusValue = new System.Windows.Forms.ComboBox();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.lblDateOfMeasurements = new System.Windows.Forms.Label();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblDateCanceled = new System.Windows.Forms.Label();
            this.lblDateCanceledValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.linkLblCustomer = new System.Windows.Forms.LinkLabel();
            this.panelEmployeesButtons = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.panelServiceButtons = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.tcOrder.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tpServices.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            this.tpLogs.SuspendLayout();
            this.gpWorkDates.SuspendLayout();
            this.panelWorkDatesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).BeginInit();
            this.panelEmployeesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelServiceButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOrder
            // 
            this.tcOrder.Controls.Add(this.tpInfo);
            this.tcOrder.Controls.Add(this.tpServices);
            this.tcOrder.Controls.Add(this.tpEmployees);
            this.tcOrder.Controls.Add(this.tpLogs);
            this.tcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcOrder.Location = new System.Drawing.Point(0, 0);
            this.tcOrder.Name = "tcOrder";
            this.tcOrder.SelectedIndex = 0;
            this.tcOrder.Size = new System.Drawing.Size(1184, 461);
            this.tcOrder.TabIndex = 1;
            // 
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
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
            this.tpInfo.Location = new System.Drawing.Point(4, 33);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(1176, 424);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Основная информация";
            // 
            // tpServices
            // 
            this.tpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.tpServices.Controls.Add(this.dgvServices);
            this.tpServices.Controls.Add(this.panelServiceButtons);
            this.tpServices.Location = new System.Drawing.Point(4, 33);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(1176, 424);
            this.tpServices.TabIndex = 1;
            this.tpServices.Text = "Услуги";
            // 
            // tpEmployees
            // 
            this.tpEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.tpEmployees.Controls.Add(this.dgvEmployees);
            this.tpEmployees.Controls.Add(this.panelEmployeesButtons);
            this.tpEmployees.Location = new System.Drawing.Point(4, 33);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(1176, 424);
            this.tpEmployees.TabIndex = 2;
            this.tpEmployees.Text = "Мастера";
            // 
            // tpLogs
            // 
            this.tpLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.tpLogs.Controls.Add(this.dgvLogs);
            this.tpLogs.Location = new System.Drawing.Point(4, 33);
            this.tpLogs.Name = "tpLogs";
            this.tpLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogs.Size = new System.Drawing.Size(1176, 424);
            this.tpLogs.TabIndex = 3;
            this.tpLogs.Text = "События";
            // 
            // gpWorkDates
            // 
            this.gpWorkDates.Controls.Add(this.dgvWorkDates);
            this.gpWorkDates.Controls.Add(this.panelWorkDatesButtons);
            this.gpWorkDates.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpWorkDates.Location = new System.Drawing.Point(602, 3);
            this.gpWorkDates.Name = "gpWorkDates";
            this.gpWorkDates.Size = new System.Drawing.Size(571, 418);
            this.gpWorkDates.TabIndex = 0;
            this.gpWorkDates.TabStop = false;
            this.gpWorkDates.Text = "Дата(ы) выполнения";
            // 
            // panelWorkDatesButtons
            // 
            this.panelWorkDatesButtons.Controls.Add(this.btnAddWorkDay);
            this.panelWorkDatesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWorkDatesButtons.Location = new System.Drawing.Point(3, 375);
            this.panelWorkDatesButtons.Name = "panelWorkDatesButtons";
            this.panelWorkDatesButtons.Size = new System.Drawing.Size(565, 40);
            this.panelWorkDatesButtons.TabIndex = 0;
            // 
            // dgvWorkDates
            // 
            this.dgvWorkDates.BackgroundColor = System.Drawing.Color.Black;
            this.dgvWorkDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkDates.Location = new System.Drawing.Point(3, 25);
            this.dgvWorkDates.Name = "dgvWorkDates";
            this.dgvWorkDates.Size = new System.Drawing.Size(565, 350);
            this.dgvWorkDates.TabIndex = 1;
            // 
            // btnAddWorkDay
            // 
            this.btnAddWorkDay.BackColor = System.Drawing.Color.Black;
            this.btnAddWorkDay.FlatAppearance.BorderSize = 0;
            this.btnAddWorkDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddWorkDay.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkDay.Location = new System.Drawing.Point(441, 5);
            this.btnAddWorkDay.Name = "btnAddWorkDay";
            this.btnAddWorkDay.Size = new System.Drawing.Size(120, 30);
            this.btnAddWorkDay.TabIndex = 43;
            this.btnAddWorkDay.Text = "Добавить";
            this.btnAddWorkDay.UseVisualStyleBackColor = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCustomer.Location = new System.Drawing.Point(11, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(80, 24);
            this.lblCustomer.TabIndex = 48;
            this.lblCustomer.Text = "Клиент:";
            // 
            // dtpDatePlaced
            // 
            this.dtpDatePlaced.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatePlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDatePlaced.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePlaced.Location = new System.Drawing.Point(200, 41);
            this.dtpDatePlaced.Name = "dtpDatePlaced";
            this.dtpDatePlaced.Size = new System.Drawing.Size(179, 29);
            this.dtpDatePlaced.TabIndex = 50;
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePaid.Location = new System.Drawing.Point(200, 111);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(179, 29);
            this.dtpDatePaid.TabIndex = 52;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceValue.Location = new System.Drawing.Point(196, 250);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(116, 24);
            this.lblPriceValue.TabIndex = 60;
            this.lblPriceValue.Text = "8391.43 руб.";
            // 
            // cbPaidByCash
            // 
            this.cbPaidByCash.AutoSize = true;
            this.cbPaidByCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPaidByCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbPaidByCash.Location = new System.Drawing.Point(15, 219);
            this.cbPaidByCash.Name = "cbPaidByCash";
            this.cbPaidByCash.Size = new System.Drawing.Size(197, 28);
            this.cbPaidByCash.TabIndex = 59;
            this.cbPaidByCash.Text = "Оплата наличными";
            this.cbPaidByCash.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfMeasurements
            // 
            this.dtpDateOfMeasurements.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateOfMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateOfMeasurements.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfMeasurements.Location = new System.Drawing.Point(200, 76);
            this.dtpDateOfMeasurements.Name = "dtpDateOfMeasurements";
            this.dtpDateOfMeasurements.Size = new System.Drawing.Size(179, 29);
            this.dtpDateOfMeasurements.TabIndex = 54;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPrice.Location = new System.Drawing.Point(11, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
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
            this.cbStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbStatusValue.FormattingEnabled = true;
            this.cbStatusValue.Location = new System.Drawing.Point(200, 181);
            this.cbStatusValue.Name = "cbStatusValue";
            this.cbStatusValue.Size = new System.Drawing.Size(310, 32);
            this.cbStatusValue.TabIndex = 56;
            // 
            // lblDatePlaced
            // 
            this.lblDatePlaced.AutoSize = true;
            this.lblDatePlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDatePlaced.Location = new System.Drawing.Point(11, 45);
            this.lblDatePlaced.Name = "lblDatePlaced";
            this.lblDatePlaced.Size = new System.Drawing.Size(175, 24);
            this.lblDatePlaced.TabIndex = 64;
            this.lblDatePlaced.Text = "Дата размещения:";
            // 
            // lblDateOfMeasurements
            // 
            this.lblDateOfMeasurements.AutoSize = true;
            this.lblDateOfMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateOfMeasurements.Location = new System.Drawing.Point(11, 80);
            this.lblDateOfMeasurements.Name = "lblDateOfMeasurements";
            this.lblDateOfMeasurements.Size = new System.Drawing.Size(141, 24);
            this.lblDateOfMeasurements.TabIndex = 65;
            this.lblDateOfMeasurements.Text = "Дата замеров:";
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDatePaid.Location = new System.Drawing.Point(11, 115);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(129, 24);
            this.lblDatePaid.TabIndex = 66;
            this.lblDatePaid.Text = "Дата оплаты:";
            // 
            // lblDateCanceled
            // 
            this.lblDateCanceled.AutoSize = true;
            this.lblDateCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateCanceled.Location = new System.Drawing.Point(11, 150);
            this.lblDateCanceled.Name = "lblDateCanceled";
            this.lblDateCanceled.Size = new System.Drawing.Size(133, 24);
            this.lblDateCanceled.TabIndex = 67;
            this.lblDateCanceled.Text = "Дата отмены:";
            // 
            // lblDateCanceledValue
            // 
            this.lblDateCanceledValue.AutoSize = true;
            this.lblDateCanceledValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateCanceledValue.Location = new System.Drawing.Point(198, 150);
            this.lblDateCanceledValue.Name = "lblDateCanceledValue";
            this.lblDateCanceledValue.Size = new System.Drawing.Size(44, 24);
            this.lblDateCanceledValue.TabIndex = 68;
            this.lblDateCanceledValue.Text = "Нет";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.Location = new System.Drawing.Point(11, 184);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 24);
            this.lblStatus.TabIndex = 69;
            this.lblStatus.Text = "Статус:";
            // 
            // linkLblCustomer
            // 
            this.linkLblCustomer.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblCustomer.AutoSize = true;
            this.linkLblCustomer.LinkColor = System.Drawing.Color.Black;
            this.linkLblCustomer.Location = new System.Drawing.Point(198, 9);
            this.linkLblCustomer.Name = "linkLblCustomer";
            this.linkLblCustomer.Size = new System.Drawing.Size(31, 24);
            this.linkLblCustomer.TabIndex = 70;
            this.linkLblCustomer.TabStop = true;
            this.linkLblCustomer.Text = "🔍";
            this.linkLblCustomer.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // panelEmployeesButtons
            // 
            this.panelEmployeesButtons.Controls.Add(this.btnAddEmployee);
            this.panelEmployeesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeesButtons.Location = new System.Drawing.Point(3, 381);
            this.panelEmployeesButtons.Name = "panelEmployeesButtons";
            this.panelEmployeesButtons.Size = new System.Drawing.Size(1170, 40);
            this.panelEmployeesButtons.TabIndex = 0;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1170, 378);
            this.dgvEmployees.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Black;
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
            // dgvServices
            // 
            this.dgvServices.BackgroundColor = System.Drawing.Color.Black;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(3, 3);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.Size = new System.Drawing.Size(1170, 378);
            this.dgvServices.TabIndex = 4;
            // 
            // panelServiceButtons
            // 
            this.panelServiceButtons.Controls.Add(this.btnAddService);
            this.panelServiceButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelServiceButtons.Location = new System.Drawing.Point(3, 381);
            this.panelServiceButtons.Name = "panelServiceButtons";
            this.panelServiceButtons.Size = new System.Drawing.Size(1170, 40);
            this.panelServiceButtons.TabIndex = 3;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.Black;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(1043, 5);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(120, 30);
            this.btnAddService.TabIndex = 44;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = false;
            // 
            // dgvLogs
            // 
            this.dgvLogs.BackgroundColor = System.Drawing.Color.Black;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 3);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(1170, 418);
            this.dgvLogs.TabIndex = 4;
            // 
            // OrderFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.tcOrder);
            this.Name = "OrderFormEdit";
            this.Load += new System.EventHandler(this.OrderFormEdit_Load);
            this.tcOrder.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.tpServices.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.tpLogs.ResumeLayout(false);
            this.gpWorkDates.ResumeLayout(false);
            this.panelWorkDatesButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).EndInit();
            this.panelEmployeesButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelServiceButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcOrder;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpLogs;
        private System.Windows.Forms.GroupBox gpWorkDates;
        private System.Windows.Forms.DataGridView dgvWorkDates;
        private System.Windows.Forms.Panel panelWorkDatesButtons;
        private System.Windows.Forms.Button btnAddWorkDay;
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
        private System.Windows.Forms.Label lblDateCanceled;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.LinkLabel linkLblCustomer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateCanceledValue;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panelEmployeesButtons;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Panel panelServiceButtons;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridView dgvLogs;
    }
}