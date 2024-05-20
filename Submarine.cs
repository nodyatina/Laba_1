using System;

namespace ObjectModel
{
    public class Submarine : Ship
    {
        public decimal SubmergedSpeed { get; set; }
        public TimeSpan EmergencySurfacingTime { get; set; }

        public override void NavigateOnSurface()
        {
        }
        
        public void NavigateSubmerged()
        {
        }
    }
}