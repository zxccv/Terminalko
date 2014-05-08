using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samoyloff.Terminal
{
    public enum INOUT
    { IN, OUT };

    public struct TerminalData
    {
        INOUT inout;

        public INOUT InOut
        {
            get { return inout; }
            set { inout = value; }
        }

        byte data;

        public byte Data
        {
            get { return data; }
            set { data = value; }
        }

        bool sent;

        public bool Sent
        {
            get { return sent; }
            set { sent = value; }
        }
    }

    class TerminalDataArray
    {
        List<TerminalData> terminal_data;

        public List<TerminalData> Data
        {
            get { return terminal_data; }
            set { terminal_data = value; }
        }



        public TerminalDataArray()
        { terminal_data = new List<TerminalData>(); }    
    }
}
