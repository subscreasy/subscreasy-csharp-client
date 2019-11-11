# IO.Swagger.com.kodfarki.subscreasy.client.ChargingLogResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChargingLogUsingPOST**](ChargingLogResourceApi.md#createcharginglogusingpost) | **POST** /api/charging-logs | createChargingLog
[**DeleteChargingLogUsingDELETE**](ChargingLogResourceApi.md#deletecharginglogusingdelete) | **DELETE** /api/charging-logs/{id} | deleteChargingLog
[**GetAllChargingLogsUsingGET**](ChargingLogResourceApi.md#getallcharginglogsusingget) | **GET** /api/charging-logs | getAllChargingLogs
[**GetChargingLogUsingGET**](ChargingLogResourceApi.md#getcharginglogusingget) | **GET** /api/charging-logs/{id} | getChargingLog
[**GetChargingLogsByStatusUsingGET**](ChargingLogResourceApi.md#getcharginglogsbystatususingget) | **GET** /api/charging-logs/status/{status} | getChargingLogsByStatus
[**GetPaymentsByMerchantSubscriberIdUsingGET**](ChargingLogResourceApi.md#getpaymentsbymerchantsubscriberidusingget) | **GET** /api/charging-logs/subscriber/m/{merchantSubscriberId} | getPaymentsByMerchantSubscriberId
[**RefundUsingPOST**](ChargingLogResourceApi.md#refundusingpost) | **POST** /api/charging-logs/refund/{chargingLogId} | refund
[**UpdateChargingLogUsingPUT**](ChargingLogResourceApi.md#updatecharginglogusingput) | **PUT** /api/charging-logs | updateChargingLog


<a name="createcharginglogusingpost"></a>
# **CreateChargingLogUsingPOST**
> ChargingLog CreateChargingLogUsingPOST (ChargingLog chargingLog)

createChargingLog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateChargingLogUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var chargingLog = new ChargingLog(); // ChargingLog | chargingLog

            try
            {
                // createChargingLog
                ChargingLog result = apiInstance.CreateChargingLogUsingPOST(chargingLog);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.CreateChargingLogUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargingLog** | [**ChargingLog**](ChargingLog.md)| chargingLog | 

### Return type

[**ChargingLog**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecharginglogusingdelete"></a>
# **DeleteChargingLogUsingDELETE**
> void DeleteChargingLogUsingDELETE (long? id)

deleteChargingLog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteChargingLogUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteChargingLog
                apiInstance.DeleteChargingLogUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.DeleteChargingLogUsingDELETE: " + e.Message );
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

<a name="getallcharginglogsusingget"></a>
# **GetAllChargingLogsUsingGET**
> List<ChargingLog> GetAllChargingLogsUsingGET (int? page = null, int? size = null, List<string> sort = null)

getAllChargingLogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllChargingLogsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var page = 56;  // int? | Page number of the requested page (optional) 
            var size = 56;  // int? | Size of a page (optional) 
            var sort = new List<string>(); // List<string> | Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. (optional) 

            try
            {
                // getAllChargingLogs
                List&lt;ChargingLog&gt; result = apiInstance.GetAllChargingLogsUsingGET(page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.GetAllChargingLogsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number of the requested page | [optional] 
 **size** | **int?**| Size of a page | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. | [optional] 

### Return type

[**List<ChargingLog>**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharginglogusingget"></a>
# **GetChargingLogUsingGET**
> ChargingLog GetChargingLogUsingGET (long? id)

getChargingLog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetChargingLogUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getChargingLog
                ChargingLog result = apiInstance.GetChargingLogUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.GetChargingLogUsingGET: " + e.Message );
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

[**ChargingLog**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharginglogsbystatususingget"></a>
# **GetChargingLogsByStatusUsingGET**
> List<ChargingLog> GetChargingLogsByStatusUsingGET (string status, int? page = null, int? size = null, List<string> sort = null)

getChargingLogsByStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetChargingLogsByStatusUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var status = status_example;  // string | status
            var page = 56;  // int? | Page number of the requested page (optional) 
            var size = 56;  // int? | Size of a page (optional) 
            var sort = new List<string>(); // List<string> | Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. (optional) 

            try
            {
                // getChargingLogsByStatus
                List&lt;ChargingLog&gt; result = apiInstance.GetChargingLogsByStatusUsingGET(status, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.GetChargingLogsByStatusUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| status | 
 **page** | **int?**| Page number of the requested page | [optional] 
 **size** | **int?**| Size of a page | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. | [optional] 

### Return type

[**List<ChargingLog>**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsbymerchantsubscriberidusingget"></a>
# **GetPaymentsByMerchantSubscriberIdUsingGET**
> List<ChargingLog> GetPaymentsByMerchantSubscriberIdUsingGET (string merchantSubscriberId, int? page = null, int? size = null, List<string> sort = null)

getPaymentsByMerchantSubscriberId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetPaymentsByMerchantSubscriberIdUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var merchantSubscriberId = merchantSubscriberId_example;  // string | merchantSubscriberId
            var page = 56;  // int? | Page number of the requested page (optional) 
            var size = 56;  // int? | Size of a page (optional) 
            var sort = new List<string>(); // List<string> | Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. (optional) 

            try
            {
                // getPaymentsByMerchantSubscriberId
                List&lt;ChargingLog&gt; result = apiInstance.GetPaymentsByMerchantSubscriberIdUsingGET(merchantSubscriberId, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.GetPaymentsByMerchantSubscriberIdUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSubscriberId** | **string**| merchantSubscriberId | 
 **page** | **int?**| Page number of the requested page | [optional] 
 **size** | **int?**| Size of a page | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. | [optional] 

### Return type

[**List<ChargingLog>**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundusingpost"></a>
# **RefundUsingPOST**
> ChargingLog RefundUsingPOST (long? chargingLogId)

refund

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class RefundUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var chargingLogId = 789;  // long? | chargingLogId

            try
            {
                // refund
                ChargingLog result = apiInstance.RefundUsingPOST(chargingLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.RefundUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargingLogId** | **long?**| chargingLogId | 

### Return type

[**ChargingLog**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecharginglogusingput"></a>
# **UpdateChargingLogUsingPUT**
> ChargingLog UpdateChargingLogUsingPUT (ChargingLog chargingLog)

updateChargingLog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateChargingLogUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChargingLogResourceApi();
            var chargingLog = new ChargingLog(); // ChargingLog | chargingLog

            try
            {
                // updateChargingLog
                ChargingLog result = apiInstance.UpdateChargingLogUsingPUT(chargingLog);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargingLogResourceApi.UpdateChargingLogUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargingLog** | [**ChargingLog**](ChargingLog.md)| chargingLog | 

### Return type

[**ChargingLog**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

