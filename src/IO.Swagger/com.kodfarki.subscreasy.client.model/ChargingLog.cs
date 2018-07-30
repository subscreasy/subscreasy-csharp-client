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
    /// ChargingLog
    /// </summary>
    [DataContract]
    public partial class ChargingLog :  IEquatable<ChargingLog>, IValidatableObject
    {
        /// <summary>
        /// Defines PaymentGateway
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentGatewayEnum
        {
            
            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            OFFLINE = 1,
            
            /// <summary>
            /// Enum IYZICO for value: IYZICO
            /// </summary>
            [EnumMember(Value = "IYZICO")]
            IYZICO = 2,
            
            /// <summary>
            /// Enum PAYU for value: PAYU
            /// </summary>
            [EnumMember(Value = "PAYU")]
            PAYU = 3
        }

        /// <summary>
        /// Gets or Sets PaymentGateway
        /// </summary>
        [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
        public PaymentGatewayEnum? PaymentGateway { get; set; }
        /// <summary>
        /// Defines Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum START for value: START
            /// </summary>
            [EnumMember(Value = "START")]
            START = 1,
            
            /// <summary>
            /// Enum RENEWAL for value: RENEWAL
            /// </summary>
            [EnumMember(Value = "RENEWAL")]
            RENEWAL = 2,
            
            /// <summary>
            /// Enum OVERUSAGE for value: OVER_USAGE
            /// </summary>
            [EnumMember(Value = "OVER_USAGE")]
            OVERUSAGE = 3,
            
            /// <summary>
            /// Enum REFUND for value: REFUND
            /// </summary>
            [EnumMember(Value = "REFUND")]
            REFUND = 4
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NOTPAID for value: NOT_PAID
            /// </summary>
            [EnumMember(Value = "NOT_PAID")]
            NOTPAID = 1,
            
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 2,
            
            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            [EnumMember(Value = "FAIL")]
            FAIL = 3,
            
            /// <summary>
            /// Enum REFUNDED for value: REFUNDED
            /// </summary>
            [EnumMember(Value = "REFUNDED")]
            REFUNDED = 4
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargingLog" /> class.
        /// </summary>
        /// <param name="AppliedCoupon">AppliedCoupon.</param>
        /// <param name="AuthCode">AuthCode.</param>
        /// <param name="CompanyId">CompanyId.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorText">ErrorText.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InvoiceId">InvoiceId.</param>
        /// <param name="JobId">JobId.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="PaymentGateway">PaymentGateway.</param>
        /// <param name="PaymentId">PaymentId.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="ServiceInstanceId">ServiceInstanceId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SubscriberSecureId">SubscriberSecureId.</param>
        /// <param name="SubscriptionId">SubscriptionId.</param>
        /// <param name="TransactionId">TransactionId.</param>
        public ChargingLog(long? AppliedCoupon = default(long?), string AuthCode = default(string), long? CompanyId = default(long?), DateTime? CreateDate = default(DateTime?), string Currency = default(string), string ErrorCode = default(string), string ErrorText = default(string), long? Id = default(long?), long? InvoiceId = default(long?), long? JobId = default(long?), long? ParentId = default(long?), PaymentGatewayEnum? PaymentGateway = default(PaymentGatewayEnum?), string PaymentId = default(string), decimal? Price = default(decimal?), ReasonEnum? Reason = default(ReasonEnum?), long? ServiceInstanceId = default(long?), StatusEnum? Status = default(StatusEnum?), string SubscriberSecureId = default(string), long? SubscriptionId = default(long?), string TransactionId = default(string))
        {
            this.AppliedCoupon = AppliedCoupon;
            this.AuthCode = AuthCode;
            this.CompanyId = CompanyId;
            this.CreateDate = CreateDate;
            this.Currency = Currency;
            this.ErrorCode = ErrorCode;
            this.ErrorText = ErrorText;
            this.Id = Id;
            this.InvoiceId = InvoiceId;
            this.JobId = JobId;
            this.ParentId = ParentId;
            this.PaymentGateway = PaymentGateway;
            this.PaymentId = PaymentId;
            this.Price = Price;
            this.Reason = Reason;
            this.ServiceInstanceId = ServiceInstanceId;
            this.Status = Status;
            this.SubscriberSecureId = SubscriberSecureId;
            this.SubscriptionId = SubscriptionId;
            this.TransactionId = TransactionId;
        }
        
        /// <summary>
        /// Gets or Sets AppliedCoupon
        /// </summary>
        [DataMember(Name="appliedCoupon", EmitDefaultValue=false)]
        public long? AppliedCoupon { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        [DataMember(Name="authCode", EmitDefaultValue=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorText
        /// </summary>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceId
        /// </summary>
        [DataMember(Name="invoiceId", EmitDefaultValue=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public long? ParentId { get; set; }


        /// <summary>
        /// Gets or Sets PaymentId
        /// </summary>
        [DataMember(Name="paymentId", EmitDefaultValue=false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }


        /// <summary>
        /// Gets or Sets ServiceInstanceId
        /// </summary>
        [DataMember(Name="serviceInstanceId", EmitDefaultValue=false)]
        public long? ServiceInstanceId { get; set; }


        /// <summary>
        /// Gets or Sets SubscriberSecureId
        /// </summary>
        [DataMember(Name="subscriberSecureId", EmitDefaultValue=false)]
        public string SubscriberSecureId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
        public long? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargingLog {\n");
            sb.Append("  AppliedCoupon: ").Append(AppliedCoupon).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ServiceInstanceId: ").Append(ServiceInstanceId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubscriberSecureId: ").Append(SubscriberSecureId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as ChargingLog);
        }

        /// <summary>
        /// Returns true if ChargingLog instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargingLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargingLog input)
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
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
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
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorText == input.ErrorText ||
                    (this.ErrorText != null &&
                    this.ErrorText.Equals(input.ErrorText))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.PaymentGateway == input.PaymentGateway ||
                    (this.PaymentGateway != null &&
                    this.PaymentGateway.Equals(input.PaymentGateway))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ServiceInstanceId == input.ServiceInstanceId ||
                    (this.ServiceInstanceId != null &&
                    this.ServiceInstanceId.Equals(input.ServiceInstanceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubscriberSecureId == input.SubscriberSecureId ||
                    (this.SubscriberSecureId != null &&
                    this.SubscriberSecureId.Equals(input.SubscriberSecureId))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.AuthCode != null)
                    hashCode = hashCode * 59 + this.AuthCode.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorText != null)
                    hashCode = hashCode * 59 + this.ErrorText.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.PaymentGateway != null)
                    hashCode = hashCode * 59 + this.PaymentGateway.GetHashCode();
                if (this.PaymentId != null)
                    hashCode = hashCode * 59 + this.PaymentId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ServiceInstanceId != null)
                    hashCode = hashCode * 59 + this.ServiceInstanceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubscriberSecureId != null)
                    hashCode = hashCode * 59 + this.SubscriberSecureId.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
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
