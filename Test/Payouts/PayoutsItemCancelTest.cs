using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using static PayoutsSdk.Test.TestHarness;
using System.Threading;


namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsItemCancelTest
    {

        [Fact]
        public async void TestPayoutsItemCancelRequest()

        {   
            var response = await PayoutsPostTest.TestCreatePayoutRequest();
            CreatePayoutResponse batch = response.Result<CreatePayoutResponse>();
            PayoutsGetRequest request = new PayoutsGetRequest(batch.BatchHeader.PayoutBatchId);


            HttpResponse getResponse = await TestHarness.client().Execute(request);
            PayoutBatch batchDetails = getResponse.Result<PayoutBatch>();
            Thread.Sleep(10000);

            PayoutsItemCancelRequest cancelRequest = new PayoutsItemCancelRequest(batchDetails.Items[0].PayoutItemId);

            HttpResponse cancelResponse = await TestHarness.client().Execute(cancelRequest);
            Assert.Equal(200,(int) cancelResponse.StatusCode);
            Assert.NotNull(cancelResponse.Result<PayoutItemResponse>());

            // Add your own checks here
        }
    }
}
