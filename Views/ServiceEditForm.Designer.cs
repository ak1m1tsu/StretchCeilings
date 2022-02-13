
namespace StretchCeilings.Views
{
    partial class ServiceEditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceEditForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelMainInfo = new System.Windows.Forms.Panel();
            this.linkRoom = new System.Windows.Forms.LinkLabel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.linkManufacturer = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbCeiling = new System.Windows.Forms.ComboBox();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCeiling = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.panelAdditServBody = new System.Windows.Forms.Panel();
            this.dgvAdditServs = new System.Windows.Forms.DataGridView();
            this.panelGridBtns = new System.Windows.Forms.Panel();
            this.btnAddAdditServ = new System.Windows.Forms.Button();
            this.panelAdditServHeader = new System.Windows.Forms.Panel();
            this.lblAdditServs = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            this.panelMainInfo.SuspendLayout();
            this.panelAdditServBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).BeginInit();
            this.panelGridBtns.SuspendLayout();
            this.panelAdditServHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 25);
            this.panelTop.TabIndex = 74;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
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
            this.btnClose.Location = new System.Drawing.Point(975, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseForm);
            // 
            // panelMainInfo
            // 
            this.panelMainInfo.Controls.Add(this.linkRoom);
            this.panelMainInfo.Controls.Add(this.lblRoom);
            this.panelMainInfo.Controls.Add(this.linkManufacturer);
            this.panelMainInfo.Controls.Add(this.btnSave);
            this.panelMainInfo.Controls.Add(this.cbCeiling);
            this.panelMainInfo.Controls.Add(this.lblPriceValue);
            this.panelMainInfo.Controls.Add(this.lblPrice);
            this.panelMainInfo.Controls.Add(this.lblCeiling);
            this.panelMainInfo.Controls.Add(this.lblManufacturer);
            this.panelMainInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainInfo.Location = new System.Drawing.Point(0, 25);
            this.panelMainInfo.Name = "panelMainInfo";
            this.panelMainInfo.Size = new System.Drawing.Size(362, 475);
            this.panelMainInfo.TabIndex = 75;
            // 
            // linkRoom
            // 
            this.linkRoom.AutoSize = true;
            this.linkRoom.Font = new System.Drawing.Font("Open Sans", 12F);
            this.linkRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkRoom.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkRoom.Location = new System.Drawing.Point(141, 35);
            this.linkRoom.Name = "linkRoom";
            this.linkRoom.Size = new System.Drawing.Size(39, 23);
            this.linkRoom.TabIndex = 101;
            this.linkRoom.TabStop = true;
            this.linkRoom.Text = "Нет";
            this.linkRoom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectRoom);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblRoom.Location = new System.Drawing.Point(5, 35);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(82, 23);
            this.lblRoom.TabIndex = 100;
            this.lblRoom.Text = "Комната:";
            // 
            // linkManufacturer
            // 
            this.linkManufacturer.AutoSize = true;
            this.linkManufacturer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.linkManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkManufacturer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkManufacturer.Location = new System.Drawing.Point(142, 5);
            this.linkManufacturer.Name = "linkManufacturer";
            this.linkManufacturer.Size = new System.Drawing.Size(39, 23);
            this.linkManufacturer.TabIndex = 99;
            this.linkManufacturer.TabStop = true;
            this.linkManufacturer.Text = "Нет";
            this.linkManufacturer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectManufacturer);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSave.Location = new System.Drawing.Point(236, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.UpdateInfo);
            // 
            // cbCeiling
            // 
            this.cbCeiling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbCeiling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCeiling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCeiling.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbCeiling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbCeiling.FormattingEnabled = true;
            this.cbCeiling.Location = new System.Drawing.Point(143, 63);
            this.cbCeiling.Name = "cbCeiling";
            this.cbCeiling.Size = new System.Drawing.Size(171, 31);
            this.cbCeiling.TabIndex = 8;
            this.cbCeiling.SelectedIndexChanged += new System.EventHandler(this.SelectCeiling);
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(139, 101);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(41, 23);
            this.lblPriceValue.TabIndex = 6;
            this.lblPriceValue.Text = "0.00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(3, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена:";
            // 
            // lblCeiling
            // 
            this.lblCeiling.AutoSize = true;
            this.lblCeiling.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCeiling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCeiling.Location = new System.Drawing.Point(3, 65);
            this.lblCeiling.Name = "lblCeiling";
            this.lblCeiling.Size = new System.Drawing.Size(81, 23);
            this.lblCeiling.TabIndex = 3;
            this.lblCeiling.Text = "Потолок:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblManufacturer.Location = new System.Drawing.Point(3, 5);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(137, 23);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // panelAdditServBody
            // 
            this.panelAdditServBody.Controls.Add(this.dgvAdditServs);
            this.panelAdditServBody.Controls.Add(this.panelGridBtns);
            this.panelAdditServBody.Controls.Add(this.panelAdditServHeader);
            this.panelAdditServBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdditServBody.Location = new System.Drawing.Point(362, 25);
            this.panelAdditServBody.Name = "panelAdditServBody";
            this.panelAdditServBody.Size = new System.Drawing.Size(638, 475);
            this.panelAdditServBody.TabIndex = 76;
            // 
            // dgvAdditServs
            // 
            this.dgvAdditServs.AllowUserToAddRows = false;
            this.dgvAdditServs.AllowUserToDeleteRows = false;
            this.dgvAdditServs.AllowUserToResizeColumns = false;
            this.dgvAdditServs.AllowUserToResizeRows = false;
            this.dgvAdditServs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvAdditServs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditServs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdditServs.Location = new System.Drawing.Point(0, 40);
            this.dgvAdditServs.Name = "dgvAdditServs";
            this.dgvAdditServs.ReadOnly = true;
            this.dgvAdditServs.RowHeadersVisible = false;
            this.dgvAdditServs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdditServs.Size = new System.Drawing.Size(638, 395);
            this.dgvAdditServs.TabIndex = 5;
            this.dgvAdditServs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveGridData);
            this.dgvAdditServs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetCount);
            // 
            // panelGridBtns
            // 
            this.panelGridBtns.Controls.Add(this.btnAddAdditServ);
            this.panelGridBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGridBtns.Location = new System.Drawing.Point(0, 435);
            this.panelGridBtns.Name = "panelGridBtns";
            this.panelGridBtns.Size = new System.Drawing.Size(638, 40);
            this.panelGridBtns.TabIndex = 0;
            // 
            // btnAddAdditServ
            // 
            this.btnAddAdditServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdditServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddAdditServ.FlatAppearance.BorderSize = 0;
            this.btnAddAdditServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdditServ.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAddAdditServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnAddAdditServ.Location = new System.Drawing.Point(511, 5);
            this.btnAddAdditServ.Name = "btnAddAdditServ";
            this.btnAddAdditServ.Size = new System.Drawing.Size(120, 30);
            this.btnAddAdditServ.TabIndex = 49;
            this.btnAddAdditServ.Text = "Добавить";
            this.btnAddAdditServ.UseVisualStyleBackColor = false;
            this.btnAddAdditServ.Click += new System.EventHandler(this.AddGridData);
            // 
            // panelAdditServHeader
            // 
            this.panelAdditServHeader.Controls.Add(this.lblAdditServs);
            this.panelAdditServHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdditServHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAdditServHeader.Name = "panelAdditServHeader";
            this.panelAdditServHeader.Size = new System.Drawing.Size(638, 40);
            this.panelAdditServHeader.TabIndex = 4;
            // 
            // lblAdditServs
            // 
            this.lblAdditServs.AutoSize = true;
            this.lblAdditServs.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblAdditServs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblAdditServs.Location = new System.Drawing.Point(6, 9);
            this.lblAdditServs.Name = "lblAdditServs";
            this.lblAdditServs.Size = new System.Drawing.Size(204, 23);
            this.lblAdditServs.TabIndex = 0;
            this.lblAdditServs.Text = "Дополнительные услуги:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // ServiceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelAdditServBody);
            this.Controls.Add(this.panelMainInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelTop.ResumeLayout(false);
            this.panelMainInfo.ResumeLayout(false);
            this.panelMainInfo.PerformLayout();
            this.panelAdditServBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).EndInit();
            this.panelGridBtns.ResumeLayout(false);
            this.panelAdditServHeader.ResumeLayout(false);
            this.panelAdditServHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelMainInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbCeiling;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCeiling;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Panel panelAdditServBody;
        private System.Windows.Forms.DataGridView dgvAdditServs;
        private System.Windows.Forms.Panel panelGridBtns;
        private System.Windows.Forms.Button btnAddAdditServ;
        private System.Windows.Forms.Panel panelAdditServHeader;
        private System.Windows.Forms.Label lblAdditServs;
        private System.Windows.Forms.LinkLabel linkManufacturer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.LinkLabel linkRoom;
        private System.Windows.Forms.Label lblRoom;
    }
}