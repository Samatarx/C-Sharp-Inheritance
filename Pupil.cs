using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Pupil
    {
        public string Title
        { get; private set; }

        public string Origin
        { get; private set; }

        // Constructor
        public Pupil(string title)
        {
            Title = title;
        }

        public Pupil(string title, string origin)
        {
            Origin = origin;
            Title = title;
        }

        // Methods
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }

    }
}
