
namespace stretch_ceilings_app.Forms
{
    partial class CeilingForm
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
            this.lblTextureValue = new System.Windows.Forms.Label();
            this.lblTexture = new System.Windows.Forms.Label();
            this.lblColorTypeValue = new System.Windows.Forms.Label();
            this.lblColorType = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextureValue
            // 
            this.lblTextureValue.AutoSize = true;
            this.lblTextureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTextureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblTextureValue.Location = new System.Drawing.Point(185, 9);
            this.lblTextureValue.Name = "lblTextureValue";
            this.lblTextureValue.Size = new System.Drawing.Size(109, 24);
            this.lblTextureValue.TabIndex = 66;
            this.lblTextureValue.Text = "Глянцевый";
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblTexture.Location = new System.Drawing.Point(12, 9);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Size = new System.Drawing.Size(90, 24);
            this.lblTexture.TabIndex = 65;
            this.lblTexture.Text = "Фактура:";
            // 
            // lblColorTypeValue
            // 
            this.lblColorTypeValue.AutoSize = true;
            this.lblColorTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblColorTypeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblColorTypeValue.Location = new System.Drawing.Point(185, 47);
            this.lblColorTypeValue.Name = "lblColorTypeValue";
            this.lblColorTypeValue.Size = new System.Drawing.Size(87, 24);
            this.lblColorTypeValue.TabIndex = 72;
            this.lblColorTypeValue.Text = "Цветной";
            // 
            // lblColorType
            // 
            this.lblColorType.AutoSize = true;
            this.lblColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblColorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblColorType.Location = new System.Drawing.Point(12, 47);
            this.lblColorType.Name = "lblColorType";
            this.lblColorType.Size = new System.Drawing.Size(59, 24);
            this.lblColorType.TabIndex = 71;
            this.lblColorType.Text = "Цвет:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(185, 84);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(106, 24);
            this.lblPriceValue.TabIndex = 70;
            this.lblPriceValue.Text = "390.00 руб.";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(12, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(164, 24);
            this.lblPrice.TabIndex = 69;
            this.lblPrice.Text = "Цена за кв. метр:";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnEditInfo.FlatAppearance.BorderSize = 0;
            this.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEditInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditInfo.Location = new System.Drawing.Point(267, 120);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(110, 30);
            this.btnEditInfo.TabIndex = 73;
            this.btnEditInfo.Text = "Изменить";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // CeilingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.lblColorTypeValue);
            this.Controls.Add(this.lblColorType);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTextureValue);
            this.Controls.Add(this.lblTexture);
            this.Name = "CeilingForm";
            this.Text = "Производитель \"Pongs\"";
            this.Load += new System.EventHandler(this.CeilingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTextureValue;
        private System.Windows.Forms.Label lblTexture;
        private System.Windows.Forms.Label lblColorTypeValue;
        private System.Windows.Forms.Label lblColorType;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnEditInfo;
    }
}