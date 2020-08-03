using Newtonsoft.Json;

namespace KuaiDi100.Models
{
    public class Data
    {
        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// 时间，原始格式
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// ftime
        /// </summary>
        [JsonProperty("ftime")]
        public string FTime { get; set; }
    }
}
