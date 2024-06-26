﻿using System;

namespace PnP.Core.Model
{
    /// <summary>
    /// Attribute used to decorate model classes that can be loaded via Microsoft Graph
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class GraphTypeAttribute : Attribute
    {
        /// <summary>
        /// Defines the field that serves as the id field in Graph, typically this is the "id" field
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The actual target type for which this attribute is valid
        /// </summary>
        public Type Target { get; set; }

        /// <summary>
        /// URI that identifies an object in Microsoft Graph, used for get, update and delete requests
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// Get LINQ query API URI, overrides the global SharePointURI when specified
        /// </summary>
        public string LinqGet { get; set; }

        /// <summary>
        /// Get API URI, overrides the global GraphURI when specified
        /// </summary>
        public string Get { get; set; }

        /// <summary>
        /// Update API URI, overrides the global GraphURI when specified
        /// </summary>
        public string Update { get; set; }

        /// <summary>
        /// Delete API URI, overrides the global GraphURI when specified
        /// </summary>
        public string Delete { get; set; }

        /// <summary>
        /// Model property name that will hold dynamic data (e.g. List Item property/value pairs)
        /// </summary>
        public string OverflowProperty { get; set; }

        /// <summary>
        /// Model property to define that a model can only be handled using the Microsoft Graph beta endpoint
        /// </summary>
        public bool Beta { get; set; }
    }
}
