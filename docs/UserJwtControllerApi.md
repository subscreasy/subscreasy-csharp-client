# IO.Swagger.com.kodfarki.subscreasy.client.UserJwtControllerApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorizeUsingPOST**](UserJwtControllerApi.md#authorizeusingpost) | **POST** /api/authenticate | authorize


<a name="authorizeusingpost"></a>
# **AuthorizeUsingPOST**
> ResponseEntity AuthorizeUsingPOST (LoginVM loginVM)

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
    public class AuthorizeUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserJwtControllerApi();
            var loginVM = new LoginVM(); // LoginVM | loginVM

            try
            {
                // authorize
                ResponseEntity result = apiInstance.AuthorizeUsingPOST(loginVM);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserJwtControllerApi.AuthorizeUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginVM** | [**LoginVM**](LoginVM.md)| loginVM | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

