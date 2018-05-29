# IO.Swagger.com.kodfarki.subscreasy.client.SubscriberResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscriberUsingPOST**](SubscriberResourceApi.md#createsubscriberusingpost) | **POST** /api/subscribers | createSubscriber
[**DeleteSubscriberUsingDELETE**](SubscriberResourceApi.md#deletesubscriberusingdelete) | **DELETE** /api/subscribers/{id} | deleteSubscriber
[**GetAllSubscribersUsingGET**](SubscriberResourceApi.md#getallsubscribersusingget) | **GET** /api/subscribers | getAllSubscribers
[**GetSubscriberByEmailUsingGET**](SubscriberResourceApi.md#getsubscriberbyemailusingget) | **GET** /api/subscribers/email/{email} | getSubscriberByEmail
[**GetSubscriberByNameUsingGET**](SubscriberResourceApi.md#getsubscriberbynameusingget) | **GET** /api/subscribers/name/{name} | getSubscriberByName
[**GetSubscriberUsingGET**](SubscriberResourceApi.md#getsubscriberusingget) | **GET** /api/subscribers/{id} | getSubscriber
[**UpdateSubscriberUsingPUT**](SubscriberResourceApi.md#updatesubscriberusingput) | **PUT** /api/subscribers | updateSubscriber


<a name="createsubscriberusingpost"></a>
# **CreateSubscriberUsingPOST**
> Subscriber CreateSubscriberUsingPOST (Subscriber subscriber)

createSubscriber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateSubscriberUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();
            var subscriber = new Subscriber(); // Subscriber | subscriber

            try
            {
                // createSubscriber
                Subscriber result = apiInstance.CreateSubscriberUsingPOST(subscriber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.CreateSubscriberUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriber** | [**Subscriber**](Subscriber.md)| subscriber | 

### Return type

[**Subscriber**](Subscriber.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscriberusingdelete"></a>
# **DeleteSubscriberUsingDELETE**
> void DeleteSubscriberUsingDELETE (long? id)

deleteSubscriber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteSubscriberUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteSubscriber
                apiInstance.DeleteSubscriberUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.DeleteSubscriberUsingDELETE: " + e.Message );
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

<a name="getallsubscribersusingget"></a>
# **GetAllSubscribersUsingGET**
> List<Subscriber> GetAllSubscribersUsingGET ()

getAllSubscribers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllSubscribersUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();

            try
            {
                // getAllSubscribers
                List&lt;Subscriber&gt; result = apiInstance.GetAllSubscribersUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.GetAllSubscribersUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Subscriber>**](Subscriber.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriberbyemailusingget"></a>
# **GetSubscriberByEmailUsingGET**
> List<Subscriber> GetSubscriberByEmailUsingGET (string email)

getSubscriberByEmail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetSubscriberByEmailUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();
            var email = email_example;  // string | email

            try
            {
                // getSubscriberByEmail
                List&lt;Subscriber&gt; result = apiInstance.GetSubscriberByEmailUsingGET(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.GetSubscriberByEmailUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| email | 

### Return type

[**List<Subscriber>**](Subscriber.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriberbynameusingget"></a>
# **GetSubscriberByNameUsingGET**
> List<Subscriber> GetSubscriberByNameUsingGET (string name)

getSubscriberByName

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetSubscriberByNameUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();
            var name = name_example;  // string | name

            try
            {
                // getSubscriberByName
                List&lt;Subscriber&gt; result = apiInstance.GetSubscriberByNameUsingGET(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.GetSubscriberByNameUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name | 

### Return type

[**List<Subscriber>**](Subscriber.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriberusingget"></a>
# **GetSubscriberUsingGET**
> Subscriber GetSubscriberUsingGET (long? id)

getSubscriber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetSubscriberUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getSubscriber
                Subscriber result = apiInstance.GetSubscriberUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.GetSubscriberUsingGET: " + e.Message );
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

[**Subscriber**](Subscriber.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscriberusingput"></a>
# **UpdateSubscriberUsingPUT**
> Subscriber UpdateSubscriberUsingPUT (Subscriber subscriber)

updateSubscriber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateSubscriberUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriberResourceApi();
            var subscriber = new Subscriber(); // Subscriber | subscriber

            try
            {
                // updateSubscriber
                Subscriber result = apiInstance.UpdateSubscriberUsingPUT(subscriber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriberResourceApi.UpdateSubscriberUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriber** | [**Subscriber**](Subscriber.md)| subscriber | 

### Return type

[**Subscriber**](Subscriber.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
