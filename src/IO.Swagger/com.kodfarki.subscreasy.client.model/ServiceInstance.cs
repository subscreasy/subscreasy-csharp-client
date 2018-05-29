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
    /// ServiceInstance
    /// </summary>
    [DataContract]
    public partial class ServiceInstance :  IEquatable<ServiceInstance>, IValidatableObject
    {
        /// <summary>
        /// Defines QuotaOrigin
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuotaOriginEnum
        {
            
            /// <summary>
            /// Enum SUBS for value: SUBS
            /// </summary>
            [EnumMember(Value = "SUBS")]
            SUBS = 1,
            
            /// <summary>
            /// Enum OVER for value: OVER
            /// </summary>
            [EnumMember(Value = "OVER")]
            OVER = 2
        }

        /// <summary>
        /// Gets or Sets QuotaOrigin
        /// </summary>
        [DataMember(Name="quotaOrigin", EmitDefaultValue=false)]
        public QuotaOriginEnum? QuotaOrigin { get; set; }
        /// <summary>
        /// Defines ServiceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceTypeEnum
        {
            
            /// <summary>
            /// Enum ONOFF for value: ONOFF
            /// </summary>
            [EnumMember(Value = "ONOFF")]
            ONOFF = 1,
            
            /// <summary>
            /// Enum SEATBASED for value: SEAT_BASED
            /// </summary>
            [EnumMember(Value = "SEAT_BASED")]
            SEATBASED = 2,
            
            /// <summary>
            /// Enum USAGEBASED for value: USAGE_BASED
            /// </summary>
            [EnumMember(Value = "USAGE_BASED")]
            USAGEBASED = 3
        }

        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name="serviceType", EmitDefaultValue=false)]
        public ServiceTypeEnum? ServiceType { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW = 1,
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 2,
            
            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            [EnumMember(Value = "SUSPENDED")]
            SUSPENDED = 3,
            
            /// <summary>
            /// Enum FINISHED for value: FINISHED
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED = 4,
            
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 5
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum ONOFF for value: ONOFF
            /// </summary>
            [EnumMember(Value = "ONOFF")]
            ONOFF = 1,
            
            /// <summary>
            /// Enum SEATBASED for value: SEAT_BASED
            /// </summary>
            [EnumMember(Value = "SEAT_BASED")]
            SEATBASED = 2,
            
            /// <summary>
            /// Enum USAGEBASED for value: USAGE_BASED
            /// </summary>
            [EnumMember(Value = "USAGE_BASED")]
            USAGEBASED = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstance" /> class.
        /// </summary>
        /// <param name="Capacity">Capacity.</param>
        /// <param name="CurrentUsage">CurrentUsage.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="NumberOfUnits">NumberOfUnits.</param>
        /// <param name="Offer">Offer.</param>
        /// <param name="OverUsage">OverUsage.</param>
        /// <param name="OverUsageQuota">OverUsageQuota.</param>
        /// <param name="QuotaOrigin">QuotaOrigin.</param>
        /// <param name="ServiceOffering">ServiceOffering.</param>
        /// <param name="ServiceType">ServiceType.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SubscriberId">SubscriberId.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Version">Version.</param>
        public ServiceInstance(decimal? Capacity = default(decimal?), decimal? CurrentUsage = default(decimal?), DateTime? EndDate = default(DateTime?), long? Id = default(long?), string Name = default(string), int? NumberOfUnits = default(int?), Offer Offer = default(Offer), decimal? OverUsage = default(decimal?), decimal? OverUsageQuota = default(decimal?), QuotaOriginEnum? QuotaOrigin = default(QuotaOriginEnum?), ServiceOffering ServiceOffering = default(ServiceOffering), ServiceTypeEnum? ServiceType = default(ServiceTypeEnum?), DateTime? StartDate = default(DateTime?), StatusEnum? Status = default(StatusEnum?), string SubscriberId = default(string), Subsription Subscription = default(Subsription), TypeEnum? Type = default(TypeEnum?), long? Version = default(long?))
        {
            this.Capacity = Capacity;
            this.CurrentUsage = CurrentUsage;
            this.EndDate = EndDate;
            this.Id = Id;
            this.Name = Name;
            this.NumberOfUnits = NumberOfUnits;
            this.Offer = Offer;
            this.OverUsage = OverUsage;
            this.OverUsageQuota = OverUsageQuota;
            this.QuotaOrigin = QuotaOrigin;
            this.ServiceOffering = ServiceOffering;
            this.ServiceType = ServiceType;
            this.StartDate = StartDate;
            this.Status = Status;
            this.SubscriberId = SubscriberId;
            this.Subscription = Subscription;
            this.Type = Type;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public decimal? Capacity { get; set; }

        /// <summary>
        /// Gets or Sets CurrentUsage
        /// </summary>
        [DataMember(Name="currentUsage", EmitDefaultValue=false)]
        public decimal? CurrentUsage { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfUnits
        /// </summary>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public int? NumberOfUnits { get; set; }

        /// <summary>
        /// Gets or Sets Offer
        /// </summary>
        [DataMember(Name="offer", EmitDefaultValue=false)]
        public Offer Offer { get; set; }

        /// <summary>
        /// Gets or Sets OverUsage
        /// </summary>
        [DataMember(Name="overUsage", EmitDefaultValue=false)]
        public decimal? OverUsage { get; set; }

        /// <summary>
        /// Gets or Sets OverUsageQuota
        /// </summary>
        [DataMember(Name="overUsageQuota", EmitDefaultValue=false)]
        public decimal? OverUsageQuota { get; set; }


        /// <summary>
        /// Gets or Sets ServiceOffering
        /// </summary>
        [DataMember(Name="serviceOffering", EmitDefaultValue=false)]
        public ServiceOffering ServiceOffering { get; set; }


        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }


        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="subscriberId", EmitDefaultValue=false)]
        public string SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subsription Subscription { get; set; }


        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInstance {\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  CurrentUsage: ").Append(CurrentUsage).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  OverUsage: ").Append(OverUsage).Append("\n");
            sb.Append("  OverUsageQuota: ").Append(OverUsageQuota).Append("\n");
            sb.Append("  QuotaOrigin: ").Append(QuotaOrigin).Append("\n");
            sb.Append("  ServiceOffering: ").Append(ServiceOffering).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ServiceInstance);
        }

        /// <summary>
        /// Returns true if ServiceInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.CurrentUsage == input.CurrentUsage ||
                    (this.CurrentUsage != null &&
                    this.CurrentUsage.Equals(input.CurrentUsage))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    (this.NumberOfUnits != null &&
                    this.NumberOfUnits.Equals(input.NumberOfUnits))
                ) && 
                (
                    this.Offer == input.Offer ||
                    (this.Offer != null &&
                    this.Offer.Equals(input.Offer))
                ) && 
                (
                    this.OverUsage == input.OverUsage ||
                    (this.OverUsage != null &&
                    this.OverUsage.Equals(input.OverUsage))
                ) && 
                (
                    this.OverUsageQuota == input.OverUsageQuota ||
                    (this.OverUsageQuota != null &&
                    this.OverUsageQuota.Equals(input.OverUsageQuota))
                ) && 
                (
                    this.QuotaOrigin == input.QuotaOrigin ||
                    (this.QuotaOrigin != null &&
                    this.QuotaOrigin.Equals(input.QuotaOrigin))
                ) && 
                (
                    this.ServiceOffering == input.ServiceOffering ||
                    (this.ServiceOffering != null &&
                    this.ServiceOffering.Equals(input.ServiceOffering))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubscriberId == input.SubscriberId ||
                    (this.SubscriberId != null &&
                    this.SubscriberId.Equals(input.SubscriberId))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.CurrentUsage != null)
                    hashCode = hashCode * 59 + this.CurrentUsage.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                if (this.Offer != null)
                    hashCode = hashCode * 59 + this.Offer.GetHashCode();
                if (this.OverUsage != null)
                    hashCode = hashCode * 59 + this.OverUsage.GetHashCode();
                if (this.OverUsageQuota != null)
                    hashCode = hashCode * 59 + this.OverUsageQuota.GetHashCode();
                if (this.QuotaOrigin != null)
                    hashCode = hashCode * 59 + this.QuotaOrigin.GetHashCode();
                if (this.ServiceOffering != null)
                    hashCode = hashCode * 59 + this.ServiceOffering.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubscriberId != null)
                    hashCode = hashCode * 59 + this.SubscriberId.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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