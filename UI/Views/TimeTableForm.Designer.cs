
namespace StretchCeilings.UI.Views
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
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.panelRepeatBody = new System.Windows.Forms.Panel();
            this.panelDays = new System.Windows.Forms.Panel();
            this.labelDaysOfWeek = new System.Windows.Forms.Label();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.panelWeeks = new System.Windows.Forms.Panel();
            this.labelWeekForRepeat = new System.Windows.Forms.Label();
            this.numericUpDownWeeks = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveData = new FontAwesome.Sharp.IconButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.buttonCloseForm = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRepeatBody.SuspendLayout();
            this.panelDays.SuspendLayout();
            this.panelWeeks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeeks)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Open Sans", 12F);
            this.labelStartTime.Location = new System.Drawing.Point(5, 40);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(73, 23);
            this.labelStartTime.TabIndex = 20;
            this.labelStartTime.Text = "Начало:";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Open Sans", 12F);
            this.labelEndTime.Location = new System.Drawing.Point(5, 75);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(63, 23);
            this.labelEndTime.TabIndex = 23;
            this.labelEndTime.Text = "Конец:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpStartTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dtpStartTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dtpStartTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpStartTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpStartTime.CustomFormat = "H:mm";
            this.dtpStartTime.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(96, 37);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(63, 29);
            this.dtpStartTime.TabIndex = 22;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(96, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(111, 29);
            this.dtpDate.TabIndex = 19;
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
            this.cbRepeat.CheckedChanged += new System.EventHandler(this.SwitchRepeatPanelEnable);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Open Sans", 12F);
            this.labelDate.Location = new System.Drawing.Point(5, 6);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 23);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Дата:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpEndTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dtpEndTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dtpEndTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpEndTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dtpEndTime.CustomFormat = "H:mm";
            this.dtpEndTime.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(96, 72);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(63, 29);
            this.dtpEndTime.TabIndex = 24;
            // 
            // panelRepeatBody
            // 
            this.panelRepeatBody.Controls.Add(this.panelDays);
            this.panelRepeatBody.Controls.Add(this.panelWeeks);
            this.panelRepeatBody.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelRepeatBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRepeatBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelRepeatBody.Location = new System.Drawing.Point(0, 149);
            this.panelRepeatBody.Name = "panelRepeatBody";
            this.panelRepeatBody.Size = new System.Drawing.Size(300, 143);
            this.panelRepeatBody.TabIndex = 28;
            // 
            // panelDays
            // 
            this.panelDays.Controls.Add(this.labelDaysOfWeek);
            this.panelDays.Controls.Add(this.cbSunday);
            this.panelDays.Controls.Add(this.cbThursday);
            this.panelDays.Controls.Add(this.cbWednesday);
            this.panelDays.Controls.Add(this.cbSaturday);
            this.panelDays.Controls.Add(this.cbTuesday);
            this.panelDays.Controls.Add(this.cbFriday);
            this.panelDays.Controls.Add(this.cbMonday);
            this.panelDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDays.Location = new System.Drawing.Point(0, 44);
            this.panelDays.Name = "panelDays";
            this.panelDays.Size = new System.Drawing.Size(300, 99);
            this.panelDays.TabIndex = 31;
            // 
            // labelDaysOfWeek
            // 
            this.labelDaysOfWeek.AutoSize = true;
            this.labelDaysOfWeek.Font = new System.Drawing.Font("Open Sans", 12F);
            this.labelDaysOfWeek.Location = new System.Drawing.Point(6, 3);
            this.labelDaysOfWeek.Name = "labelDaysOfWeek";
            this.labelDaysOfWeek.Size = new System.Drawing.Size(175, 23);
            this.labelDaysOfWeek.TabIndex = 29;
            this.labelDaysOfWeek.Text = "Дни для повторения:";
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSunday.Location = new System.Drawing.Point(184, 65);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(48, 28);
            this.cbSunday.TabIndex = 27;
            this.cbSunday.Text = "Вс";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbThursday.Location = new System.Drawing.Point(214, 33);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(48, 28);
            this.cbThursday.TabIndex = 24;
            this.cbThursday.Text = "Чв";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbWednesday.Location = new System.Drawing.Point(157, 33);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(50, 28);
            this.cbWednesday.TabIndex = 23;
            this.cbWednesday.Text = "Ср";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSaturday.Location = new System.Drawing.Point(126, 65);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(50, 28);
            this.cbSaturday.TabIndex = 26;
            this.cbSaturday.Text = "Сб";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbTuesday.Location = new System.Drawing.Point(103, 33);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(48, 28);
            this.cbTuesday.TabIndex = 22;
            this.cbTuesday.Text = "Вт";
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbFriday.Location = new System.Drawing.Point(70, 65);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(49, 28);
            this.cbFriday.TabIndex = 25;
            this.cbFriday.Text = "Пт";
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbMonday.Location = new System.Drawing.Point(46, 33);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(50, 28);
            this.cbMonday.TabIndex = 21;
            this.cbMonday.Text = "Пн";
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // panelWeeks
            // 
            this.panelWeeks.Controls.Add(this.labelWeekForRepeat);
            this.panelWeeks.Controls.Add(this.numericUpDownWeeks);
            this.panelWeeks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWeeks.Location = new System.Drawing.Point(0, 0);
            this.panelWeeks.Name = "panelWeeks";
            this.panelWeeks.Size = new System.Drawing.Size(300, 44);
            this.panelWeeks.TabIndex = 30;
            // 
            // labelWeekForRepeat
            // 
            this.labelWeekForRepeat.AutoSize = true;
            this.labelWeekForRepeat.Font = new System.Drawing.Font("Open Sans", 12F);
            this.labelWeekForRepeat.Location = new System.Drawing.Point(6, 7);
            this.labelWeekForRepeat.Name = "labelWeekForRepeat";
            this.labelWeekForRepeat.Size = new System.Drawing.Size(201, 23);
            this.labelWeekForRepeat.TabIndex = 28;
            this.labelWeekForRepeat.Text = "Недель для повторения:";
            // 
            // numericUpDownWeeks
            // 
            this.numericUpDownWeeks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.numericUpDownWeeks.Font = new System.Drawing.Font("Open Sans", 12F);
            this.numericUpDownWeeks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.numericUpDownWeeks.Location = new System.Drawing.Point(239, 5);
            this.numericUpDownWeeks.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWeeks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeeks.Name = "numericUpDownWeeks";
            this.numericUpDownWeeks.Size = new System.Drawing.Size(49, 29);
            this.numericUpDownWeeks.TabIndex = 29;
            this.numericUpDownWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownWeeks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonSaveData.FlatAppearance.BorderSize = 0;
            this.buttonSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveData.Font = new System.Drawing.Font("Open Sans", 12F);
            this.buttonSaveData.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.buttonSaveData.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonSaveData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSaveData.IconSize = 25;
            this.buttonSaveData.Location = new System.Drawing.Point(165, 115);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(130, 30);
            this.buttonSaveData.TabIndex = 29;
            this.buttonSaveData.Text = "Сохранить";
            this.buttonSaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveData.UseVisualStyleBackColor = false;
            this.buttonSaveData.Click += new System.EventHandler(this.SaveData);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.buttonSaveData);
            this.panelBody.Controls.Add(this.panelRepeatBody);
            this.panelBody.Controls.Add(this.dtpEndTime);
            this.panelBody.Controls.Add(this.labelDate);
            this.panelBody.Controls.Add(this.cbRepeat);
            this.panelBody.Controls.Add(this.dtpDate);
            this.panelBody.Controls.Add(this.dtpStartTime);
            this.panelBody.Controls.Add(this.labelEndTime);
            this.panelBody.Controls.Add(this.labelStartTime);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelBody.Location = new System.Drawing.Point(0, 28);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(300, 292);
            this.panelBody.TabIndex = 79;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonCloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.buttonCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCloseForm.IconSize = 25;
            this.buttonCloseForm.Location = new System.Drawing.Point(275, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(25, 28);
            this.buttonCloseForm.TabIndex = 2;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.CloseForm);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.buttonCloseForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 28);
            this.panelTop.TabIndex = 78;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 320);
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "TimeTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadForm);
            this.panelRepeatBody.ResumeLayout(false);
            this.panelDays.ResumeLayout(false);
            this.panelDays.PerformLayout();
            this.panelWeeks.ResumeLayout(false);
            this.panelWeeks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeeks)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Panel panelRepeatBody;
        private System.Windows.Forms.Panel panelDays;
        private System.Windows.Forms.Label labelDaysOfWeek;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.Panel panelWeeks;
        private System.Windows.Forms.Label labelWeekForRepeat;
        private System.Windows.Forms.NumericUpDown numericUpDownWeeks;
        private FontAwesome.Sharp.IconButton buttonSaveData;
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconButton buttonCloseForm;
        private System.Windows.Forms.Panel panelTop;
    }
}