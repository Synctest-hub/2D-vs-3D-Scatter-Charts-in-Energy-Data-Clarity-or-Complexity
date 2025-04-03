namespace _2DScatterChart
{
    using System.Collections.ObjectModel;

    public class EnergyViewModel
    {
        public ObservableCollection<Model> EnergyData { get; set; }

        public EnergyViewModel()
        {
            EnergyData = new ObservableCollection<Model>
            {
                new Model { EnergyConsumption = 120, MonthlyCost = 200 },
                new Model { EnergyConsumption = 900, MonthlyCost = 800 },
                new Model { EnergyConsumption = 150, MonthlyCost = 250 },
                new Model { EnergyConsumption = 850, MonthlyCost = 750 },
                new Model { EnergyConsumption = 200, MonthlyCost = 300 },
                new Model { EnergyConsumption = 800, MonthlyCost = 700 },
                new Model { EnergyConsumption = 250, MonthlyCost = 400 },
                new Model { EnergyConsumption = 750, MonthlyCost = 650 },
                new Model { EnergyConsumption = 300, MonthlyCost = 500 },
                new Model { EnergyConsumption = 700, MonthlyCost = 600 },
                new Model { EnergyConsumption = 350, MonthlyCost = 200 },
                new Model { EnergyConsumption = 650, MonthlyCost = 900 },
                new Model { EnergyConsumption = 400, MonthlyCost = 450 },
                new Model { EnergyConsumption = 600, MonthlyCost = 550 },
                new Model { EnergyConsumption = 450, MonthlyCost = 230 },
                new Model { EnergyConsumption = 550, MonthlyCost = 750 },
                new Model { EnergyConsumption = 500, MonthlyCost = 370 },
                new Model { EnergyConsumption = 500, MonthlyCost = 630 },
                new Model { EnergyConsumption = 550, MonthlyCost = 260 },
                new Model { EnergyConsumption = 450, MonthlyCost = 740 },
                new Model { EnergyConsumption = 600, MonthlyCost = 340 },
                new Model { EnergyConsumption = 400, MonthlyCost = 710 },
                new Model { EnergyConsumption = 650, MonthlyCost = 300 },
                new Model { EnergyConsumption = 350, MonthlyCost = 670 },
                new Model { EnergyConsumption = 700, MonthlyCost = 380 },
                new Model { EnergyConsumption = 300, MonthlyCost = 690 },
                new Model { EnergyConsumption = 750, MonthlyCost = 420 },
                new Model { EnergyConsumption = 250, MonthlyCost = 660 },
                new Model { EnergyConsumption = 800, MonthlyCost = 360 },
                new Model { EnergyConsumption = 200, MonthlyCost = 680 },
                new Model { EnergyConsumption = 850, MonthlyCost = 450 },
                new Model { EnergyConsumption = 150, MonthlyCost = 620 },
                new Model { EnergyConsumption = 900, MonthlyCost = 310 },
                new Model { EnergyConsumption = 147, MonthlyCost = 700 },
                new Model { EnergyConsumption = 950, MonthlyCost = 480 },
                new Model { EnergyConsumption = 340, MonthlyCost = 640 },
                new Model { EnergyConsumption = 990, MonthlyCost = 330 },
                new Model { EnergyConsumption = 460, MonthlyCost = 710 },
                new Model { EnergyConsumption = 880, MonthlyCost = 470 },
                new Model { EnergyConsumption = 130, MonthlyCost = 630 },
                new Model { EnergyConsumption = 770, MonthlyCost = 350 },
                new Model { EnergyConsumption = 190, MonthlyCost = 690 },
                new Model { EnergyConsumption = 720, MonthlyCost = 500 },
                new Model { EnergyConsumption = 260, MonthlyCost = 620 },
                new Model { EnergyConsumption = 660, MonthlyCost = 330 },
                new Model { EnergyConsumption = 310, MonthlyCost = 670 },
                new Model { EnergyConsumption = 620, MonthlyCost = 510 },
                new Model { EnergyConsumption = 370, MonthlyCost = 600 },
                new Model { EnergyConsumption = 570, MonthlyCost = 340 },
                new Model { EnergyConsumption = 420, MonthlyCost = 650 },
                new Model { EnergyConsumption = 520, MonthlyCost = 520 },
                new Model { EnergyConsumption = 470, MonthlyCost = 590 },
                new Model { EnergyConsumption = 470, MonthlyCost = 360 },
                new Model { EnergyConsumption = 520, MonthlyCost = 630 },
                new Model { EnergyConsumption = 370, MonthlyCost = 530 },
            };
        }
    }
}