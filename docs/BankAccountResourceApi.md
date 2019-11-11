# IO.Swagger.com.kodfarki.subscreasy.client.BankAccountResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBankAccountUsingPOST**](BankAccountResourceApi.md#createbankaccountusingpost) | **POST** /api/bank-accounts | createBankAccount
[**DeleteBankAccountUsingDELETE**](BankAccountResourceApi.md#deletebankaccountusingdelete) | **DELETE** /api/bank-accounts/{id} | deleteBankAccount
[**GetAllBankAccountsUsingGET**](BankAccountResourceApi.md#getallbankaccountsusingget) | **GET** /api/bank-accounts | getAllBankAccounts
[**GetBankAccountUsingGET**](BankAccountResourceApi.md#getbankaccountusingget) | **GET** /api/bank-accounts/{id} | getBankAccount
[**GetBankAccountsByCompanyUsingGET**](BankAccountResourceApi.md#getbankaccountsbycompanyusingget) | **GET** /api/bank-accounts/company/{companyId} | getBankAccountsByCompany
[**UpdateBankAccountUsingPUT**](BankAccountResourceApi.md#updatebankaccountusingput) | **PUT** /api/bank-accounts | updateBankAccount


<a name="createbankaccountusingpost"></a>
# **CreateBankAccountUsingPOST**
> BankAccount CreateBankAccountUsingPOST (BankAccount bankAccount)

createBankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateBankAccountUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankAccountResourceApi();
            var bankAccount = new BankAccount(); // BankAccount | bankAccount

            try
            {
                // createBankAccount
                BankAccount result = apiInstance.CreateBankAccountUsingPOST(bankAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountResourceApi.CreateBankAccountUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankAccount** | [**BankAccount**](BankAccount.md)| bankAccount | 

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebankaccountusingdelete"></a>
# **DeleteBankAccountUsingDELETE**
> void DeleteBankAccountUsingDELETE (long? id)

deleteBankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteBankAccountUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankAccountResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteBankAccount
                apiInstance.DeleteBankAccountUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountResourceApi.DeleteBankAccountUsingDELETE: " + e.Message );
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

<a name="getallbankaccountsusingget"></a>
# **GetAllBankAccountsUsingGET**
> List<BankAccount> GetAllBankAccountsUsingGET ()

getAllBankAccounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllBankAccountsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankAccountResourceApi();

            try
            {
                // getAllBankAccounts
                List&lt;BankAccount&gt; result = apiInstance.GetAllBankAccountsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountResourceApi.GetAllBankAccountsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BankAccount>**](BankAccount.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccountusingget"></a>
# **GetBankAccountUsingGET**
> BankAccount GetBankAccountUsingGET (long? id)

getBankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetBankAccountUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankAccountResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getBankAccount
                BankAccount result = apiInstance.GetBankAccountUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountResourceApi.GetBankAccountUsingGET: " + e.Message );
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

[**BankAccount**](BankAccount.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccountsbycompanyusingget"></a>
# **GetBankAccountsByCompanyUsingGET**
> List<BankAccount> GetBankAccountsByCompanyUsingGET (long? companyId)

getBankAccountsByCompany

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetBankAccountsByCompanyUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankAccountResourceApi();
            var companyId = 789;  // long? | companyId

            try
            {
                // getBankAccountsByCompany
                List&lt;BankAccount&gt; result = apiInstance.GetBankAccountsByCompanyUsingGET(companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountResourceApi.GetBankAccountsByCompanyUsingGET: " + e.Message );
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

[**List<BankAccount>**](BankAccount.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebankaccountusingput"></a>
# **UpdateBankAccountUsingPUT**
> BankAccount UpdateBankAccountUsingPUT (BankAccount bankAccount)

updateBankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateBankAccountUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankAccountResourceApi();
            var bankAccount = new BankAccount(); // BankAccount | bankAccount

            try
            {
                // updateBankAccount
                BankAccount result = apiInstance.UpdateBankAccountUsingPUT(bankAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountResourceApi.UpdateBankAccountUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankAccount** | [**BankAccount**](BankAccount.md)| bankAccount | 

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

