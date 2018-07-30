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
    ///  Class for testing UserJwtControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserJwtControllerApiTests
    {
        private UserJwtControllerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserJwtControllerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserJwtControllerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserJwtControllerApi
            //Assert.IsInstanceOfType(typeof(UserJwtControllerApi), instance, "instance is a UserJwtControllerApi");
        }

        
        /// <summary>
        /// Test AuthorizeUsingPOST
        /// </summary>
        [Test]
        public void AuthorizeUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoginVM loginVM = null;
            //var response = instance.AuthorizeUsingPOST(loginVM);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        
    }

}
