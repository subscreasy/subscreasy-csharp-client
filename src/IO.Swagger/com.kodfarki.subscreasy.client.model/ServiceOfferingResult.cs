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
    /// ServiceOfferingResult
    /// </summary>
    [DataContract]
    public partial class ServiceOfferingResult :  IEquatable<ServiceOfferingResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfferingResult" /> class.
        /// </summary>
        /// <param name="Capacity">Capacity.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Type">Type.</param>
        /// <param name="UnitName">UnitName.</param>
        /// <param name="UnitsPerPrice">UnitsPerPrice.</param>
        public ServiceOfferingResult(string Capacity = default(string), long? Id = default(long?), string Name = default(string), decimal? Price = default(decimal?), string Type = default(string), string UnitName = default(string), decimal? UnitsPerPrice = default(decimal?))
        {
            this.Capacity = Capacity;
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Type = Type;
            this.UnitName = UnitName;
            this.UnitsPerPrice = UnitsPerPrice;
        }
        
        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public string Capacity { get; set; }

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
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UnitName
        /// </summary>
        [DataMember(Name="unitName", EmitDefaultValue=false)]
        public string UnitName { get; set; }

        /// <summary>
        /// Gets or Sets UnitsPerPrice
        /// </summary>
        [DataMember(Name="unitsPerPrice", EmitDefaultValue=false)]
        public decimal? UnitsPerPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceOfferingResult {\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnitName: ").Append(UnitName).Append("\n");
            sb.Append("  UnitsPerPrice: ").Append(UnitsPerPrice).Append("\n");
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
            return this.Equals(input as ServiceOfferingResult);
        }

        /// <summary>
        /// Returns true if ServiceOfferingResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceOfferingResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceOfferingResult input)
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
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UnitName == input.UnitName ||
                    (this.UnitName != null &&
                    this.UnitName.Equals(input.UnitName))
                ) && 
                (
                    this.UnitsPerPrice == input.UnitsPerPrice ||
                    (this.UnitsPerPrice != null &&
                    this.UnitsPerPrice.Equals(input.UnitsPerPrice))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UnitName != null)
                    hashCode = hashCode * 59 + this.UnitName.GetHashCode();
                if (this.UnitsPerPrice != null)
                    hashCode = hashCode * 59 + this.UnitsPerPrice.GetHashCode();
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