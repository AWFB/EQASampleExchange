namespace EQASampleExchange.Models
{
    public class Distribution
    {
        public string LevelOneResult { get; set; } = string.Empty;
        public string LevelTwoResult { get; set; } = string.Empty;
        public string LevelThreeResult { get; set; } = string.Empty;
        public DateOnly DistributionDate { get; set; }
        public DateOnly ResultsDueDate { get; set; }
    }
}
