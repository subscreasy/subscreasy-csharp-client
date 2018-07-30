# IO.Swagger.com.kodfarki.subscreasy.client.OrderItemResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrderItemUsingPOST**](OrderItemResourceApi.md#createorderitemusingpost) | **POST** /api/order-items | createOrderItem
[**DeleteOrderItemUsingDELETE**](OrderItemResourceApi.md#deleteorderitemusingdelete) | **DELETE** /api/order-items/{id} | deleteOrderItem
[**GetAllOrderItemsUsingGET**](OrderItemResourceApi.md#getallorderitemsusingget) | **GET** /api/order-items | getAllOrderItems
[**GetOrderItemUsingGET**](OrderItemResourceApi.md#getorderitemusingget) | **GET** /api/order-items/{id} | getOrderItem
[**UpdateOrderItemUsingPUT**](OrderItemResourceApi.md#updateorderitemusingput) | **PUT** /api/order-items | updateOrderItem


<a name="createorderitemusingpost"></a>
# **CreateOrderItemUsingPOST**
> OrderItem CreateOrderItemUsingPOST (OrderItem orderItem)

createOrderItem

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateOrderItemUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderItemResourceApi();
            var orderItem = new OrderItem(); // OrderItem | orderItem

            try
            {
                // createOrderItem
                OrderItem result = apiInstance.CreateOrderItemUsingPOST(orderItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderItemResourceApi.CreateOrderItemUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderItem** | [**OrderItem**](OrderItem.md)| orderItem | 

### Return type

[**OrderItem**](OrderItem.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderitemusingdelete"></a>
# **DeleteOrderItemUsingDELETE**
> void DeleteOrderItemUsingDELETE (long? id)

deleteOrderItem

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteOrderItemUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderItemResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteOrderItem
                apiInstance.DeleteOrderItemUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderItemResourceApi.DeleteOrderItemUsingDELETE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallorderitemsusingget"></a>
# **GetAllOrderItemsUsingGET**
> List<OrderItem> GetAllOrderItemsUsingGET ()

getAllOrderItems

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllOrderItemsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderItemResourceApi();

            try
            {
                // getAllOrderItems
                List&lt;OrderItem&gt; result = apiInstance.GetAllOrderItemsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderItemResourceApi.GetAllOrderItemsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrderItem>**](OrderItem.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderitemusingget"></a>
# **GetOrderItemUsingGET**
> OrderItem GetOrderItemUsingGET (long? id)

getOrderItem

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetOrderItemUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderItemResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getOrderItem
                OrderItem result = apiInstance.GetOrderItemUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderItemResourceApi.GetOrderItemUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id | 

### Return type

[**OrderItem**](OrderItem.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderitemusingput"></a>
# **UpdateOrderItemUsingPUT**
> OrderItem UpdateOrderItemUsingPUT (OrderItem orderItem)

updateOrderItem

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateOrderItemUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderItemResourceApi();
            var orderItem = new OrderItem(); // OrderItem | orderItem

            try
            {
                // updateOrderItem
                OrderItem result = apiInstance.UpdateOrderItemUsingPUT(orderItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderItemResourceApi.UpdateOrderItemUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderItem** | [**OrderItem**](OrderItem.md)| orderItem | 

### Return type

[**OrderItem**](OrderItem.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

