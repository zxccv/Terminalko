namespace Terminal
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.checkboxAutoConnect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порт:";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(71, 10);
            this.cbPort.Name = "cbPort";
            this.cbPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 1;
            this.cbPort.Tag = "Port";
            this.cbPort.DropDown += new System.EventHandler(this.cbPort_DropDown);
            this.cbPort.TextChanged += new System.EventHandler(this.SettingChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скорость:";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbBaudRate.Location = new System.Drawing.Point(71, 39);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 3;
            this.cbBaudRate.TextChanged += new System.EventHandler(this.SettingChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Биты данных:";
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(289, 10);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(81, 21);
            this.cbDataBits.TabIndex = 5;
            this.cbDataBits.TextChanged += new System.EventHandler(this.SettingChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Четность:";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(289, 39);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(81, 21);
            this.cbParity.TabIndex = 6;
            this.cbParity.TextChanged += new System.EventHandler(this.SettingChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Стоп-биты:";
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(457, 10);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(61, 21);
            this.cbStopBits.TabIndex = 7;
            this.cbStopBits.TextChanged += new System.EventHandler(this.SettingChanged);
            // 
            // checkboxAutoConnect
            // 
            this.checkboxAutoConnect.AutoSize = true;
            this.checkboxAutoConnect.Location = new System.Drawing.Point(538, 12);
            this.checkboxAutoConnect.Name = "checkboxAutoConnect";
            this.checkboxAutoConnect.Size = new System.Drawing.Size(117, 17);
            this.checkboxAutoConnect.TabIndex = 8;
            this.checkboxAutoConnect.Text = "Автоподключение";
            this.checkboxAutoConnect.UseVisualStyleBackColor = true;
            this.checkboxAutoConnect.CheckedChanged += new System.EventHandler(this.SettingChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 78);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.checkboxAutoConnect);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.label1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.CheckBox checkboxAutoConnect;

    }
}