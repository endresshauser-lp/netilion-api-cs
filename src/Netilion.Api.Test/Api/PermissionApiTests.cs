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
    ///  Class for testing PermissionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PermissionApiTests
    {
        private PermissionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PermissionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PermissionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PermissionApi
            //Assert.IsInstanceOfType(typeof(PermissionApi), instance, "instance is a PermissionApi");
        }

        /// <summary>
        /// Test CreatePermissionInheritance
        /// </summary>
        [Test]
        public void CreatePermissionInheritanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PermissionInheritanceRequest body = null;
            //var response = instance.CreatePermissionInheritance(body);
            //Assert.IsInstanceOf<PermissionInheritanceResponse> (response, "response is PermissionInheritanceResponse");
        }
        /// <summary>
        /// Test CreatePermissions
        /// </summary>
        [Test]
        public void CreatePermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PermissionRequest body = null;
            //var response = instance.CreatePermissions(body);
            //Assert.IsInstanceOf<PermissionResponse> (response, "response is PermissionResponse");
        }
        /// <summary>
        /// Test DeletePermission
        /// </summary>
        [Test]
        public void DeletePermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeletePermission(id);
            
        }
        /// <summary>
        /// Test DeletePermissionInheritance
        /// </summary>
        [Test]
        public void DeletePermissionInheritanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeletePermissionInheritance(id);
            
        }
        /// <summary>
        /// Test GetPermissionById
        /// </summary>
        [Test]
        public void GetPermissionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string include = null;
            //var response = instance.GetPermissionById(id, include);
            //Assert.IsInstanceOf<PermissionResponse> (response, "response is PermissionResponse");
        }
        /// <summary>
        /// Test GetPermissionInheritanceById
        /// </summary>
        [Test]
        public void GetPermissionInheritanceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetPermissionInheritanceById(id);
            //Assert.IsInstanceOf<PermissionInheritanceResponse> (response, "response is PermissionInheritanceResponse");
        }
        /// <summary>
        /// Test GetPermissionInheritances
        /// </summary>
        [Test]
        public void GetPermissionInheritancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string permissionType = null;
            //long? permissionInheritableId = null;
            //string permissionInheritableType = null;
            //string orderBy = null;
            //var response = instance.GetPermissionInheritances(page, perPage, permissionType, permissionInheritableId, permissionInheritableType, orderBy);
            //Assert.IsInstanceOf<PermissionInheritances> (response, "response is PermissionInheritances");
        }
        /// <summary>
        /// Test GetPermissions
        /// </summary>
        [Test]
        public void GetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string permissionType = null;
            //long? assignableId = null;
            //string assignableType = null;
            //long? permitableId = null;
            //string permitableType = null;
            //string orderBy = null;
            //var response = instance.GetPermissions(page, perPage, include, permissionType, assignableId, assignableType, permitableId, permitableType, orderBy);
            //Assert.IsInstanceOf<Permissions> (response, "response is Permissions");
        }
    }

}
