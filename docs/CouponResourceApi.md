# IO.Swagger.com.kodfarki.subscreasy.client.CouponResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponUsingPOST**](CouponResourceApi.md#createcouponusingpost) | **POST** /api/coupons | createCoupon
[**DeleteCouponUsingDELETE**](CouponResourceApi.md#deletecouponusingdelete) | **DELETE** /api/coupons/{id} | deleteCoupon
[**GetAllCouponsUsingGET**](CouponResourceApi.md#getallcouponsusingget) | **GET** /api/coupons | getAllCoupons
[**GetCouponUsingGET**](CouponResourceApi.md#getcouponusingget) | **GET** /api/coupons/{id} | getCoupon
[**UpdateCouponUsingPUT**](CouponResourceApi.md#updatecouponusingput) | **PUT** /api/coupons | updateCoupon


<a name="createcouponusingpost"></a>
# **CreateCouponUsingPOST**
> Coupon CreateCouponUsingPOST (Coupon coupon)

createCoupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateCouponUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CouponResourceApi();
            var coupon = new Coupon(); // Coupon | coupon

            try
            {
                // createCoupon
                Coupon result = apiInstance.CreateCouponUsingPOST(coupon);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponResourceApi.CreateCouponUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **coupon** | [**Coupon**](Coupon.md)| coupon | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponusingdelete"></a>
# **DeleteCouponUsingDELETE**
> void DeleteCouponUsingDELETE (long? id)

deleteCoupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteCouponUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CouponResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteCoupon
                apiInstance.DeleteCouponUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponResourceApi.DeleteCouponUsingDELETE: " + e.Message );
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

<a name="getallcouponsusingget"></a>
# **GetAllCouponsUsingGET**
> List<Coupon> GetAllCouponsUsingGET ()

getAllCoupons

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllCouponsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CouponResourceApi();

            try
            {
                // getAllCoupons
                List&lt;Coupon&gt; result = apiInstance.GetAllCouponsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponResourceApi.GetAllCouponsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Coupon>**](Coupon.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponusingget"></a>
# **GetCouponUsingGET**
> Coupon GetCouponUsingGET (long? id)

getCoupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetCouponUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CouponResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getCoupon
                Coupon result = apiInstance.GetCouponUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponResourceApi.GetCouponUsingGET: " + e.Message );
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

[**Coupon**](Coupon.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecouponusingput"></a>
# **UpdateCouponUsingPUT**
> Coupon UpdateCouponUsingPUT (Coupon coupon)

updateCoupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateCouponUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CouponResourceApi();
            var coupon = new Coupon(); // Coupon | coupon

            try
            {
                // updateCoupon
                Coupon result = apiInstance.UpdateCouponUsingPUT(coupon);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponResourceApi.UpdateCouponUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **coupon** | [**Coupon**](Coupon.md)| coupon | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

