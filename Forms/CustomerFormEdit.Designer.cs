
namespace stretch_ceilings_app.Forms
{
    partial class CustomerFormEdit
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
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tcCustomer.SuspendLayout();
            this.tbInfo.SuspendLayout();
            this.tpEstates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).BeginInit();
            this.panelPageSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.tbInfo);
            this.tcCustomer.Controls.Add(this.tpEstates);
            this.tcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcCustomer.Location = new System.Drawing.Point(0, 0);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(634, 361);
            this.tcCustomer.TabIndex = 2;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.tbInfo.Controls.Add(this.mtbPhoneNumber);
            this.tbInfo.Controls.Add(this.tbFullName);
            this.tbInfo.Controls.Add(this.btnSaveInfo);
            this.tbInfo.Controls.Add(this.lblFullName);
            this.tbInfo.Controls.Add(this.lblPhoneNumber);
            this.tbInfo.Location = new System.Drawing.Point(4, 33);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(626, 324);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Основная информация";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(189, 44);
            this.mtbPhoneNumber.Mask = "+7(999)000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(155, 29);
            this.mtbPhoneNumber.TabIndex = 51;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(189, 11);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(421, 29);
            this.tbFullName.TabIndex = 50;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.Black;
            this.btnSaveInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Location = new System.Drawing.Point(499, 287);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(120, 30);
            this.btnSaveInfo.TabIndex = 49;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFullName.Location = new System.Drawing.Point(8, 14);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(59, 24);
            this.lblFullName.TabIndex = 45;
            this.lblFullName.Text = "ФИО:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(8, 49);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(167, 24);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Номер телефона:";
            // 
            // tpEstates
            // 
            this.tpEstates.Controls.Add(this.dgvEstates);
            this.tpEstates.Controls.Add(this.panelPageSide);
            this.tpEstates.Location = new System.Drawing.Point(4, 33);
            this.tpEstates.Name = "tpEstates";
            this.tpEstates.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstates.Size = new System.Drawing.Size(626, 324);
            this.tpEstates.TabIndex = 1;
            this.tpEstates.Text = "Недвижемость";
            this.tpEstates.UseVisualStyleBackColor = true;
            // 
            // dgvEstates
            // 
            this.dgvEstates.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstates.Location = new System.Drawing.Point(3, 3);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.Size = new System.Drawing.Size(620, 278);
            this.dgvEstates.TabIndex = 2;
            // 
            // panelPageSide
            // 
            this.panelPageSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelPageSide.Controls.Add(this.btnAddEstate);
            this.panelPageSide.Controls.Add(this.btnPreviousPage);
            this.panelPageSide.Controls.Add(this.tbPage);
            this.panelPageSide.Controls.Add(this.btnNextPage);
            this.panelPageSide.Controls.Add(this.button2);
            this.panelPageSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPageSide.Location = new System.Drawing.Point(3, 281);
            this.panelPageSide.Name = "panelPageSide";
            this.panelPageSide.Size = new System.Drawing.Size(620, 40);
            this.panelPageSide.TabIndex = 1;
            // 
            // btnAddEstate
            // 
            this.btnAddEstate.BackColor = System.Drawing.Color.Black;
            this.btnAddEstate.FlatAppearance.BorderSize = 0;
            this.btnAddEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddEstate.ForeColor = System.Drawing.Color.White;
            this.btnAddEstate.Location = new System.Drawing.Point(497, 5);
            this.btnAddEstate.Name = "btnAddEstate";
            this.btnAddEstate.Size = new System.Drawing.Size(120, 30);
            this.btnAddEstate.TabIndex = 82;
            this.btnAddEstate.Text = "Добавить";
            this.btnAddEstate.UseVisualStyleBackColor = false;
            this.btnAddEstate.Click += new System.EventHandler(this.btnAddEstate_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.Black;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(7, 7);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(30, 29);
            this.btnPreviousPage.TabIndex = 81;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            // 
            // tbPage
            // 
            this.tbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPage.Location = new System.Drawing.Point(43, 7);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(80, 29);
            this.tbPage.TabIndex = 80;
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Black;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(129, 7);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(30, 29);
            this.btnNextPage.TabIndex = 79;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1053, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 63;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CustomerFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.tcCustomer);
            this.Name = "CustomerFormEdit";
            this.Load += new System.EventHandler(this.CustomerFormEdit_Load);
            this.tcCustomer.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            this.tpEstates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).EndInit();
            this.panelPageSide.ResumeLayout(false);
            this.panelPageSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TabPage tpEstates;
        private System.Windows.Forms.DataGridView dgvEstates;
        private System.Windows.Forms.Panel panelPageSide;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Button btnAddEstate;
    }
}