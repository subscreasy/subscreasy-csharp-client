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
    /// MessageTemplate
    /// </summary>
    [DataContract]
    public partial class MessageTemplate :  IEquatable<MessageTemplate>, IValidatableObject
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum STARTED for value: STARTED
            /// </summary>
            [EnumMember(Value = "STARTED")]
            STARTED = 1,
            
            /// <summary>
            /// Enum RENEWED for value: RENEWED
            /// </summary>
            [EnumMember(Value = "RENEWED")]
            RENEWED = 2,
            
            /// <summary>
            /// Enum RENEWALFAILED for value: RENEWAL_FAILED
            /// </summary>
            [EnumMember(Value = "RENEWAL_FAILED")]
            RENEWALFAILED = 3,
            
            /// <summary>
            /// Enum FINISHED for value: FINISHED
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED = 4,
            
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 5,
            
            /// <summary>
            /// Enum SUBSCRIBERCREATED for value: SUBSCRIBER_CREATED
            /// </summary>
            [EnumMember(Value = "SUBSCRIBER_CREATED")]
            SUBSCRIBERCREATED = 6,
            
            /// <summary>
            /// Enum SUBSCRIBERUPDATED for value: SUBSCRIBER_UPDATED
            /// </summary>
            [EnumMember(Value = "SUBSCRIBER_UPDATED")]
            SUBSCRIBERUPDATED = 7
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Defines NotificationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NotificationTypeEnum
        {
            
            /// <summary>
            /// Enum WEBHOOK for value: WEBHOOK
            /// </summary>
            [EnumMember(Value = "WEBHOOK")]
            WEBHOOK = 1,
            
            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL = 2
        }

        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [DataMember(Name="notificationType", EmitDefaultValue=false)]
        public NotificationTypeEnum? NotificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageTemplate" /> class.
        /// </summary>
        /// <param name="Company">Company (required).</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="Id">Id.</param>
        /// <param name="_MessageTemplate">_MessageTemplate.</param>
        /// <param name="NotificationType">NotificationType.</param>
        /// <param name="Sender">Sender.</param>
        /// <param name="Subject">Subject.</param>
        public MessageTemplate(Company Company = default(Company), bool? Enabled = default(bool?), EventTypeEnum? EventType = default(EventTypeEnum?), long? Id = default(long?), string _MessageTemplate = default(string), NotificationTypeEnum? NotificationType = default(NotificationTypeEnum?), string Sender = default(string), string Subject = default(string))
        {
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for MessageTemplate and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            this.Enabled = Enabled;
            this.EventType = EventType;
            this.Id = Id;
            this._MessageTemplate = _MessageTemplate;
            this.NotificationType = NotificationType;
            this.Sender = Sender;
            this.Subject = Subject;
        }
        
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets _MessageTemplate
        /// </summary>
        [DataMember(Name="messageTemplate", EmitDefaultValue=false)]
        public string _MessageTemplate { get; set; }


        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageTemplate {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _MessageTemplate: ").Append(_MessageTemplate).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as MessageTemplate);
        }

        /// <summary>
        /// Returns true if MessageTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this._MessageTemplate == input._MessageTemplate ||
                    (this._MessageTemplate != null &&
                    this._MessageTemplate.Equals(input._MessageTemplate))
                ) && 
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this._MessageTemplate != null)
                    hashCode = hashCode * 59 + this._MessageTemplate.GetHashCode();
                if (this.NotificationType != null)
                    hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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
