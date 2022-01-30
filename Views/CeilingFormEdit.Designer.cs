
namespace StretchCeilings.Views
{
    partial class CeilingFormEdit
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
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.cbColorType = new System.Windows.Forms.ComboBox();
            this.cbTexture = new System.Windows.Forms.ComboBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.lblColorType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTexture = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 25);
            this.panelTop.TabIndex = 87;
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
            this.btnClose.Location = new System.Drawing.Point(375, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // nudPrice
            // 
            this.nudPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.nudPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudPrice.Location = new System.Drawing.Point(239, 96);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(155, 29);
            this.nudPrice.TabIndex = 94;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbColorType
            // 
            this.cbColorType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbColorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColorType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbColorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbColorType.FormattingEnabled = true;
            this.cbColorType.Location = new System.Drawing.Point(165, 62);
            this.cbColorType.Name = "cbColorType";
            this.cbColorType.Size = new System.Drawing.Size(229, 31);
            this.cbColorType.TabIndex = 93;
            // 
            // cbTexture
            // 
            this.cbTexture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbTexture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTexture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTexture.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbTexture.FormattingEnabled = true;
            this.cbTexture.Location = new System.Drawing.Point(165, 28);
            this.cbTexture.Name = "cbTexture";
            this.cbTexture.Size = new System.Drawing.Size(229, 31);
            this.cbTexture.TabIndex = 92;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSaveInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Location = new System.Drawing.Point(274, 164);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(120, 30);
            this.btnSaveInfo.TabIndex = 91;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // lblColorType
            // 
            this.lblColorType.AutoSize = true;
            this.lblColorType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblColorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblColorType.Location = new System.Drawing.Point(4, 64);
            this.lblColorType.Name = "lblColorType";
            this.lblColorType.Size = new System.Drawing.Size(52, 23);
            this.lblColorType.TabIndex = 90;
            this.lblColorType.Text = "Цвет:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(4, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(143, 23);
            this.lblPrice.TabIndex = 89;
            this.lblPrice.Text = "Цена за кв. метр:";
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblTexture.Location = new System.Drawing.Point(4, 30);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Size = new System.Drawing.Size(79, 23);
            this.lblTexture.TabIndex = 88;
            this.lblTexture.Text = "Фактура:";
            // 
            // CeilingFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.cbColorType);
            this.Controls.Add(this.cbTexture);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.lblColorType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTexture);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CeilingFormEdit";
            this.Text = "Производитель \"Pongs\"";
            this.Load += new System.EventHandler(this.CeilingFormEdit_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.ComboBox cbColorType;
        private System.Windows.Forms.ComboBox cbTexture;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Label lblColorType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTexture;
    }
}