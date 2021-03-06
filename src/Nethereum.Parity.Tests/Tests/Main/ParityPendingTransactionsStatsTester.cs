
using System;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.Parity.RPC.Admin;
using Nethereum.RPC.Eth;
using Nethereum.RPC.Tests;
using Xunit;
using Newtonsoft.Json.Linq;

namespace Nethereum.Parity.Test.Testers
{
    public class ParityPendingTransactionsStatsTester : RPCRequestTester<JObject>, IRPCRequestTester
    {

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }

        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var parityPendingTransactionsStats = new ParityPendingTransactionsStats(client);
            return await parityPendingTransactionsStats.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityPendingTransactionsStats);
        }
    }
}
        