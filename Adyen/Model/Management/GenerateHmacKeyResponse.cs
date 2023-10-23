/*
* Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// GenerateHmacKeyResponse
    /// </summary>
    [DataContract(Name = "GenerateHmacKeyResponse")]
    public partial class GenerateHmacKeyResponse : IEquatable<GenerateHmacKeyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHmacKeyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateHmacKeyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateHmacKeyResponse" /> class.
        /// </summary>
        /// <param name="hmacKey">The HMAC key generated for this webhook. (required).</param>
        public GenerateHmacKeyResponse(string hmacKey = default(string))
        {
            this.HmacKey = hmacKey;
        }

        /// <summary>
        /// The HMAC key generated for this webhook.
        /// </summary>
        /// <value>The HMAC key generated for this webhook.</value>
        [DataMember(Name = "hmacKey", IsRequired = false, EmitDefaultValue = false)]
        public string HmacKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateHmacKeyResponse {\n");
            sb.Append("  HmacKey: ").Append(HmacKey).Append("\n");
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
            return this.Equals(input as GenerateHmacKeyResponse);
        }

        /// <summary>
        /// Returns true if GenerateHmacKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateHmacKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateHmacKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HmacKey == input.HmacKey ||
                    (this.HmacKey != null &&
                    this.HmacKey.Equals(input.HmacKey))
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
                if (this.HmacKey != null)
                {
                    hashCode = (hashCode * 59) + this.HmacKey.GetHashCode();
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
