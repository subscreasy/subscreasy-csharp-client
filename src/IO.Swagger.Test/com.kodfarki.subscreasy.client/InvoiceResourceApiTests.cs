/* 
 * Api Documentation
 *
 * Api Documentation
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.com.kodfarki.subscreasy.client;
using IO.Swagger.com.kodfarki.subscreasy.client.model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing InvoiceResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvoiceResourceApiTests
    {
        private InvoiceResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoiceResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoiceResourceApi
            //Assert.IsInstanceOfType(typeof(InvoiceResourceApi), instance, "instance is a InvoiceResourceApi");
        }

        
        /// <summary>
        /// Test CreateInvoiceUsingPOST
        /// </summary>
        [Test]
        public void CreateInvoiceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Invoice invoice = null;
            //var response = instance.CreateInvoiceUsingPOST(invoice);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test DeleteInvoiceUsingDELETE
        /// </summary>
        [Test]
        public void DeleteInvoiceUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteInvoiceUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllInvoicesUsingGET
        /// </summary>
        [Test]
        public void GetAllInvoicesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllInvoicesUsingGET();
            //Assert.IsInstanceOf<List<Invoice>> (response, "response is List<Invoice>");
        }
        
        /// <summary>
        /// Test GetInvoiceBySubscriberUsingGET
        /// </summary>
        [Test]
        public void GetInvoiceBySubscriberUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriberSecureId = null;
            //var response = instance.GetInvoiceBySubscriberUsingGET(subscriberSecureId);
            //Assert.IsInstanceOf<List<Invoice>> (response, "response is List<Invoice>");
        }
        
        /// <summary>
        /// Test GetInvoiceUsingGET
        /// </summary>
        [Test]
        public void GetInvoiceUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetInvoiceUsingGET(id);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test UpdateInvoiceUsingPUT
        /// </summary>
        [Test]
        public void UpdateInvoiceUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Invoice invoice = null;
            //var response = instance.UpdateInvoiceUsingPUT(invoice);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
    }

}