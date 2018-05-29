# IO.Swagger.com.kodfarki.subscreasy.client.ServiceInstanceResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateServiceInstanceUsingPOST**](ServiceInstanceResourceApi.md#createserviceinstanceusingpost) | **POST** /api/service-instances | createServiceInstance
[**DeleteServiceInstanceUsingDELETE**](ServiceInstanceResourceApi.md#deleteserviceinstanceusingdelete) | **DELETE** /api/service-instances/{id} | deleteServiceInstance
[**GetAllServiceInstancesUsingGET**](ServiceInstanceResourceApi.md#getallserviceinstancesusingget) | **GET** /api/service-instances | getAllServiceInstances
[**GetServiceInstanceUsingGET**](ServiceInstanceResourceApi.md#getserviceinstanceusingget) | **GET** /api/service-instances/{id} | getServiceInstance
[**UpdateServiceInstanceUsingPUT**](ServiceInstanceResourceApi.md#updateserviceinstanceusingput) | **PUT** /api/service-instances | updateServiceInstance


<a name="createserviceinstanceusingpost"></a>
# **CreateServiceInstanceUsingPOST**
> ServiceInstance CreateServiceInstanceUsingPOST (ServiceInstance serviceInstance)

createServiceInstance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateServiceInstanceUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceInstanceResourceApi();
            var serviceInstance = new ServiceInstance(); // ServiceInstance | serviceInstance

            try
            {
                // createServiceInstance
                ServiceInstance result = apiInstance.CreateServiceInstanceUsingPOST(serviceInstance);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInstanceResourceApi.CreateServiceInstanceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceInstance** | [**ServiceInstance**](ServiceInstance.md)| serviceInstance | 

### Return type

[**ServiceInstance**](ServiceInstance.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserviceinstanceusingdelete"></a>
# **DeleteServiceInstanceUsingDELETE**
> void DeleteServiceInstanceUsingDELETE (long? id)

deleteServiceInstance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteServiceInstanceUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceInstanceResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteServiceInstance
                apiInstance.DeleteServiceInstanceUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInstanceResourceApi.DeleteServiceInstanceUsingDELETE: " + e.Message );
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

<a name="getallserviceinstancesusingget"></a>
# **GetAllServiceInstancesUsingGET**
> List<ServiceInstance> GetAllServiceInstancesUsingGET ()

getAllServiceInstances

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllServiceInstancesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceInstanceResourceApi();

            try
            {
                // getAllServiceInstances
                List&lt;ServiceInstance&gt; result = apiInstance.GetAllServiceInstancesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInstanceResourceApi.GetAllServiceInstancesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ServiceInstance>**](ServiceInstance.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceinstanceusingget"></a>
# **GetServiceInstanceUsingGET**
> ServiceInstance GetServiceInstanceUsingGET (long? id)

getServiceInstance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetServiceInstanceUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceInstanceResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getServiceInstance
                ServiceInstance result = apiInstance.GetServiceInstanceUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInstanceResourceApi.GetServiceInstanceUsingGET: " + e.Message );
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

[**ServiceInstance**](ServiceInstance.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateserviceinstanceusingput"></a>
# **UpdateServiceInstanceUsingPUT**
> ServiceInstance UpdateServiceInstanceUsingPUT (ServiceInstance serviceInstance)

updateServiceInstance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateServiceInstanceUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceInstanceResourceApi();
            var serviceInstance = new ServiceInstance(); // ServiceInstance | serviceInstance

            try
            {
                // updateServiceInstance
                ServiceInstance result = apiInstance.UpdateServiceInstanceUsingPUT(serviceInstance);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInstanceResourceApi.UpdateServiceInstanceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceInstance** | [**ServiceInstance**](ServiceInstance.md)| serviceInstance | 

### Return type

[**ServiceInstance**](ServiceInstance.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

