# IO.Swagger.com.kodfarki.subscreasy.client.OfferResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveOfferUsingPUT**](OfferResourceApi.md#archiveofferusingput) | **PUT** /api/offers/archive/{id} | archiveOffer
[**CreateOfferUsingPOST**](OfferResourceApi.md#createofferusingpost) | **POST** /api/offers | createOffer
[**DeleteOfferUsingDELETE**](OfferResourceApi.md#deleteofferusingdelete) | **DELETE** /api/offers/{id} | deleteOffer
[**GetAllOffersUsingGET**](OfferResourceApi.md#getalloffersusingget) | **GET** /api/offers | getAllOffers
[**GetOfferUsingGET**](OfferResourceApi.md#getofferusingget) | **GET** /api/offers/{id} | getOffer
[**SendOfferPriceChangedEmailUsingPUT**](OfferResourceApi.md#sendofferpricechangedemailusingput) | **PUT** /api/offers/sendOfferPriceChangedEmail/{offerId} | sendOfferPriceChangedEmail
[**UpdateOfferUsingPUT**](OfferResourceApi.md#updateofferusingput) | **PUT** /api/offers | updateOffer
[**UploadFileUsingPOST1**](OfferResourceApi.md#uploadfileusingpost1) | **POST** /api/offers/uploadFile/{offerId} | uploadFile


<a name="archiveofferusingput"></a>
# **ArchiveOfferUsingPUT**
> void ArchiveOfferUsingPUT (long? id)

archiveOffer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class ArchiveOfferUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var id = 789;  // long? | id

            try
            {
                // archiveOffer
                apiInstance.ArchiveOfferUsingPUT(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.ArchiveOfferUsingPUT: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createofferusingpost"></a>
# **CreateOfferUsingPOST**
> Offer CreateOfferUsingPOST (Offer offer)

createOffer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateOfferUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var offer = new Offer(); // Offer | offer

            try
            {
                // createOffer
                Offer result = apiInstance.CreateOfferUsingPOST(offer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.CreateOfferUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer** | [**Offer**](Offer.md)| offer | 

### Return type

[**Offer**](Offer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteofferusingdelete"></a>
# **DeleteOfferUsingDELETE**
> void DeleteOfferUsingDELETE (long? id)

deleteOffer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteOfferUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteOffer
                apiInstance.DeleteOfferUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.DeleteOfferUsingDELETE: " + e.Message );
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

<a name="getalloffersusingget"></a>
# **GetAllOffersUsingGET**
> List<Offer> GetAllOffersUsingGET ()

getAllOffers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllOffersUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();

            try
            {
                // getAllOffers
                List&lt;Offer&gt; result = apiInstance.GetAllOffersUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.GetAllOffersUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Offer>**](Offer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofferusingget"></a>
# **GetOfferUsingGET**
> Offer GetOfferUsingGET (long? id)

getOffer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetOfferUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getOffer
                Offer result = apiInstance.GetOfferUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.GetOfferUsingGET: " + e.Message );
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

[**Offer**](Offer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendofferpricechangedemailusingput"></a>
# **SendOfferPriceChangedEmailUsingPUT**
> void SendOfferPriceChangedEmailUsingPUT (long? offerId)

sendOfferPriceChangedEmail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SendOfferPriceChangedEmailUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var offerId = 789;  // long? | offerId

            try
            {
                // sendOfferPriceChangedEmail
                apiInstance.SendOfferPriceChangedEmailUsingPUT(offerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.SendOfferPriceChangedEmailUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **long?**| offerId | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateofferusingput"></a>
# **UpdateOfferUsingPUT**
> Offer UpdateOfferUsingPUT (Offer offer)

updateOffer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateOfferUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var offer = new Offer(); // Offer | offer

            try
            {
                // updateOffer
                Offer result = apiInstance.UpdateOfferUsingPUT(offer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.UpdateOfferUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer** | [**Offer**](Offer.md)| offer | 

### Return type

[**Offer**](Offer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfileusingpost1"></a>
# **UploadFileUsingPOST1**
> Offer UploadFileUsingPOST1 (System.IO.Stream file, long? offerId)

uploadFile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UploadFileUsingPOST1Example
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfferResourceApi();
            var file = new System.IO.Stream(); // System.IO.Stream | file
            var offerId = 789;  // long? | offerId

            try
            {
                // uploadFile
                Offer result = apiInstance.UploadFileUsingPOST1(file, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferResourceApi.UploadFileUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| file | 
 **offerId** | **long?**| offerId | 

### Return type

[**Offer**](Offer.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

