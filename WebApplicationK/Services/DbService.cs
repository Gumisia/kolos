using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationK.Models;
using WebApplicationK.Models.DTO;

namespace WebApplicationK.Services
{
    public class DbService : IDbService
    {
        private readonly masterContext _dbContext;

        public DbService(masterContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<SomeSortOfMusician>> GetMusicians(int id)
        {
            return await _dbContext.Musicans
                .Select(e => new SomeSortOfMusician
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Nickname = e.Nickname,
                    MusicianTracks = e.MusicanTracks.Select(e=> new SomeSortOfTrack { TrackName = e.IdTrackNavigation.TrackName, Duration = e.IdTrackNavigation.Duration}).ToList()
                }).OrderBy(e => e.LastName).ToListAsync();
        }
    }
}
