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
    ///  Class for testing ServiceInstanceResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ServiceInstanceResourceApiTests
    {
        private ServiceInstanceResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServiceInstanceResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServiceInstanceResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ServiceInstanceResourceApi
            //Assert.IsInstanceOfType(typeof(ServiceInstanceResourceApi), instance, "instance is a ServiceInstanceResourceApi");
        }

        
        /// <summary>
        /// Test CreateServiceInstanceUsingPOST
        /// </summary>
        [Test]
        public void CreateServiceInstanceUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ServiceInstance serviceInstance = null;
            //var response = instance.CreateServiceInstanceUsingPOST(serviceInstance);
            //Assert.IsInstanceOf<ServiceInstance> (response, "response is ServiceInstance");
        }
        
        /// <summary>
        /// Test DeleteServiceInstanceUsingDELETE
        /// </summary>
        [Test]
        public void DeleteServiceInstanceUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteServiceInstanceUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllServiceInstancesUsingGET
        /// </summary>
        [Test]
        public void GetAllServiceInstancesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllServiceInstancesUsingGET();
            //Assert.IsInstanceOf<List<ServiceInstance>> (response, "response is List<ServiceInstance>");
        }
        
        /// <summary>
        /// Test GetServiceInstanceUsingGET
        /// </summary>
        [Test]
        public void GetServiceInstanceUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetServiceInstanceUsingGET(id);
            //Assert.IsInstanceOf<ServiceInstance> (response, "response is ServiceInstance");
        }
        
        /// <summary>
        /// Test UpdateServiceInstanceUsingPUT
        /// </summary>
        [Test]
        public void UpdateServiceInstanceUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ServiceInstance serviceInstance = null;
            //var response = instance.UpdateServiceInstanceUsingPUT(serviceInstance);
            //Assert.IsInstanceOf<ServiceInstance> (response, "response is ServiceInstance");
        }
        
    }

}
