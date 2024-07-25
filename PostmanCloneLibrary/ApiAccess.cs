using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;


namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient client = new();

        public async Task<string> CallApiAsync(string url, HttpAction action = HttpAction.GET, string body = "", bool formatOutput = true)
        {
            HttpResponseMessage response;

            switch (action)
            {
                case HttpAction.POST:
                    response = await client.PostAsync(url, CreateHttpContent(body));
                    break;
                case HttpAction.PUT:
                    response = await client.PutAsync(url, CreateHttpContent(body));
                    break;
                case HttpAction.PATCH:
                    response = await client.PatchAsync(url, CreateHttpContent(body));
                    break;
                case HttpAction.DELETE:
                    response = await client.DeleteAsync(url);
                    break;
                case HttpAction.GET:
                default:
                    response = await client.GetAsync(url);
                    break;
            }

            return await ProcessResponse(response, formatOutput);
        }

        private static HttpContent CreateHttpContent(string requestBody)
        {
            // Create StringContent with the specified content, encoding, and media type
            HttpContent httpContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

            return httpContent;
        }


        private static async Task<string> ProcessResponse(HttpResponseMessage response, bool formatOutput)
        {
            // Check if the HTTP response was successful
            if (response.IsSuccessStatusCode)
            {
                // Serialize the response(HTTP) to a string
                var json = await response.Content.ReadAsStringAsync();

                if (formatOutput)
                {
                    //Prase string to json element
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    // Formatting JSON string
                    json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
                }

                return json;
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }

        // Validate URL
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
