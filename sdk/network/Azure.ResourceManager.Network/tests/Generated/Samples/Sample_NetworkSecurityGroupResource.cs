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
    public partial class Sample_NetworkSecurityGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNetworkSecurityGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkSecurityGroupGet.json
            // this example is just showing the usage of "NetworkSecurityGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkSecurityGroupName = "testnsg";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // invoke the operation
            NetworkSecurityGroupResource result = await networkSecurityGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteNetworkSecurityGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkSecurityGroupDelete.json
            // this example is just showing the usage of "NetworkSecurityGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkSecurityGroupName = "testnsg";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // invoke the operation
            await networkSecurityGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateNetworkSecurityGroupTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkSecurityGroupUpdateTags.json
            // this example is just showing the usage of "NetworkSecurityGroups_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkSecurityGroupName = "testnsg";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            NetworkSecurityGroupResource result = await networkSecurityGroup.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
