namespace RESTDemo.MAUI.Services
{
    public interface ISecureStorageService
    {
        Task Save(string key, string value);
        Task<string> Get(string key);
    }
}
