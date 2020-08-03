using KuaiDi100;
using KuaiDi100.Request;
using System;

namespace KudiDi100.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new KuaiDi100Client(new KuaiDi100Config()
            {
                ApiUrl = "https://poll.kuaidi100.com",
                Customer = "11E41580BB7F1F1B7C9D8BF57D6CC59C",
                Key = "mAPDsACR5661"
            });

            var response = client.Execute(new QueryRequest()
            {
                Com = "zhongtong",
                Num = "75374767693697"
            });
        }
    }
}
