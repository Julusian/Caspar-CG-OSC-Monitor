using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Below namepaces are required for OSC operation
using System.Net;
using System.Threading;
using Bespoke.Common;
using Bespoke.Common.Osc;

namespace Caspar_CG_OSC_Monitor
{
    public class RangeObservableCollection<T> : BindingList<T>
    {
        private bool _suppressNotification = false;

        public RangeObservableCollection()
        {
            _suppressNotification = true;
        }

        public RangeObservableCollection(IList<T> list) : base(list)
        {
            _suppressNotification = true;
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (!_suppressNotification)
                base.OnListChanged(e);
        }

        public void AddRange(IEnumerable<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

//            _suppressNotification = true;

            foreach (T item in list)
                Add(item);

//            _suppressNotification = false;
//            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, 0));
        }

        public void FireChange()
        {
            _suppressNotification = false;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
            _suppressNotification = true;
        }
    }

    public partial class formMain : Form
    {
        /// <summary>
        /// OSC Server instance
        /// </summary>
        private OscServer _OscServer = new OscServer(TransportType.Udp, IPAddress.Any, 6250);

        private readonly RangeObservableCollection<RowEntry> rows = new RangeObservableCollection<RowEntry>();
        private string filterText = "";

        public class RowEntry
        {
            public string Date { get; }
            public string Address { get; }
            public string D1 { get; }
            public string D2 { get; }
            public string D3 { get; }

            public RowEntry(string date, string address, string d1, string d2, string d3)
            {
                Date = date;
                Address = address;
                D1 = d1;
                D2 = d2;
                D3 = d3;
            }
        }

        public formMain()
        {
            InitializeComponent();
            //Subscribe to events that the OSC server raises, Message and BundleReceived
            //some messages from Caspar are sent as bundles/groups of messages, others as
            //individual messages so we need to listen to both to get all data about what
            //Caspar is doing

            dataGridViewIncomingMessages.DataSource = rows;

            Task.Run(() =>
            {
                while (true)
                {
                    if (this._OscServer.IsRunning)
                    {
                        dataGridViewIncomingMessages.BeginInvoke(new MethodInvoker(() =>
                        {
                            rows.FireChange();
                        }));
                    }

                    Thread.Sleep(1000);
                }
            });

        }
        /// <summary>
        /// Handle incoming bundles/groups of messages from the OSC server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _OscServer_BundleReceived(object sender, OscBundleReceivedEventArgs e)
        {
            var msgs = e.Bundle.Messages.Select(FilterOscMessage).Where(m => m != null).ToArray();
            if (msgs.Length == 0)
                return;

            dataGridViewIncomingMessages.BeginInvoke(new MethodInvoker(() =>
            {
                rows.AddRange(msgs);
            }));
        }
        /// <summary>
        /// Handle incoming individual messages from the OSC Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _OscServer_MessageReceived(object sender, OscMessageReceivedEventArgs e)
        {
            var msg = FilterOscMessage(e.Message);
            if (msg == null)
                return;

            dataGridViewIncomingMessages.BeginInvoke(new MethodInvoker(() =>
            {
                rows.Add(msg);
            }));
        }
        /// <summary>
        /// Allows basic filtering of some OSC messages before printing the messages to screen
        /// </summary>
        /// <param name="m"></param>
        private RowEntry FilterOscMessage(OscMessage m)
        {
            if (m.Data.Count == 0) return null;

            string d1 = m.Data[0].ToString();
            string d2 = (m.Data.Count > 1) ? m.Data[1].ToString() : null;
            string d3 = (m.Data.Count > 2) ? m.Data[2].ToString() : null;

            if (m.Address.IndexOf(filterText, StringComparison.InvariantCulture) != 0) return null;

            return new RowEntry(DateTime.Now.ToString("HH:mm:ss"), m.Address, d1, d2, d3);
        }

        /// <summary>
        /// Button click event allowing us to start and stop the OSC Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartStopServer_Click(object sender, EventArgs e)
        {
            if (this._OscServer.IsRunning) //Stop the server
            {
                this.numericUpDownOSCPort.Enabled = true;
                this.buttonStartStopServer.Text = "Start Server";
                this._OscServer.Stop();
                this._OscServer.MessageReceived -= _OscServer_MessageReceived;
                this._OscServer.BundleReceived -= _OscServer_BundleReceived;
            }
            else // Start the server
            {
                this.numericUpDownOSCPort.Enabled = false;
                this.buttonStartStopServer.Text = "Stop Server";
                this._OscServer = new OscServer(TransportType.Udp, IPAddress.Any, (int)this.numericUpDownOSCPort.Value);
                this._OscServer.MessageReceived += _OscServer_MessageReceived;
                this._OscServer.BundleReceived += _OscServer_BundleReceived;
                this._OscServer.Start();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            rows.Clear();
            dataGridViewIncomingMessages.BeginInvoke(new MethodInvoker(() =>
            {
                rows.FireChange();
            }));
        }

        private void filterChanged(object sender, EventArgs e)
        {
            filterText = filterBox.Text;
        }
    }
}
