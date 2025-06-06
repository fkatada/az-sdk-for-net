// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_InboundSecurityRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNetworkVirtualApplianceInboundSecurityRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/InboundSecurityRulePut.json
            // this example is just showing the usage of "InboundSecurityRule_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this InboundSecurityRuleResource
            InboundSecurityRuleCollection collection = networkVirtualAppliance.GetInboundSecurityRules();

            // invoke the operation
            string ruleCollectionName = "rule1";
            InboundSecurityRuleData data = new InboundSecurityRuleData
            {
                RuleType = InboundSecurityRuleType.Permanent,
                Rules = {new InboundSecurityRules
{
Name = "inboundRule1",
Protocol = InboundSecurityRulesProtocol.Tcp,
SourceAddressPrefix = "50.20.121.5/32",
DestinationPortRange = 22,
DestinationPortRanges = {"80-100"},
AppliesOn = {"slbip1"},
}},
            };
            ArmOperation<InboundSecurityRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleCollectionName, data);
            InboundSecurityRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InboundSecurityRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CreateNetworkVirtualApplianceInboundSecurityRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/InboundSecurityRuleGet.json
            // this example is just showing the usage of "InboundSecurityRule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this InboundSecurityRuleResource
            InboundSecurityRuleCollection collection = networkVirtualAppliance.GetInboundSecurityRules();

            // invoke the operation
            string ruleCollectionName = "rule1";
            InboundSecurityRuleResource result = await collection.GetAsync(ruleCollectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InboundSecurityRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CreateNetworkVirtualApplianceInboundSecurityRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/InboundSecurityRuleGet.json
            // this example is just showing the usage of "InboundSecurityRule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this InboundSecurityRuleResource
            InboundSecurityRuleCollection collection = networkVirtualAppliance.GetInboundSecurityRules();

            // invoke the operation
            string ruleCollectionName = "rule1";
            bool result = await collection.ExistsAsync(ruleCollectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CreateNetworkVirtualApplianceInboundSecurityRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/InboundSecurityRuleGet.json
            // this example is just showing the usage of "InboundSecurityRule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this InboundSecurityRuleResource
            InboundSecurityRuleCollection collection = networkVirtualAppliance.GetInboundSecurityRules();

            // invoke the operation
            string ruleCollectionName = "rule1";
            NullableResponse<InboundSecurityRuleResource> response = await collection.GetIfExistsAsync(ruleCollectionName);
            InboundSecurityRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InboundSecurityRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
