using System.ComponentModel.DataAnnotations;

namespace E2E.CURD.Operations.Models.Domain
{
    public class Walk
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultlyId { get; set; }

        //Navigation properties
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficuilty { get; set; }

    }
}
