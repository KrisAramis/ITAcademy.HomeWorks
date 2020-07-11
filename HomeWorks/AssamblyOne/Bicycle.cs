using System;
using System.Collections.Generic;
using System.Text;

namespace AssamblyOne
{
    internal class BicycleInternal
    {
        public void Getspeed()
        { }
    }

    public class BicyclePublic
    {
        private void Getspeed()
        { }
    }

    public class BicyclePublicInternalMethod
    {
        internal void Getspeed()
        { }
    }
}
