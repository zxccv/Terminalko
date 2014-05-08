using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO.Ports;

namespace Terminal
{
    public partial class SettingsForm : DockContent
    {
        MainForm main_form;

        bool change_in_progress = false;//Будем засекать программное изменение

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void LoadSettingsFromMainForm()
        {
            change_in_progress = true;

            main_form = (MainForm)(DockPanel.Parent);
            Profile current_profile = main_form.Settings.ActiveProfile;

            cbPort.Items.Add(current_profile.Port);
            cbPort.Text = current_profile.Port;
            cbBaudRate.Text = Convert.ToString(current_profile.BaudRate);
            cbDataBits.Text = Convert.ToString(current_profile.DataBits);

            string par = "";
            switch (current_profile.Parity)
            {
                case Parity.None:
                    par = "None";
                    break;
                case Parity.Odd:
                    par = "Odd";
                    break;
                case Parity.Even:
                    par = "Even";
                    break;
                case Parity.Mark:
                    par = "Mark";
                    break;
                case Parity.Space:
                    par = "Space";
                    break;    
            }

            cbParity.Text = par;

            string sb = "";

            switch (current_profile.StopBits)
            {
                case StopBits.One:
                    sb = "1";
                    break;
                case StopBits.OnePointFive:
                    sb = "1.5";
                    break;
                case StopBits.Two:
                    sb = "2";
                    break;
            }

            cbStopBits.Text = sb;

            checkboxAutoConnect.Checked = current_profile.AutoConnect;

            change_in_progress = false;

        }

        private void FillSettingsInMainForm()
        {
            main_form = (MainForm)(DockPanel.Parent);
            Profile current_profile = main_form.Settings.ActiveProfile;

            //Port
            current_profile.Port = cbPort.Text;
            
            //BaudRate
            try
            {
                Convert.ToInt32(cbBaudRate.Text);
            }
            catch (Exception)
            {
                cbBaudRate.Text = "9600";
                MessageBox.Show("Неверно введена скорость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            current_profile.BaudRate = Convert.ToInt32(cbBaudRate.Text);

            //DataBits
            current_profile.DataBits = Convert.ToInt32(cbDataBits.Text);  

            //Parity
            Parity par = new Parity();
            switch (cbParity.Text)
            {
                case "None":
                    par = Parity.None;
                    break;
                case "Odd":
                    par = Parity.Odd;
                    break;
                case "Even":
                    par = Parity.Even;
                    break;
                case "Mark":
                    par = Parity.Mark;
                    break;
                case "Space":
                    par = Parity.Space;
                    break;
            }
            current_profile.Parity = par;

            //StopBits
            StopBits sb = new StopBits();
            switch (cbStopBits.Text)
            {
                case "1":
                    sb = StopBits.One;
                    break;
                case "1.5":
                    sb = StopBits.OnePointFive;
                    break;
                case "2":
                    sb = StopBits.Two;
                    break;
            }
            current_profile.StopBits = sb;

            //Автосоединение
            current_profile.AutoConnect = checkboxAutoConnect.Checked;



        }

        private void cbPort_DropDown(object sender, EventArgs e)
        {
            cbPort.Items.Clear();
            string[] port_names = SerialPort.GetPortNames();
            foreach (string port_name in port_names)
            {
                cbPort.Items.Add(port_name);
            }

        }

        private void SettingChanged(object sender, EventArgs e)
        {
            if(!change_in_progress)
                FillSettingsInMainForm();            
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettingsFromMainForm();
        }




    }
}
