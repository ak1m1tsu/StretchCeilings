
namespace stretch_ceilings_app.Forms
{
    partial class ServiceFormEdit
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
            this.panelAdditServBody = new System.Windows.Forms.Panel();
            this.dgvAdditServs = new System.Windows.Forms.DataGridView();
            this.panelGridBtns = new System.Windows.Forms.Panel();
            this.btnAddAdditServ = new System.Windows.Forms.Button();
            this.btnPerivousPage = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.panelAdditServHeader = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAdditServs = new System.Windows.Forms.Label();
            this.panelMainInfo = new System.Windows.Forms.Panel();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCeiling = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.cbManufacturerValue = new System.Windows.Forms.ComboBox();
            this.cbCeilingValue = new System.Windows.Forms.ComboBox();
            this.panelAdditServBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).BeginInit();
            this.panelGridBtns.SuspendLayout();
            this.panelAdditServHeader.SuspendLayout();
            this.panelMainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdditServBody
            // 
            this.panelAdditServBody.Controls.Add(this.dgvAdditServs);
            this.panelAdditServBody.Controls.Add(this.panelGridBtns);
            this.panelAdditServBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdditServBody.Location = new System.Drawing.Point(387, 44);
            this.panelAdditServBody.Name = "panelAdditServBody";
            this.panelAdditServBody.Size = new System.Drawing.Size(797, 367);
            this.panelAdditServBody.TabIndex = 5;
            // 
            // dgvAdditServs
            // 
            this.dgvAdditServs.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAdditServs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditServs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdditServs.Location = new System.Drawing.Point(0, 0);
            this.dgvAdditServs.Name = "dgvAdditServs";
            this.dgvAdditServs.Size = new System.Drawing.Size(797, 326);
            this.dgvAdditServs.TabIndex = 1;
            // 
            // panelGridBtns
            // 
            this.panelGridBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelGridBtns.Controls.Add(this.btnAddAdditServ);
            this.panelGridBtns.Controls.Add(this.btnPerivousPage);
            this.panelGridBtns.Controls.Add(this.tbPage);
            this.panelGridBtns.Controls.Add(this.btnNextPage);
            this.panelGridBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGridBtns.Location = new System.Drawing.Point(0, 326);
            this.panelGridBtns.Name = "panelGridBtns";
            this.panelGridBtns.Size = new System.Drawing.Size(797, 41);
            this.panelGridBtns.TabIndex = 0;
            // 
            // btnAddAdditServ
            // 
            this.btnAddAdditServ.BackColor = System.Drawing.Color.Black;
            this.btnAddAdditServ.FlatAppearance.BorderSize = 0;
            this.btnAddAdditServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdditServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddAdditServ.ForeColor = System.Drawing.Color.White;
            this.btnAddAdditServ.Location = new System.Drawing.Point(674, 5);
            this.btnAddAdditServ.Name = "btnAddAdditServ";
            this.btnAddAdditServ.Size = new System.Drawing.Size(120, 30);
            this.btnAddAdditServ.TabIndex = 49;
            this.btnAddAdditServ.Text = "Добавить";
            this.btnAddAdditServ.UseVisualStyleBackColor = false;
            this.btnAddAdditServ.Click += new System.EventHandler(this.btnAddAdditionalService_Click);
            // 
            // btnPerivousPage
            // 
            this.btnPerivousPage.BackColor = System.Drawing.Color.Black;
            this.btnPerivousPage.FlatAppearance.BorderSize = 0;
            this.btnPerivousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerivousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPerivousPage.ForeColor = System.Drawing.Color.White;
            this.btnPerivousPage.Location = new System.Drawing.Point(10, 6);
            this.btnPerivousPage.Name = "btnPerivousPage";
            this.btnPerivousPage.Size = new System.Drawing.Size(30, 29);
            this.btnPerivousPage.TabIndex = 75;
            this.btnPerivousPage.Text = "<";
            this.btnPerivousPage.UseVisualStyleBackColor = false;
            this.btnPerivousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbPage
            // 
            this.tbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPage.Location = new System.Drawing.Point(46, 6);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(80, 29);
            this.tbPage.TabIndex = 74;
            this.tbPage.Text = "1/1";
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Black;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(132, 6);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(30, 29);
            this.btnNextPage.TabIndex = 73;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // panelAdditServHeader
            // 
            this.panelAdditServHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelAdditServHeader.Controls.Add(this.btnSave);
            this.panelAdditServHeader.Controls.Add(this.lblAdditServs);
            this.panelAdditServHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdditServHeader.Location = new System.Drawing.Point(387, 0);
            this.panelAdditServHeader.Name = "panelAdditServHeader";
            this.panelAdditServHeader.Size = new System.Drawing.Size(797, 44);
            this.panelAdditServHeader.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(673, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAdditServs
            // 
            this.lblAdditServs.AutoSize = true;
            this.lblAdditServs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdditServs.Location = new System.Drawing.Point(6, 9);
            this.lblAdditServs.Name = "lblAdditServs";
            this.lblAdditServs.Size = new System.Drawing.Size(234, 24);
            this.lblAdditServs.TabIndex = 0;
            this.lblAdditServs.Text = "Дополнительные услуги:";
            // 
            // panelMainInfo
            // 
            this.panelMainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelMainInfo.Controls.Add(this.cbCeilingValue);
            this.panelMainInfo.Controls.Add(this.cbManufacturerValue);
            this.panelMainInfo.Controls.Add(this.lblPriceValue);
            this.panelMainInfo.Controls.Add(this.lblPrice);
            this.panelMainInfo.Controls.Add(this.lblCeiling);
            this.panelMainInfo.Controls.Add(this.lblManufacturer);
            this.panelMainInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainInfo.Location = new System.Drawing.Point(0, 0);
            this.panelMainInfo.Name = "panelMainInfo";
            this.panelMainInfo.Size = new System.Drawing.Size(387, 411);
            this.panelMainInfo.TabIndex = 3;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceValue.Location = new System.Drawing.Point(172, 88);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(126, 24);
            this.lblPriceValue.TabIndex = 6;
            this.lblPriceValue.Text = "10000.00 руб.";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(12, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена:";
            // 
            // lblCeiling
            // 
            this.lblCeiling.AutoSize = true;
            this.lblCeiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCeiling.Location = new System.Drawing.Point(12, 47);
            this.lblCeiling.Name = "lblCeiling";
            this.lblCeiling.Size = new System.Drawing.Size(90, 24);
            this.lblCeiling.TabIndex = 3;
            this.lblCeiling.Text = "Потолок:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturer.Location = new System.Drawing.Point(12, 9);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(158, 24);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // cbManufacturerValue
            // 
            this.cbManufacturerValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufacturerValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbManufacturerValue.FormattingEnabled = true;
            this.cbManufacturerValue.Items.AddRange(new object[] {
            "Pongs"});
            this.cbManufacturerValue.Location = new System.Drawing.Point(176, 6);
            this.cbManufacturerValue.Name = "cbManufacturerValue";
            this.cbManufacturerValue.Size = new System.Drawing.Size(205, 32);
            this.cbManufacturerValue.TabIndex = 7;
            // 
            // cbCeilingValue
            // 
            this.cbCeilingValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCeilingValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCeilingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCeilingValue.FormattingEnabled = true;
            this.cbCeilingValue.Location = new System.Drawing.Point(176, 44);
            this.cbCeilingValue.Name = "cbCeilingValue";
            this.cbCeilingValue.Size = new System.Drawing.Size(205, 32);
            this.cbCeilingValue.TabIndex = 8;
            // 
            // ServiceFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 411);
            this.Controls.Add(this.panelAdditServBody);
            this.Controls.Add(this.panelAdditServHeader);
            this.Controls.Add(this.panelMainInfo);
            this.Name = "ServiceFormEdit";
            this.panelAdditServBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).EndInit();
            this.panelGridBtns.ResumeLayout(false);
            this.panelGridBtns.PerformLayout();
            this.panelAdditServHeader.ResumeLayout(false);
            this.panelAdditServHeader.PerformLayout();
            this.panelMainInfo.ResumeLayout(false);
            this.panelMainInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdditServBody;
        private System.Windows.Forms.DataGridView dgvAdditServs;
        private System.Windows.Forms.Panel panelGridBtns;
        private System.Windows.Forms.Button btnAddAdditServ;
        private System.Windows.Forms.Button btnPerivousPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Panel panelAdditServHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAdditServs;
        private System.Windows.Forms.Panel panelMainInfo;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCeiling;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cbManufacturerValue;
        private System.Windows.Forms.ComboBox cbCeilingValue;
    }
}