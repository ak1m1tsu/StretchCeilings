﻿namespace StretchCeilings.UI.Views
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
            this.gbPlane = new System.Windows.Forms.GroupBox();
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
            this.gbPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 25);
            this.panelTop.TabIndex = 79;
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
            this.btnClose.Location = new System.Drawing.Point(862, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.gbPlane);
            this.panelBody.Controls.Add(this.panelInfo);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelBody.Location = new System.Drawing.Point(0, 25);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(900, 575);
            this.panelBody.TabIndex = 80;
            // 
            // gbPlane
            // 
            this.gbPlane.Controls.Add(this.pbPlane);
            this.gbPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPlane.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.gbPlane.Location = new System.Drawing.Point(0, 100);
            this.gbPlane.Margin = new System.Windows.Forms.Padding(0);
            this.gbPlane.Name = "gbPlane";
            this.gbPlane.Padding = new System.Windows.Forms.Padding(0);
            this.gbPlane.Size = new System.Drawing.Size(900, 475);
            this.gbPlane.TabIndex = 22;
            this.gbPlane.TabStop = false;
            this.gbPlane.Text = "План";
            // 
            // pbPlane
            // 
            this.pbPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlane.Location = new System.Drawing.Point(0, 22);
            this.pbPlane.Margin = new System.Windows.Forms.Padding(0);
            this.pbPlane.Name = "pbPlane";
            this.pbPlane.Size = new System.Drawing.Size(900, 453);
            this.pbPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlane.TabIndex = 7;
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
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(900, 100);
            this.panelInfo.TabIndex = 5;
            // 
            // lblCornersValue
            // 
            this.lblCornersValue.AutoSize = true;
            this.lblCornersValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCornersValue.Location = new System.Drawing.Point(123, 66);
            this.lblCornersValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCornersValue.Name = "lblCornersValue";
            this.lblCornersValue.Size = new System.Drawing.Size(19, 23);
            this.lblCornersValue.TabIndex = 20;
            this.lblCornersValue.Text = "0";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTypeValue.Location = new System.Drawing.Point(123, 36);
            this.lblTypeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(39, 23);
            this.lblTypeValue.TabIndex = 19;
            this.lblTypeValue.Text = "Нет";
            // 
            // lblAreaValue
            // 
            this.lblAreaValue.AutoSize = true;
            this.lblAreaValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblAreaValue.Location = new System.Drawing.Point(123, 6);
            this.lblAreaValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaValue.Name = "lblAreaValue";
            this.lblAreaValue.Size = new System.Drawing.Size(19, 23);
            this.lblAreaValue.TabIndex = 18;
            this.lblAreaValue.Text = "0";
            // 
            // lblCorners
            // 
            this.lblCorners.AutoSize = true;
            this.lblCorners.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCorners.Location = new System.Drawing.Point(3, 66);
            this.lblCorners.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorners.Name = "lblCorners";
            this.lblCorners.Size = new System.Drawing.Size(114, 23);
            this.lblCorners.TabIndex = 17;
            this.lblCorners.Text = "Кол-во углов:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblType.Location = new System.Drawing.Point(3, 36);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 23);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Тип:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblArea.Location = new System.Drawing.Point(3, 6);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(86, 23);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Площадь:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.gbPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox gbPlane;
        private System.Windows.Forms.PictureBox pbPlane;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblCornersValue;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblAreaValue;
        private System.Windows.Forms.Label lblCorners;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblArea;
    }
}