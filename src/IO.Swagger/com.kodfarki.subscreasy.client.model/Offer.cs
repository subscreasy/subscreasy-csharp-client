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
        /// Defines Currency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            
            /// <summary>
            /// Enum TRY for value: TRY
            /// </summary>
            [EnumMember(Value = "TRY")]
            TRY = 1,
            
            /// <summary>
            /// Enum USD for value: USD
            /// </summary>
            [EnumMember(Value = "USD")]
            USD = 2
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// Defines ProductType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductTypeEnum
        {
            
            /// <summary>
            /// Enum PHYSICAL for value: PHYSICAL
            /// </summary>
            [EnumMember(Value = "PHYSICAL")]
            PHYSICAL = 1,
            
            /// <summary>
            /// Enum SERVICE for value: SERVICE
            /// </summary>
            [EnumMember(Value = "SERVICE")]
            SERVICE = 2
        }

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public ProductTypeEnum? ProductType { get; set; }
        /// <summary>
        /// Defines RenewalType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RenewalTypeEnum
        {
            
            /// <summary>
            /// Enum BILLCYCLE for value: BILLCYCLE
            /// </summary>
            [EnumMember(Value = "BILLCYCLE")]
            BILLCYCLE = 1,
            
            /// <summary>
            /// Enum STARTDATE for value: START_DATE
            /// </summary>
            [EnumMember(Value = "START_DATE")]
            STARTDATE = 2
        }

        /// <summary>
        /// Gets or Sets RenewalType
        /// </summary>
        [DataMember(Name="renewalType", EmitDefaultValue=false)]
        public RenewalTypeEnum? RenewalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Offer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Offer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Offer" /> class.
        /// </summary>
        /// <param name="Company">Company (required).</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="Currency">Currency (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="DisablePaymentForm">DisablePaymentForm (required).</param>
        /// <param name="Id">Id.</param>
        /// <param name="ImagePath">ImagePath.</param>
        /// <param name="MultiplePurchase">MultiplePurchase (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="OpenEnded">OpenEnded (required).</param>
        /// <param name="PhysicalProduct">PhysicalProduct.</param>
        /// <param name="Price">Price (required).</param>
        /// <param name="ProductType">ProductType.</param>
        /// <param name="Recurrence">Recurrence.</param>
        /// <param name="RecurrenceCount">RecurrenceCount.</param>
        /// <param name="RenewalBillcycleBased">RenewalBillcycleBased.</param>
        /// <param name="RenewalType">RenewalType.</param>
        /// <param name="SecureId">SecureId.</param>
        /// <param name="TrialPeriod">TrialPeriod.</param>
        public Offer(Company Company = default(Company), DateTime? CreateDate = default(DateTime?), CurrencyEnum Currency = default(CurrencyEnum), string Description = default(string), bool? DisablePaymentForm = default(bool?), long? Id = default(long?), string ImagePath = default(string), bool? MultiplePurchase = default(bool?), string Name = default(string), bool? OpenEnded = default(bool?), bool? PhysicalProduct = default(bool?), decimal? Price = default(decimal?), ProductTypeEnum? ProductType = default(ProductTypeEnum?), RecurrencePeriod Recurrence = default(RecurrencePeriod), int? RecurrenceCount = default(int?), bool? RenewalBillcycleBased = default(bool?), RenewalTypeEnum? RenewalType = default(RenewalTypeEnum?), string SecureId = default(string), int? TrialPeriod = default(int?))
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
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for Offer and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            // to ensure "DisablePaymentForm" is required (not null)
            if (DisablePaymentForm == null)
            {
                throw new InvalidDataException("DisablePaymentForm is a required property for Offer and cannot be null");
            }
            else
            {
                this.DisablePaymentForm = DisablePaymentForm;
            }
            // to ensure "MultiplePurchase" is required (not null)
            if (MultiplePurchase == null)
            {
                throw new InvalidDataException("MultiplePurchase is a required property for Offer and cannot be null");
            }
            else
            {
                this.MultiplePurchase = MultiplePurchase;
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
            this.CreateDate = CreateDate;
            this.Description = Description;
            this.Id = Id;
            this.ImagePath = ImagePath;
            this.PhysicalProduct = PhysicalProduct;
            this.ProductType = ProductType;
            this.Recurrence = Recurrence;
            this.RecurrenceCount = RecurrenceCount;
            this.RenewalBillcycleBased = RenewalBillcycleBased;
            this.RenewalType = RenewalType;
            this.SecureId = SecureId;
            this.TrialPeriod = TrialPeriod;
        }
        
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }


        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisablePaymentForm
        /// </summary>
        [DataMember(Name="disablePaymentForm", EmitDefaultValue=false)]
        public bool? DisablePaymentForm { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ImagePath
        /// </summary>
        [DataMember(Name="imagePath", EmitDefaultValue=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or Sets MultiplePurchase
        /// </summary>
        [DataMember(Name="multiplePurchase", EmitDefaultValue=false)]
        public bool? MultiplePurchase { get; set; }

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
        /// Gets or Sets PhysicalProduct
        /// </summary>
        [DataMember(Name="physicalProduct", EmitDefaultValue=false)]
        public bool? PhysicalProduct { get; set; }

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
        /// Gets or Sets RenewalBillcycleBased
        /// </summary>
        [DataMember(Name="renewalBillcycleBased", EmitDefaultValue=false)]
        public bool? RenewalBillcycleBased { get; set; }


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
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisablePaymentForm: ").Append(DisablePaymentForm).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  MultiplePurchase: ").Append(MultiplePurchase).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenEnded: ").Append(OpenEnded).Append("\n");
            sb.Append("  PhysicalProduct: ").Append(PhysicalProduct).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  RecurrenceCount: ").Append(RecurrenceCount).Append("\n");
            sb.Append("  RenewalBillcycleBased: ").Append(RenewalBillcycleBased).Append("\n");
            sb.Append("  RenewalType: ").Append(RenewalType).Append("\n");
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
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisablePaymentForm == input.DisablePaymentForm ||
                    (this.DisablePaymentForm != null &&
                    this.DisablePaymentForm.Equals(input.DisablePaymentForm))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImagePath == input.ImagePath ||
                    (this.ImagePath != null &&
                    this.ImagePath.Equals(input.ImagePath))
                ) && 
                (
                    this.MultiplePurchase == input.MultiplePurchase ||
                    (this.MultiplePurchase != null &&
                    this.MultiplePurchase.Equals(input.MultiplePurchase))
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
                    this.PhysicalProduct == input.PhysicalProduct ||
                    (this.PhysicalProduct != null &&
                    this.PhysicalProduct.Equals(input.PhysicalProduct))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
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
                    this.RenewalBillcycleBased == input.RenewalBillcycleBased ||
                    (this.RenewalBillcycleBased != null &&
                    this.RenewalBillcycleBased.Equals(input.RenewalBillcycleBased))
                ) && 
                (
                    this.RenewalType == input.RenewalType ||
                    (this.RenewalType != null &&
                    this.RenewalType.Equals(input.RenewalType))
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
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisablePaymentForm != null)
                    hashCode = hashCode * 59 + this.DisablePaymentForm.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImagePath != null)
                    hashCode = hashCode * 59 + this.ImagePath.GetHashCode();
                if (this.MultiplePurchase != null)
                    hashCode = hashCode * 59 + this.MultiplePurchase.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenEnded != null)
                    hashCode = hashCode * 59 + this.OpenEnded.GetHashCode();
                if (this.PhysicalProduct != null)
                    hashCode = hashCode * 59 + this.PhysicalProduct.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Recurrence != null)
                    hashCode = hashCode * 59 + this.Recurrence.GetHashCode();
                if (this.RecurrenceCount != null)
                    hashCode = hashCode * 59 + this.RecurrenceCount.GetHashCode();
                if (this.RenewalBillcycleBased != null)
                    hashCode = hashCode * 59 + this.RenewalBillcycleBased.GetHashCode();
                if (this.RenewalType != null)
                    hashCode = hashCode * 59 + this.RenewalType.GetHashCode();
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
