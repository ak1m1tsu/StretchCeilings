
namespace StretchCeilings.Views
{
    partial class CustomerForm
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
            this.tcCustomer = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.lblPhoneNumberValue = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tpEstates = new System.Windows.Forms.TabPage();
            this.dgvEstates = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tcCustomer.SuspendLayout();
            this.tbInfo.SuspendLayout();
            this.tpEstates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(634, 25);
            this.panelTop.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(609, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.tbInfo);
            this.tcCustomer.Controls.Add(this.tpEstates);
            this.tcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCustomer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tcCustomer.Location = new System.Drawing.Point(0, 25);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(634, 336);
            this.tcCustomer.TabIndex = 3;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbInfo.Controls.Add(this.btnChangeInfo);
            this.tbInfo.Controls.Add(this.lblPhoneNumberValue);
            this.tbInfo.Controls.Add(this.lblFullNameValue);
            this.tbInfo.Controls.Add(this.lblFullName);
            this.tbInfo.Controls.Add(this.lblPhoneNumber);
            this.tbInfo.Location = new System.Drawing.Point(4, 32);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(626, 300);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Основная информация";
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnChangeInfo.FlatAppearance.BorderSize = 0;
            this.btnChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInfo.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnChangeInfo.ForeColor = System.Drawing.Color.White;
            this.btnChangeInfo.Location = new System.Drawing.Point(499, 264);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(120, 30);
            this.btnChangeInfo.TabIndex = 76;
            this.btnChangeInfo.Text = "Изменить";
            this.btnChangeInfo.UseVisualStyleBackColor = false;
            // 
            // lblPhoneNumberValue
            // 
            this.lblPhoneNumberValue.AutoSize = true;
            this.lblPhoneNumberValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPhoneNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPhoneNumberValue.Location = new System.Drawing.Point(177, 45);
            this.lblPhoneNumberValue.Name = "lblPhoneNumberValue";
            this.lblPhoneNumberValue.Size = new System.Drawing.Size(39, 23);
            this.lblPhoneNumberValue.TabIndex = 48;
            this.lblPhoneNumberValue.Text = "Нет";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(177, 14);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(39, 23);
            this.lblFullNameValue.TabIndex = 47;
            this.lblFullNameValue.Text = "Нет";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblFullName.Location = new System.Drawing.Point(8, 14);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(51, 23);
            this.lblFullName.TabIndex = 45;
            this.lblFullName.Text = "ФИО:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(8, 45);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Номер телефона:";
            // 
            // tpEstates
            // 
            this.tpEstates.Controls.Add(this.dgvEstates);
            this.tpEstates.Location = new System.Drawing.Point(4, 32);
            this.tpEstates.Name = "tpEstates";
            this.tpEstates.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstates.Size = new System.Drawing.Size(626, 300);
            this.tpEstates.TabIndex = 1;
            this.tpEstates.Text = "Недвижемость";
            this.tpEstates.UseVisualStyleBackColor = true;
            // 
            // dgvEstates
            // 
            this.dgvEstates.AllowUserToAddRows = false;
            this.dgvEstates.AllowUserToDeleteRows = false;
            this.dgvEstates.AllowUserToResizeRows = false;
            this.dgvEstates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstates.Location = new System.Drawing.Point(3, 3);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.RowHeadersVisible = false;
            this.dgvEstates.Size = new System.Drawing.Size(620, 294);
            this.dgvEstates.TabIndex = 2;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.tcCustomer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panelTop.ResumeLayout(false);
            this.tcCustomer.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            this.tpEstates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Label lblPhoneNumberValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TabPage tpEstates;
        private System.Windows.Forms.DataGridView dgvEstates;
    }
}