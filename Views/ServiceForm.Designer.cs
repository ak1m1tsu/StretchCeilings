
namespace StretchCeilings.Views
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
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.panelAdditServHeader = new System.Windows.Forms.Panel();
            this.lblAdditServs = new System.Windows.Forms.Label();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.linkLblCeilingValue = new System.Windows.Forms.LinkLabel();
            this.lblCeiling = new System.Windows.Forms.Label();
            this.linkLblManufaturerValue = new System.Windows.Forms.LinkLabel();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.dgvAdditServs = new System.Windows.Forms.DataGridView();
            this.panelRightSide.SuspendLayout();
            this.panelAdditServHeader.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.panelTopSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRightSide
            // 
            this.panelRightSide.Controls.Add(this.dgvAdditServs);
            this.panelRightSide.Controls.Add(this.panelAdditServHeader);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSide.Location = new System.Drawing.Point(320, 25);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.Size = new System.Drawing.Size(680, 475);
            this.panelRightSide.TabIndex = 79;
            // 
            // panelAdditServHeader
            // 
            this.panelAdditServHeader.Controls.Add(this.lblAdditServs);
            this.panelAdditServHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdditServHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAdditServHeader.Name = "panelAdditServHeader";
            this.panelAdditServHeader.Size = new System.Drawing.Size(680, 40);
            this.panelAdditServHeader.TabIndex = 7;
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
            // panelLeftSide
            // 
            this.panelLeftSide.Controls.Add(this.btnEdit);
            this.panelLeftSide.Controls.Add(this.lblPriceValue);
            this.panelLeftSide.Controls.Add(this.lblPrice);
            this.panelLeftSide.Controls.Add(this.linkLblCeilingValue);
            this.panelLeftSide.Controls.Add(this.lblCeiling);
            this.panelLeftSide.Controls.Add(this.linkLblManufaturerValue);
            this.panelLeftSide.Controls.Add(this.lblManufacturer);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 25);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(320, 475);
            this.panelLeftSide.TabIndex = 78;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(206, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(146, 72);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(19, 23);
            this.lblPriceValue.TabIndex = 6;
            this.lblPriceValue.Text = "0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(3, 72);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена:";
            // 
            // linkLblCeilingValue
            // 
            this.linkLblCeilingValue.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblCeilingValue.AutoSize = true;
            this.linkLblCeilingValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.linkLblCeilingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCeilingValue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblCeilingValue.Location = new System.Drawing.Point(146, 38);
            this.linkLblCeilingValue.Name = "linkLblCeilingValue";
            this.linkLblCeilingValue.Size = new System.Drawing.Size(39, 23);
            this.linkLblCeilingValue.TabIndex = 4;
            this.linkLblCeilingValue.TabStop = true;
            this.linkLblCeilingValue.Text = "Нет";
            this.linkLblCeilingValue.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lblCeiling
            // 
            this.lblCeiling.AutoSize = true;
            this.lblCeiling.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCeiling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCeiling.Location = new System.Drawing.Point(3, 38);
            this.lblCeiling.Name = "lblCeiling";
            this.lblCeiling.Size = new System.Drawing.Size(81, 23);
            this.lblCeiling.TabIndex = 3;
            this.lblCeiling.Text = "Потолок:";
            // 
            // linkLblManufaturerValue
            // 
            this.linkLblManufaturerValue.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblManufaturerValue.AutoSize = true;
            this.linkLblManufaturerValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.linkLblManufaturerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblManufaturerValue.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.linkLblManufaturerValue.Location = new System.Drawing.Point(146, 3);
            this.linkLblManufaturerValue.Name = "linkLblManufaturerValue";
            this.linkLblManufaturerValue.Size = new System.Drawing.Size(39, 23);
            this.linkLblManufaturerValue.TabIndex = 2;
            this.linkLblManufaturerValue.TabStop = true;
            this.linkLblManufaturerValue.Text = "Нет";
            this.linkLblManufaturerValue.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblManufacturer.Location = new System.Drawing.Point(3, 3);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(137, 23);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // panelTopSide
            // 
            this.panelTopSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTopSide.Controls.Add(this.btnClose);
            this.panelTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(1000, 25);
            this.panelTopSide.TabIndex = 77;
            this.panelTopSide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
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
            // 
            // dgvAdditServs
            // 
            this.dgvAdditServs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvAdditServs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditServs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdditServs.Location = new System.Drawing.Point(0, 40);
            this.dgvAdditServs.Name = "dgvAdditServs";
            this.dgvAdditServs.Size = new System.Drawing.Size(680, 435);
            this.dgvAdditServs.TabIndex = 8;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelRightSide);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelTopSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceForm";
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelRightSide.ResumeLayout(false);
            this.panelAdditServHeader.ResumeLayout(false);
            this.panelAdditServHeader.PerformLayout();
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.panelTopSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditServs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRightSide;
        private System.Windows.Forms.Panel panelAdditServHeader;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAdditServs;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.LinkLabel linkLblCeilingValue;
        private System.Windows.Forms.Label lblCeiling;
        private System.Windows.Forms.LinkLabel linkLblManufaturerValue;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Panel panelTopSide;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.DataGridView dgvAdditServs;
    }
}