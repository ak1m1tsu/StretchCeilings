
namespace stretch_ceilings_app.Forms
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
            this.gbTimeTable = new System.Windows.Forms.GroupBox();
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblPasswordValue = new System.Windows.Forms.Label();
            this.lblLoginValue = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.gbTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTimeTable
            // 
            this.gbTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.gbTimeTable.Controls.Add(this.dgvTimeTable);
            this.gbTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gbTimeTable.Location = new System.Drawing.Point(388, 0);
            this.gbTimeTable.Name = "gbTimeTable";
            this.gbTimeTable.Size = new System.Drawing.Size(796, 561);
            this.gbTimeTable.TabIndex = 27;
            this.gbTimeTable.TabStop = false;
            this.gbTimeTable.Text = "Расписание";
            // 
            // dgvTimeTable
            // 
            this.dgvTimeTable.AllowUserToAddRows = false;
            this.dgvTimeTable.AllowUserToDeleteRows = false;
            this.dgvTimeTable.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeTable.Location = new System.Drawing.Point(3, 25);
            this.dgvTimeTable.Name = "dgvTimeTable";
            this.dgvTimeTable.ReadOnly = true;
            this.dgvTimeTable.RowTemplate.Height = 25;
            this.dgvTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeTable.Size = new System.Drawing.Size(790, 533);
            this.dgvTimeTable.TabIndex = 4;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(69)))), ((int)(((byte)(145)))));
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
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(388, 561);
            this.panelInfo.TabIndex = 28;
            // 
            // lblPasswordValue
            // 
            this.lblPasswordValue.AutoSize = true;
            this.lblPasswordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPasswordValue.Location = new System.Drawing.Point(143, 115);
            this.lblPasswordValue.Name = "lblPasswordValue";
            this.lblPasswordValue.Size = new System.Drawing.Size(44, 24);
            this.lblPasswordValue.TabIndex = 30;
            this.lblPasswordValue.Text = "Нет";
            this.lblPasswordValue.Visible = false;
            // 
            // lblLoginValue
            // 
            this.lblLoginValue.AutoSize = true;
            this.lblLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLoginValue.Location = new System.Drawing.Point(143, 79);
            this.lblLoginValue.Name = "lblLoginValue";
            this.lblLoginValue.Size = new System.Drawing.Size(44, 24);
            this.lblLoginValue.TabIndex = 29;
            this.lblLoginValue.Text = "Нет";
            this.lblLoginValue.Visible = false;
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRoleValue.Location = new System.Drawing.Point(143, 47);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Size = new System.Drawing.Size(44, 24);
            this.lblRoleValue.TabIndex = 28;
            this.lblRoleValue.Text = "Нет";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNameValue.Location = new System.Drawing.Point(143, 11);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(44, 24);
            this.lblNameValue.TabIndex = 27;
            this.lblNameValue.Text = "Нет";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(16, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 24);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "ФИО:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPassword.Location = new System.Drawing.Point(16, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 24);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLogin.Location = new System.Drawing.Point(16, 79);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 24);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Логин:";
            this.lblLogin.Visible = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRole.Location = new System.Drawing.Point(16, 47);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(117, 24);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "Должность:";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.gbTimeTable);
            this.Controls.Add(this.panelInfo);
            this.MinimumSize = new System.Drawing.Size(1053, 600);
            this.Name = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.gbTimeTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimeTable;
        private System.Windows.Forms.DataGridView dgvTimeTable;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblPasswordValue;
        private System.Windows.Forms.Label lblLoginValue;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRole;
    }
}