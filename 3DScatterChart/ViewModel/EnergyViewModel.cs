namespace _3DScatterChart
{
    using System.Collections.ObjectModel;

    public class EnergyViewModel
    {
        public ObservableCollection<Model> EnergyData { get; set; }

        public EnergyViewModel()
        {
            EnergyData = new ObservableCollection<Model>
            {
                new Model { EnergyConsumption = 120, MonthlyCost = 200, Temperature = 150 },
                new Model { EnergyConsumption = 900, MonthlyCost = 800, Temperature = 950 },
                new Model { EnergyConsumption = 150, MonthlyCost = 250, Temperature = 180 },
                new Model { EnergyConsumption = 850, MonthlyCost = 750, Temperature = 900 },
                new Model { EnergyConsumption = 200, MonthlyCost = 300, Temperature = 220 },
                new Model { EnergyConsumption = 800, MonthlyCost = 700, Temperature = 850 },
                new Model { EnergyConsumption = 250, MonthlyCost = 400, Temperature = 260 },
                new Model { EnergyConsumption = 750, MonthlyCost = 650, Temperature = 800 },
                new Model { EnergyConsumption = 300, MonthlyCost = 500, Temperature = 310 },
                new Model { EnergyConsumption = 700, MonthlyCost = 600, Temperature = 750 },
                new Model { EnergyConsumption = 350, MonthlyCost = 200, Temperature = 160 },
                new Model { EnergyConsumption = 650, MonthlyCost = 900, Temperature = 980 },
                new Model { EnergyConsumption = 400, MonthlyCost = 450, Temperature = 370 },
                new Model { EnergyConsumption = 600, MonthlyCost = 550, Temperature = 720 },
                new Model { EnergyConsumption = 450, MonthlyCost = 230, Temperature = 280 },
                new Model { EnergyConsumption = 550, MonthlyCost = 750, Temperature = 850 },
                new Model { EnergyConsumption = 500, MonthlyCost = 370, Temperature = 190 },
                new Model { EnergyConsumption = 500, MonthlyCost = 630, Temperature = 920 },
                new Model { EnergyConsumption = 550, MonthlyCost = 260, Temperature = 320 },
                new Model { EnergyConsumption = 450, MonthlyCost = 740, Temperature = 870 },
                new Model { EnergyConsumption = 600, MonthlyCost = 340, Temperature = 210 },
                new Model { EnergyConsumption = 400, MonthlyCost = 710, Temperature = 880 },
                new Model { EnergyConsumption = 650, MonthlyCost = 300, Temperature = 330 },
                new Model { EnergyConsumption = 350, MonthlyCost = 670, Temperature = 850 },
                new Model { EnergyConsumption = 700, MonthlyCost = 380, Temperature = 240 },
                new Model { EnergyConsumption = 300, MonthlyCost = 690, Temperature = 870 },
                new Model { EnergyConsumption = 750, MonthlyCost = 420, Temperature = 350 },
                new Model { EnergyConsumption = 250, MonthlyCost = 660, Temperature = 900 },
                new Model { EnergyConsumption = 800, MonthlyCost = 360, Temperature = 280 },
                new Model { EnergyConsumption = 200, MonthlyCost = 680, Temperature = 910 },
                new Model { EnergyConsumption = 850, MonthlyCost = 450, Temperature = 390 },
                new Model { EnergyConsumption = 150, MonthlyCost = 620, Temperature = 940 },
                new Model { EnergyConsumption = 900, MonthlyCost = 310, Temperature = 250 },
                new Model { EnergyConsumption = 147, MonthlyCost = 700, Temperature = 950 },
                new Model { EnergyConsumption = 950, MonthlyCost = 480, Temperature = 400 },
                new Model { EnergyConsumption = 340, MonthlyCost = 640, Temperature = 970 },
                new Model { EnergyConsumption = 990, MonthlyCost = 330, Temperature = 290 },
                new Model { EnergyConsumption = 460, MonthlyCost = 710, Temperature = 980 },
                new Model { EnergyConsumption = 880, MonthlyCost = 470, Temperature = 420 },
                new Model { EnergyConsumption = 130, MonthlyCost = 630, Temperature = 960 },
                new Model { EnergyConsumption = 770, MonthlyCost = 350, Temperature = 270 },
                new Model { EnergyConsumption = 190, MonthlyCost = 690, Temperature = 990 },
                new Model { EnergyConsumption = 720, MonthlyCost = 500, Temperature = 440 },
                new Model { EnergyConsumption = 260, MonthlyCost = 620, Temperature = 980 },
                new Model { EnergyConsumption = 660, MonthlyCost = 330, Temperature = 310 },
                new Model { EnergyConsumption = 310, MonthlyCost = 670, Temperature = 990 },
                new Model { EnergyConsumption = 620, MonthlyCost = 510, Temperature = 460 },
                new Model { EnergyConsumption = 370, MonthlyCost = 600, Temperature = 980 },
                new Model { EnergyConsumption = 570, MonthlyCost = 340, Temperature = 330 },
                new Model { EnergyConsumption = 420, MonthlyCost = 650, Temperature = 990 },
                new Model { EnergyConsumption = 520, MonthlyCost = 520, Temperature = 480 },
                new Model { EnergyConsumption = 470, MonthlyCost = 590, Temperature = 980 },
                new Model { EnergyConsumption = 470, MonthlyCost = 360, Temperature = 350 },
                new Model { EnergyConsumption = 520, MonthlyCost = 630, Temperature = 990 },
                new Model { EnergyConsumption = 370, MonthlyCost = 530, Temperature = 500 },
            };
        }
    }
}