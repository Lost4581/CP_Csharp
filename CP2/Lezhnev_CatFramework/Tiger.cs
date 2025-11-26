using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezhnev_CatFramework
{
    public class Tiger : Cat
    {
        private readonly double _weight;
        private readonly int _fluffiness;

        public double Weight => _weight;
        public override int Fluffiness => _fluffiness;

        public Tiger(double weight, int fluffiness = 50)
        {
            if (weight < 75.0 || weight > 140.0)
            {
                throw new CatException($"Unable to create a tiger with weight: {weight}");
            }

            if (fluffiness < 0 || fluffiness > 100)
            {
                throw new CatException($"Unable to create a tiger with fluffiness: {fluffiness}");
            }

            if ((weight < 75.0 || weight > 140.0) && (fluffiness < 0 || fluffiness > 100))
            {
                throw new CatException($"Unable to create a tiger with weight: {weight}, and fluffiness: {fluffiness}");
            }

            _weight = weight;
            _fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            return "Kycb!";
        }

        public override string ToString()
        {
            return $"A tiger with weight: {Weight}, fluffiness: {Fluffiness}";
        }
    }
}
