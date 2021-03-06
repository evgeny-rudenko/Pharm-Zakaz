/*
 * API для аптечных сетей
 *
 * Авторизация по токену, используйте заголовок          Authorization: Bearer токен         пример:          Authorization: Bearer iJKLCJhbGciOiwIjoxN3MzM0zUw9zDuGk4-sYMmf9L_8WRU          Для того чтобы работать с API через интерфейс swagger (ниже, по кнопке Try it out),         нажмите кнопку Authorize и укажите токен в формате Bearer токен.         Пример: Bearer iJKLCJhbGciOiwIjoxN3MzM0zUw9zDuGk4-sYMmf9L_8WRU 
 *
 * The version of the OpenAPI document: v2
 * Contact: info@pharm-zakaz.ru
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CreateOrder
    /// </summary>
    [DataContract]
    public partial class CreateOrder :  IEquatable<CreateOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrder" /> class.
        /// </summary>
        /// <param name="storeId">storeId (required).</param>
        /// <param name="distributorId">distributorId (required).</param>
        /// <param name="items">items (required).</param>
        public CreateOrder(int storeId = default(int), int distributorId = default(int), List<CreateOrderItem> items = default(List<CreateOrderItem>))
        {
            // to ensure "storeId" is required (not null)
            if (storeId == null)
            {
                throw new InvalidDataException("storeId is a required property for CreateOrder and cannot be null");
            }
            else
            {
                this.StoreId = storeId;
            }

            // to ensure "distributorId" is required (not null)
            if (distributorId == null)
            {
                throw new InvalidDataException("distributorId is a required property for CreateOrder and cannot be null");
            }
            else
            {
                this.DistributorId = distributorId;
            }

            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for CreateOrder and cannot be null");
            }
            else
            {
                this.Items = items;
            }

        }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="store_id", EmitDefaultValue=true)]
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or Sets DistributorId
        /// </summary>
        [DataMember(Name="distributor_id", EmitDefaultValue=true)]
        public int DistributorId { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<CreateOrderItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrder {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  DistributorId: ").Append(DistributorId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrder);
        }

        /// <summary>
        /// Returns true if CreateOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.DistributorId == input.DistributorId ||
                    (this.DistributorId != null &&
                    this.DistributorId.Equals(input.DistributorId))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.DistributorId != null)
                    hashCode = hashCode * 59 + this.DistributorId.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
