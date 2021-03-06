// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutHeader.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7xXTW/bRhC991cM2EsLyJJRwwGqmwsHiFAgERIllzQQRsuRuPVyl97ZtUsU/e/FflASRamJFdcXAZwZLd+bj7fDv4tF21AxLebYGu/gDWFJthgVn9BKXCl6i3VwF6Pid2p3D7fEwsrGSaOLabGoCJp0QBUPAFehA8lgyXmrqQSpwRI3RjOBM4AH8ZbuPbEbw4fKPDKU5FAqhrWxgBpIO2m3r+hii1FxYy22icHlqHhPWL7Tqi2ma1RMwXDvpaVya5hb05B1kriYft5yZ2el3gxJr9CJaskOnedeAg4cp5LBkEKehNRZfwBUe6X+GW3RvrbWHKkQBXMf5tY0BBhdIPXa2BqD/f/PZkkrv1nKsgdxzzgEOcd2jgqkdmQ1KpjdjuEjUxnbQhhrSUXs0HjbGCb+XhLHMg23qRePEeoc+3w6W5/OjQYMwMCsActSBjOqXp+7riwHLF49fynWklS/Dp1lWASNNQXUAV6MSrMt0IdKnAL9vak/hVwye+oh7yxD5JaQjf7P3J4H88u3AN2N1lJJfdfHPHQO4X98PwtKmVokKuj2TxA7P6TfgKsk53HumJb0QCpgfl7hOUW1Jmbc9Kuysw2JZV/qozK6V8Rn1uhs1KGve5CzYYi38jXqC0tYhr+PwGt57/uD8Wy4v6W10uWyTJfQgZ4Ofadk9WJDmmzsotltumjztfW8+c+LxQfS4Z7/LQA7uWVwDMroqy5ox+64f8gwxV001jzIkspuydgnedYWMST7da2lGqVaHpuRQ8+RWzpE9Ocl34mBIcNjRTr2X+YkHdUgTN0ocsRj2J82mSaMQ9fGRCgFloRsJGnHLyTfiTL71Z8k3JFk7DxHipp8oKSmnajHDJ3ITINtTdr1634sR72jv5Io+ITKxyjUgKqpUPuarBSQSMOjdBUg1PiXrH0NivTGVUEofrm+BpZ6o+hi1ToCUaFF4ci+VPa3LJYuBO6nf+Aa5n92C8GXV/sy7ORrmXW7y7QlQfKBXmob6OnBgRIOfSd1ghsSgUtUQu3rFdkxLCyKO+5Nl44lF8J47UKluWVH9fgPf3l5JVbKiLt7bxzF5/Qr2FmjN8ny1jiaJvNk3w7J1qSn3MalIQZtHDTWCGKG0jdKCnTbj4sxzNbQGg8JfguYDxKmzBgOcpDfvfOnWj4iQ1zmZBIThezg6hJKbHkULTfzGVgKI5ISkrUzt7rO60dPpzh+x8VtZAv8yfBQB1BC+ZIYEN7cLF6/u/kQxvQurT4ExsqNDKt0LlKEtJ3fp74x13LS7NcwP+Rs5xYPtN8sFvPBK66TQaYnrfOJcv/EfY7pExGCZRRfIFAD45pUG76ebTvM+Pn0otqFam4FMAljHF6jVQtGiyx7Z3aTzM0UkErd9dHRxE4OZ+allnMna1oKS2H76YnGgWOoGGXo49CWITLfMmlAgyB0t1LuxRVtUI/CWH2exW9YcgcHpI3+y0+Vcw1PJxNnjOKxJLceG7uZVK5WE7sWV1dXv/7IJAKQi+vxq5+f6TPmh38BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The payout header that is returned in response to a payout header request. Shows details for an entire payout request.
    /// </summary>
    [DataContract]
    public class PayoutHeader
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutHeader() {}

        /// <summary>
        /// REQUIRED
        /// The payouts status.
        /// </summary>
        [DataMember(Name="batch_status", EmitDefaultValue = false)]
        public string BatchStatus;
        
        /// <summary>
        /// REQUIRED
        /// The PayPal-generated ID for a payout.
        /// </summary>
        [DataMember(Name="payout_batch_id", EmitDefaultValue = false)]
        public string PayoutBatchId;

        /// <summary>
        /// REQUIRED
        /// The sender-provided header for a payout request.
        /// </summary>
        [DataMember(Name="sender_batch_header", EmitDefaultValue = false)]
        public PayoutSenderBatchHeader SenderBatchHeader;

        /// <summary>
        /// The date and time when processing for the payout began, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="time_created", EmitDefaultValue = false)]
        public string TimeCreated;
    }
}

