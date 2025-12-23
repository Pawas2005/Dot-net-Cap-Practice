using System;

using Computer;

namespace Desktop
{
    public class DesktopClass : ComputerClass
    {
        public int MonitorSize{ get; set;}
        public int PowerSupplyVolt{ get; set;}
        public double DesktopPriceCalculation()
        {
            double ProcessorCost = 0;

            if(Processor == "i3")
            {
                ProcessorCost = 1500;
            }
            else if(Processor == "i5")
            {
                ProcessorCost = 3000;
            }
            else if(Processor == "i7")
            {
                ProcessorCost = 4500;
            }

            return ProcessorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (PowerSupplyVolt * 20) + (MonitorSize * 250);
        }
    }
}