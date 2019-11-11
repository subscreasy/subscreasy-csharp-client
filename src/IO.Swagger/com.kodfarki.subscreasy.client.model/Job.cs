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
    /// Job
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>, IValidatableObject
    {
        /// <summary>
        /// Defines ExecutionStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExecutionStatusEnum
        {
            
            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW = 1,
            
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            [EnumMember(Value = "WAITING")]
            WAITING = 2,
            
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 3,
            
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 4,
            
            /// <summary>
            /// Enum FINISHED for value: FINISHED
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED = 5,
            
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 6,
            
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 7,
            
            /// <summary>
            /// Enum EXPIRED for value: EXPIRED
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED = 8
        }

        /// <summary>
        /// Gets or Sets ExecutionStatus
        /// </summary>
        [DataMember(Name="executionStatus", EmitDefaultValue=false)]
        public ExecutionStatusEnum? ExecutionStatus { get; set; }
        /// <summary>
        /// Defines WorkflowId
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WorkflowIdEnum
        {
            
            /// <summary>
            /// Enum CHARGING for value: CHARGING
            /// </summary>
            [EnumMember(Value = "CHARGING")]
            CHARGING = 1,
            
            /// <summary>
            /// Enum NOTIFY for value: NOTIFY
            /// </summary>
            [EnumMember(Value = "NOTIFY")]
            NOTIFY = 2,
            
            /// <summary>
            /// Enum TERMINATION for value: TERMINATION
            /// </summary>
            [EnumMember(Value = "TERMINATION")]
            TERMINATION = 3,
            
            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY = 4,
            
            /// <summary>
            /// Enum OFFLINEPAYMENTCHECK for value: OFFLINE_PAYMENT_CHECK
            /// </summary>
            [EnumMember(Value = "OFFLINE_PAYMENT_CHECK")]
            OFFLINEPAYMENTCHECK = 5
        }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public WorkflowIdEnum? WorkflowId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="ActivityId">ActivityId.</param>
        /// <param name="Company">Company.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="DetailProps">DetailProps.</param>
        /// <param name="Details">Details.</param>
        /// <param name="ExecutionCount">ExecutionCount.</param>
        /// <param name="ExecutionDate">ExecutionDate.</param>
        /// <param name="ExecutionStatus">ExecutionStatus.</param>
        /// <param name="FirstExecutionDate">FirstExecutionDate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="RetryDate">RetryDate.</param>
        /// <param name="RetryRequired">RetryRequired.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="WorkflowId">WorkflowId.</param>
        public Job(int? ActivityId = default(int?), Company Company = default(Company), DateTime? CreateDate = default(DateTime?), Dictionary<string, Object> DetailProps = default(Dictionary<string, Object>), string Details = default(string), int? ExecutionCount = default(int?), DateTime? ExecutionDate = default(DateTime?), ExecutionStatusEnum? ExecutionStatus = default(ExecutionStatusEnum?), DateTime? FirstExecutionDate = default(DateTime?), long? Id = default(long?), DateTime? ModifyDate = default(DateTime?), int? Priority = default(int?), DateTime? RetryDate = default(DateTime?), bool? RetryRequired = default(bool?), Subsription Subscription = default(Subsription), WorkflowIdEnum? WorkflowId = default(WorkflowIdEnum?))
        {
            this.ActivityId = ActivityId;
            this.Company = Company;
            this.CreateDate = CreateDate;
            this.DetailProps = DetailProps;
            this.Details = Details;
            this.ExecutionCount = ExecutionCount;
            this.ExecutionDate = ExecutionDate;
            this.ExecutionStatus = ExecutionStatus;
            this.FirstExecutionDate = FirstExecutionDate;
            this.Id = Id;
            this.ModifyDate = ModifyDate;
            this.Priority = Priority;
            this.RetryDate = RetryDate;
            this.RetryRequired = RetryRequired;
            this.Subscription = Subscription;
            this.WorkflowId = WorkflowId;
        }
        
        /// <summary>
        /// Gets or Sets ActivityId
        /// </summary>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public int? ActivityId { get; set; }

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
        /// Gets or Sets DetailProps
        /// </summary>
        [DataMember(Name="detailProps", EmitDefaultValue=false)]
        public Dictionary<string, Object> DetailProps { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionCount
        /// </summary>
        [DataMember(Name="executionCount", EmitDefaultValue=false)]
        public int? ExecutionCount { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionDate
        /// </summary>
        [DataMember(Name="executionDate", EmitDefaultValue=false)]
        public DateTime? ExecutionDate { get; set; }


        /// <summary>
        /// Gets or Sets FirstExecutionDate
        /// </summary>
        [DataMember(Name="firstExecutionDate", EmitDefaultValue=false)]
        public DateTime? FirstExecutionDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets RetryDate
        /// </summary>
        [DataMember(Name="retryDate", EmitDefaultValue=false)]
        public DateTime? RetryDate { get; set; }

        /// <summary>
        /// Gets or Sets RetryRequired
        /// </summary>
        [DataMember(Name="retryRequired", EmitDefaultValue=false)]
        public bool? RetryRequired { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subsription Subscription { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  DetailProps: ").Append(DetailProps).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ExecutionCount: ").Append(ExecutionCount).Append("\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
            sb.Append("  ExecutionStatus: ").Append(ExecutionStatus).Append("\n");
            sb.Append("  FirstExecutionDate: ").Append(FirstExecutionDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  RetryDate: ").Append(RetryDate).Append("\n");
            sb.Append("  RetryRequired: ").Append(RetryRequired).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
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
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
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
                    this.DetailProps == input.DetailProps ||
                    this.DetailProps != null &&
                    this.DetailProps.SequenceEqual(input.DetailProps)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.ExecutionCount == input.ExecutionCount ||
                    (this.ExecutionCount != null &&
                    this.ExecutionCount.Equals(input.ExecutionCount))
                ) && 
                (
                    this.ExecutionDate == input.ExecutionDate ||
                    (this.ExecutionDate != null &&
                    this.ExecutionDate.Equals(input.ExecutionDate))
                ) && 
                (
                    this.ExecutionStatus == input.ExecutionStatus ||
                    (this.ExecutionStatus != null &&
                    this.ExecutionStatus.Equals(input.ExecutionStatus))
                ) && 
                (
                    this.FirstExecutionDate == input.FirstExecutionDate ||
                    (this.FirstExecutionDate != null &&
                    this.FirstExecutionDate.Equals(input.FirstExecutionDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.RetryDate == input.RetryDate ||
                    (this.RetryDate != null &&
                    this.RetryDate.Equals(input.RetryDate))
                ) && 
                (
                    this.RetryRequired == input.RetryRequired ||
                    (this.RetryRequired != null &&
                    this.RetryRequired.Equals(input.RetryRequired))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
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
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.DetailProps != null)
                    hashCode = hashCode * 59 + this.DetailProps.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.ExecutionCount != null)
                    hashCode = hashCode * 59 + this.ExecutionCount.GetHashCode();
                if (this.ExecutionDate != null)
                    hashCode = hashCode * 59 + this.ExecutionDate.GetHashCode();
                if (this.ExecutionStatus != null)
                    hashCode = hashCode * 59 + this.ExecutionStatus.GetHashCode();
                if (this.FirstExecutionDate != null)
                    hashCode = hashCode * 59 + this.FirstExecutionDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RetryDate != null)
                    hashCode = hashCode * 59 + this.RetryDate.GetHashCode();
                if (this.RetryRequired != null)
                    hashCode = hashCode * 59 + this.RetryRequired.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
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
