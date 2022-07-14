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
    /// ResponseOrder
    /// </summary>
    [DataContract]
    public partial class ResponseOrder :  IEquatable<ResponseOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOrder" /> class.
        /// </summary>
        /// <param name="orderId">orderId (required).</param>
        /// <param name="orderCode">orderCode (required).</param>
        /// <param name="distributorOrderId">distributorOrderId (required).</param>
        /// <param name="statusDelivery">statusDelivery (required).</param>
        /// <param name="delayedItems">delayedItems (required).</param>
        public ResponseOrder(int orderId = default(int), string orderCode = default(string), string distributorOrderId = default(string), string statusDelivery = default(string), List<ResponseOrderItem> delayedItems = default(List<ResponseOrderItem>))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for ResponseOrder and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }

            // to ensure "orderCode" is required (not null)
            if (orderCode == null)
            {
                throw new InvalidDataException("orderCode is a required property for ResponseOrder and cannot be null");
            }
            else
            {
                this.OrderCode = orderCode;
            }

            // to ensure "distributorOrderId" is required (not null)
            if (distributorOrderId == null)
            {
                throw new InvalidDataException("distributorOrderId is a required property for ResponseOrder and cannot be null");
            }
            else
            {
                this.DistributorOrderId = distributorOrderId;
            }

            // to ensure "statusDelivery" is required (not null)
            if (statusDelivery == null)
            {
                throw new InvalidDataException("statusDelivery is a required property for ResponseOrder and cannot be null");
            }
            else
            {
                this.StatusDelivery = statusDelivery;
            }

            // to ensure "delayedItems" is required (not null)
            if (delayedItems == null)
            {
                throw new InvalidDataException("delayedItems is a required property for ResponseOrder and cannot be null");
            }
            else
            {
                this.DelayedItems = delayedItems;
            }

        }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="order_id", EmitDefaultValue=true)]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderCode
        /// </summary>
        [DataMember(Name="order_code", EmitDefaultValue=true)]
        public string OrderCode { get; set; }

        /// <summary>
        /// Gets or Sets DistributorOrderId
        /// </summary>
        [DataMember(Name="distributor_order_id", EmitDefaultValue=true)]
        public string DistributorOrderId { get; set; }

        /// <summary>
        /// Gets or Sets StatusDelivery
        /// </summary>
        [DataMember(Name="status_delivery", EmitDefaultValue=true)]
        public string StatusDelivery { get; set; }

        /// <summary>
        /// Gets or Sets DelayedItems
        /// </summary>
        [DataMember(Name="delayed_items", EmitDefaultValue=true)]
        public List<ResponseOrderItem> DelayedItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseOrder {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderCode: ").Append(OrderCode).Append("\n");
            sb.Append("  DistributorOrderId: ").Append(DistributorOrderId).Append("\n");
            sb.Append("  StatusDelivery: ").Append(StatusDelivery).Append("\n");
            sb.Append("  DelayedItems: ").Append(DelayedItems).Append("\n");
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
            return this.Equals(input as ResponseOrder);
        }

        /// <summary>
        /// Returns true if ResponseOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderCode == input.OrderCode ||
                    (this.OrderCode != null &&
                    this.OrderCode.Equals(input.OrderCode))
                ) && 
                (
                    this.DistributorOrderId == input.DistributorOrderId ||
                    (this.DistributorOrderId != null &&
                    this.DistributorOrderId.Equals(input.DistributorOrderId))
                ) && 
                (
                    this.StatusDelivery == input.StatusDelivery ||
                    (this.StatusDelivery != null &&
                    this.StatusDelivery.Equals(input.StatusDelivery))
                ) && 
                (
                    this.DelayedItems == input.DelayedItems ||
                    this.DelayedItems != null &&
                    input.DelayedItems != null &&
                    this.DelayedItems.SequenceEqual(input.DelayedItems)
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderCode != null)
                    hashCode = hashCode * 59 + this.OrderCode.GetHashCode();
                if (this.DistributorOrderId != null)
                    hashCode = hashCode * 59 + this.DistributorOrderId.GetHashCode();
                if (this.StatusDelivery != null)
                    hashCode = hashCode * 59 + this.StatusDelivery.GetHashCode();
                if (this.DelayedItems != null)
                    hashCode = hashCode * 59 + this.DelayedItems.GetHashCode();
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

            // OrderCode (string) minLength
            if(this.OrderCode != null && this.OrderCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderCode, length must be greater than 1.", new [] { "OrderCode" });
            }


            // DistributorOrderId (string) minLength
            if(this.DistributorOrderId != null && this.DistributorOrderId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistributorOrderId, length must be greater than 1.", new [] { "DistributorOrderId" });
            }


            // StatusDelivery (string) minLength
            if(this.StatusDelivery != null && this.StatusDelivery.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusDelivery, length must be greater than 1.", new [] { "StatusDelivery" });
            }

            yield break;
        }
    }

}
