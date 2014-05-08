using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Samoyloff.Terminal;

namespace Samoyloff.Terminal.TerminalTextBox
{
    public enum TbTypes { ASCII, DEC, HEX, BINARY };
    public enum TbInOut { IN, OUT, INOUT };
    public partial class TerminalTextBox : TextBox
    {
        TbTypes tb_type;
        TbInOut tb_in_out;

        public TbTypes TbType
        {
            get { return tb_type; }
            set { tb_type = value; }
        }

        public TbInOut TbInOut
        {
            get { return tb_in_out; }
            set { tb_in_out = value; }
        }

        List<TerminalData> data_array;

        public List<TerminalData> DataArray
        {
            get { return data_array; }
            set { data_array = value; }
        }

        int last_number = 0;

        public int LastNumber
        {
            set { last_number = value; }
            get { return last_number; }
        }

        private event EventHandler onSelectionChange;
        [Category("Change"), Description("Вызывается при смене выделения")]
        public event EventHandler OnSelectionChange
        {
            add
            {
                onSelectionChange += value;
            }
            remove
            {
                onSelectionChange -= value;
            }
        }

        private void OnChangeProperties()
        {
            Invalidate();
            if (onSelectionChange != null)
            {
                onSelectionChange(this, new EventArgs());
            }
        }

        private string CheckHex(string input)
        {
            string result = input;
            if (input.Length % 2 != 0)
                result = '0' + result;
            return result;
        }

        private byte Hex2Dec(string input)
        {
            byte result = 0;
            result = byte.Parse(input, System.Globalization.NumberStyles.HexNumber);
            return result;
        }

        private string Dec2Hex(byte input)
        {
            string result = string.Empty;
            result = input.ToString("X");
            return CheckHex(result);
        }

        public void DrawText()
        {
            string txt = this.Text;
            if(last_number >= data_array.Count)
                return;
            for (int i = last_number; i < data_array.Count; i++)
            {
                if (data_array[i].InOut == INOUT.IN && tb_in_out == Terminal.TerminalTextBox.TbInOut.OUT)
                    continue;
                if (data_array[i].InOut == INOUT.OUT && tb_in_out == Terminal.TerminalTextBox.TbInOut.IN)
                    continue;

                if (tb_type == TbTypes.ASCII)
                {
                    if (data_array[i].Data == 0)
                        txt += "<0>";
                    else
                        if (data_array[i].Data == 13)
                            txt += Environment.NewLine;
                        else
                            txt += (char)(data_array[i].Data);
                }
                else if (tb_type == TbTypes.HEX)
                {
                    txt += Dec2Hex(data_array[i].Data);
                    txt += " ";
                }
            }

            this.Text = txt;

            SelectionStart = Text.Length;
            ScrollToCaret();

            last_number = data_array.Count;
        }

        int CurrentTBIndexIncrease(int tb_index, byte data)
        {
            if (tb_type == TbTypes.ASCII)
            {
                switch (data)
                {
                    case 0:
                        return tb_index + 3;
                    case 13:
                        return tb_index + 2;
                    default:
                        return tb_index + 1;
                }
            }
            else if (tb_type == TbTypes.HEX)
            {
                return tb_index + 3;
            }


            return tb_index;
        }


        public UsingsRU.Patterns.Interval<int> GetSelData()
        {
            if (SelectionLength == 0)
                return new UsingsRU.Patterns.Interval<int>(0, 0);
            int StartIndex = -1, StopIndex = -1, CurrenTBIndex = 0;
            for (int i = 0; i < DataArray.Count; i++)
            {
                if (tb_in_out == Terminal.TerminalTextBox.TbInOut.IN &&
                    DataArray[i].InOut == INOUT.OUT)
                    continue;
                if (tb_in_out == Terminal.TerminalTextBox.TbInOut.OUT &&
                    DataArray[i].InOut == INOUT.IN)
                    continue;

                if (CurrenTBIndex >= SelectionStart && StartIndex == -1)
                    StartIndex = i;

                if (CurrenTBIndex >= SelectionStart + SelectionLength && StopIndex == -1)
                {
                    StopIndex = i - 1;
                    break;
                }

                CurrenTBIndex = CurrentTBIndexIncrease(CurrenTBIndex, DataArray[i].Data);
               
            }

            if (StopIndex == -1) StopIndex = DataArray.Count - 1;

            return new UsingsRU.Patterns.Interval<int>(StartIndex, StopIndex);
        }

        public void SetSelData(UsingsRU.Patterns.Interval<int> data_interval)
        {
            if (data_interval.Min > data_interval.Max || data_interval.Max == 0)
            {
                SelectionLength = 0;
                return;
            }
            int CurrenTBIndex = 0;
            bool StartDefined = false;
            SelectionLength = 0;

            for (int i = 0; i < DataArray.Count; i++)
            {
                if (tb_in_out == Terminal.TerminalTextBox.TbInOut.IN &&
                    DataArray[i].InOut == INOUT.OUT)
                    continue;
                if (tb_in_out == Terminal.TerminalTextBox.TbInOut.OUT &&
                    DataArray[i].InOut == INOUT.IN)
                    continue;

                if (i >= data_interval.Min && !StartDefined)
                {
                    SelectionStart = CurrenTBIndex;
                    StartDefined = true;
                }

                if (i > data_interval.Max)
                {
                    SelectionLength = CurrenTBIndex - SelectionStart;
                    break;
                }

                CurrenTBIndex = CurrentTBIndexIncrease(CurrenTBIndex, DataArray[i].Data);
               
            }

            if (StartDefined && SelectionLength == 0)
                SelectionLength = TextLength;
        }

        public TerminalTextBox()
        {
            InitializeComponent();
        }

        private void TerminalTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                onSelectionChange(this, new EventArgs());
            }
        }
    }
}
