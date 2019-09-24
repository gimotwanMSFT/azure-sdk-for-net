// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A custom alert rule that checks if a value (depends on the custom alert
    /// type) is denied.
    /// </summary>
    public partial class DenylistCustomAlertRule : ListCustomAlertRule
    {
        /// <summary>
        /// Initializes a new instance of the DenylistCustomAlertRule class.
        /// </summary>
        public DenylistCustomAlertRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DenylistCustomAlertRule class.
        /// </summary>
        /// <param name="isEnabled">Status of the custom alert.</param>
        /// <param name="ruleType">The type of the custom alert rule.</param>
        /// <param name="denylistValues">The values to deny. The format of the
        /// values depends on the rule type.</param>
        /// <param name="displayName">The display name of the custom
        /// alert.</param>
        /// <param name="description">The description of the custom
        /// alert.</param>
        /// <param name="valueType">The value type of the items in the list.
        /// Possible values include: 'IpCidr', 'String'</param>
        public DenylistCustomAlertRule(bool isEnabled, string ruleType, IList<string> denylistValues, string displayName = default(string), string description = default(string), string valueType = default(string))
            : base(isEnabled, ruleType, displayName, description, valueType)
        {
            DenylistValues = denylistValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the values to deny. The format of the values depends
        /// on the rule type.
        /// </summary>
        [JsonProperty(PropertyName = "denylistValues")]
        public IList<string> DenylistValues { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DenylistValues == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DenylistValues");
            }
        }
    }
}