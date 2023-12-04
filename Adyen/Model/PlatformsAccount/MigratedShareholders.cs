/*
* Account API
*
*
* The version of the OpenAPI document: 6
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// MigratedShareholders
    /// </summary>
    [DataContract(Name = "MigratedShareholders")]
    public partial class MigratedShareholders : IEquatable<MigratedShareholders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigratedShareholders" /> class.
        /// </summary>
        /// <param name="legalEntityCode">The unique identifier of the legal entity of that shareholder in the balance platform..</param>
        /// <param name="shareholderCode">The unique identifier of the account of the migrated shareholder in the classic integration..</param>
        public MigratedShareholders(string legalEntityCode = default(string), string shareholderCode = default(string))
        {
            this.LegalEntityCode = legalEntityCode;
            this.ShareholderCode = shareholderCode;
        }

        /// <summary>
        /// The unique identifier of the legal entity of that shareholder in the balance platform.
        /// </summary>
        /// <value>The unique identifier of the legal entity of that shareholder in the balance platform.</value>
        [DataMember(Name = "legalEntityCode", EmitDefaultValue = false)]
        public string LegalEntityCode { get; set; }

        /// <summary>
        /// The unique identifier of the account of the migrated shareholder in the classic integration.
        /// </summary>
        /// <value>The unique identifier of the account of the migrated shareholder in the classic integration.</value>
        [DataMember(Name = "shareholderCode", EmitDefaultValue = false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MigratedShareholders {\n");
            sb.Append("  LegalEntityCode: ").Append(LegalEntityCode).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigratedShareholders);
        }

        /// <summary>
        /// Returns true if MigratedShareholders instances are equal
        /// </summary>
        /// <param name="input">Instance of MigratedShareholders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigratedShareholders input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LegalEntityCode == input.LegalEntityCode ||
                    (this.LegalEntityCode != null &&
                    this.LegalEntityCode.Equals(input.LegalEntityCode))
                ) && 
                (
                    this.ShareholderCode == input.ShareholderCode ||
                    (this.ShareholderCode != null &&
                    this.ShareholderCode.Equals(input.ShareholderCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LegalEntityCode != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityCode.GetHashCode();
                }
                if (this.ShareholderCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShareholderCode.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}