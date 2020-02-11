// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// SenderBatchHeader.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7xWT28bxw+9/z4Fsb9LAkiW2sAX3xQkhY22jtAYuaSBwJ2hJNazM+vhrJ1Fke9ezJ+VVl4HRZLCNy2H4pCPj4/zd3XTt1RdVO/JavLwGoPawyWhJl/Nqg/oGWtD19hEp2pW/Ur98eMNifLcBna2uqhu9gSSwsxb7+5Zk4YWe9cF2KeAsHUecLB5uutIwlk1q1beY58TWc6qPwj1O2v66mKLRiga7jr2pA+GtXct+cAk1cXHQwmu/otUmGaNWnNMEc2G7db5BlPC41q+6jKt8OgKI9cZ8BbQ9jPAOhYX9gQt+mDJ/2iBtjPmy+xQpQTPdjetsrYb5TSdlHW0Teso2UHwqG7Z7iB6zsB5qDs2GqwLqTJ48fr6ZTkMewzAAijCO0sagjupFGLgezQdgUILaMRBTXBgAwpgOWeb/vlnt1y+UjF6+kVr7Ndo5usccL4KwXPdxTzmVzo7L47eA4cKv87gF+ehcZ7GrTl0hKX4zUCI4OOP3f3pxUI7JQtseeFpS56sovg1L0nJ4v8t9i2aeYFnjqOIrF8+EzGoQTabhkRwd0qPxydTkiQPKB65/RmlNOgCD3uyhQFppjlQA8o1raFAkvkw/JsleQo2lIXAGPCkuGWyQZ4VDOkGqXgMxvHkCW3LZ2DY5grCAaGvINNi35ANp7r3FEYnof8FKPiQB0ggjVi7R9s15FlBLhrcFro2jubP5+cgbHeG5nUfCNQePapA/rnQti6cMq4YnlKjiE0sSSeA5obuyUQRIgH0BMpZhYEsBtKDeCTsC8nwMzddwrXmqEyG7C7sIxbRM8dhgZ+Wy+Xz43Do3iZExzEik6MpNldvIJ4V9dVkA2+ZMkkOfx8qLZTLUkifMdJsNpHZt7+vrn6bSNozoZHfCJs6PjU2rE/gmJ6d4rEaXhjSkoow6AiP7Zo6rZ+4y+REkGyaEqVcZ0McDuklUHOWa6+NU7d3nQsFgGyV4J3dZcu1C3RRgBrbC6LteHOAdiSRanHhKRIB3bWGI20Hfp/B1RZ610FOvwectOYRAtOdl2jwgAKdHEfBoAR4tQSNvcySZbW+Ak9RVQam5FX5wGEfMSHv47IcS7vs3UN2Pib+zemlCbbKdDpOLlyubt6+W72PynY7PBec5x3HB1RpUkrpIHnfemPp5aId97B8FLQ9KeL7mBtc3tysJ1ecZwPnL2tLRB5HHNcoAUMn5VEUL4ivHcEtmR48Bd9PEf/+8pK+xW4edkbeJWmzOGt6cFaVTfGdbOJCppgp24FHTwK7eDwz/4VmfPryv38AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The sender-provided payout header for a payout request.
    /// </summary>
    [DataContract]
    public class SenderBatchHeader
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public SenderBatchHeader() {}

        /// <summary>
        /// The additional information, if any, about the partner.
        /// </summary>
        [DataMember(Name="additional_information", EmitDefaultValue = false)]
        public Dictionary<string,string> AdditionalInformation;

        /// <summary>
        /// The partner tracking code, or build notation (BN) code, that is assigned to the partner. The value can also be provided as a value in the <code>PayPal-Partner-Attribution-Id</code> request header. For more information about this header, see [<code>PayPal-Partner-Attribution-Id</code>](/docs/api/reference/api-requests/#paypal-partner-attribution-id).
        /// </summary>
        [DataMember(Name="bn_code", EmitDefaultValue = false)]
        public string BnCode;

        /// <summary>
        /// The email message that PayPal sends when the payout item completes. The message is the same for all recipients.
        /// </summary>
        [DataMember(Name="email_message", EmitDefaultValue = false)]
        public string EmailMessage;

        /// <summary>
        /// The subject line for the email that PayPal sends when payment for a payout item completes. The subject line is the same for all recipients. Value is an alphanumeric string of up to 255 single-byte characters.
        /// </summary>
        [DataMember(Name="email_subject", EmitDefaultValue = false)]
        public string EmailSubject;

        /// <summary>
        /// The payouts and item-level notes are concatenated in the email. The maximum combined length of the notes is 1000 characters.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note;

        /// <summary>
        /// The ID type that identifies the recipient of the payment. For example, <code>EMAIL</code>.
        /// </summary>
        [DataMember(Name="recipient_type", EmitDefaultValue = false)]
        public string RecipientType;

        /// <summary>
        /// A sender-specified ID number. Tracks the payout in an accounting system.<blockquote><strong>Note:</strong> <p>PayPal does not process duplicate payouts. If you specify a <code>sender_batch_id</code> that was used in the last 30 days, the API rejects the request with an error message that shows the duplicate <code>sender_batch_id</code> and includes a HATEOAS link to the original payout with the same <code>sender_batch_id</code>.</p><p>If you receive an HTTP <code>5<i>nn</i></code> status code, you can safely retry the request with the same <code>sender_batch_id</code>. The API completes a payment only once for a <code>sender_batch_id</code> that is used within 30 days.</p></blockquote>
        /// </summary>
        [DataMember(Name="sender_batch_id", EmitDefaultValue = false)]
        public string SenderBatchId;
    }
}

