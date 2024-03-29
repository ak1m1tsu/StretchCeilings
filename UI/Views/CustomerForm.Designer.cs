﻿
namespace StretchCeilings.UI.Views
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPhoneNumberValue = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tpEstates = new System.Windows.Forms.TabPage();
            this.dataGridViewEstates = new System.Windows.Forms.DataGridView();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tcCustomer.SuspendLayout();
            this.tbInfo.SuspendLayout();
            this.tpEstates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstates)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(700, 25);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(675, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseForm);
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.tbInfo);
            this.tcCustomer.Controls.Add(this.tpEstates);
            this.tcCustomer.Controls.Add(this.tabPageOrders);
            this.tcCustomer.Controls.Add(this.tabPageServices);
            this.tcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCustomer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tcCustomer.ItemSize = new System.Drawing.Size(200, 30);
            this.tcCustomer.Location = new System.Drawing.Point(0, 25);
            this.tcCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.Padding = new System.Drawing.Point(0, 0);
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(700, 375);
            this.tcCustomer.TabIndex = 3;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbInfo.Controls.Add(this.btnEdit);
            this.tbInfo.Controls.Add(this.lblPhoneNumberValue);
            this.tbInfo.Controls.Add(this.lblFullNameValue);
            this.tbInfo.Controls.Add(this.lblFullName);
            this.tbInfo.Controls.Add(this.lblPhoneNumber);
            this.tbInfo.Location = new System.Drawing.Point(4, 34);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(692, 337);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Основная информация";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(564, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 30);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.OpenEditForm);
            // 
            // lblPhoneNumberValue
            // 
            this.lblPhoneNumberValue.AutoSize = true;
            this.lblPhoneNumberValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPhoneNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPhoneNumberValue.Location = new System.Drawing.Point(152, 42);
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
            this.lblFullNameValue.Location = new System.Drawing.Point(152, 11);
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
            this.lblFullName.Location = new System.Drawing.Point(5, 11);
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
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 42);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Номер телефона:";
            // 
            // tpEstates
            // 
            this.tpEstates.Controls.Add(this.dataGridViewEstates);
            this.tpEstates.Location = new System.Drawing.Point(4, 34);
            this.tpEstates.Name = "tpEstates";
            this.tpEstates.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstates.Size = new System.Drawing.Size(692, 337);
            this.tpEstates.TabIndex = 1;
            this.tpEstates.Text = "Недвижемость";
            this.tpEstates.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEstates
            // 
            this.dataGridViewEstates.AllowUserToAddRows = false;
            this.dataGridViewEstates.AllowUserToDeleteRows = false;
            this.dataGridViewEstates.AllowUserToResizeColumns = false;
            this.dataGridViewEstates.AllowUserToResizeRows = false;
            this.dataGridViewEstates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dataGridViewEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEstates.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEstates.Name = "dataGridViewEstates";
            this.dataGridViewEstates.ReadOnly = true;
            this.dataGridViewEstates.RowHeadersVisible = false;
            this.dataGridViewEstates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstates.Size = new System.Drawing.Size(686, 331);
            this.dataGridViewEstates.TabIndex = 2;
            this.dataGridViewEstates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGridData);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 34);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(692, 337);
            this.tabPageOrders.TabIndex = 2;
            this.tabPageOrders.Text = "Заказы";
            // 
            // tabPageServices
            // 
            this.tabPageServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPageServices.Controls.Add(this.dataGridViewServices);
            this.tabPageServices.Location = new System.Drawing.Point(4, 34);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(692, 337);
            this.tabPageServices.TabIndex = 3;
            this.tabPageServices.Text = "Услуги";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(686, 331);
            this.dataGridViewOrders.TabIndex = 3;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AllowUserToResizeColumns = false;
            this.dataGridViewServices.AllowUserToResizeRows = false;
            this.dataGridViewServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServices.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(686, 331);
            this.dataGridViewServices.TabIndex = 3;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.tcCustomer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelTop.ResumeLayout(false);
            this.tcCustomer.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            this.tpEstates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstates)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tpEstates;
        private System.Windows.Forms.DataGridView dataGridViewEstates;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPhoneNumberValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewServices;
    }
}