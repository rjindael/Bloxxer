using System;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json.Linq;

namespace Bloxxer_Bootstrapper
{
    class Program
    {
        private static readonly string PrerequisitesPath = Directory.GetCurrentDirectory() + @"\current\resources\prerequisites.json";
        private static readonly string CurrentPath = Directory.GetCurrentDirectory() + @"\current\";
        private static readonly string ReleaseUrl = "https://api.github.com/repos/lighterlightbulb/Bloxxer/releases/latest";
        private static bool FirstInstall = false;
        private static string Version;

        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        private static void WriteLine(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Update()
        {
            // NOTE: This bootstrapper ONLY works if the the asset from github containing the Build files (Bloxxer, Bloxxer_Bootstrapper, BuildOutput\*, CefSharp bin files) ends with the "zip" extension

            JObject responseJson;
            Process[] bloxxers = Process.GetProcessesByName("Bloxxer.exe");

            using (WebClient web = new WebClient())
            {
                web.Headers.Add("user-agent", "Bloxxer_Bootstrapper");
                responseJson = JObject.Parse(web.DownloadString(ReleaseUrl));
            }

            if (bloxxers.Length >= 1)
            {
                WriteLine("Killing Bloxxer processes...", ConsoleColor.DarkGreen);
                foreach (Process bloxxer in bloxxers)
                {
                    bloxxer.Kill();
                }
            }

            using (WebClient web = new WebClient())
            {
                try
                {
                    web.Headers.Add("user-agent", "Bloxxer_Bootstrapper");

                    string currentDirectory = Directory.GetCurrentDirectory() + @"\current";
                    string url = string.Empty;
                    string fileName = string.Empty;

                    foreach (JObject asset in responseJson["assets"])
                    {
                        if (asset["browser_download_url"].ToString().Contains(".zip"))
                        {
                            url = asset["browser_download_url"].ToString();
                        }
                    }

                    fileName = Directory.GetCurrentDirectory() + @"\" + url.Substring(url.LastIndexOf("/") + 1);
                    web.DownloadFile(url, fileName);

                    if (Directory.Exists(currentDirectory))
                    {
                        DeleteDirectory(currentDirectory);
                    }
                    Directory.CreateDirectory(currentDirectory);

                    ZipFile.ExtractToDirectory(fileName, currentDirectory);
                    File.Delete(fileName);

                    Version = JObject.Parse(File.ReadAllText(PrerequisitesPath))["configuration"]["version"].ToString();
                }
                catch
                {
                    if (FirstInstall)
                    {
                        WriteLine("Fatal error occurred while updating, closing bootstrapper!", ConsoleColor.Red);
                        Environment.Exit(0);
                    }

                    WriteLine("An error occurred, skipping updater...", ConsoleColor.Red);
                    return;
                }
            }
        }

        private static void InitUpdate()
        {
            WriteLine("Checking version...", ConsoleColor.DarkGreen);
            FirstInstall = !Directory.Exists(CurrentPath) || !File.Exists(PrerequisitesPath);

            try
            {
                using (WebClient web = new WebClient())
                {
                    web.OpenRead("http://google.com/generate_204"); // Can't ping because that is blocked on some schools/libraries
                }
            }
            catch
            {
                WriteLine("Could not establish an internet connection, skipping updater!", ConsoleColor.Red);
                if (FirstInstall)
                {
                    Environment.Exit(0);
                }
                
                return;
            }
            
            if (FirstInstall)
            {
                WriteLine("This seems to be the first install, installing!", ConsoleColor.Yellow);
                Update();
            }
            else
            {
                Version = JObject.Parse(File.ReadAllText(PrerequisitesPath))["configuration"]["version"].ToString();

                JObject responseJson;
                using (WebClient web = new WebClient())
                {
                    web.Headers.Add("user-agent", "Bloxxer_Bootstrapper");
                    responseJson = JObject.Parse(web.DownloadString(ReleaseUrl));
                }

                if (responseJson["tag_name"].ToString().Replace("v", "") == Version)
                {
                    return;
                }

                WriteLine("Update found!", ConsoleColor.Yellow);
                WriteLine("Bloxxer is too old (" + Version + "), updating now!", ConsoleColor.Yellow);
                Update();
            }
        }

        private static void Main()
        {
            Console.Title = "Bloxxer";

            WriteLine(@"____  _\n|  _ \| |\n| |_) | | _____  ____  _____ _ __\n|  _ <| |/ _ \ \/ /\ \/ / _ \ '__|\n| |_) | | (_) >  <  >  <  __/ |\n|____/|_|\___/_/\_\/_/\_\___|_|".Replace(@"\n", Environment.NewLine), ConsoleColor.Green);
            WriteLine("By lightlight#8552 : https://github.com/lighterlightbulb/Bloxxer/", ConsoleColor.Green);
            
            InitUpdate();

            WriteLine("Ready to go! Opening Bloxxer v" + Version, ConsoleColor.Blue);

            Process.Start(Directory.GetCurrentDirectory() + @"\current\Bloxxer.exe");
            Environment.Exit(0);
        }
    }
}
