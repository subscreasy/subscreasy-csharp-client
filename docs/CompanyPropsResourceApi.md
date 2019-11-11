# IO.Swagger.com.kodfarki.subscreasy.client.CompanyPropsResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCompanyPropsUsingPOST**](CompanyPropsResourceApi.md#createcompanypropsusingpost) | **POST** /api/company-props | createCompanyProps
[**DeleteCompanyPropsUsingDELETE**](CompanyPropsResourceApi.md#deletecompanypropsusingdelete) | **DELETE** /api/company-props/{id} | deleteCompanyProps
[**GetAllCompanyPropsUsingGET**](CompanyPropsResourceApi.md#getallcompanypropsusingget) | **GET** /api/company-props | getAllCompanyProps
[**GetCompanyPropsByCompanyIdUsingGET**](CompanyPropsResourceApi.md#getcompanypropsbycompanyidusingget) | **GET** /api/company-props/company/{companyId} | getCompanyPropsByCompanyId
[**UpdateCompanyPropsUsingPUT**](CompanyPropsResourceApi.md#updatecompanypropsusingput) | **PUT** /api/company-props | updateCompanyProps
[**UploadCSSUsingPOST**](CompanyPropsResourceApi.md#uploadcssusingpost) | **POST** /api/company-props/uploadCSS | uploadCSS
[**UploadFileUsingPOST**](CompanyPropsResourceApi.md#uploadfileusingpost) | **POST** /api/company-props/uploadFile | uploadFile


<a name="createcompanypropsusingpost"></a>
# **CreateCompanyPropsUsingPOST**
> CompanyProps CreateCompanyPropsUsingPOST (CompanyProps companyProps)

createCompanyProps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateCompanyPropsUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();
            var companyProps = new CompanyProps(); // CompanyProps | companyProps

            try
            {
                // createCompanyProps
                CompanyProps result = apiInstance.CreateCompanyPropsUsingPOST(companyProps);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.CreateCompanyPropsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyProps** | [**CompanyProps**](CompanyProps.md)| companyProps | 

### Return type

[**CompanyProps**](CompanyProps.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecompanypropsusingdelete"></a>
# **DeleteCompanyPropsUsingDELETE**
> void DeleteCompanyPropsUsingDELETE (long? id)

deleteCompanyProps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteCompanyPropsUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteCompanyProps
                apiInstance.DeleteCompanyPropsUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.DeleteCompanyPropsUsingDELETE: " + e.Message );
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

<a name="getallcompanypropsusingget"></a>
# **GetAllCompanyPropsUsingGET**
> List<CompanyProps> GetAllCompanyPropsUsingGET ()

getAllCompanyProps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllCompanyPropsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();

            try
            {
                // getAllCompanyProps
                List&lt;CompanyProps&gt; result = apiInstance.GetAllCompanyPropsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.GetAllCompanyPropsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CompanyProps>**](CompanyProps.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcompanypropsbycompanyidusingget"></a>
# **GetCompanyPropsByCompanyIdUsingGET**
> CompanyProps GetCompanyPropsByCompanyIdUsingGET (long? companyId)

getCompanyPropsByCompanyId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetCompanyPropsByCompanyIdUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();
            var companyId = 789;  // long? | companyId

            try
            {
                // getCompanyPropsByCompanyId
                CompanyProps result = apiInstance.GetCompanyPropsByCompanyIdUsingGET(companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.GetCompanyPropsByCompanyIdUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **long?**| companyId | 

### Return type

[**CompanyProps**](CompanyProps.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecompanypropsusingput"></a>
# **UpdateCompanyPropsUsingPUT**
> CompanyProps UpdateCompanyPropsUsingPUT (CompanyProps companyProps)

updateCompanyProps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateCompanyPropsUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();
            var companyProps = new CompanyProps(); // CompanyProps | companyProps

            try
            {
                // updateCompanyProps
                CompanyProps result = apiInstance.UpdateCompanyPropsUsingPUT(companyProps);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.UpdateCompanyPropsUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyProps** | [**CompanyProps**](CompanyProps.md)| companyProps | 

### Return type

[**CompanyProps**](CompanyProps.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadcssusingpost"></a>
# **UploadCSSUsingPOST**
> Object UploadCSSUsingPOST (System.IO.Stream file)

uploadCSS

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UploadCSSUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();
            var file = new System.IO.Stream(); // System.IO.Stream | file

            try
            {
                // uploadCSS
                Object result = apiInstance.UploadCSSUsingPOST(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.UploadCSSUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| file | 

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfileusingpost"></a>
# **UploadFileUsingPOST**
> Object UploadFileUsingPOST (System.IO.Stream file)

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
    public class UploadFileUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompanyPropsResourceApi();
            var file = new System.IO.Stream(); // System.IO.Stream | file

            try
            {
                // uploadFile
                Object result = apiInstance.UploadFileUsingPOST(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyPropsResourceApi.UploadFileUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| file | 

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

