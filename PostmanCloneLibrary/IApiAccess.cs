
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
        Task<string> PostApiAsync(string url, string body, bool formatOutput = true, HttpAction action = HttpAction.POST);
        bool IsValidUrl(string url);
    }
}