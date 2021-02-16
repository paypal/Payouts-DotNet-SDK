using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Samples;
using PayoutsSdk.Payouts;
using PayoutsSdk.Core;
using PayPalHttp;

using System.IO;
using System.Text;

namespace Samples
{
    public class RunAllSamples
    {
       
         static void Main(string[] args)
          {
            var response = CreatePayoutSample.CreatePayout(true);
            HttpResponse createPayoutResponse = response.Result;
            var payout = createPayoutResponse.Result<CreatePayoutResponse>();
            
            var getResponse = GetPayoutSample.GetPayout(payout.BatchHeader.PayoutBatchId,true);
            HttpResponse getPayoutResponse = getResponse.Result;
            var payoutBatch = getPayoutResponse.Result<PayoutBatch>();

            GetPayoutItemSample.GetPayoutItem(payoutBatch.Items[0].PayoutItemId,true).Wait();
           
            CancelPayoutItem.CancelItem(payoutBatch.Items[0].PayoutItemId,true).Wait();

         //Error Samples
          CreatePayoutWithValidationError.CreatePayout(true).Wait();
          GetPayoutItemSample.GetPayoutItem("123").Wait();
          GetPayoutSample.GetPayout("abcd",true).Wait();
          CancelPayoutItem.CancelItem("123",true).Wait();

          }
    }
}