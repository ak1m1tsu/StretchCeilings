
namespace StretchCeilings.Views
{
    partial class RoomForm
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.pbPlane = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCornersValue = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblAreaValue = new System.Windows.Forms.Label();
            this.lblCorners = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(700, 25);
            this.panelTop.TabIndex = 79;
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
            this.btnClose.Location = new System.Drawing.Point(675, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.pbPlane);
            this.panelBody.Controls.Add(this.panelInfo);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(700, 575);
            this.panelBody.TabIndex = 80;
            // 
            // pbPlane
            // 
            this.pbPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlane.Location = new System.Drawing.Point(0, 100);
            this.pbPlane.Name = "pbPlane";
            this.pbPlane.Size = new System.Drawing.Size(700, 475);
            this.pbPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlane.TabIndex = 6;
            this.pbPlane.TabStop = false;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblCornersValue);
            this.panelInfo.Controls.Add(this.lblTypeValue);
            this.panelInfo.Controls.Add(this.lblAreaValue);
            this.panelInfo.Controls.Add(this.lblCorners);
            this.panelInfo.Controls.Add(this.lblType);
            this.panelInfo.Controls.Add(this.lblArea);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Font = new System.Drawing.Font("Open Sans", 12F);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(700, 100);
            this.panelInfo.TabIndex = 5;
            // 
            // lblCornersValue
            // 
            this.lblCornersValue.AutoSize = true;
            this.lblCornersValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCornersValue.Location = new System.Drawing.Point(116, 63);
            this.lblCornersValue.Name = "lblCornersValue";
            this.lblCornersValue.Size = new System.Drawing.Size(19, 23);
            this.lblCornersValue.TabIndex = 20;
            this.lblCornersValue.Text = "4";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTypeValue.Location = new System.Drawing.Point(116, 33);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(39, 23);
            this.lblTypeValue.TabIndex = 19;
            this.lblTypeValue.Text = "Нет";
            // 
            // lblAreaValue
            // 
            this.lblAreaValue.AutoSize = true;
            this.lblAreaValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblAreaValue.Location = new System.Drawing.Point(116, 3);
            this.lblAreaValue.Name = "lblAreaValue";
            this.lblAreaValue.Size = new System.Drawing.Size(19, 23);
            this.lblAreaValue.TabIndex = 18;
            this.lblAreaValue.Text = "0";
            // 
            // lblCorners
            // 
            this.lblCorners.AutoSize = true;
            this.lblCorners.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCorners.Location = new System.Drawing.Point(3, 63);
            this.lblCorners.Name = "lblCorners";
            this.lblCorners.Size = new System.Drawing.Size(114, 23);
            this.lblCorners.TabIndex = 17;
            this.lblCorners.Text = "Кол-во углов:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblType.Location = new System.Drawing.Point(3, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 23);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Тип:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblArea.Location = new System.Drawing.Point(3, 3);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(86, 23);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Площадь:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblCorners;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.PictureBox pbPlane;
        private System.Windows.Forms.Label lblCornersValue;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblAreaValue;
    }
}