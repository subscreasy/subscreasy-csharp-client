# IO.Swagger.com.kodfarki.subscreasy.client.WebHookServerApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubscriberCreatedUsingPOST**](WebHookServerApi.md#subscribercreatedusingpost) | **POST** /subscreasy/webhook/subscriber-created | subscriberCreated
[**SubscriberUpdatedUsingPOST**](WebHookServerApi.md#subscriberupdatedusingpost) | **POST** /subscreasy/webhook/subscriber-updated | subscriberUpdated
[**SubscriptionEndedUsingPOST**](WebHookServerApi.md#subscriptionendedusingpost) | **POST** /subscreasy/webhook/subscription-ended | subscriptionEnded
[**SubscriptionRenewalFailedUsingPOST**](WebHookServerApi.md#subscriptionrenewalfailedusingpost) | **POST** /subscreasy/webhook/subscription-renewal-failed | subscriptionRenewalFailed
[**SubscriptionRenewedUsingPOST**](WebHookServerApi.md#subscriptionrenewedusingpost) | **POST** /subscreasy/webhook/subscription-renewed | subscriptionRenewed
[**SubscriptionStartedUsingPOST**](WebHookServerApi.md#subscriptionstartedusingpost) | **POST** /subscreasy/webhook/subscription-started | subscriptionStarted


<a name="subscribercreatedusingpost"></a>
# **SubscriberCreatedUsingPOST**
> Object SubscriberCreatedUsingPOST (WebHookRequest r)

subscriberCreated

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SubscriberCreatedUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new WebHookServerApi();
            var r = new WebHookRequest(); // WebHookRequest | r

            try
            {
                // subscriberCreated
                Object result = apiInstance.SubscriberCreatedUsingPOST(r);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookServerApi.SubscriberCreatedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **r** | [**WebHookRequest**](WebHookRequest.md)| r | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriberupdatedusingpost"></a>
# **SubscriberUpdatedUsingPOST**
> Object SubscriberUpdatedUsingPOST (WebHookRequest r)

subscriberUpdated

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SubscriberUpdatedUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new WebHookServerApi();
            var r = new WebHookRequest(); // WebHookRequest | r

            try
            {
                // subscriberUpdated
                Object result = apiInstance.SubscriberUpdatedUsingPOST(r);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookServerApi.SubscriberUpdatedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **r** | [**WebHookRequest**](WebHookRequest.md)| r | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionendedusingpost"></a>
# **SubscriptionEndedUsingPOST**
> Object SubscriptionEndedUsingPOST (WebHookRequest r)

subscriptionEnded

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SubscriptionEndedUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new WebHookServerApi();
            var r = new WebHookRequest(); // WebHookRequest | r

            try
            {
                // subscriptionEnded
                Object result = apiInstance.SubscriptionEndedUsingPOST(r);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookServerApi.SubscriptionEndedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **r** | [**WebHookRequest**](WebHookRequest.md)| r | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionrenewalfailedusingpost"></a>
# **SubscriptionRenewalFailedUsingPOST**
> Object SubscriptionRenewalFailedUsingPOST (WebHookRequest r)

subscriptionRenewalFailed

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SubscriptionRenewalFailedUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new WebHookServerApi();
            var r = new WebHookRequest(); // WebHookRequest | r

            try
            {
                // subscriptionRenewalFailed
                Object result = apiInstance.SubscriptionRenewalFailedUsingPOST(r);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookServerApi.SubscriptionRenewalFailedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **r** | [**WebHookRequest**](WebHookRequest.md)| r | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionrenewedusingpost"></a>
# **SubscriptionRenewedUsingPOST**
> Object SubscriptionRenewedUsingPOST (WebHookRequest r)

subscriptionRenewed

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SubscriptionRenewedUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new WebHookServerApi();
            var r = new WebHookRequest(); // WebHookRequest | r

            try
            {
                // subscriptionRenewed
                Object result = apiInstance.SubscriptionRenewedUsingPOST(r);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookServerApi.SubscriptionRenewedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **r** | [**WebHookRequest**](WebHookRequest.md)| r | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionstartedusingpost"></a>
# **SubscriptionStartedUsingPOST**
> Object SubscriptionStartedUsingPOST (WebHookRequest r)

subscriptionStarted

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SubscriptionStartedUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new WebHookServerApi();
            var r = new WebHookRequest(); // WebHookRequest | r

            try
            {
                // subscriptionStarted
                Object result = apiInstance.SubscriptionStartedUsingPOST(r);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookServerApi.SubscriptionStartedUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **r** | [**WebHookRequest**](WebHookRequest.md)| r | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

