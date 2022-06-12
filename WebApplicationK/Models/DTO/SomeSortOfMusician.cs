using System.Collections.Generic;
namespace WebApplicationK.Models.DTO
{
    public class SomeSortOfMusician
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public IEnumerable<SomeSortOfTrack> MusicianTracks { get; set; }
    }
}
