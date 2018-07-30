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
    /// StartSubscriptionResult
    /// </summary>
    [DataContract]
    public partial class StartSubscriptionResult :  IEquatable<StartSubscriptionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartSubscriptionResult" /> class.
        /// </summary>
        /// <param name="Payment">Payment.</param>
        /// <param name="Subscription">Subscription.</param>
        public StartSubscriptionResult(ChargingLog Payment = default(ChargingLog), Subsription Subscription = default(Subsription))
        {
            this.Payment = Payment;
            this.Subscription = Subscription;
        }
        
        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public ChargingLog Payment { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subsription Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartSubscriptionResult {\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
            return this.Equals(input as StartSubscriptionResult);
        }

        /// <summary>
        /// Returns true if StartSubscriptionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of StartSubscriptionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartSubscriptionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
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