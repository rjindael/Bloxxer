using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Json;
using System.Windows.Forms;

namespace Bloxxer.Utils
{
    public class JsonManager
    {
        private static readonly string PrerequisitesPath = Directory.GetCurrentDirectory() + @"\resources\prerequisites.json";

        private static void CheckValidJson()
        {
            bool valid = true;

            try
            {
                var obj = JsonValue.Parse(File.ReadAllText(PrerequisitesPath));
            }
            catch (FormatException) { valid = false;  }
            catch (Exception)       { valid = false;  }

            if (!valid)
            {
                ReplaceAllPreReqs();
            }
        }

        public static void ReplaceAllPreReqs()
        {
            if (!File.Exists(PrerequisitesPath))
            {
                File.Create(PrerequisitesPath);
            }
            MessageBox.Show("y");
            var prerequisites = new JObject {
                new JProperty("configuration", new JObject {
                    new JProperty("version", Properties.Resources.Version)
                }),
                new JProperty("preferences", new JObject {
                    new JProperty("execution", new JObject {
                        new JProperty("show", false),
                        new JProperty("method", 0),
                        new JProperty("injectOnExecute", false)
                    }),
                    new JProperty("darkMode", true),
                    new JProperty("bloxxerOnTop", false),
                    new JProperty("robloxOnTop", true),
                    new JProperty("recentlyUsed")
                })
            };

            SaveJson(prerequisites.ToString());
        }

        public static void GetPreferences()
        {
            JObject json = JsonManager.GetJson();
            JToken preferences = json["preferences"];

            GlobalVars.RobloxOnTop             = Convert.ToBoolean(preferences["robloxOnTop"]);
            GlobalVars.BloxxerOnTop            = Convert.ToBoolean(preferences["bloxxerOnTop"]);
            GlobalVars.DarkMode                = Convert.ToBoolean(preferences["darkMode"]);
            GlobalVars.ExecutionMessage        = Convert.ToBoolean(preferences["execution"]["show"]);
            GlobalVars.ExecutionMessageMethod  = Convert.ToInt32  (preferences["execution"]["method"]);
            GlobalVars.InjectOnExecution       = Convert.ToBoolean(preferences["execution"]["injectOnExecution"]);
        }

        public static void SaveJson(string json)
        {
            File.WriteAllText(PrerequisitesPath, json);
        }

        public static JObject GetJson()
        {
            CheckValidJson();
            string json = File.ReadAllText(PrerequisitesPath);

            return JObject.Parse(json);
        }

        public static IList<string> GetRecentlyUsed()
        {
            CheckValidJson();
            string json = File.ReadAllText(PrerequisitesPath);
            JObject parsedJson = JObject.Parse(json);

            return parsedJson["preferences"]["recentlyUsed"].Select(s => (string)s).ToList();
        }
    }
}
