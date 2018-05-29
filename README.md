# IO.Swagger - the C# library for the Api Documentation

Api Documentation

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost:8080*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AnalyticsResourceApi* | [**GetDashboardAnalyticsUsingGET**](docs/AnalyticsResourceApi.md#getdashboardanalyticsusingget) | **GET** /api/analytics/dashboard | getDashboardAnalytics
*CardResourceApi* | [**CreateCardUsingPOST**](docs/CardResourceApi.md#createcardusingpost) | **POST** /api/cards | createCard
*CardResourceApi* | [**DeleteCardUsingDELETE**](docs/CardResourceApi.md#deletecardusingdelete) | **DELETE** /api/cards/{id} | deleteCard
*CardResourceApi* | [**GetAllCardsUsingGET**](docs/CardResourceApi.md#getallcardsusingget) | **GET** /api/cards | getAllCards
*CardResourceApi* | [**GetCardUsingGET**](docs/CardResourceApi.md#getcardusingget) | **GET** /api/cards/{id} | getCard
*CardResourceApi* | [**UpdateCardUsingPUT**](docs/CardResourceApi.md#updatecardusingput) | **PUT** /api/cards | updateCard
*ChargingLogResourceApi* | [**CreateChargingLogUsingPOST**](docs/ChargingLogResourceApi.md#createcharginglogusingpost) | **POST** /api/charging-logs | createChargingLog
*ChargingLogResourceApi* | [**DeleteChargingLogUsingDELETE**](docs/ChargingLogResourceApi.md#deletecharginglogusingdelete) | **DELETE** /api/charging-logs/{id} | deleteChargingLog
*ChargingLogResourceApi* | [**GetAllChargingLogsUsingGET**](docs/ChargingLogResourceApi.md#getallcharginglogsusingget) | **GET** /api/charging-logs | getAllChargingLogs
*ChargingLogResourceApi* | [**GetChargingLogUsingGET**](docs/ChargingLogResourceApi.md#getcharginglogusingget) | **GET** /api/charging-logs/{id} | getChargingLog
*ChargingLogResourceApi* | [**RefundUsingPOST**](docs/ChargingLogResourceApi.md#refundusingpost) | **POST** /api/charging-logs/refund/{chargingLogId} | refund
*ChargingLogResourceApi* | [**UpdateChargingLogUsingPUT**](docs/ChargingLogResourceApi.md#updatecharginglogusingput) | **PUT** /api/charging-logs | updateChargingLog
*CompanyPropsResourceApi* | [**CreateCompanyPropsUsingPOST**](docs/CompanyPropsResourceApi.md#createcompanypropsusingpost) | **POST** /api/company-props | createCompanyProps
*CompanyPropsResourceApi* | [**DeleteCompanyPropsUsingDELETE**](docs/CompanyPropsResourceApi.md#deletecompanypropsusingdelete) | **DELETE** /api/company-props/{id} | deleteCompanyProps
*CompanyPropsResourceApi* | [**GetAllCompanyPropsUsingGET**](docs/CompanyPropsResourceApi.md#getallcompanypropsusingget) | **GET** /api/company-props | getAllCompanyProps
*CompanyPropsResourceApi* | [**GetCompanyPropsByCompanyIdUsingGET**](docs/CompanyPropsResourceApi.md#getcompanypropsbycompanyidusingget) | **GET** /api/company-props/company/{companyId} | getCompanyPropsByCompanyId
*CompanyPropsResourceApi* | [**UpdateCompanyPropsUsingPUT**](docs/CompanyPropsResourceApi.md#updatecompanypropsusingput) | **PUT** /api/company-props | updateCompanyProps
*CompanyResourceApi* | [**CreateCompanyUsingPOST**](docs/CompanyResourceApi.md#createcompanyusingpost) | **POST** /api/companies | createCompany
*CompanyResourceApi* | [**DeleteCompanyUsingDELETE**](docs/CompanyResourceApi.md#deletecompanyusingdelete) | **DELETE** /api/companies/{id} | deleteCompany
*CompanyResourceApi* | [**GetAllCompaniesUsingGET**](docs/CompanyResourceApi.md#getallcompaniesusingget) | **GET** /api/companies | getAllCompanies
*CompanyResourceApi* | [**GetCompanyUsingGET**](docs/CompanyResourceApi.md#getcompanyusingget) | **GET** /api/companies/{id} | getCompany
*CompanyResourceApi* | [**UpdateCompanyUsingPUT**](docs/CompanyResourceApi.md#updatecompanyusingput) | **PUT** /api/companies | updateCompany
*CouponResourceApi* | [**CreateCouponUsingPOST**](docs/CouponResourceApi.md#createcouponusingpost) | **POST** /api/coupons | createCoupon
*CouponResourceApi* | [**DeleteCouponUsingDELETE**](docs/CouponResourceApi.md#deletecouponusingdelete) | **DELETE** /api/coupons/{id} | deleteCoupon
*CouponResourceApi* | [**GetAllCouponsUsingGET**](docs/CouponResourceApi.md#getallcouponsusingget) | **GET** /api/coupons | getAllCoupons
*CouponResourceApi* | [**GetCouponUsingGET**](docs/CouponResourceApi.md#getcouponusingget) | **GET** /api/coupons/{id} | getCoupon
*CouponResourceApi* | [**UpdateCouponUsingPUT**](docs/CouponResourceApi.md#updatecouponusingput) | **PUT** /api/coupons | updateCoupon
*EndpointsApi* | [**AuthorizeUsingPUT**](docs/EndpointsApi.md#authorizeusingput) | **PUT** /api/authorize | authorize
*EndpointsApi* | [**DeductUsingPUT**](docs/EndpointsApi.md#deductusingput) | **PUT** /api/deduct | deduct
*EndpointsApi* | [**GetAuthorizedServicesUsingGET**](docs/EndpointsApi.md#getauthorizedservicesusingget) | **GET** /api/service/subscriber/{secureId} | getAuthorizedServices
*EndpointsApi* | [**GetChargingLogBySubscriptionUsingGET**](docs/EndpointsApi.md#getcharginglogbysubscriptionusingget) | **GET** /api/charging-logs/subscription/{id} | getChargingLogBySubscription
*EndpointsApi* | [**GetCustomerTotalAmountUsingGET**](docs/EndpointsApi.md#getcustomertotalamountusingget) | **GET** /api/customer-totalAmountCharge/{id} | getCustomerTotalAmount
*EndpointsApi* | [**GetInvoiceDetailsUsingGET**](docs/EndpointsApi.md#getinvoicedetailsusingget) | **GET** /api/getInvoiceDetails | getInvoiceDetails
*EndpointsApi* | [**GetMessageTemplateUsingGET**](docs/EndpointsApi.md#getmessagetemplateusingget) | **GET** /api/message-templates/email/{lifecycleEventName} | getMessageTemplate
*EndpointsApi* | [**GetServiceInstancesBySubscriptionUsingGET**](docs/EndpointsApi.md#getserviceinstancesbysubscriptionusingget) | **GET** /api/service-instances/subscription/{id} | getServiceInstancesBySubscription
*EndpointsApi* | [**GetServiceOfferingsBySubscriptionPlanUsingGET**](docs/EndpointsApi.md#getserviceofferingsbysubscriptionplanusingget) | **GET** /api/service-offerings/offer/{id} | getServiceOfferingsBySubscriptionPlan
*EndpointsApi* | [**GetTotalRevenuePerMonthUsingGET**](docs/EndpointsApi.md#gettotalrevenuepermonthusingget) | **GET** /api/charging-logs-totalamount-customer/{id} | getTotalRevenuePerMonth
*HistoryResourceApi* | [**CreateHistoryUsingPOST**](docs/HistoryResourceApi.md#createhistoryusingpost) | **POST** /api/histories | createHistory
*HistoryResourceApi* | [**DeleteHistoryUsingDELETE**](docs/HistoryResourceApi.md#deletehistoryusingdelete) | **DELETE** /api/histories/{id} | deleteHistory
*HistoryResourceApi* | [**GetAllHistoriesUsingGET**](docs/HistoryResourceApi.md#getallhistoriesusingget) | **GET** /api/histories | getAllHistories
*HistoryResourceApi* | [**GetHistoryUsingGET**](docs/HistoryResourceApi.md#gethistoryusingget) | **GET** /api/histories/{id} | getHistory
*HistoryResourceApi* | [**UpdateHistoryUsingPUT**](docs/HistoryResourceApi.md#updatehistoryusingput) | **PUT** /api/histories | updateHistory
*InvoiceResourceApi* | [**CreateInvoiceUsingPOST**](docs/InvoiceResourceApi.md#createinvoiceusingpost) | **POST** /api/invoices | createInvoice
*InvoiceResourceApi* | [**DeleteInvoiceUsingDELETE**](docs/InvoiceResourceApi.md#deleteinvoiceusingdelete) | **DELETE** /api/invoices/{id} | deleteInvoice
*InvoiceResourceApi* | [**GetAllInvoicesUsingGET**](docs/InvoiceResourceApi.md#getallinvoicesusingget) | **GET** /api/invoices | getAllInvoices
*InvoiceResourceApi* | [**GetInvoiceBySubscriberUsingGET**](docs/InvoiceResourceApi.md#getinvoicebysubscriberusingget) | **GET** /api/invoices/subscriber/{subscriberSecureId} | getInvoiceBySubscriber
*InvoiceResourceApi* | [**GetInvoiceUsingGET**](docs/InvoiceResourceApi.md#getinvoiceusingget) | **GET** /api/invoices/{id} | getInvoice
*InvoiceResourceApi* | [**UpdateInvoiceUsingPUT**](docs/InvoiceResourceApi.md#updateinvoiceusingput) | **PUT** /api/invoices | updateInvoice
*MessageTemplateResourceApi* | [**CreateMessageTemplateUsingPOST**](docs/MessageTemplateResourceApi.md#createmessagetemplateusingpost) | **POST** /api/message-templates | createMessageTemplate
*MessageTemplateResourceApi* | [**DeleteMessageTemplateUsingDELETE**](docs/MessageTemplateResourceApi.md#deletemessagetemplateusingdelete) | **DELETE** /api/message-templates/{id} | deleteMessageTemplate
*MessageTemplateResourceApi* | [**GetAllMessageTemplatesUsingGET**](docs/MessageTemplateResourceApi.md#getallmessagetemplatesusingget) | **GET** /api/message-templates | getAllMessageTemplates
*MessageTemplateResourceApi* | [**GetMessageTemplateUsingGET1**](docs/MessageTemplateResourceApi.md#getmessagetemplateusingget1) | **GET** /api/message-templates/{id} | getMessageTemplate
*MessageTemplateResourceApi* | [**UpdateMessageTemplateUsingPUT**](docs/MessageTemplateResourceApi.md#updatemessagetemplateusingput) | **PUT** /api/message-templates | updateMessageTemplate
*OfferResourceApi* | [**CreateOfferUsingPOST**](docs/OfferResourceApi.md#createofferusingpost) | **POST** /api/offers | createOffer
*OfferResourceApi* | [**DeleteOfferUsingDELETE**](docs/OfferResourceApi.md#deleteofferusingdelete) | **DELETE** /api/offers/{id} | deleteOffer
*OfferResourceApi* | [**GetAllOffersUsingGET**](docs/OfferResourceApi.md#getalloffersusingget) | **GET** /api/offers | getAllOffers
*OfferResourceApi* | [**GetOfferUsingGET**](docs/OfferResourceApi.md#getofferusingget) | **GET** /api/offers/{id} | getOffer
*OfferResourceApi* | [**UpdateOfferUsingPUT**](docs/OfferResourceApi.md#updateofferusingput) | **PUT** /api/offers | updateOffer
*ProfileInfoResourceApi* | [**GetActiveProfilesUsingGET**](docs/ProfileInfoResourceApi.md#getactiveprofilesusingget) | **GET** /api/profile-info | getActiveProfiles
*ServiceInstanceResourceApi* | [**CreateServiceInstanceUsingPOST**](docs/ServiceInstanceResourceApi.md#createserviceinstanceusingpost) | **POST** /api/service-instances | createServiceInstance
*ServiceInstanceResourceApi* | [**DeleteServiceInstanceUsingDELETE**](docs/ServiceInstanceResourceApi.md#deleteserviceinstanceusingdelete) | **DELETE** /api/service-instances/{id} | deleteServiceInstance
*ServiceInstanceResourceApi* | [**GetAllServiceInstancesUsingGET**](docs/ServiceInstanceResourceApi.md#getallserviceinstancesusingget) | **GET** /api/service-instances | getAllServiceInstances
*ServiceInstanceResourceApi* | [**GetServiceInstanceUsingGET**](docs/ServiceInstanceResourceApi.md#getserviceinstanceusingget) | **GET** /api/service-instances/{id} | getServiceInstance
*ServiceInstanceResourceApi* | [**UpdateServiceInstanceUsingPUT**](docs/ServiceInstanceResourceApi.md#updateserviceinstanceusingput) | **PUT** /api/service-instances | updateServiceInstance
*ServiceOfferingResourceApi* | [**CreateServiceOfferingUsingPOST**](docs/ServiceOfferingResourceApi.md#createserviceofferingusingpost) | **POST** /api/service-offerings | createServiceOffering
*ServiceOfferingResourceApi* | [**DeleteServiceOfferingUsingDELETE**](docs/ServiceOfferingResourceApi.md#deleteserviceofferingusingdelete) | **DELETE** /api/service-offerings/{id} | deleteServiceOffering
*ServiceOfferingResourceApi* | [**GetAllServiceOfferingsUsingGET**](docs/ServiceOfferingResourceApi.md#getallserviceofferingsusingget) | **GET** /api/service-offerings | getAllServiceOfferings
*ServiceOfferingResourceApi* | [**GetServiceOfferingUsingGET**](docs/ServiceOfferingResourceApi.md#getserviceofferingusingget) | **GET** /api/service-offerings/{id} | getServiceOffering
*ServiceOfferingResourceApi* | [**UpdateServiceOfferingUsingPUT**](docs/ServiceOfferingResourceApi.md#updateserviceofferingusingput) | **PUT** /api/service-offerings | updateServiceOffering
*ServiceResourceApi* | [**CreateServiceUsingPOST**](docs/ServiceResourceApi.md#createserviceusingpost) | **POST** /api/services | createService
*ServiceResourceApi* | [**DeleteServiceUsingDELETE**](docs/ServiceResourceApi.md#deleteserviceusingdelete) | **DELETE** /api/services/{id} | deleteService
*ServiceResourceApi* | [**GetAllServicesUsingGET**](docs/ServiceResourceApi.md#getallservicesusingget) | **GET** /api/services | getAllServices
*ServiceResourceApi* | [**GetServiceUsingGET**](docs/ServiceResourceApi.md#getserviceusingget) | **GET** /api/services/{id} | getService
*ServiceResourceApi* | [**UpdateServiceUsingPUT**](docs/ServiceResourceApi.md#updateserviceusingput) | **PUT** /api/services | updateService
*SubscriberResourceApi* | [**CreateSubscriberUsingPOST**](docs/SubscriberResourceApi.md#createsubscriberusingpost) | **POST** /api/subscribers | createSubscriber
*SubscriberResourceApi* | [**DeleteSubscriberUsingDELETE**](docs/SubscriberResourceApi.md#deletesubscriberusingdelete) | **DELETE** /api/subscribers/{id} | deleteSubscriber
*SubscriberResourceApi* | [**GetAllSubscribersUsingGET**](docs/SubscriberResourceApi.md#getallsubscribersusingget) | **GET** /api/subscribers | getAllSubscribers
*SubscriberResourceApi* | [**GetSubscriberByEmailUsingGET**](docs/SubscriberResourceApi.md#getsubscriberbyemailusingget) | **GET** /api/subscribers/email/{email} | getSubscriberByEmail
*SubscriberResourceApi* | [**GetSubscriberByNameUsingGET**](docs/SubscriberResourceApi.md#getsubscriberbynameusingget) | **GET** /api/subscribers/name/{name} | getSubscriberByName
*SubscriberResourceApi* | [**GetSubscriberUsingGET**](docs/SubscriberResourceApi.md#getsubscriberusingget) | **GET** /api/subscribers/{id} | getSubscriber
*SubscriberResourceApi* | [**UpdateSubscriberUsingPUT**](docs/SubscriberResourceApi.md#updatesubscriberusingput) | **PUT** /api/subscribers | updateSubscriber
*SubsriptionResourceApi* | [**CancelSubscriptionUsingPUT**](docs/SubsriptionResourceApi.md#cancelsubscriptionusingput) | **PUT** /api/subscriptions/cancel | cancelSubscription
*SubsriptionResourceApi* | [**GetActiveSubscriptionsUsingGET**](docs/SubsriptionResourceApi.md#getactivesubscriptionsusingget) | **GET** /api/subsriptions/subscriber/{secureId} | getActiveSubscriptions
*SubsriptionResourceApi* | [**GetAllCompanySubscriptionsUsingGET**](docs/SubsriptionResourceApi.md#getallcompanysubscriptionsusingget) | **GET** /api/subscriptions/company/{id} | getAllCompanySubscriptions
*SubsriptionResourceApi* | [**GetSubsriptionUsingGET**](docs/SubsriptionResourceApi.md#getsubsriptionusingget) | **GET** /api/subsriptions/{id} | getSubsription
*SubsriptionResourceApi* | [**StartSubscriptionUsingPOST**](docs/SubsriptionResourceApi.md#startsubscriptionusingpost) | **POST** /api/subscriptions/start | startSubscription
*UsageNotificationResourceApi* | [**CreateUsageNotificationUsingPOST**](docs/UsageNotificationResourceApi.md#createusagenotificationusingpost) | **POST** /api/usage-notifications | createUsageNotification
*UsageNotificationResourceApi* | [**DeleteUsageNotificationUsingDELETE**](docs/UsageNotificationResourceApi.md#deleteusagenotificationusingdelete) | **DELETE** /api/usage-notifications/{id} | deleteUsageNotification
*UsageNotificationResourceApi* | [**GetAllUsageNotificationsUsingGET**](docs/UsageNotificationResourceApi.md#getallusagenotificationsusingget) | **GET** /api/usage-notifications | getAllUsageNotifications
*UsageNotificationResourceApi* | [**GetUsageNotificationUsingGET**](docs/UsageNotificationResourceApi.md#getusagenotificationusingget) | **GET** /api/usage-notifications/{id} | getUsageNotification
*UsageNotificationResourceApi* | [**UpdateUsageNotificationUsingPUT**](docs/UsageNotificationResourceApi.md#updateusagenotificationusingput) | **PUT** /api/usage-notifications | updateUsageNotification
*UserResourceApi* | [**CreateUserUsingPOST**](docs/UserResourceApi.md#createuserusingpost) | **POST** /api/users | createUser
*UserResourceApi* | [**DeleteUserUsingDELETE**](docs/UserResourceApi.md#deleteuserusingdelete) | **DELETE** /api/users/{login} | deleteUser
*UserResourceApi* | [**GetAllUsersUsingGET**](docs/UserResourceApi.md#getallusersusingget) | **GET** /api/users | getAllUsers
*UserResourceApi* | [**GetAuthoritiesUsingGET**](docs/UserResourceApi.md#getauthoritiesusingget) | **GET** /api/users/authorities | getAuthorities
*UserResourceApi* | [**GetUserUsingGET**](docs/UserResourceApi.md#getuserusingget) | **GET** /api/users/{login} | getUser
*UserResourceApi* | [**UpdateUserUsingPUT**](docs/UserResourceApi.md#updateuserusingput) | **PUT** /api/users | updateUser


<a name="documentation-for-models"></a>
## Documentation for Models

 - [com.kodfarki.subscreasy.client.model.Address](docs/Address.md)
 - [com.kodfarki.subscreasy.client.model.Authority](docs/Authority.md)
 - [com.kodfarki.subscreasy.client.model.Authorization](docs/Authorization.md)
 - [com.kodfarki.subscreasy.client.model.AuthorizedServicesResponse](docs/AuthorizedServicesResponse.md)
 - [com.kodfarki.subscreasy.client.model.Cancellation](docs/Cancellation.md)
 - [com.kodfarki.subscreasy.client.model.ChargingLog](docs/ChargingLog.md)
 - [com.kodfarki.subscreasy.client.model.Company](docs/Company.md)
 - [com.kodfarki.subscreasy.client.model.CompanyProps](docs/CompanyProps.md)
 - [com.kodfarki.subscreasy.client.model.Coupon](docs/Coupon.md)
 - [com.kodfarki.subscreasy.client.model.Deduction](docs/Deduction.md)
 - [com.kodfarki.subscreasy.client.model.DeductionResult](docs/DeductionResult.md)
 - [com.kodfarki.subscreasy.client.model.History](docs/History.md)
 - [com.kodfarki.subscreasy.client.model.Invoice](docs/Invoice.md)
 - [com.kodfarki.subscreasy.client.model.InvoiceRequest](docs/InvoiceRequest.md)
 - [com.kodfarki.subscreasy.client.model.ManagedUserVM](docs/ManagedUserVM.md)
 - [com.kodfarki.subscreasy.client.model.MessageTemplate](docs/MessageTemplate.md)
 - [com.kodfarki.subscreasy.client.model.Offer](docs/Offer.md)
 - [com.kodfarki.subscreasy.client.model.PaymentCard](docs/PaymentCard.md)
 - [com.kodfarki.subscreasy.client.model.ProfileInfoVM](docs/ProfileInfoVM.md)
 - [com.kodfarki.subscreasy.client.model.RecurrencePeriod](docs/RecurrencePeriod.md)
 - [com.kodfarki.subscreasy.client.model.ResponseEntity](docs/ResponseEntity.md)
 - [com.kodfarki.subscreasy.client.model.SavedCard](docs/SavedCard.md)
 - [com.kodfarki.subscreasy.client.model.Service](docs/Service.md)
 - [com.kodfarki.subscreasy.client.model.ServiceInstance](docs/ServiceInstance.md)
 - [com.kodfarki.subscreasy.client.model.ServiceInstanceResult](docs/ServiceInstanceResult.md)
 - [com.kodfarki.subscreasy.client.model.ServiceOffering](docs/ServiceOffering.md)
 - [com.kodfarki.subscreasy.client.model.ServiceOfferingResult](docs/ServiceOfferingResult.md)
 - [com.kodfarki.subscreasy.client.model.StartSubscriptionRequest](docs/StartSubscriptionRequest.md)
 - [com.kodfarki.subscreasy.client.model.Subscriber](docs/Subscriber.md)
 - [com.kodfarki.subscreasy.client.model.SubscriptionCreateResult](docs/SubscriptionCreateResult.md)
 - [com.kodfarki.subscreasy.client.model.SubscriptionPlan](docs/SubscriptionPlan.md)
 - [com.kodfarki.subscreasy.client.model.Subsription](docs/Subsription.md)
 - [com.kodfarki.subscreasy.client.model.UsageNotification](docs/UsageNotification.md)
 - [com.kodfarki.subscreasy.client.model.User](docs/User.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="apiKey"></a>
### apiKey

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

