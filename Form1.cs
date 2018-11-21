using System;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using Configsys;

namespace Simple_Presence_Setter
{
    public partial class Form1 : Form
    {
        public static DiscordRpcClient client;

        public Form1()
        {
            InitializeComponent();
            LoadConfig();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        private void AutoUpdateDiscord()
        {
            if (autocheck.Checked)
            {
                try
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = details.Text,
                        State = state.Text,
                        Assets = new Assets()
                        {
                            LargeImageKey = Largekey.Text,
                            LargeImageText = Largetext.Text,
                            SmallImageKey = Smallkey.Text,
                            SmallImageText = Smalltext.Text
                        }
                    });
                    client.Invoke();
                }
                catch { }
                SaveConfig();
            }
        }

        private void ManualUpdateDiscord()
        {
            client.SetPresence(new RichPresence()
            {
                Details = details.Text,
                State = state.Text,
                Assets = new Assets()
                {
                    LargeImageKey = Largekey.Text,
                    LargeImageText = Largetext.Text,
                    SmallImageKey = Smallkey.Text,
                    SmallImageText = Smalltext.Text
                }
            });
            client.Invoke();
            SaveConfig();
        }

        private void Set_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientid.Text))
            {
                MessageBox.Show("The Client ID text box blank.", "No Client ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (set_btn.Text == "Start")
            {
                client = new DiscordRpcClient(clientid.Text)
                {
                    Logger = new ConsoleLogger() { Level = LogLevel.Warning }
                };

                client.OnReady += (send, s) =>
                {
                    Console.WriteLine("Received Ready from user {0}", s.User.Username);
                };

                client.OnPresenceUpdate += (send, s) =>
                {
                    Console.WriteLine("Received Update! {0}", s.Presence);
                };
                client.Initialize();
                foreach (Control textbox in Controls)
                {
                    if (textbox is TextBox) textbox.TextChanged += (o, s) => AutoUpdateDiscord();
                }
                ManualUpdateDiscord();
                set_btn.Text = "Stop";
                details.Enabled = true;
                state.Enabled = true;
                Largekey.Enabled = true;
                Largetext.Enabled = true;
                Smallkey.Enabled = true;
                Smalltext.Enabled = true;
                clientid.Enabled = false;
                autocheck.Enabled = true;
                if (!autocheck.Checked) update_btn.Enabled = true;
            }
            else 
            {
                details.Enabled = false;
                state.Enabled = false;
                Largekey.Enabled = false;
                Largetext.Enabled = false;
                Smallkey.Enabled = false;
                Smalltext.Enabled = false;
                clientid.Enabled = true;
                client.Dispose();
                set_btn.Text = "Start";
                autocheck.Enabled = false;
                update_btn.Enabled = false;
                SaveConfig();
            }
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            try
            { 
            client.Dispose();
            }
            catch { }
        }

        private void Autocheck_CheckedChanged(object sender, EventArgs e)
        {
            if (autocheck.Checked) update_btn.Enabled = false;
            else update_btn.Enabled = true;
        }

        private void LoadConfig()
        {
            Config config = new Config();
            clientid.Text = config.Client;
            Smallkey.Text = config.Smallkey;
            Smalltext.Text = config.Smalltext;
            Largekey.Text = config.Largekey;
            Largetext.Text = config.Largetext;
            details.Text = config.Detail;
            state.Text = config.State;
            autocheck.Checked = config.Autoupdate;
        }

        private void SaveConfig()
        {
            Config config = new Config()
            {
                Client = clientid.Text,
                Smallkey = Smallkey.Text,
                Smalltext = Smalltext.Text,
                Largekey = Largekey.Text,
                Largetext = Largetext.Text,
                Detail = details.Text,
                State = state.Text,
                Autoupdate = autocheck.Checked,
            };
            config.Save();
        }
    }
}
