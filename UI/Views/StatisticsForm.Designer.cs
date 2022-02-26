namespace StretchCeilings.UI.Views
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAdditionalServices = new System.Windows.Forms.TabPage();
            this.chartAdditionalService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelAdditionalService = new System.Windows.Forms.Panel();
            this.panelAdditionalServicesButtons = new System.Windows.Forms.Panel();
            this.groupBoxAdditionalServicePeriod = new System.Windows.Forms.GroupBox();
            this.labelAddServicePeriodUntil = new System.Windows.Forms.Label();
            this.dateTimePickerAdditionalServicePeriodUntil = new System.Windows.Forms.DateTimePicker();
            this.labelAddServicePeriodFrom = new System.Windows.Forms.Label();
            this.dateTimePickerServicePeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.chartCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panelCustomerButtons = new System.Windows.Forms.Panel();
            this.groupBoxCustomerPeriod = new System.Windows.Forms.GroupBox();
            this.labelCustomerPeriodUntil = new System.Windows.Forms.Label();
            this.dateTimePickerCustomerPeriodUntil = new System.Windows.Forms.DateTimePicker();
            this.labelCustomerPeriodFrom = new System.Windows.Forms.Label();
            this.dateTimePickerCustomerPeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tabPageAdditionalServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAdditionalService)).BeginInit();
            this.panelAdditionalService.SuspendLayout();
            this.groupBoxAdditionalServicePeriod.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomers)).BeginInit();
            this.panelCustomers.SuspendLayout();
            this.groupBoxCustomerPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAdditionalServices);
            this.tabControl.Controls.Add(this.tabPageCustomers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(70, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1187, 594);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAdditionalServices
            // 
            this.tabPageAdditionalServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPageAdditionalServices.Controls.Add(this.chartAdditionalService);
            this.tabPageAdditionalServices.Controls.Add(this.panelAdditionalService);
            this.tabPageAdditionalServices.Location = new System.Drawing.Point(4, 34);
            this.tabPageAdditionalServices.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageAdditionalServices.Name = "tabPageAdditionalServices";
            this.tabPageAdditionalServices.Size = new System.Drawing.Size(1179, 556);
            this.tabPageAdditionalServices.TabIndex = 0;
            this.tabPageAdditionalServices.Text = "Доп. услуги";
            // 
            // chartAdditionalService
            // 
            this.chartAdditionalService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.chartAdditionalService.BorderlineColor = System.Drawing.Color.Empty;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            chartArea3.Name = "ChartArea";
            this.chartAdditionalService.ChartAreas.Add(chartArea3);
            this.chartAdditionalService.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            legend2.Font = new System.Drawing.Font("Open Sans", 9.75F);
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend";
            this.chartAdditionalService.Legends.Add(legend2);
            this.chartAdditionalService.Location = new System.Drawing.Point(0, 0);
            this.chartAdditionalService.Name = "chartAdditionalService";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            series3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend";
            series3.Name = "Series";
            series3.YValuesPerPoint = 2;
            this.chartAdditionalService.Series.Add(series3);
            this.chartAdditionalService.Size = new System.Drawing.Size(979, 556);
            this.chartAdditionalService.TabIndex = 0;
            title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            title3.Font = new System.Drawing.Font("Open Sans", 9.75F);
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            title3.Name = "Title";
            this.chartAdditionalService.Titles.Add(title3);
            // 
            // panelAdditionalService
            // 
            this.panelAdditionalService.Controls.Add(this.panelAdditionalServicesButtons);
            this.panelAdditionalService.Controls.Add(this.groupBoxAdditionalServicePeriod);
            this.panelAdditionalService.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAdditionalService.Location = new System.Drawing.Point(979, 0);
            this.panelAdditionalService.Name = "panelAdditionalService";
            this.panelAdditionalService.Size = new System.Drawing.Size(200, 556);
            this.panelAdditionalService.TabIndex = 1;
            // 
            // panelAdditionalServicesButtons
            // 
            this.panelAdditionalServicesButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdditionalServicesButtons.Location = new System.Drawing.Point(0, 105);
            this.panelAdditionalServicesButtons.Name = "panelAdditionalServicesButtons";
            this.panelAdditionalServicesButtons.Size = new System.Drawing.Size(200, 451);
            this.panelAdditionalServicesButtons.TabIndex = 1;
            // 
            // groupBoxAdditionalServicePeriod
            // 
            this.groupBoxAdditionalServicePeriod.Controls.Add(this.labelAddServicePeriodUntil);
            this.groupBoxAdditionalServicePeriod.Controls.Add(this.dateTimePickerAdditionalServicePeriodUntil);
            this.groupBoxAdditionalServicePeriod.Controls.Add(this.labelAddServicePeriodFrom);
            this.groupBoxAdditionalServicePeriod.Controls.Add(this.dateTimePickerServicePeriodFrom);
            this.groupBoxAdditionalServicePeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAdditionalServicePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAdditionalServicePeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.groupBoxAdditionalServicePeriod.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAdditionalServicePeriod.Name = "groupBoxAdditionalServicePeriod";
            this.groupBoxAdditionalServicePeriod.Size = new System.Drawing.Size(200, 105);
            this.groupBoxAdditionalServicePeriod.TabIndex = 1;
            this.groupBoxAdditionalServicePeriod.TabStop = false;
            this.groupBoxAdditionalServicePeriod.Text = "Период";
            // 
            // labelAddServicePeriodUntil
            // 
            this.labelAddServicePeriodUntil.AutoSize = true;
            this.labelAddServicePeriodUntil.Location = new System.Drawing.Point(8, 63);
            this.labelAddServicePeriodUntil.Name = "labelAddServicePeriodUntil";
            this.labelAddServicePeriodUntil.Size = new System.Drawing.Size(35, 23);
            this.labelAddServicePeriodUntil.TabIndex = 3;
            this.labelAddServicePeriodUntil.Text = "До:";
            // 
            // dateTimePickerAdditionalServicePeriodUntil
            // 
            this.dateTimePickerAdditionalServicePeriodUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdditionalServicePeriodUntil.Location = new System.Drawing.Point(80, 60);
            this.dateTimePickerAdditionalServicePeriodUntil.Name = "dateTimePickerAdditionalServicePeriodUntil";
            this.dateTimePickerAdditionalServicePeriodUntil.Size = new System.Drawing.Size(114, 29);
            this.dateTimePickerAdditionalServicePeriodUntil.TabIndex = 2;
            this.dateTimePickerAdditionalServicePeriodUntil.ValueChanged += new System.EventHandler(this.dateTimePickerPeriodUntil_ValueChanged);
            // 
            // labelAddServicePeriodFrom
            // 
            this.labelAddServicePeriodFrom.AutoSize = true;
            this.labelAddServicePeriodFrom.Location = new System.Drawing.Point(6, 28);
            this.labelAddServicePeriodFrom.Name = "labelAddServicePeriodFrom";
            this.labelAddServicePeriodFrom.Size = new System.Drawing.Size(34, 23);
            this.labelAddServicePeriodFrom.TabIndex = 1;
            this.labelAddServicePeriodFrom.Text = "От:";
            // 
            // dateTimePickerServicePeriodFrom
            // 
            this.dateTimePickerServicePeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerServicePeriodFrom.Location = new System.Drawing.Point(78, 25);
            this.dateTimePickerServicePeriodFrom.Name = "dateTimePickerServicePeriodFrom";
            this.dateTimePickerServicePeriodFrom.Size = new System.Drawing.Size(114, 29);
            this.dateTimePickerServicePeriodFrom.TabIndex = 0;
            this.dateTimePickerServicePeriodFrom.ValueChanged += new System.EventHandler(this.dateTimePickerPeriodFrom_ValueChanged);
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabPageCustomers.Controls.Add(this.chartCustomers);
            this.tabPageCustomers.Controls.Add(this.panelCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 34);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(1179, 556);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Клиенты";
            // 
            // chartCustomers
            // 
            this.chartCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.chartCustomers.BorderlineColor = System.Drawing.Color.Empty;
            this.chartCustomers.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            chartArea4.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            chartArea4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            chartArea4.BorderColor = System.Drawing.Color.Empty;
            chartArea4.Name = "ChartArea";
            this.chartCustomers.ChartAreas.Add(chartArea4);
            this.chartCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCustomers.Location = new System.Drawing.Point(3, 3);
            this.chartCustomers.Name = "chartCustomers";
            this.chartCustomers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            series4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            series4.Name = "Series";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            series4.YValuesPerPoint = 3;
            this.chartCustomers.Series.Add(series4);
            this.chartCustomers.Size = new System.Drawing.Size(973, 550);
            this.chartCustomers.TabIndex = 3;
            title4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            title4.Font = new System.Drawing.Font("Open Sans", 9.75F);
            title4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            title4.Name = "Title";
            this.chartCustomers.Titles.Add(title4);
            // 
            // panelCustomers
            // 
            this.panelCustomers.Controls.Add(this.panelCustomerButtons);
            this.panelCustomers.Controls.Add(this.groupBoxCustomerPeriod);
            this.panelCustomers.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCustomers.Location = new System.Drawing.Point(976, 3);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(200, 550);
            this.panelCustomers.TabIndex = 2;
            // 
            // panelCustomerButtons
            // 
            this.panelCustomerButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerButtons.Location = new System.Drawing.Point(0, 105);
            this.panelCustomerButtons.Name = "panelCustomerButtons";
            this.panelCustomerButtons.Size = new System.Drawing.Size(200, 445);
            this.panelCustomerButtons.TabIndex = 1;
            // 
            // groupBoxCustomerPeriod
            // 
            this.groupBoxCustomerPeriod.Controls.Add(this.labelCustomerPeriodUntil);
            this.groupBoxCustomerPeriod.Controls.Add(this.dateTimePickerCustomerPeriodUntil);
            this.groupBoxCustomerPeriod.Controls.Add(this.labelCustomerPeriodFrom);
            this.groupBoxCustomerPeriod.Controls.Add(this.dateTimePickerCustomerPeriodFrom);
            this.groupBoxCustomerPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomerPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCustomerPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.groupBoxCustomerPeriod.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomerPeriod.Name = "groupBoxCustomerPeriod";
            this.groupBoxCustomerPeriod.Size = new System.Drawing.Size(200, 105);
            this.groupBoxCustomerPeriod.TabIndex = 1;
            this.groupBoxCustomerPeriod.TabStop = false;
            this.groupBoxCustomerPeriod.Text = "Период";
            // 
            // labelCustomerPeriodUntil
            // 
            this.labelCustomerPeriodUntil.AutoSize = true;
            this.labelCustomerPeriodUntil.Location = new System.Drawing.Point(8, 63);
            this.labelCustomerPeriodUntil.Name = "labelCustomerPeriodUntil";
            this.labelCustomerPeriodUntil.Size = new System.Drawing.Size(35, 23);
            this.labelCustomerPeriodUntil.TabIndex = 3;
            this.labelCustomerPeriodUntil.Text = "До:";
            // 
            // dateTimePickerCustomerPeriodUntil
            // 
            this.dateTimePickerCustomerPeriodUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCustomerPeriodUntil.Location = new System.Drawing.Point(80, 60);
            this.dateTimePickerCustomerPeriodUntil.Name = "dateTimePickerCustomerPeriodUntil";
            this.dateTimePickerCustomerPeriodUntil.Size = new System.Drawing.Size(114, 29);
            this.dateTimePickerCustomerPeriodUntil.TabIndex = 2;
            // 
            // labelCustomerPeriodFrom
            // 
            this.labelCustomerPeriodFrom.AutoSize = true;
            this.labelCustomerPeriodFrom.Location = new System.Drawing.Point(6, 28);
            this.labelCustomerPeriodFrom.Name = "labelCustomerPeriodFrom";
            this.labelCustomerPeriodFrom.Size = new System.Drawing.Size(34, 23);
            this.labelCustomerPeriodFrom.TabIndex = 1;
            this.labelCustomerPeriodFrom.Text = "От:";
            // 
            // dateTimePickerCustomerPeriodFrom
            // 
            this.dateTimePickerCustomerPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCustomerPeriodFrom.Location = new System.Drawing.Point(78, 25);
            this.dateTimePickerCustomerPeriodFrom.Name = "dateTimePickerCustomerPeriodFrom";
            this.dateTimePickerCustomerPeriodFrom.Size = new System.Drawing.Size(114, 29);
            this.dateTimePickerCustomerPeriodFrom.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1187, 594);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageAdditionalServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAdditionalService)).EndInit();
            this.panelAdditionalService.ResumeLayout(false);
            this.groupBoxAdditionalServicePeriod.ResumeLayout(false);
            this.groupBoxAdditionalServicePeriod.PerformLayout();
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomers)).EndInit();
            this.panelCustomers.ResumeLayout(false);
            this.groupBoxCustomerPeriod.ResumeLayout(false);
            this.groupBoxCustomerPeriod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdditionalServices;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAdditionalService;
        private System.Windows.Forms.Panel panelAdditionalService;
        private System.Windows.Forms.Panel panelAdditionalServicesButtons;
        private System.Windows.Forms.DateTimePicker dateTimePickerServicePeriodFrom;
        private System.Windows.Forms.GroupBox groupBoxAdditionalServicePeriod;
        private System.Windows.Forms.Label labelAddServicePeriodUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdditionalServicePeriodUntil;
        private System.Windows.Forms.Label labelAddServicePeriodFrom;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomers;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Panel panelCustomerButtons;
        private System.Windows.Forms.GroupBox groupBoxCustomerPeriod;
        private System.Windows.Forms.Label labelCustomerPeriodUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerCustomerPeriodUntil;
        private System.Windows.Forms.Label labelCustomerPeriodFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerCustomerPeriodFrom;
    }
}