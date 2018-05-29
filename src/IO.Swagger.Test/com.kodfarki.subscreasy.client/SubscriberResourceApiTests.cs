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
    ///  Class for testing SubscriberResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubscriberResourceApiTests
    {
        private SubscriberResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriberResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriberResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubscriberResourceApi
            //Assert.IsInstanceOfType(typeof(SubscriberResourceApi), instance, "instance is a SubscriberResourceApi");
        }

        
        /// <summary>
        /// Test CreateSubscriberUsingPOST
        /// </summary>
        [Test]
        public void CreateSubscriberUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Subscriber subscriber = null;
            //var response = instance.CreateSubscriberUsingPOST(subscriber);
            //Assert.IsInstanceOf<Subscriber> (response, "response is Subscriber");
        }
        
        /// <summary>
        /// Test DeleteSubscriberUsingDELETE
        /// </summary>
        [Test]
        public void DeleteSubscriberUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteSubscriberUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllSubscribersUsingGET
        /// </summary>
        [Test]
        public void GetAllSubscribersUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllSubscribersUsingGET();
            //Assert.IsInstanceOf<List<Subscriber>> (response, "response is List<Subscriber>");
        }
        
        /// <summary>
        /// Test GetSubscriberByEmailUsingGET
        /// </summary>
        [Test]
        public void GetSubscriberByEmailUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.GetSubscriberByEmailUsingGET(email);
            //Assert.IsInstanceOf<List<Subscriber>> (response, "response is List<Subscriber>");
        }
        
        /// <summary>
        /// Test GetSubscriberByNameUsingGET
        /// </summary>
        [Test]
        public void GetSubscriberByNameUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetSubscriberByNameUsingGET(name);
            //Assert.IsInstanceOf<List<Subscriber>> (response, "response is List<Subscriber>");
        }
        
        /// <summary>
        /// Test GetSubscriberUsingGET
        /// </summary>
        [Test]
        public void GetSubscriberUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetSubscriberUsingGET(id);
            //Assert.IsInstanceOf<Subscriber> (response, "response is Subscriber");
        }
        
        /// <summary>
        /// Test UpdateSubscriberUsingPUT
        /// </summary>
        [Test]
        public void UpdateSubscriberUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Subscriber subscriber = null;
            //var response = instance.UpdateSubscriberUsingPUT(subscriber);
            //Assert.IsInstanceOf<Subscriber> (response, "response is Subscriber");
        }
        
    }

}