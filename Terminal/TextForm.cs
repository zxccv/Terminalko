using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Samoyloff.Terminal;
using UsingsRU.Patterns;

namespace Terminal
{
    public partial class TextForm : DockContent
    {
        public Samoyloff.Terminal.TerminalTextBox.TerminalTextBox TB
        {
            get { return textBox1; }
        }
        private string send_receive;

        public string SendReceive
        {
            get { return send_receive; }
            set { send_receive = value; }
        }
        
        private string data_type;
        
        public string DataType
        {
            get { return data_type; }
            set { data_type = value; }
        }

        public TextForm()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.HideSelection = false;
            textBox1.OnSelectionChange += new EventHandler(textBox1_OnSelectionChange);
            send_receive = "Прием";
            data_type = "ASCII";
        }

        protected override string GetPersistString()
        {
            // Add extra information into the persist string for this document
            // so that it is available when deserialized.
            return GetType().ToString() + "," + send_receive + "," + data_type;
        }

        private void textBox1_OnSelectionChange(object sender, EventArgs e)
        {
            ((MainForm)(DockPanel.Parent)).UpdateSelection(((Samoyloff.Terminal.TerminalTextBox.TerminalTextBox)sender).GetSelData(), this);
        }

        private void TextForm_Load(object sender, EventArgs e)
        {
            tscbSendReceive.Text = send_receive;
            tscbType.Text = data_type;

            Text = send_receive + "," + data_type;

            switch (send_receive)
            {
                case "Прием+Передача":
                    textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.INOUT;
                    break;               
                case "Прием":
                    textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.IN;
                    break;
                case "Передача":
                    textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.OUT;
                    break;
            }

            switch (tscbType.Text)
            {
                case "HEX":
                    textBox1.TbType = Samoyloff.Terminal.TerminalTextBox.TbTypes.HEX;
                    break;
                default:
                    textBox1.TbType = Samoyloff.Terminal.TerminalTextBox.TbTypes.ASCII;
                    break;
            }
            
        }

        private void tscbSendReceive_TextChanged(object sender, EventArgs e)
        {
            send_receive = tscbSendReceive.Text;

            Text = send_receive + "," + data_type;

            switch (send_receive)
            {
                case "Прием+Передача":
                    textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.INOUT;
                    break;
                case "Прием":
                    textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.IN;
                    break;
                case "Передача":
                    textBox1.TbInOut = Samoyloff.Terminal.TerminalTextBox.TbInOut.OUT;
                    break;
            }

            textBox1.Clear();
            textBox1.LastNumber = 0;
            textBox1.DrawText();
        }

        private void tscbType_TextChanged(object sender, EventArgs e)
        {
            data_type = tscbType.Text;

            Text = send_receive + "," + data_type;

            switch (tscbType.Text)
            {
                case "HEX":
                    textBox1.TbType = Samoyloff.Terminal.TerminalTextBox.TbTypes.HEX;
                    break;
                default:
                    textBox1.TbType = Samoyloff.Terminal.TerminalTextBox.TbTypes.ASCII;
                    break;
            }

            textBox1.Clear();
            textBox1.LastNumber = 0;
            textBox1.DrawText();
        }

        private void TextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        
                                
    }
}
