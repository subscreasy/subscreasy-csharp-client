# IO.Swagger.com.kodfarki.subscreasy.client.ServiceOfferingResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateServiceOfferingUsingPOST**](ServiceOfferingResourceApi.md#createserviceofferingusingpost) | **POST** /api/service-offerings | createServiceOffering
[**DeleteServiceOfferingUsingDELETE**](ServiceOfferingResourceApi.md#deleteserviceofferingusingdelete) | **DELETE** /api/service-offerings/{id} | deleteServiceOffering
[**GetAllServiceOfferingsUsingGET**](ServiceOfferingResourceApi.md#getallserviceofferingsusingget) | **GET** /api/service-offerings | getAllServiceOfferings
[**GetServiceOfferingUsingGET**](ServiceOfferingResourceApi.md#getserviceofferingusingget) | **GET** /api/service-offerings/{id} | getServiceOffering
[**UpdateServiceOfferingUsingPUT**](ServiceOfferingResourceApi.md#updateserviceofferingusingput) | **PUT** /api/service-offerings | updateServiceOffering


<a name="createserviceofferingusingpost"></a>
# **CreateServiceOfferingUsingPOST**
> ServiceOffering CreateServiceOfferingUsingPOST (ServiceOffering serviceOffering)

createServiceOffering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateServiceOfferingUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceOfferingResourceApi();
            var serviceOffering = new ServiceOffering(); // ServiceOffering | serviceOffering

            try
            {
                // createServiceOffering
                ServiceOffering result = apiInstance.CreateServiceOfferingUsingPOST(serviceOffering);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOfferingResourceApi.CreateServiceOfferingUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOffering** | [**ServiceOffering**](ServiceOffering.md)| serviceOffering | 

### Return type

[**ServiceOffering**](ServiceOffering.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserviceofferingusingdelete"></a>
# **DeleteServiceOfferingUsingDELETE**
> void DeleteServiceOfferingUsingDELETE (long? id)

deleteServiceOffering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteServiceOfferingUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceOfferingResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteServiceOffering
                apiInstance.DeleteServiceOfferingUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOfferingResourceApi.DeleteServiceOfferingUsingDELETE: " + e.Message );
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

<a name="getallserviceofferingsusingget"></a>
# **GetAllServiceOfferingsUsingGET**
> List<ServiceOffering> GetAllServiceOfferingsUsingGET ()

getAllServiceOfferings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllServiceOfferingsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceOfferingResourceApi();

            try
            {
                // getAllServiceOfferings
                List&lt;ServiceOffering&gt; result = apiInstance.GetAllServiceOfferingsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOfferingResourceApi.GetAllServiceOfferingsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ServiceOffering>**](ServiceOffering.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceofferingusingget"></a>
# **GetServiceOfferingUsingGET**
> ServiceOffering GetServiceOfferingUsingGET (long? id)

getServiceOffering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetServiceOfferingUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceOfferingResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getServiceOffering
                ServiceOffering result = apiInstance.GetServiceOfferingUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOfferingResourceApi.GetServiceOfferingUsingGET: " + e.Message );
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

[**ServiceOffering**](ServiceOffering.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateserviceofferingusingput"></a>
# **UpdateServiceOfferingUsingPUT**
> ServiceOffering UpdateServiceOfferingUsingPUT (ServiceOffering serviceOffering)

updateServiceOffering

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateServiceOfferingUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceOfferingResourceApi();
            var serviceOffering = new ServiceOffering(); // ServiceOffering | serviceOffering

            try
            {
                // updateServiceOffering
                ServiceOffering result = apiInstance.UpdateServiceOfferingUsingPUT(serviceOffering);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOfferingResourceApi.UpdateServiceOfferingUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOffering** | [**ServiceOffering**](ServiceOffering.md)| serviceOffering | 

### Return type

[**ServiceOffering**](ServiceOffering.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

