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
    ///  Class for testing ValuesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ValuesApiTests
    {
        private ValuesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ValuesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ValuesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ValuesApi
            //Assert.IsInstanceOfType(typeof(ValuesApi), instance, "instance is a ValuesApi");
        }

        /// <summary>
        /// Test CreateAssetValues
        /// </summary>
        [Test]
        public void CreateAssetValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetValuesRequest body = null;
            //long? assetId = null;
            //instance.CreateAssetValues(body, assetId);
            
        }
        /// <summary>
        /// Test GetAssetValues
        /// </summary>
        [Test]
        public void GetAssetValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? assetId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //string key = null;
            //string keyUnitId = null;
            //string group = null;
            //var response = instance.GetAssetValues(assetId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
            //Assert.IsInstanceOf<AssetValuesResponse> (response, "response is AssetValuesResponse");
        }
        /// <summary>
        /// Test GetAssetValuesForKey
        /// </summary>
        [Test]
        public void GetAssetValuesForKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? assetId = null;
            //string key = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? unitId = null;
            //string aggregation = null;
            //string interval = null;
            //string orderBy = null;
            //var response = instance.GetAssetValuesForKey(assetId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
            //Assert.IsInstanceOf<AssetKeyValuesResponse> (response, "response is AssetKeyValuesResponse");
        }
        /// <summary>
        /// Test GetBatchValues
        /// </summary>
        [Test]
        public void GetBatchValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? batchId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //string key = null;
            //string keyUnitId = null;
            //string group = null;
            //var response = instance.GetBatchValues(batchId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
            //Assert.IsInstanceOf<AssetValuesResponse> (response, "response is AssetValuesResponse");
        }
        /// <summary>
        /// Test GetBatchValuesForKey
        /// </summary>
        [Test]
        public void GetBatchValuesForKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? batchId = null;
            //string key = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? unitId = null;
            //string aggregation = null;
            //string interval = null;
            //string orderBy = null;
            //var response = instance.GetBatchValuesForKey(batchId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
            //Assert.IsInstanceOf<AssetKeyValuesResponse> (response, "response is AssetKeyValuesResponse");
        }
        /// <summary>
        /// Test GetInstrumentationValues
        /// </summary>
        [Test]
        public void GetInstrumentationValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? instrumentationId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //string key = null;
            //string keyUnitId = null;
            //string group = null;
            //var response = instance.GetInstrumentationValues(instrumentationId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
            //Assert.IsInstanceOf<AssetValuesResponse> (response, "response is AssetValuesResponse");
        }
        /// <summary>
        /// Test GetInstrumentationValuesForKey
        /// </summary>
        [Test]
        public void GetInstrumentationValuesForKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? instrumentationId = null;
            //string key = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? unitId = null;
            //string aggregation = null;
            //string interval = null;
            //string orderBy = null;
            //var response = instance.GetInstrumentationValuesForKey(instrumentationId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
            //Assert.IsInstanceOf<AssetKeyValuesResponse> (response, "response is AssetKeyValuesResponse");
        }
        /// <summary>
        /// Test GetSystemValues
        /// </summary>
        [Test]
        public void GetSystemValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? systemId = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //string key = null;
            //string keyUnitId = null;
            //string group = null;
            //var response = instance.GetSystemValues(systemId, page, perPage, include, usePreferredUnits, key, keyUnitId, group);
            //Assert.IsInstanceOf<AssetValuesResponse> (response, "response is AssetValuesResponse");
        }
        /// <summary>
        /// Test GetSystemValuesForKey
        /// </summary>
        [Test]
        public void GetSystemValuesForKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? systemId = null;
            //string key = null;
            //int? page = null;
            //int? perPage = null;
            //string include = null;
            //bool? usePreferredUnits = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? unitId = null;
            //string aggregation = null;
            //string interval = null;
            //string orderBy = null;
            //var response = instance.GetSystemValuesForKey(systemId, key, page, perPage, include, usePreferredUnits, from, to, unitId, aggregation, interval, orderBy);
            //Assert.IsInstanceOf<AssetKeyValuesResponse> (response, "response is AssetKeyValuesResponse");
        }
    }

}