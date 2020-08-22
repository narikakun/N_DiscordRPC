using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_DiscordRPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		public DiscordRpcClient client;

        void Initialize()
		{
			var clientID = "746622619054243891";
			if (clientid_textbox.Text != "")
            {
				clientID = clientid_textbox.Text;
            }
			client = new DiscordRpcClient(clientID);
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			client.Initialize();

			client.SetPresence(new RichPresence()
			{
				Details = details_textbox.Text,
				State = state_textbox.Text,
			});
		}
        private void button1_Click(object sender, EventArgs e)
        {
			Initialize();
		}
    }
}
