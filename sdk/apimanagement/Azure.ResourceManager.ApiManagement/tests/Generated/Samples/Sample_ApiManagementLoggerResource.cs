// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementLoggerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetLogger.json
            // this example is just showing the usage of "Logger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementLoggerResource created on azure
            // for more information of creating ApiManagementLoggerResource, please refer to the document of ApiManagementLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string loggerId = "templateLogger";
            ResourceIdentifier apiManagementLoggerResourceId = ApiManagementLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, loggerId);
            ApiManagementLoggerResource apiManagementLogger = client.GetApiManagementLoggerResource(apiManagementLoggerResourceId);

            // invoke the operation
            ApiManagementLoggerResource result = await apiManagementLogger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteLogger.json
            // this example is just showing the usage of "Logger_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementLoggerResource created on azure
            // for more information of creating ApiManagementLoggerResource, please refer to the document of ApiManagementLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string loggerId = "loggerId";
            ResourceIdentifier apiManagementLoggerResourceId = ApiManagementLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, loggerId);
            ApiManagementLoggerResource apiManagementLogger = client.GetApiManagementLoggerResource(apiManagementLoggerResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementLogger.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdateLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementUpdateLogger.json
            // this example is just showing the usage of "Logger_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementLoggerResource created on azure
            // for more information of creating ApiManagementLoggerResource, please refer to the document of ApiManagementLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string loggerId = "eh1";
            ResourceIdentifier apiManagementLoggerResourceId = ApiManagementLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, loggerId);
            ApiManagementLoggerResource apiManagementLogger = client.GetApiManagementLoggerResource(apiManagementLoggerResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementLoggerPatch patch = new ApiManagementLoggerPatch
            {
                LoggerType = LoggerType.AzureEventHub,
                Description = "updating description",
            };
            ApiManagementLoggerResource result = await apiManagementLogger.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadLogger.json
            // this example is just showing the usage of "Logger_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementLoggerResource created on azure
            // for more information of creating ApiManagementLoggerResource, please refer to the document of ApiManagementLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string loggerId = "templateLogger";
            ResourceIdentifier apiManagementLoggerResourceId = ApiManagementLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, loggerId);
            ApiManagementLoggerResource apiManagementLogger = client.GetApiManagementLoggerResource(apiManagementLoggerResourceId);

            // invoke the operation
            bool result = await apiManagementLogger.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
