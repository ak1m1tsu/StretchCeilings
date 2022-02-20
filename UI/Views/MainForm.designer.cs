
namespace StretchCeilings.UI.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizeApp = new FontAwesome.Sharp.IconButton();
            this.btnResiizeApp = new FontAwesome.Sharp.IconButton();
            this.btnCloseApp = new FontAwesome.Sharp.IconButton();
            this.lblName = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnMinimizeApp);
            this.panelTop.Controls.Add(this.btnResiizeApp);
            this.panelTop.Controls.Add(this.btnCloseApp);
            this.panelTop.Controls.Add(this.lblName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1400, 25);
            this.panelTop.TabIndex = 6;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeApp.FlatAppearance.BorderSize = 0;
            this.btnMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeApp.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMinimizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizeApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnMinimizeApp.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMinimizeApp.IconSize = 25;
            this.btnMinimizeApp.Location = new System.Drawing.Point(1325, 0);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizeApp.TabIndex = 3;
            this.btnMinimizeApp.UseVisualStyleBackColor = true;
            this.btnMinimizeApp.Click += new System.EventHandler(this.MinimizeApp);
            // 
            // btnResiizeApp
            // 
            this.btnResiizeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResiizeApp.FlatAppearance.BorderSize = 0;
            this.btnResiizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResiizeApp.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnResiizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnResiizeApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnResiizeApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResiizeApp.IconSize = 25;
            this.btnResiizeApp.Location = new System.Drawing.Point(1350, 0);
            this.btnResiizeApp.Name = "btnResiizeApp";
            this.btnResiizeApp.Size = new System.Drawing.Size(25, 25);
            this.btnResiizeApp.TabIndex = 2;
            this.btnResiizeApp.UseVisualStyleBackColor = true;
            this.btnResiizeApp.Click += new System.EventHandler(this.MaximizeApp);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCloseApp.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnCloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseApp.IconSize = 25;
            this.btnCloseApp.Location = new System.Drawing.Point(1375, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(25, 25);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.CloseApp);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(161, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Stretch Ceilings App";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelContent);
            this.panelBody.Controls.Add(this.panelNav);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1400, 575);
            this.panelBody.TabIndex = 7;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1200, 575);
            this.panelContent.TabIndex = 9;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 575);
            this.panelNav.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblName;
        private FontAwesome.Sharp.IconButton btnMinimizeApp;
        private FontAwesome.Sharp.IconButton btnResiizeApp;
        private FontAwesome.Sharp.IconButton btnCloseApp;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelNav;
    }
}

