// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutError.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7xWTW/bRhC991cMmB4sgJJyaNJUNwNOEaNBIzhyL4JhjbhDceHlLj2zrEoU/e/F7oqyadYNktiGDsLOB/e9eTND/p2tuoayRbbEzrUeiNlxlmd/IGvcGvod6+DN8uw36u4OZyQF68ZrZ7NFtqooJYIij9rILMuzU2bs0sNf59kFofpkTZctSjRCwXDbaiZ1NCzZNcRek2SL9RGWeNZ2NwakaNvurrUaALtnHANcYrdEA9p6YosGzs9mcCmkoHQMhWMmgyEcmpYbJ/TdJGxrzD/5F5loWzqu49XXRtubAaP/cI6ZXV6cRxKp+KTgXlZ0+EpLEuirOHluv41STSK4owGTO9uYwMEHvkIPKrq3JOD7tnoZ1Db83Yd8MIzxtlbftgRVW6OdMqEKT4EQfij3s+A+TOj7OGhnadDGLJoYdR3vv1bHqDtWjwQMWZ5awAAcXAmolA5mNP875G+ffshLTWY44b1lrEmsvitj8WNU6qYC2zDj3ybJdwy1SDtspt4yRs6EchzU54H5UdsbuH/zCHBYLsM+6S2PNwbTbUvip3FzkoL1h9PV+0+nnyGmXp3MlStkjo2eM5XEZAsKpymTNM4KyfxVhZ4cyjRmTJ6/oyqmcsDyYBirUri6MeQJPPKOPFxefJzBykGNNxR16lkXaEwewrfaJk9NvnIK9tpXafWuw4ZeUd2EjGnazZ7U1UnlfSOL+dw7Z2SmyZczx7t55Wsz57J4++bn15NYzRn86hgapmnDriARbXc5aFuYVqVLNz9ucticbHJAq2Az2UBRIWPhiWUGgdEmcN2ATov1hjro9QpcnSXr08xEMQCPJUgcEx8EabcShLc+ml9ooFJNH7xRDqaxeB9Wq2UvAx9uB/+IeC/EgMkM4KfzGPs6lB+OXyO+a+iLjfLml3fvXgkVIWP60ySHfaWLCoT4TxJAAbRwfhZXDEZ5k9CtxXqrd61rxXQPXrxCNVqvC+mXamrDz0Swjuvk4oBQ7tDt9/uZRosRG4rona3JepmH3GlP6eFx9legMXkSGa7i74d/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The error details.
    /// </summary>
    [DataContract]
    public class PayoutError
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutError() {}

        /// <summary>
        /// The PayPal internal ID. Used for correlation purposes.
        /// </summary>
        [DataMember(Name="debug_id", EmitDefaultValue = false)]
        public string DebugId;

        /// <summary>
        /// REQUIRED
        /// The URI for detailed information for this error.
        /// </summary>
        [DataMember(Name="information_link", EmitDefaultValue = false)]
        public string InformationLink;

        /// <summary>
        /// REQUIRED
        /// The message that describes the error.
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue = false)]
        public string Message;

        /// <summary>
        /// REQUIRED
        /// The unique human-readable name for the error.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;

        /// <summary>
        /// An array of additional error details.
        /// </summary>
        [DataMember(Name="payout_error_details", EmitDefaultValue = false)]
        public List<PayoutErrorDetails> PayoutErrorDetails;
    }
}

