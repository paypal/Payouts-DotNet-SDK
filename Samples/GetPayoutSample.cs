
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Samples;
using PayoutsSdk.Payouts;
using PayoutsSdk.Core;
using PayPalHttp;

using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
namespace Samples
{
    public class GetPayoutSample
    {
        public async static Task<HttpResponse> GetPayout(string batchId,bool debug = false)
        {
            try{
            
            PayoutsGetRequest request = new PayoutsGetRequest(batchId);
            var getResponse = await PayPalClient.client().Execute(request);
            var result = getResponse.Result<PayoutBatch>();
            if (debug)
            {
                Console.WriteLine("Status: {0}", result.BatchHeader.BatchStatus);
                Console.WriteLine("Item: {0}", result.Items[0].PayoutItemId);
                Console.WriteLine("Batch Id: {0}", result.BatchHeader.PayoutBatchId);
                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

            }
            return getResponse;
            } catch(HttpException ex){
               
                String errorString = ex.Message;
                Error error= ErrorUtil.deserializeError(errorString);
                ErrorUtil.printError(error);
                return null;
            }
        }

       /*static void Main(string[] args)
        {   var response = CreatePayoutSample.CreatePayout(true);
            HttpResponse createPayoutResponse = response.Result;
            var payout = createPayoutResponse.Result<CreatePayoutResponse>();
            GetPayout(payout.BatchHeader.PayoutBatchId,true).Wait();
        }*/
    }
}