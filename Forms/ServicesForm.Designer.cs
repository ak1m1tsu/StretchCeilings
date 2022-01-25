
namespace stretch_ceilings_app.Forms
{
    partial class ServicesForm
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
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.panelPages = new System.Windows.Forms.Panel();
            this.btnPrevios = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelUserButtons = new System.Windows.Forms.Panel();
            this.panelFilterButtons = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCeiling = new System.Windows.Forms.Label();
            this.cbCeiling = new System.Windows.Forms.ComboBox();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.nudTotalTo = new System.Windows.Forms.NumericUpDown();
            this.nudTotalFrom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelPages.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelFilterButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(0, 114);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowTemplate.Height = 25;
            this.dgvServices.Size = new System.Drawing.Size(1054, 409);
            this.dgvServices.TabIndex = 13;
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.cbRows);
            this.panelPages.Controls.Add(this.btnPrevios);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNext);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 523);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1054, 38);
            this.panelPages.TabIndex = 12;
            // 
            // btnPrevios
            // 
            this.btnPrevios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnPrevios.FlatAppearance.BorderSize = 0;
            this.btnPrevios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPrevios.ForeColor = System.Drawing.Color.White;
            this.btnPrevios.Location = new System.Drawing.Point(6, 4);
            this.btnPrevios.Name = "btnPrevios";
            this.btnPrevios.Size = new System.Drawing.Size(30, 29);
            this.btnPrevios.TabIndex = 90;
            this.btnPrevios.Text = "<";
            this.btnPrevios.UseVisualStyleBackColor = false;
            // 
            // tbPages
            // 
            this.tbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.tbPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.tbPages.Location = new System.Drawing.Point(42, 4);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 89;
            this.tbPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(128, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 29);
            this.btnNext.TabIndex = 88;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.nudTotalTo);
            this.panelFilters.Controls.Add(this.nudTotalFrom);
            this.panelFilters.Controls.Add(this.lblCeiling);
            this.panelFilters.Controls.Add(this.cbCeiling);
            this.panelFilters.Controls.Add(this.cbManufacturer);
            this.panelFilters.Controls.Add(this.lblManufacturer);
            this.panelFilters.Controls.Add(this.lblPriceTo);
            this.panelFilters.Controls.Add(this.lblPriceFrom);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1054, 114);
            this.panelFilters.TabIndex = 11;
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceTo.Location = new System.Drawing.Point(297, 83);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Size = new System.Drawing.Size(38, 24);
            this.lblPriceTo.TabIndex = 41;
            this.lblPriceTo.Text = "до:";
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceFrom.Location = new System.Drawing.Point(12, 82);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Size = new System.Drawing.Size(85, 24);
            this.lblPriceFrom.TabIndex = 39;
            this.lblPriceFrom.Text = "Цена от:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelUserButtons);
            this.panelButtons.Controls.Add(this.panelFilterButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(1054, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(130, 561);
            this.panelButtons.TabIndex = 10;
            // 
            // panelUserButtons
            // 
            this.panelUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserButtons.Location = new System.Drawing.Point(0, 114);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.Size = new System.Drawing.Size(130, 447);
            this.panelUserButtons.TabIndex = 2;
            // 
            // panelFilterButtons
            // 
            this.panelFilterButtons.Controls.Add(this.button3);
            this.panelFilterButtons.Controls.Add(this.button2);
            this.panelFilterButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterButtons.Location = new System.Drawing.Point(0, 0);
            this.panelFilterButtons.Name = "panelFilterButtons";
            this.panelFilterButtons.Size = new System.Drawing.Size(130, 114);
            this.panelFilterButtons.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.Location = new System.Drawing.Point(0, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сбросить";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Применить";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblCeiling
            // 
            this.lblCeiling.AutoSize = true;
            this.lblCeiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCeiling.Location = new System.Drawing.Point(12, 46);
            this.lblCeiling.Name = "lblCeiling";
            this.lblCeiling.Size = new System.Drawing.Size(90, 24);
            this.lblCeiling.TabIndex = 64;
            this.lblCeiling.Text = "Потолок:";
            // 
            // cbCeiling
            // 
            this.cbCeiling.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbCeiling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCeiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbCeiling.FormattingEnabled = true;
            this.cbCeiling.Location = new System.Drawing.Point(176, 44);
            this.cbCeiling.Name = "cbCeiling";
            this.cbCeiling.Size = new System.Drawing.Size(287, 32);
            this.cbCeiling.TabIndex = 63;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.AutoCompleteCustomSource.AddRange(new string[] {
            "Ожидает ответа клиента",
            "Ожидает выполнения работ",
            "Ожидает результатов замеров",
            "Отменен",
            "Завершен"});
            this.cbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(176, 6);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(287, 32);
            this.cbManufacturer.TabIndex = 62;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblManufacturer.Location = new System.Drawing.Point(12, 9);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(158, 24);
            this.lblManufacturer.TabIndex = 61;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // cbRows
            // 
            this.cbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Location = new System.Drawing.Point(993, 3);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(55, 32);
            this.cbRows.TabIndex = 98;
            // 
            // nudTotalTo
            // 
            this.nudTotalTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalTo.Location = new System.Drawing.Point(341, 81);
            this.nudTotalTo.Name = "nudTotalTo";
            this.nudTotalTo.Size = new System.Drawing.Size(122, 29);
            this.nudTotalTo.TabIndex = 97;
            this.nudTotalTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudTotalFrom
            // 
            this.nudTotalFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTotalFrom.Location = new System.Drawing.Point(176, 81);
            this.nudTotalFrom.Name = "nudTotalFrom";
            this.nudTotalFrom.Size = new System.Drawing.Size(115, 29);
            this.nudTotalFrom.TabIndex = 96;
            this.nudTotalFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelButtons);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.MinimumSize = new System.Drawing.Size(1053, 600);
            this.Name = "ServicesForm";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelFilterButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnPrevios;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblPriceTo;
        private System.Windows.Forms.Label lblPriceFrom;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelUserButtons;
        private System.Windows.Forms.Panel panelFilterButtons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCeiling;
        private System.Windows.Forms.ComboBox cbCeiling;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.NumericUpDown nudTotalTo;
        private System.Windows.Forms.NumericUpDown nudTotalFrom;
    }
}