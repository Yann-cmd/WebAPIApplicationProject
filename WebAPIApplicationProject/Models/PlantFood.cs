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
        public string? ImageUrl { get; set; } = null;
    }

    // pour avoir de la donnée par défaut pour pouvoir tester et avoir un environnement plus réaliste
    public class PlantFoodConstants
    {
        public static List<PlantFood> DefaultPlantFood = new List<PlantFood>()
    {
        new PlantFood { Id = 1, Name = "Pomme", ScientificName = "Malus domestica", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = "https://cdn.pixabay.com/photo/2022/05/18/15/44/apple-7205616_1280.jpg" },
        new PlantFood { Id = 2, Name = "Poire", ScientificName = "Pyrus communis", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = "https://cdn.pixabay.com/photo/2019/09/15/18/32/fruit-4479075_1280.jpg" },
        new PlantFood { Id = 3, Name = "Banane", ScientificName = "Musa spp.", Provenance = new[] { "Asie", "Afrique" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = false, ImageUrl = "https://cdn.pixabay.com/photo/2015/11/05/23/08/banana-1025109_1280.jpg" },
        new PlantFood { Id = 4, Name = "Orange", ScientificName = "Citrus × sinensis", Provenance = new[] { "Méditerranée" }, Season = "Hiver", IsSeasonal = true, IsVegetable = false, ImageUrl = "https://cdn.pixabay.com/photo/2017/04/04/17/42/fruits-2202426_1280.jpg" },
        new PlantFood { Id = 5, Name = "Citron", ScientificName = "Citrus limon", Provenance = new[] { "Méditerranée" }, Season = "Hiver", IsSeasonal = true, IsVegetable = false, ImageUrl = "https://cdn.pixabay.com/photo/2017/06/16/14/35/lemon-2409365_1280.jpg" },
        new PlantFood { Id = 6, Name = "Tomate", ScientificName = "Solanum lycopersicum", Provenance = new[] { "Amérique du Sud" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = "https://cdn.pixabay.com/photo/2019/07/11/10/14/cherry-tomato-4330441_960_720.jpg" },
        new PlantFood { Id = 7, Name = "Carotte", ScientificName = "Daucus carota", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = true, ImageUrl = "https://cdn.pixabay.com/photo/2020/06/23/23/40/carrot-5334163_960_720.jpg" },
        new PlantFood { Id = 8, Name = "Courgette", ScientificName = "Cucurbita pepo", Provenance = new[] { "Amérique Centrale" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = "https://cdn.pixabay.com/photo/2015/09/07/19/31/still-life-928953_1280.jpg" },
        new PlantFood { Id = 9, Name = "Aubergine", ScientificName = "Solanum melongena", Provenance = new[] { "Asie" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 10, Name = "Poivron", ScientificName = "Capsicum annuum", Provenance = new[] { "Amérique du Sud" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 11, Name = "Concombre", ScientificName = "Cucumis sativus", Provenance = new[] { "Asie" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 12, Name = "Radis", ScientificName = "Raphanus sativus", Provenance = new[] { "Europe" }, Season = "Printemps", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 13, Name = "Betterave", ScientificName = "Beta vulgaris", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 14, Name = "Laitue", ScientificName = "Lactuca sativa", Provenance = new[] { "Europe" }, Season = "Printemps", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 15, Name = "Chou-fleur", ScientificName = "Brassica oleracea", Provenance = new[] { "Europe" }, Season = "Hiver", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 16, Name = "Brocoli", ScientificName = "Brassica oleracea", Provenance = new[] { "Europe" }, Season = "Hiver", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 17, Name = "Épinard", ScientificName = "Spinacia oleracea", Provenance = new[] { "Asie" }, Season = "Printemps", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 18, Name = "Chou rouge", ScientificName = "Brassica oleracea", Provenance = new[] { "Europe" }, Season = "Hiver", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 19, Name = "Chou vert", ScientificName = "Brassica oleracea", Provenance = new[] { "Europe" }, Season = "Hiver", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 20, Name = "Navet", ScientificName = "Brassica rapa", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = true, ImageUrl = null },

        // Continuation jusqu'à 60 :

        new PlantFood { Id = 21, Name = "Fraise", ScientificName = "Fragaria × ananassa", Provenance = new[] { "Europe" }, Season = "Printemps", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 22, Name = "Framboise", ScientificName = "Rubus idaeus", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 23, Name = "Mûre", ScientificName = "Rubus fruticosus", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 24, Name = "Cerise", ScientificName = "Prunus avium", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 25, Name = "Prune", ScientificName = "Prunus domestica", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 26, Name = "Abricot", ScientificName = "Prunus armeniaca", Provenance = new[] { "Asie", "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 27, Name = "Pêche", ScientificName = "Prunus persica", Provenance = new[] { "Asie" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 28, Name = "Melon", ScientificName = "Cucumis melo", Provenance = new[] { "Afrique" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 29, Name = "Pastèque", ScientificName = "Citrullus lanatus", Provenance = new[] { "Afrique" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 30, Name = "Mangue", ScientificName = "Mangifera indica", Provenance = new[] { "Asie" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },

        // 31 à 60 :  

        new PlantFood { Id = 31, Name = "Avocat", ScientificName = "Persea americana", Provenance = new[] { "Amérique Centrale" }, Season = "Hiver", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 32, Name = "Noix de coco", ScientificName = "Cocos nucifera", Provenance = new[] { "Asie" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 33, Name = "Ananas", ScientificName = "Ananas comosus", Provenance = new[] { "Amérique du Sud" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 34, Name = "Kiwi", ScientificName = "Actinidia deliciosa", Provenance = new[] { "Asie" }, Season = "Hiver", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 35, Name = "Papaye", ScientificName = "Carica papaya", Provenance = new[] { "Amérique Centrale" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 36, Name = "Figue", ScientificName = "Ficus carica", Provenance = new[] { "Méditerranée" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 37, Name = "Grenade", ScientificName = "Punica granatum", Provenance = new[] { "Méditerranée" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 38, Name = "Patate douce", ScientificName = "Ipomoea batatas", Provenance = new[] { "Amérique du Sud" }, Season = "Automne", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 39, Name = "Pomme de terre", ScientificName = "Solanum tuberosum", Provenance = new[] { "Amérique du Sud" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 40, Name = "Oignon", ScientificName = "Allium cepa", Provenance = new[] { "Asie" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },

        new PlantFood { Id = 41, Name = "Ail", ScientificName = "Allium sativum", Provenance = new[] { "Asie" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 42, Name = "Poireau", ScientificName = "Allium ampeloprasum", Provenance = new[] { "Europe" }, Season = "Hiver", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 43, Name = "Céleri", ScientificName = "Apium graveolens", Provenance = new[] { "Europe" }, Season = "Hiver", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 44, Name = "Fenouil", ScientificName = "Foeniculum vulgare", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 45, Name = "Haricot vert", ScientificName = "Phaseolus vulgaris", Provenance = new[] { "Amérique du Sud" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 46, Name = "Petit pois", ScientificName = "Pisum sativum", Provenance = new[] { "Europe" }, Season = "Printemps", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 47, Name = "Maïs", ScientificName = "Zea mays", Provenance = new[] { "Amérique Centrale" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 48, Name = "Pois chiche", ScientificName = "Cicer arietinum", Provenance = new[] { "Moyen-Orient" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 49, Name = "Lentille", ScientificName = "Lens culinaris", Provenance = new[] { "Moyen-Orient" }, Season = "Automne", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 50, Name = "Riz", ScientificName = "Oryza sativa", Provenance = new[] { "Asie" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },

        new PlantFood { Id = 51, Name = "Blé", ScientificName = "Triticum aestivum", Provenance = new[] { "Asie" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 52, Name = "Seigle", ScientificName = "Secale cereale", Provenance = new[] { "Europe" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 53, Name = "Orge", ScientificName = "Hordeum vulgare", Provenance = new[] { "Europe" }, Season = "Toute l'année", IsSeasonal = false, IsVegetable = true, ImageUrl = null },
        new PlantFood { Id = 54, Name = "Noisette", ScientificName = "Corylus avellana", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 55, Name = "Amande", ScientificName = "Prunus dulcis", Provenance = new[] { "Méditerranée" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 56, Name = "Noix", ScientificName = "Juglans regia", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 57, Name = "Châtaigne", ScientificName = "Castanea sativa", Provenance = new[] { "Europe" }, Season = "Automne", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 58, Name = "Cassis", ScientificName = "Ribes nigrum", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 59, Name = "Groseille", ScientificName = "Ribes rubrum", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = false, ImageUrl = null },
        new PlantFood { Id = 60, Name = "Menthe", ScientificName = "Mentha spicata", Provenance = new[] { "Europe" }, Season = "Été", IsSeasonal = true, IsVegetable = true, ImageUrl = null },
    };
    }
}
