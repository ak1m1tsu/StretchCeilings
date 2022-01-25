
namespace stretch_ceilings_app.Forms
{
    partial class AdditionalServicesForm
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
            this.panelUserButtons = new System.Windows.Forms.Panel();
            this.panelSearchButtons = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnUseFilters = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgvAdditionalServices = new System.Windows.Forms.DataGridView();
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.nudTotalTo = new System.Windows.Forms.NumericUpDown();
            this.nudTotalFrom = new System.Windows.Forms.NumericUpDown();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelSearchButtons.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditionalServices)).BeginInit();
            this.panelPages.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
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
            // panelUserButtons
            // 
            this.panelUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserButtons.Location = new System.Drawing.Point(0, 110);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.Size = new System.Drawing.Size(130, 451);
            this.panelUserButtons.TabIndex = 1;
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Controls.Add(this.btnResetFilters);
            this.panelSearchButtons.Controls.Add(this.btnUseFilters);
            this.panelSearchButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchButtons.Location = new System.Drawing.Point(0, 0);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new System.Drawing.Size(130, 110);
            this.panelSearchButtons.TabIndex = 0;
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
            this.btnResetFilters.TabIndex = 12;
            this.btnResetFilters.Text = "Сбросить";
            this.btnResetFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
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
            this.btnUseFilters.TabIndex = 11;
            this.btnUseFilters.Text = "Применить";
            this.btnUseFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseFilters.UseVisualStyleBackColor = true;
            this.btnUseFilters.Click += new System.EventHandler(this.btnUseFilters_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgvAdditionalServices);
            this.panelData.Controls.Add(this.panelPages);
            this.panelData.Controls.Add(this.panelFilters);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1054, 561);
            this.panelData.TabIndex = 1;
            // 
            // dgvAdditionalServices
            // 
            this.dgvAdditionalServices.AllowUserToAddRows = false;
            this.dgvAdditionalServices.AllowUserToDeleteRows = false;
            this.dgvAdditionalServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvAdditionalServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditionalServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdditionalServices.Location = new System.Drawing.Point(0, 110);
            this.dgvAdditionalServices.Name = "dgvAdditionalServices";
            this.dgvAdditionalServices.ReadOnly = true;
            this.dgvAdditionalServices.RowHeadersVisible = false;
            this.dgvAdditionalServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdditionalServices.Size = new System.Drawing.Size(1054, 411);
            this.dgvAdditionalServices.TabIndex = 2;
            this.dgvAdditionalServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdditionalServices_CellClick);
            this.dgvAdditionalServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdditionalServices_CellDoubleClick);
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPreviousPage);
            this.panelPages.Controls.Add(this.tbPage);
            this.panelPages.Controls.Add(this.btnNextPage);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 521);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1054, 40);
            this.panelPages.TabIndex = 1;
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
            this.cbRows.SelectedIndexChanged += new System.EventHandler(this.cbRows_SelectedIndexChanged);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(5, 5);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(30, 29);
            this.btnPreviousPage.TabIndex = 93;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbPage
            // 
            this.tbPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPage.Location = new System.Drawing.Point(41, 5);
            this.tbPage.Name = "tbPage";
            this.tbPage.ReadOnly = true;
            this.tbPage.Size = new System.Drawing.Size(80, 29);
            this.tbPage.TabIndex = 92;
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(127, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(30, 29);
            this.btnNextPage.TabIndex = 91;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.nudTotalTo);
            this.panelFilters.Controls.Add(this.nudTotalFrom);
            this.panelFilters.Controls.Add(this.lblPriceTo);
            this.panelFilters.Controls.Add(this.lblPriceFrom);
            this.panelFilters.Controls.Add(this.nudId);
            this.panelFilters.Controls.Add(this.tbName);
            this.panelFilters.Controls.Add(this.lblName);
            this.panelFilters.Controls.Add(this.lblId);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1054, 110);
            this.panelFilters.TabIndex = 0;
            // 
            // nudTotalTo
            // 
            this.nudTotalTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalTo.Location = new System.Drawing.Point(290, 75);
            this.nudTotalTo.Name = "nudTotalTo";
            this.nudTotalTo.Size = new System.Drawing.Size(121, 29);
            this.nudTotalTo.TabIndex = 99;
            this.nudTotalTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalTo.ValueChanged += new System.EventHandler(this.nudTotalTo_ValueChanged);
            // 
            // nudTotalFrom
            // 
            this.nudTotalFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalFrom.Location = new System.Drawing.Point(117, 75);
            this.nudTotalFrom.Name = "nudTotalFrom";
            this.nudTotalFrom.Size = new System.Drawing.Size(115, 29);
            this.nudTotalFrom.TabIndex = 98;
            this.nudTotalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalFrom.ValueChanged += new System.EventHandler(this.nudTotalFrom_ValueChanged);
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceTo.Location = new System.Drawing.Point(246, 79);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Size = new System.Drawing.Size(38, 24);
            this.lblPriceTo.TabIndex = 7;
            this.lblPriceTo.Text = "до:";
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceFrom.Location = new System.Drawing.Point(12, 79);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Size = new System.Drawing.Size(85, 24);
            this.lblPriceFrom.TabIndex = 5;
            this.lblPriceFrom.Text = "Цена от:";
            // 
            // nudId
            // 
            this.nudId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudId.Location = new System.Drawing.Point(117, 6);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(68, 29);
            this.nudId.TabIndex = 4;
            this.nudId.ValueChanged += new System.EventHandler(this.nudIdValue_ValueChanged);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(117, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(294, 29);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbNameValue_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Название:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblId.Location = new System.Drawing.Point(12, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 24);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Номер:";
            // 
            // AdditionalServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Name = "AdditionalServicesForm";
            this.Load += new System.EventHandler(this.AdditionalServicesForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelSearchButtons.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditionalServices)).EndInit();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelUserButtons;
        private System.Windows.Forms.Panel panelSearchButtons;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dgvAdditionalServices;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnUseFilters;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label lblPriceTo;
        private System.Windows.Forms.Label lblPriceFrom;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.NumericUpDown nudTotalTo;
        private System.Windows.Forms.NumericUpDown nudTotalFrom;
    }
}