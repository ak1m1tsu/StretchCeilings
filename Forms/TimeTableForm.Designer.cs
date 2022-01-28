
namespace StretchCeilingsApp.Forms
{
    partial class TimeTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.panelRepeat = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSu = new System.Windows.Forms.CheckBox();
            this.cbTh = new System.Windows.Forms.CheckBox();
            this.cbWe = new System.Windows.Forms.CheckBox();
            this.cbSa = new System.Windows.Forms.CheckBox();
            this.cbTu = new System.Windows.Forms.CheckBox();
            this.cbFr = new System.Windows.Forms.CheckBox();
            this.cbMo = new System.Windows.Forms.CheckBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.nudWeeksValue = new System.Windows.Forms.NumericUpDown();
            this.dtpEndValue = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.dtpDateValue = new System.Windows.Forms.DateTimePicker();
            this.dtpStartValue = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.panelTopSide.SuspendLayout();
            this.panelRepeat.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeksValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 28);
            this.panelTop.TabIndex = 78;
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
            this.btnClose.Location = new System.Drawing.Point(275, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panelTopSide
            // 
            this.panelTopSide.Controls.Add(this.btnSave);
            this.panelTopSide.Controls.Add(this.panelRepeat);
            this.panelTopSide.Controls.Add(this.dtpEndValue);
            this.panelTopSide.Controls.Add(this.lblDate);
            this.panelTopSide.Controls.Add(this.cbRepeat);
            this.panelTopSide.Controls.Add(this.dtpDateValue);
            this.panelTopSide.Controls.Add(this.dtpStartValue);
            this.panelTopSide.Controls.Add(this.lblEnd);
            this.panelTopSide.Controls.Add(this.lblStart);
            this.panelTopSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelTopSide.Location = new System.Drawing.Point(0, 28);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(300, 292);
            this.panelTopSide.TabIndex = 79;
            // 
            // panelRepeat
            // 
            this.panelRepeat.Controls.Add(this.panelBody);
            this.panelRepeat.Controls.Add(this.panelTitle);
            this.panelRepeat.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelRepeat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelRepeat.Location = new System.Drawing.Point(0, 149);
            this.panelRepeat.Name = "panelRepeat";
            this.panelRepeat.Size = new System.Drawing.Size(300, 143);
            this.panelRepeat.TabIndex = 28;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.cbSu);
            this.panelBody.Controls.Add(this.cbTh);
            this.panelBody.Controls.Add(this.cbWe);
            this.panelBody.Controls.Add(this.cbSa);
            this.panelBody.Controls.Add(this.cbTu);
            this.panelBody.Controls.Add(this.cbFr);
            this.panelBody.Controls.Add(this.cbMo);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 44);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(300, 99);
            this.panelBody.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Дни для повторения:";
            // 
            // cbSu
            // 
            this.cbSu.AutoSize = true;
            this.cbSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSu.Location = new System.Drawing.Point(184, 65);
            this.cbSu.Name = "cbSu";
            this.cbSu.Size = new System.Drawing.Size(48, 28);
            this.cbSu.TabIndex = 27;
            this.cbSu.Text = "Вс";
            this.cbSu.UseVisualStyleBackColor = true;
            // 
            // cbTh
            // 
            this.cbTh.AutoSize = true;
            this.cbTh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbTh.Location = new System.Drawing.Point(214, 33);
            this.cbTh.Name = "cbTh";
            this.cbTh.Size = new System.Drawing.Size(48, 28);
            this.cbTh.TabIndex = 24;
            this.cbTh.Text = "Чв";
            this.cbTh.UseVisualStyleBackColor = true;
            // 
            // cbWe
            // 
            this.cbWe.AutoSize = true;
            this.cbWe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbWe.Location = new System.Drawing.Point(157, 33);
            this.cbWe.Name = "cbWe";
            this.cbWe.Size = new System.Drawing.Size(50, 28);
            this.cbWe.TabIndex = 23;
            this.cbWe.Text = "Ср";
            this.cbWe.UseVisualStyleBackColor = true;
            // 
            // cbSa
            // 
            this.cbSa.AutoSize = true;
            this.cbSa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSa.Location = new System.Drawing.Point(126, 65);
            this.cbSa.Name = "cbSa";
            this.cbSa.Size = new System.Drawing.Size(50, 28);
            this.cbSa.TabIndex = 26;
            this.cbSa.Text = "Сб";
            this.cbSa.UseVisualStyleBackColor = true;
            // 
            // cbTu
            // 
            this.cbTu.AutoSize = true;
            this.cbTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbTu.Location = new System.Drawing.Point(103, 33);
            this.cbTu.Name = "cbTu";
            this.cbTu.Size = new System.Drawing.Size(48, 28);
            this.cbTu.TabIndex = 22;
            this.cbTu.Text = "Вт";
            this.cbTu.UseVisualStyleBackColor = true;
            // 
            // cbFr
            // 
            this.cbFr.AutoSize = true;
            this.cbFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbFr.Location = new System.Drawing.Point(70, 65);
            this.cbFr.Name = "cbFr";
            this.cbFr.Size = new System.Drawing.Size(49, 28);
            this.cbFr.TabIndex = 25;
            this.cbFr.Text = "Пт";
            this.cbFr.UseVisualStyleBackColor = true;
            // 
            // cbMo
            // 
            this.cbMo.AutoSize = true;
            this.cbMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbMo.Location = new System.Drawing.Point(46, 33);
            this.cbMo.Name = "cbMo";
            this.cbMo.Size = new System.Drawing.Size(50, 28);
            this.cbMo.TabIndex = 21;
            this.cbMo.Text = "Пн";
            this.cbMo.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblWeeks);
            this.panelTitle.Controls.Add(this.nudWeeksValue);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(300, 44);
            this.panelTitle.TabIndex = 30;
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblWeeks.Location = new System.Drawing.Point(6, 7);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(201, 23);
            this.lblWeeks.TabIndex = 28;
            this.lblWeeks.Text = "Недель для повторения:";
            // 
            // nudWeeksValue
            // 
            this.nudWeeksValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.nudWeeksValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.nudWeeksValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.nudWeeksValue.Location = new System.Drawing.Point(239, 5);
            this.nudWeeksValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeeksValue.Name = "nudWeeksValue";
            this.nudWeeksValue.Size = new System.Drawing.Size(49, 29);
            this.nudWeeksValue.TabIndex = 29;
            this.nudWeeksValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpEndValue
            // 
            this.dtpEndValue.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpEndValue.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dtpEndValue.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dtpEndValue.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpEndValue.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpEndValue.CustomFormat = "H:mm";
            this.dtpEndValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpEndValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndValue.Location = new System.Drawing.Point(96, 72);
            this.dtpEndValue.Name = "dtpEndValue";
            this.dtpEndValue.ShowUpDown = true;
            this.dtpEndValue.Size = new System.Drawing.Size(63, 29);
            this.dtpEndValue.TabIndex = 24;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDate.Location = new System.Drawing.Point(5, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 23);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Дата:";
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRepeat.Font = new System.Drawing.Font("Open Sans", 12F);
            this.cbRepeat.Location = new System.Drawing.Point(9, 107);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(112, 27);
            this.cbRepeat.TabIndex = 27;
            this.cbRepeat.Text = "Повторить";
            this.cbRepeat.UseVisualStyleBackColor = true;
            // 
            // dtpDateValue
            // 
            this.dtpDateValue.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDateValue.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDateValue.CustomFormat = "dd.MM.yyyy";
            this.dtpDateValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateValue.Location = new System.Drawing.Point(96, 3);
            this.dtpDateValue.Name = "dtpDateValue";
            this.dtpDateValue.Size = new System.Drawing.Size(111, 29);
            this.dtpDateValue.TabIndex = 19;
            // 
            // dtpStartValue
            // 
            this.dtpStartValue.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpStartValue.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dtpStartValue.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dtpStartValue.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpStartValue.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpStartValue.CustomFormat = "H:mm";
            this.dtpStartValue.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpStartValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartValue.Location = new System.Drawing.Point(96, 37);
            this.dtpStartValue.Name = "dtpStartValue";
            this.dtpStartValue.ShowUpDown = true;
            this.dtpStartValue.Size = new System.Drawing.Size(63, 29);
            this.dtpStartValue.TabIndex = 22;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblEnd.Location = new System.Drawing.Point(5, 75);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(63, 23);
            this.lblEnd.TabIndex = 23;
            this.lblEnd.Text = "Конец:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblStart.Location = new System.Drawing.Point(5, 40);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(73, 23);
            this.lblStart.TabIndex = 20;
            this.lblStart.Text = "Начало:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(266, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 29;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.panelTopSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 320);
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "TimeTableForm";
            this.panelTop.ResumeLayout(false);
            this.panelTopSide.ResumeLayout(false);
            this.panelTopSide.PerformLayout();
            this.panelRepeat.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeksValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelTopSide;
        private System.Windows.Forms.DateTimePicker dtpEndValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateValue;
        private System.Windows.Forms.DateTimePicker dtpStartValue;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Panel panelRepeat;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.NumericUpDown nudWeeksValue;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSu;
        private System.Windows.Forms.CheckBox cbTh;
        private System.Windows.Forms.CheckBox cbWe;
        private System.Windows.Forms.CheckBox cbSa;
        private System.Windows.Forms.CheckBox cbTu;
        private System.Windows.Forms.CheckBox cbFr;
        private System.Windows.Forms.CheckBox cbMo;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}