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
    ///  Class for testing APISubscriptionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class APISubscriptionApiTests
    {
        private APISubscriptionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new APISubscriptionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APISubscriptionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' APISubscriptionApi
            //Assert.IsInstanceOfType(typeof(APISubscriptionApi), instance, "instance is a APISubscriptionApi");
        }

        /// <summary>
        /// Test AddAssetsToAPISubscription
        /// </summary>
        [Test]
        public void AddAssetsToAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetIDs body = null;
            //long? id = null;
            //instance.AddAssetsToAPISubscription(body, id);
            
        }
        /// <summary>
        /// Test AddEdgeDevicesToApiSubscription
        /// </summary>
        [Test]
        public void AddEdgeDevicesToApiSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EdgeDevicesIds body = null;
            //long? id = null;
            //instance.AddEdgeDevicesToApiSubscription(body, id);
            
        }
        /// <summary>
        /// Test CreateAPISubscription
        /// </summary>
        [Test]
        public void CreateAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APISubscriptionRequest body = null;
            //var response = instance.CreateAPISubscription(body);
            //Assert.IsInstanceOf<APISubscriptionResponse> (response, "response is APISubscriptionResponse");
        }
        /// <summary>
        /// Test DeleteAPISubscription
        /// </summary>
        [Test]
        public void DeleteAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteAPISubscription(id);
            
        }
        /// <summary>
        /// Test GetAPISubscriptionById
        /// </summary>
        [Test]
        public void GetAPISubscriptionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string include = null;
            //var response = instance.GetAPISubscriptionById(id, include);
            //Assert.IsInstanceOf<APISubscriptionResponse> (response, "response is APISubscriptionResponse");
        }
        /// <summary>
        /// Test GetAPISubscriptions
        /// </summary>
        [Test]
        public void GetAPISubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //long? userId = null;
            //long? clientApplicationId = null;
            //string externalReference = null;
            //string status = null;
            //string subscriptionType = null;
            //string notificationStatus = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //DateTime? createdAt = null;
            //string createdAtFrom = null;
            //string createdAtTo = null;
            //DateTime? updatedAt = null;
            //string updatedAtFrom = null;
            //string updatedAtTo = null;
            //string orderBy = null;
            //var response = instance.GetAPISubscriptions(page, perPage, include, userId, clientApplicationId, externalReference, status, subscriptionType, notificationStatus, startDate, endDate, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, orderBy);
            //Assert.IsInstanceOf<APISubscriptionsResponse> (response, "response is APISubscriptionsResponse");
        }
        /// <summary>
        /// Test GetAssetsOfAPISubscription
        /// </summary>
        [Test]
        public void GetAssetsOfAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string serialNumber = null;
            //string productId = null;
            //string productCategoryId = null;
            //string parentId = null;
            //string manufacturerId = null;
            //string statusId = null;
            //string statusCode = null;
            //DateTime? productionDate = null;
            //DateTime? productionDateFrom = null;
            //DateTime? productionDateTo = null;
            //string specificationsKey = null;
            //string specificationsValue = null;
            //string nodeId = null;
            //DateTime? createdAt = null;
            //string createdAtFrom = null;
            //string createdAtTo = null;
            //DateTime? updatedAt = null;
            //string updatedAtFrom = null;
            //string updatedAtTo = null;
            //bool? ownershipClaimed = null;
            //string orderBy = null;
            //var response = instance.GetAssetsOfAPISubscription(id, page, perPage, include, serialNumber, productId, productCategoryId, parentId, manufacturerId, statusId, statusCode, productionDate, productionDateFrom, productionDateTo, specificationsKey, specificationsValue, nodeId, createdAt, createdAtFrom, createdAtTo, updatedAt, updatedAtFrom, updatedAtTo, ownershipClaimed, orderBy);
            //Assert.IsInstanceOf<AssetsResponse> (response, "response is AssetsResponse");
        }
        /// <summary>
        /// Test GetEdgeDevicesOfAPISubscription
        /// </summary>
        [Test]
        public void GetEdgeDevicesOfAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //string serialNumber = null;
            //string name = null;
            //string typeId = null;
            //string statusId = null;
            //string softwareVersionId = null;
            //string tenantId = null;
            //string technicalUserId = null;
            //string orderUserId = null;
            //string logLevel = null;
            //string specificationsKey = null;
            //string specificationsValue = null;
            //string orderBy = null;
            //var response = instance.GetEdgeDevicesOfAPISubscription(id, page, perPage, include, serialNumber, name, typeId, statusId, softwareVersionId, tenantId, technicalUserId, orderUserId, logLevel, specificationsKey, specificationsValue, orderBy);
            //Assert.IsInstanceOf<EdgeDeviceResponse> (response, "response is EdgeDeviceResponse");
        }
        /// <summary>
        /// Test GetSpecificationsOfAPISubscription
        /// </summary>
        [Test]
        public void GetSpecificationsOfAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string key = null;
            //var response = instance.GetSpecificationsOfAPISubscription(id, key);
            //Assert.IsInstanceOf<SpecificationsResponse> (response, "response is SpecificationsResponse");
        }
        /// <summary>
        /// Test RemoveAssetsFromAPISubscription
        /// </summary>
        [Test]
        public void RemoveAssetsFromAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetIDs body = null;
            //long? id = null;
            //instance.RemoveAssetsFromAPISubscription(body, id);
            
        }
        /// <summary>
        /// Test RemoveEdgeDevicesFromApiSubscription
        /// </summary>
        [Test]
        public void RemoveEdgeDevicesFromApiSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EdgeDevicesIds body = null;
            //long? id = null;
            //instance.RemoveEdgeDevicesFromApiSubscription(body, id);
            
        }
        /// <summary>
        /// Test RemoveSpecificationsFromAPISubscriptions
        /// </summary>
        [Test]
        public void RemoveSpecificationsFromAPISubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //long? id = null;
            //instance.RemoveSpecificationsFromAPISubscriptions(body, id);
            
        }
        /// <summary>
        /// Test RenameSpecificationsOfAPISubscriptions
        /// </summary>
        [Test]
        public void RenameSpecificationsOfAPISubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SpecificationsRename body = null;
            //long? id = null;
            //instance.RenameSpecificationsOfAPISubscriptions(body, id);
            
        }
        /// <summary>
        /// Test ReplaceAssetsOfAPISubscription
        /// </summary>
        [Test]
        public void ReplaceAssetsOfAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetIDs body = null;
            //long? id = null;
            //instance.ReplaceAssetsOfAPISubscription(body, id);
            
        }
        /// <summary>
        /// Test ReplaceEdgeDevicesOfApiSubscription
        /// </summary>
        [Test]
        public void ReplaceEdgeDevicesOfApiSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EdgeDevicesIds body = null;
            //long? id = null;
            //instance.ReplaceEdgeDevicesOfApiSubscription(body, id);
            
        }
        /// <summary>
        /// Test UpdateAPISubscription
        /// </summary>
        [Test]
        public void UpdateAPISubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APISubscriptionRequest body = null;
            //long? id = null;
            //instance.UpdateAPISubscription(body, id);
            
        }
        /// <summary>
        /// Test UpdateSpecificationsOfAPISubscriptions
        /// </summary>
        [Test]
        public void UpdateSpecificationsOfAPISubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary<string, SpecificationRequest> body = null;
            //long? id = null;
            //instance.UpdateSpecificationsOfAPISubscriptions(body, id);
            
        }
    }

}
