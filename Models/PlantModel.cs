using Plants.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plants.Models
{
    public class PlantModel
    {
        public String ScientificName { get; set; }
        public String CommonName { get; set; }
        public String Family { get; set; }
        public CategoryEnum Category { get; set; }
        public DurationEnum Duration { get; set; }
        public String ImageURI { get; set; }

        public PlantModel()
        {
            // This is a change
        }
        public PlantModel(PlantModel data)
        {
            Update(data);
        }

        public bool Update(PlantModel newData)
        {
            if (newData == null)
            {
                return false;
            }

            ScientificName = newData.ScientificName;
            CommonName = newData.CommonName;
            Family = newData.Family;
            Category = newData.Category;
            Duration = newData.Duration;
            ImageURI = newData.ImageURI;

            return true;
        }
    }
}
