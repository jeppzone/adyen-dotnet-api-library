/*
* Management API
*
*
* The version of the OpenAPI document: 1
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
    /// StoreSplitConfiguration
    /// </summary>
    [DataContract(Name = "StoreSplitConfiguration")]
    public partial class StoreSplitConfiguration : IEquatable<StoreSplitConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSplitConfiguration" /> class.
        /// </summary>
        /// <param name="balanceAccountId">The [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id) linked to the account holder..</param>
        /// <param name="splitConfigurationId">The UUID of the [split configuration](https://docs.adyen.com/marketplaces-and-platforms/classic/split-configuration-for-stores) from the Customer Area..</param>
        public StoreSplitConfiguration(string balanceAccountId = default(string), string splitConfigurationId = default(string))
        {
            this.BalanceAccountId = balanceAccountId;
            this.SplitConfigurationId = splitConfigurationId;
        }

        /// <summary>
        /// The [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id) linked to the account holder.
        /// </summary>
        /// <value>The [balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id) linked to the account holder.</value>
        [DataMember(Name = "balanceAccountId", EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// The UUID of the [split configuration](https://docs.adyen.com/marketplaces-and-platforms/classic/split-configuration-for-stores) from the Customer Area.
        /// </summary>
        /// <value>The UUID of the [split configuration](https://docs.adyen.com/marketplaces-and-platforms/classic/split-configuration-for-stores) from the Customer Area.</value>
        [DataMember(Name = "splitConfigurationId", EmitDefaultValue = false)]
        public string SplitConfigurationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoreSplitConfiguration {\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  SplitConfigurationId: ").Append(SplitConfigurationId).Append("\n");
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
            return this.Equals(input as StoreSplitConfiguration);
        }

        /// <summary>
        /// Returns true if StoreSplitConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreSplitConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreSplitConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BalanceAccountId == input.BalanceAccountId ||
                    (this.BalanceAccountId != null &&
                    this.BalanceAccountId.Equals(input.BalanceAccountId))
                ) && 
                (
                    this.SplitConfigurationId == input.SplitConfigurationId ||
                    (this.SplitConfigurationId != null &&
                    this.SplitConfigurationId.Equals(input.SplitConfigurationId))
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
                if (this.BalanceAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAccountId.GetHashCode();
                }
                if (this.SplitConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.SplitConfigurationId.GetHashCode();
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