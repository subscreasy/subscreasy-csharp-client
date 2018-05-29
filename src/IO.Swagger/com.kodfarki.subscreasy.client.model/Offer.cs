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
    /// Offer
    /// </summary>
    [DataContract]
    public partial class Offer :  IEquatable<Offer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Offer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Offer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Offer" /> class.
        /// </summary>
        /// <param name="Company">Company (required).</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="OpenEnded">OpenEnded (required).</param>
        /// <param name="Price">Price (required).</param>
        /// <param name="Recurrence">Recurrence (required).</param>
        /// <param name="RecurrenceCount">RecurrenceCount.</param>
        /// <param name="SecureId">SecureId.</param>
        /// <param name="TrialPeriod">TrialPeriod.</param>
        public Offer(Company Company = default(Company), long? Id = default(long?), string Name = default(string), bool? OpenEnded = default(bool?), decimal? Price = default(decimal?), RecurrencePeriod Recurrence = default(RecurrencePeriod), int? RecurrenceCount = default(int?), string SecureId = default(string), int? TrialPeriod = default(int?))
        {
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for Offer and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Offer and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "OpenEnded" is required (not null)
            if (OpenEnded == null)
            {
                throw new InvalidDataException("OpenEnded is a required property for Offer and cannot be null");
            }
            else
            {
                this.OpenEnded = OpenEnded;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for Offer and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "Recurrence" is required (not null)
            if (Recurrence == null)
            {
                throw new InvalidDataException("Recurrence is a required property for Offer and cannot be null");
            }
            else
            {
                this.Recurrence = Recurrence;
            }
            this.Id = Id;
            this.RecurrenceCount = RecurrenceCount;
            this.SecureId = SecureId;
            this.TrialPeriod = TrialPeriod;
        }
        
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OpenEnded
        /// </summary>
        [DataMember(Name="openEnded", EmitDefaultValue=false)]
        public bool? OpenEnded { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name="recurrence", EmitDefaultValue=false)]
        public RecurrencePeriod Recurrence { get; set; }

        /// <summary>
        /// Gets or Sets RecurrenceCount
        /// </summary>
        [DataMember(Name="recurrenceCount", EmitDefaultValue=false)]
        public int? RecurrenceCount { get; set; }

        /// <summary>
        /// Gets or Sets SecureId
        /// </summary>
        [DataMember(Name="secureId", EmitDefaultValue=false)]
        public string SecureId { get; set; }

        /// <summary>
        /// Gets or Sets TrialPeriod
        /// </summary>
        [DataMember(Name="trialPeriod", EmitDefaultValue=false)]
        public int? TrialPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Offer {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenEnded: ").Append(OpenEnded).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  RecurrenceCount: ").Append(RecurrenceCount).Append("\n");
            sb.Append("  SecureId: ").Append(SecureId).Append("\n");
            sb.Append("  TrialPeriod: ").Append(TrialPeriod).Append("\n");
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
            return this.Equals(input as Offer);
        }

        /// <summary>
        /// Returns true if Offer instances are equal
        /// </summary>
        /// <param name="input">Instance of Offer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Offer input)
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
                    this.OpenEnded == input.OpenEnded ||
                    (this.OpenEnded != null &&
                    this.OpenEnded.Equals(input.OpenEnded))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Recurrence == input.Recurrence ||
                    (this.Recurrence != null &&
                    this.Recurrence.Equals(input.Recurrence))
                ) && 
                (
                    this.RecurrenceCount == input.RecurrenceCount ||
                    (this.RecurrenceCount != null &&
                    this.RecurrenceCount.Equals(input.RecurrenceCount))
                ) && 
                (
                    this.SecureId == input.SecureId ||
                    (this.SecureId != null &&
                    this.SecureId.Equals(input.SecureId))
                ) && 
                (
                    this.TrialPeriod == input.TrialPeriod ||
                    (this.TrialPeriod != null &&
                    this.TrialPeriod.Equals(input.TrialPeriod))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenEnded != null)
                    hashCode = hashCode * 59 + this.OpenEnded.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Recurrence != null)
                    hashCode = hashCode * 59 + this.Recurrence.GetHashCode();
                if (this.RecurrenceCount != null)
                    hashCode = hashCode * 59 + this.RecurrenceCount.GetHashCode();
                if (this.SecureId != null)
                    hashCode = hashCode * 59 + this.SecureId.GetHashCode();
                if (this.TrialPeriod != null)
                    hashCode = hashCode * 59 + this.TrialPeriod.GetHashCode();
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
