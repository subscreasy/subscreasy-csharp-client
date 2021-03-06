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
    /// RecurrencePeriod
    /// </summary>
    [DataContract]
    public partial class RecurrencePeriod :  IEquatable<RecurrencePeriod>, IValidatableObject
    {
        /// <summary>
        /// Defines RecurrenceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecurrenceTypeEnum
        {
            
            /// <summary>
            /// Enum SECONDLY for value: SECONDLY
            /// </summary>
            [EnumMember(Value = "SECONDLY")]
            SECONDLY = 1,
            
            /// <summary>
            /// Enum MINUTELY for value: MINUTELY
            /// </summary>
            [EnumMember(Value = "MINUTELY")]
            MINUTELY = 2,
            
            /// <summary>
            /// Enum HOURLY for value: HOURLY
            /// </summary>
            [EnumMember(Value = "HOURLY")]
            HOURLY = 3,
            
            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY = 4,
            
            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY = 5,
            
            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 6,
            
            /// <summary>
            /// Enum YEARLY for value: YEARLY
            /// </summary>
            [EnumMember(Value = "YEARLY")]
            YEARLY = 7
        }

        /// <summary>
        /// Gets or Sets RecurrenceType
        /// </summary>
        [DataMember(Name="recurrenceType", EmitDefaultValue=false)]
        public RecurrenceTypeEnum RecurrenceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrencePeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecurrencePeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrencePeriod" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Length">Length (required).</param>
        /// <param name="RecurrenceType">RecurrenceType (required).</param>
        public RecurrencePeriod(long? Id = default(long?), long? Length = default(long?), RecurrenceTypeEnum RecurrenceType = default(RecurrenceTypeEnum))
        {
            // to ensure "Length" is required (not null)
            if (Length == null)
            {
                throw new InvalidDataException("Length is a required property for RecurrencePeriod and cannot be null");
            }
            else
            {
                this.Length = Length;
            }
            // to ensure "RecurrenceType" is required (not null)
            if (RecurrenceType == null)
            {
                throw new InvalidDataException("RecurrenceType is a required property for RecurrencePeriod and cannot be null");
            }
            else
            {
                this.RecurrenceType = RecurrenceType;
            }
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurrencePeriod {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  RecurrenceType: ").Append(RecurrenceType).Append("\n");
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
            return this.Equals(input as RecurrencePeriod);
        }

        /// <summary>
        /// Returns true if RecurrencePeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurrencePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrencePeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.RecurrenceType == input.RecurrenceType ||
                    (this.RecurrenceType != null &&
                    this.RecurrenceType.Equals(input.RecurrenceType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.RecurrenceType != null)
                    hashCode = hashCode * 59 + this.RecurrenceType.GetHashCode();
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
