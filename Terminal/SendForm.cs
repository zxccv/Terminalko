using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;

namespace Terminal
{
    public partial class SendForm : DockContent
    {
        Thread send_thread;

        public SendForm()
        {
            InitializeComponent();
        }

        private void SendData()
        {
            //foreach (Samoyloff.Terminal.TerminalData dta in ((MainForm)(DockPanel.Parent)).TerminalData)
            List<Byte> bytelist = new List<byte>();
            
            for(int i = 0; i < ((MainForm)(DockPanel.Parent)).TerminalData.Count; i++)
            
            {
                Samoyloff.Terminal.TerminalData dta = ((MainForm)(DockPanel.Parent)).TerminalData[i];

                

                if (!dta.Sent && dta.InOut == Samoyloff.Terminal.INOUT.OUT)
                {
                    dta.Sent = true;
                    bytelist.Add(dta.Data);
                    ((MainForm)(DockPanel.Parent)).TerminalData[i] = dta;
                }
            }

            if (bytelist.Count > 0)
            {
                byte[] byte_array = new byte[bytelist.Count];

                for (int i = 0; i < bytelist.Count; i++)
                    byte_array[i] = bytelist[i];
                ((MainForm)(DockPanel.Parent)).SerPort.Write(byte_array, 0, bytelist.Count);

            }
        }

        private void tb_send_data_TextChanged(object sender, EventArgs e)
        {
            if (HotSend.Checked)
            {
                int TextLenght = tb_send_data.Text.Length;
                if (TextLenght == 0)
                    return;

                for (int i = 0; i < TextLenght; i++)
                {
                    Samoyloff.Terminal.TerminalData dta = new Samoyloff.Terminal.TerminalData();
                    dta.Data = (byte)tb_send_data.Text[i];
                    dta.InOut = Samoyloff.Terminal.INOUT.OUT;
                    ((MainForm)(DockPanel.Parent)).TerminalData.Add(dta);
                }

                if (tb_send_data.Text.Length == TextLenght)
                    tb_send_data.Text = "";
                else
                    tb_send_data.Text = tb_send_data.Text.Substring(TextLenght);


                send_thread = new Thread(SendData);
                send_thread.Start();

                ((MainForm)(DockPanel.Parent)).UpdateTextBoxes();
            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {

            if (((MainForm)(DockPanel.Parent)).SerPort.IsOpen == false)
            {
                MessageBox.Show("Порт закрыт");
                return;
            }

            foreach (char chr in tb_send_data.Text)
            {
                Samoyloff.Terminal.TerminalData dta = new Samoyloff.Terminal.TerminalData();
                dta.Data = (byte)(chr);
                dta.InOut = Samoyloff.Terminal.INOUT.OUT;
                ((MainForm)(DockPanel.Parent)).TerminalData.Add(dta);
            }

            if (tbSendEndLine.Checked)
            {
                Samoyloff.Terminal.TerminalData dta = new Samoyloff.Terminal.TerminalData();
                dta.Data = (byte)13;
                dta.InOut = Samoyloff.Terminal.INOUT.OUT;
                ((MainForm)(DockPanel.Parent)).TerminalData.Add(dta);

                //Костыль
                dta = new Samoyloff.Terminal.TerminalData();
                dta.Data = (byte)10;
                dta.InOut = Samoyloff.Terminal.INOUT.OUT;
                ((MainForm)(DockPanel.Parent)).TerminalData.Add(dta);
            }

            
            send_thread = new Thread(SendData);
            send_thread.Start();

            ((MainForm)(DockPanel.Parent)).UpdateTextBoxes();
        }
    }
}
