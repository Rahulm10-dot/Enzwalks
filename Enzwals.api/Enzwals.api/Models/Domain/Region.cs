namespace Enzwals.api.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string code { get; set; }    
        public string name { get; set; }        
        public double area { get; set; }
         public double lat { get; set; }
        public double Long { get; set; }

        public long population { get; set; }

        public IEnumerable<walk> walks { get; set; }    
    }
}
