
namespace stretch_ceilings_app.Forms
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
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.lblColorType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTexture = new System.Windows.Forms.Label();
            this.cbTexture = new System.Windows.Forms.ComboBox();
            this.cbColorType = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnSaveInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Location = new System.Drawing.Point(257, 120);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(120, 30);
            this.btnSaveInfo.TabIndex = 82;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            // 
            // lblColorType
            // 
            this.lblColorType.AutoSize = true;
            this.lblColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblColorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblColorType.Location = new System.Drawing.Point(12, 47);
            this.lblColorType.Name = "lblColorType";
            this.lblColorType.Size = new System.Drawing.Size(59, 24);
            this.lblColorType.TabIndex = 80;
            this.lblColorType.Text = "Цвет:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(12, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(164, 24);
            this.lblPrice.TabIndex = 78;
            this.lblPrice.Text = "Цена за кв. метр:";
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblTexture.Location = new System.Drawing.Point(12, 9);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Size = new System.Drawing.Size(90, 24);
            this.lblTexture.TabIndex = 74;
            this.lblTexture.Text = "Фактура:";
            // 
            // cbTexture
            // 
            this.cbTexture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTexture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTexture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTexture.FormattingEnabled = true;
            this.cbTexture.Location = new System.Drawing.Point(185, 6);
            this.cbTexture.Name = "cbTexture";
            this.cbTexture.Size = new System.Drawing.Size(192, 32);
            this.cbTexture.TabIndex = 84;
            // 
            // cbColorType
            // 
            this.cbColorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbColorType.FormattingEnabled = true;
            this.cbColorType.Location = new System.Drawing.Point(185, 44);
            this.cbColorType.Name = "cbColorType";
            this.cbColorType.Size = new System.Drawing.Size(192, 32);
            this.cbColorType.TabIndex = 85;
            // 
            // nudPrice
            // 
            this.nudPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nudPrice.Location = new System.Drawing.Point(185, 82);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(192, 29);
            this.nudPrice.TabIndex = 86;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CeilingFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.cbColorType);
            this.Controls.Add(this.cbTexture);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.lblColorType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTexture);
            this.Name = "CeilingFormEdit";
            this.Text = "Производитель \"Pongs\"";
            this.Load += new System.EventHandler(this.CeilingFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Label lblColorType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTexture;
        private System.Windows.Forms.ComboBox cbTexture;
        private System.Windows.Forms.ComboBox cbColorType;
        private System.Windows.Forms.NumericUpDown nudPrice;
    }
}