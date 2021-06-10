using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        { }

        public Archmage(string title, string origin) : base(title, origin)
        { }

        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }


        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title);
        }

    }
}
