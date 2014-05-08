namespace Terminal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin3 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient7 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient15 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient16 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient8 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient17 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient18 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient19 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient9 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient20 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient21 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sett_form_shown = new System.Windows.Forms.ToolStripButton();
            this.macros_form_shown = new System.Windows.Forms.ToolStripButton();
            this.tbAddTextForm = new System.Windows.Forms.ToolStripButton();
            this.send_form_shown = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbConnect = new System.Windows.Forms.ToolStripButton();
            this.tbDisconnect = new System.Windows.Forms.ToolStripButton();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.PortStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoConnectTimer = new System.Windows.Forms.Timer(this.components);
            this.tbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel.Location = new System.Drawing.Point(0, 53);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(680, 363);
            dockPanelGradient7.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient7.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin3.DockStripGradient = dockPanelGradient7;
            tabGradient15.EndColor = System.Drawing.SystemColors.Control;
            tabGradient15.StartColor = System.Drawing.SystemColors.Control;
            tabGradient15.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin3.TabGradient = tabGradient15;
            autoHideStripSkin3.TextFont = new System.Drawing.Font("Tahoma", 8.25F);
            dockPanelSkin3.AutoHideStripSkin = autoHideStripSkin3;
            tabGradient16.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient16.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient16.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient3.ActiveTabGradient = tabGradient16;
            dockPanelGradient8.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient8.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient3.DockStripGradient = dockPanelGradient8;
            tabGradient17.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient17.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient17.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient3.InactiveTabGradient = tabGradient17;
            dockPaneStripSkin3.DocumentGradient = dockPaneStripGradient3;
            dockPaneStripSkin3.TextFont = new System.Drawing.Font("Tahoma", 8.25F);
            tabGradient18.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient18.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient18.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient18.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient3.ActiveCaptionGradient = tabGradient18;
            tabGradient19.EndColor = System.Drawing.SystemColors.Control;
            tabGradient19.StartColor = System.Drawing.SystemColors.Control;
            tabGradient19.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient3.ActiveTabGradient = tabGradient19;
            dockPanelGradient9.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient9.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient3.DockStripGradient = dockPanelGradient9;
            tabGradient20.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient20.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient20.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient20.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient3.InactiveCaptionGradient = tabGradient20;
            tabGradient21.EndColor = System.Drawing.Color.Transparent;
            tabGradient21.StartColor = System.Drawing.Color.Transparent;
            tabGradient21.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient3.InactiveTabGradient = tabGradient21;
            dockPaneStripSkin3.ToolWindowGradient = dockPaneStripToolWindowGradient3;
            dockPanelSkin3.DockPaneStripSkin = dockPaneStripSkin3;
            this.dockPanel.Skin = dockPanelSkin3;
            this.dockPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sett_form_shown,
            this.macros_form_shown,
            this.send_form_shown,
            this.tbAddTextForm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(680, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sett_form_shown
            // 
            this.sett_form_shown.CheckOnClick = true;
            this.sett_form_shown.Image = ((System.Drawing.Image)(resources.GetObject("sett_form_shown.Image")));
            this.sett_form_shown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sett_form_shown.Name = "sett_form_shown";
            this.sett_form_shown.Size = new System.Drawing.Size(81, 22);
            this.sett_form_shown.Text = "Настройки";
            this.sett_form_shown.Click += new System.EventHandler(this.sett_form_shown_Click);
            // 
            // macros_form_shown
            // 
            this.macros_form_shown.CheckOnClick = true;
            this.macros_form_shown.Image = ((System.Drawing.Image)(resources.GetObject("macros_form_shown.Image")));
            this.macros_form_shown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.macros_form_shown.Name = "macros_form_shown";
            this.macros_form_shown.Size = new System.Drawing.Size(72, 22);
            this.macros_form_shown.Text = "Макросы";
            this.macros_form_shown.Click += new System.EventHandler(this.macros_form_shown_Click);
            // 
            // tbAddTextForm
            // 
            this.tbAddTextForm.Image = ((System.Drawing.Image)(resources.GetObject("tbAddTextForm.Image")));
            this.tbAddTextForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddTextForm.Name = "tbAddTextForm";
            this.tbAddTextForm.Size = new System.Drawing.Size(181, 22);
            this.tbAddTextForm.Text = "Добавить окно ввода/вывода";
            this.tbAddTextForm.Click += new System.EventHandler(this.tbAddTextForm_Click);
            // 
            // send_form_shown
            // 
            this.send_form_shown.CheckOnClick = true;
            this.send_form_shown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.send_form_shown.Image = ((System.Drawing.Image)(resources.GetObject("send_form_shown.Image")));
            this.send_form_shown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.send_form_shown.Name = "send_form_shown";
            this.send_form_shown.Size = new System.Drawing.Size(61, 22);
            this.send_form_shown.Text = "Отправка";
            this.send_form_shown.Click += new System.EventHandler(this.send_form_shown_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbConnect,
            this.tbDisconnect,
            this.tbClear});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(680, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "tsCommonOperations";
            // 
            // tbConnect
            // 
            this.tbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tbConnect.Image")));
            this.tbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbConnect.Name = "tbConnect";
            this.tbConnect.Size = new System.Drawing.Size(67, 22);
            this.tbConnect.Text = "Соединить";
            this.tbConnect.Click += new System.EventHandler(this.tbConnect_Click);
            // 
            // tbDisconnect
            // 
            this.tbDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tbDisconnect.Image")));
            this.tbDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDisconnect.Name = "tbDisconnect";
            this.tbDisconnect.Size = new System.Drawing.Size(78, 22);
            this.tbDisconnect.Text = "Разъединить";
            this.tbDisconnect.Click += new System.EventHandler(this.tbDisconnect_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 500;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // PortStatusTimer
            // 
            this.PortStatusTimer.Interval = 1000;
            this.PortStatusTimer.Tick += new System.EventHandler(this.PortStatusTimer_Tick);
            // 
            // AutoConnectTimer
            // 
            this.AutoConnectTimer.Interval = 1000;
            this.AutoConnectTimer.Tick += new System.EventHandler(this.AutoConnectTimer_Tick);
            // 
            // tbClear
            // 
            this.tbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbClear.Image = ((System.Drawing.Image)(resources.GetObject("tbClear.Image")));
            this.tbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(60, 22);
            this.tbClear.Text = "Очистить";
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 416);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dockPanel);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Терминалко";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sett_form_shown;
        private System.Windows.Forms.ToolStripButton macros_form_shown;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbConnect;
        private System.Windows.Forms.ToolStripButton tbDisconnect;
        private System.Windows.Forms.ToolStripButton tbAddTextForm;
        private System.Windows.Forms.ToolStripButton send_form_shown;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer PortStatusTimer;
        private System.Windows.Forms.Timer AutoConnectTimer;
        private System.Windows.Forms.ToolStripButton tbClear;
    }
}