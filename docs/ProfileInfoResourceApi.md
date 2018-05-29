# IO.Swagger.com.kodfarki.subscreasy.client.ProfileInfoResourceApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActiveProfilesUsingGET**](ProfileInfoResourceApi.md#getactiveprofilesusingget) | **GET** /api/profile-info | getActiveProfiles


<a name="getactiveprofilesusingget"></a>
# **GetActiveProfilesUsingGET**
> ProfileInfoVM GetActiveProfilesUsingGET ()

getActiveProfiles

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetActiveProfilesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfileInfoResourceApi();

            try
            {
                // getActiveProfiles
                ProfileInfoVM result = apiInstance.GetActiveProfilesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileInfoResourceApi.GetActiveProfilesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProfileInfoVM**](ProfileInfoVM.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

