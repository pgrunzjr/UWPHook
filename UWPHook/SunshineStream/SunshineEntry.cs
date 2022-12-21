using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWPHook.SunshineStream
{
    public class SunshineAppsConfig
    {
        [JsonProperty("env")]
        public Dictionary<string, string> Env { get; set; }

        [JsonProperty("apps")]
        public SunshineEntry[] Apps { get; set; }
    }

    public class SunshineEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("cmd")]
        public string Cmd { get; set; }

        [JsonProperty("image-path")]
        public string ImagePath { get; set; }

        [JsonProperty("working-dir")]
        public string WorkingDir { get; set; }
    }
}