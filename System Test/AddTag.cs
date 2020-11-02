using ModbusTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System_Test.Comms;

namespace System_Test
{
    public partial class AddTag : Form
    {
        bool removeBeforeAdd = false;
        string originalName = "";
        string originalType = "";
        public Device Device { get; }

        public AddTag(Device device)
        {
            InitializeComponent();
            Device = device ;
        }
        public AddTag(Device device, BoolTag boolTag)
        {
            InitializeComponent();
            Device = device;
            RegisterAddress.Text = boolTag.ItemPath;
            TagName.Text = boolTag.Name;
            TagTypeSelection.SelectedIndex = 2;
            removeBeforeAdd = true;
            originalName = TagName.Text;
            originalType = TagTypeSelection.SelectedItem.ToString();
        }
        public AddTag(Device device, IntegerTag intTag)
        {
            InitializeComponent();
            Device = device;
            RegisterAddress.Text = intTag.ItemPath;
            TagName.Text = intTag.Name;
            TagTypeSelection.SelectedIndex = 0;
            removeBeforeAdd = true;
            originalName = TagName.Text;
            originalType = TagTypeSelection.SelectedItem.ToString();
        }
        public AddTag(Device device, SingleTag singleTag)
        {
            InitializeComponent();
            Device = device;
            RegisterAddress.Text = singleTag.ItemPath;
            TagName.Text = singleTag.Name;
            TagTypeSelection.SelectedIndex = 1;
            removeBeforeAdd = true;
            originalName = TagName.Text;
            originalType = TagTypeSelection.SelectedItem.ToString();
        }
        public AddTag(Device device, LongTag longTag)
        {
            InitializeComponent();
            Device = device;
            RegisterAddress.Text = longTag.ItemPath;
            TagName.Text = longTag.Name;
            TagTypeSelection.SelectedIndex = 3;
            removeBeforeAdd = true;
            originalName = TagName.Text;
            originalType = TagTypeSelection.SelectedItem.ToString();
        }


        private void SaveTag_Click(object sender, EventArgs e)
        {
            var type = TagTypeSelection.SelectedItem.ToString();
            string name = TagName.Text;

            if (removeBeforeAdd)
            {
                RemoveOld();
            }

            if (type == "Float")
            {
                Device.CreateSingleTag(name, RegisterAddress.Text);
            }
            else if (type == "Integer (16-bit)")
            {
                Device.CreateIntegerTag(name, RegisterAddress.Text);
            }
            else if (type == "Boolean")
            {
                Device.CreateBoolTag(name, RegisterAddress.Text);
            }
            else if (type == "Integer (32-bit)")
            {
                Device.CreateLongTag(name, RegisterAddress.Text);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RemoveOld()
        {
            switch (originalType)
            {
                case "Float":
                    Device.SingleTags.Remove(originalName);
                    break;
                case "Integer (16-bit)":
                    Device.IntegerTags.Remove(originalName);
                    break;
                case "Boolean":
                    Device.BoolTags.Remove(originalName);
                    break;
                case "Integer (32-bit)":
                    Device.LongTags.Remove(originalName);
                    break;
                default:
                    break;
            }
        }
    }
}
