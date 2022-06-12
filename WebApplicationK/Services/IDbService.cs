using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationK.Models.DTO;

namespace WebApplicationK.Services
{
    public interface IDbService
    {
        Task<IEnumerable<SomeSortOfMusician>> GetMusicians(int id);
    }
}
