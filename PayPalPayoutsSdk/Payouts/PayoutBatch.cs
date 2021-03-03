// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutBatch.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+wda2/cNvL7/YrB9oA0wD7cpukj33xxivquSI3YyeHgC9ZcabTimSIVDuWNcLj/fuBDWr02dpz1tkn1KdkZSpwXh/Mg5f9OLsocJ88mZ6xUhYG/MROlk+nkDdOcrQS+ZJnFTqaTf2C5/XGCFGmeG67k5NnkIkU4Y+UZE7M1StTMYAwr+yYgw0xB88l0cqw1K/1kR9PJK2Txb1KUk2cJE4QW8K7gGuMacKZVjtpwpMmzy0Ey4RdkMeo+tW7qZVpht5R3EH0ucv96PwJMygxwAo2m0BJj4BI0Uq4kIRgFrDNe47sCyczhPFUbghgN44IgURqYBJSG63qKauzeJPO80BplVPbFwTJVSNMSRA3qiyAK7wEmY/DjPAeQcMlkxJkAo5kkFtmnpkBFlAIjYLBigskIQWnLZYbSQFzg/lgko7lc9xmMtqxvWWwA+0xemlQjzqKUaRYZ1HB6/tvsu2+/+WHLfqRifPv1IlYRLbg0uNbMvmARc42RWWgks6gGz+xgWjz+KFaNLjqcykKI/01vZfeGiQJbvFaQPqMOM4VNyqMUMr5ODazw2b+Lo6MnUSHcv+h/Ce5/HUtw7KJ2ag8sciQQ/Brh6u9n/7ryK4NpBKkMmDLnEROihER7o2Bi7l+6qN7amQNijHjGRP3E8FwXL08ac1GxivkNj91CNApMqgpiMjYpDU+3qDj8WdnFjG7RWeGDLLIValBJTUguWIRhrbaNYAqECJfPmzCCmTUZsCbz9uvUmJyeLRabzWbOSc2VXi84KWdQs7aNzFOTib3Yyds7WIr3d94HDzjCGrHLEdJ9/Petdh18eEOg8gY12cl3Lu1la1B/lbfxH/Bq23HWlatCRwdwUPg+Splc49JujS36u5g+5dUIsCPqLYnlueAYO3s1KaegsE9lpaOp3XtKolW2HNhY2vBxdxl3l3F3+dx3l91ewKghH9CEjh5g9ACjB/g8PUDTB7zQWg1k2mjB7dCyBg2EMhYFXCZKZ87YH37pxrgq1kset0hsAHcVMpyNaskEnJ7M4TWFUCtSWqNwtENe6FwR0p5jLidpOPG1gyGGKkSTnwrWZudYArOEWTtkccz90mnVJUyllg4X3+9fFQlH0dZDBekrQbIMLdWWPDfKr9KIFVYTu4j+VNHvopwTdRxiBelTrpFRcDf7JfMu+V5jaS0Fl9dtmvvIPvmvX52CUcFEnCOsHwJn+Vb8yqccfjlXnMZ4g8LSfJhNKkMitm5rZQvrMxZw3o5ih14h3VNH96ba2nWL5ADo05sWGZMzjSy2j0+hkPxd0V4Ye6P7bsFegth2OwEwhnhjiDeGeF9qCTEpZMzleulLZe3130W1bec0Rml4YlXBIIwFP9bqGw+0efvC2NJXPDuBYB93h8bW6UlQ8T1KbnetjZ6jjFHf0uYiN2i5s9s1jO9z6MfNcq38ygjdrCaT92pX9Zm9Q6U0Y1wshzb3LmYgvbAj2ht9COYthwSbFKVbw4EnbjCDSGW5QIM0h2aYwH1oQHa7dYIQAjRGPOcoDR3IdD3LVKz+g5EZEMYWM6BUjwPBJW6jUSehHZKp9tuW3odk1Hr1LYKCN3b3cBVrCUzkKZNFhppH4JmGDTcpMMjYe54VGQiUa5Nar/rt06dAXK4FzlalQag32kNJv+Ziab1VS/w9VF/+pyfOyYWC/dYVBvtzktYYIb/BQ6UxLX/Q8YR93E4/QTlGlhfnCf0uOIcLzaJraq0u6VQeRTb8c66/JINZ2GZXQkXX7wplsLnbktFKrj3kpTJVlLFowsHDcv8rmHGskFwgkWsVIRHERS54xEzdyZrDaQKlKsCTXwILL7J7qn9XRwZh7i3e63LDCFwWyr0zEYwMPDmCmJU0dZDjs1PQaJcI1SEDkgmmLkPe1PJT5A4MuDSqJvyjybPRNpeRKGK35f5yfPHit+Nzu0yvfc5mw2q+5tLGKl5JjqR6/X7sjFXIlDd1GH4EaQcTt2z/cnFx1pviqQeEmEvK8MZ2DNbg0fcjQ1BlJ4iYBGIJihI0Gl32JX5/9py3s9qsHaB3jG7xKilKUDZX8Q7zftbEgzFZSrms7GhQsIvumjlUVcHwDJeRUIRtn9GG9/1FbK3YGqUd2Nt97TryD0/tUro8dQU3NJ3HfPlhGyAbpQTNOZrExcg2Fl7oJHry5MlPXxG6RGD2dP794zkc157I2oskHqON2/2cnhy7Wdkdjpy3CkeWbJ4Q3AjGnpAUgd0wLqxQ6hQ10SpzKINZrjTTJaRKxP7AkEBGGB/IsXtFBBsd0lEDdSc1Bfat165Ch6bWqtc9jOIOKTONbFhiNeIT5bXCNZN/XDm97aceuL9Kfyg0j1X+jyg176WCm9TC75Rw6+MiB6x5fumV2lCZbRdsfaH2/l2AuxYKbukWhQKHm3851DraMeBOfaQPLfKxf/RH6x9tyfzVJgTNmXsEW+fStpMKstswQsw9q7pEl838g6oyOMv5QmOCGmWE9tesOlBNi69SZlAxmrknHj+8RaUakxaXATDQ0QghDxim12jg9atf53ChIGPXGDIOz3XEhJja4SsuPSZDk6q4SkU4waX10BeY5faJmffNBuNbI4Dvn/5w9NhJcw4/Kw25xtk28JhWqZ+b9OqvV1O4+vpq6uKMq8dXzfKJS2uuLK9XVfnmGss6X7S8KmlTHLdmnDKAbaM+x2NVt6FiRVbx0jjwgRaUl2lnRwmgvvJc4hnUUJfvzQ7lHay4JDoVJTHcZXLZex2NmDLHWw3l6U8//liHit89rlo3hPrGZrCuFFcXsX11wCq6kCxb8XWhChJlZ+MlzJg0PKLKqXozPEeES+dOXgUKqdPKYJI52hgRX0ubONPCPjurWOr+nL//+PbG7uj27VCE66vqpwazAVdts8G2qw6Q3Z6PS9dTKlhIJh/ecbHI8Btuym7I24bvDFV6LY1IZZlyRhESH7s8nGX4KgbY5Nm5kqpk6SGNJm4jfDaaRddcrve8lMZj4+Ox8fFEwXiiYDxRMB4bHz3A6AFGDzAeGx8LyuOx8bHsNx4bH5sRv/Ox8bGmPNaUx5ryWFP+E9SUf78j59tzJQ9TWj01mIUQcidT3JfNewwF+MBxmeZXkKozpFWZOZyScd9S8od9t4eHx08jffpx+rEEMZYgxmtNQxG16nRUAuAOp97tSCcNqQxPeBT2GDgv8lxpQ1Dk1qF9d3R0BMfnz09PG3GS8xzfWIxUctbFHu5ig+vhda80VMCh7DR0/cJOHVzYHJ4r7WPtmKoj5lftyxFXfqFVp+X3c4+ow+hLnw3tvL/RS596qA+XEnKmTfnwRScmXO3I4DIphOhTPYxvk37y4uzVi+fHFy9OfEjuSH9EUD/rGJvDcyZhhXZjKohLJHLwKUgeXfv/uY8WlqBMitpLI9RSpPVsKwTKBTfe3yRck5n6qxD+/ZUomse+tSldD7Ke80D2PizN3TL85wDJOWqyO7ppyNS+wbN7GD7W/AZln5EW+H6cuFc4lQdNHpCrjMexwD5bbfj9+PLvCCb5mhCYIGUdFRmlEbJCGJ4LbI6jkPNyuQ6vMlrJMuORlw+z6+ERTVvvPtBNVo0Jf98OvivQwBf8HMoRbbgROK0cdCWcA1JORdKlvAYNXV20qEbG8zvQq3v2uIXdzxbD896IMi7KYJbH1iSvpdpImynUN8ru4Eb9LB807DBp16iztlFnqjLqMP5gmfIXd8dyS/WGCYFmB0s1ss+UR1mF66qSFJ6qeGles5zDWfhSp1HwBmWmGrdvq6geGDyyUeuj6tKty1/h9TlkasUFQp4qidVdzoNeRuUGsx13UbeoToF4TxdR923ju6sMjRLJMkHcVT4JuPHsw1h4GAsPX2rhobneh0vDu/xe2PE6Fwzt6Dm84bhx145cnOCuuadq06m9Pkjp+IP3K+trtP0blk3UHa8Oc/Kfo9gw8jFS/Y7P+iLq1nF3DaKH+rhWQfN09uF5Gfjq+CC6z5NTcmPsnv6IxNizHnvWY8967Fn/uXvWIZAcOpRtmFj27z+14X3NOHwjequ/p+EO4RXuc1BUCLuAaN/Bxy3M5GyNQ8xU8NuZcSP3pIO//B8AAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The PayPal-generated batch status.
    /// </summary>
    [DataContract]
    public class PayoutBatch
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutBatch() {}

        /// <summary>
        /// The payout header that is returned in response to a payout header request. Shows details for an entire payout request.
        /// </summary>
        [DataMember(Name="batch_header", EmitDefaultValue = false)]
        public PayoutBatchHeader BatchHeader;
        
        /// <summary>
        /// An array of individual items.
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue = false)]
        public List<PayoutBatchItem> Items;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;

        /// <summary>
        /// The total number of items in the full result list.
        /// </summary>
        [DataMember(Name="total_items", EmitDefaultValue = false)]
        public int? TotalItems;

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue = false)]
        public int? TotalPages;
    }
}

