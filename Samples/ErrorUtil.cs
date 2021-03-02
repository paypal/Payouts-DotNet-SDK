using PayoutsSdk.Payouts;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Samples
{

 public class ErrorUtil
    {
     public static Error deserializeError(string errorString){
        var deserializedError = new Error();
        var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(errorString));
        var deserializer = new DataContractJsonSerializer(deserializedError.GetType());
        deserializedError = deserializer.ReadObject(memoryStream) as Error;
        memoryStream.Close();
       return deserializedError;
     }

     public static void printError(Error error){
         Console.WriteLine("Error "+error.Name);
         Console.WriteLine("DebugId "+error.DebugId); 
         Console.WriteLine("Message "+error.Message);
         foreach(var detail in error.Details){
            Console.WriteLine("Field "+detail.Field);
            Console.WriteLine("Issue "+detail.Issue);
         }
     }

    }
}