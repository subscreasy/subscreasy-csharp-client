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
    /// WebHook
    /// </summary>
    [DataContract]
    public partial class WebHook :  IEquatable<WebHook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHook" /> class.
        /// </summary>
        /// <param name="AuthenticationKey">AuthenticationKey.</param>
        /// <param name="Company">Company.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PaymentUpdated">PaymentUpdated.</param>
        /// <param name="ServerUrl">ServerUrl.</param>
        /// <param name="SubscriberCreated">SubscriberCreated.</param>
        /// <param name="SubscriberUpdated">SubscriberUpdated.</param>
        /// <param name="SubscriptionCreated">SubscriptionCreated.</param>
        /// <param name="SubscriptionEnded">SubscriptionEnded.</param>
        /// <param name="SubscriptionReactivated">SubscriptionReactivated.</param>
        /// <param name="SubscriptionRenewalFailed">SubscriptionRenewalFailed.</param>
        /// <param name="SubscriptionRenewed">SubscriptionRenewed.</param>
        public WebHook(string AuthenticationKey = default(string), Company Company = default(Company), long? Id = default(long?), bool? PaymentUpdated = default(bool?), string ServerUrl = default(string), bool? SubscriberCreated = default(bool?), bool? SubscriberUpdated = default(bool?), bool? SubscriptionCreated = default(bool?), bool? SubscriptionEnded = default(bool?), bool? SubscriptionReactivated = default(bool?), bool? SubscriptionRenewalFailed = default(bool?), bool? SubscriptionRenewed = default(bool?))
        {
            this.AuthenticationKey = AuthenticationKey;
            this.Company = Company;
            this.Id = Id;
            this.PaymentUpdated = PaymentUpdated;
            this.ServerUrl = ServerUrl;
            this.SubscriberCreated = SubscriberCreated;
            this.SubscriberUpdated = SubscriberUpdated;
            this.SubscriptionCreated = SubscriptionCreated;
            this.SubscriptionEnded = SubscriptionEnded;
            this.SubscriptionReactivated = SubscriptionReactivated;
            this.SubscriptionRenewalFailed = SubscriptionRenewalFailed;
            this.SubscriptionRenewed = SubscriptionRenewed;
        }
        
        /// <summary>
        /// Gets or Sets AuthenticationKey
        /// </summary>
        [DataMember(Name="authenticationKey", EmitDefaultValue=false)]
        public string AuthenticationKey { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PaymentUpdated
        /// </summary>
        [DataMember(Name="paymentUpdated", EmitDefaultValue=false)]
        public bool? PaymentUpdated { get; set; }

        /// <summary>
        /// Gets or Sets ServerUrl
        /// </summary>
        [DataMember(Name="serverUrl", EmitDefaultValue=false)]
        public string ServerUrl { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberCreated
        /// </summary>
        [DataMember(Name="subscriberCreated", EmitDefaultValue=false)]
        public bool? SubscriberCreated { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberUpdated
        /// </summary>
        [DataMember(Name="subscriberUpdated", EmitDefaultValue=false)]
        public bool? SubscriberUpdated { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionCreated
        /// </summary>
        [DataMember(Name="subscriptionCreated", EmitDefaultValue=false)]
        public bool? SubscriptionCreated { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionEnded
        /// </summary>
        [DataMember(Name="subscriptionEnded", EmitDefaultValue=false)]
        public bool? SubscriptionEnded { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionReactivated
        /// </summary>
        [DataMember(Name="subscriptionReactivated", EmitDefaultValue=false)]
        public bool? SubscriptionReactivated { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionRenewalFailed
        /// </summary>
        [DataMember(Name="subscriptionRenewalFailed", EmitDefaultValue=false)]
        public bool? SubscriptionRenewalFailed { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionRenewed
        /// </summary>
        [DataMember(Name="subscriptionRenewed", EmitDefaultValue=false)]
        public bool? SubscriptionRenewed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHook {\n");
            sb.Append("  AuthenticationKey: ").Append(AuthenticationKey).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PaymentUpdated: ").Append(PaymentUpdated).Append("\n");
            sb.Append("  ServerUrl: ").Append(ServerUrl).Append("\n");
            sb.Append("  SubscriberCreated: ").Append(SubscriberCreated).Append("\n");
            sb.Append("  SubscriberUpdated: ").Append(SubscriberUpdated).Append("\n");
            sb.Append("  SubscriptionCreated: ").Append(SubscriptionCreated).Append("\n");
            sb.Append("  SubscriptionEnded: ").Append(SubscriptionEnded).Append("\n");
            sb.Append("  SubscriptionReactivated: ").Append(SubscriptionReactivated).Append("\n");
            sb.Append("  SubscriptionRenewalFailed: ").Append(SubscriptionRenewalFailed).Append("\n");
            sb.Append("  SubscriptionRenewed: ").Append(SubscriptionRenewed).Append("\n");
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
            return this.Equals(input as WebHook);
        }

        /// <summary>
        /// Returns true if WebHook instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationKey == input.AuthenticationKey ||
                    (this.AuthenticationKey != null &&
                    this.AuthenticationKey.Equals(input.AuthenticationKey))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PaymentUpdated == input.PaymentUpdated ||
                    (this.PaymentUpdated != null &&
                    this.PaymentUpdated.Equals(input.PaymentUpdated))
                ) && 
                (
                    this.ServerUrl == input.ServerUrl ||
                    (this.ServerUrl != null &&
                    this.ServerUrl.Equals(input.ServerUrl))
                ) && 
                (
                    this.SubscriberCreated == input.SubscriberCreated ||
                    (this.SubscriberCreated != null &&
                    this.SubscriberCreated.Equals(input.SubscriberCreated))
                ) && 
                (
                    this.SubscriberUpdated == input.SubscriberUpdated ||
                    (this.SubscriberUpdated != null &&
                    this.SubscriberUpdated.Equals(input.SubscriberUpdated))
                ) && 
                (
                    this.SubscriptionCreated == input.SubscriptionCreated ||
                    (this.SubscriptionCreated != null &&
                    this.SubscriptionCreated.Equals(input.SubscriptionCreated))
                ) && 
                (
                    this.SubscriptionEnded == input.SubscriptionEnded ||
                    (this.SubscriptionEnded != null &&
                    this.SubscriptionEnded.Equals(input.SubscriptionEnded))
                ) && 
                (
                    this.SubscriptionReactivated == input.SubscriptionReactivated ||
                    (this.SubscriptionReactivated != null &&
                    this.SubscriptionReactivated.Equals(input.SubscriptionReactivated))
                ) && 
                (
                    this.SubscriptionRenewalFailed == input.SubscriptionRenewalFailed ||
                    (this.SubscriptionRenewalFailed != null &&
                    this.SubscriptionRenewalFailed.Equals(input.SubscriptionRenewalFailed))
                ) && 
                (
                    this.SubscriptionRenewed == input.SubscriptionRenewed ||
                    (this.SubscriptionRenewed != null &&
                    this.SubscriptionRenewed.Equals(input.SubscriptionRenewed))
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
                if (this.AuthenticationKey != null)
                    hashCode = hashCode * 59 + this.AuthenticationKey.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PaymentUpdated != null)
                    hashCode = hashCode * 59 + this.PaymentUpdated.GetHashCode();
                if (this.ServerUrl != null)
                    hashCode = hashCode * 59 + this.ServerUrl.GetHashCode();
                if (this.SubscriberCreated != null)
                    hashCode = hashCode * 59 + this.SubscriberCreated.GetHashCode();
                if (this.SubscriberUpdated != null)
                    hashCode = hashCode * 59 + this.SubscriberUpdated.GetHashCode();
                if (this.SubscriptionCreated != null)
                    hashCode = hashCode * 59 + this.SubscriptionCreated.GetHashCode();
                if (this.SubscriptionEnded != null)
                    hashCode = hashCode * 59 + this.SubscriptionEnded.GetHashCode();
                if (this.SubscriptionReactivated != null)
                    hashCode = hashCode * 59 + this.SubscriptionReactivated.GetHashCode();
                if (this.SubscriptionRenewalFailed != null)
                    hashCode = hashCode * 59 + this.SubscriptionRenewalFailed.GetHashCode();
                if (this.SubscriptionRenewed != null)
                    hashCode = hashCode * 59 + this.SubscriptionRenewed.GetHashCode();
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
