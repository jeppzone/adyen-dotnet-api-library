/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// NetworkToken
    /// </summary>
    [DataContract(Name = "NetworkToken")]
    public partial class NetworkToken : IEquatable<NetworkToken>, IValidatableObject
    {
        /// <summary>
        /// The status of the network token. Possible values: **active**, **inactive**, **suspended**, **closed**.
        /// </summary>
        /// <value>The status of the network token. Possible values: **active**, **inactive**, **suspended**, **closed**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2,

            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 3,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 4

        }


        /// <summary>
        /// The status of the network token. Possible values: **active**, **inactive**, **suspended**, **closed**.
        /// </summary>
        /// <value>The status of the network token. Possible values: **active**, **inactive**, **suspended**, **closed**.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkToken" /> class.
        /// </summary>
        /// <param name="brandVariant">The card brand variant of the payment instrument associated with the network token. For example, **mc_prepaid_mrw**..</param>
        /// <param name="creationDate">Date and time when the network token was created, in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) extended format. For example, **2020-12-18T10:15:30+01:00**...</param>
        /// <param name="device">device.</param>
        /// <param name="id">The unique identifier of the network token..</param>
        /// <param name="paymentInstrumentId">The unique identifier of the payment instrument to which this network token belongs to..</param>
        /// <param name="status">The status of the network token. Possible values: **active**, **inactive**, **suspended**, **closed**..</param>
        /// <param name="tokenLastFour">The last four digits of the network token &#x60;id&#x60;..</param>
        /// <param name="type">The type of wallet the network token is associated with. For example, **applePay**..</param>
        public NetworkToken(string brandVariant = default(string), DateTime creationDate = default(DateTime), DeviceInfo device = default(DeviceInfo), string id = default(string), string paymentInstrumentId = default(string), StatusEnum? status = default(StatusEnum?), string tokenLastFour = default(string), string type = default(string))
        {
            this.BrandVariant = brandVariant;
            this.CreationDate = creationDate;
            this.Device = device;
            this.Id = id;
            this.PaymentInstrumentId = paymentInstrumentId;
            this.Status = status;
            this.TokenLastFour = tokenLastFour;
            this.Type = type;
        }

        /// <summary>
        /// The card brand variant of the payment instrument associated with the network token. For example, **mc_prepaid_mrw**.
        /// </summary>
        /// <value>The card brand variant of the payment instrument associated with the network token. For example, **mc_prepaid_mrw**.</value>
        [DataMember(Name = "brandVariant", EmitDefaultValue = false)]
        public string BrandVariant { get; set; }

        /// <summary>
        /// Date and time when the network token was created, in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) extended format. For example, **2020-12-18T10:15:30+01:00**..
        /// </summary>
        /// <value>Date and time when the network token was created, in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) extended format. For example, **2020-12-18T10:15:30+01:00**..</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public DeviceInfo Device { get; set; }

        /// <summary>
        /// The unique identifier of the network token.
        /// </summary>
        /// <value>The unique identifier of the network token.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The unique identifier of the payment instrument to which this network token belongs to.
        /// </summary>
        /// <value>The unique identifier of the payment instrument to which this network token belongs to.</value>
        [DataMember(Name = "paymentInstrumentId", EmitDefaultValue = false)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// The last four digits of the network token &#x60;id&#x60;.
        /// </summary>
        /// <value>The last four digits of the network token &#x60;id&#x60;.</value>
        [DataMember(Name = "tokenLastFour", EmitDefaultValue = false)]
        public string TokenLastFour { get; set; }

        /// <summary>
        /// The type of wallet the network token is associated with. For example, **applePay**.
        /// </summary>
        /// <value>The type of wallet the network token is associated with. For example, **applePay**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkToken {\n");
            sb.Append("  BrandVariant: ").Append(BrandVariant).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PaymentInstrumentId: ").Append(PaymentInstrumentId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TokenLastFour: ").Append(TokenLastFour).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as NetworkToken);
        }

        /// <summary>
        /// Returns true if NetworkToken instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkToken input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandVariant == input.BrandVariant ||
                    (this.BrandVariant != null &&
                    this.BrandVariant.Equals(input.BrandVariant))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PaymentInstrumentId == input.PaymentInstrumentId ||
                    (this.PaymentInstrumentId != null &&
                    this.PaymentInstrumentId.Equals(input.PaymentInstrumentId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TokenLastFour == input.TokenLastFour ||
                    (this.TokenLastFour != null &&
                    this.TokenLastFour.Equals(input.TokenLastFour))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BrandVariant != null)
                {
                    hashCode = (hashCode * 59) + this.BrandVariant.GetHashCode();
                }
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.PaymentInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstrumentId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TokenLastFour != null)
                {
                    hashCode = (hashCode * 59) + this.TokenLastFour.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
