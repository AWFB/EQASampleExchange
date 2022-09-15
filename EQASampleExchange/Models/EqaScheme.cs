namespace EQASampleExchange.Models
{
    public class EqaScheme
    {
        public int EqaSchemeId { get; set; }
        public string EqaSchemeName { get; set; } = string.Empty;

        public IEnumerable<Lab> Labs { get; set; }
        public IEnumerable<Distribution> Distributions { get; set; }
    }
}
