using Taht.Core;

namespace Taht.Common.Services
{
    public class EnumsService : IEnumsService
    {
        public Task<IEnumerable<KeyValuePair<int, string>>> GetRolesAsync() => Task.FromResult(GetValues<Role>());

        public Task<IEnumerable<KeyValuePair<int, string>>> GetServiceTypes() => Task.FromResult(GetValues<ServiceType>());


        private IEnumerable<KeyValuePair<int, string>> GetValues<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<int>()
                       .Select(e => new KeyValuePair<int, string>(e, Enum.GetName(typeof(T), e)!));
        }
    }
}
