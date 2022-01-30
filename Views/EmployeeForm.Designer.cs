
namespace StretchCeilings.Views
{
    partial class EmployeeForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblPasswordValue = new System.Windows.Forms.Label();
            this.lblLoginValue = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.gbTimeTable = new System.Windows.Forms.GroupBox();
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.gbTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
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
            this.panelTop.TabIndex = 89;
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
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblPasswordValue);
            this.panelInfo.Controls.Add(this.lblLoginValue);
            this.panelInfo.Controls.Add(this.lblRoleValue);
            this.panelInfo.Controls.Add(this.lblNameValue);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.lblPassword);
            this.panelInfo.Controls.Add(this.lblLogin);
            this.panelInfo.Controls.Add(this.lblRole);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.panelInfo.Location = new System.Drawing.Point(0, 25);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(350, 475);
            this.panelInfo.TabIndex = 90;
            // 
            // lblPasswordValue
            // 
            this.lblPasswordValue.AutoSize = true;
            this.lblPasswordValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPasswordValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPasswordValue.Location = new System.Drawing.Point(107, 120);
            this.lblPasswordValue.Name = "lblPasswordValue";
            this.lblPasswordValue.Size = new System.Drawing.Size(39, 23);
            this.lblPasswordValue.TabIndex = 30;
            this.lblPasswordValue.Text = "Нет";
            this.lblPasswordValue.Visible = false;
            // 
            // lblLoginValue
            // 
            this.lblLoginValue.AutoSize = true;
            this.lblLoginValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblLoginValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblLoginValue.Location = new System.Drawing.Point(107, 84);
            this.lblLoginValue.Name = "lblLoginValue";
            this.lblLoginValue.Size = new System.Drawing.Size(39, 23);
            this.lblLoginValue.TabIndex = 29;
            this.lblLoginValue.Text = "Нет";
            this.lblLoginValue.Visible = false;
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblRoleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblRoleValue.Location = new System.Drawing.Point(107, 52);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Size = new System.Drawing.Size(39, 23);
            this.lblRoleValue.TabIndex = 28;
            this.lblRoleValue.Text = "Нет";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoEllipsis = true;
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblNameValue.Location = new System.Drawing.Point(107, 7);
            this.lblNameValue.MaximumSize = new System.Drawing.Size(230, 0);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(39, 23);
            this.lblNameValue.TabIndex = 27;
            this.lblNameValue.Text = "Нет";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(5, 7);
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
            this.lblPassword.Location = new System.Drawing.Point(5, 120);
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
            this.lblLogin.Location = new System.Drawing.Point(5, 84);
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
            this.lblRole.Location = new System.Drawing.Point(5, 52);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(101, 23);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "Должность:";
            // 
            // gbTimeTable
            // 
            this.gbTimeTable.Controls.Add(this.dgvTimeTable);
            this.gbTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTimeTable.Font = new System.Drawing.Font("Open Sans", 12F);
            this.gbTimeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.gbTimeTable.Location = new System.Drawing.Point(350, 25);
            this.gbTimeTable.Name = "gbTimeTable";
            this.gbTimeTable.Size = new System.Drawing.Size(650, 475);
            this.gbTimeTable.TabIndex = 91;
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
            this.dgvTimeTable.RowHeadersVisible = false;
            this.dgvTimeTable.RowTemplate.Height = 25;
            this.dgvTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeTable.Size = new System.Drawing.Size(644, 447);
            this.dgvTimeTable.TabIndex = 4;
            this.dgvTimeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeTable_CellClick);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.gbTimeTable);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.gbTimeTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblPasswordValue;
        private System.Windows.Forms.Label lblLoginValue;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox gbTimeTable;
        private System.Windows.Forms.DataGridView dgvTimeTable;
    }
}