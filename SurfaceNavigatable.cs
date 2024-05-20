using System;

namespace ObjectModel
{
    public interface ISurfaceNavigatable
    {
        decimal SurfaceSpeed { get; }
        void NavigateOnSurface();
    }
}
