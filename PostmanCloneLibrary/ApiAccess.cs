using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient client = new();

        // Access API
        public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET)
        {
            var response = await client.GetAsync(url);

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
