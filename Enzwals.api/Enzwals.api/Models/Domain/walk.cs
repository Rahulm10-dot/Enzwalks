namespace Enzwals.api.Models.Domain
{
    public class walk
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public double Length { get; set; }
        public Guid regionid { get; set; }

        public Guid Walkdifficultyid { get; set; }
        public Region r { get; set; }      

        public wALK_difficulty d { get; set; }

    }
}
