namespace WebAPIApplicationProject.Models
{
    public class PlantFood
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string[] Provenance { get; set; } = [];
        public string Season { get; set; }
        public bool IsSeasonal { get; set; }
        public bool IsVegetable { get; set; }
    }
}
