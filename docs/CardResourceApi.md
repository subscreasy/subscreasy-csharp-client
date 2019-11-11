# IO.Swagger.com.kodfarki.subscreasy.client.CardResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SaveCardUsingPOST**](CardResourceApi.md#savecardusingpost) | **POST** /api/card | saveCard


<a name="savecardusingpost"></a>
# **SaveCardUsingPOST**
> Object SaveCardUsingPOST (SaveCardRequest request)

saveCard

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class SaveCardUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CardResourceApi();
            var request = new SaveCardRequest(); // SaveCardRequest | request

            try
            {
                // saveCard
                Object result = apiInstance.SaveCardUsingPOST(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardResourceApi.SaveCardUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveCardRequest**](SaveCardRequest.md)| request | 

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

