using System;
using Samoyloff.Terminal.TerminalTextBox;

namespace Terminal
{
    partial class TextForm
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

            try
            {
                ((MainForm)MdiParent).TextForms.Remove(this);
            }
            catch (Exception) { };


        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            this.textBox1 = new Samoyloff.Terminal.TerminalTextBox.TerminalTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbSendReceive = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataArray = null;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 247);
            this.textBox1.TabIndex = 0;
            this.textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.IN;
            this.textBox1.TbType = Samoyloff.Terminal.TerminalTextBox.TbTypes.ASCII;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscbSendReceive,
            this.toolStripLabel2,
            this.tscbType});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(24, 22);
            this.toolStripLabel1.Text = "S/R";
            // 
            // tscbSendReceive
            // 
            this.tscbSendReceive.Items.AddRange(new object[] {
            "Прием",
            "Передача",
            "Прием+Передача"});
            this.tscbSendReceive.Name = "tscbSendReceive";
            this.tscbSendReceive.Size = new System.Drawing.Size(75, 25);
            this.tscbSendReceive.TextChanged += new System.EventHandler(this.tscbSendReceive_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel2.Text = "Тип";
            // 
            // tscbType
            // 
            this.tscbType.Items.AddRange(new object[] {
            "ASCII",
            "HEX",
            "DEC",
            "BIN"});
            this.tscbType.Name = "tscbType";
            this.tscbType.Size = new System.Drawing.Size(75, 25);
            this.tscbType.TextChanged += new System.EventHandler(this.tscbType_TextChanged);
            // 
            // TextForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextForm";
            this.Text = "TextForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextForm_FormClosing);
            this.Load += new System.EventHandler(this.TextForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TerminalTextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscbSendReceive;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tscbType;
    }
}