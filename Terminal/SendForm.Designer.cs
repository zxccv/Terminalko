namespace Terminal
{
    partial class SendForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbSendEndLine = new System.Windows.Forms.ToolStripButton();
            this.HotSend = new System.Windows.Forms.ToolStripButton();
            this.tb_send_data = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSendEndLine,
            this.HotSend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(644, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbSendEndLine
            // 
            this.tbSendEndLine.CheckOnClick = true;
            this.tbSendEndLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbSendEndLine.Image = ((System.Drawing.Image)(resources.GetObject("tbSendEndLine.Image")));
            this.tbSendEndLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSendEndLine.Name = "tbSendEndLine";
            this.tbSendEndLine.Size = new System.Drawing.Size(65, 22);
            this.tbSendEndLine.Text = "Слать #13";
            // 
            // HotSend
            // 
            this.HotSend.CheckOnClick = true;
            this.HotSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HotSend.Image = ((System.Drawing.Image)(resources.GetObject("HotSend.Image")));
            this.HotSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HotSend.Name = "HotSend";
            this.HotSend.RightToLeftAutoMirrorImage = true;
            this.HotSend.Size = new System.Drawing.Size(77, 22);
            this.HotSend.Text = "Посимвольно";
            // 
            // tb_send_data
            // 
            this.tb_send_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_send_data.Location = new System.Drawing.Point(13, 36);
            this.tb_send_data.Name = "tb_send_data";
            this.tb_send_data.Size = new System.Drawing.Size(552, 20);
            this.tb_send_data.TabIndex = 1;
            this.tb_send_data.TextChanged += new System.EventHandler(this.tb_send_data_TextChanged);
            // 
            // send_button
            // 
            this.send_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.send_button.Location = new System.Drawing.Point(568, 35);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 2;
            this.send_button.Text = "Отправить";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 68);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.tb_send_data);
            this.Controls.Add(this.toolStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SendForm";
            this.Text = "SendForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox tb_send_data;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.ToolStripButton tbSendEndLine;
        private System.Windows.Forms.ToolStripButton HotSend;
    }
}