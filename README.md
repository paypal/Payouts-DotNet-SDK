# PayPal Payouts DotNet SDK v2

![Home Image](homepage.jpg)

__Welcome to PayPal Payouts__. This repository contains PayPal's DotNet SDK for Payouts and samples for [v1/payments/payouts](https://developer.paypal.com/docs/api/payments.payouts-batch/v1/) APIs.

This is a part of the next major PayPal SDK. It includes a simplified interface to only provide simple model objects and blueprints for HTTP calls. This repo currently contains functionality for PayPal Payouts APIs which includes [Payouts](https://developer.paypal.com/docs/api/payments.payouts-batch/v1/).

Please refer to the [PayPal Payouts Integration Guide](https://developer.paypal.com/docs/payouts/) for more information. Also refer to [Setup your SDK](https://developer.paypal.com/docs/payouts/reference/setup-sdk) for additional information about setting up the SDK's. 


## Prerequisites

.NET 4.6.1 or later

An environment which supports TLS 1.2 (see the TLS-update site for more information)

PayPalHttp 1.0.0

## Usage
### Binaries

It is not necessary to fork this repository for using the PayPal SDK. Please take a look at [PayPal Payouts Server SDK](https://developer.paypal.com/docs/payouts/reference/setup-sdk/#install-the-sdk) for configuring and working with SDK without forking this code.

For contributing to this repository or using the samples you can fork this repository.

### Setting up credentials

Get client ID and client secret by going to https://developer.paypal.com/developer/applications and generating a REST API app. Get <b>Client ID</b> and <b>Secret</b> from there.

``` .NET
using System;
using PayoutsSdk.Core;
using PayoutsSdk.Payouts;
using PayPalHttp;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CreatePayout
{
    static String clientId = "PAYPAL-CLIENT-ID";
    static String secret = "PAYPAL-CLIENT-SECRET";

    public static HttpClient client()
    {
    // Creating a sandbox environment
    PayPalEnvironment environment = new SandboxEnvironment(clientId, secret);

    // Creating a client for the environment
    PayPalHttpClient client = new PayPalHttpClient(environment);
    return client;
    }
}
```

## Examples
### Creating a Payout
This will create a Payout and print batch id for the created Payouts

```.NET
var body = new CreatePayoutRequest(){
 SenderBatchHeader = new SenderBatchHeader(){
  EmailMessage = "Congrats on recieving 1$",
  EmailSubject = "You recieved a payout!!"
 },
 Items = new List<PayoutItem>(){
   new PayoutItem()
   {
     RecipientType="EMAIL",
     Amount=new Currency(){
     CurrencyCode="USD",
     Value="1",
   },
 Receiver="payouts-simulator23@paypal.com",
    }
    }
};
 PayoutsPostRequest request = new PayoutsPostRequest();
  request.RequestBody(body);
  var response = await PayPalClient.client().Execute(request);
  var result = response.Result<CreatePayoutResponse>();            
  Console.WriteLine("Status: {0}", result.BatchHeader.BatchStatus);
  Console.WriteLine("Batch Id: {0}", result.BatchHeader.PayoutBatchId);
  Console.WriteLine("Links:");
  foreach (LinkDescription link in result.Links)
   {
   Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
   }

```

### Retrieve a Payouts Batch
This will retrieve a payouts batch
``` .NET
  PayoutsGetRequest request = new PayoutsGetRequest(batchId);
  var getResponse = await PayPalClient.client().Execute(request);
  var result = getResponse.Result<PayoutBatch>();
  Console.WriteLine("Status: {0}", result.BatchHeader.BatchStatus);
  Console.WriteLine("Item: {0}", result.Items[0].PayoutItemId);
  Console.WriteLine("Batch Id: {0}", result.BatchHeader.PayoutBatchId);
  Console.WriteLine("Links:");
  foreach (LinkDescription link in result.Links)
  {
    Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
  }


```
## Running tests

To run integration tests using your client id and secret, clone this repository and run the following command:

```sh
$ PAYPAL_CLIENT_ID=YOUR_SANDBOX_CLIENT_ID PAYPAL_CLIENT_SECRET=YOUR_SANDBOX_CLIENT_SECRET dotnet test -v normal
```

You may use the client id and secret above for demonstration purposes.


## Samples

You can start off by trying out [/Payouts-DotNet-SDK/tree/master/Samples]().

Note: Update the `PayPalClient.cs` with your sandbox client credentials or pass your client credentials as environment variable while executing the samples.

## License
Code released under [SDK LICENSE](LICENSE)
