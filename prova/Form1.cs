using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnifiedAutomation.UaBase;
using UnifiedAutomation.UaClient;
namespace prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //m_Application = applicationInstance;
            //m_Application.Start();
            // what is this????
            /*
            for (uint ii = Attributes.First; ii <= Attributes.Last; ii++)
            {
                AttributeCB.Items.Add(new DropDownItem(ii));
            }
            AttributeCB.SelectedItem = new DropDownItem(Attributes.Value);
            */


        }
        //ApplicationInstance applicationInstance=new ApplicationInstance();

        private Session m_Session = null;
        public Session Session
        {
            get { return m_Session; }
            set { m_Session = value; }
        }

        private ApplicationInstance m_Application = null;
        readonly string m_defaultClientUrl = "opc.tcp://192.168.1.19:4840";
        readonly string m_defaultDiscoveryUrl = "opc.tcp://192.168.1.19:4840";
        private object m_lock = new object();
        string m_lastClientUrlsForReverseConnect;

        bool IsReverseConnectSelected
        {
            get
            {
                return DiscoveryTypeCB.SelectedIndex == 1;
            }
        }
        string DiscoveryUrl
        {
            get
            {
                string url = DiscoveryUrlCB.Text;
                if (String.IsNullOrEmpty(url))
                {
                    // Set the uri of the local discovery server by default.
                    url = "opc.tcp://192.168.1.19:4840";
                }
                else
                {
                    // Has the port been entered by the user?
                    char seperator = ':';
                    string[] portCheck = url.Split(seperator);
                    if (portCheck.Length == 1)
                    {
                        url += ":4840";
                    }
                }

                return url;
            }

            set
            {
                lock (m_lock)
                {
                    if (!DiscoveryUrlCB.Items.Contains(value))
                    {
                        DiscoveryUrlCB.Invoke(new Action(() => DiscoveryUrlCB.Items.Add(value)));
                        if (DiscoveryUrlCB.Items.Count != 0)
                        {
                            DiscoveryUrlCB.Invoke(new Action(() => DiscoveryUrlCB.SelectedIndex = 0));
                        }
                    }
                }
            }
        }
        string ClientUrlForReverseConnect
        {
            get
            {
                if (IsReverseConnectSelected)
                {
                    return m_lastClientUrlsForReverseConnect;
                }
                return null;
            }
        }
        private void Connect()
        {
            // Set wait cursor.
            Cursor = Cursors.WaitCursor;

            try
            {
                DisconnectIfRequired();

                // Extract Url from combobox text.
                EndpointDescription endpoint;
                if (!TryGetSelectedEndpoint(out endpoint))
                {
                    ConnectWithDiscoveryUrl();
                }
                else
                {
                    ConnectToSelectedEndpoint(endpoint);
                }
            }
            catch (Exception e)
            {
               
            }

            // Set default cursor.
            Cursor = Cursors.Default;
        }

        private void ConnectToSelectedEndpoint(EndpointDescription endpoint)
        {
            CreateSession();

            // Attach to events
            m_Session.ConnectionStatusUpdate += new ServerConnectionStatusUpdateEventHandler(Session_ServerConnectionStatusUpdate);

            // Call connect with endpoint
            if (!IsReverseConnectSelected)
            {
                m_Session.Connect(endpoint, null);
            }
            else
            {
                m_Session.ReverseConnect(endpoint, null);
            }
        }

        private void ConnectWithDiscoveryUrl()
        {
            CreateSession();

            m_Session.UseDnsNameAndPortFromDiscoveryUrl = true;
            m_Session.DefaultRequestSettings.OperationTimeout = 30000;

            // Attach to events
            m_Session.ConnectionStatusUpdate += new ServerConnectionStatusUpdateEventHandler(Session_ServerConnectionStatusUpdate);

            // Call connect with URL
            if (IsReverseConnectSelected)
            {
                m_Session.ReverseConnect(DiscoveryUrl, SecuritySelection.None);
            }
            else
            {
                try
                {
                      m_Session.Connect(DiscoveryUrl, SecuritySelection.None);
                }
                catch (Exception)
                {

                   this.Close();
                }
              
            }
        }

        bool TryGetSelectedEndpoint(out EndpointDescription endpoint)
        {
            object item = EndpointCB.SelectedItem;
            if (item == null || item.GetType() == typeof(string))
            {
                endpoint = null;
                return false;
            }
            endpoint = (item as EndpointWrapper).Endpoint;
            return true;
        }

      
        void CreateSession()
        {
            
            m_Session = new Session();
            
           
        }
        void DisconnectIfRequired()
        {
            if (m_Session != null)
            {
                Disconnect();
            }
        }
        private void Disconnect()
        {
            try
            {
                // Call the disconnect service of the server.
                m_Session.Disconnect(SubscriptionCleanupPolicy.Delete, null);
                m_Session.ConnectionStatusUpdate -= new ServerConnectionStatusUpdateEventHandler(Session_ServerConnectionStatusUpdate);
                m_Session.Dispose();
                m_Session = null;

            }
            catch (Exception ee)
            {
                lblerrors.Text = ee.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           

        }
        string[] nodo = new string[28];
        string[] Dativalue = new string[28];
        string[] Datilbl = new string[28];
        private void Form1_Load(object sender, EventArgs e)
        {
            
            nodo[0] = txtNumeroCassette.Text;
            nodo[1] = txtCiclo.Text;
            nodo[2] = txtCesto.Text;
            nodo[3] = txtAnnoI.Text;
            nodo[4] = txtMeseI.Text;
            nodo[5] = txtGiornoI.Text;
            nodo[6] = txtOraI.Text;
            nodo[7] = txtMinutiI.Text;
            nodo[8] = txtAnnoF.Text;
            nodo[9] = txtMeseF.Text;
            nodo[10] = txtGiornoF.Text;
            nodo[11] = txtOraF.Text;
            nodo[12] = txtMinutiF.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leggi_Dati();
        }
  


        private void Leggi_Dati()
        {
            if (m_Session != null)
            {

                try
                {
                    /// [Read Attribute]
                    // build a list of values to read.
                    List<ReadValueId> nodesToRead = new List<ReadValueId>();
                    nodesToRead.Clear();
                    //       Cursor = Cursors.WaitCursor;
                    for (int i = 0; i < 13; i++)
                    {

                        // parse the node id and get the selected attribute id.
                        NodeId nodeId = NodeId.Parse(nodo[i]);
                        uint attributeId = 13;// ((DropDownItem)AttributeCB.SelectedItem).AttributeId;

                        // read the display name and the selected attribute for the node.
                        nodesToRead.Add(new ReadValueId() { NodeId = nodeId, AttributeId = Attributes.DisplayName });
                        nodesToRead.Add(new ReadValueId() { NodeId = nodeId, AttributeId = attributeId });

                        // this is a blocking call so show the wait cursor.

                    }
                    // read the value (setting a 10 second timeout).

                    /// scade
                    List<DataValue> results = m_Session.Read(nodesToRead, 0, TimestampsToReturn.Both, new RequestSettings() { OperationTimeout = 10000 });
                    /// [Read Attribute]
                    int b = 0;
                    int c = 0;
                    do
                    {
                        Datilbl[c] = results[b].ToString();
                        Dativalue[c] = results[b + 1].ToString();
                        b = b + 2;
                        c++;
                    } while (b < 26);
                }
                catch (Exception)
                {

                    this.Close(); ;
                }
           


            }

          groupBox1.Text = "Numero ciclo: "+Dativalue[0];
            txtVciclo.Text = Dativalue[1];
            txtVcesto.Text = Dativalue[2];
            txtVannoI.Text = Dativalue[3] + "\\" + Dativalue[4] + "\\" + Dativalue[5];
            //  txtVmeseI.Text = Dativalue[4];
            //   txtVgiornoI.Text = Dativalue[5];

            if (Dativalue[7].Length < 2)
            {
                Dativalue[7] = "0" + Dativalue[7];
            }

            txtVoraI.Text = Dativalue[6]+":" + Dativalue[7];
            //     txtVminutiI.Text = Dativalue[7];
            //  txtVannoF.Text = Dativalue[8];
            //   txtVmeseF.Text = Dativalue[9];
            //    txtVGiornoF.Text = Dativalue[10];

            if (Dativalue[12].Length<2)
            {
                Dativalue[12] = "0" + Dativalue[12];
            }

            txtVoraF.Text = Dativalue[11]+":"+ Dativalue[12];
    //     txtVminutiF.Text = Dativalue[12];


     //       lblCassette.Text = Datilbl[0];
    //        lblCiclo.Text = Datilbl[1];
    //        lblCesto.Text = Datilbl[2];
   //         lblAnnoI.Text = Datilbl[3];
   //         lblMeseI.Text = Datilbl[4];
   //         lblGiornoI.Text = Datilbl[5];
   //         lblOraI.Text = Datilbl[6];
  //          lblMinutiI.Text = Datilbl[7];
        //    lblAnnoF.Text = Datilbl[8];
      //      lblMeseF.Text = Datilbl[9];
      //      lblGiornoF.Text = Datilbl[10];
     //       lblOraF.Text = Datilbl[11];
    //        lblMinutiF.Text = Datilbl[12];

            Salva_file();





        }

        private void Salva_file()
        {

            string file_name = Globals.File_Lavoro[0] + "\\" + Dativalue[0] + ".lav";
            string numero_ciclo = Globals.DirLavoro + "\\Ultimo.grx";
            string ciclo;
            //controllo ultimo ciclo salvato
            if (!System.IO.File.Exists(numero_ciclo))
            {

                System.IO.StreamWriter fs = System.IO.File.CreateText(numero_ciclo);

                fs.Close();


            }

            System.IO.StreamReader objReader;
            objReader = new System.IO.StreamReader(numero_ciclo);
            ciclo = objReader.ReadLine();//percorso
            objReader.Close();






            if (ciclo!= Dativalue[0])

            {

                string stampa = Dativalue[1] + "X" + Dativalue[2]+" "+ Dativalue[3] + "\\" + Dativalue[4] + "\\" + Dativalue[5] + "  " + Dativalue[6] + ":" + Dativalue[7] + " " +
                                         Dativalue[11] + ":" + Dativalue[12] ;


                System.IO.StreamWriter fs = System.IO.File.CreateText(file_name);
                fs.WriteLine(stampa);
                fs.Close();

                System.IO.StreamWriter pp = System.IO.File.CreateText(numero_ciclo);
                pp.WriteLine(Dativalue[0]);
                pp.Close();


            }
            
        }



        private void Session_ServerConnectionStatusUpdate(Session sender, ServerConnectionStatusUpdateEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ServerConnectionStatusUpdateEventHandler(Session_ServerConnectionStatusUpdate), sender, e);
                return;
            }

            // check that the current session matches the session that raised the event.
            if (!Object.ReferenceEquals(m_Session, sender))
            {
                return;
            }

            lock (this)
            {

                bool bClearControls = false;

                switch (e.Status)
                {
                    case ServerConnectionStatus.Disconnected:
                        bClearControls = true;
                        break;
                    case ServerConnectionStatus.Connected:
                        // Update Button
                        //      ConnectDisconnectBTN.Text = "Disconnect";
                        // Update ToolStripMenu
                        //connectToolStripMenuItem.Enabled = false;
                        //disconnectToolStripMenuItem.Enabled = true;
                        // Set enabled state for combobox
                        EndpointCB.Enabled = false;
                        DiscoveryUrlCB.Enabled = false;
                        DiscoveryTypeCB.Enabled = false;
                        ClientUrlTB.Enabled = false;

                        // Aggregate the UserControls.
                        //browseControl.Session = m_Session;
                        
                        

                        // Update status label.
                        lblerrors.Text = "Connected to " + m_Session.EndpointDescription.EndpointUrl;
                        
                        
                        break;
                    case ServerConnectionStatus.ConnectionWarningWatchdogTimeout:
                        // Update status label.
                        //toolStripStatusLabel.Text = "Watchdog timed out";
                        //toolStripStatusLabel.Image = global::UnifiedAutomation.Sample.Properties.Resources.warning;
                        break;
                    case ServerConnectionStatus.ConnectionErrorClientReconnect:
                        // Update status label.
                        lblerrors.Text = "Trying to reconnect";
                        
                        break;
                    case ServerConnectionStatus.ServerShutdownInProgress:
                        // Update status label.
                        lblerrors.Text = "Server is shutting down";
                        
                        break;
                    case ServerConnectionStatus.ServerShutdown:
                        // Update status label.
                        lblerrors.Text = "Server has shut down";
                        
                        break;
                    case ServerConnectionStatus.SessionAutomaticallyRecreated:
                        // Update status label.
                        lblerrors.Text = "A new Session was created";
                        
                        // clear controls
                        bClearControls = true;
                        break;
                    case ServerConnectionStatus.Connecting:
                        // Update status label.
                        EndpointDescription endpoint;
                        string endpointUrl;
                        if (TryGetSelectedEndpoint(out endpoint))
                        {
                            endpointUrl = endpoint.EndpointUrl;
                        }
                        else
                        {
                            endpointUrl = DiscoveryUrl;
                        }
                        lblerrors.Text = "Trying to connect to " + endpointUrl;
                        
                        break;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 60000;

            Leggi_Dati();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int adesso = System.DateTime.Now.Hour;
            if (Globals.File_Lavoro[1]=="1")
            {
                if (adesso>=int.Parse(Globals.File_Lavoro[2])|| adesso < int.Parse(Globals.File_Lavoro[3]))
                {

                    lblerrors.Text = "In attesa ";
                       timer2.Interval = 60000;
                       return;

                }
            }

           

            // Set wait cursor.
                Cursor = Cursors.WaitCursor;
            timer2.Enabled = false;
            try
            {
                DisconnectIfRequired();

                // Extract Url from combobox text.
                EndpointDescription endpoint;
                if (!TryGetSelectedEndpoint(out endpoint))
                {
                    ConnectWithDiscoveryUrl();
                }
                else
                {
                    ConnectToSelectedEndpoint(endpoint);
                }
                timer1.Interval = 2000;
                timer1.Enabled = true;
            }
            catch (Exception ee)
            {
                // Update status label.
                //PrintException(e, "Connect failed");
                timer2.Interval = 2000;
                lblerrors.Text = ee.ToString();
                timer2.Enabled = true;
            }

            // Set default cursor.
            Cursor = Cursors.Default;
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (autostartToolStripMenuItem.Checked==true)
            {
                Application.Restart();
            }



         
        }

        private void autostartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autostartToolStripMenuItem.Checked==true)
            {
                autostartToolStripMenuItem.Checked = false;
            }
            else
            {
                autostartToolStripMenuItem.Checked = true;
            }

        }

        private void lblerrors_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblerrors.Text);
        }
    }


    class EndpointWrapper
    {

        private EndpointDescription m_endpoint;
        public EndpointWrapper(EndpointDescription endpoint)
        {
            m_endpoint = endpoint;
        }

        public EndpointDescription Endpoint
        {
            get { return m_endpoint; }
            set { m_endpoint = value; }
        }
    }

        public class DropDownItem
    {
        public DropDownItem(uint attributeId)
        {
            AttributeId = attributeId;
        }

        public uint AttributeId { get; private set; }

        public override string ToString()
        {
            return Attributes.GetDisplayText(AttributeId);
        }

        public override bool Equals(object obj)
        {
            DropDownItem item = obj as DropDownItem;

            if (item != null && item.AttributeId == AttributeId)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return AttributeId.GetHashCode();
        }
    }
}
