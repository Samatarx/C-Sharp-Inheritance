using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];
            int stormsIndex = 0;
            Storm sam = new Storm("wind", false, "Zul'rajas");
            storms[stormsIndex] = sam;

            Pupil mezil = new Pupil("Mezil-kree", "touie");
            stormsIndex++;
            storms[stormsIndex] = mezil.CastWindStorm();
            // Console.WriteLine(mezil.Origin);


            Mage m = new Mage("Gul'dan");
            stormsIndex++;
            storms[stormsIndex] = m.CastRainStorm();

            Archmage a = new Archmage("Nielas Aran");

            stormsIndex++;
            storms[stormsIndex] = a.CastRainStorm();

            stormsIndex++;
            storms[stormsIndex] = a.CastLightningStorm();

            for (int i = 0; i <= stormsIndex; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }

        }
    }
}
