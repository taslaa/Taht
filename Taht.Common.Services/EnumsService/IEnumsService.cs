namespace Taht.Common.Services
{
    public interface IEnumsService
    {
        Task<IEnumerable<KeyValuePair<int, string>>> GetRolesAsync();
        Task<IEnumerable<KeyValuePair<int, string>>> GetServiceTypes();
    }
}