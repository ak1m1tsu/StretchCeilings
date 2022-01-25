
namespace stretch_ceilings_app.Forms
{
    partial class ManufacturerFormEdit
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
            this.gbCeilings = new System.Windows.Forms.GroupBox();
            this.dgvCeilings = new System.Windows.Forms.DataGridView();
            this.panelPages = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCeiling = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbCuntry = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCuntry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbCeilings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeilings)).BeginInit();
            this.panelPages.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCeilings
            // 
            this.gbCeilings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.gbCeilings.Controls.Add(this.dgvCeilings);
            this.gbCeilings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCeilings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCeilings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gbCeilings.Location = new System.Drawing.Point(0, 115);
            this.gbCeilings.Name = "gbCeilings";
            this.gbCeilings.Size = new System.Drawing.Size(1084, 456);
            this.gbCeilings.TabIndex = 62;
            this.gbCeilings.TabStop = false;
            this.gbCeilings.Text = "Потолки";
            // 
            // dgvCeilings
            // 
            this.dgvCeilings.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCeilings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCeilings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCeilings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCeilings.Location = new System.Drawing.Point(3, 25);
            this.dgvCeilings.Name = "dgvCeilings";
            this.dgvCeilings.RowTemplate.Height = 25;
            this.dgvCeilings.Size = new System.Drawing.Size(1078, 428);
            this.dgvCeilings.TabIndex = 0;
            // 
            // panelPages
            // 
            this.panelPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(69)))), ((int)(((byte)(145)))));
            this.panelPages.Controls.Add(this.btnPrevious);
            this.panelPages.Controls.Add(this.tbPages);
            this.panelPages.Controls.Add(this.btnNext);
            this.panelPages.Controls.Add(this.btnAddCeiling);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPages.Location = new System.Drawing.Point(0, 571);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1084, 40);
            this.panelPages.TabIndex = 61;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Black;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(3, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 29);
            this.btnPrevious.TabIndex = 75;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // tbPages
            // 
            this.tbPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPages.Location = new System.Drawing.Point(39, 5);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(80, 29);
            this.tbPages.TabIndex = 74;
            this.tbPages.Text = "1";
            this.tbPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(125, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 29);
            this.btnNext.TabIndex = 73;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnAddCeiling
            // 
            this.btnAddCeiling.BackColor = System.Drawing.Color.Black;
            this.btnAddCeiling.FlatAppearance.BorderSize = 0;
            this.btnAddCeiling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCeiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAddCeiling.ForeColor = System.Drawing.Color.White;
            this.btnAddCeiling.Location = new System.Drawing.Point(969, 3);
            this.btnAddCeiling.Name = "btnAddCeiling";
            this.btnAddCeiling.Size = new System.Drawing.Size(110, 30);
            this.btnAddCeiling.TabIndex = 54;
            this.btnAddCeiling.Text = "Добавить";
            this.btnAddCeiling.UseVisualStyleBackColor = false;
            this.btnAddCeiling.Click += new System.EventHandler(this.btnAddCeiling_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(69)))), ((int)(((byte)(145)))));
            this.panelInfo.Controls.Add(this.tbName);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.tbCuntry);
            this.panelInfo.Controls.Add(this.tbAddress);
            this.panelInfo.Controls.Add(this.btnSave);
            this.panelInfo.Controls.Add(this.lblCuntry);
            this.panelInfo.Controls.Add(this.lblAddress);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1084, 115);
            this.panelInfo.TabIndex = 63;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbName.Location = new System.Drawing.Point(117, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 29);
            this.tbName.TabIndex = 57;
            this.tbName.Text = "Pongs";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 24);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Название:";
            // 
            // tbCuntry
            // 
            this.tbCuntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbCuntry.Location = new System.Drawing.Point(117, 41);
            this.tbCuntry.Name = "tbCuntry";
            this.tbCuntry.Size = new System.Drawing.Size(206, 29);
            this.tbCuntry.TabIndex = 55;
            this.tbCuntry.Text = "Германия";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbAddress.Location = new System.Drawing.Point(117, 76);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(393, 29);
            this.tbAddress.TabIndex = 54;
            this.tbAddress.Text = "Bahnhofstraße 21 7919 Pausa-Mühltroff";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(959, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblCuntry
            // 
            this.lblCuntry.AutoSize = true;
            this.lblCuntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCuntry.Location = new System.Drawing.Point(9, 44);
            this.lblCuntry.Name = "lblCuntry";
            this.lblCuntry.Size = new System.Drawing.Size(80, 24);
            this.lblCuntry.TabIndex = 49;
            this.lblCuntry.Text = "Страна:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(9, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 24);
            this.lblAddress.TabIndex = 51;
            this.lblAddress.Text = "Адрес:";
            // 
            // ManufacturerFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.gbCeilings);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.panelInfo);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "ManufacturerFormEdit";
            this.gbCeilings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeilings)).EndInit();
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCeilings;
        private System.Windows.Forms.DataGridView dgvCeilings;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCeiling;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbCuntry;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCuntry;
        private System.Windows.Forms.Label lblAddress;
    }
}