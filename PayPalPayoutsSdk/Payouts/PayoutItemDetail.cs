// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutItemDetail.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/8SXbW/jNgzH3+9TEH7TG+A83HbAgLwLkhuQDbgrrrkbhq5oFZmJicqSJ9LNjGHffZCfEtfp1vWK7FUbUg/8UX9R9J/RuswxmkWXqnSFwEowgyWKIhPF0RflSW0MflBZGBPF0c9YHn4skbWnXMjZaBatU4SkmsmwdR4UMNoE/Uh7VIIJ5PUW4oKL7M4geNSUE1oZR3E0916VdTjTOPqEKvloTRnNtsowBsPvBXlMOsOldzl6IeRodt2BLArv0epyGL7KXGGlB9GZhii6WQeUTaAe12BtySqrSRkQrywrHWbFwIVOQTEo2CijrEZwPjBnaAWSAv8TovjiSUIWT3Y35NMH8gPhkXHIeC2pRxzpVHmlBT2srj6O3n339ocDvXYJ3ryZJE7zhKzgzquwwCQhj1omHlkm7eBRGMyTb7+S1BbG/BX/K+6DMgX2WFvLELTyxLBPSaeQ0S4V2ODst2I6/V4XpvqL9S9D9a+5hQoXfXXqDSIhg6F7hLufLn+9A0mVgPII1glImZNWxpSw9bUmlBnXi07aVR/tAQlqypTpZpzea/1hebQXF5uEHijBJEToQFJXsLKJpHx6u0lL+KPzIGm4dXXywRbZBj24bRdIbpTG9v72RBADI8L14tjGMAqSgSCZmzepSM6zyWS/34+J3dj53YTYVYIa9TUyTiUzr6KTm2coxTrpC6UxDHXSVCzOUdOWQoacYJUN64S2pCvx8xiuijx3XhiKPBS0d9PpFOZXi9UKusvEVeV4GzzW2dFj79dWvGfeEo8a6QF9j//IOMxB6wyyCGppStgYFs575NzZhKHSHcJdV8Bvpczxrr5oQLbTGbK8bjmoEE5hNnHY2t+D7buGyMFxwPVSvt5z9NS5KCPorRK83RbGDKM+7e+Hvnx/+en9Yr5+vxzDug39gqGbW4GNYaEsbDA8TAWTRebKHoMlfV//F667LcFJir7ORlVutLKhsm0QODckdb3ZkmeJwSiWZv02FbBP0R6SCMRHe55J76ez+XQOfzkRco6ew4suRzkNK9S45+HY0QPaIUjP/DKSaonqyJuTPCNVRklicIjVt7+Mq16jkeRnRlCGXShULM4jZIURyg0ej2Mgq02RkN01S4l3tsxI1/lR4T5ccNxb+zyZyj1u6Y9ekjrTsIDVripoITEYtwW6Tc4ZI+di+zjyznTixa1c1RP7v8XrB3o82F6mxWZ+LaKMTNnIch4keW/d3oYvhTDjuWW03uUfhd1s+ljUWV/UmWtF3Yx/lTTfPK8VOeoVnnijG9dQKKtl6LCbh4kStKEfQz5uUbrW5Xy9VRP1XhmD8gRS5xxC1a5w4B6blqmZ1bJ0gK6QMdRf6VX79QVt5g7jue3qQcFF6FovoA67/n6Fz1eQuQ0ZhDx1FpvW/1xXrGqrb0kwu6Wkf9Meu/pJmg9b8tWyDR7WXun74wyFzlNZUFqH7/VAzyULZq+k8W/+BgAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The details for a sender-created payout to a single recipient.
    /// </summary>
    [DataContract]
    public class PayoutItemDetail
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutItemDetail() {}

        /// <summary>
        /// REQUIRED
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount;

        /// <summary>
        /// The sender-specified note for notifications. Supports up to 4000 ASCII characters and 1000 non-ASCII characters.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note;

        /// <summary>
        /// REQUIRED
        /// The receiver of the payment. Corresponds to the `recipient_type` value in the request.
        /// </summary>
        [DataMember(Name="receiver", EmitDefaultValue = false)]
        public string Receiver;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name="recipient_name", EmitDefaultValue = false)]
        public Name RecipientName;

        /// <summary>
        /// The ID type that identifies the payment receiver.
        /// </summary>
        [DataMember(Name="recipient_type", EmitDefaultValue = false)]
        public string RecipientType;

        /// <summary>
        /// The wallet where the recipient receives the payout. Payouts to Venmo recipients require a 'note' string and a US mobile phone number.
        /// </summary>
        [DataMember(Name="recipient_wallet", EmitDefaultValue = false)]
        public string RecipientWallet;

        /// <summary>
        /// A sender-specified ID number. Tracks the payout in an accounting system.
        /// </summary>
        [DataMember(Name="sender_item_id", EmitDefaultValue = false)]
        public string SenderItemId;
    }
}

