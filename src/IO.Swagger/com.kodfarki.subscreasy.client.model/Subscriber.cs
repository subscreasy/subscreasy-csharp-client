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
    /// Subscriber
    /// </summary>
    [DataContract]
    public partial class Subscriber :  IEquatable<Subscriber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriber" /> class.
        /// </summary>
        /// <param name="Address">Address.</param>
        /// <param name="City">City.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Email">Email.</param>
        /// <param name="GsmNumber">GsmNumber.</param>
        /// <param name="IdentityNumber">IdentityNumber.</param>
        /// <param name="Ip">Ip.</param>
        /// <param name="LastLoginDate">LastLoginDate.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RegistrationDate">RegistrationDate.</param>
        /// <param name="SecureId">SecureId.</param>
        /// <param name="ShippingAddress">ShippingAddress.</param>
        /// <param name="ShippingCity">ShippingCity.</param>
        /// <param name="ShippingCountry">ShippingCountry.</param>
        /// <param name="ShippingName">ShippingName.</param>
        /// <param name="ShippingZipCode">ShippingZipCode.</param>
        /// <param name="Surname">Surname.</param>
        /// <param name="UseBillingAddressForShipping">UseBillingAddressForShipping.</param>
        /// <param name="ZipCode">ZipCode.</param>
        public Subscriber(string Address = default(string), string City = default(string), string Country = default(string), string Email = default(string), string GsmNumber = default(string), string IdentityNumber = default(string), string Ip = default(string), string LastLoginDate = default(string), string Name = default(string), string RegistrationDate = default(string), string SecureId = default(string), string ShippingAddress = default(string), string ShippingCity = default(string), string ShippingCountry = default(string), string ShippingName = default(string), string ShippingZipCode = default(string), string Surname = default(string), bool? UseBillingAddressForShipping = default(bool?), string ZipCode = default(string))
        {
            this.Address = Address;
            this.City = City;
            this.Country = Country;
            this.Email = Email;
            this.GsmNumber = GsmNumber;
            this.IdentityNumber = IdentityNumber;
            this.Ip = Ip;
            this.LastLoginDate = LastLoginDate;
            this.Name = Name;
            this.RegistrationDate = RegistrationDate;
            this.SecureId = SecureId;
            this.ShippingAddress = ShippingAddress;
            this.ShippingCity = ShippingCity;
            this.ShippingCountry = ShippingCountry;
            this.ShippingName = ShippingName;
            this.ShippingZipCode = ShippingZipCode;
            this.Surname = Surname;
            this.UseBillingAddressForShipping = UseBillingAddressForShipping;
            this.ZipCode = ZipCode;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets GsmNumber
        /// </summary>
        [DataMember(Name="gsmNumber", EmitDefaultValue=false)]
        public string GsmNumber { get; set; }

        /// <summary>
        /// Gets or Sets IdentityNumber
        /// </summary>
        [DataMember(Name="identityNumber", EmitDefaultValue=false)]
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets LastLoginDate
        /// </summary>
        [DataMember(Name="lastLoginDate", EmitDefaultValue=false)]
        public string LastLoginDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name="registrationDate", EmitDefaultValue=false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets SecureId
        /// </summary>
        [DataMember(Name="secureId", EmitDefaultValue=false)]
        public string SecureId { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingCity
        /// </summary>
        [DataMember(Name="shippingCity", EmitDefaultValue=false)]
        public string ShippingCity { get; set; }

        /// <summary>
        /// Gets or Sets ShippingCountry
        /// </summary>
        [DataMember(Name="shippingCountry", EmitDefaultValue=false)]
        public string ShippingCountry { get; set; }

        /// <summary>
        /// Gets or Sets ShippingName
        /// </summary>
        [DataMember(Name="shippingName", EmitDefaultValue=false)]
        public string ShippingName { get; set; }

        /// <summary>
        /// Gets or Sets ShippingZipCode
        /// </summary>
        [DataMember(Name="shippingZipCode", EmitDefaultValue=false)]
        public string ShippingZipCode { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets UseBillingAddressForShipping
        /// </summary>
        [DataMember(Name="useBillingAddressForShipping", EmitDefaultValue=false)]
        public bool? UseBillingAddressForShipping { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscriber {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  GsmNumber: ").Append(GsmNumber).Append("\n");
            sb.Append("  IdentityNumber: ").Append(IdentityNumber).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  LastLoginDate: ").Append(LastLoginDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  SecureId: ").Append(SecureId).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingCity: ").Append(ShippingCity).Append("\n");
            sb.Append("  ShippingCountry: ").Append(ShippingCountry).Append("\n");
            sb.Append("  ShippingName: ").Append(ShippingName).Append("\n");
            sb.Append("  ShippingZipCode: ").Append(ShippingZipCode).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  UseBillingAddressForShipping: ").Append(UseBillingAddressForShipping).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
            return this.Equals(input as Subscriber);
        }

        /// <summary>
        /// Returns true if Subscriber instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscriber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscriber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.GsmNumber == input.GsmNumber ||
                    (this.GsmNumber != null &&
                    this.GsmNumber.Equals(input.GsmNumber))
                ) && 
                (
                    this.IdentityNumber == input.IdentityNumber ||
                    (this.IdentityNumber != null &&
                    this.IdentityNumber.Equals(input.IdentityNumber))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.LastLoginDate == input.LastLoginDate ||
                    (this.LastLoginDate != null &&
                    this.LastLoginDate.Equals(input.LastLoginDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.SecureId == input.SecureId ||
                    (this.SecureId != null &&
                    this.SecureId.Equals(input.SecureId))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ShippingCity == input.ShippingCity ||
                    (this.ShippingCity != null &&
                    this.ShippingCity.Equals(input.ShippingCity))
                ) && 
                (
                    this.ShippingCountry == input.ShippingCountry ||
                    (this.ShippingCountry != null &&
                    this.ShippingCountry.Equals(input.ShippingCountry))
                ) && 
                (
                    this.ShippingName == input.ShippingName ||
                    (this.ShippingName != null &&
                    this.ShippingName.Equals(input.ShippingName))
                ) && 
                (
                    this.ShippingZipCode == input.ShippingZipCode ||
                    (this.ShippingZipCode != null &&
                    this.ShippingZipCode.Equals(input.ShippingZipCode))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.UseBillingAddressForShipping == input.UseBillingAddressForShipping ||
                    (this.UseBillingAddressForShipping != null &&
                    this.UseBillingAddressForShipping.Equals(input.UseBillingAddressForShipping))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.GsmNumber != null)
                    hashCode = hashCode * 59 + this.GsmNumber.GetHashCode();
                if (this.IdentityNumber != null)
                    hashCode = hashCode * 59 + this.IdentityNumber.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.LastLoginDate != null)
                    hashCode = hashCode * 59 + this.LastLoginDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.SecureId != null)
                    hashCode = hashCode * 59 + this.SecureId.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingCity != null)
                    hashCode = hashCode * 59 + this.ShippingCity.GetHashCode();
                if (this.ShippingCountry != null)
                    hashCode = hashCode * 59 + this.ShippingCountry.GetHashCode();
                if (this.ShippingName != null)
                    hashCode = hashCode * 59 + this.ShippingName.GetHashCode();
                if (this.ShippingZipCode != null)
                    hashCode = hashCode * 59 + this.ShippingZipCode.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.UseBillingAddressForShipping != null)
                    hashCode = hashCode * 59 + this.UseBillingAddressForShipping.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
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
