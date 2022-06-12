using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationK.Models
{
    public partial class Track
    {
        public Track()
        {
            MusicanTracks = new HashSet<MusicanTrack>();
        }

        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public double Duration { get; set; }
        public int IdMusicAlbum { get; set; }

        public virtual Album IdMusicAlbumNavigation { get; set; }
        public virtual ICollection<MusicanTrack> MusicanTracks { get; set; }
    }
}
