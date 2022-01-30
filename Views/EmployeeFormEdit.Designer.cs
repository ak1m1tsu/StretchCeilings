namespace StretchCeilings.Views
{
    partial class EmployeeFormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFormEdit));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.gbTimeTable = new System.Windows.Forms.GroupBox();
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            this.panelPages = new System.Windows.Forms.Panel();
            this.btnAddTimeTable = new System.Windows.Forms.Button();
            this.epControls = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.gbTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epControls)).BeginInit();
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
            this.panelTop.TabIndex = 92;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.tbLogin);
            this.panelInfo.Controls.Add(this.btnSave);
            this.panelInfo.Controls.Add(this.cbRole);
            this.panelInfo.Controls.Add(this.tbPassword);
            this.panelInfo.Controls.Add(this.tbFullName);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.lblPassword);
            this.panelInfo.Controls.Add(this.lblLogin);
            this.panelInfo.Controls.Add(this.lblRole);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.panelInfo.Location = new System.Drawing.Point(0, 25);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(350, 475);
            this.panelInfo.TabIndex = 95;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbLogin.Location = new System.Drawing.Point(107, 81);
            this.tbLogin.Mask = "+7(999)000-00-00";
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(203, 29);
            this.tbLogin.TabIndex = 36;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(204, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 30);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(107, 43);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(203, 31);
            this.cbRole.TabIndex = 34;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPassword.Location = new System.Drawing.Point(107, 116);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(203, 29);
            this.tbPassword.TabIndex = 33;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbFullName
            // 
            this.tbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbFullName.Location = new System.Drawing.Point(107, 8);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(203, 29);
            this.tbFullName.TabIndex = 31;
            this.tbFullName.TextChanged += new System.EventHandler(this.tbFullName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 23);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "ФИО:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPassword.Location = new System.Drawing.Point(3, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 23);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblLogin.Location = new System.Drawing.Point(3, 83);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 23);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Логин:";
            this.lblLogin.Visible = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblRole.Location = new System.Drawing.Point(3, 45);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(101, 23);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "Должность:";
            // 
            // gbTimeTable
            // 
            this.gbTimeTable.Controls.Add(this.dgvTimeTable);
            this.gbTimeTable.Controls.Add(this.panelPages);
            this.gbTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTimeTable.Font = new System.Drawing.Font("Open Sans", 12F);
            this.gbTimeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.gbTimeTable.Location = new System.Drawing.Point(350, 25);
            this.gbTimeTable.Name = "gbTimeTable";
            this.gbTimeTable.Size = new System.Drawing.Size(650, 475);
            this.gbTimeTable.TabIndex = 96;
            this.gbTimeTable.TabStop = false;
            this.gbTimeTable.Text = "Расписание";
            // 
            // dgvTimeTable
            // 
            this.dgvTimeTable.AllowUserToAddRows = false;
            this.dgvTimeTable.AllowUserToDeleteRows = false;
            this.dgvTimeTable.AllowUserToResizeColumns = false;
            this.dgvTimeTable.AllowUserToResizeRows = false;
            this.dgvTimeTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeTable.Location = new System.Drawing.Point(3, 25);
            this.dgvTimeTable.Name = "dgvTimeTable";
            this.dgvTimeTable.ReadOnly = true;
            this.dgvTimeTable.RowTemplate.Height = 25;
            this.dgvTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeTable.Size = new System.Drawing.Size(644, 407);
            this.dgvTimeTable.TabIndex = 7;
            this.dgvTimeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeTable_CellClick);
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.btnAddTimeTable);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(3, 432);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(644, 40);
            this.panelPages.TabIndex = 6;
            // 
            // btnAddTimeTable
            // 
            this.btnAddTimeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddTimeTable.FlatAppearance.BorderSize = 0;
            this.btnAddTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimeTable.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAddTimeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnAddTimeTable.Location = new System.Drawing.Point(521, 4);
            this.btnAddTimeTable.Name = "btnAddTimeTable";
            this.btnAddTimeTable.Size = new System.Drawing.Size(120, 30);
            this.btnAddTimeTable.TabIndex = 96;
            this.btnAddTimeTable.Text = "Добавить";
            this.btnAddTimeTable.UseVisualStyleBackColor = false;
            this.btnAddTimeTable.Click += new System.EventHandler(this.btnAddTimeTable_Click);
            // 
            // epControls
            // 
            this.epControls.ContainerControl = this;
            this.epControls.Icon = ((System.Drawing.Icon)(resources.GetObject("epControls.Icon")));
            // 
            // EmployeeFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.gbTimeTable);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeFormEdit";
            this.Load += new System.EventHandler(this.EmployeeFormEdit_Load);
            this.panelTop.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.gbTimeTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.panelPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epControls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox gbTimeTable;
        private System.Windows.Forms.DataGridView dgvTimeTable;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnAddTimeTable;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbFullName;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.ErrorProvider epControls;
        private System.Windows.Forms.MaskedTextBox tbLogin;
    }
}