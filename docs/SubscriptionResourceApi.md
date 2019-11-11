# IO.Swagger.com.kodfarki.subscreasy.client.SubscriptionResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelSubscriptionUsingPUT**](SubscriptionResourceApi.md#cancelsubscriptionusingput) | **PUT** /api/subscriptions/cancel | cancelSubscription
[**ChangePaymentMethodUsingPUT**](SubscriptionResourceApi.md#changepaymentmethodusingput) | **PUT** /api/subscriptions/change-payment-method/{subscriptionId} | changePaymentMethod
[**ChargeEarlyUsingPUT**](SubscriptionResourceApi.md#chargeearlyusingput) | **PUT** /api/subscriptions/charge/{subscriptionId} | chargeEarly
[**GetActiveSubscriptionsByEmailUsingGET**](SubscriptionResourceApi.md#getactivesubscriptionsbyemailusingget) | **GET** /api/subscriptions/subscriber/email/{email} | getActiveSubscriptionsByEmail
[**GetActiveSubscriptionsUsingGET**](SubscriptionResourceApi.md#getactivesubscriptionsusingget) | **GET** /api/subscriptions/subscriber/{secureId} | getActiveSubscriptions
[**GetAllCompanySubscriptionsUsingGET**](SubscriptionResourceApi.md#getallcompanysubscriptionsusingget) | **GET** /api/subscriptions/company/{id} | getAllCompanySubscriptions
[**GetAllSubscriptionsByOfferUsingGET**](SubscriptionResourceApi.md#getallsubscriptionsbyofferusingget) | **GET** /api/subscriptions/offer/{id} | getAllSubscriptionsByOffer
[**GetSubscriptionUsingGET**](SubscriptionResourceApi.md#getsubscriptionusingget) | **GET** /api/subscriptions/{id} | getSubscription
[**GetSubscriptionsByMerchantSubscriberIdUsingGET**](SubscriptionResourceApi.md#getsubscriptionsbymerchantsubscriberidusingget) | **GET** /api/subscriptions/subscriber/m/{merchantSubscriberId} | getSubscriptionsByMerchantSubscriberId
[**GetSubscriptionsByStatusUsingGET**](SubscriptionResourceApi.md#getsubscriptionsbystatususingget) | **GET** /api/subscriptions/status/{status} | getSubscriptionsByStatus
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

<a name="changepaymentmethodusingput"></a>
# **ChangePaymentMethodUsingPUT**
> Subsription ChangePaymentMethodUsingPUT (long? subscriptionId)

changePaymentMethod

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class ChangePaymentMethodUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var subscriptionId = 789;  // long? | subscriptionId

            try
            {
                // changePaymentMethod
                Subsription result = apiInstance.ChangePaymentMethodUsingPUT(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.ChangePaymentMethodUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **long?**| subscriptionId | 

### Return type

[**Subsription**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargeearlyusingput"></a>
# **ChargeEarlyUsingPUT**
> Job ChargeEarlyUsingPUT (long? subscriptionId)

chargeEarly

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class ChargeEarlyUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var subscriptionId = 789;  // long? | subscriptionId

            try
            {
                // chargeEarly
                Job result = apiInstance.ChargeEarlyUsingPUT(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.ChargeEarlyUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **long?**| subscriptionId | 

### Return type

[**Job**](Job.md)

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

<a name="getallsubscriptionsbyofferusingget"></a>
# **GetAllSubscriptionsByOfferUsingGET**
> List<Subsription> GetAllSubscriptionsByOfferUsingGET (long? id, int? page = null, int? size = null, List<string> sort = null)

getAllSubscriptionsByOffer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllSubscriptionsByOfferUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var id = 789;  // long? | id
            var page = 56;  // int? | Page number of the requested page (optional) 
            var size = 56;  // int? | Size of a page (optional) 
            var sort = new List<string>(); // List<string> | Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. (optional) 

            try
            {
                // getAllSubscriptionsByOffer
                List&lt;Subsription&gt; result = apiInstance.GetAllSubscriptionsByOfferUsingGET(id, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetAllSubscriptionsByOfferUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id | 
 **page** | **int?**| Page number of the requested page | [optional] 
 **size** | **int?**| Size of a page | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. | [optional] 

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

<a name="getsubscriptionsbymerchantsubscriberidusingget"></a>
# **GetSubscriptionsByMerchantSubscriberIdUsingGET**
> List<Subsription> GetSubscriptionsByMerchantSubscriberIdUsingGET (string merchantSubscriberId, int? page = null, int? size = null, List<string> sort = null)

getSubscriptionsByMerchantSubscriberId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetSubscriptionsByMerchantSubscriberIdUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var merchantSubscriberId = merchantSubscriberId_example;  // string | merchantSubscriberId
            var page = 56;  // int? | Page number of the requested page (optional) 
            var size = 56;  // int? | Size of a page (optional) 
            var sort = new List<string>(); // List<string> | Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. (optional) 

            try
            {
                // getSubscriptionsByMerchantSubscriberId
                List&lt;Subsription&gt; result = apiInstance.GetSubscriptionsByMerchantSubscriberIdUsingGET(merchantSubscriberId, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetSubscriptionsByMerchantSubscriberIdUsingGET: " + e.Message );
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

[**List<Subsription>**](Subsription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionsbystatususingget"></a>
# **GetSubscriptionsByStatusUsingGET**
> List<Subsription> GetSubscriptionsByStatusUsingGET (string status, int? page = null, int? size = null, List<string> sort = null)

getSubscriptionsByStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetSubscriptionsByStatusUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SubscriptionResourceApi();
            var status = status_example;  // string | status
            var page = 56;  // int? | Page number of the requested page (optional) 
            var size = 56;  // int? | Size of a page (optional) 
            var sort = new List<string>(); // List<string> | Sorting criteria in the format: property(,asc|desc). Default sort order is ascending. Multiple sort criteria are supported. (optional) 

            try
            {
                // getSubscriptionsByStatus
                List&lt;Subsription&gt; result = apiInstance.GetSubscriptionsByStatusUsingGET(status, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionResourceApi.GetSubscriptionsByStatusUsingGET: " + e.Message );
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

[**List<Subsription>**](Subsription.md)

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

