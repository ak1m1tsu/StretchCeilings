
namespace StretchCeilingsApp.Forms
{
    partial class CustomersForm
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
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelUserButtons = new System.Windows.Forms.Panel();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnAcceptFilters = new System.Windows.Forms.Button();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelSearchButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPreviousPage);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNextPage);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 560);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1050, 40);
            this.panelPages.TabIndex = 6;
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(989, 5);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(55, 31);
            this.cbRows.TabIndex = 98;
            this.cbRows.SelectedIndexChanged += new System.EventHandler(this.cbRows_SelectedIndexChanged);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(5, 4);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(31, 31);
            this.btnPreviousPage.TabIndex = 84;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbPages
            // 
            this.tbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPages.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPages.Location = new System.Drawing.Point(38, 5);
            this.tbPages.Name = "tbPages";
            this.tbPages.ReadOnly = true;
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 83;
            this.tbPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(120, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(31, 31);
            this.btnNextPage.TabIndex = 82;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 100);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1050, 500);
            this.dgvCustomers.TabIndex = 7;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.mtbPhoneNumber);
            this.panelFilters.Controls.Add(this.nudId);
            this.panelFilters.Controls.Add(this.lblId);
            this.panelFilters.Controls.Add(this.tbFullName);
            this.panelFilters.Controls.Add(this.lblFullName);
            this.panelFilters.Controls.Add(this.lblPhoneNumber);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1050, 100);
            this.panelFilters.TabIndex = 8;
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.mtbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPhoneNumber.Font = new System.Drawing.Font("Open Sans", 12F);
            this.mtbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.mtbPhoneNumber.Location = new System.Drawing.Point(174, 34);
            this.mtbPhoneNumber.Mask = "+7(999)000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(157, 29);
            this.mtbPhoneNumber.TabIndex = 52;
            // 
            // nudId
            // 
            this.nudId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudId.Font = new System.Drawing.Font("Open Sans", 12F);
            this.nudId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudId.Location = new System.Drawing.Point(174, 67);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(60, 29);
            this.nudId.TabIndex = 15;
            this.nudId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudId.ValueChanged += new System.EventHandler(this.nudId_ValueChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblId.Location = new System.Drawing.Point(3, 69);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 23);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "№:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbFullName.Location = new System.Drawing.Point(174, 1);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(241, 29);
            this.tbFullName.TabIndex = 12;
            this.tbFullName.TextChanged += new System.EventHandler(this.tbFullName_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblFullName.Location = new System.Drawing.Point(3, 3);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(51, 23);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "ФИО:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 36);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Номер телефона:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelUserButtons);
            this.panelButtons.Controls.Add(this.panelSearchButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(1050, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(150, 600);
            this.panelButtons.TabIndex = 5;
            // 
            // panelUserButtons
            // 
            this.panelUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserButtons.Location = new System.Drawing.Point(0, 100);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.Size = new System.Drawing.Size(150, 500);
            this.panelUserButtons.TabIndex = 1;
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Controls.Add(this.btnResetFilters);
            this.panelSearchButtons.Controls.Add(this.btnAcceptFilters);
            this.panelSearchButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchButtons.Location = new System.Drawing.Point(0, 0);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new System.Drawing.Size(150, 100);
            this.panelSearchButtons.TabIndex = 0;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetFilters.FlatAppearance.BorderSize = 0;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnResetFilters.Location = new System.Drawing.Point(0, 50);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(150, 50);
            this.btnResetFilters.TabIndex = 10;
            this.btnResetFilters.Text = "Сбросить";
            this.btnResetFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // btnAcceptFilters
            // 
            this.btnAcceptFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcceptFilters.FlatAppearance.BorderSize = 0;
            this.btnAcceptFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptFilters.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAcceptFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnAcceptFilters.Location = new System.Drawing.Point(0, 0);
            this.btnAcceptFilters.Name = "btnAcceptFilters";
            this.btnAcceptFilters.Size = new System.Drawing.Size(150, 50);
            this.btnAcceptFilters.TabIndex = 9;
            this.btnAcceptFilters.Text = "Применить";
            this.btnAcceptFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceptFilters.UseVisualStyleBackColor = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelButtons);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelSearchButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelUserButtons;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnAcceptFilters;
        private System.Windows.Forms.ComboBox cbRows;
    }
}