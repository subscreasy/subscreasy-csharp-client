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
    /// WebHookRequest
    /// </summary>
    [DataContract]
    public partial class WebHookRequest :  IEquatable<WebHookRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookRequest" /> class.
        /// </summary>
        /// <param name="PaymentLog">PaymentLog.</param>
        /// <param name="SavedCard">SavedCard.</param>
        /// <param name="Subscriber">Subscriber.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="TxId">TxId.</param>
        public WebHookRequest(ChargingLog PaymentLog = default(ChargingLog), SavedCard SavedCard = default(SavedCard), Subscriber Subscriber = default(Subscriber), Subsription Subscription = default(Subsription), string TxId = default(string))
        {
            this.PaymentLog = PaymentLog;
            this.SavedCard = SavedCard;
            this.Subscriber = Subscriber;
            this.Subscription = Subscription;
            this.TxId = TxId;
        }
        
        /// <summary>
        /// Gets or Sets PaymentLog
        /// </summary>
        [DataMember(Name="paymentLog", EmitDefaultValue=false)]
        public ChargingLog PaymentLog { get; set; }

        /// <summary>
        /// Gets or Sets SavedCard
        /// </summary>
        [DataMember(Name="savedCard", EmitDefaultValue=false)]
        public SavedCard SavedCard { get; set; }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name="subscriber", EmitDefaultValue=false)]
        public Subscriber Subscriber { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subsription Subscription { get; set; }

        /// <summary>
        /// Gets or Sets TxId
        /// </summary>
        [DataMember(Name="txId", EmitDefaultValue=false)]
        public string TxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookRequest {\n");
            sb.Append("  PaymentLog: ").Append(PaymentLog).Append("\n");
            sb.Append("  SavedCard: ").Append(SavedCard).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
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
            return this.Equals(input as WebHookRequest);
        }

        /// <summary>
        /// Returns true if WebHookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentLog == input.PaymentLog ||
                    (this.PaymentLog != null &&
                    this.PaymentLog.Equals(input.PaymentLog))
                ) && 
                (
                    this.SavedCard == input.SavedCard ||
                    (this.SavedCard != null &&
                    this.SavedCard.Equals(input.SavedCard))
                ) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.TxId == input.TxId ||
                    (this.TxId != null &&
                    this.TxId.Equals(input.TxId))
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
                if (this.PaymentLog != null)
                    hashCode = hashCode * 59 + this.PaymentLog.GetHashCode();
                if (this.SavedCard != null)
                    hashCode = hashCode * 59 + this.SavedCard.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
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
