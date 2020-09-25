using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plants.Models
{
    public class PlantsIndexModel
    {
        public List<PlantModel> PlantsList { get; set; }

        public PlantsIndexModel()
        {
            PlantsList = Helpers.DefaultPlants.GetDefaultPlantList();
        }
    }
}
