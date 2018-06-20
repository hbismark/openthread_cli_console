namespace ThreadConsole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.bt_openClose = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_state = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_discover = new System.Windows.Forms.Button();
            this.bt_router_table = new System.Windows.Forms.Button();
            this.cb_rloc16 = new System.Windows.Forms.ComboBox();
            this.bt_ping = new System.Windows.Forms.Button();
            this.bt_networkDiagnostic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sequence = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_clearListBox = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_netdiag = new System.Windows.Forms.Button();
            this.tb_parameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.bt_sendCmd = new System.Windows.Forms.Button();
            this.bt_copy = new System.Windows.Forms.Button();
            this.bt_extaddr = new System.Windows.Forms.Button();
            this.bt_eui64 = new System.Windows.Forms.Button();
            this.bt_ipmaddr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_netdiag_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_ports
            // 
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.Location = new System.Drawing.Point(6, 17);
            this.cb_ports.Name = "cb_ports";
            this.cb_ports.Size = new System.Drawing.Size(68, 21);
            this.cb_ports.TabIndex = 1;
            this.cb_ports.SelectedIndexChanged += new System.EventHandler(this.cb_ports_SelectedIndexChanged);
            // 
            // bt_openClose
            // 
            this.bt_openClose.Enabled = false;
            this.bt_openClose.Location = new System.Drawing.Point(89, 15);
            this.bt_openClose.Name = "bt_openClose";
            this.bt_openClose.Size = new System.Drawing.Size(63, 23);
            this.bt_openClose.TabIndex = 2;
            this.bt_openClose.Text = "Open";
            this.bt_openClose.UseVisualStyleBackColor = true;
            this.bt_openClose.Click += new System.EventHandler(this.bt_openClose_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(19, 164);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 3;
            this.bt_send.Text = "rloc16";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_state
            // 
            this.bt_state.Location = new System.Drawing.Point(19, 24);
            this.bt_state.Name = "bt_state";
            this.bt_state.Size = new System.Drawing.Size(75, 23);
            this.bt_state.TabIndex = 4;
            this.bt_state.Text = "state";
            this.bt_state.UseVisualStyleBackColor = true;
            this.bt_state.Click += new System.EventHandler(this.bt_state_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(18, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(689, 396);
            this.listBox1.TabIndex = 5;
            // 
            // bt_discover
            // 
            this.bt_discover.Location = new System.Drawing.Point(19, 108);
            this.bt_discover.Name = "bt_discover";
            this.bt_discover.Size = new System.Drawing.Size(75, 23);
            this.bt_discover.TabIndex = 6;
            this.bt_discover.Text = "discover";
            this.bt_discover.UseVisualStyleBackColor = true;
            this.bt_discover.Click += new System.EventHandler(this.bt_discover_Click);
            // 
            // bt_router_table
            // 
            this.bt_router_table.BackColor = System.Drawing.SystemColors.Control;
            this.bt_router_table.Location = new System.Drawing.Point(19, 52);
            this.bt_router_table.Name = "bt_router_table";
            this.bt_router_table.Size = new System.Drawing.Size(75, 23);
            this.bt_router_table.TabIndex = 7;
            this.bt_router_table.Text = "router table";
            this.bt_router_table.UseVisualStyleBackColor = false;
            this.bt_router_table.Click += new System.EventHandler(this.bt_router_table_Click);
            // 
            // cb_rloc16
            // 
            this.cb_rloc16.FormattingEnabled = true;
            this.cb_rloc16.Location = new System.Drawing.Point(179, 32);
            this.cb_rloc16.Name = "cb_rloc16";
            this.cb_rloc16.Size = new System.Drawing.Size(59, 21);
            this.cb_rloc16.TabIndex = 8;
            // 
            // bt_ping
            // 
            this.bt_ping.BackColor = System.Drawing.SystemColors.Control;
            this.bt_ping.Location = new System.Drawing.Point(19, 136);
            this.bt_ping.Name = "bt_ping";
            this.bt_ping.Size = new System.Drawing.Size(75, 23);
            this.bt_ping.TabIndex = 9;
            this.bt_ping.Text = "ping";
            this.bt_ping.UseVisualStyleBackColor = false;
            this.bt_ping.Click += new System.EventHandler(this.bt_ping_Click);
            // 
            // bt_networkDiagnostic
            // 
            this.bt_networkDiagnostic.BackColor = System.Drawing.SystemColors.Control;
            this.bt_networkDiagnostic.Location = new System.Drawing.Point(19, 80);
            this.bt_networkDiagnostic.Name = "bt_networkDiagnostic";
            this.bt_networkDiagnostic.Size = new System.Drawing.Size(75, 23);
            this.bt_networkDiagnostic.TabIndex = 10;
            this.bt_networkDiagnostic.Text = "get childs";
            this.bt_networkDiagnostic.UseVisualStyleBackColor = false;
            this.bt_networkDiagnostic.Click += new System.EventHandler(this.bt_networkDiagnostic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nodes";
            // 
            // bt_sequence
            // 
            this.bt_sequence.Location = new System.Drawing.Point(19, 305);
            this.bt_sequence.Name = "bt_sequence";
            this.bt_sequence.Size = new System.Drawing.Size(75, 23);
            this.bt_sequence.TabIndex = 12;
            this.bt_sequence.Text = "Sequence";
            this.bt_sequence.UseVisualStyleBackColor = true;
            this.bt_sequence.Click += new System.EventHandler(this.bt_sequence_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_clearListBox
            // 
            this.bt_clearListBox.Location = new System.Drawing.Point(6, 19);
            this.bt_clearListBox.Name = "bt_clearListBox";
            this.bt_clearListBox.Size = new System.Drawing.Size(75, 23);
            this.bt_clearListBox.TabIndex = 13;
            this.bt_clearListBox.Text = "Clear";
            this.bt_clearListBox.UseVisualStyleBackColor = true;
            this.bt_clearListBox.Click += new System.EventHandler(this.bt_clearListBox_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(732, 479);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(75, 23);
            this.bt_quit.TabIndex = 14;
            this.bt_quit.Text = "Quit";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // bt_netdiag
            // 
            this.bt_netdiag.Location = new System.Drawing.Point(19, 339);
            this.bt_netdiag.Name = "bt_netdiag";
            this.bt_netdiag.Size = new System.Drawing.Size(75, 23);
            this.bt_netdiag.TabIndex = 15;
            this.bt_netdiag.Text = "diag get";
            this.bt_netdiag.UseVisualStyleBackColor = true;
            this.bt_netdiag.Click += new System.EventHandler(this.bt_netdiag_Click);
            // 
            // tb_parameter
            // 
            this.tb_parameter.Location = new System.Drawing.Point(506, 33);
            this.tb_parameter.Name = "tb_parameter";
            this.tb_parameter.Size = new System.Drawing.Size(115, 20);
            this.tb_parameter.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Parameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Command";
            // 
            // tb_command
            // 
            this.tb_command.Location = new System.Drawing.Point(244, 33);
            this.tb_command.Name = "tb_command";
            this.tb_command.Size = new System.Drawing.Size(256, 20);
            this.tb_command.TabIndex = 18;
            this.tb_command.TextChanged += new System.EventHandler(this.tb_command_TextChanged);
            this.tb_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_command_KeyDown);
            // 
            // bt_sendCmd
            // 
            this.bt_sendCmd.Location = new System.Drawing.Point(19, 248);
            this.bt_sendCmd.Name = "bt_sendCmd";
            this.bt_sendCmd.Size = new System.Drawing.Size(75, 23);
            this.bt_sendCmd.TabIndex = 20;
            this.bt_sendCmd.Text = "ipaddr";
            this.bt_sendCmd.UseVisualStyleBackColor = true;
            this.bt_sendCmd.Click += new System.EventHandler(this.bt_sendCmd_Click);
            // 
            // bt_copy
            // 
            this.bt_copy.Location = new System.Drawing.Point(105, 19);
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.Size = new System.Drawing.Size(75, 23);
            this.bt_copy.TabIndex = 21;
            this.bt_copy.Text = "Copy";
            this.bt_copy.UseVisualStyleBackColor = true;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // bt_extaddr
            // 
            this.bt_extaddr.Location = new System.Drawing.Point(20, 192);
            this.bt_extaddr.Name = "bt_extaddr";
            this.bt_extaddr.Size = new System.Drawing.Size(75, 23);
            this.bt_extaddr.TabIndex = 22;
            this.bt_extaddr.Text = "extaddr";
            this.bt_extaddr.UseVisualStyleBackColor = true;
            this.bt_extaddr.Click += new System.EventHandler(this.bt_extaddr_Click);
            // 
            // bt_eui64
            // 
            this.bt_eui64.Location = new System.Drawing.Point(19, 220);
            this.bt_eui64.Name = "bt_eui64";
            this.bt_eui64.Size = new System.Drawing.Size(75, 23);
            this.bt_eui64.TabIndex = 23;
            this.bt_eui64.Text = "eui64";
            this.bt_eui64.UseVisualStyleBackColor = true;
            this.bt_eui64.Click += new System.EventHandler(this.bt_eui64_Click);
            // 
            // bt_ipmaddr
            // 
            this.bt_ipmaddr.Location = new System.Drawing.Point(20, 277);
            this.bt_ipmaddr.Name = "bt_ipmaddr";
            this.bt_ipmaddr.Size = new System.Drawing.Size(75, 23);
            this.bt_ipmaddr.TabIndex = 24;
            this.bt_ipmaddr.Text = "ipmaddr";
            this.bt_ipmaddr.UseVisualStyleBackColor = true;
            this.bt_ipmaddr.Click += new System.EventHandler(this.bt_ipmaddr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(278, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "(C) 2018 Hardy Bismark ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_clearListBox);
            this.groupBox1.Controls.Add(this.bt_copy);
            this.groupBox1.Location = new System.Drawing.Point(627, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 49);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_discover);
            this.groupBox2.Controls.Add(this.bt_send);
            this.groupBox2.Controls.Add(this.bt_state);
            this.groupBox2.Controls.Add(this.bt_router_table);
            this.groupBox2.Controls.Add(this.bt_ipmaddr);
            this.groupBox2.Controls.Add(this.bt_ping);
            this.groupBox2.Controls.Add(this.bt_eui64);
            this.groupBox2.Controls.Add(this.bt_networkDiagnostic);
            this.groupBox2.Controls.Add(this.bt_extaddr);
            this.groupBox2.Controls.Add(this.bt_sequence);
            this.groupBox2.Controls.Add(this.bt_sendCmd);
            this.groupBox2.Controls.Add(this.bt_netdiag);
            this.groupBox2.Location = new System.Drawing.Point(713, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 368);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_openClose);
            this.groupBox3.Controls.Add(this.cb_ports);
            this.groupBox3.Location = new System.Drawing.Point(12, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 44);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ports";
            // 
            // bt_netdiag_reset
            // 
            this.bt_netdiag_reset.Location = new System.Drawing.Point(732, 436);
            this.bt_netdiag_reset.Name = "bt_netdiag_reset";
            this.bt_netdiag_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_netdiag_reset.TabIndex = 30;
            this.bt_netdiag_reset.Text = "diag reset";
            this.bt_netdiag_reset.UseVisualStyleBackColor = true;
            this.bt_netdiag_reset.Click += new System.EventHandler(this.bt_netdiag_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 520);
            this.Controls.Add(this.bt_netdiag_reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_command);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_parameter);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_rloc16);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Thread CLI Console V1.00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_ports;
        private System.Windows.Forms.Button bt_openClose;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Button bt_state;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_discover;
        private System.Windows.Forms.Button bt_router_table;
        private System.Windows.Forms.ComboBox cb_rloc16;
        private System.Windows.Forms.Button bt_ping;
        private System.Windows.Forms.Button bt_networkDiagnostic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sequence;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_clearListBox;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_netdiag;
        private System.Windows.Forms.TextBox tb_parameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Button bt_sendCmd;
        private System.Windows.Forms.Button bt_copy;
        private System.Windows.Forms.Button bt_extaddr;
        private System.Windows.Forms.Button bt_eui64;
        private System.Windows.Forms.Button bt_ipmaddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_netdiag_reset;
    }
}

