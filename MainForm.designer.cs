
namespace stretch_ceilings_app
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
            this.btnMaximizeApp = new FontAwesome.Sharp.IconButton();
            this.btnCloseApp = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelTop.Controls.Add(this.btnMaximizeApp);
            this.panelTop.Controls.Add(this.btnCloseApp);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1440, 25);
            this.panelTop.TabIndex = 6;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeApp.FlatAppearance.BorderSize = 0;
            this.btnMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizeApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnMinimizeApp.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMinimizeApp.IconSize = 25;
            this.btnMinimizeApp.Location = new System.Drawing.Point(1365, 0);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizeApp.TabIndex = 3;
            this.btnMinimizeApp.UseVisualStyleBackColor = true;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            // 
            // btnMaximizeApp
            // 
            this.btnMaximizeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeApp.FlatAppearance.BorderSize = 0;
            this.btnMaximizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximizeApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnMaximizeApp.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMaximizeApp.IconSize = 25;
            this.btnMaximizeApp.Location = new System.Drawing.Point(1390, 0);
            this.btnMaximizeApp.Name = "btnMaximizeApp";
            this.btnMaximizeApp.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizeApp.TabIndex = 2;
            this.btnMaximizeApp.UseVisualStyleBackColor = true;
            this.btnMaximizeApp.Click += new System.EventHandler(this.btnMaximizeApp_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseApp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnCloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseApp.IconSize = 25;
            this.btnCloseApp.Location = new System.Drawing.Point(1415, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(25, 25);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stretch Ceilings App";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelContent);
            this.panelBody.Controls.Add(this.panelNav);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1440, 775);
            this.panelBody.TabIndex = 7;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelContent.Location = new System.Drawing.Point(190, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1250, 775);
            this.panelContent.TabIndex = 9;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(190, 775);
            this.panelNav.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1440, 800);
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
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMinimizeApp;
        private FontAwesome.Sharp.IconButton btnMaximizeApp;
        private FontAwesome.Sharp.IconButton btnCloseApp;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelNav;
    }
}

