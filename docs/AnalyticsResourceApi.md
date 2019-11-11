# IO.Swagger.com.kodfarki.subscreasy.client.AnalyticsResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDashboardAnalyticsUsingGET**](AnalyticsResourceApi.md#getdashboardanalyticsusingget) | **GET** /api/analytics/dashboard | getDashboardAnalytics


<a name="getdashboardanalyticsusingget"></a>
# **GetDashboardAnalyticsUsingGET**
> Object GetDashboardAnalyticsUsingGET ()

getDashboardAnalytics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetDashboardAnalyticsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AnalyticsResourceApi();

            try
            {
                // getDashboardAnalytics
                Object result = apiInstance.GetDashboardAnalyticsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsResourceApi.GetDashboardAnalyticsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

