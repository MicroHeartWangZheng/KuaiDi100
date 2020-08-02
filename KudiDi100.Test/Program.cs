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
                Customer = "abc",
                Key = "123"
            });

            var response = client.Execute(new QueryRequest()
            {
                Com = "wuliu",
                Num = "12344"
            });
        }
    }
}
