using FMBot.Domain.Models;

namespace FMBot.Bot.Models
{
    public class WhoKnowsObjectWithUser
    {
        public string Name { get; set; }

        public int Playcount { get; set; }

        public string LastFMUsername { get; set; }

        public string DiscordName { get; set; }

        public int UserId { get; set; }

        public PrivacyLevel? PrivacyLevel { get; set; }
    }
}
