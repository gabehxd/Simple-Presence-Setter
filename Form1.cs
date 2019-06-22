using System;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using Configsys;
using System.Diagnostics;
using System.Linq;

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

        private void Set_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientid.Text))
            {
                MessageBox.Show("The Client ID text box blank.", "No Client ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (set_btn.Text == "Start")
            {
                client = new DiscordRpcClient(clientid.Text);

                client.OnReady += (send, s) => Console.WriteLine("Received Ready from user {0}", s.User.Username);
                client.OnPresenceUpdate += (send, s) => Console.WriteLine("Received Update! {0}", s.Presence);
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

                if (!client.Initialize()) throw new Exception("Failed to start client");

                Assets assets = new Assets()
                {
                    LargeImageKey = Largekey.Text,
                    SmallImageKey = Smallkey.Text
                };
                if (Smallkey.Text.Length > 2) assets.SmallImageText = Smalltext.Text;
                if (Largetext.Text.Length > 2) assets.LargeImageText = Largetext.Text;

                RichPresence presence = new RichPresence()
                {
                    Details = details.Text,
                    State = state.Text,
                    Assets = assets
                };
                if (TimerCheck.Checked) presence.Timestamps = Timestamps.Now;

                client.SetPresence(presence);

                set_btn.Text = "Stop";
                details.Enabled = true;
                state.Enabled = true;
                Largekey.Enabled = true;
                Largetext.Enabled = true;
                Smallkey.Enabled = true;
                Smalltext.Enabled = true;
                clientid.Enabled = false;
                TimerCheck.Enabled = true;
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
                TimerCheck.Enabled = false;
                client.Dispose();
                set_btn.Text = "Start";

                SaveConfig();
            }
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            //try to dispose the client if the user hasn't already
            if (client != null && !client.IsDisposed) client.Dispose();
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
            TimerCheck.Checked = config.Timer;
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
                Shouldmini = ShouldMini.Checked,
                Timer = TimerCheck.Checked
            };
            config.Save();
        }

        //thanks stackoverflow :)
        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (WindowState == FormWindowState.Minimized && ShouldMini.Checked)
            {
                Hide();
                Toolbar.Visible = true;
            }
        }

        private void NotifyIcon_MouseClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Toolbar.Visible = false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start($"https://discordapp.com/developers/applications/{clientid.Text}");

        private void ShouldMini_CheckedChanged(object sender, EventArgs e) => SaveConfig();

        private void AssetFocusLost(object sender, EventArgs e)
        {
            Assets assets = new Assets()
            {
                LargeImageKey = Largekey.Text,
                SmallImageKey = Smallkey.Text
            };
            if (Smalltext.Text.Length != 1) assets.SmallImageText = Smalltext.Text;
            if (Largetext.Text.Length != 1) assets.LargeImageText = Largetext.Text;

            client.SetPresence(client.CurrentPresence.WithAssets(assets));
            SaveConfig();
        }

        private void TimerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (client != null && !client.IsDisposed)
            {
                if (TimerCheck.Checked) client.SetPresence(client.CurrentPresence.WithTimestamps(Timestamps.Now));
                else client.SetPresence(client.CurrentPresence.WithTimestamps(null));
                SaveConfig();
            }
        }

        private void State_LostFocus(object sender, EventArgs e)
        {
            if (state.Text.Length != 1)
            {
                client.SetPresence(client.CurrentPresence.WithState(state.Text));
                SaveConfig();
            }
        }

        private void Details_FocusLost(object sender, EventArgs e)
        {
            if (details.Text.Length != 1)
            {
                client.SetPresence(client.CurrentPresence.WithDetails(details.Text));
                SaveConfig();
            }
        }
    }
}
