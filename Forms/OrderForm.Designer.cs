
namespace stretch_ceilings_app.Forms
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
            this.linkLblCustomer = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateCanceledValue = new System.Windows.Forms.Label();
            this.lblDateCanceled = new System.Windows.Forms.Label();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblDateOfMeasurements = new System.Windows.Forms.Label();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.cbPaidByCash = new System.Windows.Forms.CheckBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dgvWorkDates = new System.Windows.Forms.DataGridView();
            this.gpWorkDates = new System.Windows.Forms.GroupBox();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblDatePaidValue = new System.Windows.Forms.Label();
            this.lblDateOfMeasurementsValue = new System.Windows.Forms.Label();
            this.lblDatePlacedValue = new System.Windows.Forms.Label();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.tpLogs = new System.Windows.Forms.TabPage();
            this.tcOrder = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).BeginInit();
            this.gpWorkDates.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tpServices.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            this.tpLogs.SuspendLayout();
            this.tcOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLblCustomer
            // 
            this.linkLblCustomer.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblCustomer.AutoSize = true;
            this.linkLblCustomer.LinkColor = System.Drawing.Color.Black;
            this.linkLblCustomer.Location = new System.Drawing.Point(198, 9);
            this.linkLblCustomer.Name = "linkLblCustomer";
            this.linkLblCustomer.Size = new System.Drawing.Size(237, 24);
            this.linkLblCustomer.TabIndex = 70;
            this.linkLblCustomer.TabStop = true;
            this.linkLblCustomer.Text = "Кравчук Роман Олегович";
            this.linkLblCustomer.VisitedLinkColor = System.Drawing.Color.Black;
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
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1170, 418);
            this.dgvEmployees.TabIndex = 2;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceValue.Location = new System.Drawing.Point(196, 250);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(126, 24);
            this.lblPriceValue.TabIndex = 60;
            this.lblPriceValue.Text = "11920.00 руб.";
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
            // dgvServices
            // 
            this.dgvServices.BackgroundColor = System.Drawing.Color.Black;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(3, 3);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.Size = new System.Drawing.Size(1170, 418);
            this.dgvServices.TabIndex = 4;
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
            // dgvWorkDates
            // 
            this.dgvWorkDates.BackgroundColor = System.Drawing.Color.Black;
            this.dgvWorkDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkDates.Location = new System.Drawing.Point(3, 25);
            this.dgvWorkDates.Name = "dgvWorkDates";
            this.dgvWorkDates.Size = new System.Drawing.Size(565, 390);
            this.dgvWorkDates.TabIndex = 1;
            // 
            // gpWorkDates
            // 
            this.gpWorkDates.Controls.Add(this.dgvWorkDates);
            this.gpWorkDates.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpWorkDates.Location = new System.Drawing.Point(602, 3);
            this.gpWorkDates.Name = "gpWorkDates";
            this.gpWorkDates.Size = new System.Drawing.Size(571, 418);
            this.gpWorkDates.TabIndex = 0;
            this.gpWorkDates.TabStop = false;
            this.gpWorkDates.Text = "Дата(ы) выполнения";
            // 
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
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
            this.tpInfo.Location = new System.Drawing.Point(4, 33);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(1176, 424);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Основная информация";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.Black;
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(476, 386);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(120, 30);
            this.btnEditOrder.TabIndex = 75;
            this.btnEditOrder.Text = "Изменить";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatusValue.Location = new System.Drawing.Point(198, 184);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(100, 24);
            this.lblStatusValue.TabIndex = 74;
            this.lblStatusValue.Text = "Выполнен";
            // 
            // lblDatePaidValue
            // 
            this.lblDatePaidValue.AutoSize = true;
            this.lblDatePaidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDatePaidValue.Location = new System.Drawing.Point(198, 115);
            this.lblDatePaidValue.Name = "lblDatePaidValue";
            this.lblDatePaidValue.Size = new System.Drawing.Size(153, 24);
            this.lblDatePaidValue.TabIndex = 73;
            this.lblDatePaidValue.Text = "1/2/2022 8:33 PM";
            // 
            // lblDateOfMeasurementsValue
            // 
            this.lblDateOfMeasurementsValue.AutoSize = true;
            this.lblDateOfMeasurementsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateOfMeasurementsValue.Location = new System.Drawing.Point(198, 80);
            this.lblDateOfMeasurementsValue.Name = "lblDateOfMeasurementsValue";
            this.lblDateOfMeasurementsValue.Size = new System.Drawing.Size(153, 24);
            this.lblDateOfMeasurementsValue.TabIndex = 72;
            this.lblDateOfMeasurementsValue.Text = "1/2/2022 8:33 PM";
            // 
            // lblDatePlacedValue
            // 
            this.lblDatePlacedValue.AutoSize = true;
            this.lblDatePlacedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDatePlacedValue.Location = new System.Drawing.Point(198, 45);
            this.lblDatePlacedValue.Name = "lblDatePlacedValue";
            this.lblDatePlacedValue.Size = new System.Drawing.Size(153, 24);
            this.lblDatePlacedValue.TabIndex = 71;
            this.lblDatePlacedValue.Text = "1/2/2022 8:33 PM";
            // 
            // tpServices
            // 
            this.tpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.tpServices.Controls.Add(this.dgvServices);
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
            this.tcOrder.TabIndex = 2;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.tcOrder);
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDates)).EndInit();
            this.gpWorkDates.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.tpServices.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.tpLogs.ResumeLayout(false);
            this.tcOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLblCustomer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateCanceledValue;
        private System.Windows.Forms.Label lblDateCanceled;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblDateOfMeasurements;
        private System.Windows.Forms.Label lblDatePlaced;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.CheckBox cbPaidByCash;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridView dgvWorkDates;
        private System.Windows.Forms.GroupBox gpWorkDates;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpLogs;
        private System.Windows.Forms.TabControl tcOrder;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblDatePaidValue;
        private System.Windows.Forms.Label lblDateOfMeasurementsValue;
        private System.Windows.Forms.Label lblDatePlacedValue;
        private System.Windows.Forms.Button btnEditOrder;
    }
}