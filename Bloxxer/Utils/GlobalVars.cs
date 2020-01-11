using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bloxxer.Utils
{
    public class GlobalVars
    {
        public static void SetProperty(string propertyName, object value)
        {
            var innerClass = typeof(GlobalVars).GetNestedType(propertyName);
            var myFieldInfo = innerClass?.GetField(propertyName);
            myFieldInfo?.SetValue(null, value);
        }

        public static Dictionary<string, string> GlobalValues = new Dictionary<string, string>
        {
            { "show", "ExecutionMessage" },
            { "method", "ExecutionMessageMethod" },
            { "injectOnExecution", "InjectOnExecution" },
            { "theme", "Theme" },
            { "bloxxerOnTop", "BloxxerOnTop" },
            { "robloxOnTop", "RobloxOnTop" }
        };

        public static int Theme;
        public static int ExecutionMessageMethod;
        public static bool ExecutionMessage;
        public static bool BloxxerOnTop;
        public static bool RobloxOnTop;
        public static bool InjectOnExecution;
    }
}
