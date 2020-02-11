// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutErrorDetails.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7yUQW/7RBDF73yKkf8cGsmx/wdaSm6RWtSKilZpyiWK5Ik9jldZ77ozY4KF+t3R2nVKGqGCKBz3ZSf7e/PG83u07BqKZtEDdr5VuGb2DFekaKxEcfQLssGNpZ+xDreiOPqJurfDFUnOplHjXTSLlhVBMZRC6RnQAYX/S6I4mjNjN7z1NY4WhMW9s100K9EKBeG5NUzFQXhg3xCrIYlmqwOlKBu3PeUqDdniCG5UTgkd1gS+BK0I+lugFSrk2AoVvfrPoZXbd8yutfYl/hDciLR0BD4qp+BMKN71nf2PKO+M28GfHz7htcbt5Ih3VI555w4wYIVGMz23JDplsqhUwOpmvry+nz9CX7o+SwufS4qNSZlKYnI5hdOUSRrvhCT9UqGSR5n2FZN3pi8+f54qpvLI5atwGkru68aSEijylhSeFncJLD3UuKM+ptF1jtbG4frGuOGXmrTyBeyNVqCVEVg9LW5hSXUTKqal5xpVqVifVaqNzNJUvbeSGNIy8bxNK61tymV+cf7910nfzQR+9AwN07Rhn5OIcdsYjMttWwyPZt9mMWRnWQzoCsgmGeQVMuZKLAkER1nwmoGR/v6OOhjzCl69I6fDF9OHAXhoweBx8IMg7UZC8E57+d/ugL/5PQ09PYruIJ2Gd7NcPowx8OvroH8R3v/kgMke4Q/nU/ZVaP8AaLwD7Rr6cFDOf7i8/CKUh4rpd5MY9pXJKxDiX0kAJWzs26thd/fxDkG3DuuN2ba+FdtB0aNsaJgPoRqdmlzGlTqM4SMRrPp1sngllDe6/X6fGHTYs6GI2bqanEoaaqejpffH5LdgY/IpMaxf1i/f/AEAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The details for an error.
    /// </summary>
    [DataContract]
    public class PayoutErrorDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayoutErrorDetails() {}

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

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;
    }
}

