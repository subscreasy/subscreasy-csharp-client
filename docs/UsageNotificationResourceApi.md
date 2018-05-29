# IO.Swagger.com.kodfarki.subscreasy.client.UsageNotificationResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUsageNotificationUsingPOST**](UsageNotificationResourceApi.md#createusagenotificationusingpost) | **POST** /api/usage-notifications | createUsageNotification
[**DeleteUsageNotificationUsingDELETE**](UsageNotificationResourceApi.md#deleteusagenotificationusingdelete) | **DELETE** /api/usage-notifications/{id} | deleteUsageNotification
[**GetAllUsageNotificationsUsingGET**](UsageNotificationResourceApi.md#getallusagenotificationsusingget) | **GET** /api/usage-notifications | getAllUsageNotifications
[**GetUsageNotificationUsingGET**](UsageNotificationResourceApi.md#getusagenotificationusingget) | **GET** /api/usage-notifications/{id} | getUsageNotification
[**UpdateUsageNotificationUsingPUT**](UsageNotificationResourceApi.md#updateusagenotificationusingput) | **PUT** /api/usage-notifications | updateUsageNotification


<a name="createusagenotificationusingpost"></a>
# **CreateUsageNotificationUsingPOST**
> UsageNotification CreateUsageNotificationUsingPOST (UsageNotification usageNotification)

createUsageNotification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateUsageNotificationUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageNotificationResourceApi();
            var usageNotification = new UsageNotification(); // UsageNotification | usageNotification

            try
            {
                // createUsageNotification
                UsageNotification result = apiInstance.CreateUsageNotificationUsingPOST(usageNotification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageNotificationResourceApi.CreateUsageNotificationUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usageNotification** | [**UsageNotification**](UsageNotification.md)| usageNotification | 

### Return type

[**UsageNotification**](UsageNotification.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusagenotificationusingdelete"></a>
# **DeleteUsageNotificationUsingDELETE**
> void DeleteUsageNotificationUsingDELETE (long? id)

deleteUsageNotification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteUsageNotificationUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageNotificationResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteUsageNotification
                apiInstance.DeleteUsageNotificationUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageNotificationResourceApi.DeleteUsageNotificationUsingDELETE: " + e.Message );
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

<a name="getallusagenotificationsusingget"></a>
# **GetAllUsageNotificationsUsingGET**
> List<UsageNotification> GetAllUsageNotificationsUsingGET ()

getAllUsageNotifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllUsageNotificationsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageNotificationResourceApi();

            try
            {
                // getAllUsageNotifications
                List&lt;UsageNotification&gt; result = apiInstance.GetAllUsageNotificationsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageNotificationResourceApi.GetAllUsageNotificationsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UsageNotification>**](UsageNotification.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagenotificationusingget"></a>
# **GetUsageNotificationUsingGET**
> UsageNotification GetUsageNotificationUsingGET (long? id)

getUsageNotification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetUsageNotificationUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageNotificationResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getUsageNotification
                UsageNotification result = apiInstance.GetUsageNotificationUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageNotificationResourceApi.GetUsageNotificationUsingGET: " + e.Message );
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

[**UsageNotification**](UsageNotification.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusagenotificationusingput"></a>
# **UpdateUsageNotificationUsingPUT**
> UsageNotification UpdateUsageNotificationUsingPUT (UsageNotification usageNotification)

updateUsageNotification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateUsageNotificationUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsageNotificationResourceApi();
            var usageNotification = new UsageNotification(); // UsageNotification | usageNotification

            try
            {
                // updateUsageNotification
                UsageNotification result = apiInstance.UpdateUsageNotificationUsingPUT(usageNotification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsageNotificationResourceApi.UpdateUsageNotificationUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usageNotification** | [**UsageNotification**](UsageNotification.md)| usageNotification | 

### Return type

[**UsageNotification**](UsageNotification.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

