using FMBot.Domain.Models;

namespace FMBot.Persistence.Domain.Models
{
    public class FeaturedLog
    {
        public int FeaturedLogId { get; set; }

        public int? UserId { get; set; }

        public BotType BotType { get; set; }

        public string Description { get; set; }

        public string TrackName { get; set; }

        public string ArtistName { get; set; }

        public string AlbumName { get; set; }

        public User User { get; set; }
    }
}
