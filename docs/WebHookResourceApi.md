# IO.Swagger.com.kodfarki.subscreasy.client.WebHookResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebHookUsingPOST**](WebHookResourceApi.md#createwebhookusingpost) | **POST** /api/web-hooks | createWebHook
[**DeleteWebHookUsingDELETE**](WebHookResourceApi.md#deletewebhookusingdelete) | **DELETE** /api/web-hooks/{id} | deleteWebHook
[**GetAllWebHooksUsingGET**](WebHookResourceApi.md#getallwebhooksusingget) | **GET** /api/web-hooks | getAllWebHooks
[**GetWebHookUsingGET**](WebHookResourceApi.md#getwebhookusingget) | **GET** /api/web-hooks/{id} | getWebHook
[**UpdateWebHookUsingPUT**](WebHookResourceApi.md#updatewebhookusingput) | **PUT** /api/web-hooks | updateWebHook


<a name="createwebhookusingpost"></a>
# **CreateWebHookUsingPOST**
> WebHook CreateWebHookUsingPOST (WebHook webHook)

createWebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateWebHookUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookResourceApi();
            var webHook = new WebHook(); // WebHook | webHook

            try
            {
                // createWebHook
                WebHook result = apiInstance.CreateWebHookUsingPOST(webHook);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookResourceApi.CreateWebHookUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webHook** | [**WebHook**](WebHook.md)| webHook | 

### Return type

[**WebHook**](WebHook.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhookusingdelete"></a>
# **DeleteWebHookUsingDELETE**
> void DeleteWebHookUsingDELETE (long? id)

deleteWebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteWebHookUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteWebHook
                apiInstance.DeleteWebHookUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookResourceApi.DeleteWebHookUsingDELETE: " + e.Message );
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

<a name="getallwebhooksusingget"></a>
# **GetAllWebHooksUsingGET**
> List<WebHook> GetAllWebHooksUsingGET ()

getAllWebHooks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllWebHooksUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookResourceApi();

            try
            {
                // getAllWebHooks
                List&lt;WebHook&gt; result = apiInstance.GetAllWebHooksUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookResourceApi.GetAllWebHooksUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<WebHook>**](WebHook.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookusingget"></a>
# **GetWebHookUsingGET**
> WebHook GetWebHookUsingGET (long? id)

getWebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetWebHookUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getWebHook
                WebHook result = apiInstance.GetWebHookUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookResourceApi.GetWebHookUsingGET: " + e.Message );
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

[**WebHook**](WebHook.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhookusingput"></a>
# **UpdateWebHookUsingPUT**
> WebHook UpdateWebHookUsingPUT (WebHook webHook)

updateWebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateWebHookUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookResourceApi();
            var webHook = new WebHook(); // WebHook | webHook

            try
            {
                // updateWebHook
                WebHook result = apiInstance.UpdateWebHookUsingPUT(webHook);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookResourceApi.UpdateWebHookUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webHook** | [**WebHook**](WebHook.md)| webHook | 

### Return type

[**WebHook**](WebHook.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

