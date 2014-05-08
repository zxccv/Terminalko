using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using WeifenLuo.WinFormsUI.Docking;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;
using UsingsRU.Patterns;

namespace Terminal
{
    
    public partial class MainForm : Form
    {
        bool update_in_progress;
          

        private Settings settings;

        public Settings Settings
        {
            get { return settings; }
            set { settings = value; }
        }

        private SettingsForm sett_form;
        private MacrosForm macros_form;
        private SendForm send_form;
        
        private List<TextForm> textforms;

        public List<TextForm> TextForms
        {
            get { return textforms; }
        }

        public delegate void DataReceived();

        public DataReceived myDelegate;

        public delegate void TimerDelegate();

        public TimerDelegate myStartTimer;
        public TimerDelegate myStopTimer;

        private SerialPort serial_port;

        public SerialPort SerPort
        {
            get { return serial_port; }
        }

        List<Samoyloff.Terminal.TerminalData> terminal_data;

        public List<Samoyloff.Terminal.TerminalData> TerminalData
        {
            get { return terminal_data; }
            set{ TerminalData = value; }
        }

       

        private DeserializeDockContent m_deserializeDockContent;

        public MainForm()
        {
            InitializeComponent();

            textforms = new List<TextForm>();
            terminal_data = new List<Samoyloff.Terminal.TerminalData>();

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);

            serial_port = new SerialPort();
           
            //Загрузим настройки
            try
            {
                XmlTextReader reader = new XmlTextReader(Application.StartupPath + "\\settings.xml");
                try
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    Settings = (Settings)serializer.Deserialize(reader);
                    reader.Close();
                }

                catch (Exception exc)
                {
                    reader.Close();
                    throw exc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Настройки не загружены. Заполним стандартными.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Settings = new Settings();
                //Settings.Profiles = new List<Profile>();
                Settings.Profiles.Add(new Profile());
                Settings.ActiveProfile = Settings.Profiles[0];
                Profile active_profile = Settings.ActiveProfile;

                active_profile.BaudRate = 9600;
                active_profile.DataBits = 8;
                active_profile.StopBits = StopBits.One;
                active_profile.Parity = Parity.None;
                active_profile.Port = "";
            };

        }

        

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(SettingsForm).ToString())
                return sett_form;
            else if (persistString == typeof(MacrosForm).ToString())
                return macros_form;
            else if (persistString == typeof(SendForm).ToString())
                return send_form;
            else
            {                
                string[] parsedStrings = persistString.Split(new char[] { ',' });
                if (parsedStrings.Length != 3)
                    return null;
                
                if (parsedStrings[0] != typeof(TextForm).ToString())
                    return null;

                TextForm newTextForm = new TextForm();
                newTextForm.SendReceive = parsedStrings[1];
                newTextForm.DataType = parsedStrings[2];
                newTextForm.TB.DataArray = terminal_data;

                textforms.Add(newTextForm);

                return newTextForm;
                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sett_form = new SettingsForm();
            macros_form = new MacrosForm();
            send_form = new SendForm();

            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);

            sett_form_shown.Checked = (sett_form.DockPanel != null && sett_form.DockState != DockState.Hidden);
            macros_form_shown.Checked = (macros_form.DockPanel != null && macros_form.DockState != DockState.Hidden);
            send_form_shown.Checked = (send_form.DockPanel != null && send_form.DockState != DockState.Hidden);

            myStartTimer = new TimerDelegate(UpdateTimer.Start);
            myStopTimer = new TimerDelegate(UpdateTimer.Stop);

            myDelegate = new DataReceived(UpdateTextBoxes);

            PortStatusTimer.Start();
                       
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            dockPanel.SaveAsXml(configFile);

            //Сохраним настройки
            try
            {
                System.Xml.XmlWriter writer = new XmlTextWriter(Application.StartupPath + "\\settings.xml", System.Text.Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(Terminal.Settings));
                serializer.Serialize(writer, Settings);
                writer.Close();                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sett_form_shown_Click(object sender, EventArgs e)
        {
            if (sett_form == null)
                sett_form = new SettingsForm();
            StateChange(sett_form_shown, sett_form);
        }

        private void macros_form_shown_Click(object sender, EventArgs e)
        {
            StateChange(macros_form_shown, macros_form);       
        }

        private void send_form_shown_Click(object sender, EventArgs e)
        {
            StateChange(send_form_shown, send_form);
        }

        private void StateChange(ToolStripButton btn, DockContent frm)
        {
            if (!btn.Checked && frm.DockState != DockState.Hidden)
            {
                frm.DockState = DockState.Hidden;
            }

            if (btn.Checked && (frm.DockState == DockState.Hidden || frm.DockPanel == null))
            {
                frm.Show(dockPanel);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(myStartTimer);

            if (serial_port.BytesToRead > 0)
            {
                int to_read = serial_port.BytesToRead;
                byte[] bytes = new byte[to_read];
                int data = serial_port.Read(bytes, 0, to_read);
                if (data <= 0)
                    return;

                this.Invoke(myStartTimer);

                for (int i = 0; i < data; i++)
                {
                    Samoyloff.Terminal.TerminalData dta = new Samoyloff.Terminal.TerminalData();
                    dta.Data = bytes[i];
                    dta.InOut = Samoyloff.Terminal.INOUT.IN;
                    terminal_data.Add(dta);
                }

                this.Invoke(myStopTimer);
                this.Invoke(this.myDelegate);
            }   
        }

        public void UpdateTextBoxes()
        {
            if (update_in_progress)
                return;
            update_in_progress = true;
            foreach (TextForm tf in textforms)
            {                
                tf.TB.DrawText();
            }
            update_in_progress = false;
        }

        public void ClearTextBoxes()
        {            
            foreach (TextForm tf in textforms)
            {
                tf.TB.LastNumber = 0;
                tf.TB.Clear();
            }

        }

        private void tbConnect_Click(object sender, EventArgs e)
        {
            Profile current_profile = Settings.ActiveProfile;
            
            try
            {
                AutoConnectTimer.Stop();

                serial_port.PortName = current_profile.Port;
                serial_port.BaudRate = current_profile.BaudRate;
                serial_port.DataBits = current_profile.DataBits;
                serial_port.StopBits = current_profile.StopBits;
                serial_port.Parity = current_profile.Parity;
                serial_port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                serial_port.Open();
                tbConnect.Enabled = false;
                tbDisconnect.Enabled = true;
                sett_form.Enabled = false;
                AutoConnectTimer.Start();
            }
            catch (Exception) 
            {
                MessageBox.Show("Соединиться не вышло. Проверяйте настройки.");
            };
            
        }

        private void tbDisconnect_Click(object sender, EventArgs e)
        {

            try
            {
                serial_port.Close();
                tbConnect.Enabled = true;
                tbDisconnect.Enabled = false;
                sett_form.Enabled = true;
                if (sender == tbDisconnect) 
                    AutoConnectTimer.Stop();
            }
            catch (Exception) { };           
        }

        private void tbAddTextForm_Click(object sender, EventArgs e)
        {
            TextForm newTextForm = new TextForm();
            newTextForm.TB.DataArray = terminal_data;
            
            textforms.Add(newTextForm);
            
            newTextForm.Show(dockPanel);

            newTextForm.TB.DrawText();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        public void UpdateSelection(Interval<int> interval,TextForm sender)
        {
            foreach (TextForm frm in textforms)
            {
                if (frm == sender || frm.TB.TbInOut != sender.TB.TbInOut)
                    continue;
                frm.TB.SetSelData(interval);
            }
        }

        private void PortStatusTimer_Tick(object sender, EventArgs e)
        {
            if (serial_port!= null && !serial_port.IsOpen)
            {
                tbDisconnect_Click(sender, e);                
            }            
        }

        private void AutoConnectTimer_Tick(object sender, EventArgs e)
        {
            if (serial_port != null && !serial_port.IsOpen)
            {
                //Автоконнект
                if (Settings.ActiveProfile.AutoConnect)
                {
                    string[] ports = SerialPort.GetPortNames();
                    if (ports.Contains(Settings.ActiveProfile.Port))
                    {
                        tbConnect_Click(sender, e);
                    }
                }
            }
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            terminal_data.Clear();
            ClearTextBoxes();
        }

        

        

        

       
    }
}
