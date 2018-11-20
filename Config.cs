using System.IO;

namespace Configsys
{
    public class Config
    {
        private const string CONFIG_PATH = "config.txt";

        public string Smallkey { get; set; } = null;
        public string Smalltext { get; set; } = null;
        public string Largekey { get; set; } = null;
        public string Largetext { get; set; } = null;
        public string Detail { get; set; } = null;
        public string Client { get; set; } = null;
        public string State { get; set; } = null;
        public bool Autoupdate { get; set; } = false;

        public Config()
        {
            if (File.Exists(CONFIG_PATH))
            {
                string[] lines = File.ReadAllLines(CONFIG_PATH);

                foreach (var line in lines)
                {
                    string[] parts = line.Replace("\t", "").Split('=');

                    if (parts.Length == 2)
                    {
                        try
                        {
                            parts[1] = parts[1].TrimStart(' ');
                            switch (parts[0].TrimEnd(' ').ToLower())
                            {
                                case "smallkey":
                                    Smallkey = parts[1];
                                    break;

                                case "smalltext":
                                    Smalltext = parts[1];
                                    break;

                                case "largekey":
                                    Largekey = parts[1];
                                    break;

                                case "largetext":
                                    Largetext = parts[1];
                                    break;

                                case "detail":
                                    Detail = parts[1];
                                    break;

                                case "client":
                                    Client = parts[1];
                                    break;

                                case "state":
                                    State = parts[1];
                                    break;

                                case "autoupdate":
                                    Autoupdate = bool.Parse(parts[1]);
                                    break;
                            }
                        }
                        catch { }
                    }
                }
            }
        }

        public void Save()
        {
            string[] lines = new string[]
            {
                $"smallkey={Smallkey}",
                $"smalltext={Smalltext}",
                $"largekey={Largekey}",
                $"largetext={Largetext}",
                $"detail={Detail}",
                $"state={State}",
                $"client={Client}",
                $"autoupdate={(Autoupdate ? "true" : "false")}",
            };

            File.WriteAllLines(CONFIG_PATH, lines);
        }
    }
}