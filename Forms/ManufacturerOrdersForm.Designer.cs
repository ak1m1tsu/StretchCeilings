
namespace stretch_ceilings_app.Forms
{
    partial class ManufacturerOrdersForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPrevios = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvManufacturerOrders = new System.Windows.Forms.DataGridView();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.linkLblManufacturer = new System.Windows.Forms.LinkLabel();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.linkLblCustomer = new System.Windows.Forms.LinkLabel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.panelUserButtons = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnUseFilters = new System.Windows.Forms.Button();
            this.nudIdValue = new System.Windows.Forms.NumericUpDown();
            this.nudTotalTo = new System.Windows.Forms.NumericUpDown();
            this.nudTotalFrom = new System.Windows.Forms.NumericUpDown();
            this.panelButtons.SuspendLayout();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturerOrders)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.panelSearchButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelUserButtons);
            this.panelButtons.Controls.Add(this.panelSearchButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(1054, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(130, 561);
            this.panelButtons.TabIndex = 0;
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPrevios);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNext);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 523);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1054, 38);
            this.panelPages.TabIndex = 26;
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(993, 4);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(55, 32);
            this.cbRows.TabIndex = 98;
            // 
            // btnPrevios
            // 
            this.btnPrevios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPrevios.FlatAppearance.BorderSize = 0;
            this.btnPrevios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPrevios.ForeColor = System.Drawing.Color.White;
            this.btnPrevios.Location = new System.Drawing.Point(5, 5);
            this.btnPrevios.Name = "btnPrevios";
            this.btnPrevios.Size = new System.Drawing.Size(30, 29);
            this.btnPrevios.TabIndex = 87;
            this.btnPrevios.Text = "<";
            this.btnPrevios.UseVisualStyleBackColor = false;
            // 
            // tbPages
            // 
            this.tbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPages.Location = new System.Drawing.Point(41, 5);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 86;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(127, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 29);
            this.btnNext.TabIndex = 85;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // dgvManufacturerOrders
            // 
            this.dgvManufacturerOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvManufacturerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturerOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManufacturerOrders.Location = new System.Drawing.Point(0, 114);
            this.dgvManufacturerOrders.Name = "dgvManufacturerOrders";
            this.dgvManufacturerOrders.ReadOnly = true;
            this.dgvManufacturerOrders.RowTemplate.Height = 25;
            this.dgvManufacturerOrders.Size = new System.Drawing.Size(1054, 447);
            this.dgvManufacturerOrders.TabIndex = 24;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.nudTotalTo);
            this.panelFilters.Controls.Add(this.nudIdValue);
            this.panelFilters.Controls.Add(this.nudTotalFrom);
            this.panelFilters.Controls.Add(this.lblPriceTo);
            this.panelFilters.Controls.Add(this.lblPriceFrom);
            this.panelFilters.Controls.Add(this.lblId);
            this.panelFilters.Controls.Add(this.linkLblManufacturer);
            this.panelFilters.Controls.Add(this.lblManufacturer);
            this.panelFilters.Controls.Add(this.linkLblCustomer);
            this.panelFilters.Controls.Add(this.lblCustomer);
            this.panelFilters.Controls.Add(this.dtpDateTo);
            this.panelFilters.Controls.Add(this.lblDateTo);
            this.panelFilters.Controls.Add(this.dtpDateFrom);
            this.panelFilters.Controls.Add(this.lblDateFrom);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1054, 114);
            this.panelFilters.TabIndex = 25;
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceTo.Location = new System.Drawing.Point(496, 75);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Size = new System.Drawing.Size(38, 24);
            this.lblPriceTo.TabIndex = 45;
            this.lblPriceTo.Text = "до:";
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceFrom.Location = new System.Drawing.Point(286, 75);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Size = new System.Drawing.Size(85, 24);
            this.lblPriceFrom.TabIndex = 43;
            this.lblPriceFrom.Text = "Цена от:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblId.Location = new System.Drawing.Point(10, 78);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 24);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "Номер:";
            // 
            // linkLblManufacturer
            // 
            this.linkLblManufacturer.AutoSize = true;
            this.linkLblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.linkLblManufacturer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblManufacturer.Location = new System.Drawing.Point(450, 44);
            this.linkLblManufacturer.Name = "linkLblManufacturer";
            this.linkLblManufacturer.Size = new System.Drawing.Size(117, 24);
            this.linkLblManufacturer.TabIndex = 30;
            this.linkLblManufacturer.TabStop = true;
            this.linkLblManufacturer.Text = "Не выбрано";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblManufacturer.Location = new System.Drawing.Point(286, 44);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(158, 24);
            this.lblManufacturer.TabIndex = 29;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // linkLblCustomer
            // 
            this.linkLblCustomer.AutoSize = true;
            this.linkLblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.linkLblCustomer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCustomer.Location = new System.Drawing.Point(450, 11);
            this.linkLblCustomer.Name = "linkLblCustomer";
            this.linkLblCustomer.Size = new System.Drawing.Size(117, 24);
            this.linkLblCustomer.TabIndex = 24;
            this.linkLblCustomer.TabStop = true;
            this.linkLblCustomer.Text = "Не выбрано";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCustomer.Location = new System.Drawing.Point(286, 11);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(80, 24);
            this.lblCustomer.TabIndex = 23;
            this.lblCustomer.Text = "Клиент:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(101, 41);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(180, 29);
            this.dtpDateTo.TabIndex = 10;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateTo.Location = new System.Drawing.Point(10, 45);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(87, 24);
            this.lblDateTo.TabIndex = 9;
            this.lblDateTo.Text = "Дата до:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(101, 7);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(180, 29);
            this.dtpDateFrom.TabIndex = 8;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateFrom.Location = new System.Drawing.Point(10, 11);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(85, 24);
            this.lblDateFrom.TabIndex = 7;
            this.lblDateFrom.Text = "Дата от:";
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Controls.Add(this.btnResetFilters);
            this.panelSearchButtons.Controls.Add(this.btnUseFilters);
            this.panelSearchButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchButtons.Location = new System.Drawing.Point(0, 0);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new System.Drawing.Size(130, 114);
            this.panelSearchButtons.TabIndex = 0;
            // 
            // panelUserButtons
            // 
            this.panelUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserButtons.Location = new System.Drawing.Point(0, 114);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.Size = new System.Drawing.Size(130, 447);
            this.panelUserButtons.TabIndex = 1;
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
            this.btnResetFilters.TabIndex = 18;
            this.btnResetFilters.Text = "Сбросить";
            this.btnResetFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilters.UseVisualStyleBackColor = true;
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
            this.btnUseFilters.TabIndex = 17;
            this.btnUseFilters.Text = "Применить";
            this.btnUseFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseFilters.UseVisualStyleBackColor = true;
            // 
            // nudIdValue
            // 
            this.nudIdValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudIdValue.Location = new System.Drawing.Point(101, 76);
            this.nudIdValue.Name = "nudIdValue";
            this.nudIdValue.Size = new System.Drawing.Size(77, 29);
            this.nudIdValue.TabIndex = 94;
            // 
            // nudTotalTo
            // 
            this.nudTotalTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalTo.Location = new System.Drawing.Point(540, 73);
            this.nudTotalTo.Name = "nudTotalTo";
            this.nudTotalTo.Size = new System.Drawing.Size(112, 29);
            this.nudTotalTo.TabIndex = 97;
            this.nudTotalTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudTotalFrom
            // 
            this.nudTotalFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalFrom.Location = new System.Drawing.Point(377, 73);
            this.nudTotalFrom.Name = "nudTotalFrom";
            this.nudTotalFrom.Size = new System.Drawing.Size(113, 29);
            this.nudTotalFrom.TabIndex = 96;
            this.nudTotalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManufacturerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.dgvManufacturerOrders);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelButtons);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "ManufacturerOrdersForm";
            this.panelButtons.ResumeLayout(false);
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturerOrders)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelSearchButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudIdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.Button btnPrevios;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvManufacturerOrders;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblPriceTo;
        private System.Windows.Forms.Label lblPriceFrom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.LinkLabel linkLblManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.LinkLabel linkLblCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Panel panelUserButtons;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnUseFilters;
        private System.Windows.Forms.NumericUpDown nudIdValue;
        private System.Windows.Forms.NumericUpDown nudTotalTo;
        private System.Windows.Forms.NumericUpDown nudTotalFrom;
    }
}