using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public int AlbumID { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}