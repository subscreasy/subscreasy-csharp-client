# IO.Swagger.com.kodfarki.subscreasy.client.AccountResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IsAuthenticatedUsingGET**](AccountResourceApi.md#isauthenticatedusingget) | **GET** /api/authenticate | isAuthenticated
[**RegisterAccountUsingPOST**](AccountResourceApi.md#registeraccountusingpost) | **POST** /api/register | registerAccount


<a name="isauthenticatedusingget"></a>
# **IsAuthenticatedUsingGET**
> string IsAuthenticatedUsingGET ()

isAuthenticated

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class IsAuthenticatedUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountResourceApi();

            try
            {
                // isAuthenticated
                string result = apiInstance.IsAuthenticatedUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountResourceApi.IsAuthenticatedUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeraccountusingpost"></a>
# **RegisterAccountUsingPOST**
> ResponseEntity RegisterAccountUsingPOST (UserDTO managedUserVM)

registerAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class RegisterAccountUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountResourceApi();
            var managedUserVM = new UserDTO(); // UserDTO | managedUserVM

            try
            {
                // registerAccount
                ResponseEntity result = apiInstance.RegisterAccountUsingPOST(managedUserVM);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountResourceApi.RegisterAccountUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **managedUserVM** | [**UserDTO**](UserDTO.md)| managedUserVM | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

