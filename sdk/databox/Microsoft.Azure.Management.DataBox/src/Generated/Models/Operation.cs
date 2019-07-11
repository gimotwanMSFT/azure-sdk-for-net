// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation entity.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Name of the operation. Format:
        /// {resourceProviderNamespace}/{resourceType}/{read|write|delete|action}</param>
        /// <param name="display">Operation display values.</param>
        /// <param name="properties">Operation properties.</param>
        /// <param name="origin">Origin of the operation. Can be :
        /// user|system|user,system</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay), object properties = default(object), string origin = default(string))
        {
            Name = name;
            Display = display;
            Properties = properties;
            Origin = origin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the operation. Format:
        /// {resourceProviderNamespace}/{resourceType}/{read|write|delete|action}
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets operation display values.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; private set; }

        /// <summary>
        /// Gets operation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; private set; }

        /// <summary>
        /// Gets origin of the operation. Can be : user|system|user,system
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; private set; }

    }
}