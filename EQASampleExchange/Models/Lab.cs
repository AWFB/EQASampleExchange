namespace EQASampleExchange.Models
{
    public class Lab
    {
        public int LabId { get; set; }
        public string Name { get; set; } = string.Empty; 

        public int UserId { get; set; }
        public IEnumerable<EqaScheme> EqaSchemes { get; set; }
    }
}
