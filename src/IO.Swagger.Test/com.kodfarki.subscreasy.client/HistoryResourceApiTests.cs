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
    ///  Class for testing HistoryResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HistoryResourceApiTests
    {
        private HistoryResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HistoryResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HistoryResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HistoryResourceApi
            //Assert.IsInstanceOfType(typeof(HistoryResourceApi), instance, "instance is a HistoryResourceApi");
        }

        
        /// <summary>
        /// Test CreateHistoryUsingPOST
        /// </summary>
        [Test]
        public void CreateHistoryUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //History history = null;
            //var response = instance.CreateHistoryUsingPOST(history);
            //Assert.IsInstanceOf<History> (response, "response is History");
        }
        
        /// <summary>
        /// Test DeleteHistoryUsingDELETE
        /// </summary>
        [Test]
        public void DeleteHistoryUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteHistoryUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllHistoriesUsingGET
        /// </summary>
        [Test]
        public void GetAllHistoriesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllHistoriesUsingGET();
            //Assert.IsInstanceOf<List<History>> (response, "response is List<History>");
        }
        
        /// <summary>
        /// Test GetHistoryUsingGET
        /// </summary>
        [Test]
        public void GetHistoryUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetHistoryUsingGET(id);
            //Assert.IsInstanceOf<History> (response, "response is History");
        }
        
        /// <summary>
        /// Test UpdateHistoryUsingPUT
        /// </summary>
        [Test]
        public void UpdateHistoryUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //History history = null;
            //var response = instance.UpdateHistoryUsingPUT(history);
            //Assert.IsInstanceOf<History> (response, "response is History");
        }
        
    }

}
