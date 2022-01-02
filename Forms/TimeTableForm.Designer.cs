
namespace stretch_ceilings_app.Forms
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
            this.dtpDateValue = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbDaysRepeat = new System.Windows.Forms.GroupBox();
            this.cbSu = new System.Windows.Forms.CheckBox();
            this.cbTh = new System.Windows.Forms.CheckBox();
            this.cbWe = new System.Windows.Forms.CheckBox();
            this.cbSa = new System.Windows.Forms.CheckBox();
            this.cbTu = new System.Windows.Forms.CheckBox();
            this.cbFr = new System.Windows.Forms.CheckBox();
            this.cbMo = new System.Windows.Forms.CheckBox();
            this.gbShedule = new System.Windows.Forms.GroupBox();
            this.nudWeeksValue = new System.Windows.Forms.NumericUpDown();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.dtpEndValue = new System.Windows.Forms.DateTimePicker();
            this.dtpStartValue = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.gbDaysRepeat.SuspendLayout();
            this.gbShedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeksValue)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateValue
            // 
            this.dtpDateValue.CustomFormat = "dd.MM.yyyy";
            this.dtpDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateValue.Location = new System.Drawing.Point(101, 29);
            this.dtpDateValue.Name = "dtpDateValue";
            this.dtpDateValue.Size = new System.Drawing.Size(128, 29);
            this.dtpDateValue.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDate.Location = new System.Drawing.Point(10, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 24);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Дата:";
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbRepeat.Location = new System.Drawing.Point(14, 131);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(125, 28);
            this.cbRepeat.TabIndex = 13;
            this.cbRepeat.Text = "Повторить";
            this.cbRepeat.UseVisualStyleBackColor = true;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelBtn);
            this.panelBody.Controls.Add(this.gbDaysRepeat);
            this.panelBody.Controls.Add(this.gbShedule);
            this.panelBody.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(244, 361);
            this.panelBody.TabIndex = 14;
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.panelBtn.Controls.Add(this.btnSave);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtn.Location = new System.Drawing.Point(0, 307);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(244, 54);
            this.panelBtn.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(61, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 30);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbDaysRepeat
            // 
            this.gbDaysRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.gbDaysRepeat.Controls.Add(this.cbSu);
            this.gbDaysRepeat.Controls.Add(this.cbTh);
            this.gbDaysRepeat.Controls.Add(this.cbWe);
            this.gbDaysRepeat.Controls.Add(this.cbSa);
            this.gbDaysRepeat.Controls.Add(this.cbTu);
            this.gbDaysRepeat.Controls.Add(this.cbFr);
            this.gbDaysRepeat.Controls.Add(this.cbMo);
            this.gbDaysRepeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDaysRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gbDaysRepeat.Location = new System.Drawing.Point(0, 212);
            this.gbDaysRepeat.Name = "gbDaysRepeat";
            this.gbDaysRepeat.Size = new System.Drawing.Size(244, 95);
            this.gbDaysRepeat.TabIndex = 15;
            this.gbDaysRepeat.TabStop = false;
            this.gbDaysRepeat.Text = "Дни повторения";
            // 
            // cbSu
            // 
            this.cbSu.AutoSize = true;
            this.cbSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSu.Location = new System.Drawing.Point(154, 61);
            this.cbSu.Name = "cbSu";
            this.cbSu.Size = new System.Drawing.Size(48, 28);
            this.cbSu.TabIndex = 20;
            this.cbSu.Text = "Вс";
            this.cbSu.UseVisualStyleBackColor = true;
            // 
            // cbTh
            // 
            this.cbTh.AutoSize = true;
            this.cbTh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbTh.Location = new System.Drawing.Point(185, 32);
            this.cbTh.Name = "cbTh";
            this.cbTh.Size = new System.Drawing.Size(48, 28);
            this.cbTh.TabIndex = 17;
            this.cbTh.Text = "Чв";
            this.cbTh.UseVisualStyleBackColor = true;
            // 
            // cbWe
            // 
            this.cbWe.AutoSize = true;
            this.cbWe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbWe.Location = new System.Drawing.Point(126, 32);
            this.cbWe.Name = "cbWe";
            this.cbWe.Size = new System.Drawing.Size(50, 28);
            this.cbWe.TabIndex = 16;
            this.cbWe.Text = "Ср";
            this.cbWe.UseVisualStyleBackColor = true;
            // 
            // cbSa
            // 
            this.cbSa.AutoSize = true;
            this.cbSa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSa.Location = new System.Drawing.Point(95, 61);
            this.cbSa.Name = "cbSa";
            this.cbSa.Size = new System.Drawing.Size(50, 28);
            this.cbSa.TabIndex = 19;
            this.cbSa.Text = "Сб";
            this.cbSa.UseVisualStyleBackColor = true;
            // 
            // cbTu
            // 
            this.cbTu.AutoSize = true;
            this.cbTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbTu.Location = new System.Drawing.Point(69, 32);
            this.cbTu.Name = "cbTu";
            this.cbTu.Size = new System.Drawing.Size(48, 28);
            this.cbTu.TabIndex = 15;
            this.cbTu.Text = "Вт";
            this.cbTu.UseVisualStyleBackColor = true;
            // 
            // cbFr
            // 
            this.cbFr.AutoSize = true;
            this.cbFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbFr.Location = new System.Drawing.Point(37, 61);
            this.cbFr.Name = "cbFr";
            this.cbFr.Size = new System.Drawing.Size(49, 28);
            this.cbFr.TabIndex = 18;
            this.cbFr.Text = "Пт";
            this.cbFr.UseVisualStyleBackColor = true;
            // 
            // cbMo
            // 
            this.cbMo.AutoSize = true;
            this.cbMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbMo.Location = new System.Drawing.Point(10, 32);
            this.cbMo.Name = "cbMo";
            this.cbMo.Size = new System.Drawing.Size(50, 28);
            this.cbMo.TabIndex = 14;
            this.cbMo.Text = "Пн";
            this.cbMo.UseVisualStyleBackColor = true;
            // 
            // gbShedule
            // 
            this.gbShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(72)))));
            this.gbShedule.Controls.Add(this.nudWeeksValue);
            this.gbShedule.Controls.Add(this.lblWeeks);
            this.gbShedule.Controls.Add(this.cbRepeat);
            this.gbShedule.Controls.Add(this.dtpEndValue);
            this.gbShedule.Controls.Add(this.lblDate);
            this.gbShedule.Controls.Add(this.dtpDateValue);
            this.gbShedule.Controls.Add(this.dtpStartValue);
            this.gbShedule.Controls.Add(this.lblEnd);
            this.gbShedule.Controls.Add(this.lblStart);
            this.gbShedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbShedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gbShedule.Location = new System.Drawing.Point(0, 0);
            this.gbShedule.Name = "gbShedule";
            this.gbShedule.Size = new System.Drawing.Size(244, 212);
            this.gbShedule.TabIndex = 14;
            this.gbShedule.TabStop = false;
            this.gbShedule.Text = "Смена";
            // 
            // nudWeeksValue
            // 
            this.nudWeeksValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nudWeeksValue.Location = new System.Drawing.Point(101, 166);
            this.nudWeeksValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeeksValue.Name = "nudWeeksValue";
            this.nudWeeksValue.Size = new System.Drawing.Size(45, 29);
            this.nudWeeksValue.TabIndex = 17;
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblWeeks.Location = new System.Drawing.Point(10, 166);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(83, 24);
            this.lblWeeks.TabIndex = 16;
            this.lblWeeks.Text = "Недель:";
            // 
            // dtpEndValue
            // 
            this.dtpEndValue.CustomFormat = "H:mm";
            this.dtpEndValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpEndValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndValue.Location = new System.Drawing.Point(101, 98);
            this.dtpEndValue.Name = "dtpEndValue";
            this.dtpEndValue.ShowUpDown = true;
            this.dtpEndValue.Size = new System.Drawing.Size(80, 29);
            this.dtpEndValue.TabIndex = 14;
            // 
            // dtpStartValue
            // 
            this.dtpStartValue.CustomFormat = "H:mm";
            this.dtpStartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpStartValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartValue.Location = new System.Drawing.Point(101, 63);
            this.dtpStartValue.Name = "dtpStartValue";
            this.dtpStartValue.ShowUpDown = true;
            this.dtpStartValue.Size = new System.Drawing.Size(80, 29);
            this.dtpStartValue.TabIndex = 13;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnd.Location = new System.Drawing.Point(10, 98);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 24);
            this.lblEnd.TabIndex = 13;
            this.lblEnd.Text = "Конец:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStart.Location = new System.Drawing.Point(10, 63);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(79, 24);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "Начало:";
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 361);
            this.Controls.Add(this.panelBody);
            this.Name = "TimeTableForm";
            this.panelBody.ResumeLayout(false);
            this.panelBtn.ResumeLayout(false);
            this.gbDaysRepeat.ResumeLayout(false);
            this.gbDaysRepeat.PerformLayout();
            this.gbShedule.ResumeLayout(false);
            this.gbShedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeksValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox gbDaysRepeat;
        private System.Windows.Forms.GroupBox gbShedule;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.CheckBox cbSu;
        private System.Windows.Forms.CheckBox cbSa;
        private System.Windows.Forms.CheckBox cbFr;
        private System.Windows.Forms.CheckBox cbTh;
        private System.Windows.Forms.CheckBox cbWe;
        private System.Windows.Forms.CheckBox cbTu;
        private System.Windows.Forms.CheckBox cbMo;
        private System.Windows.Forms.DateTimePicker dtpEndValue;
        private System.Windows.Forms.DateTimePicker dtpStartValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudWeeksValue;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.DateTimePicker dtpDateValue;
    }
}