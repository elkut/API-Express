using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient client = new();

        // GET
        public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET)
        {
            var response = await client.GetAsync(url);

            // Check if the HTTP response was successful
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (formatOutput)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
                }

                return json;
            }
            else
            {

                return $"Error: {response.StatusCode}";
            }
        }

        //POST
        public async Task<string> PostApiAsync(string url, string body ,bool formatOutput = true, HttpAction action = HttpAction.POST)
        {
            var content = new StringContent(  body, 
                                              Encoding.UTF8, 
                                              "application/json"
                                            );

            var response = await client.PostAsync(url, content);

            // Check if the HTTP response was successful
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (formatOutput)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
                }

                return json;
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
           
        }

        //public async Task<string> PostApiAsync(string url, string body ,bool formatOutput = true, HttpAction action = HttpAction.POST)
        //{
        //    var content = new StringContent(
        //                                      body, 
        //                                      System.Text.Encoding.UTF8, 
        //                                      "application/json"
        //                                    );
        //    //var jsonElement = JsonSerializer.Deserialize<JsonElement>(body);
        //    //using StringContent jsonContent = new(
        //    //    JsonSerializer.Serialize(new (jsonElement),
        //    //   Encoding.UTF8,
        //    //   "application/json");

        //    var response = await client.PostAsync(url, content);
        //    var responseString = await response.Content.ReadAsStringAsync();

        //    return responseString;
        //}

        public bool IsValidUrl(string url)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            // Regular expression
            Regex Rgx = new(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(url);

            // Another way to validate URl
            //if (string.IsNullOrEmpty(url))
            //{
            //    return false;
            //}
            //bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);
            //return output;
        }
    }
}
