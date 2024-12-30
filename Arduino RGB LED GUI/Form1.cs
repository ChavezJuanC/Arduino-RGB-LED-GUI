using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Arduino_RGB_LED_GUI
{
    public partial class MasterForm : Form
    {
        public string RedValue { get; set; }
        public string GreenValue { get; set; }
        public string BlueValue { get; set; }

        private SerialPort _serialPort;

        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM1", 9600);
            _serialPort.Open();
            GreenValue = "0";
            BlueValue = "0";

            RedInput.Text = RedValue;
            GreenInput.Text = GreenValue;
            BlueInput.Text = BlueValue;
        }

        private void RGBSumButton_Click(object sender, EventArgs e)
        {
            //Send data to arduino..
            string RGB = $"{RedValue},{GreenValue},{BlueValue}";
            Console.WriteLine(RGB);
            WriteToPort(RGB);
        }

        private void WriteToPort(string RGB)
        {
            try
            {
                _serialPort.Write(RGB);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0}", e.Message);
            }
        }

        private void RedInput_TextChanged(object sender, EventArgs e)
        {
            RedValue = RedInput.Text.PadLeft(3, '0');

            if (String.IsNullOrEmpty(RedValue))
            {
                RedValue = "000";
            }

            UpdateRGBColor();
        }

        private void GreenInput_TextChanged(object sender, EventArgs e)
        {
            GreenValue = GreenInput.Text.PadLeft(3, '0');

            if (String.IsNullOrEmpty(GreenValue))
            {
                GreenValue = "000";
            }

            UpdateRGBColor();
        }

        private void BlueInput_TextChanged(object sender, EventArgs e)
        {
            BlueValue = BlueInput.Text.PadLeft(3, '0');

            if (String.IsNullOrEmpty(BlueValue))
            {
                BlueValue = "000";
            }

            UpdateRGBColor();
        }

        private void UpdateRGBColor()
        {
            int red = string.IsNullOrEmpty(RedValue) ? 0 : Int32.Parse(RedValue);
            int green = string.IsNullOrEmpty(GreenValue) ? 0 : Int32.Parse(GreenValue);
            int blue = string.IsNullOrEmpty(BlueValue) ? 0 : Int32.Parse(BlueValue);

            RGBSumButton.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
