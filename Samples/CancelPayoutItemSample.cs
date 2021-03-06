
using System;
using System.Threading.Tasks;
using PayoutsSdk.Payouts;
using PayPalHttp;
namespace Samples
{
    public class CancelPayoutItem
    {

        public async static Task<HttpResponse> CancelItem(string itemId,bool debug = false)
        {
            try {
            PayoutsItemCancelRequest request = new PayoutsItemCancelRequest(itemId);
            var cancelResponse = await PayPalClient.client().Execute(request);
            var result = cancelResponse.Result<PayoutItemResponse>();
            if (debug)
            {
                Console.WriteLine("Batch: {0}", result.PayoutBatchId);
                Console.WriteLine("Item: {0}", result.PayoutItemId);
                Console.WriteLine("status: {0}", result.TransactionStatus);

                Console.WriteLine("Links:");
                foreach (LinkDescription link in result.Links)
                {
                    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                }

            }
            return cancelResponse;
            } catch(HttpException ex){
               
                String errorString = ex.Message;
                Error error= ErrorUtil.deserializeError(errorString);
                ErrorUtil.printError(error);
                return null;
            }
        }

    }
}