// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutBatchHeader.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The payout header that is returned in response to a payout header request. Shows details for an entire payout request.
    /// </summary>
    [DataContract]
    public class PayoutBatchHeader
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutBatchHeader() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount;

        /// <summary>
        /// REQUIRED
        /// The payouts status.
        /// </summary>
        [DataMember(Name="batch_status", EmitDefaultValue = false)]
        public string BatchStatus;

        /// <summary>
        /// The currency conversion resource.
        /// </summary>
        [DataMember(Name="currency_conversion", EmitDefaultValue = false)]
        public PayoutCurrencyConversion CurrencyConversion;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="fees", EmitDefaultValue = false)]
        public Currency Fees;

        /// <summary>
        /// Identifies a funding source type.
        /// </summary>
        [DataMember(Name="funding_source", EmitDefaultValue = false)]
        public string FundingSource;

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
        /// The date and time when the payout was closed, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). A payout is considered closed when all items in a batch are processed and the available balance from the temporary hold is released.
        /// </summary>
        [DataMember(Name="time_closed", EmitDefaultValue = false)]
        public string TimeClosed;

        /// <summary>
        /// The date and time when processing for the payout was completed, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="time_completed", EmitDefaultValue = false)]
        public string TimeCompleted;

        /// <summary>
        /// The date and time when processing for the payout began, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="time_created", EmitDefaultValue = false)]
        public string TimeCreated;
    }
}

