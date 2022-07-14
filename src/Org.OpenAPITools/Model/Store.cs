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
    /// Store
    /// </summary>
    [DataContract]
    public partial class Store :  IEquatable<Store>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Store() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        /// <param name="storeId">storeId (required).</param>
        /// <param name="storeName">storeName (required).</param>
        /// <param name="storeAddress">storeAddress (required).</param>
        public Store(int storeId = default(int), string storeName = default(string), string storeAddress = default(string))
        {
            // to ensure "storeId" is required (not null)
            if (storeId == null)
            {
                throw new InvalidDataException("storeId is a required property for Store and cannot be null");
            }
            else
            {
                this.StoreId = storeId;
            }

            // to ensure "storeName" is required (not null)
            if (storeName == null)
            {
                throw new InvalidDataException("storeName is a required property for Store and cannot be null");
            }
            else
            {
                this.StoreName = storeName;
            }

            // to ensure "storeAddress" is required (not null)
            if (storeAddress == null)
            {
                throw new InvalidDataException("storeAddress is a required property for Store and cannot be null");
            }
            else
            {
                this.StoreAddress = storeAddress;
            }

        }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="store_id", EmitDefaultValue=true)]
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or Sets StoreName
        /// </summary>
        [DataMember(Name="store_name", EmitDefaultValue=true)]
        public string StoreName { get; set; }

        /// <summary>
        /// Gets or Sets StoreAddress
        /// </summary>
        [DataMember(Name="store_address", EmitDefaultValue=true)]
        public string StoreAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Store {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  StoreAddress: ").Append(StoreAddress).Append("\n");
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
            return this.Equals(input as Store);
        }

        /// <summary>
        /// Returns true if Store instances are equal
        /// </summary>
        /// <param name="input">Instance of Store to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Store input)
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
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.StoreAddress == input.StoreAddress ||
                    (this.StoreAddress != null &&
                    this.StoreAddress.Equals(input.StoreAddress))
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
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.StoreAddress != null)
                    hashCode = hashCode * 59 + this.StoreAddress.GetHashCode();
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

            // StoreName (string) minLength
            if(this.StoreName != null && this.StoreName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreName, length must be greater than 1.", new [] { "StoreName" });
            }


            // StoreAddress (string) minLength
            if(this.StoreAddress != null && this.StoreAddress.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreAddress, length must be greater than 1.", new [] { "StoreAddress" });
            }

            yield break;
        }
    }

}
