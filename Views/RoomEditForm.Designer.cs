using StretchCeilings.Helpers.Structs;

namespace StretchCeilings.Views
{
    partial class RoomEditForm
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.nudCorners = new System.Windows.Forms.NumericUpDown();
            this.lblCorners = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.gbPlane = new System.Windows.Forms.GroupBox();
            this.pbPlane = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorners)).BeginInit();
            this.gbPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 44);
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
            this.btnClose.Location = new System.Drawing.Point(862, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.gbPlane);
            this.panelBody.Controls.Add(this.panelInfo);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 44);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(900, 556);
            this.panelBody.TabIndex = 84;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.cbType);
            this.panelInfo.Controls.Add(this.nudArea);
            this.panelInfo.Controls.Add(this.nudCorners);
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
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(123, 35);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(161, 31);
            this.cbType.TabIndex = 20;
            // 
            // nudArea
            // 
            this.nudArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudArea.Location = new System.Drawing.Point(123, 3);
            this.nudArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(161, 29);
            this.nudArea.TabIndex = 19;
            this.nudArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCorners
            // 
            this.nudCorners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudCorners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCorners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudCorners.Location = new System.Drawing.Point(123, 70);
            this.nudCorners.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCorners.Name = "nudCorners";
            this.nudCorners.Size = new System.Drawing.Size(161, 29);
            this.nudCorners.TabIndex = 18;
            this.nudCorners.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCorners
            // 
            this.lblCorners.AutoSize = true;
            this.lblCorners.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblCorners.Location = new System.Drawing.Point(3, 73);
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
            this.lblType.Location = new System.Drawing.Point(3, 38);
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
            // gbPlane
            // 
            this.gbPlane.Controls.Add(this.pbPlane);
            this.gbPlane.Controls.Add(this.panelButton);
            this.gbPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlane.ForeColor = DraculaColor.Foreground;
            this.gbPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPlane.Location = new System.Drawing.Point(0, 100);
            this.gbPlane.Margin = new System.Windows.Forms.Padding(0);
            this.gbPlane.Name = "gbPlane";
            this.gbPlane.Padding = new System.Windows.Forms.Padding(0);
            this.gbPlane.Size = new System.Drawing.Size(900, 456);
            this.gbPlane.TabIndex = 6;
            this.gbPlane.TabStop = false;
            this.gbPlane.Text = "План";
            // 
            // pbPlane
            // 
            this.pbPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlane.Location = new System.Drawing.Point(0, 22);
            this.pbPlane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPlane.Name = "pbPlane";
            this.pbPlane.Size = new System.Drawing.Size(764, 434);
            this.pbPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlane.TabIndex = 9;
            this.pbPlane.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnChangePicture);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(764, 22);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(136, 434);
            this.panelButton.TabIndex = 8;
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnChangePicture.FlatAppearance.BorderSize = 0;
            this.btnChangePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePicture.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnChangePicture.ForeColor = System.Drawing.Color.White;
            this.btnChangePicture.Location = new System.Drawing.Point(8, 5);
            this.btnChangePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(120, 30);
            this.btnChangePicture.TabIndex = 44;
            this.btnChangePicture.Text = "Изменить";
            this.btnChangePicture.UseVisualStyleBackColor = false;
            // 
            // RoomEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomEditForm";
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorners)).EndInit();
            this.gbPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlane)).EndInit();
            this.panelButton.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.NumericUpDown nudCorners;
        private System.Windows.Forms.GroupBox gbPlane;
        private System.Windows.Forms.PictureBox pbPlane;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnChangePicture;
    }
}