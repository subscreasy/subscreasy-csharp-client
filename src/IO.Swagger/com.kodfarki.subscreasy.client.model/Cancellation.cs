/* 
 * Api Documentation
 *
 * Api Documentation
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.com.kodfarki.subscreasy.client.model
{
    /// <summary>
    /// Cancellation
    /// </summary>
    [DataContract]
    public partial class Cancellation :  IEquatable<Cancellation>, IValidatableObject
    {
        /// <summary>
        /// Defines CancellationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CancellationTypeEnum
        {
            
            /// <summary>
            /// Enum IMMEDIATE for value: IMMEDIATE
            /// </summary>
            [EnumMember(Value = "IMMEDIATE")]
            IMMEDIATE = 1,
            
            /// <summary>
            /// Enum ENDOFTHEPERIOD for value: ENDOFTHEPERIOD
            /// </summary>
            [EnumMember(Value = "ENDOFTHEPERIOD")]
            ENDOFTHEPERIOD = 2
        }

        /// <summary>
        /// Gets or Sets CancellationType
        /// </summary>
        [DataMember(Name="cancellationType", EmitDefaultValue=false)]
        public CancellationTypeEnum? CancellationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cancellation" /> class.
        /// </summary>
        /// <param name="CancellationType">CancellationType.</param>
        /// <param name="SubscriberId">SubscriberId.</param>
        /// <param name="SubscriptionId">SubscriptionId.</param>
        public Cancellation(CancellationTypeEnum? CancellationType = default(CancellationTypeEnum?), long? SubscriberId = default(long?), long? SubscriptionId = default(long?))
        {
            this.CancellationType = CancellationType;
            this.SubscriberId = SubscriberId;
            this.SubscriptionId = SubscriptionId;
        }
        

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="subscriberId", EmitDefaultValue=false)]
        public long? SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
        public long? SubscriptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cancellation {\n");
            sb.Append("  CancellationType: ").Append(CancellationType).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Cancellation);
        }

        /// <summary>
        /// Returns true if Cancellation instances are equal
        /// </summary>
        /// <param name="input">Instance of Cancellation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cancellation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CancellationType == input.CancellationType ||
                    (this.CancellationType != null &&
                    this.CancellationType.Equals(input.CancellationType))
                ) && 
                (
                    this.SubscriberId == input.SubscriberId ||
                    (this.SubscriberId != null &&
                    this.SubscriberId.Equals(input.SubscriberId))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
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
                if (this.CancellationType != null)
                    hashCode = hashCode * 59 + this.CancellationType.GetHashCode();
                if (this.SubscriberId != null)
                    hashCode = hashCode * 59 + this.SubscriberId.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
