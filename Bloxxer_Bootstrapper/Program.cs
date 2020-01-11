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
        private static readonly string ReleaseUrl = "https://api.github.com/repos/zi-blip/Bloxxer/releases/latest";
        private static string Version;
        private static bool FirstInstall = false;

        private static void WriteLine(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Update()
        {
            JObject responseJson;
            Process[] bloxxers = Process.GetProcessesByName("Bloxxer.exe");

            using (WebClient web = new WebClient())
            {
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
                    string currentDirectory = Directory.GetCurrentDirectory() + @"\current";
                    string url = responseJson["assets"][0]["browser_download_url"].ToString();
                    string fileName = url.Substring(url.LastIndexOf("/" + 1)) + ".zip";

                    web.DownloadFile(url, Directory.GetCurrentDirectory() + @"\bootstrapper\" + fileName);

                    Directory.Delete(currentDirectory);
                    Directory.CreateDirectory(currentDirectory);

                    ZipFile.ExtractToDirectory(fileName, currentDirectory);
                }
                catch (Exception)
                {
                    if (FirstInstall)
                    {
                        WriteLine("Fatal error occurred while updating, closing bootstrapper!");
                        Environment.Exit(0);
                    }

                    WriteLine("An error occurred, skipping updater...", ConsoleColor.Red);
                    return;
                }
            }
        }

        private static void InitUpdate()
        {
            // NOTE: This bootstrapper ONLY works if the only assets are the zip file from github containing everything
            //       (Bloxxer, Bloxxer_Bootstrapper, BuildOutput\*, CefSharp bin files)

            WriteLine("Checking version...", ConsoleColor.DarkGreen);
            FirstInstall = !Directory.Exists(CurrentPath);
            
            if (FirstInstall)
            {
                Update();
            }
            else
            {
                Version = JObject.Parse(File.ReadAllText(PrerequisitesPath))["configuration"]["version"].ToString();
                JObject responseJson;
                using (WebClient web = new WebClient())
                {
                    responseJson = JObject.Parse(web.DownloadString(ReleaseUrl));
                }

                if (responseJson["tag_name"].ToString().Replace("v", "") == JObject.Parse(File.ReadAllText(PrerequisitesPath))["configuration"]["version"].ToString())
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

            WriteLine(@"____  _\n|  _ \| |\n| |_) | | _____  ____  _____ _ __\n|  _ <| |/ _ \ \/ /\ \/ / _ \ '__|\n| |_) | | (_) >  <  >  <  __/ |\n|____/|_|\___/_/\_\/_/\_\___|_|".Replace(@"\n", Environment.NewLine), ConsoleColor.Red);
            WriteLine("Bloxxer_Bootstrapper v1.0.0 : Release\n");

            InitUpdate();

            WriteLine("Ready to go! Opening Bloxxer v" + Version, ConsoleColor.Blue);
            Process.Start("Bloxxer.exe");
            Environment.Exit(0);
        }
    }
}
