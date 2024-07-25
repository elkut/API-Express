
namespace PostmanCloneLibrary
{
    // Interface for API Access
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, HttpAction action = HttpAction.GET, string body = "", bool formatOutput = true);
        bool IsValidUrl(string url);
    }
}