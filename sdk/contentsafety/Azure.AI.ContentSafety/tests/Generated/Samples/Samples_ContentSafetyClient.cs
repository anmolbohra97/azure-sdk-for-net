// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.ContentSafety.Samples
{
    public class Samples_ContentSafetyClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeText()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                text = "<text>",
            };

            Response response = client.AnalyzeText(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeText_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                text = "<text>",
                categories = new[] {
        "Hate"
    },
                blocklistNames = new[] {
        "<String>"
    },
                breakByBlocklists = true,
            };

            Response response = client.AnalyzeText(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("blocklistName").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("blockItemText").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("severity").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeText_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                text = "<text>",
            };

            Response response = await client.AnalyzeTextAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeText_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                text = "<text>",
                categories = new[] {
        "Hate"
    },
                blocklistNames = new[] {
        "<String>"
    },
                breakByBlocklists = true,
            };

            Response response = await client.AnalyzeTextAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("blocklistName").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("blockItemText").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("blocklistsMatchResults")[0].GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("severity").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeText_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var body = new AnalyzeTextOptions("<text>")
            {
                Categories =
{
        TextCategory.Hate
    },
                BlocklistNames =
{
        "<null>"
    },
                BreakByBlocklists = true,
            };
            var result = await client.AnalyzeTextAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeImage()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                image = new { },
            };

            Response response = client.AnalyzeImage(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeImage_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                image = new
                {
                    content = new { },
                    blobUrl = "http://localhost:3000",
                },
                categories = new[] {
        "Hate"
    },
            };

            Response response = client.AnalyzeImage(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("severity").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeImage_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                image = new { },
            };

            Response response = await client.AnalyzeImageAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeImage_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                image = new
                {
                    content = new { },
                    blobUrl = "http://localhost:3000",
                },
                categories = new[] {
        "Hate"
    },
            };

            Response response = await client.AnalyzeImageAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("hateResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("selfHarmResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("sexualResult").GetProperty("severity").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("category").ToString());
            Console.WriteLine(result.GetProperty("violenceResult").GetProperty("severity").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeImage_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var body = new AnalyzeImageOptions(new ImageData()
            {
                Content = BinaryData.FromString("<your binary data content>"),
                BlobUrl = new Uri("http://localhost:3000"),
            })
            {
                Categories =
{
        ImageCategory.Hate
    },
            };
            var result = await client.AnalyzeImageAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklist()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = client.GetTextBlocklist("<blocklistName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklist_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = client.GetTextBlocklist("<blocklistName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklist_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = await client.GetTextBlocklistAsync("<blocklistName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklist_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = await client.GetTextBlocklistAsync("<blocklistName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklist_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var result = await client.GetTextBlocklistAsync("<blocklistName>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdateTextBlocklist()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blocklistName = "<blocklistName>",
            };

            Response response = client.CreateOrUpdateTextBlocklist("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdateTextBlocklist_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blocklistName = "<blocklistName>",
                description = "<description>",
            };

            Response response = client.CreateOrUpdateTextBlocklist("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdateTextBlocklist_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blocklistName = "<blocklistName>",
            };

            Response response = await client.CreateOrUpdateTextBlocklistAsync("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdateTextBlocklist_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blocklistName = "<blocklistName>",
                description = "<description>",
            };

            Response response = await client.CreateOrUpdateTextBlocklistAsync("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blocklistName").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteTextBlocklist()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = client.DeleteTextBlocklist("<blocklistName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteTextBlocklist_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = client.DeleteTextBlocklist("<blocklistName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteTextBlocklist_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = await client.DeleteTextBlocklistAsync("<blocklistName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteTextBlocklist_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = await client.DeleteTextBlocklistAsync("<blocklistName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AddBlockItems()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItems = new[] {
        new {
            text = "<text>",
        }
    },
            };

            Response response = client.AddBlockItems("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AddBlockItems_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItems = new[] {
        new {
            description = "<description>",
            text = "<text>",
        }
    },
            };

            Response response = client.AddBlockItems("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("text").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddBlockItems_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItems = new[] {
        new {
            text = "<text>",
        }
    },
            };

            Response response = await client.AddBlockItemsAsync("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddBlockItems_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItems = new[] {
        new {
            description = "<description>",
            text = "<text>",
        }
    },
            };

            Response response = await client.AddBlockItemsAsync("<blocklistName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("text").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AddBlockItems_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var addBlockItemsOptions = new AddBlockItemsOptions(new TextBlockItemInfo[]
            {
    new TextBlockItemInfo("<text>")
{
        Description = "<Description>",
    }
            });
            var result = await client.AddBlockItemsAsync("<blocklistName>", addBlockItemsOptions);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveBlockItems()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItemIds = new[] {
        "<String>"
    },
            };

            Response response = client.RemoveBlockItems("<blocklistName>", RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RemoveBlockItems_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItemIds = new[] {
        "<String>"
    },
            };

            Response response = client.RemoveBlockItems("<blocklistName>", RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveBlockItems_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItemIds = new[] {
        "<String>"
    },
            };

            Response response = await client.RemoveBlockItemsAsync("<blocklistName>", RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveBlockItems_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var data = new
            {
                blockItemIds = new[] {
        "<String>"
    },
            };

            Response response = await client.RemoveBlockItemsAsync("<blocklistName>", RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RemoveBlockItems_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var removeBlockItemsOptions = new RemoveBlockItemsOptions(new string[]
            {
    "<null>"
            });
            var result = await client.RemoveBlockItemsAsync("<blocklistName>", removeBlockItemsOptions);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklistItem()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = client.GetTextBlocklistItem("<blocklistName>", "<blockItemId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("text").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklistItem_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = client.GetTextBlocklistItem("<blocklistName>", "<blockItemId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("text").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklistItem_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = await client.GetTextBlocklistItemAsync("<blocklistName>", "<blockItemId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("text").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklistItem_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            Response response = await client.GetTextBlocklistItemAsync("<blocklistName>", "<blockItemId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("blockItemId").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("text").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklistItem_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            var result = await client.GetTextBlocklistItemAsync("<blocklistName>", "<blockItemId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklists()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            foreach (var item in client.GetTextBlocklists(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blocklistName").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklists_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            foreach (var item in client.GetTextBlocklists(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blocklistName").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklists_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            await foreach (var item in client.GetTextBlocklistsAsync(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blocklistName").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklists_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            await foreach (var item in client.GetTextBlocklistsAsync(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blocklistName").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklists_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            await foreach (var item in client.GetTextBlocklistsAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklistItems()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            foreach (var item in client.GetTextBlocklistItems("<blocklistName>", 1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blockItemId").ToString());
                Console.WriteLine(result.GetProperty("text").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetTextBlocklistItems_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            foreach (var item in client.GetTextBlocklistItems("<blocklistName>", 1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blockItemId").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("text").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklistItems_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            await foreach (var item in client.GetTextBlocklistItemsAsync("<blocklistName>", 1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blockItemId").ToString());
                Console.WriteLine(result.GetProperty("text").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklistItems_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            await foreach (var item in client.GetTextBlocklistItemsAsync("<blocklistName>", 1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("blockItemId").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("text").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetTextBlocklistItems_Convenience_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ContentSafetyClient(endpoint, credential);

            await foreach (var item in client.GetTextBlocklistItemsAsync("<blocklistName>", 1234, 1234, 1234))
            {
            }
        }
    }
}
