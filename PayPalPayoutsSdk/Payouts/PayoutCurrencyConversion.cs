// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutCurrencyConversion.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+yU32sUMRDH3/0rhjxV2LutP0C4t9IiqNAWLYLUo51L5i7BbLJOJj0X6f8uu9u73nZrURRB6NOSyWRmPjPfne/qrKlJzdQpNjELHGZmCroBHcMVcXIxqEJ9RHa48HSMVeurCvWOmtvDESXNrpbWeabOLIEehwGmFDNrmqpCHTBj02feL9R7QnMSfKNmS/SJWsPX7JjM1nDKsSYWR0nNzrc1J2EXVuP66Ju2GFZ0wSg0KPbuzbjyjQe0HiAWBVwCrGvvyMAyMoh1CequXX+KErL318WWZ9P8MdGSY3WBVcxBBjxD+wNzwGCg9+sYEJYuYNAOPQhjSKjbVwWkrC1gAoQFegyaIHILW1EQMPkfDE/fNuGWc8c4hjwXy0QTbZFRCzG8+XAyefn82atdGRqa75Um6lS6ILRibAOUxjFpKZmSlBvnSeucyqe/hSqcH57tz3Cv0OehRjeWMWh3U8DaOm2hcisrsKDZ57y//0Jn332pP3nXnw4CdLjE3dhvEB0l8O4LweXb00+XvciRCUIUkKZ2Gr1vYMm9KNBP+6DlJuqdHGBIuwr99sX9uc6Oj3Zypbww7soZMm2FEcTGnDAYsen+dOWG8HX3DxLwTfMh5GpBDHG5LaT2qCndKH0gggISEZwf7toSTFrJQCuZ+Z4VqdOsLNfr9dSlOI28Kl2KnaAmQ41MrVT+r+hk/ktbQOJ9O2DX+rgBHjfA4wb4PzfA/PrJDwAAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The currency conversion resource.
    /// </summary>
    [DataContract]
    public class PayoutCurrencyConversion
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutCurrencyConversion() {}

        /// <summary>
        /// The exchange rate that is applied for this payout.
        /// </summary>
        [DataMember(Name="exchange_rate", EmitDefaultValue = false)]
        public string ExchangeRate;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="from_amount", EmitDefaultValue = false)]
        public Currency FromAmount;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="to_amount", EmitDefaultValue = false)]
        public Currency ToAmount;
    }
}

