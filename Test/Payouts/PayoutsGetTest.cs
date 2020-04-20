using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using static PayoutsSdk.Test.TestHarness;
using PayoutsSdk.Core;
using PayoutsSdk.Payouts;

namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsGetTest
    {

        [Fact]
        public async void TestPayoutsGetRequest()
        {

            var response = await PayoutsPostTest.TestCreatePayoutRequest();
            CreatePayoutResponse batch = response.Result<CreatePayoutResponse>();
            PayoutsGetRequest request = new PayoutsGetRequest(batch.BatchHeader.PayoutBatchId)
                .Page(4)
                .PageSize(2)
                .TotalRequired(true);

            HttpResponse getResponse = await TestHarness.client().Execute(request);
            Assert.Equal(200,(int) getResponse.StatusCode);
            Assert.NotNull(getResponse.Result<PayoutBatch>());

            // Add your own checks here
        }
    }
}
