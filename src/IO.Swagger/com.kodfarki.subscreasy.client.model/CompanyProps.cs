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
    /// CompanyProps
    /// </summary>
    [DataContract]
    public partial class CompanyProps :  IEquatable<CompanyProps>, IValidatableObject
    {
        /// <summary>
        /// Defines MobilePaymentGateway
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MobilePaymentGatewayEnum
        {
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 1,
            
            /// <summary>
            /// Enum WIRECARD for value: WIRECARD
            /// </summary>
            [EnumMember(Value = "WIRECARD")]
            WIRECARD = 2
        }

        /// <summary>
        /// Gets or Sets MobilePaymentGateway
        /// </summary>
        [DataMember(Name="mobilePaymentGateway", EmitDefaultValue=false)]
        public MobilePaymentGatewayEnum? MobilePaymentGateway { get; set; }
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
            PAYU = 3,
            
            /// <summary>
            /// Enum PAYTR for value: PAYTR
            /// </summary>
            [EnumMember(Value = "PAYTR")]
            PAYTR = 4,
            
            /// <summary>
            /// Enum MOBILEXPRESS for value: MOBILEXPRESS
            /// </summary>
            [EnumMember(Value = "MOBILEXPRESS")]
            MOBILEXPRESS = 5
        }

        /// <summary>
        /// Gets or Sets PaymentGateway
        /// </summary>
        [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
        public PaymentGatewayEnum? PaymentGateway { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyProps" /> class.
        /// </summary>
        /// <param name="BillingDate">BillingDate.</param>
        /// <param name="BillingInformationMandatory">BillingInformationMandatory (required).</param>
        /// <param name="BillingThresholdDays">BillingThresholdDays.</param>
        /// <param name="Branding">Branding (required).</param>
        /// <param name="CallbackUrl">CallbackUrl.</param>
        /// <param name="Company">Company.</param>
        /// <param name="ContactEmail">ContactEmail.</param>
        /// <param name="DomainName">DomainName (required).</param>
        /// <param name="HostedPageCSSPath">HostedPageCSSPath.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LogoPath">LogoPath.</param>
        /// <param name="MobilExpressApiPassword">MobilExpressApiPassword.</param>
        /// <param name="MobilExpressMerchantKey">MobilExpressMerchantKey.</param>
        /// <param name="MobilExpressPosid">MobilExpressPosid.</param>
        /// <param name="MobilePaymentGateway">MobilePaymentGateway.</param>
        /// <param name="NotifyNewSubscription">NotifyNewSubscription (required).</param>
        /// <param name="NotifyRenewal">NotifyRenewal (required).</param>
        /// <param name="NotifySubscriptionCancellation">NotifySubscriptionCancellation (required).</param>
        /// <param name="PaymentGateway">PaymentGateway.</param>
        /// <param name="PaymentGatewayApiKey">PaymentGatewayApiKey.</param>
        /// <param name="PaymentGatewaySecurityKey">PaymentGatewaySecurityKey.</param>
        /// <param name="PaytrDirectApiEnabled">PaytrDirectApiEnabled.</param>
        /// <param name="PaytrMerchantId">PaytrMerchantId.</param>
        /// <param name="PayuMerchantKeyRenewals">PayuMerchantKeyRenewals.</param>
        /// <param name="PayuSecretKeyRenewals">PayuSecretKeyRenewals.</param>
        /// <param name="PrivacyPolicyUrl">PrivacyPolicyUrl.</param>
        /// <param name="SendDailyReports">SendDailyReports.</param>
        /// <param name="SubscreasyApiKey">SubscreasyApiKey.</param>
        /// <param name="SubscreasySecureKey">SubscreasySecureKey.</param>
        /// <param name="WirecardErrorMessage">WirecardErrorMessage.</param>
        /// <param name="WirecardPin">WirecardPin.</param>
        /// <param name="WirecardSuccessfulMessage">WirecardSuccessfulMessage.</param>
        /// <param name="WirecardTurkcellServisId">WirecardTurkcellServisId.</param>
        /// <param name="WirecardUserCode">WirecardUserCode.</param>
        public CompanyProps(int? BillingDate = default(int?), bool? BillingInformationMandatory = default(bool?), int? BillingThresholdDays = default(int?), bool? Branding = default(bool?), string CallbackUrl = default(string), Company Company = default(Company), string ContactEmail = default(string), string DomainName = default(string), string HostedPageCSSPath = default(string), long? Id = default(long?), string LogoPath = default(string), string MobilExpressApiPassword = default(string), string MobilExpressMerchantKey = default(string), int? MobilExpressPosid = default(int?), MobilePaymentGatewayEnum? MobilePaymentGateway = default(MobilePaymentGatewayEnum?), bool? NotifyNewSubscription = default(bool?), bool? NotifyRenewal = default(bool?), bool? NotifySubscriptionCancellation = default(bool?), PaymentGatewayEnum? PaymentGateway = default(PaymentGatewayEnum?), string PaymentGatewayApiKey = default(string), string PaymentGatewaySecurityKey = default(string), bool? PaytrDirectApiEnabled = default(bool?), int? PaytrMerchantId = default(int?), string PayuMerchantKeyRenewals = default(string), string PayuSecretKeyRenewals = default(string), string PrivacyPolicyUrl = default(string), string SendDailyReports = default(string), string SubscreasyApiKey = default(string), string SubscreasySecureKey = default(string), string WirecardErrorMessage = default(string), string WirecardPin = default(string), string WirecardSuccessfulMessage = default(string), string WirecardTurkcellServisId = default(string), string WirecardUserCode = default(string))
        {
            // to ensure "BillingInformationMandatory" is required (not null)
            if (BillingInformationMandatory == null)
            {
                throw new InvalidDataException("BillingInformationMandatory is a required property for CompanyProps and cannot be null");
            }
            else
            {
                this.BillingInformationMandatory = BillingInformationMandatory;
            }
            // to ensure "Branding" is required (not null)
            if (Branding == null)
            {
                throw new InvalidDataException("Branding is a required property for CompanyProps and cannot be null");
            }
            else
            {
                this.Branding = Branding;
            }
            // to ensure "DomainName" is required (not null)
            if (DomainName == null)
            {
                throw new InvalidDataException("DomainName is a required property for CompanyProps and cannot be null");
            }
            else
            {
                this.DomainName = DomainName;
            }
            // to ensure "NotifyNewSubscription" is required (not null)
            if (NotifyNewSubscription == null)
            {
                throw new InvalidDataException("NotifyNewSubscription is a required property for CompanyProps and cannot be null");
            }
            else
            {
                this.NotifyNewSubscription = NotifyNewSubscription;
            }
            // to ensure "NotifyRenewal" is required (not null)
            if (NotifyRenewal == null)
            {
                throw new InvalidDataException("NotifyRenewal is a required property for CompanyProps and cannot be null");
            }
            else
            {
                this.NotifyRenewal = NotifyRenewal;
            }
            // to ensure "NotifySubscriptionCancellation" is required (not null)
            if (NotifySubscriptionCancellation == null)
            {
                throw new InvalidDataException("NotifySubscriptionCancellation is a required property for CompanyProps and cannot be null");
            }
            else
            {
                this.NotifySubscriptionCancellation = NotifySubscriptionCancellation;
            }
            this.BillingDate = BillingDate;
            this.BillingThresholdDays = BillingThresholdDays;
            this.CallbackUrl = CallbackUrl;
            this.Company = Company;
            this.ContactEmail = ContactEmail;
            this.HostedPageCSSPath = HostedPageCSSPath;
            this.Id = Id;
            this.LogoPath = LogoPath;
            this.MobilExpressApiPassword = MobilExpressApiPassword;
            this.MobilExpressMerchantKey = MobilExpressMerchantKey;
            this.MobilExpressPosid = MobilExpressPosid;
            this.MobilePaymentGateway = MobilePaymentGateway;
            this.PaymentGateway = PaymentGateway;
            this.PaymentGatewayApiKey = PaymentGatewayApiKey;
            this.PaymentGatewaySecurityKey = PaymentGatewaySecurityKey;
            this.PaytrDirectApiEnabled = PaytrDirectApiEnabled;
            this.PaytrMerchantId = PaytrMerchantId;
            this.PayuMerchantKeyRenewals = PayuMerchantKeyRenewals;
            this.PayuSecretKeyRenewals = PayuSecretKeyRenewals;
            this.PrivacyPolicyUrl = PrivacyPolicyUrl;
            this.SendDailyReports = SendDailyReports;
            this.SubscreasyApiKey = SubscreasyApiKey;
            this.SubscreasySecureKey = SubscreasySecureKey;
            this.WirecardErrorMessage = WirecardErrorMessage;
            this.WirecardPin = WirecardPin;
            this.WirecardSuccessfulMessage = WirecardSuccessfulMessage;
            this.WirecardTurkcellServisId = WirecardTurkcellServisId;
            this.WirecardUserCode = WirecardUserCode;
        }
        
        /// <summary>
        /// Gets or Sets BillingDate
        /// </summary>
        [DataMember(Name="billingDate", EmitDefaultValue=false)]
        public int? BillingDate { get; set; }

        /// <summary>
        /// Gets or Sets BillingInformationMandatory
        /// </summary>
        [DataMember(Name="billingInformationMandatory", EmitDefaultValue=false)]
        public bool? BillingInformationMandatory { get; set; }

        /// <summary>
        /// Gets or Sets BillingThresholdDays
        /// </summary>
        [DataMember(Name="billingThresholdDays", EmitDefaultValue=false)]
        public int? BillingThresholdDays { get; set; }

        /// <summary>
        /// Gets or Sets Branding
        /// </summary>
        [DataMember(Name="branding", EmitDefaultValue=false)]
        public bool? Branding { get; set; }

        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [DataMember(Name="callbackUrl", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name="contactEmail", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets DomainName
        /// </summary>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or Sets HostedPageCSSPath
        /// </summary>
        [DataMember(Name="hostedPageCSSPath", EmitDefaultValue=false)]
        public string HostedPageCSSPath { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LogoPath
        /// </summary>
        [DataMember(Name="logoPath", EmitDefaultValue=false)]
        public string LogoPath { get; set; }

        /// <summary>
        /// Gets or Sets MobilExpressApiPassword
        /// </summary>
        [DataMember(Name="mobilExpressApiPassword", EmitDefaultValue=false)]
        public string MobilExpressApiPassword { get; set; }

        /// <summary>
        /// Gets or Sets MobilExpressMerchantKey
        /// </summary>
        [DataMember(Name="mobilExpressMerchantKey", EmitDefaultValue=false)]
        public string MobilExpressMerchantKey { get; set; }

        /// <summary>
        /// Gets or Sets MobilExpressPosid
        /// </summary>
        [DataMember(Name="mobilExpressPosid", EmitDefaultValue=false)]
        public int? MobilExpressPosid { get; set; }


        /// <summary>
        /// Gets or Sets NotifyNewSubscription
        /// </summary>
        [DataMember(Name="notifyNewSubscription", EmitDefaultValue=false)]
        public bool? NotifyNewSubscription { get; set; }

        /// <summary>
        /// Gets or Sets NotifyRenewal
        /// </summary>
        [DataMember(Name="notifyRenewal", EmitDefaultValue=false)]
        public bool? NotifyRenewal { get; set; }

        /// <summary>
        /// Gets or Sets NotifySubscriptionCancellation
        /// </summary>
        [DataMember(Name="notifySubscriptionCancellation", EmitDefaultValue=false)]
        public bool? NotifySubscriptionCancellation { get; set; }


        /// <summary>
        /// Gets or Sets PaymentGatewayApiKey
        /// </summary>
        [DataMember(Name="paymentGatewayApiKey", EmitDefaultValue=false)]
        public string PaymentGatewayApiKey { get; set; }

        /// <summary>
        /// Gets or Sets PaymentGatewaySecurityKey
        /// </summary>
        [DataMember(Name="paymentGatewaySecurityKey", EmitDefaultValue=false)]
        public string PaymentGatewaySecurityKey { get; set; }

        /// <summary>
        /// Gets or Sets PaytrDirectApiEnabled
        /// </summary>
        [DataMember(Name="paytrDirectApiEnabled", EmitDefaultValue=false)]
        public bool? PaytrDirectApiEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PaytrMerchantId
        /// </summary>
        [DataMember(Name="paytrMerchantId", EmitDefaultValue=false)]
        public int? PaytrMerchantId { get; set; }

        /// <summary>
        /// Gets or Sets PayuMerchantKeyRenewals
        /// </summary>
        [DataMember(Name="payuMerchantKeyRenewals", EmitDefaultValue=false)]
        public string PayuMerchantKeyRenewals { get; set; }

        /// <summary>
        /// Gets or Sets PayuSecretKeyRenewals
        /// </summary>
        [DataMember(Name="payuSecretKeyRenewals", EmitDefaultValue=false)]
        public string PayuSecretKeyRenewals { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicyUrl
        /// </summary>
        [DataMember(Name="privacyPolicyUrl", EmitDefaultValue=false)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or Sets SendDailyReports
        /// </summary>
        [DataMember(Name="sendDailyReports", EmitDefaultValue=false)]
        public string SendDailyReports { get; set; }

        /// <summary>
        /// Gets or Sets SubscreasyApiKey
        /// </summary>
        [DataMember(Name="subscreasyApiKey", EmitDefaultValue=false)]
        public string SubscreasyApiKey { get; set; }

        /// <summary>
        /// Gets or Sets SubscreasySecureKey
        /// </summary>
        [DataMember(Name="subscreasySecureKey", EmitDefaultValue=false)]
        public string SubscreasySecureKey { get; set; }

        /// <summary>
        /// Gets or Sets WirecardErrorMessage
        /// </summary>
        [DataMember(Name="wirecardErrorMessage", EmitDefaultValue=false)]
        public string WirecardErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets WirecardPin
        /// </summary>
        [DataMember(Name="wirecardPin", EmitDefaultValue=false)]
        public string WirecardPin { get; set; }

        /// <summary>
        /// Gets or Sets WirecardSuccessfulMessage
        /// </summary>
        [DataMember(Name="wirecardSuccessfulMessage", EmitDefaultValue=false)]
        public string WirecardSuccessfulMessage { get; set; }

        /// <summary>
        /// Gets or Sets WirecardTurkcellServisId
        /// </summary>
        [DataMember(Name="wirecardTurkcellServisId", EmitDefaultValue=false)]
        public string WirecardTurkcellServisId { get; set; }

        /// <summary>
        /// Gets or Sets WirecardUserCode
        /// </summary>
        [DataMember(Name="wirecardUserCode", EmitDefaultValue=false)]
        public string WirecardUserCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyProps {\n");
            sb.Append("  BillingDate: ").Append(BillingDate).Append("\n");
            sb.Append("  BillingInformationMandatory: ").Append(BillingInformationMandatory).Append("\n");
            sb.Append("  BillingThresholdDays: ").Append(BillingThresholdDays).Append("\n");
            sb.Append("  Branding: ").Append(Branding).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  HostedPageCSSPath: ").Append(HostedPageCSSPath).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogoPath: ").Append(LogoPath).Append("\n");
            sb.Append("  MobilExpressApiPassword: ").Append(MobilExpressApiPassword).Append("\n");
            sb.Append("  MobilExpressMerchantKey: ").Append(MobilExpressMerchantKey).Append("\n");
            sb.Append("  MobilExpressPosid: ").Append(MobilExpressPosid).Append("\n");
            sb.Append("  MobilePaymentGateway: ").Append(MobilePaymentGateway).Append("\n");
            sb.Append("  NotifyNewSubscription: ").Append(NotifyNewSubscription).Append("\n");
            sb.Append("  NotifyRenewal: ").Append(NotifyRenewal).Append("\n");
            sb.Append("  NotifySubscriptionCancellation: ").Append(NotifySubscriptionCancellation).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  PaymentGatewayApiKey: ").Append(PaymentGatewayApiKey).Append("\n");
            sb.Append("  PaymentGatewaySecurityKey: ").Append(PaymentGatewaySecurityKey).Append("\n");
            sb.Append("  PaytrDirectApiEnabled: ").Append(PaytrDirectApiEnabled).Append("\n");
            sb.Append("  PaytrMerchantId: ").Append(PaytrMerchantId).Append("\n");
            sb.Append("  PayuMerchantKeyRenewals: ").Append(PayuMerchantKeyRenewals).Append("\n");
            sb.Append("  PayuSecretKeyRenewals: ").Append(PayuSecretKeyRenewals).Append("\n");
            sb.Append("  PrivacyPolicyUrl: ").Append(PrivacyPolicyUrl).Append("\n");
            sb.Append("  SendDailyReports: ").Append(SendDailyReports).Append("\n");
            sb.Append("  SubscreasyApiKey: ").Append(SubscreasyApiKey).Append("\n");
            sb.Append("  SubscreasySecureKey: ").Append(SubscreasySecureKey).Append("\n");
            sb.Append("  WirecardErrorMessage: ").Append(WirecardErrorMessage).Append("\n");
            sb.Append("  WirecardPin: ").Append(WirecardPin).Append("\n");
            sb.Append("  WirecardSuccessfulMessage: ").Append(WirecardSuccessfulMessage).Append("\n");
            sb.Append("  WirecardTurkcellServisId: ").Append(WirecardTurkcellServisId).Append("\n");
            sb.Append("  WirecardUserCode: ").Append(WirecardUserCode).Append("\n");
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
            return this.Equals(input as CompanyProps);
        }

        /// <summary>
        /// Returns true if CompanyProps instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingDate == input.BillingDate ||
                    (this.BillingDate != null &&
                    this.BillingDate.Equals(input.BillingDate))
                ) && 
                (
                    this.BillingInformationMandatory == input.BillingInformationMandatory ||
                    (this.BillingInformationMandatory != null &&
                    this.BillingInformationMandatory.Equals(input.BillingInformationMandatory))
                ) && 
                (
                    this.BillingThresholdDays == input.BillingThresholdDays ||
                    (this.BillingThresholdDays != null &&
                    this.BillingThresholdDays.Equals(input.BillingThresholdDays))
                ) && 
                (
                    this.Branding == input.Branding ||
                    (this.Branding != null &&
                    this.Branding.Equals(input.Branding))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.HostedPageCSSPath == input.HostedPageCSSPath ||
                    (this.HostedPageCSSPath != null &&
                    this.HostedPageCSSPath.Equals(input.HostedPageCSSPath))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LogoPath == input.LogoPath ||
                    (this.LogoPath != null &&
                    this.LogoPath.Equals(input.LogoPath))
                ) && 
                (
                    this.MobilExpressApiPassword == input.MobilExpressApiPassword ||
                    (this.MobilExpressApiPassword != null &&
                    this.MobilExpressApiPassword.Equals(input.MobilExpressApiPassword))
                ) && 
                (
                    this.MobilExpressMerchantKey == input.MobilExpressMerchantKey ||
                    (this.MobilExpressMerchantKey != null &&
                    this.MobilExpressMerchantKey.Equals(input.MobilExpressMerchantKey))
                ) && 
                (
                    this.MobilExpressPosid == input.MobilExpressPosid ||
                    (this.MobilExpressPosid != null &&
                    this.MobilExpressPosid.Equals(input.MobilExpressPosid))
                ) && 
                (
                    this.MobilePaymentGateway == input.MobilePaymentGateway ||
                    (this.MobilePaymentGateway != null &&
                    this.MobilePaymentGateway.Equals(input.MobilePaymentGateway))
                ) && 
                (
                    this.NotifyNewSubscription == input.NotifyNewSubscription ||
                    (this.NotifyNewSubscription != null &&
                    this.NotifyNewSubscription.Equals(input.NotifyNewSubscription))
                ) && 
                (
                    this.NotifyRenewal == input.NotifyRenewal ||
                    (this.NotifyRenewal != null &&
                    this.NotifyRenewal.Equals(input.NotifyRenewal))
                ) && 
                (
                    this.NotifySubscriptionCancellation == input.NotifySubscriptionCancellation ||
                    (this.NotifySubscriptionCancellation != null &&
                    this.NotifySubscriptionCancellation.Equals(input.NotifySubscriptionCancellation))
                ) && 
                (
                    this.PaymentGateway == input.PaymentGateway ||
                    (this.PaymentGateway != null &&
                    this.PaymentGateway.Equals(input.PaymentGateway))
                ) && 
                (
                    this.PaymentGatewayApiKey == input.PaymentGatewayApiKey ||
                    (this.PaymentGatewayApiKey != null &&
                    this.PaymentGatewayApiKey.Equals(input.PaymentGatewayApiKey))
                ) && 
                (
                    this.PaymentGatewaySecurityKey == input.PaymentGatewaySecurityKey ||
                    (this.PaymentGatewaySecurityKey != null &&
                    this.PaymentGatewaySecurityKey.Equals(input.PaymentGatewaySecurityKey))
                ) && 
                (
                    this.PaytrDirectApiEnabled == input.PaytrDirectApiEnabled ||
                    (this.PaytrDirectApiEnabled != null &&
                    this.PaytrDirectApiEnabled.Equals(input.PaytrDirectApiEnabled))
                ) && 
                (
                    this.PaytrMerchantId == input.PaytrMerchantId ||
                    (this.PaytrMerchantId != null &&
                    this.PaytrMerchantId.Equals(input.PaytrMerchantId))
                ) && 
                (
                    this.PayuMerchantKeyRenewals == input.PayuMerchantKeyRenewals ||
                    (this.PayuMerchantKeyRenewals != null &&
                    this.PayuMerchantKeyRenewals.Equals(input.PayuMerchantKeyRenewals))
                ) && 
                (
                    this.PayuSecretKeyRenewals == input.PayuSecretKeyRenewals ||
                    (this.PayuSecretKeyRenewals != null &&
                    this.PayuSecretKeyRenewals.Equals(input.PayuSecretKeyRenewals))
                ) && 
                (
                    this.PrivacyPolicyUrl == input.PrivacyPolicyUrl ||
                    (this.PrivacyPolicyUrl != null &&
                    this.PrivacyPolicyUrl.Equals(input.PrivacyPolicyUrl))
                ) && 
                (
                    this.SendDailyReports == input.SendDailyReports ||
                    (this.SendDailyReports != null &&
                    this.SendDailyReports.Equals(input.SendDailyReports))
                ) && 
                (
                    this.SubscreasyApiKey == input.SubscreasyApiKey ||
                    (this.SubscreasyApiKey != null &&
                    this.SubscreasyApiKey.Equals(input.SubscreasyApiKey))
                ) && 
                (
                    this.SubscreasySecureKey == input.SubscreasySecureKey ||
                    (this.SubscreasySecureKey != null &&
                    this.SubscreasySecureKey.Equals(input.SubscreasySecureKey))
                ) && 
                (
                    this.WirecardErrorMessage == input.WirecardErrorMessage ||
                    (this.WirecardErrorMessage != null &&
                    this.WirecardErrorMessage.Equals(input.WirecardErrorMessage))
                ) && 
                (
                    this.WirecardPin == input.WirecardPin ||
                    (this.WirecardPin != null &&
                    this.WirecardPin.Equals(input.WirecardPin))
                ) && 
                (
                    this.WirecardSuccessfulMessage == input.WirecardSuccessfulMessage ||
                    (this.WirecardSuccessfulMessage != null &&
                    this.WirecardSuccessfulMessage.Equals(input.WirecardSuccessfulMessage))
                ) && 
                (
                    this.WirecardTurkcellServisId == input.WirecardTurkcellServisId ||
                    (this.WirecardTurkcellServisId != null &&
                    this.WirecardTurkcellServisId.Equals(input.WirecardTurkcellServisId))
                ) && 
                (
                    this.WirecardUserCode == input.WirecardUserCode ||
                    (this.WirecardUserCode != null &&
                    this.WirecardUserCode.Equals(input.WirecardUserCode))
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
                if (this.BillingDate != null)
                    hashCode = hashCode * 59 + this.BillingDate.GetHashCode();
                if (this.BillingInformationMandatory != null)
                    hashCode = hashCode * 59 + this.BillingInformationMandatory.GetHashCode();
                if (this.BillingThresholdDays != null)
                    hashCode = hashCode * 59 + this.BillingThresholdDays.GetHashCode();
                if (this.Branding != null)
                    hashCode = hashCode * 59 + this.Branding.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.HostedPageCSSPath != null)
                    hashCode = hashCode * 59 + this.HostedPageCSSPath.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LogoPath != null)
                    hashCode = hashCode * 59 + this.LogoPath.GetHashCode();
                if (this.MobilExpressApiPassword != null)
                    hashCode = hashCode * 59 + this.MobilExpressApiPassword.GetHashCode();
                if (this.MobilExpressMerchantKey != null)
                    hashCode = hashCode * 59 + this.MobilExpressMerchantKey.GetHashCode();
                if (this.MobilExpressPosid != null)
                    hashCode = hashCode * 59 + this.MobilExpressPosid.GetHashCode();
                if (this.MobilePaymentGateway != null)
                    hashCode = hashCode * 59 + this.MobilePaymentGateway.GetHashCode();
                if (this.NotifyNewSubscription != null)
                    hashCode = hashCode * 59 + this.NotifyNewSubscription.GetHashCode();
                if (this.NotifyRenewal != null)
                    hashCode = hashCode * 59 + this.NotifyRenewal.GetHashCode();
                if (this.NotifySubscriptionCancellation != null)
                    hashCode = hashCode * 59 + this.NotifySubscriptionCancellation.GetHashCode();
                if (this.PaymentGateway != null)
                    hashCode = hashCode * 59 + this.PaymentGateway.GetHashCode();
                if (this.PaymentGatewayApiKey != null)
                    hashCode = hashCode * 59 + this.PaymentGatewayApiKey.GetHashCode();
                if (this.PaymentGatewaySecurityKey != null)
                    hashCode = hashCode * 59 + this.PaymentGatewaySecurityKey.GetHashCode();
                if (this.PaytrDirectApiEnabled != null)
                    hashCode = hashCode * 59 + this.PaytrDirectApiEnabled.GetHashCode();
                if (this.PaytrMerchantId != null)
                    hashCode = hashCode * 59 + this.PaytrMerchantId.GetHashCode();
                if (this.PayuMerchantKeyRenewals != null)
                    hashCode = hashCode * 59 + this.PayuMerchantKeyRenewals.GetHashCode();
                if (this.PayuSecretKeyRenewals != null)
                    hashCode = hashCode * 59 + this.PayuSecretKeyRenewals.GetHashCode();
                if (this.PrivacyPolicyUrl != null)
                    hashCode = hashCode * 59 + this.PrivacyPolicyUrl.GetHashCode();
                if (this.SendDailyReports != null)
                    hashCode = hashCode * 59 + this.SendDailyReports.GetHashCode();
                if (this.SubscreasyApiKey != null)
                    hashCode = hashCode * 59 + this.SubscreasyApiKey.GetHashCode();
                if (this.SubscreasySecureKey != null)
                    hashCode = hashCode * 59 + this.SubscreasySecureKey.GetHashCode();
                if (this.WirecardErrorMessage != null)
                    hashCode = hashCode * 59 + this.WirecardErrorMessage.GetHashCode();
                if (this.WirecardPin != null)
                    hashCode = hashCode * 59 + this.WirecardPin.GetHashCode();
                if (this.WirecardSuccessfulMessage != null)
                    hashCode = hashCode * 59 + this.WirecardSuccessfulMessage.GetHashCode();
                if (this.WirecardTurkcellServisId != null)
                    hashCode = hashCode * 59 + this.WirecardTurkcellServisId.GetHashCode();
                if (this.WirecardUserCode != null)
                    hashCode = hashCode * 59 + this.WirecardUserCode.GetHashCode();
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
