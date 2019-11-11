# IO.Swagger.com.kodfarki.subscreasy.client.EndpointsNoAuthApi

All URIs are relative to *https://app.subscreasy.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StartSubscription3dsUsingPOST**](EndpointsNoAuthApi.md#startsubscription3dsusingpost) | **POST** /na/subscription/start/4ds | startSubscription3ds


<a name="startsubscription3dsusingpost"></a>
# **StartSubscription3dsUsingPOST**
> string StartSubscription3dsUsingPOST (long? offerRecurrenceId = null, string offerRecurrenceRecurrenceType = null, long? offerRecurrenceLength = null, long? offerCompanyAddressId = null, string offerCompanyAddressName = null, string offerCompanyAddressStreetAddress = null, string offerCompanyAddressPostalCode = null, string offerCompanyAddressCity = null, string offerCompanyAddressStateProvince = null, string offerCompanyAddressCountry = null, long? offerCompanyAddressCompanyId = null, long? offerCompanyCompanyPropsId = null, string offerCompanyCompanyPropsCallbackUrl = null, string offerCompanyCompanyPropsLogoPath = null, string offerCompanyCompanyPropsHostedPageCSSPath = null, string offerCompanyCompanyPropsPrivacyPolicyUrl = null, string offerCompanyCompanyPropsSubscreasyApiKey = null, string offerCompanyCompanyPropsSubscreasySecureKey = null, string offerCompanyCompanyPropsPaymentGateway = null, string offerCompanyCompanyPropsMobilePaymentGateway = null, string offerCompanyCompanyPropsWirecardUserCode = null, string offerCompanyCompanyPropsWirecardPin = null, string offerCompanyCompanyPropsWirecardTurkcellServisId = null, string offerCompanyCompanyPropsWirecardSuccessfulMessage = null, string offerCompanyCompanyPropsWirecardErrorMessage = null, string offerCompanyCompanyPropsPaymentGatewayApiKey = null, string offerCompanyCompanyPropsPaymentGatewaySecurityKey = null, string offerCompanyCompanyPropsPayuMerchantKeyRenewals = null, string offerCompanyCompanyPropsPayuSecretKeyRenewals = null, int? offerCompanyCompanyPropsPaytrMerchantId = null, string offerCompanyCompanyPropsMobilExpressMerchantKey = null, string offerCompanyCompanyPropsMobilExpressApiPassword = null, int? offerCompanyCompanyPropsMobilExpressPosid = null, int? offerCompanyCompanyPropsBillingDate = null, int? offerCompanyCompanyPropsBillingThresholdDays = null, string offerCompanyCompanyPropsDomainName = null, string offerCompanyCompanyPropsContactEmail = null, string offerCompanyCompanyPropsSendDailyReports = null, bool? offerCompanyCompanyPropsNotifyNewSubscription = null, bool? offerCompanyCompanyPropsNotifyRenewal = null, bool? offerCompanyCompanyPropsNotifySubscriptionCancellation = null, bool? offerCompanyCompanyPropsBranding = null, bool? offerCompanyCompanyPropsBillingInformationMandatory = null, long? offerCompanyId = null, string offerCompanyName = null, string offerCompanySiteName = null, long? offerId = null, string offerSecureId = null, string offerName = null, string offerDescription = null, decimal? offerPrice = null, string offerCurrency = null, bool? offerMultiplePurchase = null, int? offerRecurrenceCount = null, int? offerTrialPeriod = null, string offerProductType = null, string offerRenewalType = null, bool? offerDisablePaymentForm = null, DateTime? offerCreateDate = null, string offerImagePath = null, long? subscriberBillingAddressId = null, string subscriberBillingAddressName = null, string subscriberBillingAddressStreetAddress = null, string subscriberBillingAddressPostalCode = null, string subscriberBillingAddressCity = null, string subscriberBillingAddressStateProvince = null, string subscriberBillingAddressCountry = null, long? subscriberBillingAddressCompanyId = null, long? subscriberShippingAddressId = null, string subscriberShippingAddressName = null, string subscriberShippingAddressStreetAddress = null, string subscriberShippingAddressPostalCode = null, string subscriberShippingAddressCity = null, string subscriberShippingAddressStateProvince = null, string subscriberShippingAddressCountry = null, long? subscriberShippingAddressCompanyId = null, long? subscriberCompanyAddressId = null, string subscriberCompanyAddressName = null, string subscriberCompanyAddressStreetAddress = null, string subscriberCompanyAddressPostalCode = null, string subscriberCompanyAddressCity = null, string subscriberCompanyAddressStateProvince = null, string subscriberCompanyAddressCountry = null, long? subscriberCompanyAddressCompanyId = null, long? subscriberCompanyCompanyPropsId = null, string subscriberCompanyCompanyPropsCallbackUrl = null, string subscriberCompanyCompanyPropsLogoPath = null, string subscriberCompanyCompanyPropsHostedPageCSSPath = null, string subscriberCompanyCompanyPropsPrivacyPolicyUrl = null, string subscriberCompanyCompanyPropsSubscreasyApiKey = null, string subscriberCompanyCompanyPropsSubscreasySecureKey = null, string subscriberCompanyCompanyPropsPaymentGateway = null, string subscriberCompanyCompanyPropsMobilePaymentGateway = null, string subscriberCompanyCompanyPropsWirecardUserCode = null, string subscriberCompanyCompanyPropsWirecardPin = null, string subscriberCompanyCompanyPropsWirecardTurkcellServisId = null, string subscriberCompanyCompanyPropsWirecardSuccessfulMessage = null, string subscriberCompanyCompanyPropsWirecardErrorMessage = null, string subscriberCompanyCompanyPropsPaymentGatewayApiKey = null, string subscriberCompanyCompanyPropsPaymentGatewaySecurityKey = null, string subscriberCompanyCompanyPropsPayuMerchantKeyRenewals = null, string subscriberCompanyCompanyPropsPayuSecretKeyRenewals = null, int? subscriberCompanyCompanyPropsPaytrMerchantId = null, string subscriberCompanyCompanyPropsMobilExpressMerchantKey = null, string subscriberCompanyCompanyPropsMobilExpressApiPassword = null, int? subscriberCompanyCompanyPropsMobilExpressPosid = null, int? subscriberCompanyCompanyPropsBillingDate = null, int? subscriberCompanyCompanyPropsBillingThresholdDays = null, string subscriberCompanyCompanyPropsDomainName = null, string subscriberCompanyCompanyPropsContactEmail = null, string subscriberCompanyCompanyPropsSendDailyReports = null, bool? subscriberCompanyCompanyPropsNotifyNewSubscription = null, bool? subscriberCompanyCompanyPropsNotifyRenewal = null, bool? subscriberCompanyCompanyPropsNotifySubscriptionCancellation = null, bool? subscriberCompanyCompanyPropsBranding = null, bool? subscriberCompanyCompanyPropsBillingInformationMandatory = null, long? subscriberCompanyId = null, string subscriberCompanyName = null, string subscriberCompanySiteName = null, long? subscriberId = null, string subscriberSecureId = null, string subscriberMerchantSubscriberId = null, string subscriberEmail = null, string subscriberName = null, string subscriberSurname = null, string subscriberPhoneNumber = null, DateTime? subscriberCreateDate = null, string subscriberIdentificationNo = null, string subscriberTaxNumber = null, string subscriberTaxAdministration = null, string subscriberWorksFor = null, string paymentCardCardHolderName = null, string paymentCardCardNumber = null, string paymentCardExpireYear = null, string paymentCardExpireMonth = null, string paymentCardCvc = null, int? paymentCardRegisterCard = null, string paymentCardCardAlias = null, string paymentCardCardToken = null, string paymentCardCardUserKey = null, string paymentCardCardFamily = null, long? subscriberFromDbBillingAddressId = null, string subscriberFromDbBillingAddressName = null, string subscriberFromDbBillingAddressStreetAddress = null, string subscriberFromDbBillingAddressPostalCode = null, string subscriberFromDbBillingAddressCity = null, string subscriberFromDbBillingAddressStateProvince = null, string subscriberFromDbBillingAddressCountry = null, long? subscriberFromDbBillingAddressCompanyId = null, long? subscriberFromDbShippingAddressId = null, string subscriberFromDbShippingAddressName = null, string subscriberFromDbShippingAddressStreetAddress = null, string subscriberFromDbShippingAddressPostalCode = null, string subscriberFromDbShippingAddressCity = null, string subscriberFromDbShippingAddressStateProvince = null, string subscriberFromDbShippingAddressCountry = null, long? subscriberFromDbShippingAddressCompanyId = null, long? subscriberFromDbCompanyAddressId = null, string subscriberFromDbCompanyAddressName = null, string subscriberFromDbCompanyAddressStreetAddress = null, string subscriberFromDbCompanyAddressPostalCode = null, string subscriberFromDbCompanyAddressCity = null, string subscriberFromDbCompanyAddressStateProvince = null, string subscriberFromDbCompanyAddressCountry = null, long? subscriberFromDbCompanyAddressCompanyId = null, long? subscriberFromDbCompanyCompanyPropsId = null, string subscriberFromDbCompanyCompanyPropsCallbackUrl = null, string subscriberFromDbCompanyCompanyPropsLogoPath = null, string subscriberFromDbCompanyCompanyPropsHostedPageCSSPath = null, string subscriberFromDbCompanyCompanyPropsPrivacyPolicyUrl = null, string subscriberFromDbCompanyCompanyPropsSubscreasyApiKey = null, string subscriberFromDbCompanyCompanyPropsSubscreasySecureKey = null, string subscriberFromDbCompanyCompanyPropsPaymentGateway = null, string subscriberFromDbCompanyCompanyPropsMobilePaymentGateway = null, string subscriberFromDbCompanyCompanyPropsWirecardUserCode = null, string subscriberFromDbCompanyCompanyPropsWirecardPin = null, string subscriberFromDbCompanyCompanyPropsWirecardTurkcellServisId = null, string subscriberFromDbCompanyCompanyPropsWirecardSuccessfulMessage = null, string subscriberFromDbCompanyCompanyPropsWirecardErrorMessage = null, string subscriberFromDbCompanyCompanyPropsPaymentGatewayApiKey = null, string subscriberFromDbCompanyCompanyPropsPaymentGatewaySecurityKey = null, string subscriberFromDbCompanyCompanyPropsPayuMerchantKeyRenewals = null, string subscriberFromDbCompanyCompanyPropsPayuSecretKeyRenewals = null, int? subscriberFromDbCompanyCompanyPropsPaytrMerchantId = null, string subscriberFromDbCompanyCompanyPropsMobilExpressMerchantKey = null, string subscriberFromDbCompanyCompanyPropsMobilExpressApiPassword = null, int? subscriberFromDbCompanyCompanyPropsMobilExpressPosid = null, int? subscriberFromDbCompanyCompanyPropsBillingDate = null, int? subscriberFromDbCompanyCompanyPropsBillingThresholdDays = null, string subscriberFromDbCompanyCompanyPropsDomainName = null, string subscriberFromDbCompanyCompanyPropsContactEmail = null, string subscriberFromDbCompanyCompanyPropsSendDailyReports = null, bool? subscriberFromDbCompanyCompanyPropsNotifyNewSubscription = null, bool? subscriberFromDbCompanyCompanyPropsNotifyRenewal = null, bool? subscriberFromDbCompanyCompanyPropsNotifySubscriptionCancellation = null, bool? subscriberFromDbCompanyCompanyPropsBranding = null, bool? subscriberFromDbCompanyCompanyPropsBillingInformationMandatory = null, long? subscriberFromDbCompanyId = null, string subscriberFromDbCompanyName = null, string subscriberFromDbCompanySiteName = null, long? subscriberFromDbId = null, string subscriberFromDbSecureId = null, string subscriberFromDbMerchantSubscriberId = null, string subscriberFromDbEmail = null, string subscriberFromDbName = null, string subscriberFromDbSurname = null, string subscriberFromDbPhoneNumber = null, DateTime? subscriberFromDbCreateDate = null, string subscriberFromDbIdentificationNo = null, string subscriberFromDbTaxNumber = null, string subscriberFromDbTaxAdministration = null, string subscriberFromDbWorksFor = null, string couponCode = null, string callbackUrl = null, decimal? price = null, string companySiteName = null, bool? privacyPolicyUrl = null, string paymentType = null, bool? editable = null, string productType = null)

startSubscription3ds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace Example
{
    public class StartSubscription3dsUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new EndpointsNoAuthApi();
            var offerRecurrenceId = 789;  // long? |  (optional) 
            var offerRecurrenceRecurrenceType = offerRecurrenceRecurrenceType_example;  // string |  (optional) 
            var offerRecurrenceLength = 789;  // long? |  (optional) 
            var offerCompanyAddressId = 789;  // long? |  (optional) 
            var offerCompanyAddressName = offerCompanyAddressName_example;  // string |  (optional) 
            var offerCompanyAddressStreetAddress = offerCompanyAddressStreetAddress_example;  // string |  (optional) 
            var offerCompanyAddressPostalCode = offerCompanyAddressPostalCode_example;  // string |  (optional) 
            var offerCompanyAddressCity = offerCompanyAddressCity_example;  // string |  (optional) 
            var offerCompanyAddressStateProvince = offerCompanyAddressStateProvince_example;  // string |  (optional) 
            var offerCompanyAddressCountry = offerCompanyAddressCountry_example;  // string |  (optional) 
            var offerCompanyAddressCompanyId = 789;  // long? |  (optional) 
            var offerCompanyCompanyPropsId = 789;  // long? |  (optional) 
            var offerCompanyCompanyPropsCallbackUrl = offerCompanyCompanyPropsCallbackUrl_example;  // string |  (optional) 
            var offerCompanyCompanyPropsLogoPath = offerCompanyCompanyPropsLogoPath_example;  // string |  (optional) 
            var offerCompanyCompanyPropsHostedPageCSSPath = offerCompanyCompanyPropsHostedPageCSSPath_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPrivacyPolicyUrl = offerCompanyCompanyPropsPrivacyPolicyUrl_example;  // string |  (optional) 
            var offerCompanyCompanyPropsSubscreasyApiKey = offerCompanyCompanyPropsSubscreasyApiKey_example;  // string |  (optional) 
            var offerCompanyCompanyPropsSubscreasySecureKey = offerCompanyCompanyPropsSubscreasySecureKey_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPaymentGateway = offerCompanyCompanyPropsPaymentGateway_example;  // string |  (optional) 
            var offerCompanyCompanyPropsMobilePaymentGateway = offerCompanyCompanyPropsMobilePaymentGateway_example;  // string |  (optional) 
            var offerCompanyCompanyPropsWirecardUserCode = offerCompanyCompanyPropsWirecardUserCode_example;  // string |  (optional) 
            var offerCompanyCompanyPropsWirecardPin = offerCompanyCompanyPropsWirecardPin_example;  // string |  (optional) 
            var offerCompanyCompanyPropsWirecardTurkcellServisId = offerCompanyCompanyPropsWirecardTurkcellServisId_example;  // string |  (optional) 
            var offerCompanyCompanyPropsWirecardSuccessfulMessage = offerCompanyCompanyPropsWirecardSuccessfulMessage_example;  // string |  (optional) 
            var offerCompanyCompanyPropsWirecardErrorMessage = offerCompanyCompanyPropsWirecardErrorMessage_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPaymentGatewayApiKey = offerCompanyCompanyPropsPaymentGatewayApiKey_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPaymentGatewaySecurityKey = offerCompanyCompanyPropsPaymentGatewaySecurityKey_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPayuMerchantKeyRenewals = offerCompanyCompanyPropsPayuMerchantKeyRenewals_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPayuSecretKeyRenewals = offerCompanyCompanyPropsPayuSecretKeyRenewals_example;  // string |  (optional) 
            var offerCompanyCompanyPropsPaytrMerchantId = 56;  // int? |  (optional) 
            var offerCompanyCompanyPropsMobilExpressMerchantKey = offerCompanyCompanyPropsMobilExpressMerchantKey_example;  // string |  (optional) 
            var offerCompanyCompanyPropsMobilExpressApiPassword = offerCompanyCompanyPropsMobilExpressApiPassword_example;  // string |  (optional) 
            var offerCompanyCompanyPropsMobilExpressPosid = 56;  // int? |  (optional) 
            var offerCompanyCompanyPropsBillingDate = 56;  // int? |  (optional) 
            var offerCompanyCompanyPropsBillingThresholdDays = 56;  // int? |  (optional) 
            var offerCompanyCompanyPropsDomainName = offerCompanyCompanyPropsDomainName_example;  // string |  (optional) 
            var offerCompanyCompanyPropsContactEmail = offerCompanyCompanyPropsContactEmail_example;  // string |  (optional) 
            var offerCompanyCompanyPropsSendDailyReports = offerCompanyCompanyPropsSendDailyReports_example;  // string |  (optional) 
            var offerCompanyCompanyPropsNotifyNewSubscription = true;  // bool? |  (optional) 
            var offerCompanyCompanyPropsNotifyRenewal = true;  // bool? |  (optional) 
            var offerCompanyCompanyPropsNotifySubscriptionCancellation = true;  // bool? |  (optional) 
            var offerCompanyCompanyPropsBranding = true;  // bool? |  (optional) 
            var offerCompanyCompanyPropsBillingInformationMandatory = true;  // bool? |  (optional) 
            var offerCompanyId = 789;  // long? |  (optional) 
            var offerCompanyName = offerCompanyName_example;  // string |  (optional) 
            var offerCompanySiteName = offerCompanySiteName_example;  // string |  (optional) 
            var offerId = 789;  // long? |  (optional) 
            var offerSecureId = offerSecureId_example;  // string |  (optional) 
            var offerName = offerName_example;  // string |  (optional) 
            var offerDescription = offerDescription_example;  // string |  (optional) 
            var offerPrice = 8.14;  // decimal? |  (optional) 
            var offerCurrency = offerCurrency_example;  // string |  (optional) 
            var offerMultiplePurchase = true;  // bool? |  (optional) 
            var offerRecurrenceCount = 56;  // int? |  (optional) 
            var offerTrialPeriod = 56;  // int? |  (optional) 
            var offerProductType = offerProductType_example;  // string |  (optional) 
            var offerRenewalType = offerRenewalType_example;  // string |  (optional) 
            var offerDisablePaymentForm = true;  // bool? |  (optional) 
            var offerCreateDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var offerImagePath = offerImagePath_example;  // string |  (optional) 
            var subscriberBillingAddressId = 789;  // long? |  (optional) 
            var subscriberBillingAddressName = subscriberBillingAddressName_example;  // string |  (optional) 
            var subscriberBillingAddressStreetAddress = subscriberBillingAddressStreetAddress_example;  // string |  (optional) 
            var subscriberBillingAddressPostalCode = subscriberBillingAddressPostalCode_example;  // string |  (optional) 
            var subscriberBillingAddressCity = subscriberBillingAddressCity_example;  // string |  (optional) 
            var subscriberBillingAddressStateProvince = subscriberBillingAddressStateProvince_example;  // string |  (optional) 
            var subscriberBillingAddressCountry = subscriberBillingAddressCountry_example;  // string |  (optional) 
            var subscriberBillingAddressCompanyId = 789;  // long? |  (optional) 
            var subscriberShippingAddressId = 789;  // long? |  (optional) 
            var subscriberShippingAddressName = subscriberShippingAddressName_example;  // string |  (optional) 
            var subscriberShippingAddressStreetAddress = subscriberShippingAddressStreetAddress_example;  // string |  (optional) 
            var subscriberShippingAddressPostalCode = subscriberShippingAddressPostalCode_example;  // string |  (optional) 
            var subscriberShippingAddressCity = subscriberShippingAddressCity_example;  // string |  (optional) 
            var subscriberShippingAddressStateProvince = subscriberShippingAddressStateProvince_example;  // string |  (optional) 
            var subscriberShippingAddressCountry = subscriberShippingAddressCountry_example;  // string |  (optional) 
            var subscriberShippingAddressCompanyId = 789;  // long? |  (optional) 
            var subscriberCompanyAddressId = 789;  // long? |  (optional) 
            var subscriberCompanyAddressName = subscriberCompanyAddressName_example;  // string |  (optional) 
            var subscriberCompanyAddressStreetAddress = subscriberCompanyAddressStreetAddress_example;  // string |  (optional) 
            var subscriberCompanyAddressPostalCode = subscriberCompanyAddressPostalCode_example;  // string |  (optional) 
            var subscriberCompanyAddressCity = subscriberCompanyAddressCity_example;  // string |  (optional) 
            var subscriberCompanyAddressStateProvince = subscriberCompanyAddressStateProvince_example;  // string |  (optional) 
            var subscriberCompanyAddressCountry = subscriberCompanyAddressCountry_example;  // string |  (optional) 
            var subscriberCompanyAddressCompanyId = 789;  // long? |  (optional) 
            var subscriberCompanyCompanyPropsId = 789;  // long? |  (optional) 
            var subscriberCompanyCompanyPropsCallbackUrl = subscriberCompanyCompanyPropsCallbackUrl_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsLogoPath = subscriberCompanyCompanyPropsLogoPath_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsHostedPageCSSPath = subscriberCompanyCompanyPropsHostedPageCSSPath_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPrivacyPolicyUrl = subscriberCompanyCompanyPropsPrivacyPolicyUrl_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsSubscreasyApiKey = subscriberCompanyCompanyPropsSubscreasyApiKey_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsSubscreasySecureKey = subscriberCompanyCompanyPropsSubscreasySecureKey_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPaymentGateway = subscriberCompanyCompanyPropsPaymentGateway_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsMobilePaymentGateway = subscriberCompanyCompanyPropsMobilePaymentGateway_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsWirecardUserCode = subscriberCompanyCompanyPropsWirecardUserCode_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsWirecardPin = subscriberCompanyCompanyPropsWirecardPin_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsWirecardTurkcellServisId = subscriberCompanyCompanyPropsWirecardTurkcellServisId_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsWirecardSuccessfulMessage = subscriberCompanyCompanyPropsWirecardSuccessfulMessage_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsWirecardErrorMessage = subscriberCompanyCompanyPropsWirecardErrorMessage_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPaymentGatewayApiKey = subscriberCompanyCompanyPropsPaymentGatewayApiKey_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPaymentGatewaySecurityKey = subscriberCompanyCompanyPropsPaymentGatewaySecurityKey_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPayuMerchantKeyRenewals = subscriberCompanyCompanyPropsPayuMerchantKeyRenewals_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPayuSecretKeyRenewals = subscriberCompanyCompanyPropsPayuSecretKeyRenewals_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsPaytrMerchantId = 56;  // int? |  (optional) 
            var subscriberCompanyCompanyPropsMobilExpressMerchantKey = subscriberCompanyCompanyPropsMobilExpressMerchantKey_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsMobilExpressApiPassword = subscriberCompanyCompanyPropsMobilExpressApiPassword_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsMobilExpressPosid = 56;  // int? |  (optional) 
            var subscriberCompanyCompanyPropsBillingDate = 56;  // int? |  (optional) 
            var subscriberCompanyCompanyPropsBillingThresholdDays = 56;  // int? |  (optional) 
            var subscriberCompanyCompanyPropsDomainName = subscriberCompanyCompanyPropsDomainName_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsContactEmail = subscriberCompanyCompanyPropsContactEmail_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsSendDailyReports = subscriberCompanyCompanyPropsSendDailyReports_example;  // string |  (optional) 
            var subscriberCompanyCompanyPropsNotifyNewSubscription = true;  // bool? |  (optional) 
            var subscriberCompanyCompanyPropsNotifyRenewal = true;  // bool? |  (optional) 
            var subscriberCompanyCompanyPropsNotifySubscriptionCancellation = true;  // bool? |  (optional) 
            var subscriberCompanyCompanyPropsBranding = true;  // bool? |  (optional) 
            var subscriberCompanyCompanyPropsBillingInformationMandatory = true;  // bool? |  (optional) 
            var subscriberCompanyId = 789;  // long? |  (optional) 
            var subscriberCompanyName = subscriberCompanyName_example;  // string |  (optional) 
            var subscriberCompanySiteName = subscriberCompanySiteName_example;  // string |  (optional) 
            var subscriberId = 789;  // long? |  (optional) 
            var subscriberSecureId = subscriberSecureId_example;  // string |  (optional) 
            var subscriberMerchantSubscriberId = subscriberMerchantSubscriberId_example;  // string |  (optional) 
            var subscriberEmail = subscriberEmail_example;  // string |  (optional) 
            var subscriberName = subscriberName_example;  // string |  (optional) 
            var subscriberSurname = subscriberSurname_example;  // string |  (optional) 
            var subscriberPhoneNumber = subscriberPhoneNumber_example;  // string |  (optional) 
            var subscriberCreateDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var subscriberIdentificationNo = subscriberIdentificationNo_example;  // string |  (optional) 
            var subscriberTaxNumber = subscriberTaxNumber_example;  // string |  (optional) 
            var subscriberTaxAdministration = subscriberTaxAdministration_example;  // string |  (optional) 
            var subscriberWorksFor = subscriberWorksFor_example;  // string |  (optional) 
            var paymentCardCardHolderName = paymentCardCardHolderName_example;  // string |  (optional) 
            var paymentCardCardNumber = paymentCardCardNumber_example;  // string |  (optional) 
            var paymentCardExpireYear = paymentCardExpireYear_example;  // string |  (optional) 
            var paymentCardExpireMonth = paymentCardExpireMonth_example;  // string |  (optional) 
            var paymentCardCvc = paymentCardCvc_example;  // string |  (optional) 
            var paymentCardRegisterCard = 56;  // int? |  (optional) 
            var paymentCardCardAlias = paymentCardCardAlias_example;  // string |  (optional) 
            var paymentCardCardToken = paymentCardCardToken_example;  // string |  (optional) 
            var paymentCardCardUserKey = paymentCardCardUserKey_example;  // string |  (optional) 
            var paymentCardCardFamily = paymentCardCardFamily_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressId = 789;  // long? |  (optional) 
            var subscriberFromDbBillingAddressName = subscriberFromDbBillingAddressName_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressStreetAddress = subscriberFromDbBillingAddressStreetAddress_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressPostalCode = subscriberFromDbBillingAddressPostalCode_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressCity = subscriberFromDbBillingAddressCity_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressStateProvince = subscriberFromDbBillingAddressStateProvince_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressCountry = subscriberFromDbBillingAddressCountry_example;  // string |  (optional) 
            var subscriberFromDbBillingAddressCompanyId = 789;  // long? |  (optional) 
            var subscriberFromDbShippingAddressId = 789;  // long? |  (optional) 
            var subscriberFromDbShippingAddressName = subscriberFromDbShippingAddressName_example;  // string |  (optional) 
            var subscriberFromDbShippingAddressStreetAddress = subscriberFromDbShippingAddressStreetAddress_example;  // string |  (optional) 
            var subscriberFromDbShippingAddressPostalCode = subscriberFromDbShippingAddressPostalCode_example;  // string |  (optional) 
            var subscriberFromDbShippingAddressCity = subscriberFromDbShippingAddressCity_example;  // string |  (optional) 
            var subscriberFromDbShippingAddressStateProvince = subscriberFromDbShippingAddressStateProvince_example;  // string |  (optional) 
            var subscriberFromDbShippingAddressCountry = subscriberFromDbShippingAddressCountry_example;  // string |  (optional) 
            var subscriberFromDbShippingAddressCompanyId = 789;  // long? |  (optional) 
            var subscriberFromDbCompanyAddressId = 789;  // long? |  (optional) 
            var subscriberFromDbCompanyAddressName = subscriberFromDbCompanyAddressName_example;  // string |  (optional) 
            var subscriberFromDbCompanyAddressStreetAddress = subscriberFromDbCompanyAddressStreetAddress_example;  // string |  (optional) 
            var subscriberFromDbCompanyAddressPostalCode = subscriberFromDbCompanyAddressPostalCode_example;  // string |  (optional) 
            var subscriberFromDbCompanyAddressCity = subscriberFromDbCompanyAddressCity_example;  // string |  (optional) 
            var subscriberFromDbCompanyAddressStateProvince = subscriberFromDbCompanyAddressStateProvince_example;  // string |  (optional) 
            var subscriberFromDbCompanyAddressCountry = subscriberFromDbCompanyAddressCountry_example;  // string |  (optional) 
            var subscriberFromDbCompanyAddressCompanyId = 789;  // long? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsId = 789;  // long? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsCallbackUrl = subscriberFromDbCompanyCompanyPropsCallbackUrl_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsLogoPath = subscriberFromDbCompanyCompanyPropsLogoPath_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsHostedPageCSSPath = subscriberFromDbCompanyCompanyPropsHostedPageCSSPath_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPrivacyPolicyUrl = subscriberFromDbCompanyCompanyPropsPrivacyPolicyUrl_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsSubscreasyApiKey = subscriberFromDbCompanyCompanyPropsSubscreasyApiKey_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsSubscreasySecureKey = subscriberFromDbCompanyCompanyPropsSubscreasySecureKey_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPaymentGateway = subscriberFromDbCompanyCompanyPropsPaymentGateway_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsMobilePaymentGateway = subscriberFromDbCompanyCompanyPropsMobilePaymentGateway_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsWirecardUserCode = subscriberFromDbCompanyCompanyPropsWirecardUserCode_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsWirecardPin = subscriberFromDbCompanyCompanyPropsWirecardPin_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsWirecardTurkcellServisId = subscriberFromDbCompanyCompanyPropsWirecardTurkcellServisId_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsWirecardSuccessfulMessage = subscriberFromDbCompanyCompanyPropsWirecardSuccessfulMessage_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsWirecardErrorMessage = subscriberFromDbCompanyCompanyPropsWirecardErrorMessage_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPaymentGatewayApiKey = subscriberFromDbCompanyCompanyPropsPaymentGatewayApiKey_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPaymentGatewaySecurityKey = subscriberFromDbCompanyCompanyPropsPaymentGatewaySecurityKey_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPayuMerchantKeyRenewals = subscriberFromDbCompanyCompanyPropsPayuMerchantKeyRenewals_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPayuSecretKeyRenewals = subscriberFromDbCompanyCompanyPropsPayuSecretKeyRenewals_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsPaytrMerchantId = 56;  // int? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsMobilExpressMerchantKey = subscriberFromDbCompanyCompanyPropsMobilExpressMerchantKey_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsMobilExpressApiPassword = subscriberFromDbCompanyCompanyPropsMobilExpressApiPassword_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsMobilExpressPosid = 56;  // int? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsBillingDate = 56;  // int? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsBillingThresholdDays = 56;  // int? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsDomainName = subscriberFromDbCompanyCompanyPropsDomainName_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsContactEmail = subscriberFromDbCompanyCompanyPropsContactEmail_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsSendDailyReports = subscriberFromDbCompanyCompanyPropsSendDailyReports_example;  // string |  (optional) 
            var subscriberFromDbCompanyCompanyPropsNotifyNewSubscription = true;  // bool? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsNotifyRenewal = true;  // bool? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsNotifySubscriptionCancellation = true;  // bool? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsBranding = true;  // bool? |  (optional) 
            var subscriberFromDbCompanyCompanyPropsBillingInformationMandatory = true;  // bool? |  (optional) 
            var subscriberFromDbCompanyId = 789;  // long? |  (optional) 
            var subscriberFromDbCompanyName = subscriberFromDbCompanyName_example;  // string |  (optional) 
            var subscriberFromDbCompanySiteName = subscriberFromDbCompanySiteName_example;  // string |  (optional) 
            var subscriberFromDbId = 789;  // long? |  (optional) 
            var subscriberFromDbSecureId = subscriberFromDbSecureId_example;  // string |  (optional) 
            var subscriberFromDbMerchantSubscriberId = subscriberFromDbMerchantSubscriberId_example;  // string |  (optional) 
            var subscriberFromDbEmail = subscriberFromDbEmail_example;  // string |  (optional) 
            var subscriberFromDbName = subscriberFromDbName_example;  // string |  (optional) 
            var subscriberFromDbSurname = subscriberFromDbSurname_example;  // string |  (optional) 
            var subscriberFromDbPhoneNumber = subscriberFromDbPhoneNumber_example;  // string |  (optional) 
            var subscriberFromDbCreateDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var subscriberFromDbIdentificationNo = subscriberFromDbIdentificationNo_example;  // string |  (optional) 
            var subscriberFromDbTaxNumber = subscriberFromDbTaxNumber_example;  // string |  (optional) 
            var subscriberFromDbTaxAdministration = subscriberFromDbTaxAdministration_example;  // string |  (optional) 
            var subscriberFromDbWorksFor = subscriberFromDbWorksFor_example;  // string |  (optional) 
            var couponCode = couponCode_example;  // string |  (optional) 
            var callbackUrl = callbackUrl_example;  // string |  (optional) 
            var price = 8.14;  // decimal? |  (optional) 
            var companySiteName = companySiteName_example;  // string |  (optional) 
            var privacyPolicyUrl = true;  // bool? |  (optional) 
            var paymentType = paymentType_example;  // string |  (optional) 
            var editable = true;  // bool? |  (optional) 
            var productType = productType_example;  // string |  (optional) 

            try
            {
                // startSubscription3ds
                string result = apiInstance.StartSubscription3dsUsingPOST(offerRecurrenceId, offerRecurrenceRecurrenceType, offerRecurrenceLength, offerCompanyAddressId, offerCompanyAddressName, offerCompanyAddressStreetAddress, offerCompanyAddressPostalCode, offerCompanyAddressCity, offerCompanyAddressStateProvince, offerCompanyAddressCountry, offerCompanyAddressCompanyId, offerCompanyCompanyPropsId, offerCompanyCompanyPropsCallbackUrl, offerCompanyCompanyPropsLogoPath, offerCompanyCompanyPropsHostedPageCSSPath, offerCompanyCompanyPropsPrivacyPolicyUrl, offerCompanyCompanyPropsSubscreasyApiKey, offerCompanyCompanyPropsSubscreasySecureKey, offerCompanyCompanyPropsPaymentGateway, offerCompanyCompanyPropsMobilePaymentGateway, offerCompanyCompanyPropsWirecardUserCode, offerCompanyCompanyPropsWirecardPin, offerCompanyCompanyPropsWirecardTurkcellServisId, offerCompanyCompanyPropsWirecardSuccessfulMessage, offerCompanyCompanyPropsWirecardErrorMessage, offerCompanyCompanyPropsPaymentGatewayApiKey, offerCompanyCompanyPropsPaymentGatewaySecurityKey, offerCompanyCompanyPropsPayuMerchantKeyRenewals, offerCompanyCompanyPropsPayuSecretKeyRenewals, offerCompanyCompanyPropsPaytrMerchantId, offerCompanyCompanyPropsMobilExpressMerchantKey, offerCompanyCompanyPropsMobilExpressApiPassword, offerCompanyCompanyPropsMobilExpressPosid, offerCompanyCompanyPropsBillingDate, offerCompanyCompanyPropsBillingThresholdDays, offerCompanyCompanyPropsDomainName, offerCompanyCompanyPropsContactEmail, offerCompanyCompanyPropsSendDailyReports, offerCompanyCompanyPropsNotifyNewSubscription, offerCompanyCompanyPropsNotifyRenewal, offerCompanyCompanyPropsNotifySubscriptionCancellation, offerCompanyCompanyPropsBranding, offerCompanyCompanyPropsBillingInformationMandatory, offerCompanyId, offerCompanyName, offerCompanySiteName, offerId, offerSecureId, offerName, offerDescription, offerPrice, offerCurrency, offerMultiplePurchase, offerRecurrenceCount, offerTrialPeriod, offerProductType, offerRenewalType, offerDisablePaymentForm, offerCreateDate, offerImagePath, subscriberBillingAddressId, subscriberBillingAddressName, subscriberBillingAddressStreetAddress, subscriberBillingAddressPostalCode, subscriberBillingAddressCity, subscriberBillingAddressStateProvince, subscriberBillingAddressCountry, subscriberBillingAddressCompanyId, subscriberShippingAddressId, subscriberShippingAddressName, subscriberShippingAddressStreetAddress, subscriberShippingAddressPostalCode, subscriberShippingAddressCity, subscriberShippingAddressStateProvince, subscriberShippingAddressCountry, subscriberShippingAddressCompanyId, subscriberCompanyAddressId, subscriberCompanyAddressName, subscriberCompanyAddressStreetAddress, subscriberCompanyAddressPostalCode, subscriberCompanyAddressCity, subscriberCompanyAddressStateProvince, subscriberCompanyAddressCountry, subscriberCompanyAddressCompanyId, subscriberCompanyCompanyPropsId, subscriberCompanyCompanyPropsCallbackUrl, subscriberCompanyCompanyPropsLogoPath, subscriberCompanyCompanyPropsHostedPageCSSPath, subscriberCompanyCompanyPropsPrivacyPolicyUrl, subscriberCompanyCompanyPropsSubscreasyApiKey, subscriberCompanyCompanyPropsSubscreasySecureKey, subscriberCompanyCompanyPropsPaymentGateway, subscriberCompanyCompanyPropsMobilePaymentGateway, subscriberCompanyCompanyPropsWirecardUserCode, subscriberCompanyCompanyPropsWirecardPin, subscriberCompanyCompanyPropsWirecardTurkcellServisId, subscriberCompanyCompanyPropsWirecardSuccessfulMessage, subscriberCompanyCompanyPropsWirecardErrorMessage, subscriberCompanyCompanyPropsPaymentGatewayApiKey, subscriberCompanyCompanyPropsPaymentGatewaySecurityKey, subscriberCompanyCompanyPropsPayuMerchantKeyRenewals, subscriberCompanyCompanyPropsPayuSecretKeyRenewals, subscriberCompanyCompanyPropsPaytrMerchantId, subscriberCompanyCompanyPropsMobilExpressMerchantKey, subscriberCompanyCompanyPropsMobilExpressApiPassword, subscriberCompanyCompanyPropsMobilExpressPosid, subscriberCompanyCompanyPropsBillingDate, subscriberCompanyCompanyPropsBillingThresholdDays, subscriberCompanyCompanyPropsDomainName, subscriberCompanyCompanyPropsContactEmail, subscriberCompanyCompanyPropsSendDailyReports, subscriberCompanyCompanyPropsNotifyNewSubscription, subscriberCompanyCompanyPropsNotifyRenewal, subscriberCompanyCompanyPropsNotifySubscriptionCancellation, subscriberCompanyCompanyPropsBranding, subscriberCompanyCompanyPropsBillingInformationMandatory, subscriberCompanyId, subscriberCompanyName, subscriberCompanySiteName, subscriberId, subscriberSecureId, subscriberMerchantSubscriberId, subscriberEmail, subscriberName, subscriberSurname, subscriberPhoneNumber, subscriberCreateDate, subscriberIdentificationNo, subscriberTaxNumber, subscriberTaxAdministration, subscriberWorksFor, paymentCardCardHolderName, paymentCardCardNumber, paymentCardExpireYear, paymentCardExpireMonth, paymentCardCvc, paymentCardRegisterCard, paymentCardCardAlias, paymentCardCardToken, paymentCardCardUserKey, paymentCardCardFamily, subscriberFromDbBillingAddressId, subscriberFromDbBillingAddressName, subscriberFromDbBillingAddressStreetAddress, subscriberFromDbBillingAddressPostalCode, subscriberFromDbBillingAddressCity, subscriberFromDbBillingAddressStateProvince, subscriberFromDbBillingAddressCountry, subscriberFromDbBillingAddressCompanyId, subscriberFromDbShippingAddressId, subscriberFromDbShippingAddressName, subscriberFromDbShippingAddressStreetAddress, subscriberFromDbShippingAddressPostalCode, subscriberFromDbShippingAddressCity, subscriberFromDbShippingAddressStateProvince, subscriberFromDbShippingAddressCountry, subscriberFromDbShippingAddressCompanyId, subscriberFromDbCompanyAddressId, subscriberFromDbCompanyAddressName, subscriberFromDbCompanyAddressStreetAddress, subscriberFromDbCompanyAddressPostalCode, subscriberFromDbCompanyAddressCity, subscriberFromDbCompanyAddressStateProvince, subscriberFromDbCompanyAddressCountry, subscriberFromDbCompanyAddressCompanyId, subscriberFromDbCompanyCompanyPropsId, subscriberFromDbCompanyCompanyPropsCallbackUrl, subscriberFromDbCompanyCompanyPropsLogoPath, subscriberFromDbCompanyCompanyPropsHostedPageCSSPath, subscriberFromDbCompanyCompanyPropsPrivacyPolicyUrl, subscriberFromDbCompanyCompanyPropsSubscreasyApiKey, subscriberFromDbCompanyCompanyPropsSubscreasySecureKey, subscriberFromDbCompanyCompanyPropsPaymentGateway, subscriberFromDbCompanyCompanyPropsMobilePaymentGateway, subscriberFromDbCompanyCompanyPropsWirecardUserCode, subscriberFromDbCompanyCompanyPropsWirecardPin, subscriberFromDbCompanyCompanyPropsWirecardTurkcellServisId, subscriberFromDbCompanyCompanyPropsWirecardSuccessfulMessage, subscriberFromDbCompanyCompanyPropsWirecardErrorMessage, subscriberFromDbCompanyCompanyPropsPaymentGatewayApiKey, subscriberFromDbCompanyCompanyPropsPaymentGatewaySecurityKey, subscriberFromDbCompanyCompanyPropsPayuMerchantKeyRenewals, subscriberFromDbCompanyCompanyPropsPayuSecretKeyRenewals, subscriberFromDbCompanyCompanyPropsPaytrMerchantId, subscriberFromDbCompanyCompanyPropsMobilExpressMerchantKey, subscriberFromDbCompanyCompanyPropsMobilExpressApiPassword, subscriberFromDbCompanyCompanyPropsMobilExpressPosid, subscriberFromDbCompanyCompanyPropsBillingDate, subscriberFromDbCompanyCompanyPropsBillingThresholdDays, subscriberFromDbCompanyCompanyPropsDomainName, subscriberFromDbCompanyCompanyPropsContactEmail, subscriberFromDbCompanyCompanyPropsSendDailyReports, subscriberFromDbCompanyCompanyPropsNotifyNewSubscription, subscriberFromDbCompanyCompanyPropsNotifyRenewal, subscriberFromDbCompanyCompanyPropsNotifySubscriptionCancellation, subscriberFromDbCompanyCompanyPropsBranding, subscriberFromDbCompanyCompanyPropsBillingInformationMandatory, subscriberFromDbCompanyId, subscriberFromDbCompanyName, subscriberFromDbCompanySiteName, subscriberFromDbId, subscriberFromDbSecureId, subscriberFromDbMerchantSubscriberId, subscriberFromDbEmail, subscriberFromDbName, subscriberFromDbSurname, subscriberFromDbPhoneNumber, subscriberFromDbCreateDate, subscriberFromDbIdentificationNo, subscriberFromDbTaxNumber, subscriberFromDbTaxAdministration, subscriberFromDbWorksFor, couponCode, callbackUrl, price, companySiteName, privacyPolicyUrl, paymentType, editable, productType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsNoAuthApi.StartSubscription3dsUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerRecurrenceId** | **long?**|  | [optional] 
 **offerRecurrenceRecurrenceType** | **string**|  | [optional] 
 **offerRecurrenceLength** | **long?**|  | [optional] 
 **offerCompanyAddressId** | **long?**|  | [optional] 
 **offerCompanyAddressName** | **string**|  | [optional] 
 **offerCompanyAddressStreetAddress** | **string**|  | [optional] 
 **offerCompanyAddressPostalCode** | **string**|  | [optional] 
 **offerCompanyAddressCity** | **string**|  | [optional] 
 **offerCompanyAddressStateProvince** | **string**|  | [optional] 
 **offerCompanyAddressCountry** | **string**|  | [optional] 
 **offerCompanyAddressCompanyId** | **long?**|  | [optional] 
 **offerCompanyCompanyPropsId** | **long?**|  | [optional] 
 **offerCompanyCompanyPropsCallbackUrl** | **string**|  | [optional] 
 **offerCompanyCompanyPropsLogoPath** | **string**|  | [optional] 
 **offerCompanyCompanyPropsHostedPageCSSPath** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPrivacyPolicyUrl** | **string**|  | [optional] 
 **offerCompanyCompanyPropsSubscreasyApiKey** | **string**|  | [optional] 
 **offerCompanyCompanyPropsSubscreasySecureKey** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPaymentGateway** | **string**|  | [optional] 
 **offerCompanyCompanyPropsMobilePaymentGateway** | **string**|  | [optional] 
 **offerCompanyCompanyPropsWirecardUserCode** | **string**|  | [optional] 
 **offerCompanyCompanyPropsWirecardPin** | **string**|  | [optional] 
 **offerCompanyCompanyPropsWirecardTurkcellServisId** | **string**|  | [optional] 
 **offerCompanyCompanyPropsWirecardSuccessfulMessage** | **string**|  | [optional] 
 **offerCompanyCompanyPropsWirecardErrorMessage** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPaymentGatewayApiKey** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPaymentGatewaySecurityKey** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPayuMerchantKeyRenewals** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPayuSecretKeyRenewals** | **string**|  | [optional] 
 **offerCompanyCompanyPropsPaytrMerchantId** | **int?**|  | [optional] 
 **offerCompanyCompanyPropsMobilExpressMerchantKey** | **string**|  | [optional] 
 **offerCompanyCompanyPropsMobilExpressApiPassword** | **string**|  | [optional] 
 **offerCompanyCompanyPropsMobilExpressPosid** | **int?**|  | [optional] 
 **offerCompanyCompanyPropsBillingDate** | **int?**|  | [optional] 
 **offerCompanyCompanyPropsBillingThresholdDays** | **int?**|  | [optional] 
 **offerCompanyCompanyPropsDomainName** | **string**|  | [optional] 
 **offerCompanyCompanyPropsContactEmail** | **string**|  | [optional] 
 **offerCompanyCompanyPropsSendDailyReports** | **string**|  | [optional] 
 **offerCompanyCompanyPropsNotifyNewSubscription** | **bool?**|  | [optional] 
 **offerCompanyCompanyPropsNotifyRenewal** | **bool?**|  | [optional] 
 **offerCompanyCompanyPropsNotifySubscriptionCancellation** | **bool?**|  | [optional] 
 **offerCompanyCompanyPropsBranding** | **bool?**|  | [optional] 
 **offerCompanyCompanyPropsBillingInformationMandatory** | **bool?**|  | [optional] 
 **offerCompanyId** | **long?**|  | [optional] 
 **offerCompanyName** | **string**|  | [optional] 
 **offerCompanySiteName** | **string**|  | [optional] 
 **offerId** | **long?**|  | [optional] 
 **offerSecureId** | **string**|  | [optional] 
 **offerName** | **string**|  | [optional] 
 **offerDescription** | **string**|  | [optional] 
 **offerPrice** | **decimal?**|  | [optional] 
 **offerCurrency** | **string**|  | [optional] 
 **offerMultiplePurchase** | **bool?**|  | [optional] 
 **offerRecurrenceCount** | **int?**|  | [optional] 
 **offerTrialPeriod** | **int?**|  | [optional] 
 **offerProductType** | **string**|  | [optional] 
 **offerRenewalType** | **string**|  | [optional] 
 **offerDisablePaymentForm** | **bool?**|  | [optional] 
 **offerCreateDate** | **DateTime?**|  | [optional] 
 **offerImagePath** | **string**|  | [optional] 
 **subscriberBillingAddressId** | **long?**|  | [optional] 
 **subscriberBillingAddressName** | **string**|  | [optional] 
 **subscriberBillingAddressStreetAddress** | **string**|  | [optional] 
 **subscriberBillingAddressPostalCode** | **string**|  | [optional] 
 **subscriberBillingAddressCity** | **string**|  | [optional] 
 **subscriberBillingAddressStateProvince** | **string**|  | [optional] 
 **subscriberBillingAddressCountry** | **string**|  | [optional] 
 **subscriberBillingAddressCompanyId** | **long?**|  | [optional] 
 **subscriberShippingAddressId** | **long?**|  | [optional] 
 **subscriberShippingAddressName** | **string**|  | [optional] 
 **subscriberShippingAddressStreetAddress** | **string**|  | [optional] 
 **subscriberShippingAddressPostalCode** | **string**|  | [optional] 
 **subscriberShippingAddressCity** | **string**|  | [optional] 
 **subscriberShippingAddressStateProvince** | **string**|  | [optional] 
 **subscriberShippingAddressCountry** | **string**|  | [optional] 
 **subscriberShippingAddressCompanyId** | **long?**|  | [optional] 
 **subscriberCompanyAddressId** | **long?**|  | [optional] 
 **subscriberCompanyAddressName** | **string**|  | [optional] 
 **subscriberCompanyAddressStreetAddress** | **string**|  | [optional] 
 **subscriberCompanyAddressPostalCode** | **string**|  | [optional] 
 **subscriberCompanyAddressCity** | **string**|  | [optional] 
 **subscriberCompanyAddressStateProvince** | **string**|  | [optional] 
 **subscriberCompanyAddressCountry** | **string**|  | [optional] 
 **subscriberCompanyAddressCompanyId** | **long?**|  | [optional] 
 **subscriberCompanyCompanyPropsId** | **long?**|  | [optional] 
 **subscriberCompanyCompanyPropsCallbackUrl** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsLogoPath** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsHostedPageCSSPath** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPrivacyPolicyUrl** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsSubscreasyApiKey** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsSubscreasySecureKey** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPaymentGateway** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsMobilePaymentGateway** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsWirecardUserCode** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsWirecardPin** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsWirecardTurkcellServisId** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsWirecardSuccessfulMessage** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsWirecardErrorMessage** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPaymentGatewayApiKey** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPaymentGatewaySecurityKey** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPayuMerchantKeyRenewals** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPayuSecretKeyRenewals** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsPaytrMerchantId** | **int?**|  | [optional] 
 **subscriberCompanyCompanyPropsMobilExpressMerchantKey** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsMobilExpressApiPassword** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsMobilExpressPosid** | **int?**|  | [optional] 
 **subscriberCompanyCompanyPropsBillingDate** | **int?**|  | [optional] 
 **subscriberCompanyCompanyPropsBillingThresholdDays** | **int?**|  | [optional] 
 **subscriberCompanyCompanyPropsDomainName** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsContactEmail** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsSendDailyReports** | **string**|  | [optional] 
 **subscriberCompanyCompanyPropsNotifyNewSubscription** | **bool?**|  | [optional] 
 **subscriberCompanyCompanyPropsNotifyRenewal** | **bool?**|  | [optional] 
 **subscriberCompanyCompanyPropsNotifySubscriptionCancellation** | **bool?**|  | [optional] 
 **subscriberCompanyCompanyPropsBranding** | **bool?**|  | [optional] 
 **subscriberCompanyCompanyPropsBillingInformationMandatory** | **bool?**|  | [optional] 
 **subscriberCompanyId** | **long?**|  | [optional] 
 **subscriberCompanyName** | **string**|  | [optional] 
 **subscriberCompanySiteName** | **string**|  | [optional] 
 **subscriberId** | **long?**|  | [optional] 
 **subscriberSecureId** | **string**|  | [optional] 
 **subscriberMerchantSubscriberId** | **string**|  | [optional] 
 **subscriberEmail** | **string**|  | [optional] 
 **subscriberName** | **string**|  | [optional] 
 **subscriberSurname** | **string**|  | [optional] 
 **subscriberPhoneNumber** | **string**|  | [optional] 
 **subscriberCreateDate** | **DateTime?**|  | [optional] 
 **subscriberIdentificationNo** | **string**|  | [optional] 
 **subscriberTaxNumber** | **string**|  | [optional] 
 **subscriberTaxAdministration** | **string**|  | [optional] 
 **subscriberWorksFor** | **string**|  | [optional] 
 **paymentCardCardHolderName** | **string**|  | [optional] 
 **paymentCardCardNumber** | **string**|  | [optional] 
 **paymentCardExpireYear** | **string**|  | [optional] 
 **paymentCardExpireMonth** | **string**|  | [optional] 
 **paymentCardCvc** | **string**|  | [optional] 
 **paymentCardRegisterCard** | **int?**|  | [optional] 
 **paymentCardCardAlias** | **string**|  | [optional] 
 **paymentCardCardToken** | **string**|  | [optional] 
 **paymentCardCardUserKey** | **string**|  | [optional] 
 **paymentCardCardFamily** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressId** | **long?**|  | [optional] 
 **subscriberFromDbBillingAddressName** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressStreetAddress** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressPostalCode** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressCity** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressStateProvince** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressCountry** | **string**|  | [optional] 
 **subscriberFromDbBillingAddressCompanyId** | **long?**|  | [optional] 
 **subscriberFromDbShippingAddressId** | **long?**|  | [optional] 
 **subscriberFromDbShippingAddressName** | **string**|  | [optional] 
 **subscriberFromDbShippingAddressStreetAddress** | **string**|  | [optional] 
 **subscriberFromDbShippingAddressPostalCode** | **string**|  | [optional] 
 **subscriberFromDbShippingAddressCity** | **string**|  | [optional] 
 **subscriberFromDbShippingAddressStateProvince** | **string**|  | [optional] 
 **subscriberFromDbShippingAddressCountry** | **string**|  | [optional] 
 **subscriberFromDbShippingAddressCompanyId** | **long?**|  | [optional] 
 **subscriberFromDbCompanyAddressId** | **long?**|  | [optional] 
 **subscriberFromDbCompanyAddressName** | **string**|  | [optional] 
 **subscriberFromDbCompanyAddressStreetAddress** | **string**|  | [optional] 
 **subscriberFromDbCompanyAddressPostalCode** | **string**|  | [optional] 
 **subscriberFromDbCompanyAddressCity** | **string**|  | [optional] 
 **subscriberFromDbCompanyAddressStateProvince** | **string**|  | [optional] 
 **subscriberFromDbCompanyAddressCountry** | **string**|  | [optional] 
 **subscriberFromDbCompanyAddressCompanyId** | **long?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsId** | **long?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsCallbackUrl** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsLogoPath** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsHostedPageCSSPath** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPrivacyPolicyUrl** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsSubscreasyApiKey** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsSubscreasySecureKey** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPaymentGateway** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsMobilePaymentGateway** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsWirecardUserCode** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsWirecardPin** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsWirecardTurkcellServisId** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsWirecardSuccessfulMessage** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsWirecardErrorMessage** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPaymentGatewayApiKey** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPaymentGatewaySecurityKey** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPayuMerchantKeyRenewals** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPayuSecretKeyRenewals** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsPaytrMerchantId** | **int?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsMobilExpressMerchantKey** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsMobilExpressApiPassword** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsMobilExpressPosid** | **int?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsBillingDate** | **int?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsBillingThresholdDays** | **int?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsDomainName** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsContactEmail** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsSendDailyReports** | **string**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsNotifyNewSubscription** | **bool?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsNotifyRenewal** | **bool?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsNotifySubscriptionCancellation** | **bool?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsBranding** | **bool?**|  | [optional] 
 **subscriberFromDbCompanyCompanyPropsBillingInformationMandatory** | **bool?**|  | [optional] 
 **subscriberFromDbCompanyId** | **long?**|  | [optional] 
 **subscriberFromDbCompanyName** | **string**|  | [optional] 
 **subscriberFromDbCompanySiteName** | **string**|  | [optional] 
 **subscriberFromDbId** | **long?**|  | [optional] 
 **subscriberFromDbSecureId** | **string**|  | [optional] 
 **subscriberFromDbMerchantSubscriberId** | **string**|  | [optional] 
 **subscriberFromDbEmail** | **string**|  | [optional] 
 **subscriberFromDbName** | **string**|  | [optional] 
 **subscriberFromDbSurname** | **string**|  | [optional] 
 **subscriberFromDbPhoneNumber** | **string**|  | [optional] 
 **subscriberFromDbCreateDate** | **DateTime?**|  | [optional] 
 **subscriberFromDbIdentificationNo** | **string**|  | [optional] 
 **subscriberFromDbTaxNumber** | **string**|  | [optional] 
 **subscriberFromDbTaxAdministration** | **string**|  | [optional] 
 **subscriberFromDbWorksFor** | **string**|  | [optional] 
 **couponCode** | **string**|  | [optional] 
 **callbackUrl** | **string**|  | [optional] 
 **price** | **decimal?**|  | [optional] 
 **companySiteName** | **string**|  | [optional] 
 **privacyPolicyUrl** | **bool?**|  | [optional] 
 **paymentType** | **string**|  | [optional] 
 **editable** | **bool?**|  | [optional] 
 **productType** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded;charset=UTF-8
 - **Accept**: text/html;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

