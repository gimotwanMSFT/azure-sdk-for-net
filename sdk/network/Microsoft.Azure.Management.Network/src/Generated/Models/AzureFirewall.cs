// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Firewall resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureFirewall : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AzureFirewall class.
        /// </summary>
        public AzureFirewall()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFirewall class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="applicationRuleCollections">Collection of application
        /// rule collections used by Azure Firewall.</param>
        /// <param name="natRuleCollections">Collection of NAT rule collections
        /// used by Azure Firewall.</param>
        /// <param name="networkRuleCollections">Collection of network rule
        /// collections used by Azure Firewall.</param>
        /// <param name="ipConfigurations">IP configuration of the Azure
        /// Firewall resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="threatIntelMode">The operation mode for Threat
        /// Intelligence. Possible values include: 'Alert', 'Deny',
        /// 'Off'</param>
        /// <param name="virtualHub">The virtualHub to which the firewall
        /// belongs.</param>
        /// <param name="firewallPolicy">The firewallPolicy associated with
        /// this azure firewall.</param>
        /// <param name="hubIpAddresses">IP addresses associated with
        /// AzureFirewall.</param>
        /// <param name="zones">A list of availability zones denoting where the
        /// resource needs to come from.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public AzureFirewall(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<AzureFirewallApplicationRuleCollection> applicationRuleCollections = default(IList<AzureFirewallApplicationRuleCollection>), IList<AzureFirewallNatRuleCollection> natRuleCollections = default(IList<AzureFirewallNatRuleCollection>), IList<AzureFirewallNetworkRuleCollection> networkRuleCollections = default(IList<AzureFirewallNetworkRuleCollection>), IList<AzureFirewallIPConfiguration> ipConfigurations = default(IList<AzureFirewallIPConfiguration>), string provisioningState = default(string), string threatIntelMode = default(string), SubResource virtualHub = default(SubResource), SubResource firewallPolicy = default(SubResource), HubIPAddresses hubIpAddresses = default(HubIPAddresses), IList<string> zones = default(IList<string>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            ApplicationRuleCollections = applicationRuleCollections;
            NatRuleCollections = natRuleCollections;
            NetworkRuleCollections = networkRuleCollections;
            IpConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
            ThreatIntelMode = threatIntelMode;
            VirtualHub = virtualHub;
            FirewallPolicy = firewallPolicy;
            HubIpAddresses = hubIpAddresses;
            Zones = zones;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of application rule collections used by
        /// Azure Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationRuleCollections")]
        public IList<AzureFirewallApplicationRuleCollection> ApplicationRuleCollections { get; set; }

        /// <summary>
        /// Gets or sets collection of NAT rule collections used by Azure
        /// Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "properties.natRuleCollections")]
        public IList<AzureFirewallNatRuleCollection> NatRuleCollections { get; set; }

        /// <summary>
        /// Gets or sets collection of network rule collections used by Azure
        /// Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkRuleCollections")]
        public IList<AzureFirewallNetworkRuleCollection> NetworkRuleCollections { get; set; }

        /// <summary>
        /// Gets or sets IP configuration of the Azure Firewall resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<AzureFirewallIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the operation mode for Threat Intelligence. Possible
        /// values include: 'Alert', 'Deny', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.threatIntelMode")]
        public string ThreatIntelMode { get; set; }

        /// <summary>
        /// Gets or sets the virtualHub to which the firewall belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// Gets or sets the firewallPolicy associated with this azure
        /// firewall.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallPolicy")]
        public SubResource FirewallPolicy { get; set; }

        /// <summary>
        /// Gets or sets IP addresses associated with AzureFirewall.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hubIpAddresses")]
        public HubIPAddresses HubIpAddresses { get; set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting where the
        /// resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
