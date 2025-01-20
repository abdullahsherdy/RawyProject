using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class User:BaseUser
    {
        public string SubscriptionStatus { get; set; } = "free"; 

        public ICollection<Playlist> Playlists { get; set; }= new HashSet<Playlist>();
        public ICollection<Review> Reviews { get; set; }=new HashSet<Review>(); 
        public ICollection<Favorite> Favorites { get; set; }
        //public ICollection<Subscription> Subscriptions { get; set; }
    }
}
