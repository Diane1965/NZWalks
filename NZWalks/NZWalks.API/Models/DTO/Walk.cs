using NZWalks.API.Models.Domain;

namespace NZWalks.API.Models.DTO
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }

        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }


        // Navigation Properties(Walk has a 1:1 Relationshipt to Region and WalkDifficulty)
        public Region Region { get; set; }

        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
