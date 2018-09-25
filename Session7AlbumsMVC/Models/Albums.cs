using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Session7AlbumsMVC.Models
{
    public class Album
    {
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public string CoverArt { get; set; }
        public string YoutubeLink { get; set; }
    }

    public class AlbumDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}