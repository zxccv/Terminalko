using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO.Ports;

namespace Terminal
{
    [Serializable]
    public class Profile
    {
        string name;
        
        [XmlAttribute("Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string port;

        [XmlAttribute("Port")]
        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        int baud_rate;

        [XmlAttribute("BaudRate")]
        public int BaudRate
        {
            get { return baud_rate; }
            set { baud_rate = value; }
        }

        int data_bits;

        [XmlAttribute("DataBits")]
        public int DataBits
        {
            get { return data_bits; }
            set { data_bits = value; }
        }

        Parity parity;

        [XmlAttribute("Parity")]
        public Parity Parity
        {
            get { return parity; }
            set { parity = value; }
        }

        StopBits stop_bits;

        [XmlAttribute("StopBits")]
        public StopBits StopBits
        {
            get { return stop_bits; }
            set { stop_bits = value; }
        }

        Handshake handshake;

        [XmlAttribute("Handshake")]
        public Handshake Handshake
        {
            get { return handshake; }
            set { handshake = value; }
        }

        bool autoconnect;

        [XmlAttribute("AutoConnect")]
        public bool AutoConnect
        {
            get { return autoconnect; }
            set { autoconnect = value; }
        }       
        

        public Profile() { }

    }

    [Serializable]
    public class Settings
    {
        private Profile active_profile;

        [XmlElement("ActiveProfile", typeof(Profile))]
        public Profile ActiveProfile
        {
            get { return active_profile; }
            set { active_profile = value; }
        }

        private List<Profile> profiles;        

        [XmlArrayItem("Profile", typeof(Profile))]
        public List<Profile> Profiles
        {
            get { return profiles; }
            set { profiles = value; }
        }

        public Settings()
        {
            profiles = new List<Profile>();
        }

    }
}
