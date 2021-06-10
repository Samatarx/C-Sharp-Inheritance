using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {

        }

        public Mage(string title, string origin) : base(title, origin)
        {

        }

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }

    }
}
