// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Phone.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/9xTwWrcQAy99yvEnHbBWTfQ9uBbcXIqbEO69BJCkG3tWjDWuDMatqbk38us3Q1Zb2lLoZTcPNKT9PSe/M1shp5MYW5aJ2Qy8xk9Y2VpjV0Km8x8oOHpcUWh9twrOzGF2bQEfSoEiV1FHliANUCN4oRrtMCi5AUTHi3cXa8u372ZwCw76C0KbJ3vUO8XrWofijzf7/cr1rhi0dxTnW8ubq/Li0NpTrJcmcy89x6HkfnrzNwSNh/FDqbYog2UAl8ie2qOgRvvevLKFExxd9w5aCIxX7p2UdQPD7Vr6JkAJ4m5GBMAarQ27ZeAsCjLZfZvpIGRRFexUAOWZKctuC1oS1CWgNIcPo9TJ9u6GBTEKVQEO0+o5EFbFLh8Cw3vWMPY+bSudhI4aEgj8CnbUFAeX5MC66tyeZgeYpU0S8VTj8Wn9Z9Zqj6eOCrR2sfsl7bSVyUJ7ORhHP3M2jPJub1H0ET+b0/xN4n/EPYc73luTvvEtv/gFn/6n7zoE71/fPUdAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The phone number in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
    /// </summary>
    [DataContract]
    public class Phone
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Phone() {}

        /// <summary>
        /// REQUIRED
        /// The country calling code (CC), in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the CC and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        /// <summary>
        /// The extension number.
        /// </summary>
        [DataMember(Name="extension_number", EmitDefaultValue = false)]
        public string ExtensionNumber;

        /// <summary>
        /// REQUIRED
        /// The national number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en). The combined length of the country calling code (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [DataMember(Name="national_number", EmitDefaultValue = false)]
        public string NationalNumber;
    }
}

