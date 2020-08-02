using KuaiDi100.Response;
using Interface.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;

namespace KuaiDi100.Request
{
    public class QueryRequest : BaseRequest<QueryResponse>
    {
        /// <summary>
        /// 查询的快递公司的编码， 一律用小写字母
        /// </summary>
        [JsonProperty("com")]
        public string Com { get; set; }

        /// <summary>
        /// 查询的快递单号， 单号的最大长度是32个字符
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }

        public override string GetApiName()
        {
            return "/poll/query.do";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }
    }
}
