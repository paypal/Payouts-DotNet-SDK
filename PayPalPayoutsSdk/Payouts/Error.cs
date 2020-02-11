// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Error.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/6yTQW/bMAyF7/sVhM5esdMOvhXIDsWALSjaXYaiYCI6JiZLLiUNMIb+90GOnUTTMqxOjn4Uje/xkb/Uw9CTqtUnESeqUt9QGDeGvmCXZFWpzzQcP1bkt8J9YGdVrR5aAkqNwLZx0mHSb1SlbkVw2P/5Q6XuCfVXawZVN2g8JeElspA+CGtxPUlg8qr+fmDyQdjuSihNm7h7Zp3BnYgl5BqHNRpgG0gsGrhb3cCjJw2NE9g6ETIjO/RReufJX2rCRmNeq3y6sKKAbPzfDM2FUz+zltu5tYAJDFwDqDUnGQ1Mz0dDYY7lDxcfrx9Fw2TyHGalDMFiR4k64Y2vILQYYIsxJXEO+tLRnyNn7yNl5LNSkguhd/afs12G+fQ/oMfTejZsf+TMZbHEf7y/g+CmFSF9eqwwbn4av4PQsp/OeXaq6SeZxPwmt0Hiskw68h53eSpHrTQ21fZ7pMfyhvzCjBZTp73OkCeh5G1jh/a9EOrUXkG0/BLzw7ga99Pru98AAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// The error information.
    /// </summary>
    [DataContract]
    public class Error
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Error() {}

        /// <summary>
        /// The PayPal internal ID. Used for correlation purposes.
        /// </summary>
        [DataMember(Name="debug_id", EmitDefaultValue = false)]
        public string DebugId;

        /// <summary>
        /// An array of additional details for the error.
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue = false)]
        public List<ErrorDetails> Details;

        /// <summary>
        /// REQUIRED
        /// The URI to detailed information related to this error for the developer.
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
        /// The human-readable, unique name of the error.
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue = false)]
        public string Name;
    }
}

