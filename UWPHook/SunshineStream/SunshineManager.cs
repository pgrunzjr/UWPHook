using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPHook.SunshineStream
{
    internal class SunshineManager
    {
        const string SunshineFolder = @"C:\Program Files\Sunshine";
        static readonly string SunshineAppsPath = SunshineFolder + @"\apps.json";

        public static SunshineEntry[] ReadShortcuts()
        {
            var entries = new SunshineEntry[0];

            if (File.Exists(SunshineAppsPath))
            {
                var aspsConfigFile = File.ReadAllText(SunshineAppsPath);
                var appsConfig = JsonConvert.DeserializeObject<SunshineAppsConfig>(aspsConfigFile);
                entries = appsConfig.Apps;
            }

            return entries;
        }

        public static void WriteShortcuts(SunshineEntry[] entries)
        {
            if (File.Exists(SunshineAppsPath))
            {
                var aspsConfigFile = File.ReadAllText(SunshineAppsPath);
                var appsConfig = JsonConvert.DeserializeObject<SunshineAppsConfig>(aspsConfigFile);
                appsConfig.Apps = entries;
                aspsConfigFile = JsonConvert.SerializeObject(appsConfig, Formatting.Indented);
                File.WriteAllText(SunshineAppsPath, aspsConfigFile);
            }
        }

        public static string GetSunshineFolder()
        {
            return SunshineFolder;
        }
    }
}
