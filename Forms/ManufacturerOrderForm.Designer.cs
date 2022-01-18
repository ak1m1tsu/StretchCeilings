
namespace stretch_ceilings_app.Forms
{
    partial class ManufacturerOrderForm
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbCeilings = new System.Windows.Forms.GroupBox();
            this.dgvCeilings = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDateComing = new System.Windows.Forms.Label();
            this.lblDatePlaced = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.ibtnCustomer = new FontAwesome.Sharp.IconButton();
            this.ibtnManufacturer = new FontAwesome.Sharp.IconButton();
            this.lblDateComingValue = new System.Windows.Forms.Label();
            this.lblDatePlacedValue = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelPages.SuspendLayout();
            this.gbCeilings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeilings)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.btnPrevious);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNext);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(3, 344);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1178, 42);
            this.panelPages.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Black;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(6, 6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 29);
            this.btnPrevious.TabIndex = 78;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // tbPages
            // 
            this.tbPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPages.Location = new System.Drawing.Point(42, 6);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 77;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(128, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 29);
            this.btnNext.TabIndex = 76;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // gbCeilings
            // 
            this.gbCeilings.Controls.Add(this.dgvCeilings);
            this.gbCeilings.Controls.Add(this.panelPages);
            this.gbCeilings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCeilings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCeilings.Location = new System.Drawing.Point(0, 172);
            this.gbCeilings.Name = "gbCeilings";
            this.gbCeilings.Size = new System.Drawing.Size(1184, 389);
            this.gbCeilings.TabIndex = 3;
            this.gbCeilings.TabStop = false;
            this.gbCeilings.Text = "Потолки";
            // 
            // dgvCeilings
            // 
            this.dgvCeilings.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCeilings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCeilings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCeilings.Location = new System.Drawing.Point(3, 25);
            this.dgvCeilings.Name = "dgvCeilings";
            this.dgvCeilings.RowTemplate.Height = 25;
            this.dgvCeilings.Size = new System.Drawing.Size(1178, 319);
            this.dgvCeilings.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblDatePlacedValue);
            this.panelInfo.Controls.Add(this.lblDateComingValue);
            this.panelInfo.Controls.Add(this.ibtnManufacturer);
            this.panelInfo.Controls.Add(this.btnEdit);
            this.panelInfo.Controls.Add(this.ibtnCustomer);
            this.panelInfo.Controls.Add(this.lblTotalValue);
            this.panelInfo.Controls.Add(this.lblTotal);
            this.panelInfo.Controls.Add(this.lblDateComing);
            this.panelInfo.Controls.Add(this.lblDatePlaced);
            this.panelInfo.Controls.Add(this.lblManufacturer);
            this.panelInfo.Controls.Add(this.lblCustomer);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1184, 172);
            this.panelInfo.TabIndex = 2;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTotalValue.Location = new System.Drawing.Point(186, 138);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(81, 24);
            this.lblTotalValue.TabIndex = 44;
            this.lblTotalValue.Text = "0.00 руб";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTotal.Location = new System.Drawing.Point(8, 138);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 24);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "Стоимость:";
            // 
            // lblDateComing
            // 
            this.lblDateComing.AutoSize = true;
            this.lblDateComing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateComing.Location = new System.Drawing.Point(8, 107);
            this.lblDateComing.Name = "lblDateComing";
            this.lblDateComing.Size = new System.Drawing.Size(152, 24);
            this.lblDateComing.TabIndex = 41;
            this.lblDateComing.Text = "Дата прибытия:";
            // 
            // lblDatePlaced
            // 
            this.lblDatePlaced.AutoSize = true;
            this.lblDatePlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDatePlaced.Location = new System.Drawing.Point(8, 73);
            this.lblDatePlaced.Name = "lblDatePlaced";
            this.lblDatePlaced.Size = new System.Drawing.Size(175, 24);
            this.lblDatePlaced.TabIndex = 39;
            this.lblDatePlaced.Text = "Дата размещения:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblManufacturer.Location = new System.Drawing.Point(8, 39);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(158, 24);
            this.lblManufacturer.TabIndex = 37;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCustomer.Location = new System.Drawing.Point(8, 8);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(80, 24);
            this.lblCustomer.TabIndex = 35;
            this.lblCustomer.Text = "Клиент:";
            // 
            // ibtnCustomer
            // 
            this.ibtnCustomer.FlatAppearance.BorderSize = 0;
            this.ibtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnCustomer.IconColor = System.Drawing.Color.Black;
            this.ibtnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCustomer.IconSize = 25;
            this.ibtnCustomer.Location = new System.Drawing.Point(190, 10);
            this.ibtnCustomer.Name = "ibtnCustomer";
            this.ibtnCustomer.Size = new System.Drawing.Size(25, 25);
            this.ibtnCustomer.TabIndex = 45;
            this.ibtnCustomer.UseVisualStyleBackColor = true;
            // 
            // ibtnManufacturer
            // 
            this.ibtnManufacturer.FlatAppearance.BorderSize = 0;
            this.ibtnManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnManufacturer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnManufacturer.IconColor = System.Drawing.Color.Black;
            this.ibtnManufacturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnManufacturer.IconSize = 25;
            this.ibtnManufacturer.Location = new System.Drawing.Point(190, 41);
            this.ibtnManufacturer.Name = "ibtnManufacturer";
            this.ibtnManufacturer.Size = new System.Drawing.Size(25, 25);
            this.ibtnManufacturer.TabIndex = 46;
            this.ibtnManufacturer.UseVisualStyleBackColor = true;
            // 
            // lblDateComingValue
            // 
            this.lblDateComingValue.AutoSize = true;
            this.lblDateComingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateComingValue.Location = new System.Drawing.Point(186, 107);
            this.lblDateComingValue.Name = "lblDateComingValue";
            this.lblDateComingValue.Size = new System.Drawing.Size(44, 24);
            this.lblDateComingValue.TabIndex = 47;
            this.lblDateComingValue.Text = "Нет";
            // 
            // lblDatePlacedValue
            // 
            this.lblDatePlacedValue.AutoSize = true;
            this.lblDatePlacedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDatePlacedValue.Location = new System.Drawing.Point(186, 73);
            this.lblDatePlacedValue.Name = "lblDatePlacedValue";
            this.lblDatePlacedValue.Size = new System.Drawing.Size(44, 24);
            this.lblDatePlacedValue.TabIndex = 48;
            this.lblDatePlacedValue.Text = "Нет";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1068, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // ManufacturerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.gbCeilings);
            this.Controls.Add(this.panelInfo);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "ManufacturerOrderForm";
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.gbCeilings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeilings)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbCeilings;
        private System.Windows.Forms.DataGridView dgvCeilings;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDateComing;
        private System.Windows.Forms.Label lblDatePlaced;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDatePlacedValue;
        private System.Windows.Forms.Label lblDateComingValue;
        private FontAwesome.Sharp.IconButton ibtnManufacturer;
        private FontAwesome.Sharp.IconButton ibtnCustomer;
        private System.Windows.Forms.Button btnEdit;
    }
}