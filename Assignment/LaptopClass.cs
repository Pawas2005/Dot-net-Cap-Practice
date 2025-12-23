using System;

using Computer;

namespace Laptop
{
    public class LaptopClass : ComputerClass
    {
        public int DisplaySize{ get; set; }
        public int BatteryVolt{ get; set; }
        public double LaptopPriceCalculation()
        {
            double ProcessorCost = 0;

            if(Processor == "i3")
            {
                ProcessorCost = 2500;
            }
            else if(Processor == "i5")
            {
                ProcessorCost = 5000;
            }
            else if(Processor == "i7")
            {
                ProcessorCost = 6500;
            }

            return ProcessorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (BatteryVolt * 20) + (DisplaySize * 250);
        }
    }
}