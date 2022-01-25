
namespace stretch_ceilings_app.Forms
{
    partial class ManufacturersForm
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
            this.panelFilters = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbCuntry = new System.Windows.Forms.ComboBox();
            this.lblCuntry = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelUserButtons = new System.Windows.Forms.Panel();
            this.panelFilterButtons = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnUserFilters = new System.Windows.Forms.Button();
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelFilterButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            this.panelPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.tbName);
            this.panelFilters.Controls.Add(this.lblName);
            this.panelFilters.Controls.Add(this.cbCuntry);
            this.panelFilters.Controls.Add(this.lblCuntry);
            this.panelFilters.Controls.Add(this.tbAddress);
            this.panelFilters.Controls.Add(this.lblAddress);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1054, 114);
            this.panelFilters.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbName.Location = new System.Drawing.Point(117, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(340, 29);
            this.tbName.TabIndex = 40;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(12, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 24);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Название:";
            // 
            // cbCuntry
            // 
            this.cbCuntry.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbCuntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCuntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbCuntry.FormattingEnabled = true;
            this.cbCuntry.Location = new System.Drawing.Point(117, 78);
            this.cbCuntry.Name = "cbCuntry";
            this.cbCuntry.Size = new System.Drawing.Size(166, 32);
            this.cbCuntry.TabIndex = 38;
            // 
            // lblCuntry
            // 
            this.lblCuntry.AutoSize = true;
            this.lblCuntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCuntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCuntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblCuntry.Location = new System.Drawing.Point(12, 81);
            this.lblCuntry.Name = "lblCuntry";
            this.lblCuntry.Size = new System.Drawing.Size(80, 24);
            this.lblCuntry.TabIndex = 13;
            this.lblCuntry.Text = "Страна:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbAddress.Location = new System.Drawing.Point(117, 7);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(340, 29);
            this.tbAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblAddress.Location = new System.Drawing.Point(12, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 24);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Адрес:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelUserButtons);
            this.panelButtons.Controls.Add(this.panelFilterButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(1054, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(130, 561);
            this.panelButtons.TabIndex = 6;
            // 
            // panelUserButtons
            // 
            this.panelUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserButtons.Location = new System.Drawing.Point(0, 114);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.Size = new System.Drawing.Size(130, 447);
            this.panelUserButtons.TabIndex = 1;
            // 
            // panelFilterButtons
            // 
            this.panelFilterButtons.Controls.Add(this.btnResetFilters);
            this.panelFilterButtons.Controls.Add(this.btnUserFilters);
            this.panelFilterButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterButtons.Location = new System.Drawing.Point(0, 0);
            this.panelFilterButtons.Name = "panelFilterButtons";
            this.panelFilterButtons.Size = new System.Drawing.Size(130, 114);
            this.panelFilterButtons.TabIndex = 0;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetFilters.FlatAppearance.BorderSize = 0;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnResetFilters.Location = new System.Drawing.Point(0, 56);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(130, 56);
            this.btnResetFilters.TabIndex = 10;
            this.btnResetFilters.Text = "Сбросить";
            this.btnResetFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // btnUserFilters
            // 
            this.btnUserFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserFilters.FlatAppearance.BorderSize = 0;
            this.btnUserFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnUserFilters.Location = new System.Drawing.Point(0, 0);
            this.btnUserFilters.Name = "btnUserFilters";
            this.btnUserFilters.Size = new System.Drawing.Size(130, 56);
            this.btnUserFilters.TabIndex = 9;
            this.btnUserFilters.Text = "Применить";
            this.btnUserFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserFilters.UseVisualStyleBackColor = false;
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManufacturers.Location = new System.Drawing.Point(0, 114);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.RowTemplate.Height = 25;
            this.dgvManufacturers.Size = new System.Drawing.Size(1054, 409);
            this.dgvManufacturers.TabIndex = 11;
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPrevious);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNext);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 523);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1054, 38);
            this.panelPages.TabIndex = 10;
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(993, 3);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(55, 32);
            this.cbRows.TabIndex = 98;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 29);
            this.btnPrevious.TabIndex = 84;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // tbPages
            // 
            this.tbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPages.Location = new System.Drawing.Point(40, 4);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 83;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(126, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 29);
            this.btnNext.TabIndex = 82;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // ManufacturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dgvManufacturers);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelButtons);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "ManufacturersForm";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelFilterButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbCuntry;
        private System.Windows.Forms.Label lblCuntry;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelUserButtons;
        private System.Windows.Forms.Panel panelFilterButtons;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnUserFilters;
        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNext;
    }
}