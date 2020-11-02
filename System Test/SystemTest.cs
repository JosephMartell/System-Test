using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ModbusTCP;
using System_Test.Comms;
using System_Test.Test;
using System.Net.Sockets;

namespace System_Test
{
    public partial class SystemTest : Form
    {
        public string FileName { get; set; }
        Device device = DeviceFactory.GetOrCreateDevice("VM Test", System.Net.IPAddress.Parse("192.168.245.129"), 502);
        public delegate void UpdateTickCount();
        TestEngine engine;
        private Task ActiveTestRun { get; set; }
        BindingList<Test.Definition> tests = new BindingList<Test.Definition>();
        public SystemTest()
        {
            InitializeComponent();
            UpdateListView();
        }
        private void PlayAllTests_Click(object sender, EventArgs e)
        {
            if (engine != null)
            {
                try
                {
                    PlayAllTests.Enabled = false;
                    PlaySelectedTests.Enabled = false;
                    device.Client.Connect();
                    testsInProgress.Enabled = true;
                    testsInProgress.Value = 0;
                    testsInProgress.Maximum = engine.Tests.Count();
                    var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
                    ActiveTestRun = Task.Run(() => engine.ExecuteAllTests())
                        .ContinueWith(delegate { FinishTesting(); }, uiScheduler);

                }
                catch (SocketException)
                {
                    MessageBox.Show("Could not connect to target device. Check you connection and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FinishTesting()
        {
            if (engine != null)
            {
                tests = (BindingList<Definition>)engine.Tests;
                device.Client.Disconnect();
            }
            ActiveTestRun = null;
            UpdateListView();
            PlayAllTests.Enabled = true;
            PlaySelectedTests.Enabled = true;
            testsInProgress.Enabled = false;
        }
        private void AddTest_Click(object sender, EventArgs e)
        {
            TestSetup frmTestSetup = new TestSetup();
            if (frmTestSetup.ShowDialog() == DialogResult.OK)
            {
                tests.Add(frmTestSetup.TestDefinition);
                UpdateListView();
            }
        }
        private void FileMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XDocument doc = new XDocument(new XElement("SystemTests"
                    , new XElement("Tags"
                    , device.IntegerTags.Select(t => Comms.XMLTranslator.TranslateTag(t.Value))
                    , device.SingleTags.Select(t => Comms.XMLTranslator.TranslateTag(t.Value))
                    , device.BoolTags.Select(t => Comms.XMLTranslator.TranslateTag(t.Value)))
                    , tests.Select(s => Test.XMLTranslator.TranslateDefinition(s))));


                doc.Save(sfd.FileName);
            }
            
        }
        private void FileMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                this.Text = "System Test - " + FileName.Substring(FileName.LastIndexOf("\\") + 1);
                tests.Clear();
                device.BoolTags.Clear();
                device.IntegerTags.Clear();
                device.SingleTags.Clear();
                device.LongTags.Clear();
                var saveDoc = XDocument.Load(ofd.FileName);
                Test.XMLTranslator.TranslateXML(saveDoc).ToList().ForEach(tests.Add);
                Comms.XMLTranslator.AddTagsToDevice(device, saveDoc);

                engine = new TestEngine(device, tests);
                engine.TestCompleteEvent += Engine_TestCompleteEvent;

                UpdateListView();
            }
        }

        private void Engine_TestCompleteEvent(object sender, EventArgs e)
        {
            if (testsInProgress.InvokeRequired)
            {
                Action d = () => testsInProgress.Value += 1;
                testsInProgress.Invoke(d);
            }
            else
            {
                testsInProgress.Value += 1;
            }
        }

        private void FileMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CommsMenuManage_Click(object sender, EventArgs e)
        {
            var devWindow = new Devices();
            devWindow.Show();
        }
        private void CommsMenuTags_Click(object sender, EventArgs e)
        {
            var tagsWindow = new Tags();
            tagsWindow.Show();
        }
        private void SystemTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            device.Client.Disconnect();
            device.Client.Dispose();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            foreach (var test in tests)
            {
                ListViewItem item = new ListViewItem();
                item.Text = test.Name;
                item.Tag = test;
                if (test.TestComplete)
                {
                    if (test.TestPass)
                        item.BackColor = Color.Green;
                    else
                        item.BackColor = Color.Red;
                }
                else
                    item.BackColor = Color.White;
                listView1.Items.Add(item);
                listView1.Refresh();
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                EditTest.Enabled = true;
            }
            else
            {
                EditTest.Enabled = false;
            }
        }
        private void EditTest_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var oldTest = (Test.Definition)listView1.SelectedItems[0].Tag;
                TestSetup frmTestSetup = new TestSetup(oldTest);
                if (frmTestSetup.ShowDialog() == DialogResult.OK)
                {
                    var index = tests.IndexOf(oldTest);
                    tests.RemoveAt(index);
                    tests.Insert(index,frmTestSetup.TestDefinition);
                    UpdateListView();
                }
            }
        }
        private void DeleteTestButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                tests.Remove((Definition)listView1.SelectedItems[0].Tag);
                UpdateListView();
            }
        }
        private void PlaySelectedTests_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (engine != null)
                {
                    List<Definition> testSubset = new List<Definition>();
                    foreach (int index in listView1.SelectedIndices)
                    {
                        testSubset.Add((Definition)listView1.Items[index].Tag);
                    }
                    PlayAllTests.Enabled = false;
                    PlaySelectedTests.Enabled = false;
                    testsInProgress.Enabled = true;
                    testsInProgress.Value = 0;
                    testsInProgress.Maximum = testSubset.Count();
                    try
                    {
                        device.Client.Connect();
                        var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
                        ActiveTestRun = Task.Run(() => engine.ExecuteTestSet(testSubset))
                            .ContinueWith(delegate { FinishTesting(); }, uiScheduler);
                    }
                    catch (SocketException)
                    {
                        MessageBox.Show("Could not connect to target device. Check you connection and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
