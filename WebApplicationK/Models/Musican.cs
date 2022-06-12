using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationK.Models
{
    public partial class Musican
    {
        public Musican()
        {
            MusicanTracks = new HashSet<MusicanTrack>();
        }

        public int IdMusican { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public virtual ICollection<MusicanTrack> MusicanTracks { get; set; }
    }
}
