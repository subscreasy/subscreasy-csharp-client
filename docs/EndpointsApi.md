# IO.Swagger.com.kodfarki.subscreasy.client.EndpointsApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorizeUsingPUT**](EndpointsApi.md#authorizeusingput) | **PUT** /api/authorize | authorize
[**DeductUsingPUT**](EndpointsApi.md#deductusingput) | **PUT** /api/deduct | deduct
[**GetAuthorizedServicesUsingGET**](EndpointsApi.md#getauthorizedservicesusingget) | **GET** /api/service/subscriber/{secureId} | getAuthorizedServices
[**GetChargingLogBySubscriptionUsingGET**](EndpointsApi.md#getcharginglogbysubscriptionusingget) | **GET** /api/charging-logs/subscription/{id} | getChargingLogBySubscription
[**GetCustomerTotalAmountUsingGET**](EndpointsApi.md#getcustomertotalamountusingget) | **GET** /api/customer-totalAmountCharge/{id} | getCustomerTotalAmount
[**GetInvoiceDetailsUsingGET**](EndpointsApi.md#getinvoicedetailsusingget) | **GET** /api/getInvoiceDetails | getInvoiceDetails
[**GetMessageTemplateUsingGET**](EndpointsApi.md#getmessagetemplateusingget) | **GET** /api/message-templates/email/{lifecycleEventName} | getMessageTemplate
[**GetServiceInstancesBySubscriptionUsingGET**](EndpointsApi.md#getserviceinstancesbysubscriptionusingget) | **GET** /api/service-instances/subscription/{id} | getServiceInstancesBySubscription
[**GetServiceOfferingsBySubscriptionPlanUsingGET**](EndpointsApi.md#getserviceofferingsbysubscriptionplanusingget) | **GET** /api/service-offerings/offer/{id} | getServiceOfferingsBySubscriptionPlan
[**GetTotalRevenuePerMonthUsingGET**](EndpointsApi.md#gettotalrevenuepermonthusingget) | **GET** /api/charging-logs-totalamount-customer/{id} | getTotalRevenuePerMonth


<a name="authorizeusingput"></a>
# **AuthorizeUsingPUT**
> bool? AuthorizeUsingPUT (Authorization authorization)

authorize

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class AuthorizeUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var authorization = new Authorization(); // Authorization | authorization

            try
            {
                // authorize
                bool? result = apiInstance.AuthorizeUsingPUT(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.AuthorizeUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | [**Authorization**](Authorization.md)| authorization | 

### Return type

**bool?**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deductusingput"></a>
# **DeductUsingPUT**
> DeductionResult DeductUsingPUT (Deduction deduction)

deduct

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeductUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var deduction = new Deduction(); // Deduction | deduction

            try
            {
                // deduct
                DeductionResult result = apiInstance.DeductUsingPUT(deduction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.DeductUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deduction** | [**Deduction**](Deduction.md)| deduction | 

### Return type

[**DeductionResult**](DeductionResult.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthorizedservicesusingget"></a>
# **GetAuthorizedServicesUsingGET**
> AuthorizedServicesResponse GetAuthorizedServicesUsingGET (string secureId)

getAuthorizedServices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAuthorizedServicesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var secureId = secureId_example;  // string | secureId

            try
            {
                // getAuthorizedServices
                AuthorizedServicesResponse result = apiInstance.GetAuthorizedServicesUsingGET(secureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetAuthorizedServicesUsingGET: " + e.Message );
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

[**AuthorizedServicesResponse**](AuthorizedServicesResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharginglogbysubscriptionusingget"></a>
# **GetChargingLogBySubscriptionUsingGET**
> List<ChargingLog> GetChargingLogBySubscriptionUsingGET (long? id)

getChargingLogBySubscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetChargingLogBySubscriptionUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 789;  // long? | id

            try
            {
                // getChargingLogBySubscription
                List&lt;ChargingLog&gt; result = apiInstance.GetChargingLogBySubscriptionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetChargingLogBySubscriptionUsingGET: " + e.Message );
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

[**List<ChargingLog>**](ChargingLog.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomertotalamountusingget"></a>
# **GetCustomerTotalAmountUsingGET**
> long? GetCustomerTotalAmountUsingGET (string id)

getCustomerTotalAmount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetCustomerTotalAmountUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = id_example;  // string | id

            try
            {
                // getCustomerTotalAmount
                long? result = apiInstance.GetCustomerTotalAmountUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetCustomerTotalAmountUsingGET: " + e.Message );
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

**long?**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicedetailsusingget"></a>
# **GetInvoiceDetailsUsingGET**
> Object GetInvoiceDetailsUsingGET (InvoiceRequest invoiceRequest)

getInvoiceDetails

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetInvoiceDetailsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var invoiceRequest = new InvoiceRequest(); // InvoiceRequest | invoiceRequest

            try
            {
                // getInvoiceDetails
                Object result = apiInstance.GetInvoiceDetailsUsingGET(invoiceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetInvoiceDetailsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceRequest** | [**InvoiceRequest**](InvoiceRequest.md)| invoiceRequest | 

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagetemplateusingget"></a>
# **GetMessageTemplateUsingGET**
> MessageTemplate GetMessageTemplateUsingGET (string lifecycleEventName)

getMessageTemplate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetMessageTemplateUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var lifecycleEventName = lifecycleEventName_example;  // string | lifecycleEventName

            try
            {
                // getMessageTemplate
                MessageTemplate result = apiInstance.GetMessageTemplateUsingGET(lifecycleEventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetMessageTemplateUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lifecycleEventName** | **string**| lifecycleEventName | 

### Return type

[**MessageTemplate**](MessageTemplate.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceinstancesbysubscriptionusingget"></a>
# **GetServiceInstancesBySubscriptionUsingGET**
> List<ServiceInstanceResult> GetServiceInstancesBySubscriptionUsingGET (long? id)

getServiceInstancesBySubscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetServiceInstancesBySubscriptionUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 789;  // long? | id

            try
            {
                // getServiceInstancesBySubscription
                List&lt;ServiceInstanceResult&gt; result = apiInstance.GetServiceInstancesBySubscriptionUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetServiceInstancesBySubscriptionUsingGET: " + e.Message );
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

[**List<ServiceInstanceResult>**](ServiceInstanceResult.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceofferingsbysubscriptionplanusingget"></a>
# **GetServiceOfferingsBySubscriptionPlanUsingGET**
> List<ServiceOfferingResult> GetServiceOfferingsBySubscriptionPlanUsingGET (long? id)

getServiceOfferingsBySubscriptionPlan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetServiceOfferingsBySubscriptionPlanUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 789;  // long? | id

            try
            {
                // getServiceOfferingsBySubscriptionPlan
                List&lt;ServiceOfferingResult&gt; result = apiInstance.GetServiceOfferingsBySubscriptionPlanUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetServiceOfferingsBySubscriptionPlanUsingGET: " + e.Message );
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

[**List<ServiceOfferingResult>**](ServiceOfferingResult.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettotalrevenuepermonthusingget"></a>
# **GetTotalRevenuePerMonthUsingGET**
> List<Object> GetTotalRevenuePerMonthUsingGET (long? id)

getTotalRevenuePerMonth

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetTotalRevenuePerMonthUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 789;  // long? | id

            try
            {
                // getTotalRevenuePerMonth
                List&lt;Object&gt; result = apiInstance.GetTotalRevenuePerMonthUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetTotalRevenuePerMonthUsingGET: " + e.Message );
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

**List<Object>**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

