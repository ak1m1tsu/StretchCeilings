﻿
namespace StretchCeilings.UI.Views
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblColorTypeValue = new System.Windows.Forms.Label();
            this.lblColorType = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTextureValue = new System.Windows.Forms.Label();
            this.lblTexture = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
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
            this.panelTop.TabIndex = 88;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
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
            // lblColorTypeValue
            // 
            this.lblColorTypeValue.AutoSize = true;
            this.lblColorTypeValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblColorTypeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblColorTypeValue.Location = new System.Drawing.Point(152, 64);
            this.lblColorTypeValue.Name = "lblColorTypeValue";
            this.lblColorTypeValue.Size = new System.Drawing.Size(39, 23);
            this.lblColorTypeValue.TabIndex = 94;
            this.lblColorTypeValue.Text = "Нет";
            // 
            // lblColorType
            // 
            this.lblColorType.AutoSize = true;
            this.lblColorType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblColorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblColorType.Location = new System.Drawing.Point(4, 64);
            this.lblColorType.Name = "lblColorType";
            this.lblColorType.Size = new System.Drawing.Size(52, 23);
            this.lblColorType.TabIndex = 93;
            this.lblColorType.Text = "Цвет:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(152, 98);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(41, 23);
            this.lblPriceValue.TabIndex = 92;
            this.lblPriceValue.Text = "0.00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(4, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(143, 23);
            this.lblPrice.TabIndex = 91;
            this.lblPrice.Text = "Цена за кв. метр:";
            // 
            // lblTextureValue
            // 
            this.lblTextureValue.AutoSize = true;
            this.lblTextureValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTextureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblTextureValue.Location = new System.Drawing.Point(152, 30);
            this.lblTextureValue.Name = "lblTextureValue";
            this.lblTextureValue.Size = new System.Drawing.Size(39, 23);
            this.lblTextureValue.TabIndex = 90;
            this.lblTextureValue.Text = "Нет";
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTexture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblTexture.Location = new System.Drawing.Point(4, 30);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Size = new System.Drawing.Size(79, 23);
            this.lblTexture.TabIndex = 89;
            this.lblTexture.Text = "Фактура:";
            // 
            // CeilingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblColorTypeValue);
            this.Controls.Add(this.lblColorType);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTextureValue);
            this.Controls.Add(this.lblTexture);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CeilingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Производитель \"Pongs\"";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblColorTypeValue;
        private System.Windows.Forms.Label lblColorType;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTextureValue;
        private System.Windows.Forms.Label lblTexture;
    }
}