using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP
{
    public class Crop
    {
        public string name;
        public string currentStage;
        public Crop (string name)
        {
            this.name = name;
            currentStage = "Seed";
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name:{name} {currentStage}");
        }
        public void Water()
        {
            switch (currentStage)
            {
                case "Seed":
                    currentStage = "Sprout";
                    break;
                case "Sprout":
                    currentStage = "Plant";
                    break;
                case "Plant":
                    currentStage = "CanBeHarvested";
                    break;
                case "CanBeHarvested":
                    currentStage = "Harvested";
                    break;
            }
        }
        public void Harvest()
        {
            if (currentStage == "CanBeHarvested")
            {
                currentStage = "Harvested";
            }
            else
            {
                Console.WriteLine("Cannot harvest at the current stage");
            }
        }
    }
}
