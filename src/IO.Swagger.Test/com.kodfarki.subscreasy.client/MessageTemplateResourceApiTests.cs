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
    ///  Class for testing MessageTemplateResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessageTemplateResourceApiTests
    {
        private MessageTemplateResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MessageTemplateResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessageTemplateResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MessageTemplateResourceApi
            //Assert.IsInstanceOfType(typeof(MessageTemplateResourceApi), instance, "instance is a MessageTemplateResourceApi");
        }

        
        /// <summary>
        /// Test CreateMessageTemplateUsingPOST
        /// </summary>
        [Test]
        public void CreateMessageTemplateUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageTemplate messageTemplate = null;
            //var response = instance.CreateMessageTemplateUsingPOST(messageTemplate);
            //Assert.IsInstanceOf<MessageTemplate> (response, "response is MessageTemplate");
        }
        
        /// <summary>
        /// Test DeleteMessageTemplateUsingDELETE
        /// </summary>
        [Test]
        public void DeleteMessageTemplateUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteMessageTemplateUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllMessageTemplatesUsingGET
        /// </summary>
        [Test]
        public void GetAllMessageTemplatesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllMessageTemplatesUsingGET();
            //Assert.IsInstanceOf<List<MessageTemplate>> (response, "response is List<MessageTemplate>");
        }
        
        /// <summary>
        /// Test GetMessageTemplateUsingGET1
        /// </summary>
        [Test]
        public void GetMessageTemplateUsingGET1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetMessageTemplateUsingGET1(id);
            //Assert.IsInstanceOf<MessageTemplate> (response, "response is MessageTemplate");
        }
        
        /// <summary>
        /// Test UpdateMessageTemplateUsingPUT
        /// </summary>
        [Test]
        public void UpdateMessageTemplateUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageTemplate messageTemplate = null;
            //var response = instance.UpdateMessageTemplateUsingPUT(messageTemplate);
            //Assert.IsInstanceOf<MessageTemplate> (response, "response is MessageTemplate");
        }
        
    }

}
