using System;

namespace ObjectModel
{
    public class NuclearPoweredShip : Ship
    {
        public decimal EnginePower { get; set; }
        public string ReactorModel { get; set; }

        public override void NavigateOnSurface()
        {
        
        }
    }
}