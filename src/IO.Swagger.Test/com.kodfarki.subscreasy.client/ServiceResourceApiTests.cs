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
    ///  Class for testing ServiceResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ServiceResourceApiTests
    {
        private ServiceResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServiceResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServiceResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ServiceResourceApi
            //Assert.IsInstanceOfType(typeof(ServiceResourceApi), instance, "instance is a ServiceResourceApi");
        }

        
        /// <summary>
        /// Test CreateServiceUsingPOST
        /// </summary>
        [Test]
        public void CreateServiceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Service service = null;
            //var response = instance.CreateServiceUsingPOST(service);
            //Assert.IsInstanceOf<Service> (response, "response is Service");
        }
        
        /// <summary>
        /// Test DeleteServiceUsingDELETE
        /// </summary>
        [Test]
        public void DeleteServiceUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteServiceUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllServicesUsingGET
        /// </summary>
        [Test]
        public void GetAllServicesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllServicesUsingGET();
            //Assert.IsInstanceOf<List<Service>> (response, "response is List<Service>");
        }
        
        /// <summary>
        /// Test GetServiceUsingGET
        /// </summary>
        [Test]
        public void GetServiceUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetServiceUsingGET(id);
            //Assert.IsInstanceOf<Service> (response, "response is Service");
        }
        
        /// <summary>
        /// Test UpdateServiceUsingPUT
        /// </summary>
        [Test]
        public void UpdateServiceUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Service service = null;
            //var response = instance.UpdateServiceUsingPUT(service);
            //Assert.IsInstanceOf<Service> (response, "response is Service");
        }
        
    }

}