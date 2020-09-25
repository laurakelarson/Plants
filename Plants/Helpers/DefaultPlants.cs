using Plants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plants.Helpers
{
    public static class DefaultPlants
    {
        public static List<PlantModel> GetDefaultPlantList()
        {
            List<PlantModel> plants = new List<PlantModel>();
            plants.Add(Monstera());
            plants.Add(Caladium());
            plants.Add(Ficus());
            plants.Add(FicusTineike());
            plants.Add(Hoya());
            plants.Add(Jade());
            plants.Add(Calathea());
            plants.Add(Pilea());
            plants.Add(Snake());
            plants.Add(Spider());
            plants.Add(Rhaphidophora());
            plants.Add(Peperomia());

            return plants;
        }

        public static PlantModel Monstera()
        {
            return new PlantModel
            {
                ScientificName = "Monstera deliciosa Liebm.",
                CommonName = "Monstera",
                Family = "Araceae",
                Category = Models.Enums.CategoryEnum.Monocot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "monstera2.jpg"
            };
        }

        public static PlantModel Caladium()
        {
            return new PlantModel
            {
                ScientificName = "Caladium bicolor (Aiton) Vent.",
                CommonName = "Heart of Jesus",
                Family = "Araceae",
                Category = Models.Enums.CategoryEnum.Monocot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "caladium.jpg"
            };
        }

        public static PlantModel Ficus()
        {
            return new PlantModel
            {
                ScientificName = "Ficus Elastica",
                CommonName = "Rubber Tree",
                Family = "Moraceae",
                Category = Models.Enums.CategoryEnum.Dicot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "ficus.jpg"
            };
        }

        public static PlantModel FicusTineike()
        {
            return new PlantModel
            {
                ScientificName = "Ficus Elastica Tineke",
                CommonName = "Variegated Rubber Tree",
                Family = "Moraceae",
                Category = Models.Enums.CategoryEnum.Dicot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "tineike.jpg"
            };
        }

        public static PlantModel Hoya()
        {
            return new PlantModel
            {
                ScientificName = "Hoya carnosa (L. f.) R. Br.",
                CommonName = "Crimson Queen",
                Family = "Asclepiadaceae",
                Category = Models.Enums.CategoryEnum.Dicot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "hoya.jpg"
            };
        }

        public static PlantModel Jade()
        {
            return new PlantModel
            {
                ScientificName = "Crassula ovata",
                CommonName = "Jade plant",
                Family = "Crassulaceae",
                Category = Models.Enums.CategoryEnum.Dicot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "jade.jpg"
            };
        }

        public static PlantModel Calathea()
        {
            return new PlantModel
            {
                ScientificName = "Calathea orbifolia",
                CommonName = "Prayer plant",
                Family = "Marantaceae",
                Category = Models.Enums.CategoryEnum.Monocot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "orbifolia.jpg"
            };
        }

        public static PlantModel Pilea()
        {
            return new PlantModel
            {
                ScientificName = "Pilea peperomioides",
                CommonName = "Chinese Money Plant",
                Family = "Urticaceae",
                Category = Models.Enums.CategoryEnum.Dicot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "pilea.jpg"
            };
        }

        public static PlantModel Snake()
        {
            return new PlantModel
            {
                ScientificName = "Sansevieria trifasciata hort. ex Prain",
                CommonName = "Snake plant",
                Family = "Agavaceae",
                Category = Models.Enums.CategoryEnum.Monocot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "snake.jpg"
            };
        }

        public static PlantModel Spider()
        {
            return new PlantModel
            {
                ScientificName = "Chlorophytum comosum",
                CommonName = "Bonnie spider plant",
                Family = "Liliaceae",
                Category = Models.Enums.CategoryEnum.Monocot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "spider.jpg"
            };
        }

        public static PlantModel Rhaphidophora()
        {
            return new PlantModel
            {
                ScientificName = "Rhaphidophora tetrasperma",
                CommonName = "Mini Monstera",
                Family = "Araceae",
                Category = Models.Enums.CategoryEnum.Monocot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "tetrasperma.jpg"
            };
        }

        public static PlantModel Peperomia()
        {
            return new PlantModel
            {
                ScientificName = "Peperomia argyreia",
                CommonName = "Watermelon Peperomia",
                Family = "Piperaceae",
                Category = Models.Enums.CategoryEnum.Dicot,
                Duration = Models.Enums.DurationEnum.Perennial,
                ImageURI = "watermelon_peperomia.jpg"
            };
        }
    }
}
