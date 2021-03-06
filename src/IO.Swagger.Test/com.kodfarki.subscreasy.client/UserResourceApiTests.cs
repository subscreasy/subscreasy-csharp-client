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
    ///  Class for testing UserResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserResourceApiTests
    {
        private UserResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserResourceApi
            //Assert.IsInstanceOfType(typeof(UserResourceApi), instance, "instance is a UserResourceApi");
        }

        
        /// <summary>
        /// Test CreateUserUsingPOST
        /// </summary>
        [Test]
        public void CreateUserUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ManagedUserVM managedUserVM = null;
            //var response = instance.CreateUserUsingPOST(managedUserVM);
            //Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity");
        }
        
        /// <summary>
        /// Test DeleteUserUsingDELETE
        /// </summary>
        [Test]
        public void DeleteUserUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string login = null;
            //instance.DeleteUserUsingDELETE(login);
            
        }
        
        /// <summary>
        /// Test GetAllUsersUsingGET
        /// </summary>
        [Test]
        public void GetAllUsersUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //List<string> sort = null;
            //var response = instance.GetAllUsersUsingGET(page, size, sort);
            //Assert.IsInstanceOf<List<User>> (response, "response is List<User>");
        }
        
        /// <summary>
        /// Test GetAuthoritiesUsingGET
        /// </summary>
        [Test]
        public void GetAuthoritiesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAuthoritiesUsingGET();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetUserUsingGET
        /// </summary>
        [Test]
        public void GetUserUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string login = null;
            //var response = instance.GetUserUsingGET(login);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test UpdateUserUsingPUT
        /// </summary>
        [Test]
        public void UpdateUserUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ManagedUserVM managedUserVM = null;
            //var response = instance.UpdateUserUsingPUT(managedUserVM);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
    }

}
