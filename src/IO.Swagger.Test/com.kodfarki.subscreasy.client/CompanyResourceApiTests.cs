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
    ///  Class for testing CompanyResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CompanyResourceApiTests
    {
        private CompanyResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompanyResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompanyResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompanyResourceApi
            //Assert.IsInstanceOfType(typeof(CompanyResourceApi), instance, "instance is a CompanyResourceApi");
        }

        
        /// <summary>
        /// Test CreateCompanyUsingPOST
        /// </summary>
        [Test]
        public void CreateCompanyUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Company company = null;
            //var response = instance.CreateCompanyUsingPOST(company);
            //Assert.IsInstanceOf<Company> (response, "response is Company");
        }
        
        /// <summary>
        /// Test DeleteCompanyUsingDELETE
        /// </summary>
        [Test]
        public void DeleteCompanyUsingDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteCompanyUsingDELETE(id);
            
        }
        
        /// <summary>
        /// Test GetAllCompaniesUsingGET
        /// </summary>
        [Test]
        public void GetAllCompaniesUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllCompaniesUsingGET();
            //Assert.IsInstanceOf<List<Company>> (response, "response is List<Company>");
        }
        
        /// <summary>
        /// Test GetCompanyUsingGET
        /// </summary>
        [Test]
        public void GetCompanyUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetCompanyUsingGET(id);
            //Assert.IsInstanceOf<Company> (response, "response is Company");
        }
        
        /// <summary>
        /// Test UpdateCompanyUsingPUT
        /// </summary>
        [Test]
        public void UpdateCompanyUsingPUTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Company company = null;
            //var response = instance.UpdateCompanyUsingPUT(company);
            //Assert.IsInstanceOf<Company> (response, "response is Company");
        }
        
    }

}
