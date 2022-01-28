namespace StretchCeilingsApp.Forms
{
    partial class RoomFormEdit
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCorners = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.pbPlane = new System.Windows.Forms.PictureBox();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.panelTop.TabIndex = 83;
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
            this.panelBody.Controls.Add(this.panelButton);
            this.panelBody.Controls.Add(this.panelInfo);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(700, 575);
            this.panelBody.TabIndex = 84;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.comboBox1);
            this.panelInfo.Controls.Add(this.numericUpDown2);
            this.panelInfo.Controls.Add(this.numericUpDown1);
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
            // lblCorners
            // 
            this.lblCorners.AutoSize = true;
            this.lblCorners.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCorners.Location = new System.Drawing.Point(3, 66);
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
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(86, 23);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Площадь:";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnChangePicture);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(570, 100);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(130, 475);
            this.panelButton.TabIndex = 6;
            // 
            // pbPlane
            // 
            this.pbPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlane.Location = new System.Drawing.Point(0, 100);
            this.pbPlane.Name = "pbPlane";
            this.pbPlane.Size = new System.Drawing.Size(570, 475);
            this.pbPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlane.TabIndex = 7;
            this.pbPlane.TabStop = false;
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnChangePicture.FlatAppearance.BorderSize = 0;
            this.btnChangePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePicture.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnChangePicture.ForeColor = System.Drawing.Color.White;
            this.btnChangePicture.Location = new System.Drawing.Point(5, 6);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(120, 30);
            this.btnChangePicture.TabIndex = 44;
            this.btnChangePicture.Text = "Изменить";
            this.btnChangePicture.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.numericUpDown1.Location = new System.Drawing.Point(123, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(198, 29);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.numericUpDown2.Location = new System.Drawing.Point(123, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(198, 29);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 31);
            this.comboBox1.TabIndex = 20;
            // 
            // RoomFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomFormEdit";
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}