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
        /// <param name="dateTo">dateTo (required).</param>
        /// <param name="orderMin">orderMin (required).</param>
        /// <param name="multiplicity">multiplicity (required).</param>
        /// <param name="discount">discount (required).</param>
        /// <param name="bonus">bonus (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="priceWithVAT">priceWithVAT (required).</param>
        /// <param name="vat">vat (required).</param>
        public Offer(DateTime dateTo = default(DateTime), int orderMin = default(int), int multiplicity = default(int), decimal discount = default(decimal), decimal bonus = default(decimal), decimal price = default(decimal), decimal priceWithVAT = default(decimal), decimal vat = default(decimal))
        {
            // to ensure "dateTo" is required (not null)
            if (dateTo == null)
            {
                throw new InvalidDataException("dateTo is a required property for Offer and cannot be null");
            }
            else
            {
                this.DateTo = dateTo;
            }

            // to ensure "orderMin" is required (not null)
            if (orderMin == null)
            {
                throw new InvalidDataException("orderMin is a required property for Offer and cannot be null");
            }
            else
            {
                this.OrderMin = orderMin;
            }

            // to ensure "multiplicity" is required (not null)
            if (multiplicity == null)
            {
                throw new InvalidDataException("multiplicity is a required property for Offer and cannot be null");
            }
            else
            {
                this.Multiplicity = multiplicity;
            }

            // to ensure "discount" is required (not null)
            if (discount == null)
            {
                throw new InvalidDataException("discount is a required property for Offer and cannot be null");
            }
            else
            {
                this.Discount = discount;
            }

            // to ensure "bonus" is required (not null)
            if (bonus == null)
            {
                throw new InvalidDataException("bonus is a required property for Offer and cannot be null");
            }
            else
            {
                this.Bonus = bonus;
            }

            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for Offer and cannot be null");
            }
            else
            {
                this.Price = price;
            }

            // to ensure "priceWithVAT" is required (not null)
            if (priceWithVAT == null)
            {
                throw new InvalidDataException("priceWithVAT is a required property for Offer and cannot be null");
            }
            else
            {
                this.PriceWithVAT = priceWithVAT;
            }

            // to ensure "vat" is required (not null)
            if (vat == null)
            {
                throw new InvalidDataException("vat is a required property for Offer and cannot be null");
            }
            else
            {
                this.Vat = vat;
            }

        }

        /// <summary>
        /// Gets or Sets DateTo
        /// </summary>
        [DataMember(Name="date_to", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Gets or Sets OrderMin
        /// </summary>
        [DataMember(Name="order_min", EmitDefaultValue=true)]
        public int OrderMin { get; set; }

        /// <summary>
        /// Gets or Sets Multiplicity
        /// </summary>
        [DataMember(Name="multiplicity", EmitDefaultValue=true)]
        public int Multiplicity { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=true)]
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or Sets Bonus
        /// </summary>
        [DataMember(Name="bonus", EmitDefaultValue=true)]
        public decimal Bonus { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=true)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets PriceWithVAT
        /// </summary>
        [DataMember(Name="price_with_VAT", EmitDefaultValue=true)]
        public decimal PriceWithVAT { get; set; }

        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name="vat", EmitDefaultValue=true)]
        public decimal Vat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Offer {\n");
            sb.Append("  DateTo: ").Append(DateTo).Append("\n");
            sb.Append("  OrderMin: ").Append(OrderMin).Append("\n");
            sb.Append("  Multiplicity: ").Append(Multiplicity).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Bonus: ").Append(Bonus).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceWithVAT: ").Append(PriceWithVAT).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
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
                    this.DateTo == input.DateTo ||
                    (this.DateTo != null &&
                    this.DateTo.Equals(input.DateTo))
                ) && 
                (
                    this.OrderMin == input.OrderMin ||
                    (this.OrderMin != null &&
                    this.OrderMin.Equals(input.OrderMin))
                ) && 
                (
                    this.Multiplicity == input.Multiplicity ||
                    (this.Multiplicity != null &&
                    this.Multiplicity.Equals(input.Multiplicity))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.Bonus == input.Bonus ||
                    (this.Bonus != null &&
                    this.Bonus.Equals(input.Bonus))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PriceWithVAT == input.PriceWithVAT ||
                    (this.PriceWithVAT != null &&
                    this.PriceWithVAT.Equals(input.PriceWithVAT))
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
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
                if (this.DateTo != null)
                    hashCode = hashCode * 59 + this.DateTo.GetHashCode();
                if (this.OrderMin != null)
                    hashCode = hashCode * 59 + this.OrderMin.GetHashCode();
                if (this.Multiplicity != null)
                    hashCode = hashCode * 59 + this.Multiplicity.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Bonus != null)
                    hashCode = hashCode * 59 + this.Bonus.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceWithVAT != null)
                    hashCode = hashCode * 59 + this.PriceWithVAT.GetHashCode();
                if (this.Vat != null)
                    hashCode = hashCode * 59 + this.Vat.GetHashCode();
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
