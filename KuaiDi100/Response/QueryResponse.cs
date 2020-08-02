using Interface.Core;
using KuaiDi100.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KuaiDi100.Response
{
    public class QueryResponse : BaseResponse
    {
        /// <summary>
        /// 消息体，请忽略
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 快递单当前状态，包括0在途，1揽收，2疑难，3签收，4退签，5派件，6退回，7转单，10待清关，11清关中，12已清关，13清关异常，14收件人拒签等13个状态
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 通讯状态，请忽略
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 快递单明细状态标记，暂未实现，请忽略
        /// </summary>
        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 是否签收标记，请忽略，明细状态请参考state字段
        /// </summary>
        [JsonPropertyName("ischeck")]
        public string Ischeck { get; set; }

        /// <summary>
        /// 快递公司编码,一律用小写字母
        /// </summary>
        [JsonPropertyName("com")]
        public string Com { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        [JsonPropertyName("nu")]
        public string Nu { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        [JsonPropertyName("data")]
        public List<Data> Datas { get; set; }
    }
}
