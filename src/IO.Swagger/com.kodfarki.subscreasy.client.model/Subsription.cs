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
    /// Subsription
    /// </summary>
    [DataContract]
    public partial class Subsription :  IEquatable<Subsription>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="Subsription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subsription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subsription" /> class.
        /// </summary>
        /// <param name="AppliedCoupon">AppliedCoupon.</param>
        /// <param name="CancelDate">CancelDate.</param>
        /// <param name="Card">Card.</param>
        /// <param name="Company">Company (required).</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="NextChargingDate">NextChargingDate.</param>
        /// <param name="Offer">Offer (required).</param>
        /// <param name="Services">Services.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SubscriberId">SubscriberId.</param>
        /// <param name="Version">Version.</param>
        public Subsription(Coupon AppliedCoupon = default(Coupon), DateTime? CancelDate = default(DateTime?), SavedCard Card = default(SavedCard), Company Company = default(Company), DateTime? EndDate = default(DateTime?), long? Id = default(long?), DateTime? NextChargingDate = default(DateTime?), Offer Offer = default(Offer), List<ServiceInstance> Services = default(List<ServiceInstance>), DateTime? StartDate = default(DateTime?), StatusEnum? Status = default(StatusEnum?), string SubscriberId = default(string), long? Version = default(long?))
        {
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for Subsription and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            // to ensure "Offer" is required (not null)
            if (Offer == null)
            {
                throw new InvalidDataException("Offer is a required property for Subsription and cannot be null");
            }
            else
            {
                this.Offer = Offer;
            }
            this.AppliedCoupon = AppliedCoupon;
            this.CancelDate = CancelDate;
            this.Card = Card;
            this.EndDate = EndDate;
            this.Id = Id;
            this.NextChargingDate = NextChargingDate;
            this.Services = Services;
            this.StartDate = StartDate;
            this.Status = Status;
            this.SubscriberId = SubscriberId;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets AppliedCoupon
        /// </summary>
        [DataMember(Name="appliedCoupon", EmitDefaultValue=false)]
        public Coupon AppliedCoupon { get; set; }

        /// <summary>
        /// Gets or Sets CancelDate
        /// </summary>
        [DataMember(Name="cancelDate", EmitDefaultValue=false)]
        public DateTime? CancelDate { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public SavedCard Card { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Company Company { get; set; }

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
        /// Gets or Sets NextChargingDate
        /// </summary>
        [DataMember(Name="nextChargingDate", EmitDefaultValue=false)]
        public DateTime? NextChargingDate { get; set; }

        /// <summary>
        /// Gets or Sets Offer
        /// </summary>
        [DataMember(Name="offer", EmitDefaultValue=false)]
        public Offer Offer { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<ServiceInstance> Services { get; set; }

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
            sb.Append("class Subsription {\n");
            sb.Append("  AppliedCoupon: ").Append(AppliedCoupon).Append("\n");
            sb.Append("  CancelDate: ").Append(CancelDate).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NextChargingDate: ").Append(NextChargingDate).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
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
            return this.Equals(input as Subsription);
        }

        /// <summary>
        /// Returns true if Subsription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subsription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subsription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppliedCoupon == input.AppliedCoupon ||
                    (this.AppliedCoupon != null &&
                    this.AppliedCoupon.Equals(input.AppliedCoupon))
                ) && 
                (
                    this.CancelDate == input.CancelDate ||
                    (this.CancelDate != null &&
                    this.CancelDate.Equals(input.CancelDate))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
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
                    this.NextChargingDate == input.NextChargingDate ||
                    (this.NextChargingDate != null &&
                    this.NextChargingDate.Equals(input.NextChargingDate))
                ) && 
                (
                    this.Offer == input.Offer ||
                    (this.Offer != null &&
                    this.Offer.Equals(input.Offer))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
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
                if (this.AppliedCoupon != null)
                    hashCode = hashCode * 59 + this.AppliedCoupon.GetHashCode();
                if (this.CancelDate != null)
                    hashCode = hashCode * 59 + this.CancelDate.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NextChargingDate != null)
                    hashCode = hashCode * 59 + this.NextChargingDate.GetHashCode();
                if (this.Offer != null)
                    hashCode = hashCode * 59 + this.Offer.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubscriberId != null)
                    hashCode = hashCode * 59 + this.SubscriberId.GetHashCode();
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
