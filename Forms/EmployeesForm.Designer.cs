
namespace stretch_ceilings_app.Forms
{
    partial class EmployeesForm
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelUserButtons = new System.Windows.Forms.Panel();
            this.panelFilterButtons = new System.Windows.Forms.Panel();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnUseFilters = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelPages = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelFilterButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panelPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.nudId);
            this.panelInfo.Controls.Add(this.lblId);
            this.panelInfo.Controls.Add(this.cbRole);
            this.panelInfo.Controls.Add(this.lblRole);
            this.panelInfo.Controls.Add(this.tbFullName);
            this.panelInfo.Controls.Add(this.lblFullName);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1054, 114);
            this.panelInfo.TabIndex = 5;
            // 
            // nudId
            // 
            this.nudId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudId.Location = new System.Drawing.Point(133, 7);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(68, 29);
            this.nudId.TabIndex = 40;
            this.nudId.ValueChanged += new System.EventHandler(this.nudId_ValueChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 24);
            this.lblId.TabIndex = 39;
            this.lblId.Text = "№:";
            // 
            // cbRole
            // 
            this.cbRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(133, 79);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(169, 32);
            this.cbRole.TabIndex = 38;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblRole.Location = new System.Drawing.Point(12, 82);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(117, 24);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Должность:";
            // 
            // tbFullName
            // 
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbFullName.Location = new System.Drawing.Point(133, 42);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(252, 29);
            this.tbFullName.TabIndex = 12;
            this.tbFullName.TextChanged += new System.EventHandler(this.tbFullName_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblFullName.Location = new System.Drawing.Point(12, 45);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(59, 24);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "ФИО:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelUserButtons);
            this.panelButtons.Controls.Add(this.panelFilterButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(1054, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(130, 561);
            this.panelButtons.TabIndex = 4;
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
            this.panelFilterButtons.Controls.Add(this.btnResetFilter);
            this.panelFilterButtons.Controls.Add(this.btnUseFilters);
            this.panelFilterButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterButtons.Location = new System.Drawing.Point(0, 0);
            this.panelFilterButtons.Name = "panelFilterButtons";
            this.panelFilterButtons.Size = new System.Drawing.Size(130, 114);
            this.panelFilterButtons.TabIndex = 0;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnResetFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnResetFilter.Location = new System.Drawing.Point(0, 56);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(130, 56);
            this.btnResetFilter.TabIndex = 10;
            this.btnResetFilter.Text = "Сбросить";
            this.btnResetFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
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
            this.btnUseFilters.TabIndex = 9;
            this.btnUseFilters.Text = "Применить";
            this.btnUseFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseFilters.UseVisualStyleBackColor = true;
            this.btnUseFilters.Click += new System.EventHandler(this.btnUseFilters_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 114);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1054, 407);
            this.dgvEmployees.TabIndex = 9;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            this.dgvEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellDoubleClick);
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPrevious);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNext);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 521);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1054, 40);
            this.panelPages.TabIndex = 8;
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(993, 5);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(55, 32);
            this.cbRows.TabIndex = 99;
            this.cbRows.SelectedIndexChanged += new System.EventHandler(this.cbRows_SelectedIndexChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(3, 6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 29);
            this.btnPrevious.TabIndex = 69;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tbPages
            // 
            this.tbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPages.Location = new System.Drawing.Point(39, 6);
            this.tbPages.Name = "tbPages";
            this.tbPages.ReadOnly = true;
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 68;
            this.tbPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(125, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 29);
            this.btnNext.TabIndex = 67;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelFilterButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelUserButtons;
        private System.Windows.Forms.Panel panelFilterButtons;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnUseFilters;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.NumericUpDown nudId;
    }
}