// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutBatchItem.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The payout item status and other details.
    /// </summary>
    [DataContract]
    public class PayoutBatchItem
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutBatchItem() {}

        /// <summary>
        /// The unique PayPal-generated common ID created to link sender side and receiver side transaction. Used for tracking.
        /// </summary>
        [DataMember(Name="activity_id", EmitDefaultValue = false)]
        public string ActivityId;

        /// <summary>
        /// The currency conversion resource.
        /// </summary>
        [DataMember(Name="currency_conversion", EmitDefaultValue = false)]
        public PayoutCurrencyConversion CurrencyConversion;

        /// <summary>
        /// The error information.
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue = false)]
        public Error Errors;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;

        /// <summary>
        /// REQUIRED
        /// The PayPal-generated ID for the payout.
        /// </summary>
        [DataMember(Name="payout_batch_id", EmitDefaultValue = false)]
        public string PayoutBatchId;

        /// <summary>
        /// REQUIRED
        /// The details for a sender-created payout to a single recipient.
        /// </summary>
        [DataMember(Name="payout_item", EmitDefaultValue = false)]
        public PayoutItemDetail PayoutItem;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="payout_item_fee", EmitDefaultValue = false)]
        public Currency PayoutItemFee;

        /// <summary>
        /// REQUIRED
        /// The ID for the payout item. Viewable when you show details for a payout.
        /// </summary>
        [DataMember(Name="payout_item_id", EmitDefaultValue = false)]
        public string PayoutItemId;

        /// <summary>
        /// The date and time when this item was last processed, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="time_processed", EmitDefaultValue = false)]
        public string TimeProcessed;

        /// <summary>
        /// The PayPal-generated ID for the transaction.
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue = false)]
        public string TransactionId;

        /// <summary>
        /// The item transaction status.
        /// </summary>
        [DataMember(Name="transaction_status", EmitDefaultValue = false)]
        public string TransactionStatus;
    }
}

