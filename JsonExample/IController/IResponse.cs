using System.Collections.Generic;
using System.Threading.Tasks;

namespace JsonExample.IController
{
    public interface IResponse
    {
        List<T> ParseJSON<T>();
        Task<List<T>> ParseJSONAsync<T>();
    }
}
