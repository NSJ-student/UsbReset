using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace UsbReset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listUsbDevice.DisplayMember = "Caption";
            btnUsbEnable.Enabled = false;
            btnUsbDisable.Enabled = false;
        }

        private void btnLoadUsbDevices_Click(object sender, EventArgs e)
        {
            List<USBDeviceInfo> usbDevices = GetUSBDevices();

            foreach (USBDeviceInfo usbDevice in usbDevices)
            {
                listUsbDevice.Items.Add(usbDevice);
                Console.WriteLine(
                    $"Device ID: {usbDevice.DeviceID}, " +
                    $"PNP Device ID: {usbDevice.PnpDeviceID}, " +
                    $"Description: {usbDevice.Description}, " +
                    $"Caption: {usbDevice.Caption}");
            }

        }

        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            try
            {
                var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity WHERE Caption like '%(COM%'");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject device in collection)
                {
                    devices.Add(new USBDeviceInfo(
                        device,
                        (string)device.GetPropertyValue("DeviceID"),
                        (string)device.GetPropertyValue("PNPDeviceID"),
                        (string)device.GetPropertyValue("Description"),
                        (string)device.GetPropertyValue("Caption")
                        ));
                }
            }
            catch
            {
            }

            return devices;
        }

        private void listUsbDevice_DoubleClick(object sender, EventArgs e)
        {
            if(listUsbDevice.SelectedItem != null)
            {
                ManagementObject obj = ((USBDeviceInfo)listUsbDevice.SelectedItem).BaseObject;

                btnUsbEnable.Enabled = true;
                btnUsbDisable.Enabled = true;
                lblDeviceID.Text = (string)obj.GetPropertyValue("DeviceID");
                lblPnpDeviceID.Text = (string)obj.GetPropertyValue("PNPDeviceID");
                lblDescription.Text = (string)obj.GetPropertyValue("Description");
                lblCaption.Text = (string)obj.GetPropertyValue("Caption");
                lblStatus.Text = (string)obj.GetPropertyValue("Status");
            }
        }

        private void btnUsbEnable_Click(object sender, EventArgs e)
        {
            if (listUsbDevice.SelectedItem != null)
            {
                ManagementObject obj = ((USBDeviceInfo)listUsbDevice.SelectedItem).BaseObject;

                try
                {
                    obj.InvokeMethod("Enable", null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnUsbDisable_Click(object sender, EventArgs e)
        {
            if (listUsbDevice.SelectedItem != null)
            {
                ManagementObject obj = ((USBDeviceInfo)listUsbDevice.SelectedItem).BaseObject;

                try
                {
                    obj.InvokeMethod("Disable", null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(ManagementObject obj, string deviceID, string pnpDeviceID, string description, string caption)
        {
            this.BaseObject = obj;
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
            this.Caption = caption;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
        public string Caption { get; private set; }
        public ManagementObject BaseObject { get; private set; }

        public override string ToString()
        {
            return Caption;
        }
    }
}
