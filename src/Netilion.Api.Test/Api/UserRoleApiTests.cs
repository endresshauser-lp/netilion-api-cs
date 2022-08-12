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
    ///  Class for testing UserRoleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserRoleApiTests
    {
        private UserRoleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserRoleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserRoleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserRoleApi
            //Assert.IsInstanceOfType(typeof(UserRoleApi), instance, "instance is a UserRoleApi");
        }

        /// <summary>
        /// Test AddUsersToUserRole
        /// </summary>
        [Test]
        public void AddUsersToUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIDs body = null;
            //long? userroleId = null;
            //instance.AddUsersToUserRole(body, userroleId);
            
        }
        /// <summary>
        /// Test CreateUserRole
        /// </summary>
        [Test]
        public void CreateUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserRoleRequest body = null;
            //var response = instance.CreateUserRole(body);
            //Assert.IsInstanceOf<UserRoleResponse> (response, "response is UserRoleResponse");
        }
        /// <summary>
        /// Test DeleteUserRole
        /// </summary>
        [Test]
        public void DeleteUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteUserRole(id);
            
        }
        /// <summary>
        /// Test DeleteUsersFromUserRole
        /// </summary>
        [Test]
        public void DeleteUsersFromUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIDs body = null;
            //long? userroleId = null;
            //instance.DeleteUsersFromUserRole(body, userroleId);
            
        }
        /// <summary>
        /// Test GetUserRoleById
        /// </summary>
        [Test]
        public void GetUserRoleByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetUserRoleById(id);
            //Assert.IsInstanceOf<UserRoleResponse> (response, "response is UserRoleResponse");
        }
        /// <summary>
        /// Test GetUserRoles
        /// </summary>
        [Test]
        public void GetUserRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string name = null;
            //string tenantId = null;
            //string orderBy = null;
            //var response = instance.GetUserRoles(page, perPage, name, tenantId, orderBy);
            //Assert.IsInstanceOf<UserRolesResponse> (response, "response is UserRolesResponse");
        }
        /// <summary>
        /// Test GetUsersOfUserRole
        /// </summary>
        [Test]
        public void GetUsersOfUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? userroleId = null;
            //int? page = null;
            //int? perPage = null;
            //string firstName = null;
            //string lastName = null;
            //string orderBy = null;
            //var response = instance.GetUsersOfUserRole(userroleId, page, perPage, firstName, lastName, orderBy);
            //Assert.IsInstanceOf<UsersPublicResponse> (response, "response is UsersPublicResponse");
        }
        /// <summary>
        /// Test ReplaceUsersOfUserRole
        /// </summary>
        [Test]
        public void ReplaceUsersOfUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIDs body = null;
            //long? userroleId = null;
            //instance.ReplaceUsersOfUserRole(body, userroleId);
            
        }
        /// <summary>
        /// Test UpdateUserRole
        /// </summary>
        [Test]
        public void UpdateUserRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserRoleRequest body = null;
            //long? id = null;
            //instance.UpdateUserRole(body, id);
            
        }
    }

}
