using System.Text.Json.Serialization;

namespace KuaiDi100.Models
{
    public class Data
    {
        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// 时间，原始格式
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// ftime
        /// </summary>
        [JsonPropertyName("ftime")]
        public string FTime { get; set; }
    }
}
