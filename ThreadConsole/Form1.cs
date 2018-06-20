using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace ThreadConsole
{
    public partial class Form1 : Form
    {
        static bool serialPortOpen = false;
        public delegate void addlistBoxItem();
        public addlistBoxItem addlistBoxItemDelegate;
        public delegate void addRloc16Item();
        public addRloc16Item addRloc16ItemDelegate;
        static string recString;
        static string rloc16String;
        static string prefix;
        static string cmd;
        static int nodeIndex = 0;
        static int nodeIndexMax = 0;



        public Form1()
        {
            InitializeComponent();
            GetSerialPorts();
            addlistBoxItemDelegate = new addlistBoxItem(addlistBoxItemMethode);
            addRloc16ItemDelegate = new addRloc16Item(addRloc16ItemMethode);
        }

        public void GetSerialPorts()
        {
            List<String> tList = new List<String>();
            

            cb_ports.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                tList.Add(s);
            }

            tList.Sort();
            cb_ports.Items.AddRange(tList.ToArray());
            cb_ports.SelectedIndex = 0;

            serialPort.BaudRate = 115200;
                        
        }

        private void addRloc16ItemMethode()
        {
            if(rloc16String.Length == 2)
            {
                rloc16String = cb_rloc16.Text.Substring(0, 2) + rloc16String;
            }
            if(!cb_rloc16.Items.ToString().Contains(rloc16String))
            {
                cb_rloc16.Items.Add(rloc16String);
                cb_rloc16.Text = rloc16String;
            }
            cb_rloc16.Refresh();            
        }

        private void addlistBoxItemMethode()
        {
            if (recString != "" && recString != ">")
            {
                listBox1.Items.Add(recString);
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
                listBox1.SetSelected(listBox1.Items.Count - 1, false);
                listBox1.Refresh();
            }
        }

        private void bt_openClose_Click(object sender, EventArgs e)
        {
            if(!serialPortOpen)
            {
                if (serialPort.PortName.Contains("COM"))
                {
                    try
                    {
                        serialPort.Open();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if(serialPort.IsOpen)
                    {
                        bt_openClose.Text = "Close";
                        serialPortOpen = true;                        
                    }                    
                }
            }
            else
            {
                serialPort.Close();
                bt_openClose.Text = "Open";
                serialPortOpen = false;
                GetSerialPorts();
            }
        }

        

        private void cb_ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                bt_openClose_Click(this, null);
            }
            serialPort.PortName = cb_ports.Text;
            bt_openClose.Enabled = true;
        }

        private void extractRloc16(string line)
        {
            if (line.Length > 12)
            {
                if (line.Substring(7, 2) == "0x")
                {
                    string rloc16 = line.Substring(9, 4);
                    rloc16String = rloc16;
                    cb_rloc16.Invoke(addRloc16ItemDelegate);
                }
            }
        }

        private void createChildRloc16(string line)
        {
            if (line.Length > 25)
            {
                int indexColon = line.IndexOf(':', 0);
                string router = line.Substring((indexColon + 6), 2);
                byte childs = Convert.ToByte(line.Substring((indexColon + 12), 2));
                childs /= 3;
                for (int i = 0; i < childs; i++)
                {
                    rloc16String = router + line.Substring((indexColon + 16 + (i * 6)), 2);
                    cb_rloc16.Invoke(addRloc16ItemDelegate);
                }
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();
            string indata; 
            string[] tokens;

            try
            {


                while ((indata = sp.ReadLine()) != "")
                {
                    tokens = indata.Split('\r');
                    foreach (string token in tokens)
                    {
                        if (token != "\n")
                        {
                            recString = token;
                            listBox1.Invoke(addlistBoxItemDelegate);
                            if (cmd == "router table")
                            {
                                extractRloc16(recString);
                            }
                            else
                            {
                                if (cmd == "networkdiagnostic get ")
                                {
                                    if (recString.Contains("DIAG_GET.rsp"))
                                    {
                                        createChildRloc16(recString);
                                    }
                                }
                            }
                        }
                    }
                };

                indata = sp.ReadExisting();
                tokens = indata.Split('\r');
                foreach (string token in tokens)
                {
                    if (token != "\n")
                    {
                        recString = token;
                        listBox1.Invoke(addlistBoxItemDelegate);
                    }
                }
            }
            catch (System.IO.IOException) { }
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            cmd = "rloc16";
            if (serialPort.IsOpen)
                serialPort.WriteLine("rloc16\n\r");
        }

        private void bt_state_Click(object sender, EventArgs e)
        {
            cmd = "state";
            if (serialPort.IsOpen)
                serialPort.WriteLine("state\n\r");
        }

        private void bt_discover_Click(object sender, EventArgs e)
        {
            cmd = "discover";
            if (serialPort.IsOpen)
                serialPort.WriteLine("discover\n\r");
        }

        private void bt_router_table_Click(object sender, EventArgs e)
        {
            cmd = "router table";
            cb_rloc16.Items.Clear();
            if (serialPort.IsOpen)
                serialPort.WriteLine("router table\n\r");
        }

        private void bt_ping_Click(object sender, EventArgs e)
        {
            cmd = "ping ";
            if (serialPort.IsOpen)
            {
                prefix = "fdde:ad00:beef:0:0:ff:fe00:";
                cmd = cmd + prefix + cb_rloc16.Text + "\n\r";
                serialPort.WriteLine(cmd);
            }
        }

        private void bt_networkDiagnostic_Click(object sender, EventArgs e)
        {
            cmd = "networkdiagnostic get ";
            if (serialPort.IsOpen)
            {
                string c = cmd;
                prefix = "fdde:ad00:beef:0:0:ff:fe00:";
                c = c + prefix + cb_rloc16.Text + " 1 16\n\r";
                serialPort.WriteLine(c);
            }
        }

        private void bt_sequence_Click(object sender, EventArgs e)
        {
            bt_router_table_Click(this, null);
            nodeIndex = 0;
            Thread.Sleep(500);
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (nodeIndexMax > 0)
            {
                cb_rloc16.SelectedIndex = nodeIndex;
                bt_networkDiagnostic_Click(this, null);
                nodeIndex++;
                if (nodeIndex > nodeIndexMax)
                {
                    timer1.Stop();
                    cb_rloc16.SelectedIndex = 0;
                }
            }
            else
            {
                cb_rloc16.Refresh();
                nodeIndexMax = cb_rloc16.Items.Count;
            }
        }

        private void bt_clearListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_netdiag_Click(object sender, EventArgs e)
        {
            cmd = "networkdiagnostic get";
            if (serialPort.IsOpen)
            {
                string c = cmd;
                prefix = " fdde:ad00:beef:0:0:ff:fe00:";
                c = c + prefix + cb_rloc16.Text + " " + tb_parameter.Text + "\n\r";
                serialPort.WriteLine(c);
            }
        }

        private void bt_sendCmd_Click(object sender, EventArgs e)
        {
            cmd = "ipaddr";
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine("ipaddr\r\n");
            }
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());            
        }

        private void bt_extaddr_Click(object sender, EventArgs e)
        {
            cmd = "extaddr";
            if (serialPort.IsOpen)
                serialPort.WriteLine("extaddr\n\r");
        }

        private void bt_eui64_Click(object sender, EventArgs e)
        {
            cmd = "eui64";
            if (serialPort.IsOpen)
                serialPort.WriteLine("eui64\n\r");
        }

        private void bt_ipmaddr_Click(object sender, EventArgs e)
        {
            cmd = "ipmaddr";
            if (serialPort.IsOpen)
                serialPort.WriteLine("ipmaddr\n\r");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_command_TextChanged(object sender, EventArgs e)
        {
            // check content
        }

        private void tb_command_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tb_command.Text.Trim('\r');
                cmd = "command";
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine(tb_command.Text + "\r\n");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_netdiag_reset_Click(object sender, EventArgs e)
        {
            cmd = "networkdiagnostic reset";
            if (serialPort.IsOpen)
            {
                string c = cmd;
                prefix = " fdde:ad00:beef:0:0:ff:fe00:";
                c = c + prefix + cb_rloc16.Text + " " + tb_parameter.Text + "\n\r";
                serialPort.WriteLine(c);
            }
        }
    }
}
