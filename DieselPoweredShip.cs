using System;

namespace ObjectModel
{
    public class DieselPoweredShip : Ship
    {
        public decimal EnginePower { get; set; }
        public decimal Range { get; set; }

        public override void NavigateOnSurface()
        {
        }
    }
}