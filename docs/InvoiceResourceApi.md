# IO.Swagger.com.kodfarki.subscreasy.client.InvoiceResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoiceUsingPOST**](InvoiceResourceApi.md#createinvoiceusingpost) | **POST** /api/invoices | createInvoice
[**DeleteInvoiceUsingDELETE**](InvoiceResourceApi.md#deleteinvoiceusingdelete) | **DELETE** /api/invoices/{id} | deleteInvoice
[**GetAllInvoicesUsingGET**](InvoiceResourceApi.md#getallinvoicesusingget) | **GET** /api/invoices | getAllInvoices
[**GetInvoiceBySubscriberUsingGET**](InvoiceResourceApi.md#getinvoicebysubscriberusingget) | **GET** /api/invoices/subscriber/{subscriberSecureId} | getInvoiceBySubscriber
[**GetInvoiceUsingGET**](InvoiceResourceApi.md#getinvoiceusingget) | **GET** /api/invoices/{id} | getInvoice
[**UpdateInvoiceUsingPUT**](InvoiceResourceApi.md#updateinvoiceusingput) | **PUT** /api/invoices | updateInvoice


<a name="createinvoiceusingpost"></a>
# **CreateInvoiceUsingPOST**
> Invoice CreateInvoiceUsingPOST (Invoice invoice)

createInvoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateInvoiceUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvoiceResourceApi();
            var invoice = new Invoice(); // Invoice | invoice

            try
            {
                // createInvoice
                Invoice result = apiInstance.CreateInvoiceUsingPOST(invoice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceResourceApi.CreateInvoiceUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoice** | [**Invoice**](Invoice.md)| invoice | 

### Return type

[**Invoice**](Invoice.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvoiceusingdelete"></a>
# **DeleteInvoiceUsingDELETE**
> void DeleteInvoiceUsingDELETE (long? id)

deleteInvoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteInvoiceUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvoiceResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteInvoice
                apiInstance.DeleteInvoiceUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceResourceApi.DeleteInvoiceUsingDELETE: " + e.Message );
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

<a name="getallinvoicesusingget"></a>
# **GetAllInvoicesUsingGET**
> List<Invoice> GetAllInvoicesUsingGET ()

getAllInvoices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllInvoicesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvoiceResourceApi();

            try
            {
                // getAllInvoices
                List&lt;Invoice&gt; result = apiInstance.GetAllInvoicesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceResourceApi.GetAllInvoicesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Invoice>**](Invoice.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicebysubscriberusingget"></a>
# **GetInvoiceBySubscriberUsingGET**
> List<Invoice> GetInvoiceBySubscriberUsingGET (string subscriberSecureId)

getInvoiceBySubscriber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetInvoiceBySubscriberUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvoiceResourceApi();
            var subscriberSecureId = subscriberSecureId_example;  // string | subscriberSecureId

            try
            {
                // getInvoiceBySubscriber
                List&lt;Invoice&gt; result = apiInstance.GetInvoiceBySubscriberUsingGET(subscriberSecureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceResourceApi.GetInvoiceBySubscriberUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriberSecureId** | **string**| subscriberSecureId | 

### Return type

[**List<Invoice>**](Invoice.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceusingget"></a>
# **GetInvoiceUsingGET**
> Invoice GetInvoiceUsingGET (long? id)

getInvoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetInvoiceUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvoiceResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getInvoice
                Invoice result = apiInstance.GetInvoiceUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceResourceApi.GetInvoiceUsingGET: " + e.Message );
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

[**Invoice**](Invoice.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoiceusingput"></a>
# **UpdateInvoiceUsingPUT**
> Invoice UpdateInvoiceUsingPUT (Invoice invoice)

updateInvoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateInvoiceUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvoiceResourceApi();
            var invoice = new Invoice(); // Invoice | invoice

            try
            {
                // updateInvoice
                Invoice result = apiInstance.UpdateInvoiceUsingPUT(invoice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceResourceApi.UpdateInvoiceUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoice** | [**Invoice**](Invoice.md)| invoice | 

### Return type

[**Invoice**](Invoice.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

