# IO.Swagger.com.kodfarki.subscreasy.client.MessageTemplateResourceApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMessageTemplateUsingPOST**](MessageTemplateResourceApi.md#createmessagetemplateusingpost) | **POST** /api/message-templates | createMessageTemplate
[**DeleteMessageTemplateUsingDELETE**](MessageTemplateResourceApi.md#deletemessagetemplateusingdelete) | **DELETE** /api/message-templates/{id} | deleteMessageTemplate
[**GetAllMessageTemplatesUsingGET**](MessageTemplateResourceApi.md#getallmessagetemplatesusingget) | **GET** /api/message-templates | getAllMessageTemplates
[**GetMessageTemplateUsingGET1**](MessageTemplateResourceApi.md#getmessagetemplateusingget1) | **GET** /api/message-templates/{id} | getMessageTemplate
[**UpdateMessageTemplateUsingPUT**](MessageTemplateResourceApi.md#updatemessagetemplateusingput) | **PUT** /api/message-templates | updateMessageTemplate


<a name="createmessagetemplateusingpost"></a>
# **CreateMessageTemplateUsingPOST**
> MessageTemplate CreateMessageTemplateUsingPOST (MessageTemplate messageTemplate)

createMessageTemplate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class CreateMessageTemplateUsingPOSTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageTemplateResourceApi();
            var messageTemplate = new MessageTemplate(); // MessageTemplate | messageTemplate

            try
            {
                // createMessageTemplate
                MessageTemplate result = apiInstance.CreateMessageTemplateUsingPOST(messageTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageTemplateResourceApi.CreateMessageTemplateUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageTemplate** | [**MessageTemplate**](MessageTemplate.md)| messageTemplate | 

### Return type

[**MessageTemplate**](MessageTemplate.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemessagetemplateusingdelete"></a>
# **DeleteMessageTemplateUsingDELETE**
> void DeleteMessageTemplateUsingDELETE (long? id)

deleteMessageTemplate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class DeleteMessageTemplateUsingDELETEExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageTemplateResourceApi();
            var id = 789;  // long? | id

            try
            {
                // deleteMessageTemplate
                apiInstance.DeleteMessageTemplateUsingDELETE(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageTemplateResourceApi.DeleteMessageTemplateUsingDELETE: " + e.Message );
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

<a name="getallmessagetemplatesusingget"></a>
# **GetAllMessageTemplatesUsingGET**
> List<MessageTemplate> GetAllMessageTemplatesUsingGET ()

getAllMessageTemplates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetAllMessageTemplatesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageTemplateResourceApi();

            try
            {
                // getAllMessageTemplates
                List&lt;MessageTemplate&gt; result = apiInstance.GetAllMessageTemplatesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageTemplateResourceApi.GetAllMessageTemplatesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MessageTemplate>**](MessageTemplate.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagetemplateusingget1"></a>
# **GetMessageTemplateUsingGET1**
> MessageTemplate GetMessageTemplateUsingGET1 (long? id)

getMessageTemplate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class GetMessageTemplateUsingGET1Example
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageTemplateResourceApi();
            var id = 789;  // long? | id

            try
            {
                // getMessageTemplate
                MessageTemplate result = apiInstance.GetMessageTemplateUsingGET1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageTemplateResourceApi.GetMessageTemplateUsingGET1: " + e.Message );
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

[**MessageTemplate**](MessageTemplate.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemessagetemplateusingput"></a>
# **UpdateMessageTemplateUsingPUT**
> MessageTemplate UpdateMessageTemplateUsingPUT (MessageTemplate messageTemplate)

updateMessageTemplate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class UpdateMessageTemplateUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessageTemplateResourceApi();
            var messageTemplate = new MessageTemplate(); // MessageTemplate | messageTemplate

            try
            {
                // updateMessageTemplate
                MessageTemplate result = apiInstance.UpdateMessageTemplateUsingPUT(messageTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageTemplateResourceApi.UpdateMessageTemplateUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageTemplate** | [**MessageTemplate**](MessageTemplate.md)| messageTemplate | 

### Return type

[**MessageTemplate**](MessageTemplate.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

