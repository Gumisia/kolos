using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationK.Models
{
    public partial class MusicanTrack
    {
        public int IdTrack { get; set; }
        public int IdMusican { get; set; }

        public virtual Musican IdMusicanNavigation { get; set; }
        public virtual Track IdTrackNavigation { get; set; }
    }
}
