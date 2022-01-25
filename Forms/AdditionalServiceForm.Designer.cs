
namespace stretch_ceilings_app.Forms
{
    partial class AdditionalServiceForm
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
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblNameValue.Location = new System.Drawing.Point(121, 9);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(44, 24);
            this.lblNameValue.TabIndex = 54;
            this.lblNameValue.Text = "Нет";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 24);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Название:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(12, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 55;
            this.lblPrice.Text = "Цена:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblPriceValue.Location = new System.Drawing.Point(121, 47);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(86, 24);
            this.lblPriceValue.TabIndex = 56;
            this.lblPriceValue.Text = "0.00 руб.";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(258, 122);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 30);
            this.btnChange.TabIndex = 67;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // AdditionalServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblName);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "AdditionalServiceForm";
            this.Load += new System.EventHandler(this.AdditionalServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Button btnChange;
    }
}