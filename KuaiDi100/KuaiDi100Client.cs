using Interface.Common.Extend;
using Interface.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KuaiDi100
{
    public class KuaiDi100Client : BaseClient, IKuaiDi100Client
    {
        private KuaiDi100Config Config;

        public KuaiDi100Client(KuaiDi100Config hupunConfig)
        {
            this.Config = hupunConfig;
        }

        public override string GetRequestUri(IRequest request)
        {
            return Config.ApiUrl + request.GetApiName();
        }

        public override string GetRequestBody(IRequest request)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("customer", Config.Customer);
            dic.Add("sign", GetSign(request));
            dic.Add("param", JsonConvert.SerializeObject(request.GetParameters(), Formatting.None));

            return dic.ToSortQueryParameters(true);
        }

        public override string GetSign(IRequest request)
        {
            var param = JsonConvert.SerializeObject(request.GetParameters(), Formatting.None);
            var key = Config.Key;
            var customer = Config.Customer;

            var signString = param + key + customer;
            return signString.GetMD5().ToUpper();
        }

        public override string MediaType => "application/x-www-form-urlencoded";
    }
}
