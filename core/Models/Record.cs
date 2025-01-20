using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class Record : BaseClass
    {
        [Required]
        public string AudioFile { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.UtcNow;

        [ForeignKey("TellerId")]
        public int TellerId { get; set; }
        public ICollection<Playlist> playlists { get; set; }= new HashSet<Playlist>();
        public Teller Teller { get; set; }


    }
}
