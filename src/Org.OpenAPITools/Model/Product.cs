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
    /// Product
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Product() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="uniqueId">uniqueId (required).</param>
        /// <param name="productId">productId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="ean">ean (required).</param>
        /// <param name="gtin">gtin (required).</param>
        /// <param name="vat">vat (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="priceWithVAT">priceWithVAT (required).</param>
        /// <param name="distributorId">distributorId (required).</param>
        /// <param name="expirationDate">expirationDate (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="minOrder">minOrder (required).</param>
        /// <param name="multiplicity">multiplicity (required).</param>
        /// <param name="bonus">bonus (required).</param>
        /// <param name="discount">discount (required).</param>
        /// <param name="potentialPriceWithOffers">potentialPriceWithOffers.</param>
        /// <param name="isOffer">isOffer (required).</param>
        /// <param name="bonusMaxMonthOrderAmount">bonusMaxMonthOrderAmount.</param>
        /// <param name="potentialPriceTotal">potentialPriceTotal.</param>
        /// <param name="manufacturer">manufacturer (required).</param>
        public Product(string uniqueId = default(string), int productId = default(int), string name = default(string), string ean = default(string), string gtin = default(string), decimal vat = default(decimal), decimal price = default(decimal), decimal priceWithVAT = default(decimal), int distributorId = default(int), DateTime expirationDate = default(DateTime), int quantity = default(int), int minOrder = default(int), int multiplicity = default(int), decimal bonus = default(decimal), decimal discount = default(decimal), decimal potentialPriceWithOffers = default(decimal), bool isOffer = default(bool), decimal bonusMaxMonthOrderAmount = default(decimal), decimal potentialPriceTotal = default(decimal), string manufacturer = default(string))
        {
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new InvalidDataException("uniqueId is a required property for Product and cannot be null");
            }
            else
            {
                this.UniqueId = uniqueId;
            }

            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for Product and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Product and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "ean" is required (not null)
            if (ean == null)
            {
                throw new InvalidDataException("ean is a required property for Product and cannot be null");
            }
            else
            {
                this.Ean = ean;
            }

            // to ensure "gtin" is required (not null)
            if (gtin == null)
            {
                throw new InvalidDataException("gtin is a required property for Product and cannot be null");
            }
            else
            {
                this.Gtin = gtin;
            }

            // to ensure "vat" is required (not null)
            if (vat == null)
            {
                throw new InvalidDataException("vat is a required property for Product and cannot be null");
            }
            else
            {
                this.Vat = vat;
            }

            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for Product and cannot be null");
            }
            else
            {
                this.Price = price;
            }

            // to ensure "priceWithVAT" is required (not null)
            if (priceWithVAT == null)
            {
                throw new InvalidDataException("priceWithVAT is a required property for Product and cannot be null");
            }
            else
            {
                this.PriceWithVAT = priceWithVAT;
            }

            // to ensure "distributorId" is required (not null)
            if (distributorId == null)
            {
                throw new InvalidDataException("distributorId is a required property for Product and cannot be null");
            }
            else
            {
                this.DistributorId = distributorId;
            }

            // to ensure "expirationDate" is required (not null)
            if (expirationDate == null)
            {
                throw new InvalidDataException("expirationDate is a required property for Product and cannot be null");
            }
            else
            {
                this.ExpirationDate = expirationDate;
            }

            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for Product and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }

            // to ensure "minOrder" is required (not null)
            if (minOrder == null)
            {
                throw new InvalidDataException("minOrder is a required property for Product and cannot be null");
            }
            else
            {
                this.MinOrder = minOrder;
            }

            // to ensure "multiplicity" is required (not null)
            if (multiplicity == null)
            {
                throw new InvalidDataException("multiplicity is a required property for Product and cannot be null");
            }
            else
            {
                this.Multiplicity = multiplicity;
            }

            // to ensure "bonus" is required (not null)
            if (bonus == null)
            {
                throw new InvalidDataException("bonus is a required property for Product and cannot be null");
            }
            else
            {
                this.Bonus = bonus;
            }

            // to ensure "discount" is required (not null)
            if (discount == null)
            {
                throw new InvalidDataException("discount is a required property for Product and cannot be null");
            }
            else
            {
                this.Discount = discount;
            }

            // to ensure "isOffer" is required (not null)
            if (isOffer == null)
            {
                throw new InvalidDataException("isOffer is a required property for Product and cannot be null");
            }
            else
            {
                this.IsOffer = isOffer;
            }

            // to ensure "manufacturer" is required (not null)
            if (manufacturer == null)
            {
                throw new InvalidDataException("manufacturer is a required property for Product and cannot be null");
            }
            else
            {
                this.Manufacturer = manufacturer;
            }

            this.PotentialPriceWithOffers = potentialPriceWithOffers;
            this.BonusMaxMonthOrderAmount = bonusMaxMonthOrderAmount;
            this.PotentialPriceTotal = potentialPriceTotal;
        }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="unique_id", EmitDefaultValue=true)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="product_id", EmitDefaultValue=true)]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Ean
        /// </summary>
        [DataMember(Name="ean", EmitDefaultValue=true)]
        public string Ean { get; set; }

        /// <summary>
        /// Gets or Sets Gtin
        /// </summary>
        [DataMember(Name="gtin", EmitDefaultValue=true)]
        public string Gtin { get; set; }

        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name="vat", EmitDefaultValue=true)]
        public decimal Vat { get; set; }

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
        /// Gets or Sets DistributorId
        /// </summary>
        [DataMember(Name="distributor_id", EmitDefaultValue=true)]
        public int DistributorId { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expiration_date", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets MinOrder
        /// </summary>
        [DataMember(Name="min_order", EmitDefaultValue=true)]
        public int MinOrder { get; set; }

        /// <summary>
        /// Gets or Sets Multiplicity
        /// </summary>
        [DataMember(Name="multiplicity", EmitDefaultValue=true)]
        public int Multiplicity { get; set; }

        /// <summary>
        /// Gets or Sets Bonus
        /// </summary>
        [DataMember(Name="bonus", EmitDefaultValue=true)]
        public decimal Bonus { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=true)]
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or Sets PotentialPriceWithOffers
        /// </summary>
        [DataMember(Name="potential_price_with_offers", EmitDefaultValue=false)]
        public decimal PotentialPriceWithOffers { get; set; }

        /// <summary>
        /// Gets or Sets IsOffer
        /// </summary>
        [DataMember(Name="is_offer", EmitDefaultValue=true)]
        public bool IsOffer { get; set; }

        /// <summary>
        /// Gets or Sets BonusMaxMonthOrderAmount
        /// </summary>
        [DataMember(Name="bonus_max_month_order_amount", EmitDefaultValue=false)]
        public decimal BonusMaxMonthOrderAmount { get; set; }

        /// <summary>
        /// Gets or Sets PotentialPriceTotal
        /// </summary>
        [DataMember(Name="potential_price_total", EmitDefaultValue=false)]
        public decimal PotentialPriceTotal { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=true)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceWithVAT: ").Append(PriceWithVAT).Append("\n");
            sb.Append("  DistributorId: ").Append(DistributorId).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  MinOrder: ").Append(MinOrder).Append("\n");
            sb.Append("  Multiplicity: ").Append(Multiplicity).Append("\n");
            sb.Append("  Bonus: ").Append(Bonus).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  PotentialPriceWithOffers: ").Append(PotentialPriceWithOffers).Append("\n");
            sb.Append("  IsOffer: ").Append(IsOffer).Append("\n");
            sb.Append("  BonusMaxMonthOrderAmount: ").Append(BonusMaxMonthOrderAmount).Append("\n");
            sb.Append("  PotentialPriceTotal: ").Append(PotentialPriceTotal).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ean == input.Ean ||
                    (this.Ean != null &&
                    this.Ean.Equals(input.Ean))
                ) && 
                (
                    this.Gtin == input.Gtin ||
                    (this.Gtin != null &&
                    this.Gtin.Equals(input.Gtin))
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
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
                    this.DistributorId == input.DistributorId ||
                    (this.DistributorId != null &&
                    this.DistributorId.Equals(input.DistributorId))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.MinOrder == input.MinOrder ||
                    (this.MinOrder != null &&
                    this.MinOrder.Equals(input.MinOrder))
                ) && 
                (
                    this.Multiplicity == input.Multiplicity ||
                    (this.Multiplicity != null &&
                    this.Multiplicity.Equals(input.Multiplicity))
                ) && 
                (
                    this.Bonus == input.Bonus ||
                    (this.Bonus != null &&
                    this.Bonus.Equals(input.Bonus))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.PotentialPriceWithOffers == input.PotentialPriceWithOffers ||
                    (this.PotentialPriceWithOffers != null &&
                    this.PotentialPriceWithOffers.Equals(input.PotentialPriceWithOffers))
                ) && 
                (
                    this.IsOffer == input.IsOffer ||
                    (this.IsOffer != null &&
                    this.IsOffer.Equals(input.IsOffer))
                ) && 
                (
                    this.BonusMaxMonthOrderAmount == input.BonusMaxMonthOrderAmount ||
                    (this.BonusMaxMonthOrderAmount != null &&
                    this.BonusMaxMonthOrderAmount.Equals(input.BonusMaxMonthOrderAmount))
                ) && 
                (
                    this.PotentialPriceTotal == input.PotentialPriceTotal ||
                    (this.PotentialPriceTotal != null &&
                    this.PotentialPriceTotal.Equals(input.PotentialPriceTotal))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
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
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ean != null)
                    hashCode = hashCode * 59 + this.Ean.GetHashCode();
                if (this.Gtin != null)
                    hashCode = hashCode * 59 + this.Gtin.GetHashCode();
                if (this.Vat != null)
                    hashCode = hashCode * 59 + this.Vat.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceWithVAT != null)
                    hashCode = hashCode * 59 + this.PriceWithVAT.GetHashCode();
                if (this.DistributorId != null)
                    hashCode = hashCode * 59 + this.DistributorId.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.MinOrder != null)
                    hashCode = hashCode * 59 + this.MinOrder.GetHashCode();
                if (this.Multiplicity != null)
                    hashCode = hashCode * 59 + this.Multiplicity.GetHashCode();
                if (this.Bonus != null)
                    hashCode = hashCode * 59 + this.Bonus.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.PotentialPriceWithOffers != null)
                    hashCode = hashCode * 59 + this.PotentialPriceWithOffers.GetHashCode();
                if (this.IsOffer != null)
                    hashCode = hashCode * 59 + this.IsOffer.GetHashCode();
                if (this.BonusMaxMonthOrderAmount != null)
                    hashCode = hashCode * 59 + this.BonusMaxMonthOrderAmount.GetHashCode();
                if (this.PotentialPriceTotal != null)
                    hashCode = hashCode * 59 + this.PotentialPriceTotal.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
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

            // UniqueId (string) minLength
            if(this.UniqueId != null && this.UniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UniqueId, length must be greater than 1.", new [] { "UniqueId" });
            }


            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }


            // Ean (string) minLength
            if(this.Ean != null && this.Ean.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ean, length must be greater than 1.", new [] { "Ean" });
            }


            // Gtin (string) minLength
            if(this.Gtin != null && this.Gtin.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Gtin, length must be greater than 1.", new [] { "Gtin" });
            }


            // Manufacturer (string) minLength
            if(this.Manufacturer != null && this.Manufacturer.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Manufacturer, length must be greater than 1.", new [] { "Manufacturer" });
            }

            yield break;
        }
    }

}
