# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://pharm-zakaz.ru/api/v2/private*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DistributorsList**](DefaultApi.md#distributorslist) | **GET** /distributors/ | Получение списка дистрибьюторов
[**OrderCreate**](DefaultApi.md#ordercreate) | **POST** /order/ | Размещение заказов в системе.
[**OrderRead**](DefaultApi.md#orderread) | **GET** /order/{id}/ | Получение детальной информации о заказе
[**OrdersList**](DefaultApi.md#orderslist) | **GET** /orders/ | Получение списка заказов
[**ProductsList**](DefaultApi.md#productslist) | **GET** /products/ | Получение списка доступных продуктов по id аптеки, id дистрибьютора и id продукта
[**StoresList**](DefaultApi.md#storeslist) | **GET** /stores/ | Получение списка аптек пользователя



## DistributorsList

> ListDistributors DistributorsList ()

Получение списка дистрибьюторов

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DistributorsListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://pharm-zakaz.ru/api/v2/private";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Получение списка дистрибьюторов
                ListDistributors result = apiInstance.DistributorsList();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.DistributorsList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ListDistributors**](ListDistributors.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **401** | Учетные данные не были предоставлены |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrderCreate

> ResponseOrder OrderCreate (CreateOrder data)

Размещение заказов в системе.

 Размещение заказов в системе. Минимальная сумма заказа с НДС 3000. Количество товаров в заказе может быть сниженно при недостатке его на складе, данные препараты будут помечены как отложенные в ответе. Тело запроса в формате json. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://pharm-zakaz.ru/api/v2/private";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var data = new CreateOrder(); // CreateOrder | 

            try
            {
                // Размещение заказов в системе.
                ResponseOrder result = apiInstance.OrderCreate(data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.OrderCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**CreateOrder**](CreateOrder.md)|  | 

### Return type

[**ResponseOrder**](ResponseOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **400** | Bad request |  -  |
| **401** | Учетные данные не были предоставлены |  -  |
| **403** | Сумма заказа меньше 3000, включая налоги |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrderRead

> DetailedOrder OrderRead (string id)

Получение детальной информации о заказе

Получение детальной информации о заказе

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://pharm-zakaz.ru/api/v2/private";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | 

            try
            {
                // Получение детальной информации о заказе
                DetailedOrder result = apiInstance.OrderRead(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.OrderRead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**DetailedOrder**](DetailedOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **401** | Учетные данные не были предоставлены. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrdersList

> Order OrdersList (int? orderId = null)

Получение списка заказов

 Чтобы получить детальную информацию о заказе, необходимо передать order_id в качестве query параметра.  Возможные значения status_delivery: new: Новый,  equipped: Укомплектован,  confirmed: Подтвержден,  assembly: Передан на сборку, blocked: Заблокирован,  sent: Отправлен,  delivered: Доставлен,  refund: Возврат,  canceled: Отменен.  Возможные значения status_pay:  paid: Оплачен,  expected: Ожидается,  due: Просрочен 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrdersListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://pharm-zakaz.ru/api/v2/private";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var orderId = 56;  // int? | id заказа (optional) 

            try
            {
                // Получение списка заказов
                Order result = apiInstance.OrdersList(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.OrdersList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| id заказа | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **401** | Учетные данные не были предоставлены. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ProductsList

> ProductList ProductsList (int? storeId = null, string uniqueId = null, int? distributorId = null)

Получение списка доступных продуктов по id аптеки, id дистрибьютора и id продукта

 Получение списка доступных продуктов по id аптеки, передаваемого как query параметра store_id, при передаче дополнительно query параметра distributor_id, список будет отфильтрован по требуемому дистрибьютору. Получение детальной информации о продукте, при передаче уникального id(получается из списка доступных продуктов) как query параметра unique_id.  Внимание! Доступные дистрибьюторы: id=1: Фармкомплект,  id=2: Протек  Поле price отображает цену товара без НДС, Поле price_with_VAT отображает цену товара, включая НДС, Поле potential_price_with_offers отображает потенциальную цену с учётом акций, руб.  

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductsListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://pharm-zakaz.ru/api/v2/private";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var storeId = 56;  // int? | id аптеки. Можно указать либо store_id либо unique_id. Оба параметра указывать недопустимо (optional) 
            var uniqueId = "uniqueId_example";  // string | id продукта (получается из списка доступных продуктов).  Можно указать либо store_id либо unique_id. Оба параметра указывать недопустимо (optional) 
            var distributorId = 56;  // int? | id дистрибьютора (optional) 

            try
            {
                // Получение списка доступных продуктов по id аптеки, id дистрибьютора и id продукта
                ProductList result = apiInstance.ProductsList(storeId, uniqueId, distributorId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| id аптеки. Можно указать либо store_id либо unique_id. Оба параметра указывать недопустимо | [optional] 
 **uniqueId** | **string**| id продукта (получается из списка доступных продуктов).  Можно указать либо store_id либо unique_id. Оба параметра указывать недопустимо | [optional] 
 **distributorId** | **int?**| id дистрибьютора | [optional] 

### Return type

[**ProductList**](ProductList.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **401** | Учетные данные не были предоставлены. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StoresList

> Store StoresList ()

Получение списка аптек пользователя

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StoresListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://pharm-zakaz.ru/api/v2/private";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Получение списка аптек пользователя
                Store result = apiInstance.StoresList();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.StoresList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**Store**](Store.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **401** | Учетные данные не были предоставлены. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

