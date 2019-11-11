# IO.Swagger.com.kodfarki.subscreasy.client.ServiceResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateServiceUsingPOST**](ServiceResourceApi.md#createserviceusingpost) | **POST** /api/services | createService
[**DeleteServiceUsingDELETE**](ServiceResourceApi.md#deleteserviceusingdelete) | **DELETE** /api/services/{id} | deleteService
[**GetAllServicesUsingGET**](ServiceResourceApi.md#getallservicesusingget) | **GET** /api/services | getAllServices
[**GetServiceUsingGET**](ServiceResourceApi.md#getserviceusingget) | **GET** /api/services/{id} | getService
[**UpdateServiceUsingPUT**](ServiceResourceApi.md#updateserviceusingput) | **PUT** /api/services | updateService


<a name="createserviceusingpost"></a>
# **CreateServiceUsingPOST**
> Service CreateServiceUsingPOST (Service service)

createService

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateServiceUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceResourceApi();
            var service = new Service(); // Service | service

            try
            {
                // createService
                Service result = apiInstance.CreateServiceUsingPOST(service);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceResourceApi.CreateServiceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | [**Service**](Service.md)| service | 

### Return type

[**Service**](Service.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserviceusingdelete"></a>
# **DeleteServiceUsingDELETE**
> void DeleteServiceUsingDELETE (long? id)

deleteService

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteServiceUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteService
                apiInstance.DeleteServiceUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceResourceApi.DeleteServiceUsingDELETE: " + e.Message );
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

<a name="getallservicesusingget"></a>
# **GetAllServicesUsingGET**
> List<Service> GetAllServicesUsingGET ()

getAllServices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllServicesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceResourceApi();

            try
            {
                // getAllServices
                List&lt;Service&gt; result = apiInstance.GetAllServicesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceResourceApi.GetAllServicesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Service>**](Service.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceusingget"></a>
# **GetServiceUsingGET**
> Service GetServiceUsingGET (long? id)

getService

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetServiceUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getService
                Service result = apiInstance.GetServiceUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceResourceApi.GetServiceUsingGET: " + e.Message );
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

[**Service**](Service.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateserviceusingput"></a>
# **UpdateServiceUsingPUT**
> Service UpdateServiceUsingPUT (Service service)

updateService

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateServiceUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceResourceApi();
            var service = new Service(); // Service | service

            try
            {
                // updateService
                Service result = apiInstance.UpdateServiceUsingPUT(service);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceResourceApi.UpdateServiceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | [**Service**](Service.md)| service | 

### Return type

[**Service**](Service.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

