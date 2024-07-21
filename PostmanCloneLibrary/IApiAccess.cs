
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
        Task<string> PostApiAsync(string url, string body, bool formatOutput = true, HttpAction action = HttpAction.POST);
        Task<string> PutApiAsync(string url, string body, bool formatOutput = true, HttpAction action = HttpAction.PUT);
        Task<string> PatchApiAsync(string url, string body, bool formatOutput = true, HttpAction action = HttpAction.PATCH);
        Task<string> DeleteApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.DELETE);
        bool IsValidUrl(string url);
    }
}