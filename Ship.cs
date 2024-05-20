using System;

namespace ObjectModel
{
    public abstract class Ship : ISurfaceNavigatable
    {
        public decimal SurfaceSpeed { get; protected set; }
        public int Crew { get; protected set; }

        public abstract void NavigateOnSurface();
    }
}