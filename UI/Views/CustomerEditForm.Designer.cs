
namespace StretchCeilings.UI.Views
{
    partial class CustomerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tcCustomer = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tpEstates = new System.Windows.Forms.TabPage();
            this.dgvEstates = new System.Windows.Forms.DataGridView();
            this.panelPageSide = new System.Windows.Forms.Panel();
            this.btnAddEstate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            this.tcCustomer.SuspendLayout();
            this.tbInfo.SuspendLayout();
            this.tpEstates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).BeginInit();
            this.panelPageSide.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(634, 25);
            this.panelTop.TabIndex = 78;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
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
            this.btnClose.Location = new System.Drawing.Point(609, 0);
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
            this.tcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCustomer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tcCustomer.Location = new System.Drawing.Point(0, 25);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(634, 336);
            this.tcCustomer.TabIndex = 79;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbInfo.Controls.Add(this.mtbPhoneNumber);
            this.tbInfo.Controls.Add(this.tbFullName);
            this.tbInfo.Controls.Add(this.btnSaveInfo);
            this.tbInfo.Controls.Add(this.lblFullName);
            this.tbInfo.Controls.Add(this.lblPhoneNumber);
            this.tbInfo.Location = new System.Drawing.Point(4, 32);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(626, 300);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Основная информация";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.mtbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPhoneNumber.Font = new System.Drawing.Font("Open Sans", 12F);
            this.mtbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.mtbPhoneNumber.Location = new System.Drawing.Point(157, 44);
            this.mtbPhoneNumber.Mask = "+7(999)000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(155, 29);
            this.mtbPhoneNumber.TabIndex = 51;
            // 
            // tbFullName
            // 
            this.tbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.tbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbFullName.Location = new System.Drawing.Point(157, 11);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(421, 29);
            this.tbFullName.TabIndex = 50;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSaveInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Location = new System.Drawing.Point(502, 266);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(120, 30);
            this.btnSaveInfo.TabIndex = 49;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.UpdateInfo);
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
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 46);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Номер телефона:";
            // 
            // tpEstates
            // 
            this.tpEstates.Controls.Add(this.dgvEstates);
            this.tpEstates.Controls.Add(this.panelPageSide);
            this.tpEstates.Location = new System.Drawing.Point(4, 32);
            this.tpEstates.Margin = new System.Windows.Forms.Padding(0);
            this.tpEstates.Name = "tpEstates";
            this.tpEstates.Size = new System.Drawing.Size(626, 300);
            this.tpEstates.TabIndex = 1;
            this.tpEstates.Text = "Недвижемость";
            this.tpEstates.UseVisualStyleBackColor = true;
            // 
            // dgvEstates
            // 
            this.dgvEstates.AllowUserToAddRows = false;
            this.dgvEstates.AllowUserToDeleteRows = false;
            this.dgvEstates.AllowUserToResizeColumns = false;
            this.dgvEstates.AllowUserToResizeRows = false;
            this.dgvEstates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstates.Location = new System.Drawing.Point(0, 0);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.ReadOnly = true;
            this.dgvEstates.RowHeadersVisible = false;
            this.dgvEstates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstates.Size = new System.Drawing.Size(626, 260);
            this.dgvEstates.TabIndex = 2;
            this.dgvEstates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveGridData);
            this.dgvEstates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGridData);
            // 
            // panelPageSide
            // 
            this.panelPageSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelPageSide.Controls.Add(this.btnAddEstate);
            this.panelPageSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPageSide.Location = new System.Drawing.Point(0, 260);
            this.panelPageSide.Name = "panelPageSide";
            this.panelPageSide.Size = new System.Drawing.Size(626, 40);
            this.panelPageSide.TabIndex = 1;
            // 
            // btnAddEstate
            // 
            this.btnAddEstate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnAddEstate.FlatAppearance.BorderSize = 0;
            this.btnAddEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEstate.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAddEstate.ForeColor = System.Drawing.Color.White;
            this.btnAddEstate.Location = new System.Drawing.Point(501, 4);
            this.btnAddEstate.Name = "btnAddEstate";
            this.btnAddEstate.Size = new System.Drawing.Size(120, 30);
            this.btnAddEstate.TabIndex = 82;
            this.btnAddEstate.Text = "Добавить";
            this.btnAddEstate.UseVisualStyleBackColor = false;
            this.btnAddEstate.Click += new System.EventHandler(this.AddGridData);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.tcCustomer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelTop.ResumeLayout(false);
            this.tcCustomer.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            this.tpEstates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).EndInit();
            this.panelPageSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TabPage tpEstates;
        private System.Windows.Forms.DataGridView dgvEstates;
        private System.Windows.Forms.Panel panelPageSide;
        private System.Windows.Forms.Button btnAddEstate;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}