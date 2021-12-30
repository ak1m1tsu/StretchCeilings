
namespace stretch_ceilings_app
{
    partial class ServiceForm
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
            this.panelMainInfo = new System.Windows.Forms.Panel();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.linkLblCeilingValue = new System.Windows.Forms.LinkLabel();
            this.lblCeiling = new System.Windows.Forms.Label();
            this.linkLblManufaturerValue = new System.Windows.Forms.LinkLabel();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.panelAdditServHeader = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAdditServs = new System.Windows.Forms.Label();
            this.panelAdditServBody = new System.Windows.Forms.Panel();
            this.dgvAdditServs = new System.Windows.Forms.DataGridView();
            this.panelGridBtns = new System.Windows.Forms.Panel();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.panelMainInfo.SuspendLayout();
            this.panelAdditServHeader.SuspendLayout();
            this.panelAdditServBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).BeginInit();
            this.panelGridBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainInfo
            // 
            this.panelMainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelMainInfo.Controls.Add(this.lblPriceValue);
            this.panelMainInfo.Controls.Add(this.lblPrice);
            this.panelMainInfo.Controls.Add(this.linkLblCeilingValue);
            this.panelMainInfo.Controls.Add(this.lblCeiling);
            this.panelMainInfo.Controls.Add(this.linkLblManufaturerValue);
            this.panelMainInfo.Controls.Add(this.lblManufacturer);
            this.panelMainInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainInfo.Location = new System.Drawing.Point(0, 0);
            this.panelMainInfo.Name = "panelMainInfo";
            this.panelMainInfo.Size = new System.Drawing.Size(387, 411);
            this.panelMainInfo.TabIndex = 0;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceValue.Location = new System.Drawing.Point(176, 78);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(106, 24);
            this.lblPriceValue.TabIndex = 6;
            this.lblPriceValue.Text = "450.00 руб.";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(12, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена:";
            // 
            // linkLblCeilingValue
            // 
            this.linkLblCeilingValue.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblCeilingValue.AutoSize = true;
            this.linkLblCeilingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblCeilingValue.LinkColor = System.Drawing.Color.Black;
            this.linkLblCeilingValue.Location = new System.Drawing.Point(176, 44);
            this.linkLblCeilingValue.Name = "linkLblCeilingValue";
            this.linkLblCeilingValue.Size = new System.Drawing.Size(153, 24);
            this.linkLblCeilingValue.TabIndex = 4;
            this.linkLblCeilingValue.TabStop = true;
            this.linkLblCeilingValue.Text = "Матовый белый";
            this.linkLblCeilingValue.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lblCeiling
            // 
            this.lblCeiling.AutoSize = true;
            this.lblCeiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCeiling.Location = new System.Drawing.Point(12, 44);
            this.lblCeiling.Name = "lblCeiling";
            this.lblCeiling.Size = new System.Drawing.Size(90, 24);
            this.lblCeiling.TabIndex = 3;
            this.lblCeiling.Text = "Потолок:";
            // 
            // linkLblManufaturerValue
            // 
            this.linkLblManufaturerValue.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblManufaturerValue.AutoSize = true;
            this.linkLblManufaturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblManufaturerValue.LinkColor = System.Drawing.Color.Black;
            this.linkLblManufaturerValue.Location = new System.Drawing.Point(176, 9);
            this.linkLblManufaturerValue.Name = "linkLblManufaturerValue";
            this.linkLblManufaturerValue.Size = new System.Drawing.Size(64, 24);
            this.linkLblManufaturerValue.TabIndex = 2;
            this.linkLblManufaturerValue.TabStop = true;
            this.linkLblManufaturerValue.Text = "Pongs";
            this.linkLblManufaturerValue.VisitedLinkColor = System.Drawing.Color.Black;
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
            // panelAdditServHeader
            // 
            this.panelAdditServHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelAdditServHeader.Controls.Add(this.btnEdit);
            this.panelAdditServHeader.Controls.Add(this.lblAdditServs);
            this.panelAdditServHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdditServHeader.Location = new System.Drawing.Point(387, 0);
            this.panelAdditServHeader.Name = "panelAdditServHeader";
            this.panelAdditServHeader.Size = new System.Drawing.Size(797, 44);
            this.panelAdditServHeader.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(681, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // panelAdditServBody
            // 
            this.panelAdditServBody.Controls.Add(this.dgvAdditServs);
            this.panelAdditServBody.Controls.Add(this.panelGridBtns);
            this.panelAdditServBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdditServBody.Location = new System.Drawing.Point(387, 44);
            this.panelAdditServBody.Name = "panelAdditServBody";
            this.panelAdditServBody.Size = new System.Drawing.Size(797, 367);
            this.panelAdditServBody.TabIndex = 2;
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
            this.panelGridBtns.Controls.Add(this.btnPreviousPage);
            this.panelGridBtns.Controls.Add(this.tbPage);
            this.panelGridBtns.Controls.Add(this.btnNextPage);
            this.panelGridBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGridBtns.Location = new System.Drawing.Point(0, 326);
            this.panelGridBtns.Name = "panelGridBtns";
            this.panelGridBtns.Size = new System.Drawing.Size(797, 41);
            this.panelGridBtns.TabIndex = 0;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.Black;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(10, 6);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(30, 29);
            this.btnPreviousPage.TabIndex = 75;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
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
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 411);
            this.Controls.Add(this.panelAdditServBody);
            this.Controls.Add(this.panelAdditServHeader);
            this.Controls.Add(this.panelMainInfo);
            this.Name = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.panelMainInfo.ResumeLayout(false);
            this.panelMainInfo.PerformLayout();
            this.panelAdditServHeader.ResumeLayout(false);
            this.panelAdditServHeader.PerformLayout();
            this.panelAdditServBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).EndInit();
            this.panelGridBtns.ResumeLayout(false);
            this.panelGridBtns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainInfo;
        private System.Windows.Forms.Panel panelAdditServHeader;
        private System.Windows.Forms.Label lblAdditServs;
        private System.Windows.Forms.Panel panelAdditServBody;
        private System.Windows.Forms.DataGridView dgvAdditServs;
        private System.Windows.Forms.Panel panelGridBtns;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.LinkLabel linkLblCeilingValue;
        private System.Windows.Forms.Label lblCeiling;
        private System.Windows.Forms.LinkLabel linkLblManufaturerValue;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnEdit;
    }
}