// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// ErrorDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6zQQUvzQBDG8fv7KYY55y0ePOUm1JOgUooUROjYfWIGtrtxZnMI0u8uTWil5iCCx/3vMPx2P3g9dOCab82y0RJFNDpX/CSm8hpxL/vjNVd8h+HrsITvTLuiOXHN6xaEcUGYFixohfdeDYGabLSLilT+uwbQ9nqz2U7TvuCKb8xkmBBXFa8g4SHFgetGouMYpj3n8Gi5gxWFc/185nsxTW9zd6OI4QJ/KvMXJNmDckOlBY1TVFoptJPeEcY6qn+FLtZ/M6c+xkP1I1zde1zAT2UON4jnNP70nypfDv8+AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The error details. Required for client-side `4XX` errors.
    /// </summary>
    [DataContract]
    public class ErrorDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ErrorDetails() {}

        /// <summary>
        /// REQUIRED
        /// The name of the field that caused the error.
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue = false)]
        public string Field;

        /// <summary>
        /// REQUIRED
        /// The reason for the error.
        /// </summary>
        [DataMember(Name="issue", EmitDefaultValue = false)]
        public string Issue;
    }
}

