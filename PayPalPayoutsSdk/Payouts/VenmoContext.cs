// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AlternateNotificationMethod.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/9xTzW7TQBC+8xSjPSWSm1AJOORWuT0hQlUiLlVUTbyTeKT1rNkdEyyUd0cbuwmJiwCBEOrNO7/fz/irWbQ1mZm5ckpBUAnmXnnNBSp7gXekpbcmMx8xMK4czbFK5SYzb6k9Pq4pFoHr1GNmJsdam0AR0FpOMXQg34+tvKUI6iEQFiX4RtNDS4JABfFnChBog8GybEBLjlBjW5HoxGTmKgRsO9gvM3NHaN+La81sjS5SCnxqOJA9BG6DrykoUzSz+wPh29ILDYnVffjI7jFySnFREuwzIE21ogAswBqhQPHCBTpg6RTt6N/fTC7fvOqLE6vaocDahwp1OSpV6zibTrfb7YS1mbDoNFAxXVzc3eQX+9YpyfjvsY+aQAzpF74RDe1D4e2pCmeJoRh9ARToXOKXCmGU5+Ps30gDHYhqxUIWHMlGS/Dr/VHlOaDY/edha29b1URNtwkrgk0gVAqgJQpcvgbLG9bYTT7vK7xEjhrTCjxmLUXl7tUrML/Ox/vtsVklzVJzP2P0Yf57lmpozhyVxrld9lNb6YuSRPby0K0+sfaJ5NDeQ1EP/k9P8ReBPwr7FO5hbgj7zLb/4BZ/+J886xNd7pa7F98AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// Captures additional notification modes to reach out to the receiver regarding this payment.
    /// </summary>
    [DataContract]
    public class VenmoContext
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public VenmoContext() {}

       /// <summary>
        /// Social feed privacy URL
        /// </summary>
        [DataMember(Name="social_feed_privacy", EmitDefaultValue = false)]
        public string SocialFeedPrivacy;

        /// <summary>
        /// Holler URL
        /// </summary>
        [DataMember(Name="holler_url", EmitDefaultValue = false)]
        public string HollerURL;

        /// <summary>
        ///  Logo URL
        /// </summary>
        [DataMember(Name="logo_url", EmitDefaultValue = false)]
        public string LogoURL;
    }
}




