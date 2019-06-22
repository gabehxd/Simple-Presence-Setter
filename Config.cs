/*
 * Copyright (c) 2018 Random
 *
 * This program is free software; you can redistribute it and/or modify it
 * under the terms and conditions of the GNU General Public License,
 * version 2, as published by the Free Software Foundation.
 *
 * This program is distributed in the hope it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for
 * more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System.IO;

namespace Configsys
{
    public class Config
    {
        private readonly FileInfo CONFIG_PATH = new FileInfo("config.txt");

        public string Smallkey { get; set; } = null;
        public string Smalltext { get; set; } = null;
        public string Largekey { get; set; } = null;
        public string Largetext { get; set; } = null;
        public string Detail { get; set; } = null;
        public string Client { get; set; } = null;
        public string State { get; set; } = null;
        public bool Shouldmini { get; set; } = false;
        public bool Timer { get; set; } = false;

        public Config()
        {
            if (File.Exists(CONFIG_PATH.FullName))
            {
                string[] lines = File.ReadAllLines(CONFIG_PATH.FullName);

                foreach (string line in lines)
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

                                case "timer":
                                    Timer = bool.Parse(parts[1]);
                                    break;
                                case "shouldmini":
                                    Shouldmini = bool.Parse(parts[1]);
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
                $"timer={(Timer ? "true" : "false")}",
                $"shouldmini={(Shouldmini ? "true" : "false")}"
            };

            File.WriteAllLines(CONFIG_PATH.FullName, lines);
        }
    }
}