# IO.Swagger.com.kodfarki.subscreasy.client.SubscriptionResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelSubscriptionUsingPUT**](SubscriptionResourceApi.md#cancelsubscriptionusingput) | **PUT** /api/subscriptions/cancel | cancelSubscription
[**GetActiveSubscriptionsByEmailUsingGET**](SubscriptionResourceApi.md#getactivesubscriptionsbyemailusingget) | **GET** /api/subscriptions/subscriber/email/{email} | getActiveSubscriptionsByEmail
[**GetActiveSubscriptionsUsingGET**](SubscriptionResourceApi.md#getactivesubscriptionsusingget) | **GET** /api/subscriptions/subscriber/{secureId} | getActiveSubscriptions
[**GetAllCompanySubscriptionsUsingGET**](SubscriptionResourceApi.md#getallcompanysubscriptionsusingget) | **GET** /api/subscriptions/company/{id} | getAllCompanySubscriptions
[**GetSubscriptionUsingGET**](SubscriptionResourceApi.md#getsubscriptionusingget) | **GET** /api/subscriptions/{id} | getSubscription
[**StartSubscriptionUsingPOST**](SubscriptionResourceApi.md#startsubscriptionusingpost) | **POST** /api/subscriptions/start | startSubscription


<a name="cancelsubscriptionusingput"></a>
# **CancelSubscriptionUsingPUT**
> Subsription CancelSubscriptionUsingPUT (Cancellation cancellation)

cancelSubscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CancelSubscriptionUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var cancellation = new Cancellation(); // Cancellation | cancellation

            try
            {
                // cancelSubscription
                Subsription result = apiInstance.CancelSubscriptionUsingPUT(cancellation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.CancelSubscriptionUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cancellation** | [**Cancellation**](Cancellation.md)| cancellation | 

### Return type

[**Subsription**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivesubscriptionsbyemailusingget"></a>
# **GetActiveSubscriptionsByEmailUsingGET**
> List<Subsription> GetActiveSubscriptionsByEmailUsingGET (string email)

getActiveSubscriptionsByEmail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetActiveSubscriptionsByEmailUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var email = email_example;  // string | email

            try
            {
                // getActiveSubscriptionsByEmail
                List&lt;Subsription&gt; result = apiInstance.GetActiveSubscriptionsByEmailUsingGET(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetActiveSubscriptionsByEmailUsingGET: " + e.Message );
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

[**List<Subsription>**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivesubscriptionsusingget"></a>
# **GetActiveSubscriptionsUsingGET**
> List<Subsription> GetActiveSubscriptionsUsingGET (string secureId)

getActiveSubscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetActiveSubscriptionsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var secureId = secureId_example;  // string | secureId

            try
            {
                // getActiveSubscriptions
                List&lt;Subsription&gt; result = apiInstance.GetActiveSubscriptionsUsingGET(secureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetActiveSubscriptionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secureId** | **string**| secureId | 

### Return type

[**List<Subsription>**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcompanysubscriptionsusingget"></a>
# **GetAllCompanySubscriptionsUsingGET**
> List<Subsription> GetAllCompanySubscriptionsUsingGET (string id)

getAllCompanySubscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllCompanySubscriptionsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var id = id_example;  // string | id

            try
            {
                // getAllCompanySubscriptions
                List&lt;Subsription&gt; result = apiInstance.GetAllCompanySubscriptionsUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetAllCompanySubscriptionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**List<Subsription>**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionusingget"></a>
# **GetSubscriptionUsingGET**
> Subsription GetSubscriptionUsingGET (long? id)

getSubscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetSubscriptionUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getSubscription
                Subsription result = apiInstance.GetSubscriptionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetSubscriptionUsingGET: " + e.Message );
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

[**Subsription**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startsubscriptionusingpost"></a>
# **StartSubscriptionUsingPOST**
> StartSubscriptionResult StartSubscriptionUsingPOST (StartSubscriptionRequest request)

startSubscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class StartSubscriptionUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var request = new StartSubscriptionRequest(); // StartSubscriptionRequest | request

            try
            {
                // startSubscription
                StartSubscriptionResult result = apiInstance.StartSubscriptionUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.StartSubscriptionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StartSubscriptionRequest**](StartSubscriptionRequest.md)| request | 

### Return type

[**StartSubscriptionResult**](StartSubscriptionResult.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

