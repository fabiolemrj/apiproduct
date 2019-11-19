using System.ComponentModel.DataAnnotations;

namespace musicmanager.Models
{
    public class MusicAuthor
    {

  
        public int MusicId { get; set; }
        public Music Music { get;  set; }
  
        public int AuthorId { get;  set; }
        public Author Author { get; set; }
    }
}