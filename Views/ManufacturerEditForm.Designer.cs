
namespace StretchCeilings.Views
{
    partial class ManufacturerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturerEditForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.gbCeilings = new System.Windows.Forms.GroupBox();
            this.dgvCeilings = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCuntry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panelPages = new System.Windows.Forms.Panel();
            this.btnAddCeiling = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.gbCeilings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeilings)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelPages.SuspendLayout();
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
            this.panelTop.TabIndex = 75;
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
            // panelBody
            // 
            this.panelBody.Controls.Add(this.gbCeilings);
            this.panelBody.Controls.Add(this.panelInfo);
            this.panelBody.Controls.Add(this.panelPages);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1000, 575);
            this.panelBody.TabIndex = 76;
            // 
            // gbCeilings
            // 
            this.gbCeilings.Controls.Add(this.dgvCeilings);
            this.gbCeilings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCeilings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCeilings.Font = new System.Drawing.Font("Open Sans", 12F);
            this.gbCeilings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.gbCeilings.Location = new System.Drawing.Point(0, 100);
            this.gbCeilings.Name = "gbCeilings";
            this.gbCeilings.Size = new System.Drawing.Size(1000, 435);
            this.gbCeilings.TabIndex = 68;
            this.gbCeilings.TabStop = false;
            this.gbCeilings.Text = "Потолки";
            // 
            // dgvCeilings
            // 
            this.dgvCeilings.AllowUserToAddRows = false;
            this.dgvCeilings.AllowUserToDeleteRows = false;
            this.dgvCeilings.AllowUserToResizeColumns = false;
            this.dgvCeilings.AllowUserToResizeRows = false;
            this.dgvCeilings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvCeilings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCeilings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCeilings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCeilings.Location = new System.Drawing.Point(3, 25);
            this.dgvCeilings.Name = "dgvCeilings";
            this.dgvCeilings.ReadOnly = true;
            this.dgvCeilings.RowHeadersVisible = false;
            this.dgvCeilings.RowTemplate.Height = 25;
            this.dgvCeilings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCeilings.Size = new System.Drawing.Size(994, 407);
            this.dgvCeilings.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.cbCountry);
            this.panelInfo.Controls.Add(this.tbName);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.tbAddress);
            this.panelInfo.Controls.Add(this.btnSave);
            this.panelInfo.Controls.Add(this.lblCuntry);
            this.panelInfo.Controls.Add(this.lblAddress);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1000, 100);
            this.panelInfo.TabIndex = 69;
            // 
            // cbCountry
            // 
            this.cbCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountry.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(99, 33);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 31);
            this.cbCountry.TabIndex = 58;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbName.Location = new System.Drawing.Point(99, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 29);
            this.tbName.TabIndex = 57;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(5, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 23);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Название:";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbAddress.Location = new System.Drawing.Point(99, 68);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(400, 29);
            this.tbAddress.TabIndex = 54;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSave.Location = new System.Drawing.Point(874, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblCuntry
            // 
            this.lblCuntry.AutoSize = true;
            this.lblCuntry.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCuntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCuntry.Location = new System.Drawing.Point(5, 36);
            this.lblCuntry.Name = "lblCuntry";
            this.lblCuntry.Size = new System.Drawing.Size(70, 23);
            this.lblCuntry.TabIndex = 49;
            this.lblCuntry.Text = "Страна:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblAddress.Location = new System.Drawing.Point(5, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 23);
            this.lblAddress.TabIndex = 51;
            this.lblAddress.Text = "Адрес:";
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.btnAddCeiling);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 535);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1000, 40);
            this.panelPages.TabIndex = 67;
            // 
            // btnAddCeiling
            // 
            this.btnAddCeiling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCeiling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddCeiling.FlatAppearance.BorderSize = 0;
            this.btnAddCeiling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCeiling.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAddCeiling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnAddCeiling.Location = new System.Drawing.Point(874, 3);
            this.btnAddCeiling.Name = "btnAddCeiling";
            this.btnAddCeiling.Size = new System.Drawing.Size(120, 30);
            this.btnAddCeiling.TabIndex = 54;
            this.btnAddCeiling.Text = "Добавить";
            this.btnAddCeiling.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.AwesomeIcon")));
            // 
            // ManufacturerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManufacturerEditForm";
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.gbCeilings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeilings)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox gbCeilings;
        private System.Windows.Forms.DataGridView dgvCeilings;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCuntry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnAddCeiling;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}