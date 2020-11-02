using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System_Test.Comms;

namespace System_Test
{
    public partial class Tags : Form
    {
        public Tags()
        {
            InitializeComponent();
            UpdateTagList();
        }

        Device Device = DeviceFactory.GetDevice("VM Test");
        private void Tags_Load(object sender, EventArgs e)
        {
        }

        private void UpdateTagList()
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(Device.IntegerTags.Select(t => new ListViewItem(new string[] { t.Value.Name, t.Value.ItemPath }) { Tag = t.Value, Text = t.Value.Name }).ToArray());
            listView1.Items.AddRange(Device.SingleTags.Select(t => new ListViewItem(new string[] { t.Value.Name, t.Value.ItemPath }) { Tag = t.Value, Text = t.Value.Name }).ToArray());
            listView1.Items.AddRange(Device.BoolTags.Select(t => new ListViewItem(new string[] { t.Value.Name, t.Value.ItemPath }) { Tag = t.Value, Text = t.Value.Name }).ToArray());
            listView1.Items.AddRange(Device.LongTags.Select(t => new ListViewItem(new string[] { t.Value.Name, t.Value.ItemPath }) { Tag = t.Value, Text = t.Value.Name }).ToArray());
            listView1.Refresh();
        }
        private void AddTag_Click(object sender, EventArgs e)
        {
            var addTagWindow = new AddTag(Device);
            addTagWindow.ShowDialog();
            UpdateTagList();
        }

        private void DeleteTag_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0].Tag;
                if (selectedItem.GetType() == typeof(BoolTag))
                {
                    Device.BoolTags.Remove(((BoolTag)selectedItem).Name);
                }
                else if (selectedItem.GetType() == typeof(IntegerTag))
                {
                    Device.IntegerTags.Remove(((IntegerTag)selectedItem).Name);
                }
                else if (selectedItem.GetType() == typeof(SingleTag))
                {
                    Device.SingleTags.Remove(((SingleTag)selectedItem).Name);
                }
                else if (selectedItem.GetType() == typeof(LongTag))
                {
                    Device.LongTags.Remove(((LongTag)selectedItem).Name);
                }
                UpdateTagList();
            }
        }

        private void editTag_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                AddTag tagFrm;
                var selectedItem = listView1.SelectedItems[0].Tag;
                if (selectedItem.GetType() == typeof(BoolTag))
                {
                    tagFrm = new AddTag(Device, selectedItem as BoolTag);
                    tagFrm.ShowDialog();
                }
                else if (selectedItem.GetType() == typeof(IntegerTag))
                {
                    tagFrm = new AddTag(Device, selectedItem as IntegerTag);
                    tagFrm.ShowDialog();
                }
                else if (selectedItem.GetType() == typeof(SingleTag))
                {
                    tagFrm = new AddTag(Device, selectedItem as SingleTag);
                    tagFrm.ShowDialog();
                }
                else if (selectedItem.GetType() == typeof(LongTag))
                {
                    tagFrm = new AddTag(Device, selectedItem as LongTag);
                    tagFrm.ShowDialog();
                }

                UpdateTagList();
            }
        }
    }
}
