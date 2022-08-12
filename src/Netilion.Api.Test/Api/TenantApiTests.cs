/* 
 * Netilion API Documentation
 *
 * Welcome to the Netilion API Documentation, which provides interactive access and documentation to our REST API. Please visit our developer portal for further instructions and information: https://developer.netilion.endress.com/ 
 *
 * OpenAPI spec version: 01.00.00
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

using Netilion.Api.Client;
using Netilion.Api.Api;
using Netilion.Api.Model;

namespace Netilion.Api.Test
{
    /// <summary>
    ///  Class for testing TenantApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TenantApiTests
    {
        private TenantApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TenantApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TenantApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TenantApi
            //Assert.IsInstanceOfType(typeof(TenantApi), instance, "instance is a TenantApi");
        }

        /// <summary>
        /// Test AddTenantAdmins
        /// </summary>
        [Test]
        public void AddTenantAdminsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdminIDs body = null;
            //long? tenantId = null;
            //instance.AddTenantAdmins(body, tenantId);
            
        }
        /// <summary>
        /// Test AddTenantUsers
        /// </summary>
        [Test]
        public void AddTenantUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIDs body = null;
            //long? tenantId = null;
            //instance.AddTenantUsers(body, tenantId);
            
        }
        /// <summary>
        /// Test CreateTenants
        /// </summary>
        [Test]
        public void CreateTenantsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TenantRequest body = null;
            //var response = instance.CreateTenants(body);
            //Assert.IsInstanceOf<TenantResponse> (response, "response is TenantResponse");
        }
        /// <summary>
        /// Test DeleteTenant
        /// </summary>
        [Test]
        public void DeleteTenantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteTenant(id);
            
        }
        /// <summary>
        /// Test GetAssetTenantOptions
        /// </summary>
        [Test]
        public void GetAssetTenantOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? assetId = null;
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string orderBy = null;
            //var response = instance.GetAssetTenantOptions(assetId, page, perPage, name, orderBy);
            //Assert.IsInstanceOf<Tenants> (response, "response is Tenants");
        }
        /// <summary>
        /// Test GetTenantAdmins
        /// </summary>
        [Test]
        public void GetTenantAdminsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? tenantId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string firstName = null;
            //string lastName = null;
            //string orderBy = null;
            //var response = instance.GetTenantAdmins(tenantId, page, perPage, include, firstName, lastName, orderBy);
            //Assert.IsInstanceOf<UsersPublicResponse> (response, "response is UsersPublicResponse");
        }
        /// <summary>
        /// Test GetTenantUsers
        /// </summary>
        [Test]
        public void GetTenantUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? tenantId = null;
            //int? page = null;
            //int? perPage = null;
            //string firstName = null;
            //string lastName = null;
            //string orderBy = null;
            //var response = instance.GetTenantUsers(tenantId, page, perPage, firstName, lastName, orderBy);
            //Assert.IsInstanceOf<UsersPublicResponse> (response, "response is UsersPublicResponse");
        }
        /// <summary>
        /// Test GetTenants
        /// </summary>
        [Test]
        public void GetTenantsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string adminUserId = null;
            //string adminOrUserId = null;
            //bool? _public = null;
            //string orderBy = null;
            //var response = instance.GetTenants(page, perPage, name, adminUserId, adminOrUserId, _public, orderBy);
            //Assert.IsInstanceOf<TenantsResponse> (response, "response is TenantsResponse");
        }
        /// <summary>
        /// Test GetTenantsById
        /// </summary>
        [Test]
        public void GetTenantsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetTenantsById(id);
            //Assert.IsInstanceOf<TenantResponse> (response, "response is TenantResponse");
        }
        /// <summary>
        /// Test RemoveTenantAdmins
        /// </summary>
        [Test]
        public void RemoveTenantAdminsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdminIDs body = null;
            //long? tenantId = null;
            //instance.RemoveTenantAdmins(body, tenantId);
            
        }
        /// <summary>
        /// Test RemoveTenantUsers
        /// </summary>
        [Test]
        public void RemoveTenantUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIDs body = null;
            //long? tenantId = null;
            //instance.RemoveTenantUsers(body, tenantId);
            
        }
        /// <summary>
        /// Test ReplaceTenantAdmins
        /// </summary>
        [Test]
        public void ReplaceTenantAdminsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdminIDs body = null;
            //long? tenantId = null;
            //instance.ReplaceTenantAdmins(body, tenantId);
            
        }
        /// <summary>
        /// Test ReplaceTenantUsers
        /// </summary>
        [Test]
        public void ReplaceTenantUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIDs body = null;
            //long? tenantId = null;
            //instance.ReplaceTenantUsers(body, tenantId);
            
        }
        /// <summary>
        /// Test UpdateTenant
        /// </summary>
        [Test]
        public void UpdateTenantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TenantRequest body = null;
            //long? id = null;
            //instance.UpdateTenant(body, id);
            
        }
    }

}
